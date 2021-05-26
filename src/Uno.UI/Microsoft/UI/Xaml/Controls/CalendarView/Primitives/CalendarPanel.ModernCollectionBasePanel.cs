﻿#nullable enable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Windows.Foundation;
using Windows.UI.Core;
using Uno;
using Uno.Extensions;
using Uno.Extensions.Specialized;
using Uno.UI;

namespace Windows.UI.Xaml.Controls.Primitives
{
	// This file is aimed to implement methods that should be implemented by the ModernCollectionBasePanel which is not present in Uno

	partial class CalendarPanel : ILayoutDataInfoProvider, ICustomScrollInfo
	{
		// The CalendarView has a minimum size of 296x350, any size under this one will trigger clipping
		// TODO: Is this size updated according to accessibility font scale factor?
		private static readonly Size _defaultHardCodedSize = new Size(296, 350 - 78); // 78 px for the header etc.

		// Minimum item/cell size to trigger a full measure pass.
		// Below this threshold, we only make sure to insert the first item in the Children collection to allow valid computation of the DetermineTheBiggestItemSize.
		private static readonly Size _minCellSize = new Size(10, 10);

		private class ContainersCache : IItemContainerMapping
		{
			private readonly List<CacheEntry> _entries = new List<CacheEntry>(31 + 7 * 2); // A month + one week before and after
			private CalendarViewGeneratorHost? _host;

			private int _generationStartIndex = -1;
			private int _generationCurrentIndex = -1;
			private int _generationEndIndex = -1;
			private GenerationState _generationState;
			private (int at, int count) _generationRecyclableBefore;
			private (int at, int count) _generationUnusedInRange;
			private (int at, int count) _generationRecyclableAfter;

			internal CalendarViewGeneratorHost? Host
			{
				get => _host;
				set
				{
					_host = value;
					_entries.Clear();
				}
			}

			internal int FirstIndex { get; private set; } = -1;

			internal int LastIndex { get; private set; } = -1;

			private bool IsInRange(int itemIndex)
				=> itemIndex >= FirstIndex && itemIndex <= LastIndex;

			private int GetEntryIndex(int itemIndex)
				=> itemIndex - FirstIndex;

			private enum GenerationState
			{
				Before,
				InRange,
				After
			}

			internal void BeginGeneration(int startIndex, int endIndex)
			{
				if (_host is null)
				{
					throw new InvalidOperationException("Host not set yet");
				}
				global::System.Diagnostics.Debug.Assert(_generationStartIndex == -1);
				global::System.Diagnostics.Debug.Assert(_generationCurrentIndex == -1);
				global::System.Diagnostics.Debug.Assert(_generationEndIndex == -1);

				_generationStartIndex = startIndex;
				_generationCurrentIndex = startIndex;
				_generationEndIndex = endIndex;
				_generationState = GenerationState.Before;

				// Note: Start and End indexes are INCLUSIVE
				startIndex = Math.Max(FirstIndex, startIndex);
				endIndex = Math.Min(LastIndex, endIndex);

				if (endIndex < 0)
				{
					return; // Cache is empty
				}

				var startEntryIndex = Math.Min(GetEntryIndex(startIndex), _entries.Count);
				var endEntryIndex = Math.Max(0, GetEntryIndex(endIndex) + 1);

				// Since the _generationEndIndex is only an estimation, we might have some items that was not flagged as recyclable which are not going to be not used.
				// The easiest solution is to track them using the _generationUnusedInRange.

				_generationRecyclableBefore = (0, startEntryIndex);
				_generationUnusedInRange = (startEntryIndex, endEntryIndex - startEntryIndex);
				_generationRecyclableAfter = (endEntryIndex, Math.Max(0, _entries.Count - endEntryIndex));

				global::System.Diagnostics.Debug.Assert(
					(_generationRecyclableAfter.at == _entries.Count && _generationRecyclableAfter.count == 0) // Nothing to recycle at the end
					|| (_generationRecyclableAfter.at + _generationRecyclableAfter.count == _entries.Count)); // The last recycle item does exists!
			}

