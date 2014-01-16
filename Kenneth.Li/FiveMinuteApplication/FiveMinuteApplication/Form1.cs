using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FiveMinuteApplication
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            huskyGradPictureBox.Hide();
            stopHuskySong.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void huskyPictureBox_Click_1(object sender, EventArgs e)
        {
            huskyGradPictureBox.Show();
            label1.Hide();
            player = new
            SoundPlayer(FiveMinuteApplication.Properties.Resources.Baha_Men___Who_Let_The_Dogs_Out);
            player.Play();
            stopHuskySong.Show();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void stopHuskySong_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

    }
}
