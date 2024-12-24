using BloxInstaller_DLL;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows;

namespace FDJASVS_X_Booting_Application
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private async void Application_Startup(object sender, StartupEventArgs e)
        {
            await Task.Delay(2000);
            Process.Start(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Versions" + "\\version-b71c150c7c1f40de" + "\\RobloxPlayerBeta.exe", string.Join(" ", e.Args));
            Environment.Exit(0);
        }
    }

}