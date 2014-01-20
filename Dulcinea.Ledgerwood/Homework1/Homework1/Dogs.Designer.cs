namespace Homework1
{
    partial class Dogs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.moarBtn = new System.Windows.Forms.Button();
            this.dogsPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dogsPB)).BeginInit();
            this.SuspendLayout();
            // 
            // moarBtn
            // 
            this.moarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moarBtn.Location = new System.Drawing.Point(921, 79);
            this.moarBtn.Name = "moarBtn";
            this.moarBtn.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.moarBtn.Size = new System.Drawing.Size(127, 62);
            this.moarBtn.TabIndex = 1;
            this.moarBtn.Text = "Show me moar!";
            this.moarBtn.UseVisualStyleBackColor = true;
            this.moarBtn.Click += new System.EventHandler(this.moarBtn_Click);
            // 
            // dogsPB
            // 
            this.dogsPB.Image = global::Homework1.Properties.Resources.NayaBaileyOreo;
            this.dogsPB.Location = new System.Drawing.Point(198, 79);
            this.dogsPB.Name = "dogsPB";
            this.dogsPB.Size = new System.Drawing.Size(604, 407);
            this.dogsPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dogsPB.TabIndex = 2;
            this.dogsPB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1106, 653);
            this.Controls.Add(this.dogsPB);
            this.Controls.Add(this.moarBtn);
            this.Name = "Form1";
            this.Text = "I love my puppies";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dogsPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moarBtn;
        private System.Windows.Forms.PictureBox dogsPB;
    }
}

