namespace LabelCreator.ViewModels
{
    using System;
    using System.Windows.Input;
    using Microsoft.Practices.Prism.Commands;
    using Microsoft.Practices.Prism.Regions;
    using LabelCreator.ViewModels.Contracts;
    using Views;

    /// <summary>
    ///     Represents the view model of the home screen.
    /// </summary>
    public class HomeScreenViewModel : IHomeScreenViewModel
    {
        #region Fields

        private IRegionViewRegistry regionViewRegistry;

        private IRegionManager regionManager;

        #endregion Fields

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="HomeScreenViewModel" /> class.
        /// </summary>
        /// <param name="regionViewRegistry">
        ///     The interface for the registry of region's content.
        /// </param>
        /// <param name="regionManager">
        ///     The interface to manage a set of Microsoft.Practices.Prism.Regions.IRegion and to attach regions to objects (typically controls).
        /// </param>
        /// <param name="navigationViewModel">
        ///     The contract for the view model of the navigation.
        /// </param>
        public HomeScreenViewModel(IRegionViewRegistry regionViewRegistry,
                                   IRegionManager regionManager,
                                   INavigationViewModel navigationViewModel)
        {
            this.regionViewRegistry = regionViewRegistry;
            this.regionManager = regionManager;

            navigationViewModel.Title = "Home Screen";

            this.CreateNewLabelCommand = new DelegateCommand<object>(this.CreateNewLabel, this.CanCreateNewLabel);
        }

        #endregion Constructors and Destructors

        #region Public Properties

        /// <summary>
        ///     Gets or sets the command to create a new label.
        /// </summary>
        public ICommand CreateNewLabelCommand { get; set; }

        #endregion Public Properties

        #region Methods

        private bool CanCreateNewLabel(object arg)
        {
            return true;
        }

        private void CreateNewLabel(object arg)
        {
            this.regionViewRegistry.RegisterViewWithRegion("ScreenContent", typeof(NewLabelView));
            this.regionManager.RequestNavigate("ScreenContent", new Uri("NewLabelView", UriKind.Relative));
        }

        #endregion Methods
    }
}
