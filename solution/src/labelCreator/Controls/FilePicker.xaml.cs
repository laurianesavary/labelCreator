namespace LabelCreator.Controls
{
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    /// <summary>
    ///     Interaction logic for FilePicker.xaml
    /// </summary>
    public partial class FilePicker : UserControl
    {
        #region Static Fields

        /// <summary>
        ///     Defines the BrowseButtonAutomationId dependency property.
        /// </summary>
        public static readonly DependencyProperty BrowseButtonAutomationIdProperty = 
            DependencyProperty.Register("BrowseButtonAutomationId",
                                        typeof(string),
                                        typeof(FilePicker),
                                        new PropertyMetadata(string.Empty));

        /// <summary>
        ///     Defines the BrowseCommand dependency property.
        /// </summary>
        public static readonly DependencyProperty BrowseCommandProperty =
            DependencyProperty.Register("BrowseCommand",
                                        typeof(ICommand),
                                        typeof(FilePicker),
                                        new FrameworkPropertyMetadata(null));

        /// <summary>
        ///     Defines the IsReadOnly dependency property.
        /// </summary>
        public static readonly DependencyProperty IsReadOnlyProperty =
            DependencyProperty.Register("IsReadOnly",
                                        typeof(bool),
                                        typeof(FilePicker),
                                        new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender));

        /// <summary>
        ///     Defines the TextBoxAutomationid dependency property.
        /// </summary>
        public static readonly DependencyProperty TextBoxAutomationIdProperty =
            DependencyProperty.Register("TextBoxAutomationId",
                                        typeof(string),
                                        typeof(FilePicker),
                                        new PropertyMetadata(string.Empty));

        /// <summary>
        ///     Defines the Text dependency property.
        /// </summary>
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text",
                                        typeof(string),
                                        typeof(FilePicker),
                                        new FrameworkPropertyMetadata(string.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.Journal, OnTextPropertyChanged, CoerceText, true, System.Windows.Data.UpdateSourceTrigger.LostFocus));

        /// <summary>
        ///     Defines the Watermark dependency property.
        /// </summary>
        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.Register("Watermark",
                                        typeof(string),
                                        typeof(FilePicker),
                                        new PropertyMetadata(default(string)));

        #endregion Static Fields

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="FilePicker" /> class.
        /// </summary>
        public FilePicker()
        {
            this.InitializeComponent();
        }

        #endregion Constructors and Destructors

        #region Public Properties

        /// <summary>
        ///     Gets or sets the automation id assigned to the "Browse" <see cref="Button" />.
        /// </summary>
        public string BrowseButtonAutomationId
        {
            get
            {
                return (string)this.GetValue(BrowseButtonAutomationIdProperty);
            }

            set
            {
                this.SetValue(BrowseButtonAutomationIdProperty, value);
            }
        }

        /// <summary>
        ///     Gets or sets the <see cref="ICommand" /> associated with the "Browse" <see cref="Button" />.
        /// </summary>
        [Bindable(true)]
        [Category("Action")]
        public ICommand BrowseCommand
        {
            get
            {
                return (ICommand)this.GetValue(BrowseCommandProperty);
            }

            set
            {
                this.SetValue(BrowseCommandProperty, value);
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether the text of the control is readonly.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return (bool)this.GetValue(IsReadOnlyProperty);
            }

            set
            {
                this.SetValue(IsReadOnlyProperty, value);
            }
        }

        /// <summary>
        ///     Gets or sets the text displayed in the <see cref="TextBox" />.
        /// </summary>
        [DefaultValue("")]
        public string Text
        {
            get
            {
                return (string)this.GetValue(TextProperty);
            }

            set
            {
                this.SetValue(TextProperty, value);
            }
        }

        /// <summary>
        ///     Gets or sets the automation id assigned to the <see cref="TextBox" />.
        /// </summary>
        public string TextBoxAutomationId
        {
            get
            {
                return (string)this.GetValue(TextBoxAutomationIdProperty);
            }

            set
            {
                this.SetValue(TextBoxAutomationIdProperty, value);
            }
        }

        /// <summary>
        ///     Gets or sets the watermark displayed on the <see cref="TextBox" />.
        /// </summary>
        public string Watermark
        {
            get
            {
                return (string)this.GetValue(WatermarkProperty);
            }

            set
            {
                this.SetValue(WatermarkProperty, value);
            }
        }

        #endregion Public Properties

        #region Methods

        private static object CoerceText(DependencyObject d,
                                         object value)
        {
            return value ?? string.Empty;
        }

        private static void OnTextPropertyChanged(DependencyObject d,
                                                  DependencyPropertyChangedEventArgs e)
        {
        }

        #endregion Methods
    }
}
