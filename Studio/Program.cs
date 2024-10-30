// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;


    string robloxStudioUrl = "roblox-studio://";

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\r\n____________  ___  ___   _____  _   _ _____  __   __  _____ _             _ _       \r\n|  ___|  _  \\|_  |/ _ \\ /  ___|| | | /  ___| \\ \\ / / /  ___| |           | (_)      \r\n| |_  | | | |  | / /_\\ \\\\ `--. | | | \\ `--.   \\ V /  \\ `--.| |_ _   _  __| |_  ___  \r\n|  _| | | | |  | |  _  | `--. \\| | | |`--. \\  /   \\   `--. \\ __| | | |/ _` | |/ _ \\ \r\n| |   | |/ /\\__/ / | | |/\\__/ /\\ \\_/ /\\__/ / / /^\\ \\ /\\__/ / |_| |_| | (_| | | (_) |\r\n\\_|   |___/\\____/\\_| |_/\\____/  \\___/\\____/  \\/   \\/ \\____/ \\__|\\__,_|\\__,_|_|\\___/ \r\n                                                                                    \r\n                                                                                    \r\n");
    Console.WriteLine("----------------");

    try
    {
        
        Process.Start(new ProcessStartInfo(robloxStudioUrl) { UseShellExecute = true });
        Console.WriteLine("Roblox Studio Open!");
    }
    catch (Exception ex)
    {
        Console.WriteLine("An Error Occured While Trying To Open Roblox Studio: " + ex.Message);
    }

