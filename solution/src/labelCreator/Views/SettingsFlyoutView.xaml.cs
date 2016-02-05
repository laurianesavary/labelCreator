namespace LabelCreator.Views
{
    using System.Windows.Controls;
    using Microsoft.Practices.Unity;
    using ViewModels.Contracts;

    /// <summary>
    ///     Interaction logic for SettingsFlyoutView.xaml
    /// </summary>
    public partial class SettingsFlyoutView : UserControl
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SettingsFlyoutView" /> class.
        /// </summary>
        public SettingsFlyoutView()
        {
            this.InitializeComponent();
        }

        /// <summary>
        ///     Sets the data context of this view to the corresponding view model.
        /// </summary>
        [Dependency]
        public ISettingsFlyoutViewModel ViewModel
        {
            set
            {
                this.DataContext = value;
            }
        }
    }
}
