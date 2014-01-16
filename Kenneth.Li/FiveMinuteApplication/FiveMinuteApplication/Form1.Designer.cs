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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.huskyTab = new System.Windows.Forms.TabPage();
            this.stopHuskySong = new System.Windows.Forms.Button();
            this.huskyGradPictureBox = new System.Windows.Forms.PictureBox();
            this.huskyPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.huskyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.huskyGradPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huskyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.huskyTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(197, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // huskyTab
            // 
            this.huskyTab.Controls.Add(this.stopHuskySong);
            this.huskyTab.Controls.Add(this.huskyGradPictureBox);
            this.huskyTab.Controls.Add(this.huskyPictureBox);
            this.huskyTab.Controls.Add(this.label1);
            this.huskyTab.Location = new System.Drawing.Point(4, 22);
            this.huskyTab.Name = "huskyTab";
            this.huskyTab.Padding = new System.Windows.Forms.Padding(3);
            this.huskyTab.Size = new System.Drawing.Size(189, 385);
            this.huskyTab.TabIndex = 0;
            this.huskyTab.Text = "Click if you\'re a Husky";
            this.huskyTab.UseVisualStyleBackColor = true;
            // 
            // stopHuskySong
            // 
            this.stopHuskySong.Location = new System.Drawing.Point(25, 297);
            this.stopHuskySong.Name = "stopHuskySong";
            this.stopHuskySong.Size = new System.Drawing.Size(115, 50);
            this.stopHuskySong.TabIndex = 6;
            this.stopHuskySong.Text = "Stop Playing Song";
            this.stopHuskySong.UseVisualStyleBackColor = true;
            this.stopHuskySong.Click += new System.EventHandler(this.stopHuskySong_Click);
            // 
            // huskyGradPictureBox
            // 
            this.huskyGradPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("huskyGradPictureBox.Image")));
            this.huskyGradPictureBox.Location = new System.Drawing.Point(6, 29);
            this.huskyGradPictureBox.Name = "huskyGradPictureBox";
            this.huskyGradPictureBox.Size = new System.Drawing.Size(150, 225);
            this.huskyGradPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.huskyGradPictureBox.TabIndex = 5;
            this.huskyGradPictureBox.TabStop = false;
            // 
            // huskyPictureBox
            // 
            this.huskyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("huskyPictureBox.Image")));
            this.huskyPictureBox.Location = new System.Drawing.Point(25, 52);
            this.huskyPictureBox.Name = "huskyPictureBox";
            this.huskyPictureBox.Size = new System.Drawing.Size(99, 95);
            this.huskyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.huskyPictureBox.TabIndex = 4;
            this.huskyPictureBox.TabStop = false;
            this.huskyPictureBox.Click += new System.EventHandler(this.huskyPictureBox_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hi fellow Husky, please click on me!";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(277, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 452);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Five Minute Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.huskyTab.ResumeLayout(false);
            this.huskyTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.huskyGradPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huskyPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage huskyTab;
        private System.Windows.Forms.PictureBox huskyGradPictureBox;
        private System.Windows.Forms.PictureBox huskyPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button stopHuskySong;

    }
}

