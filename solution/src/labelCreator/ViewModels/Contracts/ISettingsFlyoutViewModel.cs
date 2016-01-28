namespace LabelCreator.ViewModels.Contracts
{
    /// <summary>
    ///     Defines the contract for the view model representing the application flyout window.
    /// </summary>
    public interface ISettingsFlyoutViewModel
    {
        /// <summary>
        ///     Gets or sets a value indicating whether the flyout is visible or not.
        /// </summary>
        bool IsOpen { get; set; }
    }
}
