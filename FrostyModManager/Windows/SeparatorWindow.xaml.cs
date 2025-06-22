using Frosty.Controls;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FrostyModManager
{
    /// <summary>
    /// Interaction logic for SeparatorWindow.xaml
    /// </summary>
    public partial class SeparatorWindow : FrostyDockableWindow
    {
        public string NameSeparator { get; private set; } = "";

        public SeparatorWindow()
        {
            InitializeComponent();

            doneButton.IsEnabled = false;
        }

        private void nameSeparatorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (nameSeparatorTextBox.Text != "")
            {
                doneButton.IsEnabled = true;
            }
            else
            {
                doneButton.IsEnabled = false;
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
