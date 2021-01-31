using ECMU.Interface;
using RED7Studios.EzCar.Properties;
using RED7Studios.UI.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using WMPLib;

namespace RED7Studios.EzCar.Players
{
    public partial class frmMusic : ModernForm
    {
        // Create a new windows media player variable called 'player'.
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        // Create a new 'PluginImplementerMenu' called 'PI'.
        PluginImplementerMenu PI;

        public frmMusic()
        {
            // Initalize the form.
            InitializeComponent();

            // Initalize the languages.
            this.Text = Languages.Resources.frmMusic_Name;
            this.mtMenu.Text = Languages.Resources.frmMusic_Menu;
            this.lbAlbum.Text = Languages.Resources.frmMusic_PlayASong;
            this.lbArtist.Text = Languages.Resources.frmMusic_PlayASong;
            this.lbSong.Text = Languages.Resources.frmMusic_PlayASong;

        }

        // Create a new string called 'musicRootDirectory' and set it to the MusicDirectory file.
        private string musicRootDirectory = File.ReadAllText(@"settings/MusicDirectory.txt");

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

        private void frmMusic_Load(object sender, EventArgs e)
        {
            // ----------------------------
            // --- File/Directory Check ---
            // ----------------------------

            if (!Directory.Exists("settings\\lastsonginfo"))
            {
                // Create the last song info directory.
                Directory.CreateDirectory("settings\\lastsonginfo");
            }

            if (!File.Exists("settings\\lastsonginfo\\artist"))
            {
                // Write the last artist to a file.
                File.WriteAllText(@"settings/lastsonginfo/artist", lbArtists.SelectedIndex.ToString());
            }

            if (!File.Exists("settings\\lastsonginfo\\album"))
            {
                // Write the last album to a file.
                File.WriteAllText(@"settings/lastsonginfo/album", lbAlbums.SelectedIndex.ToString());
            }

            if (!File.Exists("settings\\lastsonginfo\\song"))
            {
                // Write the last song to a file.
                File.WriteAllText(@"settings/lastsonginfo/song", lbSongs.SelectedIndex.ToString());
            }

            if (!File.Exists("settings\\lastsonginfo\\pos"))
            {
                // Write the last position to a file.
                File.WriteAllText(@"settings/lastsonginfo/pos", player.controls.currentPosition.ToString());
            }

            if (!File.Exists("settings\\lastsonginfo\\volume"))
            {
                // Write the last volume to a file.
                File.WriteAllText(@"settings/lastsonginfo/volume", player.settings.volume.ToString());
            }





            // ---------------
            // --- Plugins ---
            // ---------------

            // For each of the plugins in the 'Plugins' directory.
            foreach (var files in Directory.GetFiles(@"Plugins", "*.dll"))
            {
                // Create a new variable called 'assembly' and load the files.
                var assembly = Assembly.LoadFrom(files);
                // For each of the types in the assembly types.
                foreach (var type in assembly.GetTypes())
                {
                    // If the type interfaces contains the plugin implementer for the menu.
                    if (type.GetInterfaces().Contains(typeof(PluginImplementerMenu)))
                    {
                        // Set PI to the new instance of type as the plugin implementer for the menu.
                        PI = Activator.CreateInstance(type) as PluginImplementerMenu;
                        // Create a new string called 'name' with the plugin name.
                        string name = PI.PluginName();

                        // Create a new ToolStripMenuItem called 'tsi' with the name of the plugin.
                        ToolStripMenuItem tsi = new ToolStripMenuItem(name);
                        // Add the 'tsi' to the menu.
                        menu.Items.Add(tsi);
                        // Run the menu adder of the plugin.
                        PI.MenuAdder(tsi);
                    }
                }
            }





            // -----------------
            // --- Playlists ---
            // -----------------

            try
            {
                // Create a new list (with string) called 'dataSource'.
                List<String> dataSource = new List<String>();
                // Set the 'dataSource' to the sub directorys of the music directory.
                dataSource = Directory.GetDirectories(musicRootDirectory).Select(Path.GetFileName).ToList();

                // IF the 'System Volume Information' exists in the 'dataSource'.
                if (dataSource.Contains("System Volume Information"))
                {
                    // Remove it from 'dataSource'.
                    dataSource.RemoveAt(0);
                }

                // Set the DataSource of the artists list to 'dataSource'.
                lbArtists.DataSource = dataSource;

                // Set the 'volume' taskbar to the players volume.
                tbVolume.Value = player.settings.volume;

                // Run the create playlist function.
                CreatePlaylist();

                // Set the selected index of the artists listbox the the last artist played.
                lbArtists.SelectedIndex = Convert.ToInt32(File.ReadAllText(@"settings/lastsonginfo/artist"));
                // Set the selected index of the albums listbox the the last album played.
                lbAlbums.SelectedIndex = Convert.ToInt32(File.ReadAllText(@"settings/lastsonginfo/album"));
                // Set the selected index of the songs listbox the the last song played.
                lbSongs.SelectedIndex = Convert.ToInt32(File.ReadAllText(@"settings/lastsonginfo/song"));
                // Set the players current position to the last SAVED position.
                player.controls.currentPosition = Convert.ToDouble(File.ReadAllText(@"settings/lastsonginfo/pos"));
                // Set the playes volume to the last volume.
                player.settings.volume = Convert.ToInt32(File.ReadAllText(@"settings/lastsonginfo/volume"));

            }
            catch (Exception ex)
            {
                // Create a message box with the error (exception).
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void CreatePlaylist()
        {
            try
            {
                // Create a new music string with the selected song in a string form.
                string music = lbSongs.SelectedItem.ToString();
                // Set the players url to 'music'.
                player.URL = music;

                // Make the player play.
                player.controls.play();
            }
            catch (Exception ex)
            {
                // Create a message box with the error (exception).
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void AfterInfo()
        {
            // Set the maximum progress to the current duration.
            tbProgress.Maximum = Convert.ToInt32(player.controls.currentItem.duration);

            // Create a double variable called percent.
            double percent;

            // Set 'percent' to the current position divided by the current song duration.
            percent = ((double)player.controls.currentPosition / player.controls.currentItem.duration);

            // Multiple the progress by the percent double to make it work.
            tbProgress.Value = (int)(percent * tbProgress.Maximum);

            // Set the volume track bar to the players volume.
            tbVolume.Value = player.settings.volume;
        }

        private void NewSong_Tick(object sender, EventArgs e)
        {
            try
            {
                // If the players play state is 'playing'.
                if (player.playState == WMPPlayState.wmppsPlaying)
                {
                    // Set the text of the song to the meta data 'Title'.
                    lbSong.Text = player.currentMedia.getItemInfo("Title");
                    // Set text of the artist to the meta data 'Artist'.
                    lbArtist.Text = player.currentMedia.getItemInfo("Artist");
                    // Set text of the album to the meta data 'Album'.
                    lbAlbum.Text = player.currentMedia.getItemInfo("Album");

                    // Create a string called dir and set it to the directory of the song.
                    string dir = Path.GetDirectoryName(player.currentMedia.sourceURL);
                    // Create a string called guid and get the item info of the song.
                    string guid = player.currentMedia.getItemInfo("WMCollectionID");
                    // Create a string called filename and combine 'dir' with album.jpg.
                    string filename = Path.Combine(dir, string.Format("album.jpg"));

                    // If the album.jpg file exists
                    if (!File.Exists(filename))
                    {
                        // Set the picture boxs image to the 'NoArt' image.
                        pbLogo.Image = Resources.NoArt;
                        // Run the after info function.
                        AfterInfo();
                        // Return.
                        return;
                    }

                    // Set the picture box to the album.jpg.
                    pbLogo.Image = Image.FromFile(filename);

                    // Run the after info function.
                    AfterInfo();
                }
                // If the players play state is 'stopped'.
                else if (player.playState == WMPPlayState.wmppsStopped)
                {
                    // Set the progress to 0.
                    tbProgress.Value = 0;

                    // Stupid code that I don't even know what it does.
                    // If the songs item count is the selected index.
                    if (lbSongs.Items.Count - 1 == lbSongs.SelectedIndex)
                    {
                        // Pause the player to make error not happen.
                        player.controls.pause();
                        // If the albums item count is the selected index.
                        if (lbAlbums.Items.Count - 1 == lbAlbums.SelectedIndex)
                        {
                            // If the artists item count is the selected index.
                            if (lbArtists.Items.Count - 1 == lbArtists.SelectedIndex)
                            {
                                // Set the artists selected index to 0.
                                lbArtists.SelectedIndex = 0;
                            }
                            else
                            {
                                // Set the artists selected index plus 1.
                                lbArtists.SelectedIndex = +1;
                            }
                        }
                        else
                        {
                            // Set the albums selected index plus 1.
                            lbAlbums.SelectedIndex = +1;
                        }

                    }
                    else
                    {
                        // Set the songs selected index plus 1.
                        lbSongs.SelectedIndex = +1;
                    }
                }
            }
            catch (Exception ex)
            {
                // Create a new message box with the error (exception).
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void mtControls_Click(object sender, EventArgs e)
        {
            try
            {
                // If the open button text is 'Open Controls'.
                if (mtControls.Text == Languages.Resources.frmMusic_Open)
                {
                    // Set the open button text to 'Close Controls'.
                    mtControls.Text = Languages.Resources.frmMusic_Close;

                    // Make the group box for the controls visible.
                    gbControls.Visible = true;
                }
                // If the open button text is 'Close Controls'.
                else if (mtControls.Text == Languages.Resources.frmMusic_Close)
                {
                    // Set the open button text to 'Open Controls'.
                    mtControls.Text = Languages.Resources.frmMusic_Open;
                    // Make the group box for the controls invisible.
                    gbControls.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // Create a new message box with the error (exception).
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void tbProgress_Scroll(object sender, EventArgs e)
        {
            try
            {
                // Set the players current position to the progress.
                player.controls.currentPosition = tbProgress.Value;
            }
            catch (Exception ex)
            {
                // Create a new message box with the error (exception).
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void mtPlayPause_Click(object sender, EventArgs e)
        {
            try
            {
                // If the players play state is 'playing'.
                if (player.playState == WMPPlayState.wmppsPlaying)
                {
                    // Pause the player.
                    player.controls.pause();
                }
                else
                {
                    // Play the player.
                    player.controls.play();
                }
            }
            catch (Exception ex)
            {
                // Create a new message box with the error (exception).
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void mtPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a variable called 'list' with the songs selected index.
                var list = lbSongs.SelectedIndex;
                // If the list DOESN'T equal 0.
                if (list != 0)
                {
                    // Set the songs selected index to 'list' minus 1.
                    lbSongs.SelectedIndex = list - 1;
                }
            }
            catch (Exception ex)
            {
                // Create a new message box with the error (exception).
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void mtNext_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new variable called 'list' with the songs selected index.
                var list = lbSongs.SelectedIndex;
                // Create a new variable called 'count' with the counts of the songs.
                var count = lbSongs.Items.Count;
                // If the 'list' equals the 'count' minus 1.
                if (list == count - 1)
                {

                }
                else
                {
                    // Set the songs selected index to 'list' plus 1.
                    lbSongs.SelectedIndex = list + 1;
                }
                // Write a line with 'count' to the console.
                Console.WriteLine(count);
                // Write a line with 'list' to the console.
                Console.WriteLine(list);
            }
            catch (Exception ex)
            {
                // Create a new message box with the error (exception).
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void mtShuffle_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new list called 'list'.
                List<String> list = new List<String>();

                // Set the 'list' to the musics root directory, selected artist and the selected album (and convert to a list).
                list = Directory.GetFiles(musicRootDirectory + @"\" + lbArtists.SelectedItem.ToString() + @"\" + lbAlbums.SelectedItem.ToString(), "*.mp3").ToList();

                // Create new random called 'random'.
                Random random = new Random();
                // Create a new integer with the lists count.
                int w = list.Count;
                // Being an update of the songs listbox.
                lbSongs.BeginUpdate();
                // While 'w' (count) is greater than 1.
                while (w > 1)
                {
                    // Minus the 'w' (count).
                    w--;
                    // Create a new integer with the random next of 'w' (count) plus 1.
                    int u = random.Next(w + 1);
                    // Create a new string called 'value' with the 'list' (content: 'u').
                    string value = list[u];
                    // Set 'list[u]' to 'list[w]'.
                    list[u] = list[w];
                    // Set 'list[w]' to 'value'.
                    list[w] = value;
                }
                // Set the songs data source to 'list'.
                lbSongs.DataSource = list;
                // End the update of the songs.
                lbSongs.EndUpdate();
                // Invalidate the songs.
                lbSongs.Invalidate();
            }
            catch (Exception ex)
            {
                // Create a new message box with the error (exception).
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void lbArtists_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Set the albums data source to the music directory and artists selected item with the file (and to a list).
                lbAlbums.DataSource = Directory.GetDirectories(musicRootDirectory + @"\" + lbArtists.SelectedItem).Select(Path.GetFileName).ToList();
            }
            catch (Exception ex)
            {
                // Create a new message box with the error (exception).
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void lbAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Set the songs data source to the musics root directory, selected artist and the selected album (and convert to a list).
                lbSongs.DataSource = Directory.GetFiles(musicRootDirectory + @"\" + lbArtists.SelectedItem.ToString() + @"\" + lbAlbums.SelectedItem.ToString(), "*.mp3").ToList();
                // Run the create playlist function.
                CreatePlaylist();
            }
            catch (Exception ex)
            {
                // Create a new message box with the error (exception).
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            try
            {
                // Set the players volume to the volume track bar value.
                player.settings.volume = tbVolume.Value;
            }
            catch (Exception ex)
            {
                // Create a new message box with the error (exception).
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }


        }

        private void frmMusic_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Exit the application.
            Application.Exit();
        }

        private void SaveSongInfo_Tick(object sender, EventArgs e)
        {
            // Write the last artist to a file.
            File.WriteAllText(@"settings/lastsonginfo/artist", lbArtists.SelectedIndex.ToString());
            // Write the last album to a file.
            File.WriteAllText(@"settings/lastsonginfo/album", lbAlbums.SelectedIndex.ToString());
            // Write the last song to a file.
            File.WriteAllText(@"settings/lastsonginfo/song", lbSongs.SelectedIndex.ToString());
            // Write the last SAVED position to a file.
            File.WriteAllText(@"settings/lastsonginfo/pos", player.controls.currentPosition.ToString());
            // Write the last volume to a file.
            File.WriteAllText(@"settings/lastsonginfo/volume", player.settings.volume.ToString());
        }

        private void lbSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Run the create playlist function.
            CreatePlaylist();
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
