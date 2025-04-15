using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp4.FormPageNowPlaying;

namespace WindowsFormsApp4
{
    public partial class FormPlayer : Form
    {
        private string currentVideoPath;
        private double lastPosition = 0;

        private string videoPath;

        public FormPlayer(string videoPath)
        {
            InitializeComponent();
            currentVideoPath = videoPath;
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }


        private void FormPlayer_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                lastPosition = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
        }

        private void FormPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            NowPlayingStorage.AddOrUpdate(currentVideoPath, lastPosition);
        }

        public void ResumeFrom(double position)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = position;
        }


    }

}
