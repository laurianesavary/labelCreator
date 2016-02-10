namespace LabelCreator.UserInterface
{
    /// <summary>
    ///     The options used to customize the file name prompt.
    /// </summary>
    public struct FileNamePromptOptions
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets a value indicating whether the dialog box displays a warning if the user specifies a file name that does not exist.
        /// </summary>
        public bool CheckFileExists { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the dialog box displays a warning if the user specified a path that does not exist.
        /// </summary>
        public bool CheckPathExists { get; set; }

        /// <summary>
        ///     Gets or sets the default file name extension.
        /// </summary>
        public string DefaultExt { get; set; }

        /// <summary>
        ///     Gets or sets a string containing the file name selected in the file dialog box.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        ///     Gets or sets the current file name filter string, which determines the choices that appear in the "Save as file type" or 
        ///     "Files of type" box in the dialog box.
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        ///     Gets or sets the index of the filter currently selected in the file dialog box.
        /// </summary>
        public int FilterIndex { get; set; }

        /// <summary>
        ///     Gets or sets the initial directory displayed by the file dialog box.
        /// </summary>
        public string InitialDirectory { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the Save As dialog box displays a warning if the user specified a file name that already exists.
        /// </summary>
        public bool OverwritePrompt { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the dialog box restores the current directory before closing.
        /// </summary>
        public bool RestoreDirectory { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the Help button is displayed in the file dialog box.
        /// </summary>
        public bool ShowHelp { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the dialog box supports displaying and saving files that have multiple file name extensions.
        /// </summary>
        public bool SupportMultiDottedExtensions { get; set; }

        /// <summary>
        ///     Gets or sets the file dialog box title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the dialog box accepts only valid Win32 file names.
        /// </summary>
        public bool ValidateNames { get; set; }

        #endregion
    }
}
