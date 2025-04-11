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
                        Image thumbnail = GetVideoThumbnail(file);

                        PictureBox thumb = new PictureBox
                        {
                            Size = new Size(120, 90),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Image = thumbnail,
                            BackColor = Color.Black,
                            Cursor = Cursors.Hand, // Biar kelihatan bisa di-klik
                            Tag = file // Simpan path video di Tag
                        };

                        // Tambahkan event klik
                        thumb.Click += (s, args) =>
                        {
                            string videoFilePath = ((PictureBox)s).Tag.ToString();
                            try
                            {
                                Process.Start(new ProcessStartInfo
                                {
                                    FileName = videoFilePath,
                                    UseShellExecute = true // Wajib untuk buka file dengan media player
                                });
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Gagal membuka video: " + ex.Message);
                            }
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
            string ffmpegPath = @"C:\ffmpeg-2025-03-31-git-35c091f4b7-full_build\ffmpeg-2025-03-31-git-35c091f4b7-full_build\bin\ffmpeg.exe";
            string thumbnailPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".jpg");

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = ffmpegPath,
                Arguments = $"-ss 00:00:07 -i \"{videoPath}\" -frames:v 1 -q:v 2 \"{thumbnailPath}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardError = true // hanya error saja cukup
            };

            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();

                    string error = process.StandardError.ReadToEnd(); // bisa di-log kalau mau
                    process.WaitForExit();
                }

                if (File.Exists(thumbnailPath))
                {
                    using (var fs = new FileStream(thumbnailPath, FileMode.Open, FileAccess.Read))
                    {
                        Image img = Image.FromStream(fs);
                        return (Image)img.Clone();
                    }
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
