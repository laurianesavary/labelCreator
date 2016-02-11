namespace LabelCreator.Types
{
    /// <summary>
    ///     Represents the data of the label.
    /// </summary>
    public class LabelData
    {
        /// <summary>
        ///     Gets or sets the first line of text.
        /// </summary>
        public string FirstLineText { get; set; }

        /// <summary>
        ///     Gets or sets the path to the left image.
        /// </summary>
        public string ImageLeftPath { get; set; }

        /// <summary>
        ///     Gets or sets the path to the right image.
        /// </summary>
        public string ImageRightPath { get; set; }

        /// <summary>
        ///     Gets or sets the second line of text.
        /// </summary>
        public string SecondLineText { get; set; }
    }
}
