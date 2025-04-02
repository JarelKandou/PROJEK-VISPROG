using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormPageSettings : Form
    {
        // Add these variables at the top
        private bool isDarkMode = false;
        private Color darkBackColor = Color.FromArgb(45, 45, 48);
        private Color darkForeColor = Color.White;
        private Color darkPanelColor = Color.FromArgb(30, 30, 32);
        private Color darkControlColor = Color.FromArgb(63, 63, 70);

        public FormPageSettings()
        {
            InitializeComponent();
            this.btnLightMode = new System.Windows.Forms.RadioButton();
            this.btnDarkMode = new System.Windows.Forms.RadioButton();

            // Configure them
            this.btnLightMode.Text = "Light Mode";
            this.btnDarkMode.Text = "Dark Mode";
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ToggleDarkMode()
        {
            isDarkMode = !isDarkMode;

            // Apply to form
            this.BackColor = isDarkMode ? darkBackColor : SystemColors.Control;
            this.ForeColor = isDarkMode ? darkForeColor : SystemColors.ControlText;

            // Apply to panel
            panelSidebar.BackColor = isDarkMode ? darkPanelColor : SystemColors.ControlLight;

            // Apply to buttons
           
            {
             
            }

            // Apply to Guna2Button if you're using it
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormPageHum HumPageForm = new FormPageHum();
            if (isDarkMode)
            {
                HumPageForm.BackColor = darkBackColor;
                HumPageForm.ForeColor = darkForeColor;
            }
            HumPageForm.Show();
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

        private void FormPageSettings_Load(object sender, EventArgs e)
        {
            // Load saved theme preference
            isDarkMode = Properties.Settings.Default.DarkMode;
            if (isDarkMode)
            {
                ToggleDarkMode(); // Apply dark mode if enabled
                btnDarkMode.Checked = true;
            }
            else
            {
                btnLightMode.Checked = true;
            }
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnLightMode_CheckedChanged(object sender, EventArgs e)
        {
            if (btnLightMode.Checked && !isDarkMode)
            {
                ToggleDarkMode(); // Switch to dark mode
            }
        }

        // Add this new method for dark mode toggle
        private void btnDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (btnDarkMode.Checked && isDarkMode)
            {
                ToggleDarkMode(); // Switch to light mode
            }
        }
    }
}
