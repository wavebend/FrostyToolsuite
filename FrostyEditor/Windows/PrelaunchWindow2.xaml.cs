using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.IO;
using FrostySdk;
using Microsoft.Win32;
using Frosty.Controls;
using Frosty.Core;
using System.Linq;

namespace FrostyEditor.Windows
{
    /// <summary>
    /// Interaction logic for PrelaunchWindow2.xaml
    /// </summary>
    public partial class PrelaunchWindow2
    {
        private ObservableCollection<FrostyConfiguration> configurations = new ObservableCollection<FrostyConfiguration>();
        private FrostyConfiguration defaultConfiguration;

        public PrelaunchWindow2()
        {
            InitializeComponent();
        }

        private void LaunchConfiguration(string profile)
        {
            // load profiles
            if (!ProfilesLibrary.SelectProfile(profile))
            {
                FrostyMessageBox.Show("There was an error when trying to load game using specified profile.", "Frosty Editor");
                Close();
                return;
            }

            App.InitDiscordRpc();
            App.UpdateDiscordRpc("Initializing");

            // launch splash
            SplashWindow splash = new SplashWindow();
            App.Current.MainWindow = splash;
            splash.Show();
            Close();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ModifyConfigurationButton.IsEnabled = false;
            RemoveConfigurationButton.IsEnabled = false;
            LaunchConfigurationButton.IsEnabled = false;

            RefreshConfigurationList();

            if (ConfigurationListView.Items.Count == 0)
            {
                try
                {
                    await ScanGames();
                    RefreshConfigurationList();
                }
                catch
                {
                    // do nothing
                }
            }

            if (Config.Get<bool>("UseDefaultProfile2", false))
            {
                string defaultConfigurationName = Config.Get<string>("DefaultProfile2", null);

                if (!string.IsNullOrEmpty(defaultConfigurationName))
                {
                    defaultConfiguration = configurations.FirstOrDefault(x => x.ProfileName == defaultConfigurationName);

                    if (defaultConfiguration == null)
                    {
                        FrostyMessageBox.Show("There was an error when trying to load game using specified profile.", "Frosty Editor");
                        return;
                    }
                    
                    await Task.Delay(1);
                    LaunchConfiguration(defaultConfiguration.ProfileName);
                    Close();
                }
            }
        }

        private void LaunchConfigurationButton_OnClick(object sender, RoutedEventArgs e)
        {
            SelectConfiguration();
        }

        private void ConfigurationListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ModifyConfigurationButton.IsEnabled = true;
            RemoveConfigurationButton.IsEnabled = true;
            LaunchConfigurationButton.IsEnabled = true;

            if (SelectGameTextBlock.IsVisible)
            {
                SelectGameTextBlock.Visibility = Visibility.Collapsed;
            }

            if (ConfigurationListView.SelectedItem is FrostyConfiguration configuration)
            {
                ProfileNameTextBlock.Text = configuration.GameName;
                ProfilePathTextBlock.Text = configuration.GamePath;
            }
            else
            {
                ProfileNameTextBlock.Text = "";
                ProfilePathTextBlock.Text = "";
                SelectGameTextBlock.Visibility = Visibility.Visible;

                ModifyConfigurationButton.IsEnabled = false;
                RemoveConfigurationButton.IsEnabled = false;
                LaunchConfigurationButton.IsEnabled = false;
            }
        }

