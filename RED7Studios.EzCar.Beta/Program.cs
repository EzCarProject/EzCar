using AutoUpdaterDotNET;
using RED7Studios.EzCar.Players;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace RED7Studios.EzCar
{
    static class Program
    {
        // Create a new ProgramSettings called 'settings'.
        static ProgramSettings settings = new ProgramSettings();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Try to find if everything exists
            try
            {
                // If the 'Plugins' directory DOESN'T exist.
                if (!Directory.Exists("Plugins"))
                {
                    // Create the 'Plugins' directory.
                    Directory.CreateDirectory("Plugins");
                }

                // If the 'settings' directory DOESN'T exist.
                if (!Directory.Exists("settings"))
                {
                    // Create the 'settings' directory.
                    Directory.CreateDirectory("settings");
                }

                // If the 'MusicDirectory.txt' in 'settings' file DOESN'T exist.
                if (!File.Exists("settings\\MusicDirectory.txt"))
                {
                    // Write the user's music folder to the 'MusicDirectory.txt' file in 'settings'.
                    File.WriteAllText("settings\\MusicDirectory.txt", Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
                }

                // If the 'ECMU.Market.ecmu_dll' in 'Plugins' DOESN'T exist.
                if (!File.Exists("Plugins\\ECMU.Market.ecmu_dll"))
                {
                    // Using a new web client called 'client'.
                    using (WebClient client = new WebClient())
                    {
                        // Download the 'ECMU.Market.ecmu_dll'.
                        client.DownloadFile("https://ezcar.doubleddevelopment.ml/ecmu-plugin/ECMU.Market.ecmu_dll", "Plugins\\ECMU.Market.ecmu_dll");
                    }
                }

                // If the 'ECMU.Settings.ecmu_dll' in 'Plugins' DOESN'T exist.
                if (!File.Exists("Plugins\\ECMU.Settings.ecmu_dll"))
                {
                    // Using a new web client called 'client'.
                    using (WebClient client = new WebClient())
                    {
                        // Download the 'ECMU.Settings.ecmu_dll'.
                        client.DownloadFile("https://ezcar.doubleddevelopment.ml/ecmu-plugin/ECMU.Settings.ecmu_dll", "Plugins\\ECMU.Settings.ecmu_dll");
                    }
                }
            }
            catch (Exception ex)
            {
                // Show a message box with the error (exception).
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }

            // Enable the applications visual styles.
            Application.EnableVisualStyles();
            // Set the applications compatible text rendering default to false.
            Application.SetCompatibleTextRenderingDefault(false);

            // Lock the file to use it.
            lock ("forceMenu")
            {
                // If the 'forceMenu' file in 'settings' exists.
                if (File.Exists("settings\\forceMenu"))
                {
                    // Create a new 'frmMenu' called 'menu'.
                    frmMenu menu = new frmMenu();
                    // Show the 'menu' form.
                    menu.Show();
                }
                else
                {
                    // Create a new 'frmMusic' called 'music'.
                    frmMusic music = new frmMusic();
                    // Show the 'music' form.
                    music.Show();
                }
            }

            // Start the updater with the NEW url.
            AutoUpdater.Start(settings.UpdateURL + settings.UpdateURLXML);

            // Write a line to the console with the settings.
            Console.WriteLine("\n\nSettings:\nVersion: " + settings.Version + "\nBeta: " + settings.Beta + "\n\nUpdate URL: " + settings.UpdateURL + "\nUpdate Structure: " + settings.UpdateURL + settings.UpdateURLStruct + "\nUpdate XML: " + settings.UpdateURL + settings.UpdateURLXML + "\n\n");

            // Run the program.
            Application.Run();
        }
    }
}
