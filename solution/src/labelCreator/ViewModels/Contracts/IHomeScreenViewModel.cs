namespace LabelCreator.ViewModels.Contracts
{
    using System.Windows.Input;

    /// <summary>
    ///     Defines the contract for the view model of the home screen.
    /// </summary>
    public interface IHomeScreenViewModel
    {
        /// <summary>
        ///     Gets or sets the command to create a new label.
        /// </summary>
        ICommand CreateNewLabelCommand { get; set; }
    }
}
