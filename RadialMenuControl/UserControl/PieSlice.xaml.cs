using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using RadialMenuControl.Components;

namespace RadialMenuControl.UserControl
{
    public sealed partial class PieSlice : Windows.UI.Xaml.Controls.UserControl
    {
        // Inner Arc Colors
        public static readonly DependencyProperty InnerNormalColorProperty =
            DependencyProperty.Register("InnerNormalColor", typeof(Color), typeof(PieSlice), null);

        public static readonly DependencyProperty InnerHoverColorProperty =
            DependencyProperty.Register("InnerHoverColor", typeof(Color), typeof(PieSlice), null);

        public static readonly DependencyProperty InnerTappedColorProperty =
            DependencyProperty.Register("InnerTappedColor", typeof(Color), typeof(PieSlice), null);

        public static readonly DependencyProperty InnerReleasedColorProperty =
            DependencyProperty.Register("InnerReleasedColor", typeof(Color), typeof(PieSlice), null);

        /// <summary>
        /// Hover color for the inner portion of the PieSlice
        /// </summary>
        public Color InnerHoverColor
        {
            get { return (Color)GetValue(InnerHoverColorProperty); }
            set { SetValue(InnerHoverColorProperty, value); }
        }

        /// <summary>
        /// Normal color for the inner portion of the PieSlice
        /// </summary>
        public Color InnerNormalColor
        {
            get { return (Color)GetValue(InnerNormalColorProperty); }
            set { SetValue(InnerNormalColorProperty, value); }
        }

        /// <summary>
        /// Tapped color for the inner portion of the PieSlice
        /// </summary>
        public Color InnerTappedColor
        {
            get { return (Color)GetValue(InnerTappedColorProperty); }
            set { SetValue(InnerTappedColorProperty, value); }
        }

        /// <summary>
        ///  Released color for the inner portion of the PieSlice
        /// </summary>
        public Color InnerReleasedColor
        {
            get { return (Color)GetValue(InnerReleasedColorProperty); }
            set { SetValue(InnerReleasedColorProperty, value); }
        }

        // Outer Arc Colors
        public static readonly DependencyProperty OuterNormalColorProperty =
            DependencyProperty.Register("OuterNormalColor", typeof(Color), typeof(PieSlice), null);

        public static readonly DependencyProperty OuterHoverColorProperty =
            DependencyProperty.Register("OuterHoverColor", typeof(Color), typeof(PieSlice), null);

        public static readonly DependencyProperty OuterTappedColorProperty =
            DependencyProperty.Register("OuterTappedColor", typeof(Color), typeof(PieSlice), null);

        public static readonly DependencyProperty OuterDisabledColorProperty =
            DependencyProperty.Register("OuterDisabledColor", typeof(Color), typeof(PieSlice), null);

        public static readonly DependencyProperty IconImageProperty =
            DependencyProperty.Register("IconImage", typeof(ImageSource), typeof(PieSlice), null);

        public static readonly DependencyProperty IconImageSideLengthProperty =
            DependencyProperty.Register("IconImageSideLength", typeof(ImageSource), typeof(PieSlice), null);

        /// <summary>
        /// Hover color for the outer portion of the PieSlice
        /// </summary>
        public Color OuterHoverColor
        {
            get { return (Color)GetValue(OuterHoverColorProperty); }
            set { SetValue(OuterHoverColorProperty, value); }
        }

        /// <summary>
        /// Normal color for the outer portion of the PieSlice
        /// </summary>
        public Color OuterNormalColor
        {
            get { return (Color)GetValue(OuterNormalColorProperty); }
            set { SetValue(OuterNormalColorProperty, value); }
        }

        /// <summary>
        /// Disabled color for the outer portion of the PieSlice
        /// </summary>
        public Color OuterDisabledColor
        {
            get { return (Color)GetValue(OuterDisabledColorProperty); }
            set { SetValue(OuterDisabledColorProperty, value); }
        }

        /// <summary>
        /// Tapped color for the outer portion of the PieSlice
        /// </summary>
        public Color OuterTappedColor
        {
            get { return (Color)GetValue(OuterTappedColorProperty); }
            set { SetValue(OuterTappedColorProperty, value); }
        }