			internal IEnumerable<CacheEntry> CompleteGeneration(int endIndex)
			{
				global::System.Diagnostics.Debug.Assert(_generationCurrentIndex - 1 == endIndex); // endIndex is inclusive while _generationCurrentIndex is the next index to use

				var unusedEntriesCount = _generationRecyclableBefore.count
					+ _generationUnusedInRange.count
					+ _generationRecyclableAfter.count;

				IEnumerable<CacheEntry> unusedEntries;
				if (unusedEntriesCount > 0)
				{
					var removedEntries = new CacheEntry[unusedEntriesCount];
					var removed = 0;

					// We need to process from the end to the begin in order to not alter indexes:
					// ..Recycled..Recyclable-Head..In-Range..Unexpected-Remaining-Items..Recyclable-Tail..Recycled..

					if (_generationRecyclableAfter.count > 0)
					{
						_entries.CopyTo(_generationRecyclableAfter.at, removedEntries, removed, _generationRecyclableAfter.count);
						_entries.RemoveRange(_generationRecyclableAfter.at, _generationRecyclableAfter.count); //TODO: Move to a second recycling stage instead of throwing them away.

						removed += _generationRecyclableAfter.count;
					}

					if (_generationUnusedInRange.count > 0)
					{
						_entries.CopyTo(_generationUnusedInRange.at, removedEntries, removed, _generationUnusedInRange.count);
						_entries.RemoveRange(_generationUnusedInRange.at, _generationUnusedInRange.count); //TODO: Move to a second recycling stage instead of throwing them away.

						removed += _generationUnusedInRange.count;
					}

					if (_generationRecyclableBefore.count > 0)
					{
						_entries.CopyTo(_generationRecyclableBefore.at, removedEntries, removed, _generationRecyclableBefore.count);
						_entries.RemoveRange(_generationRecyclableBefore.at, _generationRecyclableBefore.count); //TODO: Move to a second recycling stage instead of throwing them away.

						removed += _generationRecyclableBefore.count;
					}

					global::System.Diagnostics.Debug.Assert(removed == unusedEntriesCount);

					unusedEntries = removedEntries;
				}
				else
				{
					unusedEntries = Enumerable.Empty<CacheEntry>();
				}

				_entries.Sort(CacheEntryComparer.Instance);

				FirstIndex = _entries[0].Index;
				LastIndex = _entries[_entries.Count - 1].Index;

				global::System.Diagnostics.Debug.Assert(_generationStartIndex == FirstIndex);
				global::System.Diagnostics.Debug.Assert(endIndex == LastIndex);
				global::System.Diagnostics.Debug.Assert(FirstIndex + _entries.Count - 1 == LastIndex);
				global::System.Diagnostics.Debug.Assert(_entries.Skip(1).Select((e, i) => _entries[i].Index + 1 == e.Index).AllTrue());

				_generationStartIndex = -1;
				_generationCurrentIndex = -1;
				_generationEndIndex = -1;

				return unusedEntries;
			}

