namespace LabelCreator.Views
{
    using System.Windows.Controls;
    using ViewModels.Contracts;

    /// <summary>
    ///     Interaction logic for HomeScreenView.xaml
    /// </summary>
    public partial class HomeScreenView : UserControl
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="HomeScreenView" /> class.
        /// </summary>
        /// <param name="homeScreenViewModel">
        ///     The contract for the view model of the home screen.
        /// </param>
        public HomeScreenView(IHomeScreenViewModel homeScreenViewModel)
        {
            this.InitializeComponent();
            this.DataContext = homeScreenViewModel;
        }
    }
}
