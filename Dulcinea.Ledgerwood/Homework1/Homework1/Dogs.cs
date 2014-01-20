using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Homework1.Properties;

namespace Homework1
{
    public partial class Dogs : Form
    {
        readonly Image[] dogImages = new Image[6];
       
        public Dogs()
        {
            InitializeComponent();
            
            // load image array - puppies!
            dogImages[0] = Resources.NayaBaileyOreo;
            dogImages[1] = Resources.Bailey2;
            dogImages[2] = Resources.Bert10;
            dogImages[3] = Resources.BertZeke;
            dogImages[4] = Resources.BertPool2;
            dogImages[5] = Resources.Gurgle;
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void moarBtn_Click(object sender, EventArgs e)
        {
            // hide our first picture box and make the backcolor dark gray.
            dogsPB.Hide();
            this.BackColor = Color.DarkSlateGray;

            // We'll collage these picture boxes on the form.
            PictureBox[] picturebox= new PictureBox[dogImages.Length-1];

            for (int index = 0; index < picturebox.Length; index++)
            {
                picturebox[index] = new PictureBox();
                this.Controls.Add(picturebox[index]);

                // I tried to determine the axis points dynamically but gave up after a failed try.
                switch (index)
                {
                    case 0:
                        picturebox[index].Location = new Point(20, 20);
                        break;
                    case 1:
                        picturebox[index].Location = new Point(20, 250);
                        break;
                    case 2:
                        picturebox[index].Location = new Point(250, 20);
                        break;
                    case 3:
                        picturebox[index].Location = new Point(200, 220);
                        break;
                    case 4:
                        picturebox[index].Location = new Point(500, 20);
                        break;
                }

                picturebox[index].Size = new Size(dogImages[index+1].Height, dogImages[index+1].Width);
                picturebox[index].SizeMode = PictureBoxSizeMode.AutoSize;
                picturebox[index].Image = dogImages[index+1];
                
            }

            // For now, hide the button.  If we have time we'll look into making it return to
            // to the previous picture.
            moarBtn.Hide();

        }
    }
}
