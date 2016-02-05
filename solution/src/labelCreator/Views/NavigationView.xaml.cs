namespace LabelCreator.Views
{
    using System.Windows.Controls;
    using ViewModels.Contracts;

    /// <summary>
    ///     Interaction logic for NavigationView.xaml
    /// </summary>
    public partial class NavigationView : UserControl
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="NavigationView" /> class.
        /// </summary>
        /// <param name="navigationViewModel">
        ///     The contract for the view model of the navigation.
        /// </param>
        public NavigationView(INavigationViewModel navigationViewModel)
        {
            this.InitializeComponent();

            this.DataContext = navigationViewModel;
        }
    }
}
