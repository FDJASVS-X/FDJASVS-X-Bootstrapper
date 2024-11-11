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

namespace FDJASVS_X_Bootstrapper
{

    class GGStorage
    {
        public String[] Lightningfflags = { /* Voxel Lighting (Phase 1) */ "@\r\n{\r\n    \"DFFlagDebugRenderForceTechnologyVoxel\": \"True\"\r\n}", /* Shadowmap Lighting (Phase 2) */ "@{\r\n    \"FFlagDebugForceFutureIsBrightPhase2\": \"True\"\r\n}", /* Future Lighting (Phase 3)) */ "@{\r\n    \"FFlagDebugForceFutureIsBrightPhase3\": \"True\"\r\n}", /* Disable Shadows */ "@{\r\n    \"FIntRenderShadowIntensity\": \"0\"\r\n}" };
        public String[] Hackfflags = { /* Draws a circle under avatars */ "@{\r\n    \"FFlagDebugAvatarChatVisualization\": \"True\",\r\n    \"FFlagEnableInGameMenuChromeABTest2\": \"False\"\r\n}" };

        // Personal FFlags
        public String[] PLightningfflags = { /* Disable Player Shadows */ "@{\r\n    \"FIntRenderShadowIntensity\": \"0\"\r\n}" };

        public String[] Weirdfflags = { /* Draws an outline around every part and every humanoid */ "@{\r\n    \"DFFlagDebugDrawBroadPhaseAABBs\": \"True\"\r\n}", /* xray(buggy) */ "@{\r\n   \"FIntCameraFarZPlane\": \"1\"\r\n    \"DFIntCullFactorPixelThresholdMainViewHighQuality\": \"10000\",\r\n    \"DFIntCullFactorPixelThresholdMainViewLowQuality\": \"10000\",\r\n    \"DFIntCullFactorPixelThresholdShadowMapHighQuality\": \"10000\",\r\n    \"DFIntCullFactorPixelThresholdShadowMapLowQuality\": \"10000\"\r\n}", /* SpeedHack */ "@{\r\n\"FFlagDebugSimIntegrationStabilityTesting\": true\r\n}", /* Possible Super Jump */ "@{\r\n    \"DFIntNewRunningBaseGravityReductionFactorHundredth\": \"1500\"\r\n}\r\n", /* Remove Grass(every gamer needs this) */ "@{\r\n    \"FIntFRMMinGrassDistance\": \"0\",\r\n    \"FIntFRMMaxGrassDistance\": \"0\",\r\n    \"FIntRenderGrassDetailStrands\": \"0\",\r\n    \"FIntRenderGrassHeightScaler\": \"0\"\r\n}", /* Semi Fullbright */ "@{\r\n    \"FFlagFastGPULightCulling3\": \"True\",\r\n    \"FIntRenderShadowIntensity\": \"0\",\r\n    \"DFIntCullFactorPixelThresholdShadowMapHighQuality \": \"2147483647\",\r\n    \"DFIntCullFactorPixelThresholdShadowMapLowQuality\": \"2147483647\",\r\n    \"FFlagNewLightAttenuation\": \"True\",\r\n    \"FIntRenderShadowmapBias\": \"-1\",\r\n    \"DFFlagDebugPauseVoxelizer\": \"True\"\r\n}" };

        public String[] EscapeMenufflags = { /* Default */ "@{ \"DisableV2\", null },\r\n                    { \"EnableV4\", null },\r\n                    { \"ABTest\", null }",  /* Version 1(2015) */ "@  { \"DisableV2\", \"True\" },\r\n                    { \"EnableV4\", \"False\" },\r\n                    { \"ABTest\", \"False\" }", /* Version 2 (2020) */ "@{ \"DisableV2\", \"False\" },\r\n                    { \"EnableV4\", \"False\" },\r\n                    { \"ABTest\", \"False\" }", /* Version 4 (2023) */ "@{ \"DisableV2\", \"True\" },\r\n                    { \"EnableV4\", \"True\" },\r\n                    { \"ABTest\", \"False\" }" };


    }



     class BloxInstallerExecutables
    {
       
        
        internal async Task DownloadRobloxTask()
        {
          int DownloadRoblox = await EmeraldGG.InitializationAsync();
            if (DownloadRoblox == 1)
            {
                if (Properties.Settings.Default.DevModeDebug == true)
                {
                    MessageBox.Show("Roblox Downloaded/Updated Successfully", "Debugger");
                }
            }
            else if (DownloadRoblox == 2)
            {
                if (Properties.Settings.Default.DevModeDebug == true)
                {
                    MessageBox.Show("Roblox Already Installed", "Debugger", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else if (DownloadRoblox == 3)
            {
                    MessageBox.Show("Something Went Wrong :( Please Try Again Or Report It On Our GitHub Repository", "EmeraldGG");
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
                MessageBox.Show("Something Went Wrong :(", "EmeraldGG");
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

