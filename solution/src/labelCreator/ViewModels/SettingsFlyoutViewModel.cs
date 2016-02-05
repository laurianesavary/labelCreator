namespace LabelCreator.ViewModels
{
    using LabelCreator.ViewModels.Contracts;
    using Microsoft.Practices.Prism.Mvvm;

    /// <summary>
    ///     The view model representing the application flyout window.
    /// </summary>
    public class SettingsFlyoutViewModel : BindableBase, ISettingsFlyoutViewModel
    {
        private bool isOpen;

        /// <summary>
        ///     Gets or sets a value indicating whether the flyout is visible or not.
        /// </summary>
        public bool IsOpen
        {
            get
            {
                return this.isOpen;
            }

            set
            {
                this.isOpen = value;
                this.OnPropertyChanged(() => this.IsOpen);
            }
        }
    }
}
