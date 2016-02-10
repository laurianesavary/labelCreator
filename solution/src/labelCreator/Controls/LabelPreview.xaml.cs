namespace LabelCreator.Controls
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    /// <summary>
    /// Interaction logic for LabelPreview.xaml
    /// </summary>
    public partial class LabelPreview : UserControl
    {
        #region Static Fields

        /// <summary>
        ///     Defines the ImageLeftAutomationId dependency property.
        /// </summary>
        public static readonly DependencyProperty ImageLeftAutomationIdProperty =
            DependencyProperty.Register("ImageLeftAutomationId",
                                        typeof(string),
                                        typeof(LabelPreview),
                                        new PropertyMetadata(string.Empty));

        /// <summary>
        ///     Defines the ImageRightAutomationId dependency property.
        /// </summary>
        public static readonly DependencyProperty ImageRightAutomationIdProperty =
            DependencyProperty.Register("ImageRightAutomationId",
                                        typeof(string),
                                        typeof(LabelPreview),
                                        new PropertyMetadata(string.Empty));

        /// <summary>
        ///     Defines the LabelText dependency property.
        /// </summary>
        public static readonly DependencyProperty FirstLineTextProperty =
            DependencyProperty.Register("FirstLineText",
                                        typeof(string),
                                        typeof(LabelPreview),
                                        new PropertyMetadata(default(string)));

        /// <summary>
        ///     Defines the FirstLineTextAutomationId dependency property.
        /// </summary>
        public static readonly DependencyProperty FirstLineTextAutomationIdProperty =
            DependencyProperty.Register("FirstLineTextAutomationId",
                                        typeof(string),
                                        typeof(LabelPreview),
                                        new PropertyMetadata(string.Empty));

        /// <summary>
        ///     Defines the LeftImagePath dependency property.
        /// </summary>
        public static readonly DependencyProperty LeftImagePathProperty =
            DependencyProperty.Register("LeftImagePath",
                                        typeof(ImageSource),
                                        typeof(LabelPreview),
                                        new FrameworkPropertyMetadata(default(ImageSource)));

        /// <summary>
        ///     Defines the RightImagePath dependency property.
        /// </summary>
        public static readonly DependencyProperty RightImagePathProperty =
            DependencyProperty.Register("RightImagePath",
                                        typeof(ImageSource),
                                        typeof(LabelPreview),
                                        new FrameworkPropertyMetadata(default(ImageSource)));

        /// <summary>
        ///     Defines the SecondLineTextAutomationId dependency property.
        /// </summary>
        public static readonly DependencyProperty SecondLineTextAutomationIdProperty =
            DependencyProperty.Register("SecondLineTextAutomationId",
                                        typeof(string),
                                        typeof(LabelPreview),
                                        new PropertyMetadata(string.Empty));

        #endregion Static Fields

        #region Constructors and Destrutors

        /// <summary>
        ///     Initializes a new instance of the <see cref="LabelPreview" /> class.
        /// </summary>
        public LabelPreview()
        {
            this.InitializeComponent();
        }

        #endregion Constructors and Destructors

        #region Public Properties

        /// <summary>
        ///     Gets or sets the automation id assigned to the left image.
        /// </summary>
        public string ImageLeftAutomationId
        {
            get
            {
                return (string)this.GetValue(ImageLeftAutomationIdProperty);
            }

            set
            {
                this.SetValue(ImageLeftAutomationIdProperty, value);
            }
        }

        /// <summary>
        ///     Gets or sets the automation id assigned to the right image.
        /// </summary>
        public string ImageRightAutomationId
        {
            get
            {
                return (string)this.GetValue(ImageRightAutomationIdProperty);
            }

            set
            {
                this.SetValue(ImageRightAutomationIdProperty, value);
            }
        }

        /// <summary>
        ///     Gets or sets the text of the label.
        /// </summary>
        public string FirstLineText
        {
            get
            {
                return (string)this.GetValue(FirstLineTextProperty);
            }

            set
            {
                this.SetValue(FirstLineTextProperty, value);
            }
        }

        /// <summary>
        ///     Gets or sets the automation id assigned to the first line of text of the label.
        /// </summary>
        public string FirstLineTextAutomationId
        {
            get
            {
                return (string)this.GetValue(FirstLineTextAutomationIdProperty);
            }

            set
            {
                this.SetValue(FirstLineTextAutomationIdProperty, value);
            }
        }

        /// <summary>
        ///     Gets or sets the path for the image on the left.
        /// </summary>
        public ImageSource LeftImagePath
        {
            get
            {
                return (ImageSource)this.GetValue(LeftImagePathProperty);
            }

            set
            {
                this.SetValue(LeftImagePathProperty, value);
            }
        }

        /// <summary>
        ///     Gets or sets the path for the image on the right.
        /// </summary>
        public ImageSource RightImagePath
        {
            get
            {
                return (ImageSource)this.GetValue(RightImagePathProperty);
            }

            set
            {
                this.SetValue(RightImagePathProperty, value);
            }
        }

        /// <summary>
        ///     Gets or sets the automation id assigned to the second line of text of the label.
        /// </summary>
        public string SecondLineTextAutomationId
        {
            get
            {
                return (string)this.GetValue(SecondLineTextAutomationIdProperty);
            }

            set
            {
                this.SetValue(SecondLineTextAutomationIdProperty, value);
            }
        }

        #endregion Public Properties
    }
}
