using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using System.IO;

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

        private void labelHome_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenFiles_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath;

                    // Ambil semua file video di folder
                    string[] videoFiles = Directory.GetFiles(selectedFolder, "*.*")
                                                   .Where(file => file.EndsWith(".mp4") || file.EndsWith(".avi") || file.EndsWith(".mkv") || file.EndsWith(".wmv") || file.EndsWith(".dvr"))
                                                   .ToArray();

                    // Bersihkan panel dulu
                    flowLayoutPanel1.Controls.Clear();

                    foreach (string file in videoFiles)
                    {
                        // Buat PictureBox + Label (atau Button) untuk setiap file
                        PictureBox thumb = new PictureBox();
                        thumb.Size = new Size(120, 90);
                        thumb.BackColor = Color.Black;
                        thumb.SizeMode = PictureBoxSizeMode.StretchImage;

                        // Optional: Tambahkan thumbnail kalau kamu punya
                        // thumb.Image = Image.FromFile(...);

                        Label label = new Label();
                        label.Text = Path.GetFileName(file);
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        label.Width = 120;

                        Panel itemPanel = new Panel();
                        itemPanel.Size = new Size(120, 130);
                        itemPanel.Controls.Add(thumb);
                        itemPanel.Controls.Add(label);

                        // Atur posisi label di bawah thumbnail
                        label.Top = thumb.Bottom + 2;

                        // Tambahkan ke FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(itemPanel);
                    }
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
