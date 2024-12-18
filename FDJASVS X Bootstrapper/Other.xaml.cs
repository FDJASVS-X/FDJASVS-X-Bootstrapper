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
using BloxInstaller_DLL;

namespace FDJASVS_X_Bootstrapper
{
    /// <summary>
    /// Logika interakcji dla klasy Other.xaml
    /// </summary>
    public partial class Other : Page
    {
        public Other()
        {
            InitializeComponent();
            this.Loaded += Oter_Loaded;
        }

        private void Oter_Loaded(object sender, RoutedEventArgs e)
        {
            // Load saved settings and set the checkbox states
            ShadowsCheckBox.IsChecked = Properties.Settings.Default.ShadowsCheckBox;
            GamerThing.IsChecked = Properties.Settings.Default.Gamm;
            OldMaterialsCheckBox.IsChecked = Properties.Settings.Default.UseOldMaterials;
            LightSettings.SelectedIndex = Properties.Settings.Default.Lightning;
            Mouser.SelectedIndex = Properties.Settings.Default.MouserC;
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

      


        public bool ShadowsBool = true;
        public bool PlrShadowsBool = true;
        public bool GamerBool = true;

        private void ShadowsBox_Checked(object sender, RoutedEventArgs e)
        {
            
            Properties.Settings.Default.ShadowsCheckBox = true;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set ShadowsCheckBox Setting To " + Properties.Settings.Default.ShadowsCheckBox, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ShadowsBox_Unchecked(object sender, RoutedEventArgs e)
        {

            Properties.Settings.Default.ShadowsCheckBox = false;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set ShadowsCheckBox Setting To " + Properties.Settings.Default.ShadowsCheckBox, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

      
      

        private void GMBox_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Gamm = true;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set Gamm Setting To " + Properties.Settings.Default.Gamm, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void GMBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Gamm = false;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set Gamm Setting To " + Properties.Settings.Default.Gamm, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void OldBox_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.UseOldMaterials = true;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set UseOldMaterials Setting To " + Properties.Settings.Default.UseOldMaterials, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void OldBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.UseOldMaterials = false;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set UseOldMaterials Setting To " + Properties.Settings.Default.UseOldMaterials, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ftBox_Checked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.UseOldCharacterSounds = true;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set UseOldCharacterSounds Setting To " + Properties.Settings.Default.UseOldCharacterSounds, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ftBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.UseOldCharacterSounds = false;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.DevModeDebug)
            {
                MessageBox.Show("Set UseOldCharacterSounds Setting To " + Properties.Settings.Default.UseOldCharacterSounds, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        



        private void LightningComboBoxChange(object sender, SelectionChangedEventArgs e)
        {
            if (LightSettings.SelectedIndex == 0)
            {
                Properties.Settings.Default.Lightning = 0;
                Properties.Settings.Default.Save();
                if (Properties.Settings.Default.DevModeDebug)
                {
                    MessageBox.Show("Set Lightning Setting To " + Properties.Settings.Default.Lightning, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            }
            else if(LightSettings.SelectedIndex == 1)
            {
                Properties.Settings.Default.Lightning = 1;
                Properties.Settings.Default.Save();
                if (Properties.Settings.Default.DevModeDebug)
                {
                    MessageBox.Show("Set Lightning Setting To " + Properties.Settings.Default.Lightning, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
           else if (LightSettings.SelectedIndex == 2)
            {
                Properties.Settings.Default.Lightning = 2;
                Properties.Settings.Default.Save();
                if (Properties.Settings.Default.DevModeDebug)
                {
                    MessageBox.Show("Set Lightning Setting To " + Properties.Settings.Default.Lightning, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else if (LightSettings.SelectedIndex == 3)
            {
                Properties.Settings.Default.Lightning = 3;
                Properties.Settings.Default.Save();
                
            }
        }
        private void MouseComboBoxChange(object sender, RoutedEventArgs e)
        {
            if (Mouser.SelectedIndex == 0)
            {
                Properties.Settings.Default.MouserC = 0;
                Properties.Settings.Default.Save();
               

            }
            else if (Mouser.SelectedIndex == 1)
            {
                Properties.Settings.Default.MouserC = 1;
                Properties.Settings.Default.Save();
                if (Properties.Settings.Default.DevModeDebug)
                {
                    MessageBox.Show("Set MouserC Setting To " + Properties.Settings.Default.MouserC, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else if (Mouser.SelectedIndex == 2)
            {
                Properties.Settings.Default.MouserC = 2;
                Properties.Settings.Default.Save();
                if (Properties.Settings.Default.DevModeDebug)
                {
                    MessageBox.Show("Set MouserC Setting To " + Properties.Settings.Default.MouserC, "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private async void SaveBtnO_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to save?", "FDJASVS X Bootstrapper", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    SaveBtnO.IsEnabled = false;
                    if (Properties.Settings.Default.ShadowsCheckBox == true)
                    {
                        if (!EmeraldGG.CheckExistsFlag("FIntRenderShadowIntensity"))
                        {
                            await EmeraldGG.AddFlag("FIntRenderShadowIntensity", "0");
                        }
                    }
                    else
                    {
                        await EmeraldGG.RemoveFlag("FIntRenderShadowIntensity");
                    }

                    if (Properties.Settings.Default.Gamm == true)
                    {
                        if (!EmeraldGG.CheckExistsFlag("FIntFRMMinGrassDistance") && !EmeraldGG.CheckExistsFlag("FIntFRMMaxGrassDistance") && !EmeraldGG.CheckExistsFlag("FIntRenderGrassDetailStrands") && !EmeraldGG.CheckExistsFlag("FIntRenderGrassHeightScaler"))
                        {
                            await EmeraldGG.AddFlag("FIntFRMMinGrassDistance", "0");
                            await EmeraldGG.AddFlag("FIntFRMMaxGrassDistance", "0");
                            await EmeraldGG.AddFlag("FIntRenderGrassDetailStrands", "0");
                            await EmeraldGG.AddFlag("FIntRenderGrassHeightScaler", "0");
                        }
                    }
                    else
                    {
                        await EmeraldGG.RemoveFlag("FIntFRMMinGrassDistance");
                        await EmeraldGG.RemoveFlag("FIntFRMMaxGrassDistance");
                        await EmeraldGG.RemoveFlag("FIntRenderGrassDetailStrands");
                        await EmeraldGG.RemoveFlag("FIntRenderGrassHeightScaler");
                    }

                    if (Properties.Settings.Default.Lightning == 3)
                    {
                            await EmeraldGG.RemoveFlag("DFFlagDebugRenderForceTechnologyVoxel");
                            await EmeraldGG.RemoveFlag("FFlagDebugForceFutureIsBrightPhase2");
                            await EmeraldGG.RemoveFlag("FFlagDebugForceFutureIsBrightPhase3");

                    }
                    else if (Properties.Settings.Default.Lightning == 2)
                    {
                        if (!EmeraldGG.CheckExistsFlag("FFlagDebugForceFutureIsBrightPhase3"))
                        {
                            await EmeraldGG.AddFlag("FFlagDebugForceFutureIsBrightPhase3", "True");
                            await EmeraldGG.RemoveFlag("DFFlagDebugRenderForceTechnologyVoxel");
                            await EmeraldGG.RemoveFlag("FFlagDebugForceFutureIsBrightPhase2");
                        }
                    }
                    else if (Properties.Settings.Default.Lightning == 1)
                    {
                        if (!EmeraldGG.CheckExistsFlag("FFlagDebugForceFutureIsBrightPhase2"))
                        {
                            await EmeraldGG.AddFlag("FFlagDebugForceFutureIsBrightPhase2", "True");
                            await EmeraldGG.RemoveFlag("FFlagDebugForceFutureIsBrightPhase3");
                            await EmeraldGG.RemoveFlag("DFFlagDebugRenderForceTechnologyVoxel");
                        }
                    }
                    else if (Properties.Settings.Default.Lightning == 0)
                    {
                        if (!EmeraldGG.CheckExistsFlag("DFFlagDebugRenderForceTechnologyVoxel"))
                        {
                            await EmeraldGG.AddFlag("DFFlagDebugRenderForceTechnologyVoxel", "True");
                            await EmeraldGG.RemoveFlag("FFlagDebugForceFutureIsBrightPhase3");
                            await EmeraldGG.RemoveFlag("FFlagDebugForceFutureIsBrightPhase2");
                        }
                    }
                    else
                    {
                        await EmeraldGG.RemoveFlag("DFFlagDebugRenderForceTechnologyVoxel");
                        await EmeraldGG.RemoveFlag("FFlagDebugForceFutureIsBrightPhase2");
                        await EmeraldGG.RemoveFlag("FFlagDebugForceFutureIsBrightPhase3");
                    }

                    MessageBox.Show("Saving Success!", "FDJASVS X Bootstrapper");




                    await Task.Delay(15000);
                    SaveBtnO.IsEnabled = true;


                }
                catch (Exception ex)
                {
                    SaveBtnO.IsEnabled = true;
                    MessageBox.Show("Something went wrong during saving: \n" + "\n" + ex.Message + "\n" + "\nPlease Try Again or issue a bug on Our GitHub Repository", "FDJASVS X Bootstrapper", MessageBoxButton.OK, MessageBoxImage.Warning);
                }


            }
        }
    }
}
