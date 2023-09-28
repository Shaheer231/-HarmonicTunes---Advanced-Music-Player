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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        Random rand = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if(guna2ProgressBar1.Value>=100)
                {

                    Form2 frm = new Form2();

                    frm.Show();

                    this.Hide();

                    timer1.Stop();
                }

                else
                {
                    guna2ProgressBar1.Value += rand.Next(2, 35);
                }
               
            }

            catch(Exception)
            {
                
            }
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
