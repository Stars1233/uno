﻿#if __ANDROID__
#nullable enable

using Android.Content;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.UI.Core;
using Uno.UI;

namespace Windows.ApplicationModel.DataTransfer
{
	public static partial class Clipboard
	{
		private const string ClipboardDataLabel = nameof(Clipboard);

		public static void SetContent(DataPackage? content)
		{
			if (content is null)
			{
				throw new ArgumentNullException(nameof(content));
			}

			// Notes:
			// 1. We don't want to change the SetContent signature to async so
			//    async code is run on the CoreDispatcher.
			// 2. All async code is run in the same task to avoid potential threading concerns.
			//    Otherwise, it would be possible to set the OS clipboard data (code at the end)
			//    before one or more of the data formats is ready.
			CoreDispatcher.Main.RunAsync(
				CoreDispatcherPriority.High,
				async () =>
				{
					var data = content?.GetView();

					var items = new List<ClipData.Item>();
					var mimeTypes = new List<string>();

					if (data?.Contains(StandardDataFormats.Text) ?? false)
					{
						var text = await data.GetTextAsync();

						items.Add(new ClipData.Item(text));
						mimeTypes.Add("text/plaintext");
					}

					// UWP has the following standard data formats that correspond with an Android Uri:
					//
					//  1. Uri, now deprecated in favor of:
					//  2. ApplicationLink and
					//  3. WebLink
					//
					// For maximum compatibility with Android all are mapped to Uri. However, only
					// one may be used at a time in the above defined priority. WebLink is
					// considered more specific than ApplicationLink.
					if (data?.Contains(StandardDataFormats.Uri) ?? false)
					{
						var uri = await data.GetUriAsync();
						AddAndroidUri(uri.ToString());
					}
					else if (data?.Contains(StandardDataFormats.WebLink) ?? false)
					{
						var webLink = await data.GetWebLinkAsync();
						AddAndroidUri(webLink.ToString());
					}
					else if (data?.Contains(StandardDataFormats.ApplicationLink) ?? false)
					{
						var appLink = await data.GetApplicationLinkAsync();
						AddAndroidUri(appLink.ToString());
					}

					if (data?.Contains(StandardDataFormats.Html) ?? false)
					{
						var html = await data.GetHtmlFormatAsync();

						// Matches all tags
						Regex regex = new Regex("(<.*?>\\s*)+", RegexOptions.Singleline);
						// Replace tags by spaces and trim
						var plainText = regex.Replace(html, " ").Trim();

						items.Add(new ClipData.Item(plainText, html));
						mimeTypes.Add("text/html");
					}

					// Set all the data formats to the Android clipboard
					if (items.Count > 0)
					{
						ClipData clipData = new ClipData(
							new ClipDescription(ClipboardDataLabel, mimeTypes.ToArray()),
							items[0]);

						for (int itemIndex = 1; itemIndex < items.Count; itemIndex++)
						{
							clipData.AddItem(items[itemIndex]);
						}

						var manager = ContextHelper.Current.GetSystemService(Context.ClipboardService) as ClipboardManager;
						if (manager is null)
						{
							return;
						}
						manager.PrimaryClip = clipData;
					}
					else
					{
						// Clear clipboard
						Clear();
					}

					// Local function to convert a UWP Uri for Android and add it to the items list
					void AddAndroidUri(string uri)
					{
						var androidUri = Android.Net.Uri.Parse(uri);

						items.Add(new ClipData.Item(androidUri));
						mimeTypes.Add("text/uri-list");
					}
				});

			return;
		}

		public static DataPackageView GetContent()
		{
			var dataPackage = new DataPackage();

			var manager = ContextHelper.Current.GetSystemService(Context.ClipboardService) as ClipboardManager;
			if (manager is null)
			{
				return dataPackage.GetView();
			}

			var clipData = manager.PrimaryClip;

			Uri? clipApplicationLink = null;
			string? clipHtml = null;
			string? clipText = null;
			Uri? clipUri = null;
			Uri? clipWebLink = null;

			// Extract all the standard data format information from the clipboard.
			// Each format can only be used once; therefore, the last occurrence of the format will be the one used.
			if (clipData != null)
			{
				for (int itemIndex = 0; itemIndex < clipData.ItemCount; itemIndex++)
				{
					var item = clipData.GetItemAt(itemIndex);

					if (item != null)
					{
						var itemText = item.Text;
						if (itemText != null)
						{
							clipText = itemText;
						}

						// An Android Uri must be specially mapped for UWP as the UWP's direct equivalent 
						// standard data format 'Uri' is deprecated.
						//
						// 1. WebLink is used if the URI has a scheme of http or https 
						// 2. ApplicationLink is used if not #1
						//
						// For full compatibility, Uri is still populated regardless of #1 or #2.
						var itemUri = item.Uri;
						var itemUriStr = itemUri?.ToString();
						if (itemUriStr != null)
						{
							if (itemUriStr.StartsWith("http", StringComparison.InvariantCultureIgnoreCase) ||
								itemUriStr.StartsWith("https", StringComparison.InvariantCultureIgnoreCase))
							{
								clipWebLink = new Uri(itemUriStr);
							}
							else
							{
								clipApplicationLink = new Uri(itemUriStr);
							}

							// Deprecated but added for compatibility
							clipUri = new Uri(itemUriStr);
						}

						var itemHtml = item.HtmlText;
						if (itemText != null)
						{
							clipHtml = itemHtml;
						}
					}
				}
			}

			// Add standard data formats to the data package.
			// This can be done synchronously on Android since the data is already available from above.
			if (clipApplicationLink != null)
			{
				dataPackage.SetApplicationLink(clipApplicationLink);
			}

			if (clipHtml != null)
			{
				dataPackage.SetHtmlFormat(clipHtml);
			}

			if (clipText != null)
			{
				dataPackage.SetText(clipText);
			}

			if (clipUri != null)
			{
				dataPackage.SetUri(clipUri);
			}

			if (clipWebLink != null)
			{
				dataPackage.SetWebLink(clipWebLink);
			}

			return dataPackage.GetView();
		}

		public static void Clear()
		{
			if (ContextHelper.Current.GetSystemService(Context.ClipboardService) is ClipboardManager manager)
			{
				var clipData = ClipData.NewPlainText("", "");
				manager.PrimaryClip = clipData;
			}
		}

		private static void StartContentChanged()
		{
			if (ContextHelper.Current.GetSystemService(Context.ClipboardService) is ClipboardManager manager)
			{
				manager.PrimaryClipChanged += Manager_PrimaryClipChanged;
			}
		}

		private static void StopContentChanged()
		{
			if (ContextHelper.Current.GetSystemService(Context.ClipboardService) is ClipboardManager manager)
			{
				manager.PrimaryClipChanged -= Manager_PrimaryClipChanged;
			}
		}

		private static void Manager_PrimaryClipChanged(object sender, EventArgs e)
		{
			OnContentChanged();
		}
	}
}
#endif