			internal (CacheEntry entry, CacheEntryKind kind) GetOrCreate(int index)
			{
				global::System.Diagnostics.Debug.Assert(_host is { });
				global::System.Diagnostics.Debug.Assert(_generationStartIndex <= index);
				global::System.Diagnostics.Debug.Assert(_generationCurrentIndex == index);
				// We do not validate global::System.Diagnostics.Debug.Assert(_generationEndIndex >= index); as the generationEndIndex is only an estimate

				_generationCurrentIndex++;

				switch (_generationState)
				{
					case GenerationState.Before when index >= FirstIndex:
						if (index > LastIndex)
						{
							_generationState = GenerationState.After;
							goto after;
						}
						else
						{
							_generationState = GenerationState.InRange;
							goto inRange;
						}
					case GenerationState.InRange when index > LastIndex
						|| GetEntryIndex(index) >= _generationRecyclableAfter.at + _generationRecyclableAfter.count: // Unfortunately we had already recycled that container, we need to create a new one!
						_generationState = GenerationState.After;
						goto after;

					case GenerationState.InRange:
					inRange:
					{
						var entryIndex = GetEntryIndex(index);
						var entry = _entries[entryIndex];

						if (entryIndex == _generationRecyclableAfter.at && _generationRecyclableAfter.count > 0)
						{
							// Finally a container which was eligible for recycling is still valid ... we saved it in extremis!
							_generationRecyclableAfter.at++;
							_generationRecyclableAfter.count--;
						}
						else
						{
							_generationUnusedInRange.at++;
							_generationUnusedInRange.count--;
						}

						global::System.Diagnostics.Debug.Assert(entry.Index == index);

						return (entry, CacheEntryKind.Kept);
					}

					case GenerationState.Before:
					case GenerationState.After:
					after:
					{
						var item = _host![index];

						CacheEntry entry;
						CacheEntryKind kind;
						if (_generationRecyclableBefore.count > 0)
						{
							entry = _entries[_generationRecyclableBefore.at];
							kind = CacheEntryKind.Recycled;

							_generationRecyclableBefore.at++;
							_generationRecyclableBefore.count--;
						}
						else if (_generationRecyclableAfter.count > 0)
						{
							entry = _entries[_generationRecyclableAfter.at + _generationRecyclableAfter.count - 1];
							kind = CacheEntryKind.Recycled;

							_generationRecyclableAfter.count--;

							global::System.Diagnostics.Debug.Assert(entry.Index > index);
						}
						else
						{
							var container = (UIElement)_host.GetContainerForItem(item, null);
							entry = new CacheEntry(container);
							kind = CacheEntryKind.New;

							_entries.Add(entry);
						}

						entry.Index = index;
						entry.Item = item;

						_host.PrepareItemContainer(entry.Container, item);

						return (entry, kind);
					}
				}

				throw new InvalidOperationException("Non reachable case.");
			}

			/// <inheritdoc />
			public object? ItemFromContainer(DependencyObject container)
				=> container is UIElement elt ? _entries.Find(e => e.Container == elt)?.Container : default;

			/// <inheritdoc />
			public DependencyObject? ContainerFromItem(object item)
				=> _entries.Find(e => e.Item == item)?.Container;

			/// <inheritdoc />
			public int IndexFromContainer(DependencyObject container)
				=> container is UIElement elt ? _entries.Find(e => e.Container == elt)?.Index ?? -1 : -1;

			/// <inheritdoc />
			public DependencyObject? ContainerFromIndex(int index)
				=> index >= 0 && IsInRange(index) ? _entries[GetEntryIndex(index)].Container : default;
		}

		private class CacheEntry
		{
			public CacheEntry(UIElement container)
			{
				Container = container;
			}

			public UIElement Container { get; }

			public int Index { get; set; }

			public object? Item { get; set; }
		}

		private class CacheEntryComparer : IComparer<CacheEntry>
		{
			public static CacheEntryComparer Instance { get; } = new CacheEntryComparer();
			public int Compare(CacheEntry x, CacheEntry y) => x.Index.CompareTo(y.Index);
		}

		private enum CacheEntryKind
		{
			New,
			Kept,
			Recycled
		}

		internal event VisibleIndicesUpdatedEventCallback VisibleIndicesUpdated;

		private readonly ContainersCache _cache = new ContainersCache();
		private CalendarLayoutStrategy? _layoutStrategy;
		private CalendarViewGeneratorHost? _host;
		private Rect _effectiveViewport;
		private Rect _lastLayoutedViewport = Rect.Empty;

		private void base_Initialize()
		{
			ContainerManager = new ContainerManager(this);
			VerticalAlignment = VerticalAlignment.Top;
			HorizontalAlignment = HorizontalAlignment.Left;
			EffectiveViewportChanged += OnEffectiveViewportChanged;
		}


		/// <inheritdoc />
		public double? ViewportWidth { get; private set; }

		/// <inheritdoc />
		public double? ViewportHeight { get; private set; }

		#region Private and internal API required by UWP code
		internal int FirstVisibleIndexBase { get; private set; } = -1;
		internal int LastVisibleIndexBase { get; private set; } = -1;
		internal int FirstCacheIndexBase => _cache.FirstIndex;
		internal int LastCacheIndexBase => _cache.LastIndex;

		[NotImplemented]
		internal PanelScrollingDirection PanningDirectionBase { get; } = PanelScrollingDirection.None;

		internal ILayoutStrategy? LayoutStrategy => _layoutStrategy;

