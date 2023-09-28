using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Form2 : Form
    {
        private object lblTime;

        public Form2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Check if the media player is currently playing a media file
            if (axWindowsMediaPlayer1.URL != null)
            {
                // Pause the media player
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(axWindowsMediaPlayer1.playState== WMPLib.WMPPlayState.wmppsPaused)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
     
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Check if the media player is currently playing a media file
            if (axWindowsMediaPlayer1.URL != null)
            {
                // Increment the current position of the media player by 10 seconds
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 10;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.URL != null)
            {
                // Decrement the current position of the media player by 10 seconds
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 10;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(axWindowsMediaPlayer1.settings.playCount !=100)
            {
                axWindowsMediaPlayer1.settings.playCount = 100;
            }

            else
            {
                axWindowsMediaPlayer1.settings.playCount = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }


        private void btnFull_Click(object sender, EventArgs e)
        {
            if(this.WindowState ==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }

            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(splitContainer1.Panel1Collapsed == true)
            {
                splitContainer1.Panel1Collapsed =false;
            }

            else
            {
                splitContainer1.Panel1Collapsed = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            OFD.ShowDialog();
            string selectedFile = OFD.FileName;
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
           
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            // Set the filter for the file dialog to display only media files
            OFD.Filter = "Media Files|*.mp3;*.mp4;*.wmv;*.wma;*.wav";

            DialogResult result = OFD.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    axWindowsMediaPlayer1.URL = OFD.FileName;
                }
                catch (Exception)
                {
                }
            }
        }


        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            DialogResult result = OFD.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    axWindowsMediaPlayer1.URL = OFD.FileName;
                }
                catch (Exception)
                {
                }
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
