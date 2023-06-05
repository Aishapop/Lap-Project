namespace EOB
{
    partial class ProfilePicturePage
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
            this.PictureLocationLabel = new System.Windows.Forms.Label();
            this.PictureLocation = new System.Windows.Forms.TextBox();
            this.ProfilePictureBtn = new System.Windows.Forms.Button();
            this.ChangeProfilePicButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PictureLocationLabel
            // 
            this.PictureLocationLabel.AutoSize = true;
            this.PictureLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureLocationLabel.Location = new System.Drawing.Point(110, 94);
            this.PictureLocationLabel.Name = "PictureLocationLabel";
            this.PictureLocationLabel.Size = new System.Drawing.Size(98, 16);
            this.PictureLocationLabel.TabIndex = 18;
            this.PictureLocationLabel.Text = "Picture location";
            // 
            // PictureLocation
            // 
            this.PictureLocation.Location = new System.Drawing.Point(113, 113);
            this.PictureLocation.Name = "PictureLocation";
            this.PictureLocation.Size = new System.Drawing.Size(205, 20);
            this.PictureLocation.TabIndex = 17;
            this.PictureLocation.TextChanged += new System.EventHandler(this.PictureLocation_TextChanged);
            // 
            // ProfilePictureBtn
            // 
            this.ProfilePictureBtn.Location = new System.Drawing.Point(163, 139);
            this.ProfilePictureBtn.Name = "ProfilePictureBtn";
            this.ProfilePictureBtn.Size = new System.Drawing.Size(98, 23);
            this.ProfilePictureBtn.TabIndex = 16;
            this.ProfilePictureBtn.Text = "Select picture";
            this.ProfilePictureBtn.UseVisualStyleBackColor = true;
            this.ProfilePictureBtn.Click += new System.EventHandler(this.ProfilePictureBtn_Click);
            // 
            // ChangeProfilePicButton
            // 
            this.ChangeProfilePicButton.Location = new System.Drawing.Point(124, 192);
            this.ChangeProfilePicButton.Name = "ChangeProfilePicButton";
            this.ChangeProfilePicButton.Size = new System.Drawing.Size(176, 23);
            this.ChangeProfilePicButton.TabIndex = 19;
            this.ChangeProfilePicButton.Text = "Change profile picture";
            this.ChangeProfilePicButton.UseVisualStyleBackColor = true;
            this.ChangeProfilePicButton.Click += new System.EventHandler(this.ChangeProfilePicButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(0, 0);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 37);
            this.ReturnButton.TabIndex = 20;
            this.ReturnButton.Text = "Back";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // ProfilePicturePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(397, 296);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.ChangeProfilePicButton);
            this.Controls.Add(this.PictureLocationLabel);
            this.Controls.Add(this.PictureLocation);
            this.Controls.Add(this.ProfilePictureBtn);
            this.Name = "ProfilePicturePage";
            this.Text = "ProfilePicturePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PictureLocationLabel;
        private System.Windows.Forms.TextBox PictureLocation;
        private System.Windows.Forms.Button ProfilePictureBtn;
        private System.Windows.Forms.Button ChangeProfilePicButton;
        private System.Windows.Forms.Button ReturnButton;
    }
}