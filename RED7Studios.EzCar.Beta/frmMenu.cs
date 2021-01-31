using RED7Studios.EzCar.Players;
using RED7Studios.UI.Forms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RED7Studios.EzCar
{
    public partial class frmMenu : ModernForm
    {
        public frmMenu()
        {
            // Initialize the form.
            InitializeComponent();

            // Initalize the languages.
            this.Text = Languages.Resources.frmMenu_Name;
            this.mtMusic.Text = Languages.Resources.frmMenu_Music;
            this.mtSettings.Text = Languages.Resources.frmMenu_Settings;
        }

        private void mtMusic_Click(object sender, EventArgs e)
        {
            // Create a new varible called 'formToShow' with the open forms (and select 'frmMusic').
            var formToShow = Application.OpenForms.Cast<Form>()
            .FirstOrDefault(c => c is frmMusic);
            // If the form to show ISN'T null
            if (formToShow != null)
            {
                // Hide this form.
                Hide();
                // Show 'formToShow' form.
                formToShow.Show();
            }
            else
            {
                // Hide this form.
                Hide();
                // Create a new 'frmMusic' variable called 'music'.
                frmMusic music = new frmMusic();
                // Show the 'music' form.
                music.Show();
            }
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Exit the application.
            Application.Exit();
        }

        private void SetTime_Tick(object sender, EventArgs e)
        {
            // Set the time to the system time in 'hour:minute am/pm' form.
            lbTime.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            // Create a new 'frmSettings' variable called 'settings'.
            frmSettings settings = new frmSettings();
            // Show the 'settings' form.
            settings.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
