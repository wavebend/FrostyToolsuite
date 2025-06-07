using Frosty.Core;
using Frosty.Core.Mod;
using FrostySdk;
using System.IO;
using System.Windows.Media;

namespace FrostyModManager
{
    public class FrostyAppliedMod
    {
        public string ModName
        {
            get
            {
                if (Mod != null)
                {
                    return Mod.ModDetails.Title;
                }
                else
                {
                    return BackupFileName;
                }
            }
        }
        public ImageSource ModIcon
        {
            get
            {
                if (Mod != null)
                {
                    if (Mod.ModDetails.Icon != null)
                    {
                        return Mod.ModDetails.Icon;
                    }
                    else
                    {
                        return new ImageSourceConverter().ConvertFromString("pack://application:,,,/FrostyModManager;component/Images/DefaultModIcon.png") as ImageSource;
                    }
                }
                else
                {
                    return new ImageSourceConverter().ConvertFromString("pack://application:,,,/FrostyModManager;component/Images/ModImportWarningApplied.png") as ImageSource;
                }
            }
        }

        public string ModTooltip 
        {
            get 
            {
                if (Mod == null)
                {
                    DirectoryInfo modsDir = new DirectoryInfo(Path.Combine("Mods", ProfilesLibrary.ProfileName));

                    if (Config.Get<bool>("UseCustomModsDirectory", false) && Directory.Exists(Config.Get<string>("CustomModsDirectory", "")))
                    {
                        modsDir = new DirectoryInfo(Path.Combine(Config.Get<string>("CustomModsDirectory", ""), ProfilesLibrary.ProfileName));
                    }
                        
                    return $"Missing from: {modsDir}";
                }
                else
                {
                    return null;
                } 
            }
        }

        public bool IsEnabled { get; set; }
        public bool IsFound { get; set; }
        public IFrostyMod Mod { get; }

        public string BackupFileName { get; }

        public FrostyAppliedMod(IFrostyMod inMod, bool inIsEnabled = true)
        {
            Mod = inMod;
            IsEnabled = inIsEnabled;
            IsFound = true;
        }

        public FrostyAppliedMod(string inBackupFileName, bool inIsEnabled = true)
        {
            BackupFileName = inBackupFileName;
            IsEnabled = inIsEnabled;
            IsFound = false;
        }
    }
}
