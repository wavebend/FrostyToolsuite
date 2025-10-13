using System.Windows;
using Frosty.Controls;

namespace FrostyModManager.Windows
{
    /// <summary>
    /// Interaction logic for AddProfileWindow.xaml
    /// </summary>
    public partial class AddProfileWindow
    {
        public string ProfileName { get; set; }

        public AddProfileWindow(string title = "Add Pack", string button = "Add")
        {
            InitializeComponent();

            Title = title;
            addButton.Content = button;

            Window mainWin = Application.Current.MainWindow;
            if (mainWin != null)
            {
                double x = mainWin.Left + (mainWin.Width / 2.0);
                double y = mainWin.Top + (mainWin.Height / 2.0);

                Left = x - (Width / 2.0);
                Top = y - (Height / 2.0);
            }

            profileNameTextBox.Focus();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (profileNameTextBox.Text == "")
            {
                FrostyMessageBox.Show("Pack name must not be empty", "Frosty Mod Manager");
                return;
            }

            ProfileName = profileNameTextBox.Text;
            DialogResult = true;
            Close();
        }
    }
}
