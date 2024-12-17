using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.Json.Nodes;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using BloxInstaller_DLL;
using FDJASVS_X_Bootstrapper;

namespace FDJASVS_X_Bootstrapper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if (!Path.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Versions")))
            {
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "Versions"));
            }
            DoFastFlagLoading();


            if (Properties.Settings.Default.DeveloperMode == true)
            {
                CustomFlagsButton.Visibility = Visibility.Visible;
                this.Height = 370;
            }
        }

        public async static void DoFastFlagLoading()
        {
            if (await EmeraldGG.InitializationAsync() == 1)
            {
                File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "Versions", EmeraldGG.GetLatestVersion(), "ClientSettings", "ClientAppSettings.json"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "FastFlags.txt")));
            }
            else
            {
                if (Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "FastFlags.txt")))
                {
                    File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "FastFlags.txt"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Versions", EmeraldGG.GetLatestVersion(), "ClientSettings", "ClientAppSettings.json")));
                }
                else
                {
                    File.Create(Path.Combine(Directory.GetCurrentDirectory(), "FastFlags.txt")).Close();
                    File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "FastFlags.txt"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Versions", EmeraldGG.GetLatestVersion(), "ClientSettings", "ClientAppSettings.json")));
                }
                Properties.Settings.Default.FastFlags = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Versions", EmeraldGG.GetLatestVersion(), "ClientSettings", "ClientAppSettings.json"));
                Properties.Settings.Default.Save();
            };
        }



        private async void Button_Click(object sender, RoutedEventArgs e)
        {
           
            Utilities utilities = new Utilities();


            this.Content = utilities;


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Other otherPage = new Other();


            this.Content = otherPage;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            Settings Settingspage = new Settings();

 
            this.Content = Settingspage;
        }

        private void CustomClick(object sender, RoutedEventArgs e)
        {

            FFMWindow fFMWindow = new FFMWindow();

            fFMWindow.Show();
        }


        private async void DevModeClick(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.DeveloperMode == true)
            {
                
                

                // Create an instance of the Hacks page
                DevWindow devWindow = new DevWindow();

                // Navigate to the Hacks page
                devWindow.Show();

                if (Properties.Settings.Default.DevModeDebug == true)
                {
                    MessageBox.Show("DevWindow Open!", "Debugger", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            else if (Properties.Settings.Default.DeveloperMode == false)
            {
                MessageBoxResult DevResult = MessageBox.Show("Are you sure you want To Enable Developer Mode? It Will Unlock Features To Be Used With Extreme Caution or else It'll Result In Consequences. Do You Want To Proceed?", "FDJASVS X Bootstrapper", MessageBoxButton.YesNo);
                if (DevResult == MessageBoxResult.Yes)
                {
                    Properties.Settings.Default.DeveloperMode = true;
                    Properties.Settings.Default.Save();
                }
            }
        }
    }
}