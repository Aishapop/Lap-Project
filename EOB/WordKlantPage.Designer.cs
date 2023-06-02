namespace EOB
{
    partial class WordKlantPage
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
            this.returnButton = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.ProfilePictureBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.VerifyPasswordText = new System.Windows.Forms.TextBox();
            this.VerifyPasswordLabel = new System.Windows.Forms.Label();
            this.PictureLocation = new System.Windows.Forms.TextBox();
            this.PictureLocationLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(-1, -1);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 37);
            this.returnButton.TabIndex = 0;
            this.returnButton.Text = "Back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(162, 151);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(169, 20);
            this.FirstName.TabIndex = 1;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged_2);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(162, 194);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(169, 20);
            this.LastName.TabIndex = 2;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(161, 243);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(169, 20);
            this.Email.TabIndex = 3;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(161, 291);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(169, 20);
            this.Password.TabIndex = 4;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(159, 178);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(55, 13);
            this.LabelLastName.TabIndex = 6;
            this.LabelLastName.Text = "LastName";
            this.LabelLastName.Click += new System.EventHandler(this.LabelLastName_Click);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(159, 227);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(32, 13);
            this.LabelEmail.TabIndex = 7;
            this.LabelEmail.Text = "Email";
            this.LabelEmail.Click += new System.EventHandler(this.LabelEmail_Click);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(158, 275);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(53, 13);
            this.LabelPassword.TabIndex = 8;
            this.LabelPassword.Text = "Password";
            this.LabelPassword.Click += new System.EventHandler(this.LabelPassword_Click);
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(159, 135);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(54, 13);
            this.LabelFirstName.TabIndex = 9;
            this.LabelFirstName.Text = "FirstName";
            this.LabelFirstName.Click += new System.EventHandler(this.LabelFirstName_Click);
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(174, 472);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(133, 31);
            this.CreateAccountButton.TabIndex = 10;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // ProfilePictureBtn
            // 
            this.ProfilePictureBtn.Location = new System.Drawing.Point(190, 420);
            this.ProfilePictureBtn.Name = "ProfilePictureBtn";
            this.ProfilePictureBtn.Size = new System.Drawing.Size(98, 23);
            this.ProfilePictureBtn.TabIndex = 11;
            this.ProfilePictureBtn.Text = "Select picture";
            this.ProfilePictureBtn.UseVisualStyleBackColor = true;
            this.ProfilePictureBtn.Click += new System.EventHandler(this.ProfilePictureBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // VerifyPasswordText
            // 
            this.VerifyPasswordText.Location = new System.Drawing.Point(161, 339);
            this.VerifyPasswordText.Name = "VerifyPasswordText";
            this.VerifyPasswordText.Size = new System.Drawing.Size(169, 20);
            this.VerifyPasswordText.TabIndex = 12;
            // 
            // VerifyPasswordLabel
            // 
            this.VerifyPasswordLabel.AutoSize = true;
            this.VerifyPasswordLabel.Location = new System.Drawing.Point(158, 323);
            this.VerifyPasswordLabel.Name = "VerifyPasswordLabel";
            this.VerifyPasswordLabel.Size = new System.Drawing.Size(113, 13);
            this.VerifyPasswordLabel.TabIndex = 13;
            this.VerifyPasswordLabel.Text = "Confirm your password";
            // 
            // PictureLocation
            // 
            this.PictureLocation.Location = new System.Drawing.Point(140, 394);
            this.PictureLocation.Name = "PictureLocation";
            this.PictureLocation.Size = new System.Drawing.Size(205, 20);
            this.PictureLocation.TabIndex = 14;
            this.PictureLocation.TextChanged += new System.EventHandler(this.PictureLocation_TextChanged);
            // 
            // PictureLocationLabel
            // 
            this.PictureLocationLabel.AutoSize = true;
            this.PictureLocationLabel.Location = new System.Drawing.Point(159, 378);
            this.PictureLocationLabel.Name = "PictureLocationLabel";
            this.PictureLocationLabel.Size = new System.Drawing.Size(80, 13);
            this.PictureLocationLabel.TabIndex = 15;
            this.PictureLocationLabel.Text = "Picture location";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EOB.Properties.Resources.EOB_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(190, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // WordKlantPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(499, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PictureLocationLabel);
            this.Controls.Add(this.PictureLocation);
            this.Controls.Add(this.VerifyPasswordLabel);
            this.Controls.Add(this.VerifyPasswordText);
            this.Controls.Add(this.ProfilePictureBtn);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.returnButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "WordKlantPage";
            this.Text = "WordKlantPage";
            this.Load += new System.EventHandler(this.WordKlantPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.Button ProfilePictureBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox VerifyPasswordText;
        private System.Windows.Forms.Label VerifyPasswordLabel;
        private System.Windows.Forms.TextBox PictureLocation;
        private System.Windows.Forms.Label PictureLocationLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}