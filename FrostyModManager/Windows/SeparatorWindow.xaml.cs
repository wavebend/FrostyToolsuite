using Frosty.Controls;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace FrostyModManager
{
    /// <summary>
    /// Interaction logic for SeparatorWindow.xaml
    /// </summary>
    public partial class SeparatorWindow : FrostyDockableWindow
    {
        public string NameSeparator { get; private set; } = "";
        public string[] invalidChars = { "\\", "/", ":", "*", "?", "\"", "<", ">", "|", "{", "}" };

        public SeparatorWindow()
        {
            InitializeComponent();

            string invalidCharsJoin = String.Join(" ", invalidChars);
            charsTextBox.Text = $"Invalid Characters: {invalidCharsJoin}";

            doneButton.IsEnabled = false;
        }

        private void nameSeparatorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameSeparatorTextBox.Text) || invalidChars.Any(nameSeparatorTextBox.Text.Contains))
            {
                doneButton.IsEnabled = false;
            }
            else
            {
                doneButton.IsEnabled = true;
            }
        }

        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;

            NameSeparator = nameSeparatorTextBox.Text;
            
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
