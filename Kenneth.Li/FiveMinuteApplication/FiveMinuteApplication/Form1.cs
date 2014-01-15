using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveMinuteApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            huskyGradPictureBox.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void huskyPictureBox_Click(object sender, EventArgs e)
        {
            huskyGradPictureBox.Show();
            label1.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
