﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BloxInstaller_DLL;

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
            QualityChangerBoxx.IsChecked = Properties.Settings.Default.BoxxSetting;
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
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set MultiInstanceLaunchingSetting Setting To " + Properties.Settings.Default.MultiInstanceLaunchingSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Multi_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.MultiInstanceLaunchingSetting = false;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set MultiInstanceLaunchingSetting Setting To " + Properties.Settings.Default.MultiInstanceLaunchingSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void RPCBox_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.RPCSetting = true;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set RPCSetting Setting To " + Properties.Settings.Default.RPCSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void RPCBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.RPCSetting = false;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set RPCSetting Setting To " + Properties.Settings.Default.RPCSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }



        private void AutoUpdate_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.AutoUpdatePLS = true;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set AutoUpdatePLS Setting To " + Properties.Settings.Default.AutoUpdatePLS, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }



        private void AutoUpdate_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.AutoUpdatePLS = false;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set AutoUpdatePLS Setting To " + Properties.Settings.Default.AutoUpdatePLS, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void OldDeath_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.OldDeathSoundS = true;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set OldDeathSoundS Setting To " + Properties.Settings.Default.OldDeathSoundS, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }



        private void OldDeath_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.OldDeathSoundS = false;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set OldDeathSoundS Setting To " + Properties.Settings.Default.OldDeathSoundS, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Swap_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.OldAvatarBack = true;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set OldAvatarBack Setting To " + Properties.Settings.Default.OldAvatarBack, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }



        private void Swap_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.OldAvatarBack = false;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set OldAvatarBack Setting To " + Properties.Settings.Default.OldAvatarBack, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Boxx_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.BoxxSetting = true;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set BoxxSetting Setting To " + Properties.Settings.Default.BoxxSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }



        private void Boxx_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.BoxxSetting = false;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set BoxxSetting Setting To " + Properties.Settings.Default.BoxxSetting, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private async void SaveBtnS_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to save?", "FDJASVS X Bootstrapper", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    if (Properties.Settings.Default.BoxxSetting == true)
                    {
                        if (!EmeraldGG.CheckExistsFlag("DFIntDebugFRMQualityLevelOverride"))
                        {
                            await EmeraldGG.AddFlag("DFIntDebugFRMQualityLevelOverride", "1");
                        }
                    }
                    else
                    {
                        await EmeraldGG.RemoveFlag("DFIntDebugFRMQualityLevelOverride");
                    }

                    if (Properties.Settings.Default.MultiInstanceLaunchingSetting == true)
                    {
                       File.WriteAllText(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "MultiInstance.txt"), "true");
                    }
                    else
                    {
                        File.WriteAllText(System.IO.Path.Combine(Directory.GetCurrentDirectory(), "MultiInstance.txt"), "false");
                    }

                    MessageBox.Show("Saving Success!", "FDJASVS X Bootstrapper");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong during saving: \n" + "\n" + ex.Message + "\n" + "\nPlease Try Again or issue a bug on Our GitHub Repository", "FDJASVS X Bootstrapper", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
