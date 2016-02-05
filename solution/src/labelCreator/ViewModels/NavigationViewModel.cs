namespace LabelCreator.ViewModels
{
    using LabelCreator.ViewModels.Contracts;
    using Microsoft.Practices.Prism.Commands;
    using Microsoft.Practices.Prism.Mvvm;
    using Microsoft.Practices.Prism.Regions;
    using System;
    using System.Windows.Input;
    /// <summary>
    ///     The view model representing the navigation.
    /// </summary>
    public class NavigationViewModel : BindableBase,
                                       INavigationViewModel
    {
        #region Fields

        private bool backVisible;

        private string title;

        private readonly IRegionManager regionManager;

        #endregion Fields

        public NavigationViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;

            this.NavigateBackToHomeScreenCommand = new DelegateCommand<object>(this.NavigateBackToHomeScreen, this.CanNavigateBackToHomeScreen);
        }

        #region Public Properties

        public ICommand NavigateBackToHomeScreenCommand { get; set; }

        /// <summary>
        ///     Gets the visibility of the "Back" button.
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
