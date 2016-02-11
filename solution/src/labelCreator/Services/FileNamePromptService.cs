namespace LabelCreator.Services
{
    using LabelCreator.Services.Contracts;
    using Microsoft.Win32;
    using UserInterface;
    using System.Windows.Forms;

    using OpenFileDialog = Microsoft.Win32.OpenFileDialog;
    using SaveFileDialog = System.Windows.Forms.SaveFileDialog;

    /// <summary>
    ///     Class that displays an open file dialog or save file dialog to the user.
    /// </summary>
    public class FileNamePromptService : IFileNamePromptService
    {
        #region Public Methods and Operators

        /// <summary>
        ///     Displays a dialog to open a file.
        /// </summary>
        /// <param name="options">
        ///     The options.
        /// </param>
        /// <returns>
        ///     The name of the file selected by the user, or null if canceled.
        /// </returns>
        public string PromptForOpenFile(FileNamePromptOptions options)
        {
            var openFileDialog = new OpenFileDialog
                                        {
                                            CheckFileExists = options.CheckFileExists,
                                            CheckPathExists = options.CheckPathExists,
                                            DefaultExt = options.DefaultExt,
                                            FileName = options.FileName,
                                            Filter = options.Filter,
                                            FilterIndex = options.FilterIndex,
                                            InitialDirectory = options.InitialDirectory,
                                            RestoreDirectory = options.RestoreDirectory,
                                            Title = options.Title,
                                            ValidateNames = options.ValidateNames
                                        };

            var dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == true)
            {
                return openFileDialog.FileName;
            }

            return null;
        }

        /// <summary>
        ///     Displays a dialog to save a file.
        /// </summary>
        /// <param name="options">
        ///     The options.
        /// </param>
        /// <returns>
        ///     The name of the file selected by the user, or null if canceled.
        /// </returns>
        public string PromptForSaveFile(FileNamePromptOptions options)
        {
            var saveFileDialog = new SaveFileDialog
                                        {
                                            CheckFileExists = options.CheckFileExists,
                                            CheckPathExists = options.CheckPathExists,
                                            DefaultExt = options.DefaultExt,
                                            FileName = options.FileName,
                                            Filter = options.Filter,
                                            FilterIndex = options.FilterIndex,
                                            InitialDirectory = options.InitialDirectory,
                                            RestoreDirectory = options.RestoreDirectory,
                                            Title = options.Title,
                                            ValidateNames = options.ValidateNames,
                                            OverwritePrompt = options.OverwritePrompt,
                                            AddExtension = true
                                        };

            var dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return null;
        }

        #endregion Public Methods and Operators
    }
}
