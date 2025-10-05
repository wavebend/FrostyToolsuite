using System;
using System.Net.Http;
using System.Windows;

namespace Frosty.Core.Windows
{
    /// <summary>
    /// Interaction logic for UpdateCheckerWindow.xaml
    /// </summary>
    public partial class UpdateCheckerWindow
    {
        public UpdateCheckerWindow()
        {
            InitializeComponent();

            Window mainWin = Application.Current.MainWindow;
            if (mainWin != null)
            {
                Icon = mainWin.Icon;
            }

            infoTextBox.Text = $"You are using an outdated version of {App.Title}\n\nWould you like to download the latest version?";
            infoTextBox.TextAlignment = TextAlignment.Center;

            ChangeLog();
        }

        private async void ChangeLog()
        {
            try
            {
                string changeLogRaw = await new HttpClient().GetStringAsync("https://raw.githubusercontent.com/J-Lyt/FrostyToolsuite/refs/heads/DragonAge/FrostyEditor/ChangeLog.txt");

                int index = changeLogRaw.IndexOf("v1.0.7 - " + App.BuildVersion, StringComparison.Ordinal);

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
            Close();
        }
    }
}
