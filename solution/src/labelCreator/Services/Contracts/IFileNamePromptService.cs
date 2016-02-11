namespace LabelCreator.Services.Contracts
{
    using LabelCreator.UserInterface;

    /// <summary>
    ///     Defines the contract for displaying a open file dialog or save file dialog to the user.
    /// </summary>
    public interface IFileNamePromptService
    {
        /// <summary>
        ///     Displays a dialog to open a file.
        /// </summary>
        /// <param name="options">
        ///     The options.
        /// </param>
        /// <returns>
        ///     The name of the file selected by the user, or null if canceled.
        /// </returns>
        string PromptForOpenFile(FileNamePromptOptions options);

        /// <summary>
        ///     Displays a dialog to save a file.
        /// </summary>
        /// <param name="options">
        ///     The options.
        /// </param>
        /// <returns>
        ///     The name of the file selected by the user, or null if canceled.
        /// </returns>
        string PromptForSaveFile(FileNamePromptOptions options);
    }
}
