namespace LabelCreator.Controls
{
    using Microsoft.Win32;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for FilePicker.xaml
    /// </summary>
    public partial class FilePicker : UserControl
    {
        public FilePicker()
        {
            this.InitializeComponent();
        }

        private void BrowseClick(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.DefaultExt = ".png";
            dialog.Filter = "Image files (*.png, *.jpg)|*.png;*.jpg|All files (*.*)|*.*";

            var result = dialog.ShowDialog();

            if (result == true)
            {
                this.FilePickerText.Text = dialog.FileName;
            }
        }
    }
}
