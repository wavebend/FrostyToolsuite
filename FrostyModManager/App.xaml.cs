using Frosty.Controls;
using Frosty.Core;
using Frosty.Core.Controls;
using Frosty.Core.Managers;
using Frosty.Core.Windows;
using FrostyCore;
using FrostySdk;
using FrostySdk.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Reflection;
using System.Text;
using System.Windows;

namespace FrostyModManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        public static ILogger Logger { get => Frosty.Core.App.Logger; private set => Frosty.Core.App.Logger = value; }
        
        public static string SelectedPack { get => Frosty.Core.App.SelectedPack; set => Frosty.Core.App.SelectedPack = value; }

        public static bool LaunchGameImmediately 
        { 
            get => launchGameImmediately;
            set => launchGameImmediately = value;
        }

        public static string LaunchProfile { get; private set; }
        public static string LaunchArgs { get; private set; }

        public static PluginManager PluginManager { get => Frosty.Core.App.PluginManager; private set => Frosty.Core.App.PluginManager = value; }
        public static NotificationManager NotificationManager { get => Frosty.Core.App.NotificationManager; private set => Frosty.Core.App.NotificationManager = value; }

        private List<FrostyConfiguration> configs = new List<FrostyConfiguration>();
        private FrostyConfiguration defaultConfig = null;

        private Config ini = new Config();

        private static bool launchGameImmediately;

        public App()
        {
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            Frosty.Core.App.Version = entryAssembly.GetName().Version + " - " + Frosty.Core.App.BuildVersion;

            Frosty.Core.App.IsEditor = false;
            Frosty.Core.App.Title = "Frosty Mod Manager";

            Logger = new FrostyLogger();
            Logger.Log("Frosty Mod Manager v{0}", Frosty.Core.App.Version);

            FileUnblocker.UnblockDirectory(".\\");
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            TypeLibrary.Initialize();
            PluginManager = new PluginManager(Logger, PluginManagerType.ModManager);
            ProfilesLibrary.Initialize(PluginManager.Profiles);

            NotificationManager = new NotificationManager();

            // for displaying exception box on all unhandled exceptions
            DispatcherUnhandledException += App_DispatcherUnhandledException;

#if FROSTY_DEVELOPER
            Frosty.Core.App.Version += " (Developer)";
#elif FROSTY_ALPHA
            Frosty.Core.App.Version += $" (ALPHA {Frosty.Core.App.Version})";
#elif FROSTY_BETA
            Frosty.Core.App.Version += $" (BETA {Frosty.Core.App.Version})";
#endif
        }

        private static void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            Exception exp = e.Exception;

            FrostyExceptionBox.Show(exp, "Frosty Mod Manager");
            Environment.Exit(0);
        }

        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string dllName = args.Name.Contains(",") ? args.Name.Substring(0, args.Name.IndexOf(',')) : args.Name;
            if (dllName.StartsWith("SharpDX") || dllName.StartsWith("Newtonsoft") || dllName.StartsWith("Ookii") || dllName.StartsWith("GongSolutions") && !dllName.EndsWith(".resources"))
            {
                FileInfo fi = new FileInfo(Assembly.GetExecutingAssembly().FullName);
                return Assembly.LoadFile(fi.DirectoryName + "/ThirdParty/" + dllName + ".dll");
            }

            if (dllName.Equals("EbxClasses"))
            {
                FileInfo fi = new FileInfo(Assembly.GetExecutingAssembly().FullName);
                return Assembly.LoadFile(fi.DirectoryName + "/Profiles/" + ProfilesLibrary.SDKFilename + ".dll");
            }

            if (PluginManager != null)
            {
                if (dllName.StartsWith("GongSolutions"))
                {
                    FileInfo fi = new FileInfo(Assembly.GetExecutingAssembly().FullName);
                    return PluginManager.GetPluginAssembly(fi.DirectoryName + "/ThirdParty/" + dllName);
                }
                
                return PluginManager.GetPluginAssembly(dllName);
            }

            return null;
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            if (!File.Exists($"{Frosty.Core.App.GlobalSettingsPath}/manager_config.json"))
            {
                Config.UpgradeConfigs();
            }

            Config.Load();

            StringBuilder sb = new StringBuilder();
            if (e.Args.Length > 0)
            {
                string arg = e.Args[0];
                if (arg == "-launch")
                {
                    if (e.Args.Length < 2)
                    {
                        FrostyMessageBox.Show("-launch argument found, but missing profile name", "Frosty Mod Manager");
                        Current.Shutdown();
                        return;
                    }

                    launchGameImmediately = true;
                    LaunchProfile = e.Args[1];

                    for (int i = 2; i < e.Args.Length; i++)
                    {
                        arg = e.Args[i];
                        sb.Append(arg + " ");
                    }
                }
            }

            LaunchArgs = sb.ToString().Trim();
        }

        public static void CheckVersion()
        {
            //bool checkPrerelease = Config.Get<bool>("UpdateCheckPrerelease", false);
            Version localVersion = new Version(Frosty.Core.App.BuildVersion);

            try
            {
                if (UpdateCheckerUtils.CheckVersion(false, localVersion))
                {
                    System.Threading.Tasks.Task.Run(() =>
                    {
                        Current.Dispatcher.Invoke(delegate {
                            SystemSounds.Exclamation.Play();
                            UpdateCheckerWindow win = new UpdateCheckerWindow { Owner = Current.MainWindow };
                            if (win.ShowDialog() == true)
                            {
                                System.Diagnostics.Process.Start("https://github.com/J-Lyt/FrostyToolsuite/releases/latest");
                            }
                        });
                    });
                }
            }
            catch (Exception e)
            {
                System.Threading.Tasks.Task.Run(() =>
                {
                    FrostyMessageBox.Show("Frosty Update Checker returned with an error:\n\n" + e.Message, "Frosty Mod Manager", MessageBoxButton.OK);
                });
            }
        }
    }
}
