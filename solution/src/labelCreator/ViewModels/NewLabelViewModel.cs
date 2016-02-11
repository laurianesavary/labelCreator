namespace LabelCreator.ViewModels
{
    using System.Windows.Input;
    using LabelCreator.ViewModels.Contracts;
    using Microsoft.Practices.Prism.Commands;
    using Microsoft.Practices.Prism.Mvvm;
    using Services.Contracts;
    using UserInterface;
    using Types;
    using Newtonsoft.Json;
    using System.IO;
    using System.Collections.Generic;/// <summary>
                                     ///     The view model representing the creation of a new label.
                                     /// </summary>
    public class NewLabelViewModel : BindableBase,
                                     INewLabelViewModel
    {
        #region Fields

        private readonly IFileNamePromptService fileNamePromptService;

        private string firstLineText;

        private string leftImagePath;

        private string rightImagePath;

        private string secondLineText;

        #endregion Fields

        /// <summary>
        ///     Initializes a new instance of the <see cref="NewLabelViewModel" /> class.
        /// </summary>
        /// <param name="navigationViewModel">
        ///     The view model representing the navigation.
        /// </param>
        /// <param name="fileNamePromptService">
        ///     The service for displaying a open file dialog or save file dialog to the user.
        /// </param>
        public NewLabelViewModel(INavigationViewModel navigationViewModel,
                                 IFileNamePromptService fileNamePromptService)
        {
            navigationViewModel.Title = "New Label";
            this.fileNamePromptService = fileNamePromptService;

            this.BrowseLeftImageCommand = new DelegateCommand(this.BrowseLeftImagePath);
            this.BrowseRightImageCommand = new DelegateCommand(this.BrowseRightImagePath);
            this.SaveLabelCommand = new DelegateCommand(this.SaveLabel);
        }

        #region Public Properties

        /// <summary>
        ///     Gets the command associated with the "Browse" <see cref="Button" /> on the left image path file picker.
        /// </summary>
        public ICommand BrowseLeftImageCommand { get; private set; }

        /// <summary>
        ///     Gets the command associated with the "Browse" <see cref="Button" /> on the right image path file picker.
        /// </summary>
        public ICommand BrowseRightImageCommand { get; private set; }

        /// <summary>
        ///     Gets the command associated with the "Save" <see cref="Button" /> in the application bar.
        /// </summary>
        public ICommand SaveLabelCommand { get; private set; }

        /// <summary>
        ///     Gets or sets the text of the first line of the label.
        /// </summary>
        public string FirstLineText
        {
            get
            {
                return this.firstLineText;
            }

            set
            {
                this.firstLineText = value;
                this.OnPropertyChanged(() => this.FirstLineText);
            }
        }

        /// <summary>
        ///     Gets or sets the left image path.
        /// </summary>
        public string LeftImagePath
        {
            get
            {
                return this.leftImagePath;
            }

            set
            {
                this.leftImagePath = value;
                this.OnPropertyChanged(() => this.LeftImagePath);
            }
        }

        /// <summary>
        ///     Gets or sets the right image path.
        /// </summary>
        public string RightImagePath
        {
            get
            {
                return this.rightImagePath;
            }

            set
            {
                this.rightImagePath = value;
                this.OnPropertyChanged(() => this.RightImagePath);
            }
        }

        /// <summary>
        ///     Gets or sets the text of the second line of the label.
        /// </summary>
        public string SecondLineText
        {
            get
            {
                return this.secondLineText;
            }

            set
            {
                this.secondLineText = value;
                this.OnPropertyChanged(() => this.SecondLineText);
            }
        }

        #endregion Public Properties

        #region Public Methods and Operators

        /// <summary>
        ///     Opens the system file browser to select which image file to insert left.
        /// </summary>
        public void BrowseLeftImagePath()
        {
            var filePath = this.BrowseForImage();

            if (!string.IsNullOrWhiteSpace(filePath))
            {
                this.LeftImagePath = filePath;
            }
        }

        /// <summary>
        ///     Opens the system file browser to select which image file to insert right.
        /// </summary>
        public void BrowseRightImagePath()
        {
            var filePath = this.BrowseForImage();

            if (!string.IsNullOrWhiteSpace(filePath))
            {
                this.RightImagePath = filePath;
            }
        }

        /// <summary>
        ///     Saves the data of the label to a file.
        /// </summary>
        public void SaveLabel()
        {
            var list = new List<LabelData>();

            list.Add(new LabelData
                        {
                            FirstLineText = this.FirstLineText,
                            ImageLeftPath = this.LeftImagePath,
                            ImageRightPath = this.RightImagePath,
                            SecondLineText = this.SecondLineText
                        });

            var json = JsonConvert.SerializeObject(list.ToArray());

            var fileNamePromptOptions = new FileNamePromptOptions
            {
                CheckPathExists = true,
                DefaultExt = ".json"
            };

            var filename = this.fileNamePromptService.PromptForSaveFile(fileNamePromptOptions);

            if (filename != null)
            {
                File.WriteAllText(filename, json);
            }
        }

        #endregion Public Methods and Operators

        #region Methods

        private string BrowseForImage()
        {
            var filters = new[]
                            {
                                "Bitmap files (*.bmp)|*.bmp",
                                "JPEG files (*.jpg,*.jpeg)|*.jpg;*.jpeg",
                                "PNG files (*.png)|*.png"
                            };

            var fileNamePromptOptions = new FileNamePromptOptions
            {
                Filter = string.Join("|", filters),
                FilterIndex = 2,
                CheckPathExists = true,
                CheckFileExists = true
            };

            return this.fileNamePromptService.PromptForOpenFile(fileNamePromptOptions);
        }

        #endregion Methods
    }
}