		internal double CacheLengthBase { get; set; }

		internal ContainerManager ContainerManager { get; private set; }

		internal void RegisterItemsHost(CalendarViewGeneratorHost? pHost)
		{
			_host = pHost;
			_cache.Host = pHost;
			Children.Clear();
			ContainerManager.Host = pHost;
		}

		internal void DisconnectItemsHost()
			=> RegisterItemsHost(null);

		internal DependencyObject? ContainerFromIndex(int index)
			=> _cache.ContainerFromIndex(index);

		internal void ScrollItemIntoView(int index, ScrollIntoViewAlignment alignment, double offset, bool forceSynchronous)
		{
			if (_layoutStrategy is null)
			{
				return;
			}

			_layoutStrategy.EstimateElementBounds(ElementType.ItemContainer, index, default, default, default, out var bounds);

			if (Owner?.ScrollViewer is { } sv)
			{
				var newOffset = bounds.Y + offset;

				// When we navigate between decade/month/year views, the CalendarView_Partial_Interaction.FocusItem
				// will set the date which will invoke this ScrollItemIntoView method,
				// then it will request GetContainerFromIndex and tries to focus it.
				// So here we prepare the _effectiveViewport (which will most probably be re-updated by the ChangeView below),
				// and then force a base_Measure()
				_effectiveViewport.Y += newOffset - sv.VerticalOffset;

				sv.ChangeView(
					horizontalOffset: null,
					verticalOffset: newOffset,
					zoomFactor: null,
					forceSynchronous);

				// Makes sure the container of the requested date is materialized before the end of this method
				base_MeasureOverride(_lastLayoutedViewport.Size);
			}
		}

		private Size GetViewportSize()
			=> _lastLayoutedViewport.Size.AtLeast(_defaultHardCodedSize).FiniteOrDefault(_defaultHardCodedSize);

		internal Size GetDesiredViewportSize()
			=> _layoutStrategy?.GetDesiredViewportSize() ?? default;

		[NotImplemented]
		internal void GetTargetIndexFromNavigationAction(
			int focusedIndex,
			ElementType elementType,
			KeyNavigationAction action,
			object o,
			int i,
			out uint newFocusedIndexUint,
			out ElementType newFocusedType,
			out bool actionValidForSourceIndex)
		{
			newFocusedIndexUint = (uint)focusedIndex;
			newFocusedType = elementType;
			actionValidForSourceIndex = true;
		}

		internal IItemContainerMapping GetItemContainerMapping()
			=> _cache;

		private void SetLayoutStrategyBase(CalendarLayoutStrategy spLayoutStrategy)
		{
			_layoutStrategy = spLayoutStrategy;
			spLayoutStrategy.LayoutDataInfoProvider = this;
		}

		private void CacheFirstVisibleElementBeforeOrientationChange()
		{
		}

		private void ProcessOrientationChange()
		{
		}

		/// <inheritdoc />
		int ILayoutDataInfoProvider.GetTotalItemCount()
			=> ContainerManager.TotalItemsCount;

		/// <inheritdoc />
		int ILayoutDataInfoProvider.GetTotalGroupCount()
			=> ContainerManager.TotalGroupCount;
		#endregion

		#region Panel / base class (i.e. ModernCollectionBasePanel) implementation (Measure/Arrange)
		private Rect GetLayoutViewport(Size availableSize = default)
		{
			if (_host is null)
			{
				return default;
			}

			// Compute the effective viewport of the panel (i.e. the portion of the panel for which we have to generate items)
			// By default, if the CalendarView is not stretch, it will render at its default hardcoded size.
			// It will also never be smaller than this hardcoded size (content will clipped)
			// Note: If the Calendar has a defined size (or min / max) we ignore it in Measure, and we wait for the Arrange to "force" us to apply it.

			var calendar = _host.Owner;
			var viewport = new Rect(
				_effectiveViewport.Location.FiniteOrDefault(default),
				_effectiveViewport.Size.AtLeast(availableSize).AtLeast(_defaultHardCodedSize).FiniteOrDefault(_defaultHardCodedSize));
			if (calendar.HorizontalAlignment != HorizontalAlignment.Stretch)
			{
				viewport.Width = _defaultHardCodedSize.Width;
			}
			if (calendar.VerticalAlignment != VerticalAlignment.Stretch)
			{
				viewport.Height = _defaultHardCodedSize.Height;
			}

			return viewport;
		}

