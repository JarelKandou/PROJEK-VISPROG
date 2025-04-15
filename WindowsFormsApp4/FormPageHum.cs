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
            RenderOpenedVideos();
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
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath;

                    // Ambil semua file video di folder
                    string[] videoFiles = Directory.GetFiles(selectedFolder, "*.*", SearchOption.TopDirectoryOnly)
                                                   .Where(file => file.EndsWith(".mp4") || file.EndsWith(".avi") ||
                                                                  file.EndsWith(".mkv") || file.EndsWith(".mov") ||
                                                                  file.EndsWith(".wmv")).ToArray();

                    flowLayoutPanel1.Controls.Clear(); // Bersihkan yang lama

                    foreach (string file in videoFiles)
                    {
                        Image thumbnail = GetVideoThumbnail(file); // pastikan thumbnail didapat di sini
                        Panel item = CreateVideoItem(file, thumbnail);
                        flowLayoutPanel1.Controls.Add(item);

                        // Tambahkan ke storage agar tidak hilang saat ganti form
                        OpenedVideoStorage.Add(file, thumbnail);
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

        private Panel CreateVideoItem(string file, Image thumbnail)
        {
            PictureBox thumb = new PictureBox
            {
                Size = new Size(120, 90),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = thumbnail,
                BackColor = Color.Black,
                Cursor = Cursors.Hand,
                Tag = file
            };

            thumb.Click += (s, args) =>
            {
                string videoFilePath = ((PictureBox)s).Tag.ToString();
                try
                {
                    FormPlayer playerForm = new FormPlayer(videoFilePath);
                    playerForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membuka player: " + ex.Message);
                }
            };

            Label label = new Label
            {
                Text = Path.GetFileName(file),
                Width = 120,
                TextAlign = ContentAlignment.MiddleCenter
            };

            Panel panel = new Panel
            {
                Size = new Size(120, 130)
            };

            label.Top = thumb.Bottom + 2;
            panel.Controls.Add(thumb);
            panel.Controls.Add(label);

            return panel;
        }

        private void RenderOpenedVideos()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var video in OpenedVideoStorage.Videos)
            {
                Panel item = CreateVideoItem(video.FilePath, video.Thumbnail);
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
