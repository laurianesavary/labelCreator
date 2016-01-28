namespace LabelCreator.ViewModels
{
    using LabelCreator.ViewModels.Contracts;

    using Caliburn.Micro;

    /// <summary>
    ///     The view model backing the <see cref="ShellView" /> view.
    /// </summary>
    public class ShellViewModel : PropertyChangedBase,
                                  IShellViewModel
    {
        #region Constructors and Desctuctors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ShellViewModel" /> class.
        /// </summary>
        /// <param name="settingsFlyoutViewModel">
        ///     The view model representing the application flyout window.
        /// </param>
        public ShellViewModel(ISettingsFlyoutViewModel settingsFlyoutViewModel)
        {
            this.SettingsFlyoutViewModel = settingsFlyoutViewModel;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the view model representing the application flyout window.
        /// </summary>
        public ISettingsFlyoutViewModel SettingsFlyoutViewModel { get; private set; }

        #endregion Public Properties

        #region Public Methods and Operators

        /// <summary>
        ///     Displays the flyout for the settings.
        /// </summary>
        public void DisplaySettings()
        {
            this.SettingsFlyoutViewModel.IsOpen = true;
        }

        #endregion Public Methods and Operators
    }
}
