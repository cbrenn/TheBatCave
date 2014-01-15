namespace FiveMinuteApplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.huskyPictureBox = new System.Windows.Forms.PictureBox();
            this.huskyGradPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.huskyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huskyGradPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is the UW Husky, click me!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // huskyPictureBox
            // 
            this.huskyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("huskyPictureBox.Image")));
            this.huskyPictureBox.Location = new System.Drawing.Point(50, 44);
            this.huskyPictureBox.Name = "huskyPictureBox";
            this.huskyPictureBox.Size = new System.Drawing.Size(99, 95);
            this.huskyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.huskyPictureBox.TabIndex = 1;
            this.huskyPictureBox.TabStop = false;
            // 
            // huskyGradPictureBox
            // 
            this.huskyGradPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("huskyGradPictureBox.Image")));
            this.huskyGradPictureBox.Location = new System.Drawing.Point(22, 35);
            this.huskyGradPictureBox.Name = "huskyGradPictureBox";
            this.huskyGradPictureBox.Size = new System.Drawing.Size(148, 224);
            this.huskyGradPictureBox.TabIndex = 2;
            this.huskyGradPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 323);
            this.Controls.Add(this.huskyGradPictureBox);
            this.Controls.Add(this.huskyPictureBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Five Minute Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.huskyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huskyGradPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox huskyPictureBox;
        private System.Windows.Forms.PictureBox huskyGradPictureBox;
    }
}

