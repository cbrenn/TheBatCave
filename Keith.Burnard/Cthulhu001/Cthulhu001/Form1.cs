using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cthulhu001
{
    public partial class frmWWCD : Form
    {
        public frmWWCD()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbQuestion.Text = "";
            lblAnswer.Text = "";
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            Random Answer = new Random();
            int Answer_INT = Answer.Next(8);

            if (tbQuestion.Text == "")
            {
                MessageBox.Show("In order to get an answer, you have to actually ask a question.");
                tbQuestion.Focus();
            }
            else 
            {
                RetunAnswer(Answer_INT);
            }
                        

        }

        private void RetunAnswer(int Answer_INT)
        {
            switch (Answer_INT)
            {
                case 1:
                    lblAnswer.Text = "Go back to bed";
                    break;

                case 2:
                    lblAnswer.Text = "Eat their souls";
                    break;

                case 3:
                    lblAnswer.Text = "Destroy the earth";
                    break;

                case 4:
                    lblAnswer.Text = "Fold space and time so the situation is no longer relevant";
                    break;

                case 5:
                    lblAnswer.Text = "The answer will be found on page 974 of the Necronomicon. \n Make sure to use the Latin translation!";
                    break;

                case 6:
                    lblAnswer.Text = "Call Dagon and go out for a pint";
                    break;

                case 7:
                    lblAnswer.Text = "Answer unclear. Sacrafice your neighbor and try again";
                    break;

                case 8:
                    lblAnswer.Text = "42";
                    break;
            }
        }
    }
}
