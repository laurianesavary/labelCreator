namespace LabelCreator.ViewModels
{
    using LabelCreator.ViewModels.Contracts;
    using Microsoft.Practices.Prism.Mvvm;

    /// <summary>
    ///     The view model representing the navigation.
    /// </summary>
    public class NavigationViewModel : BindableBase,
                                       INavigationViewModel
    {
        #region Fields

        private string title = "test";

        #endregion Fields

        #region Public Properties

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
            }
        }

        #endregion Public Properties
    }
}
