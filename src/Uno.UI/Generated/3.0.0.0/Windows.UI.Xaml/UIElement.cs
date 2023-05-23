#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class UIElement : global::Windows.UI.Composition.IAnimationObject,global::Windows.UI.Composition.IVisualElement
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Media.Projection Projection
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Projection)this.GetValue(ProjectionProperty);
			}
			set
			{
				this.SetValue(ProjectionProperty, value);
			}
		}
		#endif
		// Skipping already declared property ManipulationMode
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsTapEnabled
		{
			get
			{
				return (bool)this.GetValue(IsTapEnabledProperty);
			}
			set
			{
				this.SetValue(IsTapEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsRightTapEnabled
		{
			get
			{
				return (bool)this.GetValue(IsRightTapEnabledProperty);
			}
			set
			{
				this.SetValue(IsRightTapEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsHoldingEnabled
		{
			get
			{
				return (bool)this.GetValue(IsHoldingEnabledProperty);
			}
			set
			{
				this.SetValue(IsHoldingEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsDoubleTapEnabled
		{
			get
			{
				return (bool)this.GetValue(IsDoubleTapEnabledProperty);
			}
			set
			{
				this.SetValue(IsDoubleTapEnabledProperty, value);
			}
		}
		#endif
		// Skipping already declared property AllowDrop
		// Skipping already declared property Clip
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Media.CacheMode CacheMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.CacheMode)this.GetValue(CacheModeProperty);
			}
			set
			{
				this.SetValue(CacheModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool UseLayoutRounding
		{
			get
			{
				return (bool)this.GetValue(UseLayoutRoundingProperty);
			}
			set
			{
				this.SetValue(UseLayoutRoundingProperty, value);
			}
		}
		#endif
		#if false || false || false || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__NETSTD_REFERENCE__")]
		public  global::Windows.Foundation.Size DesiredSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member Size UIElement.DesiredSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Size%20UIElement.DesiredSize");
			}
		}
		#endif
		// Skipping already declared property PointerCaptures
		#if false || false || false || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__NETSTD_REFERENCE__")]
		public  global::Windows.Foundation.Size RenderSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member Size UIElement.RenderSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Size%20UIElement.RenderSize");
			}
		}
		#endif
		// Skipping already declared property XamlRoot
		// Skipping already declared property Shadow
		// Skipping already declared property ActualOffset
		// Skipping already declared property ActualSize
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.UIContext UIContext
		{
			get
			{
				throw new global::System.NotImplementedException("The member UIContext UIElement.UIContext is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=UIContext%20UIElement.UIContext");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Media.ElementCompositeMode CompositeMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.ElementCompositeMode)this.GetValue(CompositeModeProperty);
			}
			set
			{
				this.SetValue(CompositeModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Media.Media3D.Transform3D Transform3D
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Media3D.Transform3D)this.GetValue(Transform3DProperty);
			}
			set
			{
				this.SetValue(Transform3DProperty, value);
			}
		}
		#endif
		// Skipping already declared property CanDrag
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsAccessKeyScope
		{
			get
			{
				return (bool)this.GetValue(IsAccessKeyScopeProperty);
			}
			set
			{
				this.SetValue(IsAccessKeyScopeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool ExitDisplayModeOnAccessKeyInvoked
		{
			get
			{
				return (bool)this.GetValue(ExitDisplayModeOnAccessKeyInvokedProperty);
			}
			set
			{
				this.SetValue(ExitDisplayModeOnAccessKeyInvokedProperty, value);
			}
		}
		#endif
		// Skipping already declared property ContextFlyout
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.DependencyObject AccessKeyScopeOwner
		{
			get
			{
				return (global::Windows.UI.Xaml.DependencyObject)this.GetValue(AccessKeyScopeOwnerProperty);
			}
			set
			{
				this.SetValue(AccessKeyScopeOwnerProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string AccessKey
		{
			get
			{
				return (string)this.GetValue(AccessKeyProperty);
			}
			set
			{
				this.SetValue(AccessKeyProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double KeyTipHorizontalOffset
		{
			get
			{
				return (double)this.GetValue(KeyTipHorizontalOffsetProperty);
			}
			set
			{
				this.SetValue(KeyTipHorizontalOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.ElementHighContrastAdjustment HighContrastAdjustment
		{
			get
			{
				return (global::Windows.UI.Xaml.ElementHighContrastAdjustment)this.GetValue(HighContrastAdjustmentProperty);
			}
			set
			{
				this.SetValue(HighContrastAdjustmentProperty, value);
			}
		}
		#endif
		// Skipping already declared property XYFocusRightNavigationStrategy
		// Skipping already declared property XYFocusKeyboardNavigation
		// Skipping already declared property XYFocusDownNavigationStrategy
		// Skipping already declared property TabFocusNavigation
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double KeyTipVerticalOffset
		{
			get
			{
				return (double)this.GetValue(KeyTipVerticalOffsetProperty);
			}
			set
			{
				this.SetValue(KeyTipVerticalOffsetProperty, value);
			}
		}
		#endif
		// Skipping already declared property XYFocusUpNavigationStrategy
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Input.KeyTipPlacementMode KeyTipPlacementMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Input.KeyTipPlacementMode)this.GetValue(KeyTipPlacementModeProperty);
			}
			set
			{
				this.SetValue(KeyTipPlacementModeProperty, value);
			}
		}
		#endif
		// Skipping already declared property XYFocusLeftNavigationStrategy
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Media.XamlLight> Lights
		{
			get
			{
				return (global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Media.XamlLight>)this.GetValue(LightsProperty);
			}
		}
		#endif
		// Skipping already declared property KeyboardAccelerators
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.DependencyObject KeyboardAcceleratorPlacementTarget
		{
			get
			{
				return (global::Windows.UI.Xaml.DependencyObject)this.GetValue(KeyboardAcceleratorPlacementTargetProperty);
			}
			set
			{
				this.SetValue(KeyboardAcceleratorPlacementTargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Input.KeyboardAcceleratorPlacementMode KeyboardAcceleratorPlacementMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Input.KeyboardAcceleratorPlacementMode)this.GetValue(KeyboardAcceleratorPlacementModeProperty);
			}
			set
			{
				this.SetValue(KeyboardAcceleratorPlacementModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.DependencyObject KeyTipTarget
		{
			get
			{
				return (global::Windows.UI.Xaml.DependencyObject)this.GetValue(KeyTipTargetProperty);
			}
			set
			{
				this.SetValue(KeyTipTargetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Vector3Transition TranslationTransition
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3Transition UIElement.TranslationTransition is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Vector3Transition%20UIElement.TranslationTransition");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "Vector3Transition UIElement.TranslationTransition");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.ScalarTransition OpacityTransition
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScalarTransition UIElement.OpacityTransition is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ScalarTransition%20UIElement.OpacityTransition");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "ScalarTransition UIElement.OpacityTransition");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Matrix4x4 TransformMatrix
		{
			get
			{
				throw new global::System.NotImplementedException("The member Matrix4x4 UIElement.TransformMatrix is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Matrix4x4%20UIElement.TransformMatrix");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "Matrix4x4 UIElement.TransformMatrix");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.Vector3Transition ScaleTransition
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3Transition UIElement.ScaleTransition is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Vector3Transition%20UIElement.ScaleTransition");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "Vector3Transition UIElement.ScaleTransition");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector3 Scale
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 UIElement.Scale is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Vector3%20UIElement.Scale");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "Vector3 UIElement.Scale");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Xaml.ScalarTransition RotationTransition
		{
			get
			{
				throw new global::System.NotImplementedException("The member ScalarTransition UIElement.RotationTransition is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ScalarTransition%20UIElement.RotationTransition");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "ScalarTransition UIElement.RotationTransition");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector3 RotationAxis
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 UIElement.RotationAxis is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Vector3%20UIElement.RotationAxis");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "Vector3 UIElement.RotationAxis");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float Rotation
		{
			get
			{
				throw new global::System.NotImplementedException("The member float UIElement.Rotation is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=float%20UIElement.Rotation");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "float UIElement.Rotation");
			}
		}
		#endif
		// Skipping already declared property Translation
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Numerics.Vector3 CenterPoint
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector3 UIElement.CenterPoint is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Vector3%20UIElement.CenterPoint");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "Vector3 UIElement.CenterPoint");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool CanBeScrollAnchor
		{
			get
			{
				return (bool)this.GetValue(CanBeScrollAnchorProperty);
			}
			set
			{
				this.SetValue(CanBeScrollAnchorProperty, value);
			}
		}
		#endif
		// Skipping already declared property HoldingEvent
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IsDoubleTapEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IsDoubleTapEnabled), typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IsHoldingEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IsHoldingEnabled), typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IsRightTapEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IsRightTapEnabled), typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared property KeyDownEvent
		// Skipping already declared property KeyUpEvent
		// Skipping already declared property ManipulationCompletedEvent
		// Skipping already declared property ManipulationDeltaEvent
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IsTapEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IsTapEnabled), typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared property ManipulationInertiaStartingEvent
		// Skipping already declared property ManipulationModeProperty
		// Skipping already declared property ManipulationStartedEvent
		// Skipping already declared property ManipulationStartingEvent
		// Skipping already declared property PointerCanceledEvent
		// Skipping already declared property PointerCaptureLostEvent
		// Skipping already declared property PointerCapturesProperty
		// Skipping already declared property PointerEnteredEvent
		// Skipping already declared property PointerExitedEvent
		// Skipping already declared property PointerMovedEvent
		// Skipping already declared property PointerPressedEvent
		// Skipping already declared property PointerWheelChangedEvent
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ProjectionProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Projection), typeof(global::Windows.UI.Xaml.Media.Projection), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Projection)));
		#endif
		// Skipping already declared property RightTappedEvent
		// Skipping already declared property DragEnterEvent
		// Skipping already declared property TappedEvent
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty UseLayoutRoundingProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(UseLayoutRounding), typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared property AllowDropProperty
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty CacheModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(CacheMode), typeof(global::Windows.UI.Xaml.Media.CacheMode), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.CacheMode)));
		#endif
		// Skipping already declared property ClipProperty
		// Skipping already declared property DoubleTappedEvent
		// Skipping already declared property PointerReleasedEvent
		// Skipping already declared property DragLeaveEvent
		// Skipping already declared property DragOverEvent
		// Skipping already declared property DropEvent
		// Skipping already declared property ShadowProperty
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty CompositeModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(CompositeMode), typeof(global::Windows.UI.Xaml.Media.ElementCompositeMode), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.ElementCompositeMode)));
		#endif
		// Skipping already declared property CanDragProperty
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty Transform3DProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Transform3D), typeof(global::Windows.UI.Xaml.Media.Media3D.Transform3D), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Media3D.Transform3D)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty AccessKeyProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(AccessKey), typeof(string), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty AccessKeyScopeOwnerProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(AccessKeyScopeOwner), typeof(global::Windows.UI.Xaml.DependencyObject), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.DependencyObject)));
		#endif
		// Skipping already declared property ContextFlyoutProperty
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty IsAccessKeyScopeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(IsAccessKeyScope), typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty ExitDisplayModeOnAccessKeyInvokedProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(ExitDisplayModeOnAccessKeyInvoked), typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty HighContrastAdjustmentProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(HighContrastAdjustment), typeof(global::Windows.UI.Xaml.ElementHighContrastAdjustment), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.ElementHighContrastAdjustment)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty KeyTipHorizontalOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(KeyTipHorizontalOffset), typeof(double), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty KeyTipPlacementModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(KeyTipPlacementMode), typeof(global::Windows.UI.Xaml.Input.KeyTipPlacementMode), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Input.KeyTipPlacementMode)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty KeyTipVerticalOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(KeyTipVerticalOffset), typeof(double), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty LightsProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(Lights), typeof(global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Media.XamlLight>), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Media.XamlLight>)));
		#endif
		// Skipping already declared property XYFocusDownNavigationStrategyProperty
		// Skipping already declared property XYFocusKeyboardNavigationProperty
		// Skipping already declared property XYFocusLeftNavigationStrategyProperty
		// Skipping already declared property XYFocusRightNavigationStrategyProperty
		// Skipping already declared property XYFocusUpNavigationStrategyProperty
		// Skipping already declared property TabFocusNavigationProperty
		// Skipping already declared property GettingFocusEvent
		// Skipping already declared property LosingFocusEvent
		// Skipping already declared property NoFocusCandidateFoundEvent
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.RoutedEvent CharacterReceivedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.CharacterReceivedEvent is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=RoutedEvent%20UIElement.CharacterReceivedEvent");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.RoutedEvent PreviewKeyDownEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.PreviewKeyDownEvent is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=RoutedEvent%20UIElement.PreviewKeyDownEvent");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.RoutedEvent PreviewKeyUpEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.PreviewKeyUpEvent is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=RoutedEvent%20UIElement.PreviewKeyUpEvent");
			}
		}
		#endif
		// Skipping already declared property BringIntoViewRequestedEvent
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.RoutedEvent ContextRequestedEvent
		{
			get
			{
				throw new global::System.NotImplementedException("The member RoutedEvent UIElement.ContextRequestedEvent is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=RoutedEvent%20UIElement.ContextRequestedEvent");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty KeyTipTargetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(KeyTipTarget), typeof(global::Windows.UI.Xaml.DependencyObject), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty KeyboardAcceleratorPlacementModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(KeyboardAcceleratorPlacementMode), typeof(global::Windows.UI.Xaml.Input.KeyboardAcceleratorPlacementMode), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Input.KeyboardAcceleratorPlacementMode)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty KeyboardAcceleratorPlacementTargetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(KeyboardAcceleratorPlacementTarget), typeof(global::Windows.UI.Xaml.DependencyObject), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.DependencyObject)));
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.UI.Xaml.DependencyProperty CanBeScrollAnchorProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			nameof(CanBeScrollAnchor), typeof(bool), 
			typeof(global::Windows.UI.Xaml.UIElement), 
			new Windows.UI.Xaml.FrameworkPropertyMetadata(default(bool)));
		#endif
		// Forced skipping of method Windows.UI.Xaml.UIElement.DesiredSize.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.AllowDrop.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.AllowDrop.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.Opacity.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Opacity.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.Clip.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Clip.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.RenderTransform.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.RenderTransform.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.Projection.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Projection.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.RenderTransformOrigin.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.RenderTransformOrigin.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsHitTestVisible.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsHitTestVisible.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.Visibility.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Visibility.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.RenderSize.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.UseLayoutRounding.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.UseLayoutRounding.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.Transitions.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Transitions.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.CacheMode.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CacheMode.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsTapEnabled.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsTapEnabled.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsDoubleTapEnabled.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsDoubleTapEnabled.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsRightTapEnabled.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsRightTapEnabled.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsHoldingEnabled.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsHoldingEnabled.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationMode.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationMode.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerCaptures.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyUp.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyUp.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyDown.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyDown.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.GotFocus.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.GotFocus.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.LostFocus.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.LostFocus.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragEnter.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragEnter.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragLeave.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragLeave.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragOver.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragOver.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.Drop.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.Drop.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerPressed.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerPressed.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerMoved.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerMoved.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerReleased.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerReleased.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerEntered.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerEntered.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerExited.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerExited.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerCaptureLost.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerCaptureLost.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerCanceled.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerCanceled.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerWheelChanged.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerWheelChanged.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.Tapped.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.Tapped.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.DoubleTapped.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.DoubleTapped.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.Holding.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.Holding.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.RightTapped.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.RightTapped.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationStarting.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationStarting.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationInertiaStarting.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationInertiaStarting.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationStarted.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationStarted.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationDelta.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationDelta.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationCompleted.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationCompleted.remove
		#if false || false || false || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__NETSTD_REFERENCE__")]
		public  void Measure( global::Windows.Foundation.Size availableSize)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.Measure(Size availableSize)");
		}
		#endif
		#if false || false || false || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__NETSTD_REFERENCE__")]
		public  void Arrange( global::Windows.Foundation.Rect finalRect)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.Arrange(Rect finalRect)");
		}
		#endif
		// Skipping already declared method Windows.UI.Xaml.UIElement.CapturePointer(Windows.UI.Xaml.Input.Pointer)
		// Skipping already declared method Windows.UI.Xaml.UIElement.ReleasePointerCapture(Windows.UI.Xaml.Input.Pointer)
		// Skipping already declared method Windows.UI.Xaml.UIElement.ReleasePointerCaptures()
		// Skipping already declared method Windows.UI.Xaml.UIElement.AddHandler(Windows.UI.Xaml.RoutedEvent, object, bool)
		// Skipping already declared method Windows.UI.Xaml.UIElement.RemoveHandler(Windows.UI.Xaml.RoutedEvent, object)
		// Skipping already declared method Windows.UI.Xaml.UIElement.TransformToVisual(Windows.UI.Xaml.UIElement)
		#if false || false || false || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__NETSTD_REFERENCE__")]
		public  void InvalidateMeasure()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.InvalidateMeasure()");
		}
		#endif
		#if false || false || false || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("__NETSTD_REFERENCE__")]
		public  void InvalidateArrange()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.InvalidateArrange()");
		}
		#endif
		// Skipping already declared method Windows.UI.Xaml.UIElement.UpdateLayout()
		// Forced skipping of method Windows.UI.Xaml.UIElement.CompositeMode.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CompositeMode.set
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool CancelDirectManipulations()
		{
			throw new global::System.NotImplementedException("The member bool UIElement.CancelDirectManipulations() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20UIElement.CancelDirectManipulations%28%29");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.UIElement.Transform3D.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Transform3D.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.CanDrag.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CanDrag.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragStarting.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragStarting.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.DropCompleted.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.DropCompleted.remove
		// Skipping already declared method Windows.UI.Xaml.UIElement.StartDragAsync(Windows.UI.Input.PointerPoint)
		// Forced skipping of method Windows.UI.Xaml.UIElement.ContextFlyout.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ContextFlyout.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.ExitDisplayModeOnAccessKeyInvoked.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ExitDisplayModeOnAccessKeyInvoked.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsAccessKeyScope.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsAccessKeyScope.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyScopeOwner.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyScopeOwner.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKey.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKey.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.ContextRequested.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.ContextRequested.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.ContextCanceled.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.ContextCanceled.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyDisplayRequested.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyDisplayRequested.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyDisplayDismissed.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyDisplayDismissed.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyInvoked.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyInvoked.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.Lights.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipPlacementMode.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipPlacementMode.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipHorizontalOffset.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipHorizontalOffset.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipVerticalOffset.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipVerticalOffset.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusKeyboardNavigation.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusKeyboardNavigation.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusUpNavigationStrategy.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusUpNavigationStrategy.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusDownNavigationStrategy.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusDownNavigationStrategy.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusLeftNavigationStrategy.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusLeftNavigationStrategy.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusRightNavigationStrategy.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusRightNavigationStrategy.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.HighContrastAdjustment.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.HighContrastAdjustment.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.TabFocusNavigation.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.TabFocusNavigation.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.GettingFocus.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.GettingFocus.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.LosingFocus.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.LosingFocus.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.NoFocusCandidateFound.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.NoFocusCandidateFound.remove
		// Skipping already declared method Windows.UI.Xaml.UIElement.StartBringIntoView()
		// Skipping already declared method Windows.UI.Xaml.UIElement.StartBringIntoView(Windows.UI.Xaml.BringIntoViewOptions)
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyboardAccelerators.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CharacterReceived.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.CharacterReceived.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.ProcessKeyboardAccelerators.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.ProcessKeyboardAccelerators.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PreviewKeyDown.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PreviewKeyDown.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.PreviewKeyUp.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.PreviewKeyUp.remove
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void TryInvokeKeyboardAccelerator( global::Windows.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.TryInvokeKeyboardAccelerator(ProcessKeyboardAcceleratorEventArgs args)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipTarget.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipTarget.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementTarget.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementTarget.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementMode.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementMode.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.BringIntoViewRequested.add
		// Forced skipping of method Windows.UI.Xaml.UIElement.BringIntoViewRequested.remove
		// Forced skipping of method Windows.UI.Xaml.UIElement.CanBeScrollAnchor.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CanBeScrollAnchor.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.OpacityTransition.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.OpacityTransition.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.Translation.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Translation.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.TranslationTransition.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.TranslationTransition.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.Rotation.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Rotation.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.RotationTransition.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.RotationTransition.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.Scale.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Scale.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.ScaleTransition.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ScaleTransition.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.TransformMatrix.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.TransformMatrix.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.CenterPoint.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CenterPoint.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.RotationAxis.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.RotationAxis.set
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void StartAnimation( global::Windows.UI.Composition.ICompositionAnimationBase animation)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.StartAnimation(ICompositionAnimationBase animation)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void StopAnimation( global::Windows.UI.Composition.ICompositionAnimationBase animation)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.StopAnimation(ICompositionAnimationBase animation)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.UIElement.ActualOffset.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ActualSize.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XamlRoot.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XamlRoot.set
		// Forced skipping of method Windows.UI.Xaml.UIElement.UIContext.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Shadow.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Shadow.set
		// Skipping already declared method Windows.UI.Xaml.UIElement.OnCreateAutomationPeer()
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected virtual void OnDisconnectVisualChildren()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.OnDisconnectVisualChildren()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected virtual global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<global::Windows.Foundation.Point>> FindSubElementsForTouchTargeting( global::Windows.Foundation.Point point,  global::Windows.Foundation.Rect boundingRect)
		{
			throw new global::System.NotImplementedException("The member IEnumerable<IEnumerable<Point>> UIElement.FindSubElementsForTouchTargeting(Point point, Rect boundingRect) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IEnumerable%3CIEnumerable%3CPoint%3E%3E%20UIElement.FindSubElementsForTouchTargeting%28Point%20point%2C%20Rect%20boundingRect%29");
		}
		#endif
		// Skipping already declared method Windows.UI.Xaml.UIElement.GetChildrenInTabFocusOrder()
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected virtual void OnProcessKeyboardAccelerators( global::Windows.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.OnProcessKeyboardAccelerators(ProcessKeyboardAcceleratorEventArgs args)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected virtual void OnKeyboardAcceleratorInvoked( global::Windows.UI.Xaml.Input.KeyboardAcceleratorInvokedEventArgs args)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.OnKeyboardAcceleratorInvoked(KeyboardAcceleratorInvokedEventArgs args)");
		}
		#endif
		// Skipping already declared method Windows.UI.Xaml.UIElement.OnBringIntoViewRequested(Windows.UI.Xaml.BringIntoViewRequestedEventArgs)
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected virtual void PopulatePropertyInfoOverride( string propertyName,  global::Windows.UI.Composition.AnimationPropertyInfo animationPropertyInfo)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.PopulatePropertyInfoOverride(string propertyName, AnimationPropertyInfo animationPropertyInfo)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void PopulatePropertyInfo( string propertyName,  global::Windows.UI.Composition.AnimationPropertyInfo propertyInfo)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "void UIElement.PopulatePropertyInfo(string propertyName, AnimationPropertyInfo propertyInfo)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.UIElement.ShadowProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CanBeScrollAnchorProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.BringIntoViewRequestedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ContextRequestedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipTargetProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementTargetProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyboardAcceleratorPlacementModeProperty.get
		// Skipping already declared method Windows.UI.Xaml.UIElement.RegisterAsScrollPort(Windows.UI.Xaml.UIElement)
		// Forced skipping of method Windows.UI.Xaml.UIElement.PreviewKeyDownEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CharacterReceivedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PreviewKeyUpEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.GettingFocusEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.LosingFocusEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.NoFocusCandidateFoundEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.LightsProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipPlacementModeProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipHorizontalOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyTipVerticalOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusKeyboardNavigationProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusUpNavigationStrategyProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusDownNavigationStrategyProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusLeftNavigationStrategyProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.XYFocusRightNavigationStrategyProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.HighContrastAdjustmentProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.TabFocusNavigationProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ContextFlyoutProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ExitDisplayModeOnAccessKeyInvokedProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsAccessKeyScopeProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyScopeOwnerProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.AccessKeyProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.Transform3DProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CanDragProperty.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool TryStartDirectManipulation( global::Windows.UI.Xaml.Input.Pointer value)
		{
			throw new global::System.NotImplementedException("The member bool UIElement.TryStartDirectManipulation(Pointer value) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20UIElement.TryStartDirectManipulation%28Pointer%20value%29");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.UIElement.CompositeModeProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyDownEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.KeyUpEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerEnteredEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerPressedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerMovedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerReleasedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerExitedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerCaptureLostEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerCanceledEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerWheelChangedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.TappedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.DoubleTappedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.HoldingEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.RightTappedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationStartingEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationInertiaStartingEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationStartedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationDeltaEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationCompletedEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragEnterEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragLeaveEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.DragOverEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.DropEvent.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.AllowDropProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.OpacityProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ClipProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.RenderTransformProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ProjectionProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.RenderTransformOriginProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsHitTestVisibleProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.VisibilityProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.UseLayoutRoundingProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.TransitionsProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.CacheModeProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsTapEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsDoubleTapEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsRightTapEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.IsHoldingEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.ManipulationModeProperty.get
		// Forced skipping of method Windows.UI.Xaml.UIElement.PointerCapturesProperty.get
		// Skipping already declared event Windows.UI.Xaml.UIElement.DoubleTapped
		// Skipping already declared event Windows.UI.Xaml.UIElement.DragEnter
		// Skipping already declared event Windows.UI.Xaml.UIElement.DragLeave
		// Skipping already declared event Windows.UI.Xaml.UIElement.DragOver
		// Skipping already declared event Windows.UI.Xaml.UIElement.Drop
		// Skipping already declared event Windows.UI.Xaml.UIElement.GotFocus
		// Skipping already declared event Windows.UI.Xaml.UIElement.Holding
		// Skipping already declared event Windows.UI.Xaml.UIElement.KeyDown
		// Skipping already declared event Windows.UI.Xaml.UIElement.KeyUp
		// Skipping already declared event Windows.UI.Xaml.UIElement.LostFocus
		// Skipping already declared event Windows.UI.Xaml.UIElement.ManipulationCompleted
		// Skipping already declared event Windows.UI.Xaml.UIElement.ManipulationDelta
		// Skipping already declared event Windows.UI.Xaml.UIElement.ManipulationInertiaStarting
		// Skipping already declared event Windows.UI.Xaml.UIElement.ManipulationStarted
		// Skipping already declared event Windows.UI.Xaml.UIElement.ManipulationStarting
		// Skipping already declared event Windows.UI.Xaml.UIElement.PointerCanceled
		// Skipping already declared event Windows.UI.Xaml.UIElement.PointerCaptureLost
		// Skipping already declared event Windows.UI.Xaml.UIElement.PointerEntered
		// Skipping already declared event Windows.UI.Xaml.UIElement.PointerExited
		// Skipping already declared event Windows.UI.Xaml.UIElement.PointerMoved
		// Skipping already declared event Windows.UI.Xaml.UIElement.PointerPressed
		// Skipping already declared event Windows.UI.Xaml.UIElement.PointerReleased
		// Skipping already declared event Windows.UI.Xaml.UIElement.PointerWheelChanged
		// Skipping already declared event Windows.UI.Xaml.UIElement.RightTapped
		// Skipping already declared event Windows.UI.Xaml.UIElement.Tapped
		// Skipping already declared event Windows.UI.Xaml.UIElement.DragStarting
		// Skipping already declared event Windows.UI.Xaml.UIElement.DropCompleted
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.Input.AccessKeyDisplayDismissedEventArgs> AccessKeyDisplayDismissed
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyDisplayDismissedEventArgs> UIElement.AccessKeyDisplayDismissed");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyDisplayDismissedEventArgs> UIElement.AccessKeyDisplayDismissed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.Input.AccessKeyDisplayRequestedEventArgs> AccessKeyDisplayRequested
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyDisplayRequestedEventArgs> UIElement.AccessKeyDisplayRequested");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyDisplayRequestedEventArgs> UIElement.AccessKeyDisplayRequested");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs> AccessKeyInvoked
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyInvokedEventArgs> UIElement.AccessKeyInvoked");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, AccessKeyInvokedEventArgs> UIElement.AccessKeyInvoked");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.RoutedEventArgs> ContextCanceled
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, RoutedEventArgs> UIElement.ContextCanceled");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, RoutedEventArgs> UIElement.ContextCanceled");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.Input.ContextRequestedEventArgs> ContextRequested
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, ContextRequestedEventArgs> UIElement.ContextRequested");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, ContextRequestedEventArgs> UIElement.ContextRequested");
			}
		}
		#endif
		// Skipping already declared event Windows.UI.Xaml.UIElement.GettingFocus
		// Skipping already declared event Windows.UI.Xaml.UIElement.LosingFocus
		// Skipping already declared event Windows.UI.Xaml.UIElement.NoFocusCandidateFound
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.Input.CharacterReceivedRoutedEventArgs> CharacterReceived
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, CharacterReceivedRoutedEventArgs> UIElement.CharacterReceived");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, CharacterReceivedRoutedEventArgs> UIElement.CharacterReceived");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.UI.Xaml.Input.KeyEventHandler PreviewKeyDown
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event KeyEventHandler UIElement.PreviewKeyDown");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event KeyEventHandler UIElement.PreviewKeyDown");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.UI.Xaml.Input.KeyEventHandler PreviewKeyUp
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event KeyEventHandler UIElement.PreviewKeyUp");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event KeyEventHandler UIElement.PreviewKeyUp");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.UIElement, global::Windows.UI.Xaml.Input.ProcessKeyboardAcceleratorEventArgs> ProcessKeyboardAccelerators
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, ProcessKeyboardAcceleratorEventArgs> UIElement.ProcessKeyboardAccelerators");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.UIElement", "event TypedEventHandler<UIElement, ProcessKeyboardAcceleratorEventArgs> UIElement.ProcessKeyboardAccelerators");
			}
		}
		#endif
		// Skipping already declared event Windows.UI.Xaml.UIElement.BringIntoViewRequested
		// Processing: Windows.UI.Composition.IAnimationObject
		// Processing: Windows.UI.Composition.IVisualElement
	}
}
