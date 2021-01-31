using RED7Studios.EzCar.Settings;
using RED7Studios.UI.Forms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RED7Studios.EzCar
{
    public partial class frmSettings : ModernForm
    {
        public frmSettings()
        {
            // Initialize the form.
            InitializeComponent();

            // Initalize the languages.
            this.Text = Languages.Resources.frmSettings_Name;
            this.mtDateAndTime.Text = Languages.Resources.frmSettings_DateAndTime;
            this.mtPlugins.Text = Languages.Resources.frmSettings_Plugins;
            this.mtMenu.Text = Languages.Resources.frmSettings_GoBack;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            // Create anew 'frmPlugins' variable called 'plugins'.
            frmPlugins plugins = new frmPlugins();
            // Show the 'plugins' form.
            plugins.Show();
        }

        private void mtMusic_Click(object sender, EventArgs e)
        {
            // Create a new 'frmDateAndTime' variable called 'dt'.
            frmDateAndTime dt = new frmDateAndTime();
            // Show the 'dt' form.
            dt.Show();
        }

        private void mtMenu_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new varible called 'formToShow' with the open forms (and select 'frmMenu').
                var formToShow = Application.OpenForms.Cast<Form>()
                .FirstOrDefault(c => c is frmMenu);
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
                    frmMenu menu = new frmMenu();
                    // Show the 'music' form.
                    menu.Show();
                }
            }
            catch (Exception ex)
            {
                // Show a message box with the error (exception).
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
