using RED7Studios.EzCar.Players;
using System;
using System.IO;
using System.Windows.Forms;

namespace RED7Studios.EzCar
{
    static class Program
    {
        static ProgramInfo info = new ProgramInfo();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            lock ("forceMenu")
            {
                if (File.Exists("settings\\forceMenu"))
                {
                    lock ("pirateDetected")
                    {
                        if (File.Exists("settings\\pirateDetected"))
                        {
                            frmPirate pirate = new frmPirate();
                            pirate.Show();
                        }
                        else
                        {
                            frmMenu menu = new frmMenu();
                            menu.Show();
                        }
                    }
                }
                else
                {
                    lock ("pirateDetected")
                    {
                        if (File.Exists("settings\\pirateDetected"))
                        {
                            frmPirate pirate = new frmPirate();
                            pirate.Show();
                        }
                        else
                        {
                            frmMusic music = new frmMusic();
                            music.Show();
                        }
                    }
                }
            }

            Application.Run();

            info.version = "1.0.0";
        }
    }
}
