using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ModernWPF;
using ModernWPF.Controls;
using FDJASVS_X_Bootstrapper;


namespace FDJASVS_X_Bootstrapper
{
    /// <summary>
    /// Logika interakcji dla klasy Hacks.xaml
    /// </summary>
    /// 



    public partial class Hacks : Page
    {
        public Hacks()
        {
            InitializeComponent();
            this.Loaded += Hacks_Loaded;
        }

        BloxInstallerExecutables bloxInstallerExecutables = new BloxInstallerExecutables();

        private void Hacks_Loaded(object sender, RoutedEventArgs e)
        {
            // Load saved settings and set the checkbox states
            CircleCheckBox.IsChecked = Properties.Settings.Default.CircleCheckBoxSetting;
            OutlineCheckBox.IsChecked = Properties.Settings.Default.OutlineCheckBoxSetting;
            xrayCheckBox.IsChecked = Properties.Settings.Default.xrayCheckBoxSetting;
            SpeedHackCheckBox.IsChecked = Properties.Settings.Default.SpeedHackCheckBoxSetting;
            PSuperJumpCheckBox.IsChecked = Properties.Settings.Default.SuperJumpCheckBoxSetting;
            SemiCheckBox.IsChecked = Properties.Settings.Default.SemiCheckBoxSetting;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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



        public bool CircleUnderAvatars = false;
        public bool Outline = false;
        public bool xray = false;
        public bool SpeedHack = false;
        public bool SuperJump = false;
        public bool Semi = false;



        private void CircleBox_Checked(object sender, RoutedEventArgs e)
        {
            CircleUnderAvatars = true;
            Properties.Settings.Default.CircleCheckBoxSetting = true;    
            Properties.Settings.Default.Save(); // Save the setting
        }

        private void CircleBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CircleUnderAvatars = false;
            Properties.Settings.Default.CircleCheckBoxSetting = false;
            Properties.Settings.Default.Save(); // Save the setting
        }

        private void OutlineBox_Checked(object sender, RoutedEventArgs e)
        {
            Outline = true;
            Properties.Settings.Default.OutlineCheckBoxSetting = true;
            Properties.Settings.Default.Save(); // Save the setting
        }

        private void OutlineBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Outline = false;
            Properties.Settings.Default.OutlineCheckBoxSetting = false;
            Properties.Settings.Default.Save(); // Save the setting
        }

        private void xrayBox_Checked(object sender, RoutedEventArgs e)
        {
            xray = true;
            Properties.Settings.Default.xrayCheckBoxSetting = true;
            Properties.Settings.Default.Save(); // Save the setting
        }

        private void xrayBox_Unchecked(object sender, RoutedEventArgs e)
        {
            xray = false;
            Properties.Settings.Default.xrayCheckBoxSetting = false;
            Properties.Settings.Default.Save(); // Save the setting
        }

        private void SpeedBox_Checked(object sender, RoutedEventArgs e)
        {
            SpeedHack = true;
            Properties.Settings.Default.SpeedHackCheckBoxSetting = true;
            Properties.Settings.Default.Save(); // Save the setting
        }

        private void SpeedBox_Unchecked(object sender, RoutedEventArgs e)
        {
            SpeedHack = false;
            Properties.Settings.Default.SpeedHackCheckBoxSetting = false;
            Properties.Settings.Default.Save(); // Save the setting
        }

        private void SuperJumpBox_Checked(object sender, RoutedEventArgs e)
        {
            SuperJump = true;
            Properties.Settings.Default.SuperJumpCheckBoxSetting = true;
            Properties.Settings.Default.Save(); // Save the setting
        }

        private void SuperJumpBox_Unchecked(object sender, RoutedEventArgs e)
        {
            SuperJump = false;
            Properties.Settings.Default.SuperJumpCheckBoxSetting = false;
            Properties.Settings.Default.Save(); // Save the setting
        }

        private void SemiBox_Checked(object sender, RoutedEventArgs e)
        {
            Semi = true;
            Properties.Settings.Default.SemiCheckBoxSetting = true;
            Properties.Settings.Default.Save(); // Save the setting
        }

        private void SemiBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Semi = false;
            Properties.Settings.Default.SemiCheckBoxSetting = false;
            Properties.Settings.Default.Save(); // Save the setting
        }


    }
}