		private Size base_MeasureOverride(Size availableSize)
		{
			if (_host is null || _layoutStrategy is null)
			{
				return default;
			}

			var viewport = GetLayoutViewport(availableSize);

			_layoutStrategy.BeginMeasure();
#if __ANDROID__ // TODO: IOS
			using var a = PreventRequestLayout();
#else
			ShouldInterceptInvalidate = true;
#endif
			var index = -1;
			try
			{
				// Gets the index of the first element to render and the actual viewport to use
				_layoutStrategy.EstimateElementIndex(ElementType.ItemContainer, default, default, viewport, out var renderWindow, out var startIndex);
				renderWindow.Size = viewport.Size; // The actualViewport contains only position information

				// We request to the algo to render an extra row before and after the actual viewport
				if (Rows > 0) // This can occur on first measure when we only determine the biggest item size
				{
					var pixelsPerRow = viewport.Height / Rows;
					renderWindow.Y = Math.Max(0, renderWindow.Y - pixelsPerRow);
					renderWindow.Height = renderWindow.Height + (2 * pixelsPerRow);
				}

				// Prepare the items generator to generate some new items (will also set which items can be recycled in this measure pass).
				var expectedItemsCount = LastVisibleIndex - FirstVisibleIndex;
				_cache.BeginGeneration(startIndex, startIndex + expectedItemsCount);

				index = startIndex;
				int firstVisibleIndex = -1, lastVisibleIndex = -1;
				var count = _host.Count;
				var layout = new LayoutReference { RelativeLocation = ReferenceIdentity.Myself };
				var currentLine = (y: double.MinValue, col: 0);

				while (
					index < count
					&&
						// _layoutStrategy.ShouldContinueFillingUpSpace behaves weirdly, so we prefer to just check the bounds of the last measured element
						// First we continue until we reach the last line, then we make sure to complete those line.
						(layout.ReferenceBounds.Bottom < renderWindow.Bottom || currentLine.col < Cols)
					)
				{
					var (entry, kind) = _cache.GetOrCreate(index);
					if (kind == CacheEntryKind.New)
					{
						Children.Add(entry.Container);
					}

					var itemSize = _layoutStrategy.GetElementMeasureSize(ElementType.ItemContainer, index, renderWindow); // Note: It's actually the same for all items
					var itemBounds = _layoutStrategy.GetElementBounds(ElementType.ItemContainer, index, itemSize, layout, renderWindow);

					if (itemSize.Width < _minCellSize.Width && itemSize.Height < _minCellSize.Height)
					{
						// We don't have any valid cell size yet (This measure pass has been caused by DetermineTheBiggestItemSize),
						// so we stop right after having inserted the first child in the Children collection.
						index++;
						return _defaultHardCodedSize;
					}

					entry.Container.Measure(itemSize);
					entry.Container.GetVirtualizationInformation().MeasureSize = itemSize;
					switch (kind)
					{
						case CacheEntryKind.New:
							_host.SetupContainerContentChangingAfterPrepare(entry.Container, entry.Item, entry.Index, itemSize);
							break;

						case CacheEntryKind.Recycled:
							// Note: ModernBasePanel seems to use only SetupContainerContentChangingAfterPrepare
							_host.RaiseContainerContentChangingOnRecycle(entry.Container, entry.Item);
							break;
					}

					var isVisible = itemBounds.IsIntersecting(viewport);
					if (firstVisibleIndex == -1 && isVisible)
					{
						firstVisibleIndex = index;
						lastVisibleIndex = index;
					}
					else if (isVisible)
					{
						lastVisibleIndex = index;
					}

					layout.RelativeLocation = ReferenceIdentity.AfterMe;
					layout.ReferenceBounds = itemBounds;

					if (currentLine.y < itemBounds.Y)
					{
						currentLine = (itemBounds.Y, 1);
					}
					else
					{
						currentLine.col++;
					}

					index++;
				}
				
				StartIndex = 0;
				FirstVisibleIndexBase = Math.Max(firstVisibleIndex, startIndex);
				LastVisibleIndexBase = Math.Max(FirstVisibleIndexBase, lastVisibleIndex);
				_lastLayoutedViewport = viewport;
			}
			finally
			{
				foreach (var unusedEntry in _cache.CompleteGeneration(index - 1))
				{
					Children.Remove(unusedEntry.Container);
				}

				global::System.Diagnostics.Debug.Assert(_cache.FirstIndex <= FirstVisibleIndex || FirstVisibleIndex == -1);
				global::System.Diagnostics.Debug.Assert(_cache.LastIndex >= LastVisibleIndex || LastVisibleIndex == -1);
				global::System.Diagnostics.Debug.Assert(Children.Count == _cache.LastIndex - _cache.FirstIndex + 1 || (_cache.LastIndex == -1 && _cache.LastIndex == -1));

				// We force the parent ScrollViewer to use the same viewport as us, no matter its own stretching.
				ViewportHeight = viewport.Height;

#if !__ANDROID__
				ShouldInterceptInvalidate = false;
#endif
				_layoutStrategy.EndMeasure();
			}

			VisibleIndicesUpdated?.Invoke(this, null);

			_layoutStrategy.EstimatePanelExtent(
				default /* not used by CalendarLayoutStrategyImpl */,
				default /* not used by CalendarLayoutStrategyImpl */,
				default /* not used by CalendarLayoutStrategyImpl */,
				out var desiredSize);

			return desiredSize;
		}

