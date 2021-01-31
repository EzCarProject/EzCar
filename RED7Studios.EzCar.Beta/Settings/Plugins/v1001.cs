using ECMU.Interface;
using RED7Studios.UI.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace RED7Studios.EzCar.Settings.Plugins
{
    public partial class v1001 : ModernForm
    {
        // Create new PluginImplementerButton called 'PI'.
        PluginImplementerButton PI;

        public v1001()
        {
            // Initalize the form.
            InitializeComponent();

            // Initalize the languages.
            this.Text = Languages.Resources.frmPlugins_Name;
        }

        private void frmPlugins_Load(object sender, EventArgs e)
        {
            // For each of the plugins in the 'Plugins' directory.
            foreach (var files in Directory.GetFiles(@"Plugins", "*.1.0.0.1-dll"))
            {
                // Create a new variable called 'assembly' and load the files.
                var assembly = Assembly.LoadFrom(files);
                // For each of the types in the assembly types.
                foreach (var type in assembly.GetTypes())
                {
                    // If the type interfaces contains the plugin implementer for the button OR all of the implementers.
                    if (type.GetInterfaces().Contains(typeof(PluginImplementerButton)) || type.GetInterfaces().Contains(typeof(PluginImplementerAll)))
                    {
                        // Set PI to the new instance of type as the plugin implementer for the button.
                        PI = Activator.CreateInstance(type) as PluginImplementerButton;
                        // Create a new string called 'name' with the plugin name.
                        string name = PI.PluginName();

                        // Create a new button called 'btn'.
                        Button btn = new Button();
                        // Set 'btn's height to 180.
                        btn.Height = 180;
                        // Set 'btn's width to 180.
                        btn.Width = 180;
                        // Set 'btn's back color to green.
                        btn.BackColor = Color.SeaGreen;
                        // Set 'btn's fore color to white.
                        btn.ForeColor = Color.White;
                        // Set the 'btn's text to the plugin name.
                        btn.Text = name;
                        // Set the 'btn's name to 'btn' plus the plugin name.
                        btn.Name = "btn" + name;
                        // Set the font of 'btn' to 'Segoe UI'.
                        btn.Font = new Font("Segoe UI", 16);
                        // Add the 'btn' to the plugins list.
                        flowLayoutPanel1.Controls.Add(btn);
                        // Run the interfaces button adder function (with 'btn').
                        PI.ButtonAdder(btn);
                    }
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
