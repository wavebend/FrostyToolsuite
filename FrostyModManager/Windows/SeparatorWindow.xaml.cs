using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace FrostyModManager.Windows
{
    /// <summary>
    /// Interaction logic for SeparatorWindow.xaml
    /// </summary>
    public partial class SeparatorWindow
    {
        public string NameSeparator { get; private set; } = "";
        private readonly string[] invalidChars = { "\\", "/", ":", "*", "?", "\"", "<", ">", "|", "{", "}" };

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
            NameSeparator = nameSeparatorTextBox.Text;
            
            DialogResult = true;
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
