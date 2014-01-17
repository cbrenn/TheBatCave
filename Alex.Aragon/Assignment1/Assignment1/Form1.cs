using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult feedback1 = MessageBox.Show("Wasn't that fun?",
            "You clicked it!",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (feedback1 == DialogResult.Yes)
            {
                MessageBox.Show("If was fun for me too");
            }
            else {
                MessageBox.Show("Give me a break it's my first C# program.");
            }


        }
    }
}
