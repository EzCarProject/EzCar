namespace RED7Studios.EzCar
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.mtMusic = new MetroFramework.Controls.MetroTile();
            this.lbTime = new System.Windows.Forms.Label();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SetTime = new System.Windows.Forms.Timer(this.components);
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 5;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpMain.Controls.Add(this.mtMusic, 0, 0);
            this.tlpMain.Controls.Add(this.lbTime, 4, 0);
            this.tlpMain.Controls.Add(this.metroTile1, 4, 2);
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(10);
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpMain.Size = new System.Drawing.Size(816, 496);
            this.tlpMain.TabIndex = 0;
            // 
            // mtMusic
            // 
            this.mtMusic.Location = new System.Drawing.Point(13, 13);
            this.mtMusic.Name = "mtMusic";
            this.mtMusic.Size = new System.Drawing.Size(154, 154);
            this.mtMusic.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtMusic.TabIndex = 6;
            this.mtMusic.Text = "Music";
            this.mtMusic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtMusic.TileImage = global::RED7Studios.EzCar.Properties.Resources.Music;
            this.mtMusic.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtMusic.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtMusic.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtMusic.UseTileImage = true;
            this.mtMusic.Click += new System.EventHandler(this.mtMusic_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lbTime.Location = new System.Drawing.Point(653, 10);
            this.lbTime.Name = "lbTime";
            this.lbTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTime.Size = new System.Drawing.Size(144, 36);
            this.lbTime.TabIndex = 7;
            this.lbTime.Text = "11:59 PM";
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(653, 333);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(154, 154);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "Settings";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = global::RED7Studios.EzCar.Properties.Resources.Music;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // SetTime
            // 
            this.SetTime.Enabled = true;
            this.SetTime.Interval = 1000;
            this.SetTime.Tick += new System.EventHandler(this.SetTime_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 496);
            this.Controls.Add(this.tlpMain);
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenu_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMenu_KeyUp);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtMusic;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer SetTime;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

