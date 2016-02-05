namespace LabelCreator.Views
{
    using MahApps.Metro.Controls;
    using ViewModels.Contracts;

    /// <summary>
    ///     Interaction logic for <see cref="ShellView" />.
    /// </summary>
    public partial class ShellView : MetroWindow
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ShellView" /> class.
        /// </summary>
        /// <param name="shellViewModel">
        ///     The contract for the view model backing the <see cref="ShellView" /> view.
        /// </param>
        public ShellView(IShellViewModel shellViewModel)
        {
            this.InitializeComponent();

            this.DataContext = shellViewModel;
        }
    }
}
