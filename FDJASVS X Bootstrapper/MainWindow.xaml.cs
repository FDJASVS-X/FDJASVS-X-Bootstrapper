using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.Json.Nodes;
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
using FDJASVS_X_Bootstrapper;

namespace FDJASVS_X_Bootstrapper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the Hacks page
            Hacks hacksPage = new Hacks();

            // Navigate to the Hacks page
            this.Content = hacksPage;

           



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Create an instance of the Hacks page
            Other otherPage = new Other();

            // Navigate to the Hacks page
            this.Content = otherPage;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Create an instance of the Hacks page
            Settings Settingspage = new Settings();

            // Navigate to the Hacks page
            this.Content = Settingspage;
        }


    }
}