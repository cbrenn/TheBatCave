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
        SoundPlayer huskySong = new SoundPlayer(FiveMinuteApplication.Properties.Resources.Baha_Men___Who_Let_The_Dogs_Out);
        SoundPlayer cougSong = new SoundPlayer(FiveMinuteApplication.Properties.Resources.fail_trombone_01);

        public Form1()
        {
            InitializeComponent();
            huskyMascotPictureBox.Hide();
            playHuskySong.Hide();
            stopHuskySong.Hide();
            cougFailPictureBox.Hide();
            MessageBox.Show("Please have your sound on, but not too loud, thanks :)");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void huskyPictureBox_Click_1(object sender, EventArgs e)
        {
            huskyPictureBox.Hide();
            huskyMascotPictureBox.Show();
            label1.Hide();
            huskySong.Play();
            playHuskySong.Show();
            stopHuskySong.Show();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void stopHuskySong_Click(object sender, EventArgs e)
        {
            huskySong.Stop();
        }

        private void playHuskySong_Click(object sender, EventArgs e)
        {
            huskySong.Play();
        }

        private void cougPictureBox_Click(object sender, EventArgs e)
        {
            label2.Hide();
            cougPictureBox.Hide();
            cougFailPictureBox.Show();
            cougSong.Play();
            MessageBox.Show("Sorry, you don't get a cool song!");
        }
    }
}
