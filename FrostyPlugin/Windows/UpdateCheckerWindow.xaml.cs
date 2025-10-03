using Frosty.Controls;
using FrostySdk;
using Microsoft.Win32;
using SharpDX.Direct2D1;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;

namespace Frosty.Core.Windows
{
    /// <summary>
    /// Interaction logic for UpdateCheckerWindow.xaml
    /// </summary>
    public partial class UpdateCheckerWindow : FrostyDockableWindow
    {
        public UpdateCheckerWindow()
        {
            InitializeComponent();

            infoTextBox.Text = $"You are using an outdated version of {App.Title}\n\nWould you like to download the latest version?";
            infoTextBox.TextAlignment = TextAlignment.Center;

            changeLog();
        }

        private async void changeLog()
        {
            try
            {
                string changeLogRaw = await new HttpClient().GetStringAsync("https://raw.githubusercontent.com/J-Lyt/FrostyToolsuite/refs/heads/DragonAge/FrostyEditor/ChangeLog.txt");

                int index = changeLogRaw.IndexOf("v1.0.7 - " + App.BuildVersion);

                string changeLog = changeLogRaw.Substring(0, index);

                changelogTextBox.Text = changeLog;
            }
            catch
            {
                changelogTextBox.Text = "Unable to retrieve changelog.";
            }
        }

        private void yesButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;

            Close();
        }

        private void noButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;

            Close();
        }
    }
}
