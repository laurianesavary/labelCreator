namespace LabelCreator.ViewModels
{
    using System.Windows.Input;
    using Microsoft.Practices.Prism.Commands;
    using Microsoft.Practices.Prism.Mvvm;
    using Microsoft.Practices.Prism.Regions;
    using LabelCreator.ViewModels.Contracts;
    using Views;

    /// <summary>
    ///     The view model backing the <see cref="ShellView" /> view.
    /// </summary>
    public class ShellViewModel : BindableBase,
                                  IShellViewModel
    {
        private IRegionViewRegistry regionViewRegistry;

        #region Constructors and Desctuctors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ShellViewModel" /> class.
        /// </summary>
        /// <param name="settingsFlyoutViewModel">
        ///     The view model representing the application flyout window.
        /// </param>
        /// <param name="regionViewRegistry">
        ///     The interface for the registry of region's content.
        /// </param>
        public ShellViewModel(ISettingsFlyoutViewModel settingsFlyoutViewModel,
                              IRegionViewRegistry regionViewRegistry)
        {
            this.SettingsFlyoutViewModel = settingsFlyoutViewModel;
            this.regionViewRegistry = regionViewRegistry;

            this.DisplaySettingsCommand = new DelegateCommand<object>(this.DisplaySettings, this.CanDisplaySettings);
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the view model representing the application flyout window.
        /// </summary>
        public ISettingsFlyoutViewModel SettingsFlyoutViewModel { get; private set; }

        /// <summary>
        ///     Gets or sets the command to display the settings.
        /// </summary>
        public ICommand DisplaySettingsCommand { get; set; }

        #endregion Public Properties

        #region Public Methods and Operators

        private bool CanDisplaySettings(object arg)
        {
            return true;
        }

        private void DisplaySettings(object arg)
        {
            this.SettingsFlyoutViewModel.IsOpen = !this.SettingsFlyoutViewModel.IsOpen;

            this.regionViewRegistry.RegisterViewWithRegion("FlyoutRegion", typeof(SettingsFlyoutView));
        }

        #endregion Public Methods and Operators
    }
}
