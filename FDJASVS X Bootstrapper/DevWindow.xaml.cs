using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BloxInstaller_DLL;

namespace FDJASVS_X_Bootstrapper
{
    /// <summary>
    /// Logika interakcji dla klasy DevWindow.xaml
    /// </summary>
    public partial class DevWindow : Window
    {
        public DevWindow()
        {
            InitializeComponent();
            this.Loaded += DevSettings_Loaded;

            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            BloxInstallerExecutables bloxInstallerExecutables = new BloxInstallerExecutables();

            DevRobloxVer.Text = "Current Roblox Version: " + EmeraldGG.GetLatestVersion();

        }

        public bool ChannelWarned = false;

        private void DevSettings_Loaded(object sender, RoutedEventArgs e)
        {
            // Load saved settings and set the checkbox states
            ChannelsssTextBox.Text = Properties.Settings.Default.Channel;
            DebugModeCheckBox.IsChecked = Properties.Settings.Default.DevModeDebug;
        }

        private async void DevDownRoblox(object sender, RoutedEventArgs e)
        {
            BloxInstallerExecutables bloxInstallerExecutables = new BloxInstallerExecutables();

            var method = typeof(BloxInstallerExecutables).GetMethod("DownloadRobloxTask", BindingFlags.NonPublic | BindingFlags.Instance);
            await(Task)method.Invoke(bloxInstallerExecutables, null);
        }

        private void ChannTextBoxFocus(object sender, RoutedEventArgs e)
        {
            if (ChannelWarned == false)
            {
                MessageBox.Show("MODIFYING THIS VALUE MAY LEAD TO UNINTENDED CONSEQUENCES, IF YOU DON'T KNOW WHAT YOU'RE DOING AVOID CHANGING THIS VALUE. YOU HAVE BEEN WARNED", "FDJASVS", MessageBoxButton.OK, MessageBoxImage.Warning);
                ChannelWarned = true;
            }
        }

        private async void ButtonGotFocus(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("As Warned earlier, Modifying this value may Result In Consequences. Are you Sure You want To Switch Channels? It Is Recommended To Stay On The Channel LIVE", "BloxInstaller", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                Properties.Settings.Default.Channel = ChannelsssTextBox.Text;
                Properties.Settings.Default.Save();
                BloxInstallerExecutables bloxInstallerExecutables = new BloxInstallerExecutables();

                bloxInstallerExecutables.SetChannel();
                MessageBoxResult result3 = MessageBox.Show("Do you want To re-download Roblox? This Is For Real Your Last Chance Before Consequences Could Happen. I warned you...", "Emerald", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
                if (result3 == MessageBoxResult.Yes)
                {
                    MessageBox.Show("As you wish....", "BloxInstaller");
                    var method = typeof(BloxInstallerExecutables).GetMethod("DownloadRobloxTask", BindingFlags.NonPublic | BindingFlags.Instance);
                    await (Task)method.Invoke(bloxInstallerExecutables, null);
                }
            }

        }

        private void DexBox_Checked(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.DevModeDebug == false)
            {
                MessageBox.Show("Debug Mode Has Been Enabled", "Debugger");
                MessageBox.Show("You'll now see what FDJASVS X Bootstrapper Is Doing in the background", "Debugger", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                MessageBox.Show("It might Be a bit Annoying, But I Suppose you've turned it on out of curiosity. Well, have fun! Also, You can Always Turn It Off :)", "Debugger", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
     
            Properties.Settings.Default.DevModeDebug = true;
            Properties.Settings.Default.Save();     
        }

        private void DexBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.DevModeDebug = false;
            Properties.Settings.Default.Save();
        }
    }
}