		private Size base_ArrangeOverride(Size finalSize)
		{
			if (_host is null || _layoutStrategy is null)
			{
				return default;
			}

			var layout = new LayoutReference(); // Empty layout which will actually drive the ShouldContinueFillingUpSpace to always return true
			var window = new Rect(default, finalSize);

			global::System.Diagnostics.Debug.Assert(Children.Count == _cache.LastIndex - _cache.FirstIndex + 1 || (_cache.LastIndex == -1 && _cache.LastIndex == -1));

			foreach (var child in Children)
			{
				var index = _cache.IndexFromContainer(child);
				var bounds = _layoutStrategy.GetElementBounds(ElementType.ItemContainer, index, child.DesiredSize, layout, window);

				//TODO _layoutStrategy.GetElementArrangeBounds()

				child.Arrange(bounds);
				child.GetVirtualizationInformation().Bounds = bounds;
			}

			return finalSize;
		}
#endregion

		private static void OnEffectiveViewportChanged(FrameworkElement sender, EffectiveViewportChangedEventArgs args)
		{
			if (sender is CalendarPanel that)
			{
				that._effectiveViewport = args.EffectiveViewport;

				if (that._host is null || that._layoutStrategy is null)
				{
					return;
				}

				// Uno: This SetViewportSize should be done in the CalendarPanel_Partial.ArrangeOverride of the Panel (not the 'base_'),
				// but (due to invalid layouting event sequence in uno?) it would cause a second layout pass.
				// Also on Android in Year and Decade views, the Arrange would never be invoked if the CellSize is not defined ...
				// which is actually set **ONLY** by this SetViewport for Year and Decade host
				// (We bypass the SetItemMinimumSize in the CalendarPanel_Partial.MeasureOverride if m_type is **not** CalendarPanelType.Primary)
				that._layoutStrategy.SetViewportSize(that.GetLayoutViewport().Size, out var needsMeasure);

				if (needsMeasure || Math.Abs(that._effectiveViewport.Y - that._lastLayoutedViewport.Y) > (that._lastLayoutedViewport.Height / that.Rows) * .75)
				{
					that.InvalidateMeasure();
				}
			}
		}
	}

	internal class ContainerManager
	{
		// Required properties from WinUI code
		public int StartOfContainerVisualSection() => Math.Max(0, _owner.FirstVisibleIndex);

		public int TotalItemsCount => Host?.Count ?? 0;

		public int TotalGroupCount = 0;

		// Uno only
		private readonly CalendarPanel _owner;

		public CalendarViewGeneratorHost? Host { get; set; }

		public ContainerManager(CalendarPanel owner)
		{
			_owner = owner;
		}
	}
}
