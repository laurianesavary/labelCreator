namespace LabelCreator.ViewModels
{
    using LabelCreator.ViewModels.Contracts;
    using Microsoft.Practices.Prism.Commands;
    using Microsoft.Practices.Prism.Mvvm;
    using Microsoft.Practices.Prism.Regions;
    using Microsoft.Practices.ServiceLocation;
    using Microsoft.Practices.Unity;
    using System.Windows.Input;
    using Views;
    /// <summary>
    ///     The view model backing the <see cref="ShellView" /> view.
    /// </summary>
    public class ShellViewModel : BindableBase,
                                  IShellViewModel
    {
        private IRegionViewRegistry regionViewRegistry;

        private IUnityContainer unityContainer;

        #region Constructors and Desctuctors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ShellViewModel" /> class.
        /// </summary>
        /// <param name="settingsFlyoutViewModel">
        ///     The view model representing the application flyout window.
        /// </param>
        public ShellViewModel(ISettingsFlyoutViewModel settingsFlyoutViewModel,
                              IRegionViewRegistry regionViewRegistry,
                              IUnityContainer unityContainer)
        {
            this.SettingsFlyoutViewModel = settingsFlyoutViewModel;
            this.regionViewRegistry = regionViewRegistry;
            this.unityContainer = unityContainer;

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

        /// <summary>
        ///     Displays the flyout for the settings.
        /// </summary>
        private void DisplaySettings(object arg)
        {
            this.SettingsFlyoutViewModel.IsOpen = !this.SettingsFlyoutViewModel.IsOpen;

            this.regionViewRegistry.RegisterViewWithRegion("FlyoutRegion", typeof(SettingsFlyoutView));
        }

        #endregion Public Methods and Operators
    }
}
