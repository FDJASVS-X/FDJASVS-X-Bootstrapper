using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FDJASVS_X_Bootstrapper
{
    /// <summary>
    /// Logika interakcji dla klasy Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        public Settings()
        {
            InitializeComponent();
            this.Loaded += Settings_Loaded;
        }

        private void Settings_Loaded(object sender, RoutedEventArgs e)
        {
            // Load saved settings and set the checkbox states
            RPCheckBox.IsChecked = Properties.Settings.Default.RPCSetting;
           MultInstanceCheckBox.IsChecked = Properties.Settings.Default.MultiInstanceLaunchingSetting;
            OldDeathCheckBox.IsChecked = Properties.Settings.Default.OldDeathSoundS;
            OldAvatarModelSwapCheckBox.IsChecked = Properties.Settings.Default.OldAvatarBack;
            AutoUpdateCheckBox.IsChecked = Properties.Settings.Default.AutoUpdatePLS;
         
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            // Get the current window that hosts the Hacks page
            Window currentWindow = Window.GetWindow(this);

            // Capture the position of the current window
            double left = currentWindow.Left;
            double top = currentWindow.Top;

            // Instantiate MainWindow
            MainWindow mainWindow = new MainWindow();

            // Set the position of the MainWindow to match the current window's position
            mainWindow.Left = left;
            mainWindow.Top = top;

            // Show the MainWindow
            mainWindow.Show();

            // Close the current window
            currentWindow.Close();
        }



        private void Multi_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.MultiInstanceLaunchingSetting = true;
            Properties.Settings.Default.Save();
        }

        private void Multi_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.MultiInstanceLaunchingSetting = false;
            Properties.Settings.Default.Save();
        }

        private void RPCBox_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.RPCSetting = true;
            Properties.Settings.Default.Save();
        }

        private void RPCBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.RPCSetting = false;
            Properties.Settings.Default.Save();
        }

        

        private void AutoUpdate_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.AutoUpdatePLS = true;
            Properties.Settings.Default.Save();

        }

      

        private void AutoUpdate_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.AutoUpdatePLS = false;
            Properties.Settings.Default.Save();
        }

        private void OldDeath_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.OldDeathSoundS = true;
            Properties.Settings.Default.Save();
        }



        private void OldDeath_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.OldDeathSoundS = false;
            Properties.Settings.Default.Save();
        }

        private void Swap_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.OldAvatarBack = true;
            Properties.Settings.Default.Save();
        }



        private void Swap_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.OldAvatarBack = false;
            Properties.Settings.Default.Save();
        }

        
    }
}
