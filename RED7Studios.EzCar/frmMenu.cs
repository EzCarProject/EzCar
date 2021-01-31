using RED7Studios.EzCar.Players;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RED7Studios.EzCar
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void mtMusic_Click(object sender, EventArgs e)
        {
            var formToShow = Application.OpenForms.Cast<Form>()
            .FirstOrDefault(c => c is frmMusic);
            if (formToShow != null)
            {
                Hide();
                formToShow.Show();
            }
            else
            {
                frmMusic music = new frmMusic();
                music.Show();
            }
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SetTime_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm tt");
        }



        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmSettings settings = new frmSettings();
            settings.Show();
        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void frmMenu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control)
            {
                frmAbout about = new frmAbout();
                about.Show();
            }
        }
    }
}
