using System.Windows;
using FrostySdk;

namespace UnifyAssetsPlugin.Windows
{
    /// <summary>
    /// Interaction logic for UnifyAssetsWindow.xaml
    /// </summary>
    public partial class UnifyAssetsWindow
    {
        public UnifyAssetsWindow()
        {
            InitializeComponent();
            LinkedAssetsAccessText.Text = $"The following assets have chunks that are only compatible with the {UnifyAssets.GameVersion} version of {UnifyAssets.DisplayName}";
            LinkedAssetsListBox.ItemsSource = UnifyAssets.LinkedAssets;
        }

        private void yesButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void noButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