        // Angles & Radius
        public static readonly DependencyProperty StartAngleProperty =
            DependencyProperty.Register("StartAngle", typeof(double), typeof(PieSlice), null);

        public static readonly DependencyProperty AngleProperty =
            DependencyProperty.Register("Angle", typeof(double), typeof(PieSlice), null);

        public static readonly DependencyProperty RadiusProperty =
            DependencyProperty.Register("Radius", typeof(double), typeof(PieSlice), null);

        /// <summary>
        /// Starting angle of this PieSlice (with 0 being the "north top")
        /// </summary>
        public double StartAngle
        {
            get { return (double)GetValue(StartAngleProperty); }
            set { SetValue(StartAngleProperty, value); }
        }

        /// <summary>
        /// Angle (aka size) of this PieSlice
        /// </summary>
        public double Angle
        {
            get { return (double)GetValue(AngleProperty); }
            set { SetValue(AngleProperty, value); }
        }

        /// <summary>
        /// Radius of the (invisible) full circle used as drawing basis for this PieSlice
        /// </summary>
        public double Radius
        {
            get { return (double)GetValue(RadiusProperty); }
            set { SetValue(RadiusProperty, value); }
        }

        // Label
        public static readonly DependencyProperty IsLabelHiddenProperty =
            DependencyProperty.Register("IsLabelHidden", typeof(bool), typeof(PieSlice), null);

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(PieSlice), null);

