using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics; // Tambahkan paling atas


namespace WindowsFormsApp4
{
    public partial class FormPageHum : Form
    {

        public FormPageHum()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnPinned_Click(object sender, EventArgs e)
        {
            // Membuat instance dari form Playlist
            FormPageHum HumPageForm = new FormPageHum();
            // Menampilkan form Playlist
            HumPageForm.Show();
            // Menyembunyikan form saat ini (opsional)
            this.Close();
        }

        private void btnPlayQueue_Click(object sender, EventArgs e)
        {
            // Membuat instance dari form Playlist
            FormPageNowPlaying NowPlayingForm = new FormPageNowPlaying();
            // Menampilkan form Playlist
            NowPlayingForm.Show();
            // Menyembunyikan form saat ini (opsional)
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Membuat instance dari form Playlist
            FormPagePlaylists playlistForm = new FormPagePlaylists();
            // Menampilkan form Playlist
            playlistForm.Show();
            // Menyembunyikan form saat ini (opsional)
            this.Close();
        }

        private void FormPageHum_Load(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Membuat instance dari form Playlist
            FormPageSettings SettingsPageForm = new FormPageSettings();
            // Menampilkan form Playlist
            SettingsPageForm.Show();
            // Menyembunyikan form saat ini (opsional)
            this.Close();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
        
        }


        private void btnOpenFile_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mkv;*.mov;*.wmv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] selectedFiles = openFileDialog.FileNames;

                    // Bersihkan panel dulu
                    flowLayoutPanel1.Controls.Clear();

                    foreach (string file in selectedFiles)
                    {
                        // Ambil thumbnail
                        Image thumbnail = GetVideoThumbnail(file);

                        // Buat UI item
                        PictureBox thumb = new PictureBox
                        {
                            Size = new Size(120, 90),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Image = thumbnail,
                            BackColor = Color.Black
                        };

                        Label label = new Label
                        {
                            Text = Path.GetFileName(file),
                            Width = 120,
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        Panel itemPanel = new Panel
                        {
                            Size = new Size(120, 130)
                        };

                        // Posisi label
                        label.Top = thumb.Bottom + 2;

                        itemPanel.Controls.Add(thumb);
                        itemPanel.Controls.Add(label);

                        flowLayoutPanel1.Controls.Add(itemPanel);
                    }
                }
            }
        }

        private Image GetVideoThumbnail(string videoPath)
        {
            string ffmpegPath = @"C:\ffmpeg\bin\ffmpeg.exe"; // Ganti ke path ffmpeg kamu
            string thumbnailPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".jpg");

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = ffmpegPath,
                Arguments = $"-i \"{videoPath}\" -ss 00:00:01 -vframes 1 -q:v 2 \"{thumbnailPath}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };

            try
            {
                using (Process process = Process.Start(startInfo))
                {
                    process.WaitForExit();
                }

                if (File.Exists(thumbnailPath))
                {
                    Image img = Image.FromFile(thumbnailPath);
                    return img;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat membuat thumbnail: " + ex.Message);
            }

            return null;
        }
    }
}
