namespace LabelCreator.ViewModels.Contracts
{
    /// <summary>
    ///     Defines the contract for the view model of the navigation.
    /// </summary>
    public interface INavigationViewModel
    {
        /// <summary>
        ///     Gets a value indicating whether the "Back" button is visible or not.
        /// </summary>
        bool BackVisible { get; }

        /// <summary>
        ///     Gets or sets the title of the screen.
        /// </summary>
        string Title { get; set; }
    }
}
