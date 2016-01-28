namespace LabelCreator.ViewModels
{
    using Caliburn.Micro;
    using LabelCreator.ViewModels.Contracts;

    /// <summary>
    ///     The view model representing the application flyout window.
    /// </summary>
    public class SettingsFlyoutViewModel : PropertyChangedBase, ISettingsFlyoutViewModel
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
                this.NotifyOfPropertyChange("IsOpen");
            }
        }
    }
}
