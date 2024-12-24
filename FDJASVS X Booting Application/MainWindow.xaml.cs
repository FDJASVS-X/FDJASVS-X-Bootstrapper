using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using FDJASVS_X_Bootstrapper;
using Wpf.Ui.Controls;
using BloxInstaller_DLL;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace FDJASVS_X_Booting_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FluentWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;





            LoadMultiInstancer();

        }

        public async static void LoadMultiInstancer()
        {
            int DownloadRoblox = await EmeraldGG.InitializationAsync();
            await GetMultInstancer();
        }


        public async static Task<int> GetMultInstancer()
        {

            if (!Path.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "MultiInstance.txt")))
            {
                File.Create(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "MultiInstance.txt")).Close();
                File.WriteAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "MultiInstance.txt"), "false");
            }

            if (File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "MultiInstance.txt")) == "true")
            {
                Process[] processes = Process.GetProcessesByName("MultiInstancer");
                if (processes.Length > 0)
                {
                    return 1;
                }
                else
                {
                    Process.Start(new ProcessStartInfo().FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\MultiInstancer.exe");
                    return 2;
                }
            }
            else
            {
                Process[] processes = Process.GetProcessesByName("MultiInstancer.exe");
                foreach (Process process in processes)
                {
                    process.Kill();
                }
                return 3;
            }

        }

    }
}