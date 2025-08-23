using Frosty.Controls;
using Frosty.Core.Controls;
using Frosty.Core.Windows;
using FrostyEditor.Windows;
using System;
using System.Windows;
using System.Windows.Input;

namespace FrostyEditor.Commands
{
    class ExportModMenuItemCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public bool CanExecute(object parameter)
        {
            //return (App.AssetManager != null && App.AssetManager.GetModifiedCount() != 0);
            return (App.AssetManager != null);
        }

        public void Execute(object parameter)
        {
            if (App.AssetManager.GetModifiedCount() == 0)
            {
                MessageBoxResult result = FrostyMessageBox.Show("This project file has no modified assets. Do you wish to export anyway?", "Frosty Editor", MessageBoxButton.YesNo);

                if (result == MessageBoxResult.Yes)
                {
                    ExportMod(parameter);
                }
            }
            else
            {
                ExportMod(parameter);
            }
        }

        private void ExportMod(object parameter)
        {
            MainWindow mainWin = parameter as MainWindow;
            ModSettingsWindow win = new ModSettingsWindow(mainWin.Project);
            win.ShowDialog();

            if (win.DialogResult == true)
            {
                FrostySaveFileDialog sfd = new FrostySaveFileDialog("Save Mod", "*.fbmod (Frosty Mod)|*.fbmod", "Mod");
                if (sfd.ShowDialog())
                {
                    string filename = sfd.FileName;
                    FrostyTaskWindow.Show("Saving Mod", "", (task) => { mainWin.ExportMod(mainWin.Project.GetModSettings(), filename, false); });
                }
            }
        }
    }
}
