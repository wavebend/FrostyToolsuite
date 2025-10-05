using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Frosty.Controls;
using FrostySdk;

namespace Frosty.Core.Windows
{

    public class ModDataListItem
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }


    /// <summary>
    /// Author: Stoichiom, Dyvinia
    /// Class <c>ManageModDataWindow</c> handles the logic for deleting specified ModData folders. 
    /// </summary>
    public partial class ManageModDataWindow
    {
        public ManageModDataWindow()
        {
            InitializeComponent();

            // Draws the window in the center of the screen
            Window mainWin = Application.Current.MainWindow;
            if (mainWin != null)
            {
                double x = mainWin.Left + (mainWin.Width / 2.0);
                double y = mainWin.Top + (mainWin.Height / 2.0);

                Left = x - (Width / 2.0);
                Top = y - (MaxHeight / 2.0);
                
                Icon = mainWin.Icon;
            }

            // Draws the user's ModData directory on modDataNameTextBox
            string modDataPath = GetModDataPath();
            modDataNameTextBox.Text = modDataPath;

            // Done to avoid potential IO error on init
            if (!Directory.Exists(modDataPath))
                Directory.CreateDirectory(modDataPath);

            ListPacks();
        }

        /// <summary>
        /// Method <c>getModDataPath</c> Returns the path to the ModData folder.
        /// </summary>
        private string GetModDataPath()
        {
            return Config.Get<string>("GamePath", "", ConfigScope.Game, ProfilesLibrary.ProfileName) + "\\ModData";
        }

        /// <summary>
        /// Method <c>listPacks</c> lists the available packs in the ModData folder
        /// </summary>
        private void ListPacks()
        {
            // Cleans out old items
            modDataList.Items.Clear();

            string modDataPath = GetModDataPath();

            // Grabs the packs currently in the ModData folder.
            string[] modDataPacks = Directory.GetDirectories(modDataPath, "*", SearchOption.TopDirectoryOnly);

            // Adds them to the ComboBox in the window.
            foreach (string packNamePath in modDataPacks)
            {
                modDataList.Items.Add(new ModDataListItem { Name = Path.GetFileName(packNamePath), Path = packNamePath });
            }
        }

        /// <summary>
        /// Method <c>deleteModData_Click</c> Delete operation for the selected ModData pack folder
        /// </summary>
        private void deleteModData_Click(object sender, RoutedEventArgs e)
        {
            ModDataListItem selectedPack = ((Button)sender).DataContext as ModDataListItem;

            DateTime lastModified = File.GetLastWriteTime(selectedPack.Path);

            if (FrostyMessageBox.Show($"Are you sure you want to delete this folder?\n\n{selectedPack.Name}\n{lastModified}", App.Title, MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    Directory.Delete(selectedPack.Path, true);
                    ListPacks();
                }
                catch (IOException)
                {
                    System.Threading.Tasks.Task.Run(() => {
                        FrostyMessageBox.Show("Folder could not be deleted.\n\nTry running Frosty as Administrator.", App.Title, MessageBoxButton.OK);
                    });
                }
            }
        }

        /// <summary>
        /// Method <c>openModData_Click</c> Open ModData pack folder
        /// </summary>
        private void openModData_Click(object sender, RoutedEventArgs e)
        {
            ModDataListItem selectedPack = ((Button)sender).DataContext as ModDataListItem;
            Process.Start(selectedPack.Path);
        }
    }
}
