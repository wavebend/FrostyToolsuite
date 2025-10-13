using Frosty.Controls;
using Frosty.Core;
using Frosty.Core.Mod;
using FrostySdk;
using FrostySdk.IO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using FrostySdk.Managers.Entries;

namespace FrostyEditor.Windows
{
    /// <summary>
    /// Interaction logic for ModSettingsWindow.xaml
    /// </summary>
    public partial class ModSettingsWindow
    {
        private ModSettings ModSettings => project.GetModSettings();
        private FrostyProject project;
        private byte[] dexResource;
        private string gameVersion = "Steam";

        private List<string> categories = new List<string>()
        {
            "Custom",
            "Armour and Clothing",
            "Audio",
            "Characters",
            "Cosmetic",
            "Gameplay",
            "Graphic",
            "Map",
            "Miscellaneous",
            "User Interface",
            "Visuals"
        };

        public ModSettingsWindow(FrostyProject inProject = null)
        {
            InitializeComponent();

            project = inProject;
            Loaded += ModSettingsWindow_Loaded;
        }

        private void ModSettingsWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            modCategoryComboBox.ItemsSource = categories;
            
            modTitleTextBox.Text = ModSettings.Title;
            modAuthorTextBox.Text = ModSettings.Author;
            modCategoryComboBox.SelectedIndex = ModSettings.SelectedCategory;
            modVersionTextBox.Text = ModSettings.Version;
            modDescriptionTextBox.Text = ModSettings.Description;
            modPageLinkTextBox.Text = ModSettings.Link;
            modDEXResourceNameTextBox.Text = ModSettings.DexResourceName;

            dexResource = ModSettings.DEXResource;

            if (dexResource != null || ProfilesLibrary.IsLoaded(ProfileVersion.DragonAgeTheVeilguard))
            {
                dockPanelDex.Visibility = System.Windows.Visibility.Visible;
            }

            if (modCategoryComboBox.SelectedItem.ToString() == "Custom")
            {
                modCategoryTextBox.Text = ModSettings.Category;
                modCategoryTextBox.IsEnabled = true;
            }
            else
            {
                modCategoryTextBox.Text = categories[ModSettings.SelectedCategory];
                modCategoryTextBox.IsEnabled = false;
            }

            iconImageButton.SetImage(ModSettings.Icon);
            ssImageButton1.SetImage(ModSettings.GetScreenshot(0));
            ssImageButton2.SetImage(ModSettings.GetScreenshot(1));
            ssImageButton3.SetImage(ModSettings.GetScreenshot(2));
            ssImageButton4.SetImage(ModSettings.GetScreenshot(3));

            if (dexResource == null)
            {
                exportDEXButton.IsEnabled = false;
                clearDEXButton.IsEnabled = false;
            }
            
            bool isUnifyLoaded = App.PluginManager.LoadedPlugins.ToList().Any(plugin => plugin.Name == "Unify Assets");

            if (ProfilesLibrary.IsLoaded(ProfileVersion.DragonAgeTheVeilguard) && isUnifyLoaded)
            {
                string displayName = ProfilesLibrary.DisplayName.Replace("\u2122", "");
                
                checkChunksDockPanel.Visibility = System.Windows.Visibility.Visible;
                checkChunksLabel.Content = $"Compatible with Steam and EA versions of {displayName}";
                
                bool isSteam = GameVersions.DragonAgeTheVeilguardSteam.Contains((int)Frosty.Core.App.FileSystemManager.Head);
                
                if (!CheckChunks(isSteam))
                {
                    checkChunksLabel.Content = $"Only compatible with the {gameVersion} version of {displayName}";
                    checkChunksLabel.Foreground = new BrushConverter().ConvertFrom("#FF000D") as SolidColorBrush;
                }
            }
        }

        private bool CheckChunks(bool isSteam)
        {
            List<string> chunkDiffList = new List<string>();
            
            if (!isSteam)
            {
                gameVersion = "EA";
            }
            
            string chunksPath = $"UnifyAssetsPlugin.Resources.{ProfilesLibrary.CacheName}-{gameVersion}-Chunks.txt";

            using (StreamReader reader = new StreamReader(Assembly.LoadFrom("Plugins\\UnifyAssetsPlugin.dll").GetManifestResourceStream(chunksPath)))
            {
                string listLine;
                
                while ((listLine = reader.ReadLine()) != null)
                {
                    chunkDiffList.Add(listLine);
                }
            }
            
            foreach (ChunkAssetEntry entry in App.AssetManager.EnumerateChunks(modifiedOnly: true))
            {
                if (chunkDiffList.Contains(entry.Name))
                {
                    return false;
                }
            }

            return true;
        }

