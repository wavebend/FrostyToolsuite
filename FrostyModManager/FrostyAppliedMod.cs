using Frosty.Core;
using Frosty.Core.Mod;
using FrostySdk;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                else if (BackupFileName.EndsWith("_Separator"))
                {
                    return BackupFileName.Replace("_Separator", "");
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
                else if (BackupFileName.EndsWith("_Separator"))
                {
                    return null;
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

        public List<string> packList;

        public int ModIndex
        {
            get 
            {
                string modFilename = BackupFileName;

                if (Mod != null)
                {
                    modFilename = Mod.Filename;
                }

                string selectedPack = Config.Get<string>("SelectedPack", "", ConfigScope.Game);
                string pack = Config.Get(selectedPack, "", ConfigScope.Pack);

                packList = pack.Split('|').ToList();

                int index = packList.FindIndex(x => x == $"{modFilename}:{IsEnabled}");
                return index;
            }
        }

        public string ModPriority
        {
            get 
            {
                if (ModIndex == 0)
                {
                    return "Low Priority";
                }
                else if (ModIndex == packList.Count - 1)
                {
                    return "High Priority";
                }
                else
                {
                    return null;
                }
            }
        }

        public string ModVisibility
        {
            get 
            {
                if (Mod == null && BackupFileName.EndsWith("_Separator"))
                {
                    return "Collapsed";
                }
                else
                {
                    return "Visible";
                }
            }
        }

        public string ModHorizontalAlignment
        {
            get 
            {
                if (Mod == null && BackupFileName.EndsWith("_Separator"))
                {
                    return "Center";
                }
                else
                {
                    return "Stretch";
                }
            }
        }

        public string ModFontWeight {
            get {
                if (Mod == null && BackupFileName.EndsWith("_Separator"))
                {
                    return "Bold";
                }
                else
                {
                    return "Normal";
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
