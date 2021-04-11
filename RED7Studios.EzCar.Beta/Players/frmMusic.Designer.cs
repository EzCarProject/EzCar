namespace RED7Studios.EzCar.Players
{
    partial class frmMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusic));
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.tbProgress = new System.Windows.Forms.TrackBar();
            this.NewSong = new System.Windows.Forms.Timer(this.components);
            this.lbAlbums = new System.Windows.Forms.ListBox();
            this.lbArtists = new System.Windows.Forms.ListBox();
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.mtShuffle = new MetroFramework.Controls.MetroTile();
            this.mtNext = new MetroFramework.Controls.MetroTile();
            this.mtPrevious = new MetroFramework.Controls.MetroTile();
            this.mtPlayPause = new MetroFramework.Controls.MetroTile();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbSong = new System.Windows.Forms.Label();
            this.SaveSongInfo = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mtControls = new MetroFramework.Controls.MetroTile();
            this.mtMenu = new MetroFramework.Controls.MetroTile();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).BeginInit();
            this.gbControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVolume
            // 
            this.tbVolume.BackColor = System.Drawing.SystemColors.Control;
            this.tbVolume.Location = new System.Drawing.Point(682, 467);
            this.tbVolume.Maximum = 50;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(120, 45);
            this.tbVolume.TabIndex = 28;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // tbProgress
            // 
            this.tbProgress.BackColor = System.Drawing.SystemColors.Control;
            this.tbProgress.Location = new System.Drawing.Point(13, 467);
            this.tbProgress.Maximum = 100;
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.Size = new System.Drawing.Size(650, 45);
            this.tbProgress.TabIndex = 25;
            this.tbProgress.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbProgress.Scroll += new System.EventHandler(this.tbProgress_Scroll);
            // 
            // NewSong
            // 
            this.NewSong.Enabled = true;
            this.NewSong.Interval = 1000;
            this.NewSong.Tick += new System.EventHandler(this.NewSong_Tick);
            // 
            // lbAlbums
            // 
            this.lbAlbums.FormattingEnabled = true;
            this.lbAlbums.ItemHeight = 15;
            this.lbAlbums.Location = new System.Drawing.Point(589, 219);
            this.lbAlbums.Name = "lbAlbums";
            this.lbAlbums.ScrollAlwaysVisible = true;
            this.lbAlbums.Size = new System.Drawing.Size(213, 139);
            this.lbAlbums.TabIndex = 24;
            this.lbAlbums.SelectedIndexChanged += new System.EventHandler(this.lbAlbums_SelectedIndexChanged);
            // 
            // lbArtists
            // 
            this.lbArtists.FormattingEnabled = true;
            this.lbArtists.ItemHeight = 15;
            this.lbArtists.Location = new System.Drawing.Point(589, 61);
            this.lbArtists.Name = "lbArtists";
            this.lbArtists.ScrollAlwaysVisible = true;
            this.lbArtists.Size = new System.Drawing.Size(213, 139);
            this.lbArtists.TabIndex = 23;
            this.lbArtists.SelectedIndexChanged += new System.EventHandler(this.lbArtists_SelectedIndexChanged);
            // 
            // lbSongs
            // 
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.ItemHeight = 15;
            this.lbSongs.Location = new System.Drawing.Point(511, 14);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(272, 79);
            this.lbSongs.TabIndex = 13;
            this.lbSongs.SelectedIndexChanged += new System.EventHandler(this.lbSongs_SelectedIndexChanged);
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.mtShuffle);
            this.gbControls.Controls.Add(this.mtNext);
            this.gbControls.Controls.Add(this.mtPrevious);
            this.gbControls.Controls.Add(this.mtPlayPause);
            this.gbControls.Controls.Add(this.lbSongs);
            this.gbControls.Location = new System.Drawing.Point(13, 364);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(789, 97);
            this.gbControls.TabIndex = 21;
            this.gbControls.TabStop = false;
            this.gbControls.Visible = false;
            // 
            // mtShuffle
            // 
            this.mtShuffle.Location = new System.Drawing.Point(249, 14);
            this.mtShuffle.Name = "mtShuffle";
            this.mtShuffle.Size = new System.Drawing.Size(75, 75);
            this.mtShuffle.TabIndex = 34;
            this.mtShuffle.TileImage = global::RED7Studios.EzCar.Properties.Resources.Shuffle_Light;
            this.mtShuffle.UseTileImage = true;
            this.mtShuffle.Click += new System.EventHandler(this.mtShuffle_Click);
            // 
            // mtNext
            // 
            this.mtNext.Location = new System.Drawing.Point(168, 14);
            this.mtNext.Name = "mtNext";
            this.mtNext.Size = new System.Drawing.Size(75, 75);
            this.mtNext.TabIndex = 33;
            this.mtNext.TileImage = global::RED7Studios.EzCar.Properties.Resources.Next_Light;
            this.mtNext.UseTileImage = true;
            this.mtNext.Click += new System.EventHandler(this.mtNext_Click);
            // 
            // mtPrevious
            // 
            this.mtPrevious.Location = new System.Drawing.Point(6, 14);
            this.mtPrevious.Name = "mtPrevious";
            this.mtPrevious.Size = new System.Drawing.Size(75, 75);
            this.mtPrevious.TabIndex = 32;
            this.mtPrevious.TileImage = global::RED7Studios.EzCar.Properties.Resources.Previous_Light;
            this.mtPrevious.UseTileImage = true;
            this.mtPrevious.Click += new System.EventHandler(this.mtPrevious_Click);
            // 
            // mtPlayPause
            // 
            this.mtPlayPause.Location = new System.Drawing.Point(87, 14);
            this.mtPlayPause.Name = "mtPlayPause";
            this.mtPlayPause.Size = new System.Drawing.Size(75, 75);
            this.mtPlayPause.TabIndex = 31;
            this.mtPlayPause.TileImage = global::RED7Studios.EzCar.Properties.Resources.PlayPause_Light;
            this.mtPlayPause.UseTileImage = true;
            this.mtPlayPause.Click += new System.EventHandler(this.mtPlayPause_Click);
            // 
            // lbAlbum
            // 
            this.lbAlbum.AutoSize = true;
            this.lbAlbum.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.lbAlbum.Location = new System.Drawing.Point(135, 147);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(174, 36);
            this.lbAlbum.TabIndex = 18;
            this.lbAlbum.Text = "PLAY A SONG";
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.lbArtist.Location = new System.Drawing.Point(135, 106);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(174, 36);
            this.lbArtist.TabIndex = 17;
            this.lbArtist.Text = "PLAY A SONG";
            // 
            // lbSong
            // 
            this.lbSong.AutoSize = true;
            this.lbSong.Font = new System.Drawing.Font("Segoe UI", 23F);
            this.lbSong.Location = new System.Drawing.Point(132, 61);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(205, 42);
            this.lbSong.TabIndex = 16;
            this.lbSong.Text = "PLAY A SONG";
            // 
            // SaveSongInfo
            // 
            this.SaveSongInfo.Enabled = true;
            this.SaveSongInfo.Interval = 5000;
            this.SaveSongInfo.Tick += new System.EventHandler(this.SaveSongInfo_Tick);
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(1, 33);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(813, 24);
            this.menu.TabIndex = 30;
            this.menu.Text = "menu";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // mtControls
            // 
            this.mtControls.Location = new System.Drawing.Point(13, 283);
            this.mtControls.Name = "mtControls";
            this.mtControls.Size = new System.Drawing.Size(148, 75);
            this.mtControls.TabIndex = 35;
            this.mtControls.Text = "Open";
            this.mtControls.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtControls.TileImage = global::RED7Studios.EzCar.Properties.Resources.Controls_Light;
            this.mtControls.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtControls.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtControls.UseTileImage = true;
            this.mtControls.Click += new System.EventHandler(this.mtControls_Click);
            // 
            // mtMenu
            // 
            this.mtMenu.Location = new System.Drawing.Point(422, 283);
            this.mtMenu.Name = "mtMenu";
            this.mtMenu.Size = new System.Drawing.Size(148, 75);
            this.mtMenu.TabIndex = 34;
            this.mtMenu.Text = "Menu";
            this.mtMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtMenu.TileImage = global::RED7Studios.EzCar.Properties.Resources.Menu_Light;
            this.mtMenu.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtMenu.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtMenu.UseTileImage = true;
            this.mtMenu.Click += new System.EventHandler(this.mtMenu_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::RED7Studios.EzCar.Properties.Resources.NoArt;
            this.pbLogo.Location = new System.Drawing.Point(9, 61);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(120, 120);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 19;
            this.pbLogo.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(573, 61);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 10);
            this.axWindowsMediaPlayer1.TabIndex = 36;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // frmMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 525);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.mtControls);
            this.Controls.Add(this.mtMenu);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.tbProgress);
            this.Controls.Add(this.lbAlbums);
            this.Controls.Add(this.lbArtists);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.lbArtist);
            this.Controls.Add(this.lbSong);
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menu;
            this.MaximumSize = new System.Drawing.Size(1680, 1010);
            this.Name = "frmMusic";
            this.ShowIcon = false;
            this.Text = "Music";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMusic_FormClosing);
            this.Load += new System.EventHandler(this.frmMusic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).EndInit();
            this.gbControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.TrackBar tbProgress;
        private System.Windows.Forms.Timer NewSong;
        private System.Windows.Forms.ListBox lbAlbums;
        private System.Windows.Forms.ListBox lbArtists;
        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbAlbum;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbSong;
        private System.Windows.Forms.Timer SaveSongInfo;
        private System.Windows.Forms.MenuStrip menu;
        private MetroFramework.Controls.MetroTile mtPlayPause;
        private MetroFramework.Controls.MetroTile mtPrevious;
        private MetroFramework.Controls.MetroTile mtShuffle;
        private MetroFramework.Controls.MetroTile mtNext;
        private MetroFramework.Controls.MetroTile mtMenu;
        private MetroFramework.Controls.MetroTile mtControls;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}