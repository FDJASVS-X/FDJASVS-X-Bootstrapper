using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using BloxInstaller_DLL;
using FDJASVS_X_Bootstrapper;
using Microsoft.Web.WebView2.WinForms;

namespace FDJASVS_X_Bootstrapper
{
    /// <summary>
    /// Logika interakcji dla klasy FFMWindow.xaml
    /// </summary>
    public partial class FFMWindow : Window
    {
        public FFMWindow()
        {
            InitializeComponent();
            DoWebBowser();
        }

        private async void DoWebBowser()
        {
            if (await EmeraldGG.InitializationAsync() == 1)
            {
                File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "Versions", EmeraldGG.GetLatestVersion(), "ClientSettings", "ClientAppSettings.json"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "FastFlags.txt")));
            }
            else
            {
                if (Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "FastFlags.txt")))
                {
                    File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "FastFlags.txt"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Versions", EmeraldGG.GetLatestVersion(), "ClientSettings", "ClientAppSettings.json")));
                }
                else
                {
                    File.Create(Path.Combine(Directory.GetCurrentDirectory(), "FastFlags.txt")).Close();
                    File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "FastFlags.txt"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Versions", EmeraldGG.GetLatestVersion(), "ClientSettings", "ClientAppSettings.json")));
                }
                Properties.Settings.Default.FastFlags = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Versions", EmeraldGG.GetLatestVersion(), "ClientSettings", "ClientAppSettings.json"));
                Properties.Settings.Default.Save();
            };
            await EditorStuff.EnsureCoreWebView2Async();
            MessageBox.Show(Properties.Settings.Default.FastFlags);
            EditorStuff.CoreWebView2.Navigate((string)System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("file:\\", "file:///").Replace("\\", "/") + "/json/index.html");
            //MessageBox.Show(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Versions", EmeraldGG.GetLatestVersion(), "ClientSettings", "ClientAppSettings.json")));
            await Task.Delay(1000);
            if (File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Versions", EmeraldGG.GetLatestVersion(), "ClientSettings", "ClientAppSettings.json")).Length > 0)
            {
                await EditorStuff.CoreWebView2.ExecuteScriptAsync("editor.setValue(" + '`' + File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Versions", EmeraldGG.GetLatestVersion(), "ClientSettings", "ClientAppSettings.json")) + "`)");
            }
            //MessageBox.Show("editor.setValue(" + "`" + File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Versions", EmeraldGG.GetLatestVersion(), "ClientSettings", "ClientAppSettings.json")) + "`" + ")");
        }

       

        private async void SaveToFile(object sender, RoutedEventArgs e)
        {
            String Heha = @"
                (function() {
                    return editor.getValue();
                })();";

            String Result1 = await EditorStuff.CoreWebView2.ExecuteScriptAsync(Heha);
            Result1 = JsonSerializer.Deserialize<string>(Result1);
            String filepath = Path.Combine(Directory.GetCurrentDirectory(), "Versions", EmeraldGG.GetLatestVersion(), "ClientSettings", "ClientAppSettings.json");

            if (Result1 == "")
            {
                File.WriteAllText(filepath, "{}");
            }
            else
            {
                if (Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "FastFlags.txt")))
                {
                    File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "FastFlags.txt"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Versions", EmeraldGG.GetLatestVersion(), "ClientSettings", "ClientAppSettings.json")));
                }
                else
                {
                    File.Create(Path.Combine(Directory.GetCurrentDirectory(), "FastFlags.txt")).Close();
                    File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "FastFlags.txt"), File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Versions", EmeraldGG.GetLatestVersion(), "ClientSettings", "ClientAppSettings.json")));
                }
                File.WriteAllText(filepath, Result1);
                Properties.Settings.Default.FastFlags = Result1;
                Properties.Settings.Default.Save();
                MessageBox.Show(Result1);
            }
        }


    }
}
