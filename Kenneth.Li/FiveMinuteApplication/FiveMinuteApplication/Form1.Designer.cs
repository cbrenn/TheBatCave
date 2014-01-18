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
            this.playHuskySong = new System.Windows.Forms.Button();
            this.stopHuskySong = new System.Windows.Forms.Button();
            this.huskyPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cougTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cougPictureBox = new System.Windows.Forms.PictureBox();
            this.cougFailPictureBox = new System.Windows.Forms.PictureBox();
            this.huskyMascotPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.huskyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.huskyPictureBox)).BeginInit();
            this.cougTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cougPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cougFailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huskyMascotPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.huskyTab);
            this.tabControl1.Controls.Add(this.cougTab);
            this.tabControl1.Location = new System.Drawing.Point(16, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(359, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // huskyTab
            // 
            this.huskyTab.Controls.Add(this.huskyMascotPictureBox);
            this.huskyTab.Controls.Add(this.playHuskySong);
            this.huskyTab.Controls.Add(this.stopHuskySong);
            this.huskyTab.Controls.Add(this.huskyPictureBox);
            this.huskyTab.Controls.Add(this.label1);
            this.huskyTab.Location = new System.Drawing.Point(4, 22);
            this.huskyTab.Name = "huskyTab";
            this.huskyTab.Padding = new System.Windows.Forms.Padding(3);
            this.huskyTab.Size = new System.Drawing.Size(351, 366);
            this.huskyTab.TabIndex = 0;
            this.huskyTab.Text = "Click here if you\'re a Husky";
            this.huskyTab.UseVisualStyleBackColor = true;
            // 
            // playHuskySong
            // 
            this.playHuskySong.Location = new System.Drawing.Point(73, 304);
            this.playHuskySong.Name = "playHuskySong";
            this.playHuskySong.Size = new System.Drawing.Size(75, 40);
            this.playHuskySong.TabIndex = 7;
            this.playHuskySong.Text = "Play Song Snippet Again";
            this.playHuskySong.UseVisualStyleBackColor = true;
            this.playHuskySong.Click += new System.EventHandler(this.playHuskySong_Click);
            // 
            // stopHuskySong
            // 
            this.stopHuskySong.Location = new System.Drawing.Point(180, 304);
            this.stopHuskySong.Name = "stopHuskySong";
            this.stopHuskySong.Size = new System.Drawing.Size(75, 40);
            this.stopHuskySong.TabIndex = 6;
            this.stopHuskySong.Text = "Stop Playing Song";
            this.stopHuskySong.UseVisualStyleBackColor = true;
            this.stopHuskySong.Click += new System.EventHandler(this.stopHuskySong_Click);
            // 
            // huskyPictureBox
            // 
            this.huskyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("huskyPictureBox.Image")));
            this.huskyPictureBox.Location = new System.Drawing.Point(113, 110);
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
            this.label1.Location = new System.Drawing.Point(70, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hi fellow Husky, please click on the logo!";
            // 
            // cougTab
            // 
            this.cougTab.Controls.Add(this.cougFailPictureBox);
            this.cougTab.Controls.Add(this.cougPictureBox);
            this.cougTab.Controls.Add(this.label2);
            this.cougTab.Location = new System.Drawing.Point(4, 22);
            this.cougTab.Name = "cougTab";
            this.cougTab.Padding = new System.Windows.Forms.Padding(3);
            this.cougTab.Size = new System.Drawing.Size(351, 366);
            this.cougTab.TabIndex = 1;
            this.cougTab.Text = "Click here if you\'re a Coug";
            this.cougTab.UseVisualStyleBackColor = true;
            this.cougTab.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Sigh* Click on the Coug picture";
            // 
            // cougPictureBox
            // 
            this.cougPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cougPictureBox.Image")));
            this.cougPictureBox.Location = new System.Drawing.Point(102, 88);
            this.cougPictureBox.Name = "cougPictureBox";
            this.cougPictureBox.Size = new System.Drawing.Size(154, 125);
            this.cougPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cougPictureBox.TabIndex = 2;
            this.cougPictureBox.TabStop = false;
            this.cougPictureBox.Click += new System.EventHandler(this.cougPictureBox_Click);
            // 
            // cougFailPictureBox
            // 
            this.cougFailPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cougFailPictureBox.Image")));
            this.cougFailPictureBox.Location = new System.Drawing.Point(9, 36);
            this.cougFailPictureBox.Name = "cougFailPictureBox";
            this.cougFailPictureBox.Size = new System.Drawing.Size(339, 312);
            this.cougFailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cougFailPictureBox.TabIndex = 3;
            this.cougFailPictureBox.TabStop = false;
            // 
            // huskyMascotPictureBox
            // 
            this.huskyMascotPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("huskyMascotPictureBox.Image")));
            this.huskyMascotPictureBox.Location = new System.Drawing.Point(75, 82);
            this.huskyMascotPictureBox.Name = "huskyMascotPictureBox";
            this.huskyMascotPictureBox.Size = new System.Drawing.Size(202, 196);
            this.huskyMascotPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.huskyMascotPictureBox.TabIndex = 8;
            this.huskyMascotPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 415);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Five Minute Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.huskyTab.ResumeLayout(false);
            this.huskyTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.huskyPictureBox)).EndInit();
            this.cougTab.ResumeLayout(false);
            this.cougTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cougPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cougFailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huskyMascotPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage huskyTab;
        private System.Windows.Forms.PictureBox huskyPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage cougTab;
        private System.Windows.Forms.Button stopHuskySong;
        private System.Windows.Forms.Button playHuskySong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox cougPictureBox;
        private System.Windows.Forms.PictureBox cougFailPictureBox;
        private System.Windows.Forms.PictureBox huskyMascotPictureBox;

    }
}

