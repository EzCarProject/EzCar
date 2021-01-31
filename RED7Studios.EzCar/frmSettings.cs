using RED7Studios.EzCar.Settings;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RED7Studios.EzCar
{
    public partial class frmSettings : Form
    {
        ProgramInfo info = new ProgramInfo();
        public frmSettings()
        {
            InitializeComponent();
        }

        private void tlpMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmPlugins plugins = new frmPlugins();
            plugins.Show();
        }

        private void mtMusic_Click(object sender, EventArgs e)
        {
            frmDateAndTime dt = new frmDateAndTime();
            dt.Show();
        }

        private void mtMenu_Click(object sender, EventArgs e)
        {
            try
            {
                // Hide this form and show the menu.
                var formToShow = Application.OpenForms.Cast<Form>()
                .FirstOrDefault(c => c is frmMenu);
                if (formToShow != null)
                {
                    Hide();
                    formToShow.Show();
                }
                else
                {
                    Hide();
                    frmMenu menu = new frmMenu();
                    menu.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
