namespace LabelCreator.Views
{
    using System.Windows.Controls;
    using ViewModels.Contracts;

    /// <summary>
    ///     Interaction logic for NewLabelView.xaml
    /// </summary>
    public partial class NewLabelView : UserControl
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="NewLabelView" /> class.
        /// </summary>
        /// <param name="newLabelViewModel">
        ///     The contract for the view model of the label creation view.
        /// </param>
        public NewLabelView(INewLabelViewModel newLabelViewModel)
        {
            this.InitializeComponent();
            this.DataContext = newLabelViewModel;
        }
    }
}
