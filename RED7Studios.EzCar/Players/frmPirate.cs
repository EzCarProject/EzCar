using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace RED7Studios.EzCar.Players
{
    public partial class frmPirate : Form
    {
        // Create a new windows media player varible called 'player'.
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public frmPirate()
        {
            InitializeComponent();
        }

        private void frmPirate_Load(object sender, EventArgs e)
        {
            player.URL = "Songs\\pirate.mp3";

            // Play the player with the selected song.
            player.controls.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            label1.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            label2.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            label3.ForeColor = Color.FromArgb(A, R, G, B);
        }
    }
}
