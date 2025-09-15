using System.Linq;
using System.Windows.Media;
using Frosty.Controls;
using Frosty.Core;
using FrostySdk;
using UnifyAssetsPlugin.Windows;

namespace UnifyAssetsPlugin.Extensions
{
    public class UnifyAssetsMenuExtension : MenuExtension
    {
        private static ImageSource imageSource = new ImageSourceConverter().ConvertFromString("pack://application:,,,/FrostyEditor;component/Images/Compile.png") as ImageSource;
        
        public override string TopLevelMenuName => "Tools";

        public override string MenuItemName => "Unify Assets";
        
        public override ImageSource Icon => imageSource;

        public override RelayCommand MenuItemClicked => new RelayCommand((o) =>
        {
            bool isSteam = GameVersions.DragonAgeTheVeilguardSteam.Contains((int)App.FileSystemManager.Head);

            if (!UnifyAssets.CheckChunks(isSteam))
            {
                UnifyAssetsWindow win =  new UnifyAssetsWindow();

                if (win.ShowDialog() == true)
                {
                    UnifyAssets.UnifyChunks();
                }
            }
            else
            {
                FrostyMessageBox.Show($"This project is already compatible with Steam and EA versions of\n{UnifyAssets.DisplayName}.", "Unify Assets");
            }
        });
    }
}
