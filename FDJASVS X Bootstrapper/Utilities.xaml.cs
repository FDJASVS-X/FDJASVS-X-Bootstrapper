using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
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
using BloxInstaller_DLL;
using FDJASVS_X_Bootstrapper;


namespace FDJASVS_X_Bootstrapper
{
   



    public partial class Utilities : Page
    {
        public Utilities()
        {
            InitializeComponent();
            this.Loaded += Utilities_Loaded;
        }

        BloxInstallerExecutables bloxInstallerExecutables = new BloxInstallerExecutables();

        private void Utilities_Loaded(object sender, RoutedEventArgs e)
        {
            // Load saved settings and set the checkbox states
            CircleCheckBox.IsChecked = Properties.Settings.Default.CircleCheckBoxSetting;
            OutlineCheckBox.IsChecked = Properties.Settings.Default.OutlineCheckBoxSetting;
            xrayCheckBox.IsChecked = Properties.Settings.Default.xrayCheckBoxSetting;
         

            
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
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set CircleCheckBoxSetting Setting To " + Properties.Settings.Default.CircleCheckBoxSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
           
          
        }

        private void CircleBox_Unchecked(object sender, RoutedEventArgs e)
        {
            
            CircleUnderAvatars = false;
            Properties.Settings.Default.CircleCheckBoxSetting = false;
            Properties.Settings.Default.Save(); // Save the setting
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set CircleCheckBoxSetting Setting To " + Properties.Settings.Default.CircleCheckBoxSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void OutlineBox_Checked(object sender, RoutedEventArgs e)
        {
            
            Outline = true;
            Properties.Settings.Default.OutlineCheckBoxSetting = true;
            Properties.Settings.Default.Save(); // Save the setting
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set OutlineCheckBoxSetting Setting To " + Properties.Settings.Default.OutlineCheckBoxSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
          
        }

        private void OutlineBox_Unchecked(object sender, RoutedEventArgs e)
        {
           
            Outline = false;
            Properties.Settings.Default.OutlineCheckBoxSetting = false;
            Properties.Settings.Default.Save(); // Save the setting
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set OutlineCheckBoxSetting Setting To " + Properties.Settings.Default.OutlineCheckBoxSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void xrayBox_Checked(object sender, RoutedEventArgs e)
        {
         
           
            xray = true;
            Properties.Settings.Default.xrayCheckBoxSetting = true;
            Properties.Settings.Default.Save(); // Save the setting
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set xrayCheckBoxSetting Setting To " + Properties.Settings.Default.xrayCheckBoxSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
          
        }

        private void xrayBox_Unchecked(object sender, RoutedEventArgs e)
        {
            
           
            xray = false;
            Properties.Settings.Default.xrayCheckBoxSetting = false;
            Properties.Settings.Default.Save(); // Save the setting
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set xrayCheckBoxSetting Setting To " + Properties.Settings.Default.xrayCheckBoxSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void SuperJumpBox_Checked(object sender, RoutedEventArgs e)
        {
           
            SuperJump = true;
            Properties.Settings.Default.SuperJumpCheckBoxSetting = true;
            Properties.Settings.Default.Save(); // Save the setting
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set SuperJumpCheckBoxSetting Setting To " + Properties.Settings.Default.SuperJumpCheckBoxSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            
        }

        private void SuperJumpBox_Unchecked(object sender, RoutedEventArgs e)
        {
          
            SuperJump = false;
            Properties.Settings.Default.SuperJumpCheckBoxSetting = false;
            Properties.Settings.Default.Save(); // Save the setting
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set SuperJumpCheckBoxSetting Setting To " + Properties.Settings.Default.SuperJumpCheckBoxSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        

      

        private async void SaveBtnU_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Do you want to save?", "FDJASVS X Bootstrapper", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                try
                {

                    SaveBtnU.IsEnabled = false;
                    if (Properties.Settings.Default.CircleCheckBoxSetting == true)
                    {
                        if (!EmeraldGG.CheckExistsFlag("FFlagDebugAvatarChatVisualization") && !EmeraldGG.CheckExistsFlag("FFlagEnableInGameMenuChromeABTest2"))
                        {
                            await EmeraldGG.AddFlag("FFlagDebugAvatarChatVisualization", "True");
                            await EmeraldGG.AddFlag("FFlagEnableInGameMenuChromeABTest2", "False");
                        }

                    }
                    else
                    {

                        await EmeraldGG.RemoveFlag("FFlagDebugAvatarChatVisualization");
                        await EmeraldGG.RemoveFlag("FFlagEnableInGameMenuChromeABTest2");
                    }

                    if (Properties.Settings.Default.OutlineCheckBoxSetting == true)
                    {
                        if (!EmeraldGG.CheckExistsFlag("DFFlagDebugDrawBroadPhaseAABBs"))
                        {
                            await EmeraldGG.AddFlag("DFFlagDebugDrawBroadPhaseAABBs", "True");
                        }
                    }
                    else
                    {
                        await EmeraldGG.RemoveFlag("DFFlagDebugDrawBroadPhaseAABBs");
                    }

                    if (Properties.Settings.Default.xrayCheckBoxSetting == true)
                    {
                        if (!EmeraldGG.CheckExistsFlag("FIntCameraFarZPlane") && !EmeraldGG.CheckExistsFlag("DFIntCullFactorPixelThresholdMainViewHighQuality") && !EmeraldGG.CheckExistsFlag("DFIntCullFactorPixelThresholdShadowMapHighQuality") && !EmeraldGG.CheckExistsFlag("DFIntCullFactorPixelThresholdShadowMapLowQuality"))
                        {
                            await EmeraldGG.AddFlag("FIntCameraFarZPlane", "1");
                            await EmeraldGG.AddFlag("DFIntCullFactorPixelThresholdMainViewHighQuality", "1000");
                            await EmeraldGG.AddFlag("DFIntCullFactorPixelThresholdShadowMapHighQuality", "10000");
                            await EmeraldGG.AddFlag("DFIntCullFactorPixelThresholdShadowMapLowQuality", "10000");
                        }
                    }
                    else
                    {
                        await EmeraldGG.RemoveFlag("FIntCameraFarZPlane");
                        await EmeraldGG.RemoveFlag("DFIntCullFactorPixelThresholdMainViewHighQuality");
                        await EmeraldGG.RemoveFlag("DFIntCullFactorPixelThresholdShadowMapHighQuality");
                        await EmeraldGG.RemoveFlag("DFIntCullFactorPixelThresholdShadowMapLowQuality");
                    }

                    if (Properties.Settings.Default.SuperJumpCheckBoxSetting == true)
                    {
                        if (!EmeraldGG.CheckExistsFlag("DFIntNewRunningBaseGravityReductionFactorHundredth"))
                        {
                            await EmeraldGG.AddFlag("DFIntNewRunningBaseGravityReductionFactorHundredth", "1500");
                        }
                    }
                    else
                    {
                        await EmeraldGG.RemoveFlag("DFIntNewRunningBaseGravityReductionFactorHundredth");
                    }

                   

                    MessageBox.Show("Saving Success!", "FDJASVS X Bootstrapper");
                    SaveBtnU.IsEnabled = false;


                    await Task.Delay(15000);
                    SaveBtnU.IsEnabled = true;
                }
                catch (Exception ex)
                {
                    SaveBtnU.IsEnabled = true;
                    MessageBox.Show("Something went wrong during saving: \n" + "\n" + ex.Message + "\n" + "\nPlease Try Again or issue a bug on Our GitHub Repository", "FDJASVS X Bootstrapper", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                
            }
        }
    }
}