        private void ConfigurationListView_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SelectConfiguration();
        }

        private void AddConfigurationButton_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "*.exe (Game Executable)|*.exe",
                Title = "Choose Game Executable"
            };

            if (ofd.ShowDialog() == false)
            {
                FrostyMessageBox.Show("No game executable chosen.", "Frosty Editor");
                return;
            }

            FileInfo fi = new FileInfo(ofd.FileName);

            // try to load game profile
            if (!ProfilesLibrary.HasProfile(fi.Name.Remove(fi.Name.Length - 4)))
            {
                FrostyMessageBox.Show("There was an error when trying to load game using specified profile.", "Frosty Editor");
                return;
            }

            // make sure config doesnt already exist
            foreach (FrostyConfiguration configuration in configurations)
            {
                if (configuration.ProfileName == fi.Name.Remove(fi.Name.Length - 4))
                {
                    FrostyMessageBox.Show($"{configuration.GameName} already has a profile.", "Frosty Editor");
                    return;
                }
            }

            // create
            Config.AddGame(fi.Name.Remove(fi.Name.Length - 4), fi.DirectoryName);
            configurations.Add(new FrostyConfiguration(fi.Name.Remove(fi.Name.Length - 4)));
            Config.Save();

            ConfigurationListView.Items.Refresh();
        }

        private void ScanButton_OnClick(object sender, RoutedEventArgs e)
        {
            ScanGames().ContinueWith(t =>
            {
                // Refresh the configuration list after scanning is done
                RefreshConfigurationList();
            });
        }

        private void IterateSubKeys(RegistryKey subKey, ref int totalCount)
        {
            foreach (string subKeyName in subKey.GetSubKeyNames())
            {
                try
                {
                    IterateSubKeys(subKey.OpenSubKey(subKeyName), ref totalCount);
                }
                catch (System.Security.SecurityException)
                {
                    // do nothing
                }
            }

            foreach (string subKeyValue in subKey.GetValueNames())
            {
                if (subKeyValue.IndexOf("Install Dir", StringComparison.OrdinalIgnoreCase) != -1)
                {
                    string installDir = subKey.GetValue("Install Dir") as string;
                    if (string.IsNullOrEmpty(installDir))
                        continue;
                    if (!Directory.Exists(installDir))
                        continue;

                    foreach (string filename in Directory.EnumerateFiles(installDir, "*.exe"))
                    {
                        FileInfo fi = new FileInfo(filename);
                        string nameWithoutExt = fi.Name.Replace(fi.Extension, "");

                        if (ProfilesLibrary.HasProfile(nameWithoutExt))
                        {
                            Application.Current.Dispatcher.Invoke(() =>
                            {
                                foreach (FrostyConfiguration configuration in configurations)
                                {
                                    if (configuration.ProfileName == fi.Name.Remove(fi.Name.Length - 4))
                                        return;
                                }

                                Config.AddGame(fi.Name.Remove(fi.Name.Length - 4), fi.DirectoryName);
                                configurations.Add(new FrostyConfiguration(fi.Name.Remove(fi.Name.Length - 4)));
                            });

                            totalCount++;
                        }
                    }
                }
            }
        }

        private void RemoveConfigurationButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (FrostyMessageBox.Show("Are you sure you want to remove this profile?", "Frosty Editor", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                FrostyConfiguration selectedItem = ConfigurationListView.SelectedItem as FrostyConfiguration;

                Config.RemoveGame(selectedItem.ProfileName);

                configurations.Remove(selectedItem);
                ConfigurationListView.Items.Refresh();

                ConfigurationListView.SelectedIndex = -1;
                Config.Save();
            }
        }

        private void ModifyConfigurationButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (FrostyMessageBox.Show("Are you sure you want to change the game path for this profile?", "Frosty Editor", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                FrostyConfiguration selectedItem = ConfigurationListView.SelectedItem as FrostyConfiguration;

                ChangeGamePath(selectedItem.ProfileName, selectedItem.GameName);
            }
        }
        
        private void RefreshConfigurationList()
        {
            Dispatcher.Invoke(() =>
            {
                configurations.Clear();

                foreach (string profile in Config.GameProfiles)
                {
                    try
                    {
                        configurations.Add(new FrostyConfiguration(profile));
                    }
                    catch (FileNotFoundException)
                    {
                        string displayName = ProfilesLibrary.GetProfileDisplayName(profile);
                        
                        MessageBoxResult result = FrostyMessageBox.Show($"{displayName} could not be found\n\nDo you want to remove this profile?\n\nSelecting 'No' will allow you to choose another location.", "Missing Profile", MessageBoxButton.YesNoCancel);

                        if (result == MessageBoxResult.Yes)
                        {
                            Config.RemoveGame(profile);
                            Config.Save();
                        }
                        else if (result == MessageBoxResult.No)
                        {
                            ChangeGamePath(profile, displayName);
                        }
                    }
                }

                ConfigurationListView.ItemsSource = configurations;
            });
        }

        private void ChangeGamePath(string profile, string displayName)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = $"*.exe (Game Executable)|{profile}.exe",
                Title = $"Choose {displayName} Game Executable"
            };

            if (ofd.ShowDialog() == false)
            {
                FrostyMessageBox.Show("No game executable chosen.", "Frosty Editor");
                return;
            }

            FileInfo fi = new FileInfo(ofd.FileName);

            // try to load game profile
            if (!ProfilesLibrary.HasProfile(profile))
            {
                FrostyMessageBox.Show("There was an error when trying to load game using specified profile.", "Frosty Editor");
                return;
            }
            
            Config.Add("GamePath", fi.DirectoryName, ConfigScope.Game, profile);
            Config.Save();
            
            RefreshConfigurationList();
        }
        
        private void SelectConfiguration()
        {
            if (ConfigurationListView.SelectedIndex == -1)
                return;

            if (ConfigurationListView.SelectedItem is FrostyConfiguration configuration)
            {
                string version = Frosty.Core.App.Version;

                if (configuration.ProfileName == "Dragon Age The Veilguard")
                {
                    LaunchConfiguration(configuration.ProfileName);
                    Close();
                }
                else if (configuration.ProfileName == "DragonAgeInquisition")
                {
                    FrostyMessageBox.Show($"{configuration.GameName} is not supported on {version}\n\nUse 1.0.6.3 for {configuration.GameName}", "Unsupported Profile");
                    return;
                }
                else
                {
                    if (FrostyMessageBox.Show($"{configuration.GameName} is not supported.\n\nThis release only has support for Dragon Age\u2122: The Veilguard\n\nDo you wish to continue anyway?", "Unsupported Profile", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        LaunchConfiguration(configuration.ProfileName);
                        Close();
                    }
                }
            }
            ConfigurationListView.SelectedIndex = -1;
        }

        private async Task ScanGames()
        {
            ScanButton.IsEnabled = false;

            await Task.Run((() =>
            {
                using (RegistryKey lmKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node"))
                {
                    int totalCount = 0;

                    IterateSubKeys(lmKey, ref totalCount);
                }
            }));

            ScanButton.IsEnabled = true;
        }

        private void CancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
