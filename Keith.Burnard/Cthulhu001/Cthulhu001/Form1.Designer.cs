namespace Cthulhu001
{
    partial class frmWWCD
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
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.gbQuestion = new System.Windows.Forms.GroupBox();
            this.btnAsk = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbAnaswer = new System.Windows.Forms.GroupBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.gbQuestion.SuspendLayout();
            this.gbAnaswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(28, 38);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(585, 176);
            this.tbQuestion.TabIndex = 0;
            // 
            // gbQuestion
            // 
            this.gbQuestion.Controls.Add(this.btnExit);
            this.gbQuestion.Controls.Add(this.btnClear);
            this.gbQuestion.Controls.Add(this.btnAsk);
            this.gbQuestion.Controls.Add(this.tbQuestion);
            this.gbQuestion.Location = new System.Drawing.Point(101, 42);
            this.gbQuestion.Name = "gbQuestion";
            this.gbQuestion.Size = new System.Drawing.Size(642, 328);
            this.gbQuestion.TabIndex = 2;
            this.gbQuestion.TabStop = false;
            this.gbQuestion.Text = "Describe the situation so that Cthulhu may advise you.";
            // 
            // btnAsk
            // 
            this.btnAsk.Location = new System.Drawing.Point(144, 256);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(75, 23);
            this.btnAsk.TabIndex = 1;
            this.btnAsk.Text = "Ask";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(287, 257);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(434, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbAnaswer
            // 
            this.gbAnaswer.Controls.Add(this.lblAnswer);
            this.gbAnaswer.Location = new System.Drawing.Point(101, 410);
            this.gbAnaswer.Name = "gbAnaswer";
            this.gbAnaswer.Size = new System.Drawing.Size(642, 116);
            this.gbAnaswer.TabIndex = 3;
            this.gbAnaswer.TabStop = false;
            this.gbAnaswer.Text = "Cthulhu would...";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(28, 52);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 17);
            this.lblAnswer.TabIndex = 0;
            // 
            // frmWWCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 587);
            this.Controls.Add(this.gbAnaswer);
            this.Controls.Add(this.gbQuestion);
            this.Name = "frmWWCD";
            this.Text = "What would Cthulhu do?";
            this.gbQuestion.ResumeLayout(false);
            this.gbQuestion.PerformLayout();
            this.gbAnaswer.ResumeLayout(false);
            this.gbAnaswer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.GroupBox gbQuestion;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.GroupBox gbAnaswer;
        private System.Windows.Forms.Label lblAnswer;
    }
}

