namespace HintCreditSystem
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
            this.hintButton = new System.Windows.Forms.Button();
            this.hint1 = new System.Windows.Forms.Button();
            this.hint5 = new System.Windows.Forms.Button();
            this.nxtButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.hintLabel = new System.Windows.Forms.Label();
            this.creditLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctrBox = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBox)).BeginInit();
            this.SuspendLayout();
            // 
            // hintButton
            // 
            this.hintButton.Location = new System.Drawing.Point(191, 31);
            this.hintButton.Name = "hintButton";
            this.hintButton.Size = new System.Drawing.Size(75, 59);
            this.hintButton.TabIndex = 0;
            this.hintButton.Text = "Hint";
            this.hintButton.UseVisualStyleBackColor = true;
            this.hintButton.Click += new System.EventHandler(this.hintButton_Click);
            // 
            // hint1
            // 
            this.hint1.Location = new System.Drawing.Point(36, 31);
            this.hint1.Name = "hint1";
            this.hint1.Size = new System.Drawing.Size(75, 59);
            this.hint1.TabIndex = 1;
            this.hint1.Text = "1 Hint ";
            this.hint1.UseVisualStyleBackColor = true;
            this.hint1.Click += new System.EventHandler(this.hint1_Click);
            // 
            // hint5
            // 
            this.hint5.Location = new System.Drawing.Point(36, 105);
            this.hint5.Name = "hint5";
            this.hint5.Size = new System.Drawing.Size(75, 57);
            this.hint5.TabIndex = 2;
            this.hint5.Text = "5 Hints";
            this.hint5.UseVisualStyleBackColor = true;
            this.hint5.Click += new System.EventHandler(this.hint5_Click);
            // 
            // nxtButton
            // 
            this.nxtButton.Location = new System.Drawing.Point(203, 433);
            this.nxtButton.Name = "nxtButton";
            this.nxtButton.Size = new System.Drawing.Size(75, 23);
            this.nxtButton.TabIndex = 3;
            this.nxtButton.Text = "Next Round";
            this.nxtButton.UseVisualStyleBackColor = true;
            this.nxtButton.Click += new System.EventHandler(this.nxtButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(109, 222);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(203, 105);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(29, 13);
            this.hintLabel.TabIndex = 5;
            this.hintLabel.Text = "Hint:";
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Location = new System.Drawing.Point(203, 127);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(37, 13);
            this.creditLabel.TabIndex = 6;
            this.creditLabel.Text = "Credit:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HintCreditSystem.Properties.Resources.EAGLE;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(47, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 104);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pctrBox
            // 
            this.pctrBox.BackgroundImage = global::HintCreditSystem.Properties.Resources.EAGLE_H;
            this.pctrBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctrBox.Location = new System.Drawing.Point(47, 265);
            this.pctrBox.Name = "pctrBox";
            this.pctrBox.Size = new System.Drawing.Size(185, 104);
            this.pctrBox.TabIndex = 8;
            this.pctrBox.TabStop = false;
            this.pctrBox.Visible = false;
            this.pctrBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 488);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pctrBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.nxtButton);
            this.Controls.Add(this.hint5);
            this.Controls.Add(this.hint1);
            this.Controls.Add(this.hintButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hintButton;
        private System.Windows.Forms.Button hint1;
        private System.Windows.Forms.Button hint5;
        private System.Windows.Forms.Button nxtButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctrBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

