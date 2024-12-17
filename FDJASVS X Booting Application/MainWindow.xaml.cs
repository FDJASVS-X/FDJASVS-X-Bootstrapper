using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FDJASVS_X_Bootstrapper;
using Wpf.Ui.Controls;
using BloxInstaller_DLL;

namespace FDJASVS_X_Booting_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FluentWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;


            FlagCheck();


        }

        public async void FlagCheck()
        {


          

           var DownloadRoblox = await EmeraldGG.InitializationAsync();

           var CleanFlags = await EmeraldGG.ClearAllFlags();

                    if (FDJASVS_X_Bootstrapper.Properties.Settings.Default.CircleCheckBoxSetting == true)
                    {
                        var AddFlag = await EmeraldGG.AddFlag("DFFlagDebugDrawBroadPhaseAABBs", "True");
                        if (AddFlag == 1)
                        {
                            System.Windows.MessageBox.Show("Success", "ye");
                        }
                        else if (AddFlag == 2)
                        {
                            System.Windows.MessageBox.Show("Roblox Not Installed", ":(");
                        }
                        else if (AddFlag == 3)
                        {
                            System.Windows.MessageBox.Show("Failure", "Sad :(((((");
                        }
                        else if (AddFlag == 4)
                        {
                            System.Windows.MessageBox.Show("Value Replaced Succesfully", "ye");
                        }
                        else
                        {
                            System.Windows.MessageBox.Show("Unknown Error", "🥶");
                        }

              
                    }
               
        }
    }
}