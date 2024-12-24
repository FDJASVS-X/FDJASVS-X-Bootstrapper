using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDJASVS_X_Bootstrapper;
using BloxInstaller_DLL;
using System.Windows.Controls;
using System.Windows;
using System.Reflection;
using System.IO;

namespace FDJASVS_X_Bootstrapper
{



    class BloxInstallerExecutables
    {


        internal async Task DownloadRobloxTask()
        {
            int DownloadRoblox = await EmeraldGG.InitializationAsync();
            if (DownloadRoblox == 1)
            {
                // Success
                File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "Versions", EmeraldGG.GetLatestVersion(), "ClientSettings", "ClientAppSettings.json"), Properties.Settings.Default.FastFlags);
                if (Properties.Settings.Default.DevModeDebug == true)
                {
                    MessageBox.Show("Roblox Downloaded/Updated Successfully", "Debugger");
                }
            }
            else if (DownloadRoblox == 2)
            {
                // Already Installed
                if (Properties.Settings.Default.DevModeDebug == true)
                {
                    MessageBox.Show("Roblox Already Installed", "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else if (DownloadRoblox == 3)
            {
                // Error
                MessageBox.Show("Something Went Wrong. Please Try Again Or Report It On Our GitHub Repository", "EmeraldGG");
            }
            else
            {
                MessageBox.Show("Unknown Error", "...");
            }
        }

        internal void SetChannel()
        {
            var SetChannel = EmeraldGG.SetChannel(Properties.Settings.Default.Channel);
            if (SetChannel == true)
            {
                MessageBox.Show("Channel Successfully Set To " + Properties.Settings.Default.Channel, "RBXChannels");
            }
            else
            {
                MessageBox.Show("Failed To Set Channel, Usually Means It Does Not Exist", "EmeraldGG"); // usually means the channel doesnt exist
            }
        }


        internal void GetChannel()
        {
            var GetChannel = EmeraldGG.GetChannel();
            if (GetChannel != null)
            {
                MessageBox.Show("Current Channel: " + EmeraldGG.GetChannel(), "RBXChannels");
            }
            else
            {
                MessageBox.Show("Something Went Wrong :(", "EmeraldGG"); // Error
            }
        }

        internal async void GetLatestVersion()
        {
            var GetLatestVersion = EmeraldGG.GetLatestVersion();
            if (GetLatestVersion != null)
            {
                MessageBox.Show("Newest Roblox Version Is " + EmeraldGG.GetLatestVersion(), "EmeraldGG");
            }
            else
            {
                MessageBox.Show("Can't Identify Newest Roblox Version, Press OK To Check For Roblox...", "EmeraldGG");
                DownloadRobloxTask();


            }
        }

        internal async Task AddFlagTask(string name, string value)
        {


            BloxInstallerExecutables bloxInstallerExecutables = new BloxInstallerExecutables();



            var AddFlag = await EmeraldGG.AddFlag(name, value);
            if (AddFlag == 1)
            {
                // Success
            }
            else if (AddFlag == 2)
            {
                MessageBox.Show("Roblox Outdated Or Not Installed", ":(");


                var method = typeof(BloxInstallerExecutables).GetMethod("DownloadRobloxTask", BindingFlags.NonPublic | BindingFlags.Instance);
                await (Task)method.Invoke(bloxInstallerExecutables, null);


            }
            else if (AddFlag == 3)
            {
                MessageBox.Show("Something Went Wrong", ":(");
            }
            else if (AddFlag == 4)
            {

            }
            else
            {
                MessageBox.Show("Unknown Error", "....");
            }


        }

        internal async Task RemoveFlagTask(string name)
        {

            var RemoveFlag = await EmeraldGG.RemoveFlag(name);
            if (RemoveFlag == 1)
            {
                // Success
            }
            else if (RemoveFlag == 2)
            {

            }
            else if (RemoveFlag == 3)
            {
                MessageBox.Show("Something Went Wrong", ":(");
            }
            else if (RemoveFlag == 4)
            {

            }
            else
            {
                MessageBox.Show("Unknown Error", "....");
            }


        }


    }



}

