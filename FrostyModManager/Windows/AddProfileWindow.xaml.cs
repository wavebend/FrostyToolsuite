using System;
using System.Collections.Generic;
using System.Linq;
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
        private List<FrostyPack> packs;
        private bool isRename;

        public AddProfileWindow(string title, string button, List<FrostyPack> frostyPacks)
        {
            InitializeComponent();

            Title = title;
            addButton.Content = button;
            packs = frostyPacks;

            if (title.Contains("Rename"))
            {
                isRename = true;
            }

            Window mainWin = Application.Current.MainWindow;
            if (mainWin != null)
            {
                double x = mainWin.Left + (mainWin.Width / 2.0);
                double y = mainWin.Top + (mainWin.Height / 2.0);

                Left = x - (Width / 2.0);
                Top = y - (Height / 2.0);
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string profileName = profileNameTextBox.Text;
            
            if (string.IsNullOrWhiteSpace(profileName))
            {
                FrostyMessageBox.Show("Pack name cannot be empty", "Frosty Mod Manager");
                return;
            }

            if (!isRename && packs.Any(s => string.Equals(s.Name, profileName, StringComparison.OrdinalIgnoreCase)))
            {
                FrostyMessageBox.Show("A pack with this name already exists", "Frosty Mod Manager");
                return;
            }

            ProfileName = profileName.Trim();
            DialogResult = true;
            Close();
        }
    }
}
