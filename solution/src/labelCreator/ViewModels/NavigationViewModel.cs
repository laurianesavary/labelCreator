namespace LabelCreator.ViewModels
{
    using System;
    using System.Windows.Input;
    using LabelCreator.ViewModels.Contracts;
    using Microsoft.Practices.Prism.Commands;
    using Microsoft.Practices.Prism.Mvvm;
    using Microsoft.Practices.Prism.Regions;

    /// <summary>
    ///     The view model representing the navigation.
    /// </summary>
    public class NavigationViewModel : BindableBase,
                                       INavigationViewModel
    {
        #region Fields

        private readonly IRegionManager regionManager;

        private bool backVisible;

        private string title;

        #endregion Fields

        /// <summary>
        ///     Initializes a new instance of the <see cref="NavigationViewModel" /> class.
        /// </summary>
        /// <param name="regionManager">
        ///     The interface to manage a set of Microsoft.Practices.Prism.Regions.IRegion and to attach regions to objects (typically controls).
        /// </param>
        public NavigationViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;

            this.NavigateBackToHomeScreenCommand = new DelegateCommand<object>(this.NavigateBackToHomeScreen, this.CanNavigateBackToHomeScreen);
        }

        #region Public Properties

        /// <summary>
        ///     Gets or sets the command associated with the "Back" <see cref="Button" />.
        /// </summary>
        public ICommand NavigateBackToHomeScreenCommand { get; set; }

        /// <summary>
        ///     Gets a value indicating whether the "Back" button is visible or not.
        /// </summary>
        public bool BackVisible
        {
            get
            {
                return this.backVisible;
            }

            private set
            {
                this.backVisible = value;
                this.OnPropertyChanged(() => this.BackVisible);
            }
        }

        /// <summary>
        ///     Gets or sets the title of the screen.
        /// </summary>
        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.title = value;
                this.OnPropertyChanged(() => this.Title);

                this.BackVisible = !value.Equals("Home Screen");
            }
        }

        #endregion Public Properties

        #region Methods

        private void NavigateBackToHomeScreen(object arg)
        {
            this.regionManager.RequestNavigate("ScreenContent", new Uri("HomeScreenView", UriKind.Relative));
            this.Title = "Home Screen";
        }

        private bool CanNavigateBackToHomeScreen(object arg)
        {
            return true;
        }

        #endregion Methods
    }
}
