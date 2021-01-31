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
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.lbDebug = new System.Windows.Forms.Label();
            this.tbProgress = new System.Windows.Forms.TrackBar();
            this.NewSong = new System.Windows.Forms.Timer(this.components);
            this.lbAlbums = new System.Windows.Forms.ListBox();
            this.lbArtists = new System.Windows.Forms.ListBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnOpenControls = new System.Windows.Forms.Button();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbSong = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.SaveSongInfo = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).BeginInit();
            this.gbControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVolume
            // 
            this.tbVolume.BackColor = System.Drawing.SystemColors.Control;
            this.tbVolume.Location = new System.Drawing.Point(668, 420);
            this.tbVolume.Maximum = 50;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(120, 45);
            this.tbVolume.TabIndex = 28;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbVolume.Scroll += new System.EventHandler(this.tbVolume_Scroll);
            // 
            // lbDebug
            // 
            this.lbDebug.AutoSize = true;
            this.lbDebug.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbDebug.Location = new System.Drawing.Point(12, 25);
            this.lbDebug.Name = "lbDebug";
            this.lbDebug.Size = new System.Drawing.Size(92, 13);
            this.lbDebug.TabIndex = 26;
            this.lbDebug.Text = "DEBUG ENABLED";
            this.lbDebug.Visible = false;
            this.lbDebug.Click += new System.EventHandler(this.lbDebug_Click);
            // 
            // tbProgress
            // 
            this.tbProgress.BackColor = System.Drawing.SystemColors.Control;
            this.tbProgress.Location = new System.Drawing.Point(12, 420);
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
            this.lbAlbums.Location = new System.Drawing.Point(575, 177);
            this.lbAlbums.Name = "lbAlbums";
            this.lbAlbums.ScrollAlwaysVisible = true;
            this.lbAlbums.Size = new System.Drawing.Size(213, 134);
            this.lbAlbums.TabIndex = 24;
            this.lbAlbums.SelectedIndexChanged += new System.EventHandler(this.lbAlbums_SelectedIndexChanged);
            // 
            // lbArtists
            // 
            this.lbArtists.FormattingEnabled = true;
            this.lbArtists.Location = new System.Drawing.Point(575, 38);
            this.lbArtists.Name = "lbArtists";
            this.lbArtists.ScrollAlwaysVisible = true;
            this.lbArtists.Size = new System.Drawing.Size(213, 134);
            this.lbArtists.TabIndex = 23;
            this.lbArtists.SelectedIndexChanged += new System.EventHandler(this.lbArtists_SelectedIndexChanged);
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnShuffle.ForeColor = System.Drawing.Color.White;
            this.btnShuffle.Location = new System.Drawing.Point(375, 14);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(117, 75);
            this.btnShuffle.TabIndex = 14;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // lbSongs
            // 
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.Location = new System.Drawing.Point(499, 10);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(272, 82);
            this.lbSongs.TabIndex = 13;
            this.lbSongs.SelectedIndexChanged += new System.EventHandler(this.lbSongs_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(252, 14);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(117, 75);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(421, 241);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(148, 70);
            this.btnMenu.TabIndex = 22;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(129, 14);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(117, 75);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDebug.FlatAppearance.BorderSize = 0;
            this.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebug.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebug.ForeColor = System.Drawing.Color.White;
            this.btnDebug.Location = new System.Drawing.Point(264, 241);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(148, 70);
            this.btnDebug.TabIndex = 27;
            this.btnDebug.Text = "Debug";
            this.btnDebug.UseVisualStyleBackColor = false;
            this.btnDebug.Visible = false;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.btnShuffle);
            this.gbControls.Controls.Add(this.lbSongs);
            this.gbControls.Controls.Add(this.btnNext);
            this.gbControls.Controls.Add(this.btnPrevious);
            this.gbControls.Controls.Add(this.btnPlayPause);
            this.gbControls.Location = new System.Drawing.Point(12, 317);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(776, 97);
            this.gbControls.TabIndex = 21;
            this.gbControls.TabStop = false;
            this.gbControls.Visible = false;
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPlayPause.FlatAppearance.BorderSize = 0;
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnPlayPause.ForeColor = System.Drawing.Color.White;
            this.btnPlayPause.Location = new System.Drawing.Point(6, 14);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(117, 75);
            this.btnPlayPause.TabIndex = 0;
            this.btnPlayPause.Text = "Play/Pause";
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnOpenControls
            // 
            this.btnOpenControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOpenControls.FlatAppearance.BorderSize = 0;
            this.btnOpenControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenControls.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenControls.ForeColor = System.Drawing.Color.White;
            this.btnOpenControls.Location = new System.Drawing.Point(15, 241);
            this.btnOpenControls.Name = "btnOpenControls";
            this.btnOpenControls.Size = new System.Drawing.Size(148, 70);
            this.btnOpenControls.TabIndex = 20;
            this.btnOpenControls.Text = "Open Controls";
            this.btnOpenControls.UseVisualStyleBackColor = false;
            this.btnOpenControls.Click += new System.EventHandler(this.btnOpenControls_Click);
            // 
            // lbAlbum
            // 
            this.lbAlbum.AutoSize = true;
            this.lbAlbum.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.lbAlbum.Location = new System.Drawing.Point(138, 124);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(174, 36);
            this.lbAlbum.TabIndex = 18;
            this.lbAlbum.Text = "PLAY A SONG";
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.lbArtist.Location = new System.Drawing.Point(138, 83);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(174, 36);
            this.lbArtist.TabIndex = 17;
            this.lbArtist.Text = "PLAY A SONG";
            // 
            // lbSong
            // 
            this.lbSong.AutoSize = true;
            this.lbSong.Font = new System.Drawing.Font("Segoe UI", 23F);
            this.lbSong.Location = new System.Drawing.Point(135, 38);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(205, 42);
            this.lbSong.TabIndex = 16;
            this.lbSong.Text = "PLAY A SONG";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::RED7Studios.EzCar.Properties.Resources.NoArt;
            this.pbLogo.Location = new System.Drawing.Point(12, 38);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(120, 120);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 19;
            this.pbLogo.TabStop = false;
            // 
            // SaveSongInfo
            // 
            this.SaveSongInfo.Enabled = true;
            this.SaveSongInfo.Interval = 5000;
            this.SaveSongInfo.Tick += new System.EventHandler(this.SaveSongInfo_Tick);
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 30;
            this.menu.Text = "menu";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // frmMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.lbDebug);
            this.Controls.Add(this.tbProgress);
            this.Controls.Add(this.lbAlbums);
            this.Controls.Add(this.lbArtists);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.btnOpenControls);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.lbArtist);
            this.Controls.Add(this.lbSong);
            this.MainMenuStrip = this.menu;
            this.Name = "frmMusic";
            this.ShowIcon = false;
            this.Text = "Music";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMusic_FormClosing);
            this.Load += new System.EventHandler(this.frmMusic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).EndInit();
            this.gbControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Label lbDebug;
        private System.Windows.Forms.TrackBar tbProgress;
        private System.Windows.Forms.Timer NewSong;
        private System.Windows.Forms.ListBox lbAlbums;
        private System.Windows.Forms.ListBox lbArtists;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnOpenControls;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbAlbum;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbSong;
        private System.Windows.Forms.Timer SaveSongInfo;
        private System.Windows.Forms.MenuStrip menu;
    }
}