using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp4
{
    public partial class FormPageNowPlaying : Form
    {
        public FormPageNowPlaying()
        {
            InitializeComponent();
            DisplayVideoHistory(); // Pindahkan logika tampil thumbnail ke sini
        }

        private void DisplayVideoHistory()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var video in OpenedVideoStorage.Videos.AsEnumerable().Reverse())
            {
                var panel = new Panel { Size = new Size(120, 130) };

                var label = new Label
                {
                    Text = Path.GetFileName(video.FilePath),
                    Width = 120,
                    TextAlign = ContentAlignment.MiddleCenter
                };

                var thumb = new PictureBox
                {
                    Size = new Size(120, 90),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = video.Thumbnail,
                    BackColor = Color.Black,
                    Cursor = Cursors.Hand,
                    Tag = video.FilePath
                };

                thumb.Click += (s, args) =>
                {
                    string path = (string)((PictureBox)s).Tag;
                    var stored = NowPlayingStorage.Videos.FirstOrDefault(v => v.FilePath == path);
                    FormPlayer player = new FormPlayer(path);
                    player.Show();

                    if (stored != null)
                        player.ResumeFrom(stored.LastPosition);
                };

                label.Top = thumb.Bottom + 2;
                panel.Controls.Add(thumb);
                panel.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormPageHum HumPageForm = new FormPageHum();
            HumPageForm.Show();
            this.Close();
        }

        private void btnPinned_Click(object sender, EventArgs e)
        {
        }

        private void btnPlayQueue_Click(object sender, EventArgs e)
        {
            FormPageNowPlaying NowPlayingForm = new FormPageNowPlaying();
            NowPlayingForm.Show();
            this.Close();
        }

        public class NowPlayingVideo
        {
            public string FilePath { get; set; }
            public double LastPosition { get; set; } // Dalam detik
        }

        public static class NowPlayingStorage
        {
            public static List<NowPlayingVideo> Videos = new List<NowPlayingVideo>();

            public static void AddOrUpdate(string filePath, double position)
            {
                var existing = Videos.FirstOrDefault(v => v.FilePath == filePath);
                if (existing != null)
                {
                    existing.LastPosition = position;
                }
                else
                {
                    Videos.Add(new NowPlayingVideo
                    {
                        FilePath = filePath,
                        LastPosition = position
                    });
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Judol_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormPagePlaylists playlistForm = new FormPagePlaylists();
            playlistForm.Show();
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormPageSettings SettingsPageForm = new FormPageSettings();
            SettingsPageForm.Show();
            this.Close();
        }

        // Hapus event ini karena tidak digunakan lagi
        private void FormPageNowPlaying_Load(object sender, EventArgs e)
        {
        }
        private void Form_Load(object sender, EventArgs e)
        {
            AppTheme.ApplyTheme(this);
        }



    }
}