        private void importDEXButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "ZIP Files (*.zip)|*.zip",
                Title = "Import DAVExtender(Dex) Archive",
            };

            if (ofd.ShowDialog() == true)
            {
                byte[] buffer = null;
                using (NativeReader reader = new NativeReader(new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read)))
                    buffer = reader.ReadToEnd();

                if (buffer.Length > (32 * 1024 * 1024))
                {
                    FrostyMessageBox.Show("DEX Archive cannot be larger than 32 MB", "Frosty Editor");
                    DexButtonEnabled();
                    return;
                }

                if (ParseZip(buffer, "dex.json", ofd.SafeFileName))
                {
                    modDEXResourceNameTextBox.Text = ofd.SafeFileName;
                    dexResource = buffer;

                    DexButtonEnabled();
                }
            }
        }

        private void DexButtonEnabled()
        {
            if (dexResource != null)
            {
                exportDEXButton.IsEnabled = true;
                clearDEXButton.IsEnabled = true;
            }
            else
            {
                exportDEXButton.IsEnabled = false;
                clearDEXButton.IsEnabled = false;
            }
        }

        private static bool ParseZip(byte[] buffer, string filename, string archiveName)
        {
            Stream data = new MemoryStream(buffer);

            ZipArchive archive = new ZipArchive(data);

            if (archive.GetEntry(filename) == null)
            {
                FrostyMessageBox.Show($"{filename} cannot be found in {archiveName}. It is either missing or stored within a folder.\n\nAll files and folders must be at the root of the archive.", "Frosty Editor");
                return false;
            }

            return true;
        }

        private void exportDEXButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "ZIP Files (*.zip)|*.zip",
                Title = "Export DAVExtender(Dex) Archive",
                FileName = modDEXResourceNameTextBox.Text,
                DefaultExt = ".zip"
            };

            if (sfd.ShowDialog() == true)
            {
                File.WriteAllBytes(sfd.FileName, dexResource);
            }
        }

        private void clearDEXButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            dexResource = null;
            modDEXResourceNameTextBox.Text = "";
            exportDEXButton.IsEnabled = false;
            clearDEXButton.IsEnabled = false;
        }

        private void cancelButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void saveButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (modPageLinkTextBox.Text.All(char.IsWhiteSpace))
            {
                modPageLinkTextBox.Text = "";
            }

            string mTTB = modTitleTextBox.Text;
            string mATB = modAuthorTextBox.Text;
            string mCTB = modCategoryTextBox.Text;
            string mVTB = modVersionTextBox.Text;
            string mLTB = modPageLinkTextBox.Text;

            if (string.IsNullOrWhiteSpace(mTTB) || string.IsNullOrWhiteSpace(mATB) || string.IsNullOrWhiteSpace(mCTB) || string.IsNullOrWhiteSpace(mVTB))
            {
                FrostyMessageBox.Show("Title, Author, Category and Version are mandatory fields", "Frosty Editor");
                return;
            }

            string[] invalidChars = { "\\", "/", ":", "*", "?", "\"", "<", ">", "|", "{", "}" };

            if (invalidChars.Any(mTTB.Contains) || invalidChars.Any(mATB.Contains) || invalidChars.Any(mCTB.Contains) || invalidChars.Any(mVTB.Contains))
            {
                string invalidCharsJoin = String.Join(" ", invalidChars);
                FrostyMessageBox.Show($"Invalid Characters: {invalidCharsJoin}", "Frosty Editor");
                return;
            }

            string[] approvedDomains = { "nexusmods.com", "moddb.com" };

            if (mLTB != "" && (!Uri.IsWellFormedUriString(mLTB, UriKind.Absolute) || !mLTB.StartsWith("https://www.") || !approvedDomains.Any(mLTB.Contains)))
            {
                FrostyMessageBox.Show("Link must be valid:\n\nhttps://www.nexusmods.com/{GAME}/mods/{ID}\nhttps://www.moddb.com/mods/{MOD}", "Frosty Editor");
                return;
            }

            if (mLTB.Contains("nexusmods.com") && mLTB.Contains("?"))
            {
                int index = mLTB.IndexOf("?");

                if (index >= 0)
                {
                    modPageLinkTextBox.Text = mLTB.Substring(0, index);
                }
            }

            ModSettings.Title = modTitleTextBox.Text;
            ModSettings.Author = modAuthorTextBox.Text;
            ModSettings.Category = modCategoryTextBox.Text;
            ModSettings.SelectedCategory = modCategoryComboBox.SelectedIndex;
            ModSettings.Version = modVersionTextBox.Text;
            ModSettings.Description = modDescriptionTextBox.Text;
            ModSettings.Link = modPageLinkTextBox.Text;
            ModSettings.DexResourceName = modDEXResourceNameTextBox.Text;
            ModSettings.DEXResource = dexResource;
            ModSettings.Icon = iconImageButton.GetImage();
            ModSettings.SetScreenshot(0, ssImageButton1.GetImage());
            ModSettings.SetScreenshot(1, ssImageButton2.GetImage());
            ModSettings.SetScreenshot(2, ssImageButton3.GetImage());
            ModSettings.SetScreenshot(3, ssImageButton4.GetImage());

            DialogResult = true;
            Close();
        }

        private bool FrostyImageButton_OnValidate(object sender, FileInfo fi, BitmapImage bimage)
        {
            FrostyImageButton btn = sender as FrostyImageButton;
            if (btn == iconImageButton)
            {
                if (bimage.PixelWidth > 128 || bimage.PixelHeight > 128)
                {
                    FrostyMessageBox.Show("Icon cannot be larger than 128x128");
                    return false;
                }
            }
            else
            {
                if (fi.Length > (5 * 1024 * 1024))
                {
                    FrostyMessageBox.Show("Screenshots cannot be larger than 5mb each");
                    return false;
                }
            }

            return true;
        }

        private void modCategoryComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (modCategoryComboBox.SelectedItem.ToString() == "Custom")
            {
                modCategoryTextBox.Text = "";
                modCategoryTextBox.IsEnabled = true;
            }
            else
            {
                modCategoryTextBox.Text = modCategoryComboBox.SelectedItem.ToString();
                modCategoryTextBox.IsEnabled = false;
            }
        }
    }
}
