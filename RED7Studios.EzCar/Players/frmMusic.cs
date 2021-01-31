using ECMU.Interface;
using RED7Studios.EzCar.Properties;
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
    public partial class frmMusic : Form
    {
        // Create a new windows media player varible called 'player'.
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        PluginImplementerMenu PI;

        public frmMusic()
        {
            InitializeComponent();
        }

        // Directory for the music.
        private string musicRootDirectory = File.ReadAllText(@"settings/MusicDirectory.txt");

        private void btnMenu_Click(object sender, EventArgs e)
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

        private void frmMusic_Load(object sender, EventArgs e)
        {
            foreach (var files in Directory.GetFiles(@"Plugins", "*.dll"))
            {
                var assembly = Assembly.LoadFrom(files);
                foreach (var type in assembly.GetTypes())
                {
                    if (type.GetInterfaces().Contains(typeof(PluginImplementerMenu)))
                    {
                        PI = Activator.CreateInstance(type) as PluginImplementerMenu;
                        string name = PI.PluginName();

                        ToolStripMenuItem tsi = new ToolStripMenuItem(name);
                        menu.Items.Add(tsi);
                        PI.MenuAdder(tsi);
                    }
                }
            }


            try
            {
                // Create a new list.
                List<String> dataSource = new List<String>();
                // Get all of the sub directories of the root directory for music and convert it to a list.
                dataSource = Directory.GetDirectories(musicRootDirectory).Select(Path.GetFileName).ToList();

                // If "System Volume Information" exists,
                if (dataSource.Contains("System Volume Information"))
                {
                    // Then remove it from the data source which is all the sub directories of the root directory.
                    dataSource.RemoveAt(0);
                }

                // Populate artists list box with the list.
                lbArtists.DataSource = dataSource;

                // Set the volume value to what the player volume is.
                tbVolume.Value = player.settings.volume;

                // Utilize the create playlist function.
                CreatePlaylist();

                lbArtists.SelectedIndex = Convert.ToInt32(File.ReadAllText(@"settings/lastsonginfo/artist"));
                lbAlbums.SelectedIndex = Convert.ToInt32(File.ReadAllText(@"settings/lastsonginfo/album"));
                lbSongs.SelectedIndex = Convert.ToInt32(File.ReadAllText(@"settings/lastsonginfo/song"));
                player.controls.currentPosition = Convert.ToDouble(File.ReadAllText(@"settings/lastsonginfo/pos"));
                player.settings.volume = Convert.ToInt32(File.ReadAllText(@"settings/lastsonginfo/volume"));

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        // Create playlist function to create a playlist.
        private void CreatePlaylist()
        {
            try
            {
                // Set the player URL to what is selected in the songs list box.
                string music = lbSongs.SelectedItem.ToString();
                player.URL = music;

                // Play the player with the selected song.
                player.controls.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void AfterInfo()
        {
            // Set the maximum of the progress bar to the duration of the song.
            tbProgress.Maximum = Convert.ToInt32(player.controls.currentItem.duration);

            // Create a double variable called percent.
            double percent;
            // Set percent to the current position divided by the current song duration.
            percent = ((double)player.controls.currentPosition / player.controls.currentItem.duration);

            // The the progress bar value to the current progress of the song.
            // Multiple by the percent double to make it work.
            tbProgress.Value = (int)(percent * tbProgress.Maximum);

            tbVolume.Value = player.settings.volume;
        }

        private void NewSong_Tick(object sender, EventArgs e)
        {
            try
            {
                if (player.playState == WMPPlayState.wmppsPlaying)
                {
                    // Set labels with information about the song.
                    lbSong.Text = player.currentMedia.getItemInfo("Title");
                    lbArtist.Text = player.currentMedia.getItemInfo("Artist");
                    lbAlbum.Text = player.currentMedia.getItemInfo("Album");

                    // Create a string called dir and get directory from the player.
                    string dir = Path.GetDirectoryName(player.currentMedia.sourceURL);
                    // Create a string called guid and get the info of the song.
                    string guid = player.currentMedia.getItemInfo("WMCollectionID");
                    // Create a string called filename and combine 'dir' with album.jpg.
                    string filename = Path.Combine(dir, string.Format("album.jpg"));

                    // If the album.jpg file exists,
                    if (!File.Exists(filename))
                    {
                        // Set the picture box to the 'NoArt' resource.
                        pbLogo.Image = Resources.NoArt;
                        AfterInfo();
                        return;
                    }

                    // Set the picture box to the album.jpg.
                    pbLogo.Image = Image.FromFile(filename);

                    AfterInfo();
                }
                else if (player.playState == WMPPlayState.wmppsStopped)
                {
                    tbProgress.Value = 0;
                    // Cycle songs on the songs listbox.
                    lbSongs.SelectedIndex = lbSongs.SelectedIndex + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void btnOpenControls_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnOpenControls.Text == "Open Controls")
                {
                    btnOpenControls.Text = "Close Controls";
                    gbControls.Visible = true;
                }
                else if (btnOpenControls.Text == "Close Controls")
                {
                    btnOpenControls.Text = "Open Controls";
                    gbControls.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void tbProgress_Scroll(object sender, EventArgs e)
        {
            try
            {
                // Set the current position of the song to the value of this.
                player.controls.currentPosition = tbProgress.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (player.playState == WMPPlayState.wmppsPlaying)
                {
                    player.controls.pause();
                }
                else
                {
                    player.controls.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                var list = lbSongs.SelectedIndex;
                if (list != 0)
                {
                    lbSongs.SelectedIndex = list - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                var list = lbSongs.SelectedIndex;
                var count = lbSongs.Items.Count;
                if (list == count - 1)
                {

                }
                else
                {
                    lbSongs.SelectedIndex = list + 1;
                }
                Console.WriteLine(count);
                Console.WriteLine(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            try
            {
                List<String> list = new List<String>();
                list = Directory.GetFiles(musicRootDirectory + @"\" + lbArtists.SelectedItem.ToString() + @"\" + lbAlbums.SelectedItem.ToString(), "*.mp3").ToList();

                Random random = new Random();
                int w = list.Count;
                lbSongs.BeginUpdate();
                while (w > 1)
                {
                    w--;
                    int u = random.Next(w + 1);
                    string value = list[u];
                    list[u] = list[w];
                    list[w] = value;
                }
                lbSongs.DataSource = list;
                lbSongs.EndUpdate();
                lbSongs.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void lbArtists_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbAlbums.DataSource = Directory.GetDirectories(musicRootDirectory + @"\" + lbArtists.SelectedItem).Select(Path.GetFileName).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void lbAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbSongs.DataSource = Directory.GetFiles(musicRootDirectory + @"\" + lbArtists.SelectedItem.ToString() + @"\" + lbAlbums.SelectedItem.ToString(), "*.mp3").ToList();
                CreatePlaylist();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            try
            {
                player.settings.volume = tbVolume.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured with this instance.\n\nDetails: \n\n" + ex.Message + "\n\nThis has happened in " + ex.Source, "Sorry :(");
            }


        }

        private void frmMusic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SaveSongInfo_Tick(object sender, EventArgs e)
        {
            File.WriteAllText(@"settings/lastsonginfo/artist", lbArtists.SelectedIndex.ToString());
            File.WriteAllText(@"settings/lastsonginfo/album", lbAlbums.SelectedIndex.ToString());
            File.WriteAllText(@"settings/lastsonginfo/song", lbSongs.SelectedIndex.ToString());
            File.WriteAllText(@"settings/lastsonginfo/pos", player.controls.currentPosition.ToString());
            File.WriteAllText(@"settings/lastsonginfo/volume", player.settings.volume.ToString());
        }

        private void lbSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreatePlaylist();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void lbDebug_Click(object sender, EventArgs e)
        {

        }

        private void btnDebug_Click(object sender, EventArgs e)
        {

        }
    }
}
