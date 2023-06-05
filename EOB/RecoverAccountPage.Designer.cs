namespace EOB
{
    partial class RecoverAccountPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.RecoverAccountButton = new System.Windows.Forms.Button();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EOB.Properties.Resources.EOB_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(127, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(1, 1);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 37);
            this.ReturnButton.TabIndex = 5;
            this.ReturnButton.Text = "Back";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // RecoverAccountButton
            // 
            this.RecoverAccountButton.Location = new System.Drawing.Point(140, 290);
            this.RecoverAccountButton.Name = "RecoverAccountButton";
            this.RecoverAccountButton.Size = new System.Drawing.Size(120, 23);
            this.RecoverAccountButton.TabIndex = 6;
            this.RecoverAccountButton.Text = "Recover Account";
            this.RecoverAccountButton.UseVisualStyleBackColor = true;
            this.RecoverAccountButton.Click += new System.EventHandler(this.RecoverAccountButton_Click);
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(127, 234);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(150, 20);
            this.EmailText.TabIndex = 7;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(124, 215);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 16);
            this.EmailLabel.TabIndex = 8;
            this.EmailLabel.Text = "Email";
            // 
            // RecoverAccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(406, 421);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.RecoverAccountButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RecoverAccountPage";
            this.Text = "RecoverAccountPage";
            this.Load += new System.EventHandler(this.RecoverAccountPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button RecoverAccountButton;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label EmailLabel;
    }
}