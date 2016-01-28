namespace LabelCreator.ViewModels.Contracts
{
    /// <summary>
    ///     Defines the contract for the view model backing the <see cref="ShellView" /> view.
    /// </summary>
    public interface IShellViewModel
    {
        /// <summary>
        ///     Gets the view model representing the application flyout window.
        /// </summary>
        ISettingsFlyoutViewModel SettingsFlyoutViewModel { get; }
    }
}
