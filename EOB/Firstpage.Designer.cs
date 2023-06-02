using System.Windows.Forms;
using System;

namespace EOB
{
    partial class Firstpage
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
            this.wordKlantButton = new System.Windows.Forms.Button();
            this.aanmeldButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // wordKlantButton
            // 
            this.wordKlantButton.Location = new System.Drawing.Point(187, 248);
            this.wordKlantButton.Name = "wordKlantButton";
            this.wordKlantButton.Size = new System.Drawing.Size(200, 30);
            this.wordKlantButton.TabIndex = 0;
            this.wordKlantButton.Text = "Word Klant";
            this.wordKlantButton.UseVisualStyleBackColor = true;
            this.wordKlantButton.Click += new System.EventHandler(this.wordKlantButton_Click);
            // 
            // aanmeldButton
            // 
            this.aanmeldButton.Location = new System.Drawing.Point(187, 295);
            this.aanmeldButton.Name = "aanmeldButton";
            this.aanmeldButton.Size = new System.Drawing.Size(200, 30);
            this.aanmeldButton.TabIndex = 1;
            this.aanmeldButton.Text = "Aanmelden";
            this.aanmeldButton.UseVisualStyleBackColor = true;
            this.aanmeldButton.Click += new System.EventHandler(this.aanmeldButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(187, 344);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(200, 30);
            this.adminButton.TabIndex = 2;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EOB.Properties.Resources.EOB_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(187, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Firstpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(593, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.aanmeldButton);
            this.Controls.Add(this.wordKlantButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Firstpage";
            this.Text = "Firstpage";
            this.Load += new System.EventHandler(this.Firstpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wordKlantButton;
        private System.Windows.Forms.Button aanmeldButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}