        public static readonly DependencyProperty LabelSizeProperty =
            DependencyProperty.Register("LabelSize", typeof(int), typeof(PieSlice), null);

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(string), typeof(PieSlice), null);

        public static readonly DependencyProperty IconForegroundBrushProperty =
            DependencyProperty.Register("IconForegroundBrush", typeof(Brush), typeof(PieSlice), null);

        public static readonly DependencyProperty IconFontFamilyProperty =
            DependencyProperty.Register("IconFontFamily", typeof(FontFamily), typeof(PieSlice), null);

        public static readonly DependencyProperty IconSizeProperty =
            DependencyProperty.Register("IconSize", typeof(int), typeof(PieSlice), null);

        /// <summary>
        /// Text label
        /// </summary>
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        /// <summary>
        /// Font size for the text label
        /// </summary>
        public int LabelSize
        {
            get { return (int)GetValue(LabelSizeProperty); }
            set { SetValue(LabelSizeProperty, value); }
        }

        /// <summary>
        /// Should the label be hidden?
        /// </summary>
        public bool IsLabelHidden
        {
            get { return (bool)GetValue(IsLabelHiddenProperty); }
            set { SetValue(IsLabelHiddenProperty, value); }
        }

        /// <summary>
        /// Icon (string-based), to be used with icon fonts like Segoe Symbol
        /// </summary>
        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        /// <summary>
        /// Foreground brush for the icon, allowing color change for text-based icons
        /// </summary>
        public Brush IconForegroundBrush
        {
            get { return (Brush)GetValue(IconForegroundBrushProperty); }
            set { SetValue(IconForegroundBrushProperty, value); }
        }

        /// <summary>
        /// Font family for the text-based icon
        /// </summary>
        public FontFamily IconFontFamily
        {
            get { return (FontFamily)GetValue(IconFontFamilyProperty); }
            set
            {
                IconTextElement.FontFamily = value;
                SetValue(IconFontFamilyProperty, value);
            }
        }

        /// <summary>
        /// Font size for the text-based icon
        /// </summary>
        public int IconSize
        {
            get { return (int)GetValue(IconSizeProperty); }
            set { SetValue(IconSizeProperty, value); }
        }

        /// <summary>
        /// ImageSource for an image icon - if set, the text-based icon will not be displayed
        /// </summary>
        public ImageSource IconImage
        {
            get { return (ImageSource)GetValue(IconImageProperty); }
            set { SetValue(IconImageProperty, value); }
        }

        /// <summary>
        /// Length of the image-based icon
        /// </summary>
        public double IconImageSideLength
        {
            get { return (double)GetValue(IconImageSideLengthProperty); }
            set { SetValue(IconImageSideLengthProperty, value); }
        }

        /// <summary>
        /// Visibility of the text block - determined by checking whether or not an IconImage is set
        /// </summary>
        public Visibility TextBlockVisibility => IconImage == null ? Visibility.Visible : Visibility.Collapsed;

        public static readonly DependencyProperty OriginalRadialMenuButtonProperty =
            DependencyProperty.Register("OriginalRadialMenuButton", typeof(RadialMenuButton), typeof(PieSlice), null);

        /// <summary>
        /// Reference to the original RadialMenuButton that was used to create this PieSLice
        /// </summary>
        public RadialMenuButton OriginalRadialMenuButton;

        /// <summary>
        /// Delegate for a ChangeMenuRequest, asking the parent RadialMenu to change the menu to a submenu on a button
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="submenu">RadialMenu to change to</param>
        public delegate void ChangeMenuRequestHandler(object sender, MenuBase submenu);
        public event ChangeMenuRequestHandler ChangeMenuRequestEvent;

        /// <summary>
        /// A delegate for the ChangeSelected event, fired whenever a radio or toggle button changes its value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="slice"></param>
        public delegate void ChangeSelectedHandler(object sender, PieSlice slice);
        public event ChangeSelectedHandler ChangeSelectedEvent;


        private void OnChangeMenuRequest(object s, MenuBase sm)
        {
            ChangeMenuRequestEvent?.Invoke(s, sm);
        }

        public PieSlice()
        {
            InitializeComponent();
            DataContext = this;

            Loaded += OnLoaded;
        }

        /// <summary>
        /// Math and drawing operations for the path elements is handled in this OnLoaded event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="routedEventArgs"></param>
        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            // Setup outer arc
            OuterPieSlicePath.Radius = Radius;
            OuterPieSlicePath.StartAngle = StartAngle;
            OuterPieSlicePath.Angle = Angle;
            var middleRadian = (Math.PI / 180) * (StartAngle + (Angle / 2));

            if ((OriginalRadialMenuButton.Submenu == null && OriginalRadialMenuButton.CustomMenu == null)
                && !OriginalRadialMenuButton.HasOuterArcEvents())
            {
                OuterPieSlicePath.Fill = new SolidColorBrush(OuterDisabledColor);
            }
            else
            {
                OuterPieSlicePath.Fill = new SolidColorBrush(OuterNormalColor);
                OuterPieSlicePath.PointerPressed += outerPieSlicePath_PointerPressed;
                OuterPieSlicePath.PointerReleased += outerPieSlicePath_PointerReleased;
                OuterPieSlicePath.PointerEntered += outerPieSlicePath_PointerEntered;
                OuterPieSlicePath.PointerExited += outerPieSlicePath_PointerExited;
                // setup caret
                CaretRotateTransform.Angle = (StartAngle + (Angle / 2));
                CaretTranslate.X = Radius * Math.Sin(middleRadian);
                CaretTranslate.Y = -Radius * Math.Cos(middleRadian);
            }

            // Setup inner arc
            InnerPieSlicePath.Radius = Radius - 20;
            InnerPieSlicePath.StartAngle = StartAngle;
            InnerPieSlicePath.Angle = Angle;
            InnerPieSlicePath.Fill = new SolidColorBrush(InnerNormalColor);

            // Setup icon and text
            IconTranslate.X = 85 * Math.Sin(middleRadian);
            IconTranslate.Y = -85 * Math.Cos(middleRadian);

            // Go to correct visual state
            UpdateSliceForToggle();
            UpdateSliceForRadio();
        }

        /// <summary>
        /// Event handler for a pointer press (mouse, touch, stylus) for on the outer arc of the PieSlice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outerPieSlicePath_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "OuterPressed", true);

            // Check for Submenu & Custom Menu
            if (OriginalRadialMenuButton.Submenu != null)
            {
                OnChangeMenuRequest(OriginalRadialMenuButton, OriginalRadialMenuButton.Submenu);
            }
            else if (OriginalRadialMenuButton.CustomMenu != null)
            {
                OnChangeMenuRequest(OriginalRadialMenuButton, OriginalRadialMenuButton.CustomMenu);
            }

            OriginalRadialMenuButton.OnOuterArcPressed(e);
        }

        /// <summary>
        /// Event handler for a pointer relese (mouse, touch, stylus) on the outer arc of the PieSlice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outerPieSlicePath_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "OuterHover", true);
            OriginalRadialMenuButton.OnOuterArcReleased(e);
        }

        /// <summary>
        /// Event handler for a pointer enter (mouse, touch, stylus) on the outer arc of the PieSlice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outerPieSlicePath_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "OuterHover", true);
        }

        /// <summary>
        /// Event handler for a pointer exit (mouse, touch, stylus) on the outer arc of the PieSlice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outerPieSlicePath_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "OuterNormal", true);
        }

        /// <summary>
        ///  Event handler for a pointer enter (mouse, touch, stylus) on the inner arc of the PieSlice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void innerPieSlicePath_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            switch (OriginalRadialMenuButton.Type)
            {
                case RadialMenuButton.ButtonType.Toggle:
                    VisualStateManager.GoToState(this, (OriginalRadialMenuButton.Value != null && ((bool)OriginalRadialMenuButton.Value)) ? "InnerReleased" : "InnerHover", true);
                    break;
                case RadialMenuButton.ButtonType.Radio:
                    VisualStateManager.GoToState(this, OriginalRadialMenuButton.MenuSelected ? "InnerReleased" : "InnerHover", true);
                    break;
                default:
                    VisualStateManager.GoToState(this, "InnerHover", true);
                    break;
            }
        }

        /// <summary>
        ///  Event handler for a pointer exit (mouse, touch, stylus) on the inner arc of the PieSlice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void innerPieSlicePath_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            switch (OriginalRadialMenuButton.Type)
            {
                case RadialMenuButton.ButtonType.Toggle:
                    UpdateSliceForToggle();
                    break;
                case RadialMenuButton.ButtonType.Radio:
                    UpdateSliceForRadio();
                    break;
                default:
                    VisualStateManager.GoToState(this, "InnerNormal", true);
                    break;
            }
        }

        /// <summary>
        ///  Event handler for a pointer press (mouse, touch, stylus) on the inner arc of the PieSlice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void innerPieSlicePath_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            VisualStateManager.GoToState(this, "InnerPressed", true);
            OriginalRadialMenuButton.OnInnerArcPressed(e);
        }

        /// <summary>
        ///  Event handler for a pointer release (mouse, touch, stylus) on the inner arc of the PieSlice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void innerPieSlicePath_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            OriginalRadialMenuButton.OnInnerArcReleased(e);
            switch (OriginalRadialMenuButton.Type)
            {
                case RadialMenuButton.ButtonType.Toggle:
                    VisualStateManager.GoToState(this, (OriginalRadialMenuButton.Value != null && ((bool)OriginalRadialMenuButton.Value)) ? "InnerReleased" : "InnerNormal", true);
                    break;
                case RadialMenuButton.ButtonType.Radio:
                    VisualStateManager.GoToState(this, "InnerReleased", true);
                    // get all other menus to release now that this menu has been selected
                    ChangeSelectedEvent?.Invoke(sender, this);
                    break;
                default:
                    VisualStateManager.GoToState(this, "InnerNormal", true);
                    break;
            }
        }


        /// <summary>
        /// If the PieSlice has been generated by a "radio" RadialMenuButton, this method ensures the correct visual state
        /// </summary>
        public void UpdateSliceForRadio()
        {
            if (OriginalRadialMenuButton.Type != RadialMenuButton.ButtonType.Radio) return;
            VisualStateManager.GoToState(this, OriginalRadialMenuButton.MenuSelected ? "InnerReleased" : "InnerNormal", true);
        }

        /// <summary>
        /// If the PieSlice has been generated by a "toggle" RadialMenuButton, this method ensures the correct visual state
        /// </summary>
        public void UpdateSliceForToggle()
        {
            if (OriginalRadialMenuButton.Type != RadialMenuButton.ButtonType.Toggle) return;
            VisualStateManager.GoToState(this, (OriginalRadialMenuButton.Value != null && ((bool)OriginalRadialMenuButton.Value)) ? "InnerReleased" : "InnerNormal", true);
        }
    }
}
