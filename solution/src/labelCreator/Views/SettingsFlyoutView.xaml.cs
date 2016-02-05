namespace LabelCreator.Views
{
    using Microsoft.Practices.Unity;
    using System.Windows.Controls;
    using ViewModels.Contracts;

    /// <summary>
    /// Interaction logic for SettingsFlyoutView.xaml
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
