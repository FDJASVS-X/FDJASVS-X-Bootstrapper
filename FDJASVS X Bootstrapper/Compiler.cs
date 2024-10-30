using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using BloxInstaller_DLL;
using System.Reflection;

namespace FDJASVS_X_Bootstrapper
{
   
    internal class Compiler
    {
        internal Compiler()
        {
            CheckHacks();
        }

        internal async void CheckHacks()
        {
            GGStorage gGStorage = new GGStorage();

            BloxInstallerExecutables bloxInstallerExecutables = new BloxInstallerExecutables();

            if (Properties.Settings.Default.CircleCheckBoxSetting == true)
            {
                var AddFlag = await EmeraldGG.AddFlag(gGStorage.Hackfflags[0], "True");
                if (AddFlag == 1)
                {
                    MessageBox.Show("Success", "ye");
                }
                else if (AddFlag == 2)
                {
                    MessageBox.Show("Roblox Not Installed", ":(");
                

                    var method = typeof(BloxInstallerExecutables).GetMethod("DownloadRobloxTask", BindingFlags.NonPublic | BindingFlags.Instance);
                    await (Task)method.Invoke(bloxInstallerExecutables, null);


                }
                else if (AddFlag == 3)
                {
                    MessageBox.Show("Failure", "Sad :(((((");
                }
                else if (AddFlag == 4)
                {
                    MessageBox.Show("Value Replaced Succesfully", "ye");
                }
                else
                {
                    MessageBox.Show("Unknown Error", "🥶");
                }
            }
            
        }
    }
}
