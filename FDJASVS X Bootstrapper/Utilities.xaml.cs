﻿using System;
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
            SemiCheckBox.IsEnabled = false;
           
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
            SemiCheckBox.IsEnabled = true;
           
            xray = false;
            Properties.Settings.Default.xrayCheckBoxSetting = false;
            Properties.Settings.Default.Save(); // Save the setting
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set xrayCheckBoxSetting Setting To " + Properties.Settings.Default.xrayCheckBoxSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void SpeedBox_Checked(object sender, RoutedEventArgs e)
        {
           
            SpeedHack = true;
            Properties.Settings.Default.SpeedHackCheckBoxSetting = true;
            Properties.Settings.Default.Save(); // Save the setting
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set SpeedHackCheckBoxSetting Setting To " + Properties.Settings.Default.SpeedHackCheckBoxSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
           
        }

        private void SpeedBox_Unchecked(object sender, RoutedEventArgs e)
        {
            
            SpeedHack = false;
            Properties.Settings.Default.SpeedHackCheckBoxSetting = false;
            Properties.Settings.Default.Save(); // Save the setting
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set SpeedHackCheckBoxSetting Setting To " + Properties.Settings.Default.SpeedHackCheckBoxSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
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

        

        private void SemiBox_Checked(object sender, RoutedEventArgs e)
        {
            xrayCheckBox.IsEnabled = false;
           
            Semi = true;
            Properties.Settings.Default.SemiCheckBoxSetting = true;
            Properties.Settings.Default.Save(); // Save the setting
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set SemiCheckBoxSetting Setting To " + Properties.Settings.Default.SemiCheckBoxSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
           
        }

        private void SemiBox_Unchecked(object sender, RoutedEventArgs e)
        {
            xrayCheckBox.IsEnabled = true;
           
            Semi = false;
            Properties.Settings.Default.SemiCheckBoxSetting = false;
            Properties.Settings.Default.Save(); // Save the setting
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set SemiCheckBoxSetting Setting To " + Properties.Settings.Default.SemiCheckBoxSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private async void SaveBtnU_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Do you want to save?", "FDJASVS X Bootstrapper", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {

                SaveBtnU.IsEnabled = false;
                if (Properties.Settings.Default.CircleCheckBoxSetting == true)
                {
                    EmeraldGG.QuickAddFlag("FFlagDebugAvatarChatVisualization", "True");
                    EmeraldGG.QuickAddFlag("FFlagEnableInGameMenuChromeABTest2", "False");
                }
                else
                {
                    EmeraldGG.QuickRemoveFlag("FFlagDebugAvatarChatVisualization");
                    EmeraldGG.QuickRemoveFlag("FFlagEnableInGameMenuChromeABTest2");
                }

                if (Properties.Settings.Default.OutlineCheckBoxSetting == true)
                {
                    EmeraldGG.QuickAddFlag("DFFlagDebugDrawBroadPhaseAABBs", "True");
                }
                else
                {
                    EmeraldGG.QuickRemoveFlag("DFFlagDebugDrawBroadPhaseAABBs");
                }

                if (Properties.Settings.Default.xrayCheckBoxSetting == true)
                {
                    EmeraldGG.QuickAddFlag("FIntCameraFarZPlane", "1");
                    EmeraldGG.QuickAddFlag("DFIntCullFactorPixelThresholdMainViewHighQuality", "1000");
                    EmeraldGG.QuickAddFlag("DFIntCullFactorPixelThresholdShadowMapHighQuality", "10000");
                    EmeraldGG.QuickAddFlag("DFIntCullFactorPixelThresholdShadowMapLowQuality", "10000");
                }
                else
                {
                    EmeraldGG.QuickRemoveFlag("FIntCameraFarZPlane");
                    EmeraldGG.QuickRemoveFlag("DFIntCullFactorPixelThresholdMainViewHighQuality");
                    EmeraldGG.QuickRemoveFlag("DFIntCullFactorPixelThresholdShadowMapHighQuality");
                    EmeraldGG.QuickRemoveFlag("DFIntCullFactorPixelThresholdShadowMapLowQuality");
                }

                if (Properties.Settings.Default.SpeedHackCheckBoxSetting == true)
                {
                    EmeraldGG.QuickAddFlag("FFlagDebugSimIntegrationStabilityTesting", "true");
                }
                else
                {
                    EmeraldGG.QuickRemoveFlag("FFlagDebugSimIntegrationStabilityTesting");
                }

                if (Properties.Settings.Default.SuperJumpCheckBoxSetting == true)
                {
                    EmeraldGG.QuickAddFlag("DFIntNewRunningBaseGravityReductionFactorHundredth", "1500");
                }
                else
                {
                    EmeraldGG.QuickRemoveFlag("DFIntNewRunningBaseGravityReductionFactorHundredth");
                }

                if (Properties.Settings.Default.SemiCheckBoxSetting == true)
                {
                    EmeraldGG.QuickAddFlag("FFlagFastGPULightCulling3", "True");
                    EmeraldGG.QuickAddFlag("FIntRenderShadowIntensity", "0");
                    EmeraldGG.QuickAddFlag("DFIntCullFactorPixelThresholdShadowMapHighQuality", "2147483647");
                    EmeraldGG.QuickAddFlag("DFIntCullFactorPixelThresholdShadowMapLowQuality", "2147483647");
                    EmeraldGG.QuickAddFlag("FFlagNewLightAttenuation", "True");
                    EmeraldGG.QuickAddFlag("FIntRenderShadowmapBias", "-1");
                    EmeraldGG.QuickAddFlag("DFFlagDebugPauseVoxelizer", "True");
                }
                else
                {
                    EmeraldGG.QuickRemoveFlag("FFlagFastGPULightCulling3");
                    EmeraldGG.QuickRemoveFlag("FIntRenderShadowIntensity");
                    EmeraldGG.QuickRemoveFlag("DFIntCullFactorPixelThresholdShadowMapHighQuality");
                    EmeraldGG.QuickRemoveFlag("DFIntCullFactorPixelThresholdShadowMapLowQuality");
                    EmeraldGG.QuickRemoveFlag("FFlagNewLightAttenuation");
                    EmeraldGG.QuickRemoveFlag("FIntRenderShadowmapBias");
                    EmeraldGG.QuickRemoveFlag("DFFlagDebugPauseVoxelizer");
                }

                await Task.Delay(15000);
                SaveBtnU.IsEnabled = false;
            }
        }
    }
}