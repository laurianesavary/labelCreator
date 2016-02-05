using LabelCreator.ViewModels.Contracts;

namespace LabelCreator.ViewModels
{
    /// <summary>
    ///     The view model representing the creation of a new label.
    /// </summary>
    public class NewLabelViewModel : INewLabelViewModel
    {
        public NewLabelViewModel(INavigationViewModel navigationViewModel)
        {
            navigationViewModel.Title = "New Label";
        }
    }
}
