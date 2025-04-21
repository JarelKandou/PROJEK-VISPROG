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
using AxWMPLib;

namespace WindowsFormsApp4
{
    public partial class FormPagePlaylists : Form
    {
        // Struktur data untuk menyimpan playlist per folder
        private Dictionary<string, List<string>> playlistByFolder = new Dictionary<string, List<string>>();

        public FormPagePlaylists()
        {
            InitializeComponent();

            treeViewPlaylist.NodeMouseDoubleClick += treeViewPlaylist_NodeMouseDoubleClick;

        }
        private void FormPagePlaylists_Load(object sender, EventArgs e)
        {
            // Pastikan TreeView dan Button sudah ada di form
            treeViewPlaylist.NodeMouseDoubleClick += treeViewPlaylist_NodeMouseDoubleClick;
        }
        private void _Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Video Files|*.mp4;*.avi;*.mkv;*.mov"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    string folder = Path.GetDirectoryName(filePath);

                    if (!playlistByFolder.ContainsKey(folder))
                    {
                        playlistByFolder[folder] = new List<string>();
                    }

                    playlistByFolder[folder].Add(filePath);
                }

                TampilkanPlaylist();
            }
        }
        private void btnAddFiles_Click1(object sender, EventArgs e)
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
                    if (!playlistByFolder.ContainsKey(selectedFolder))
                    {
                        playlistByFolder[selectedFolder] = new List<string>();
                    }

                    foreach (string file in videoFiles)
                    {
                        if (!playlistByFolder[selectedFolder].Contains(file))
                        {
                            playlistByFolder[selectedFolder].Add(file);
                        }
                    }

                    TampilkanPlaylist();
                }
            }
        }

        private void TampilkanPlaylist()
        {
            treeViewPlaylist.Nodes.Clear();

            foreach (var folderEntry in playlistByFolder)
            {
                TreeNode folderNode = new TreeNode(Path.GetFileName(folderEntry.Key));

                foreach (string file in folderEntry.Value)
                {
                    TreeNode fileNode = new TreeNode(Path.GetFileName(file))
                    {
                        Tag = file
                    };
                    folderNode.Nodes.Add(fileNode);
                }

                treeViewPlaylist.Nodes.Add(folderNode);
            }

            treeViewPlaylist.ExpandAll();
        }


        private void treeViewPlaylist_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Membuat instance dari form Playlist
            FormPageHum HumPageForm = new FormPageHum();
            // Menampilkan form Playlist
            HumPageForm.Show();
            // Menyembunyikan form saat ini (opsional)
            this.Close();

        }

        private void btnPinned_Click(object sender, EventArgs e)
        {
            
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

        private void labelHome_Click(object sender, EventArgs e)
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Membuat instance dari form Playlist
            FormPageSettings SettingsPageForm = new FormPageSettings();
            // Menampilkan form Playlist
            SettingsPageForm.Show();
            // Menyembunyikan form saat ini (opsional)
            this.Close();
        }

        private void btnAddFiles_Click_1(object sender, EventArgs e)
        {

        }
        private void Form_Load(object sender, EventArgs e)
        {
            AppTheme.ApplyTheme(this);
        }

    }
}
