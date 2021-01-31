namespace RED7Studios.EzCar
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.mtDateAndTime = new MetroFramework.Controls.MetroTile();
            this.mtPlugins = new MetroFramework.Controls.MetroTile();
            this.mtMenu = new MetroFramework.Controls.MetroTile();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 5;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tlpMain.Controls.Add(this.mtDateAndTime, 0, 0);
            this.tlpMain.Controls.Add(this.mtPlugins, 0, 2);
            this.tlpMain.Controls.Add(this.mtMenu, 4, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(1, 33);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(10);
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tlpMain.Size = new System.Drawing.Size(813, 491);
            this.tlpMain.TabIndex = 1;
            // 
            // mtDateAndTime
            // 
            this.mtDateAndTime.Location = new System.Drawing.Point(13, 13);
            this.mtDateAndTime.Name = "mtDateAndTime";
            this.mtDateAndTime.Size = new System.Drawing.Size(140, 140);
            this.mtDateAndTime.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtDateAndTime.TabIndex = 6;
            this.mtDateAndTime.Text = "Date && Time";
            this.mtDateAndTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtDateAndTime.TileImage = global::RED7Studios.EzCar.Properties.Resources.DateAndTime;
            this.mtDateAndTime.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDateAndTime.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtDateAndTime.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtDateAndTime.UseTileImage = true;
            this.mtDateAndTime.Click += new System.EventHandler(this.mtMusic_Click);
            // 
            // mtPlugins
            // 
            this.mtPlugins.Location = new System.Drawing.Point(13, 330);
            this.mtPlugins.Name = "mtPlugins";
            this.mtPlugins.Size = new System.Drawing.Size(140, 140);
            this.mtPlugins.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtPlugins.TabIndex = 7;
            this.mtPlugins.Text = "Plugins";
            this.mtPlugins.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtPlugins.TileImage = global::RED7Studios.EzCar.Properties.Resources.Plugin_New;
            this.mtPlugins.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPlugins.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtPlugins.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtPlugins.UseTileImage = true;
            this.mtPlugins.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mtMenu
            // 
            this.mtMenu.Location = new System.Drawing.Point(652, 330);
            this.mtMenu.Name = "mtMenu";
            this.mtMenu.Size = new System.Drawing.Size(140, 140);
            this.mtMenu.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtMenu.TabIndex = 8;
            this.mtMenu.Text = "Go Back";
            this.mtMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtMenu.TileImage = global::RED7Studios.EzCar.Properties.Resources.Back_Small;
            this.mtMenu.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtMenu.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtMenu.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtMenu.UseTileImage = true;
            this.mtMenu.Click += new System.EventHandler(this.mtMenu_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 525);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.tlpMain);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(32, 39);
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private MetroFramework.Controls.MetroTile mtDateAndTime;
        private MetroFramework.Controls.MetroTile mtPlugins;
        private MetroFramework.Controls.MetroTile mtMenu;
    }
}