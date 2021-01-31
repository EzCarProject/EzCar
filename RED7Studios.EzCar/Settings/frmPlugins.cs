using ECMU.Interface;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace RED7Studios.EzCar
{
    public partial class frmPlugins : Form
    {
        PluginImplementerButton PI;

        public frmPlugins()
        {
            InitializeComponent();
        }

        private void frmPlugins_Load(object sender, EventArgs e)
        {
            foreach (var files in Directory.GetFiles(@"Plugins", "*.dll"))
            {
                var assembly = Assembly.LoadFrom(files);
                foreach (var type in assembly.GetTypes())
                {
                    if (type.GetInterfaces().Contains(typeof(PluginImplementerButton)) || type.GetInterfaces().Contains(typeof(PluginImplementerAll)))
                    {
                        PI = Activator.CreateInstance(type) as PluginImplementerButton;
                        string name = PI.PluginName();

                        Button btn = new Button();
                        btn.Height = 180;
                        btn.Width = 180;
                        btn.BackColor = Color.SeaGreen;
                        btn.ForeColor = Color.White;
                        btn.Text = name;
                        btn.Name = "btn" + name;
                        btn.Font = new Font("Segoe UI", 16);
                        flowLayoutPanel1.Controls.Add(btn);
                        PI.ButtonAdder(btn);
                    }
                }
            }

            foreach (var files in Directory.GetFiles(@"Plugins", "*.ecmu_dll"))
            {
                var assembly = Assembly.LoadFrom(files);
                foreach (var type in assembly.GetTypes())
                {
                    if (type.GetInterfaces().Contains(typeof(PluginImplementerButton)) || type.GetInterfaces().Contains(typeof(PluginImplementerAll)))
                    {
                        PI = Activator.CreateInstance(type) as PluginImplementerButton;
                        string name = PI.PluginName();

                        Button btn = new Button();
                        btn.Height = 180;
                        btn.Width = 180;
                        btn.BackColor = Color.LightSkyBlue;
                        btn.ForeColor = Color.White;
                        btn.Text = name;
                        btn.Name = "btn" + name;
                        btn.Font = new Font("Segoe UI", 16);
                        flowLayoutPanel1.Controls.Add(btn);
                        PI.ButtonAdder(btn);
                    }
                }
            }
        }
    }
}
