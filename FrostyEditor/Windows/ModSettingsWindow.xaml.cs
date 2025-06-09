using Frosty.Controls;
using System.Windows.Media.Imaging;
using System.IO;
using Frosty.Core;
using Frosty.Core.Mod;
using System.Collections.Generic;
using System;
using System.Linq;

namespace FrostyEditor.Windows
{
    /// <summary>
    /// Interaction logic for ModSettingsWindow.xaml
    /// </summary>
    public partial class ModSettingsWindow : FrostyDockableWindow
    {
        private ModSettings ModSettings => project.GetModSettings();
        private FrostyProject project;

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

            string[] invalidChars = { "{", "}" };

            if (invalidChars.Any(mTTB.Contains) || invalidChars.Any(mATB.Contains) || invalidChars.Any(mCTB.Contains) || invalidChars.Any(mVTB.Contains))
            {
                FrostyMessageBox.Show("Invalid Characters: {, }", "Frosty Editor");
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
