namespace EOB
{
    partial class AdminMainPage
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
            this.UsertabControl = new System.Windows.Forms.TabControl();
            this.Usertab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.FirsnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Createtab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createAccount = new System.Windows.Forms.Button();
            this.imageLabellabel2 = new System.Windows.Forms.Label();
            this.PictureLocation1 = new System.Windows.Forms.TextBox();
            this.selectPicture = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordconfirmetext = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.LogopictureBox = new System.Windows.Forms.PictureBox();
            this.PictureLocationLabel = new System.Windows.Forms.Label();
            this.PictureLocation = new System.Windows.Forms.TextBox();
            this.VerifyPasswordLabel = new System.Windows.Forms.Label();
            this.VerifyPasswordText = new System.Windows.Forms.TextBox();
            this.ProfilePictureBtn = new System.Windows.Forms.Button();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LastNametext = new System.Windows.Forms.TextBox();
            this.FirstNametext = new System.Windows.Forms.TextBox();
            this.Logoutbutton = new System.Windows.Forms.Button();
            this.Welkomlabel = new System.Windows.Forms.Label();
            this.AdminNameLabel = new System.Windows.Forms.Label();
            this.ProfilepictureBox = new System.Windows.Forms.PictureBox();
            this.UsertabControl.SuspendLayout();
            this.Usertab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Createtab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UsertabControl
            // 
            this.UsertabControl.Controls.Add(this.Usertab);
            this.UsertabControl.Controls.Add(this.Createtab);
            this.UsertabControl.Location = new System.Drawing.Point(1, 66);
            this.UsertabControl.Name = "UsertabControl";
            this.UsertabControl.SelectedIndex = 0;
            this.UsertabControl.Size = new System.Drawing.Size(1104, 392);
            this.UsertabControl.TabIndex = 0;
            // 
            // Usertab
            // 
            this.Usertab.Controls.Add(this.dataGridView1);
            this.Usertab.Location = new System.Drawing.Point(4, 25);
            this.Usertab.Name = "Usertab";
            this.Usertab.Padding = new System.Windows.Forms.Padding(3);
            this.Usertab.Size = new System.Drawing.Size(1096, 363);
            this.Usertab.TabIndex = 0;
            this.Usertab.Text = "User";
            this.Usertab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageColumn,
            this.FirsnameColumn,
            this.LastnameColumn,
            this.EmailColumn,
            this.DeleteColumn});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1093, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // ImageColumn
            // 
            this.ImageColumn.HeaderText = "profilepicture";
            this.ImageColumn.MinimumWidth = 6;
            this.ImageColumn.Name = "ImageColumn";
            this.ImageColumn.Width = 300;
            // 
            // FirsnameColumn
            // 
            this.FirsnameColumn.HeaderText = "Firstname";
            this.FirsnameColumn.MinimumWidth = 6;
            this.FirsnameColumn.Name = "FirsnameColumn";
            this.FirsnameColumn.Width = 125;
            // 
            // LastnameColumn
            // 
            this.LastnameColumn.HeaderText = "Lastname";
            this.LastnameColumn.MinimumWidth = 6;
            this.LastnameColumn.Name = "LastnameColumn";
            this.LastnameColumn.Width = 125;
            // 
            // EmailColumn
            // 
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.MinimumWidth = 6;
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.Width = 125;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.MinimumWidth = 6;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Width = 125;
            // 
            // Createtab
            // 
            this.Createtab.Controls.Add(this.panel1);
            this.Createtab.Location = new System.Drawing.Point(4, 25);
            this.Createtab.Name = "Createtab";
            this.Createtab.Padding = new System.Windows.Forms.Padding(3);
            this.Createtab.Size = new System.Drawing.Size(1096, 363);
            this.Createtab.TabIndex = 1;
            this.Createtab.Text = "Create";
            this.Createtab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.createAccount);
            this.panel1.Controls.Add(this.imageLabellabel2);
            this.panel1.Controls.Add(this.PictureLocation1);
            this.panel1.Controls.Add(this.selectPicture);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.passwordconfirmetext);
            this.panel1.Controls.Add(this.passwordtext);
            this.panel1.Controls.Add(this.emailtext);
            this.panel1.Controls.Add(this.LogopictureBox);
            this.panel1.Controls.Add(this.PictureLocationLabel);
            this.panel1.Controls.Add(this.PictureLocation);
            this.panel1.Controls.Add(this.VerifyPasswordLabel);
            this.panel1.Controls.Add(this.VerifyPasswordText);
            this.panel1.Controls.Add(this.ProfilePictureBtn);
            this.panel1.Controls.Add(this.CreateAccountButton);
            this.panel1.Controls.Add(this.LabelFirstName);
            this.panel1.Controls.Add(this.LabelPassword);
            this.panel1.Controls.Add(this.LabelEmail);
            this.panel1.Controls.Add(this.LabelLastName);
            this.panel1.Controls.Add(this.LastNametext);
            this.panel1.Controls.Add(this.FirstNametext);
            this.panel1.Location = new System.Drawing.Point(-4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 391);
            this.panel1.TabIndex = 0;
            // 
            // createAccount
            // 
            this.createAccount.Location = new System.Drawing.Point(905, 236);
            this.createAccount.Margin = new System.Windows.Forms.Padding(4);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(177, 38);
            this.createAccount.TabIndex = 37;
            this.createAccount.Text = "Create Account";
            this.createAccount.UseVisualStyleBackColor = true;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // imageLabellabel2
            // 
            this.imageLabellabel2.AutoSize = true;
            this.imageLabellabel2.Location = new System.Drawing.Point(643, 167);
            this.imageLabellabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageLabellabel2.Name = "imageLabellabel2";
            this.imageLabellabel2.Size = new System.Drawing.Size(98, 16);
            this.imageLabellabel2.TabIndex = 36;
            this.imageLabellabel2.Text = "Picture location";
            // 
            // PictureLocation1
            // 
            this.PictureLocation1.Location = new System.Drawing.Point(618, 187);
            this.PictureLocation1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureLocation1.Name = "PictureLocation1";
            this.PictureLocation1.Size = new System.Drawing.Size(272, 22);
            this.PictureLocation1.TabIndex = 35;
            // 
            // selectPicture
            // 
            this.selectPicture.Location = new System.Drawing.Point(683, 219);
            this.selectPicture.Margin = new System.Windows.Forms.Padding(4);
            this.selectPicture.Name = "selectPicture";
            this.selectPicture.Size = new System.Drawing.Size(131, 28);
            this.selectPicture.TabIndex = 34;
            this.selectPicture.Text = "Select picture";
            this.selectPicture.UseVisualStyleBackColor = true;
            this.selectPicture.Click += new System.EventHandler(this.SelectPicture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Confirm your password";
            // 
            // passwordconfirmetext
            // 
            this.passwordconfirmetext.Location = new System.Drawing.Point(619, 297);
            this.passwordconfirmetext.Margin = new System.Windows.Forms.Padding(4);
            this.passwordconfirmetext.Name = "passwordconfirmetext";
            this.passwordconfirmetext.Size = new System.Drawing.Size(224, 22);
            this.passwordconfirmetext.TabIndex = 32;
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(321, 297);
            this.passwordtext.Margin = new System.Windows.Forms.Padding(4);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(224, 22);
            this.passwordtext.TabIndex = 31;
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(22, 297);
            this.emailtext.Margin = new System.Windows.Forms.Padding(4);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(224, 22);
            this.emailtext.TabIndex = 30;
            // 
            // LogopictureBox
            // 
            this.LogopictureBox.Image = global::EOB.Properties.Resources.EOB_Logo;
            this.LogopictureBox.Location = new System.Drawing.Point(22, 4);
            this.LogopictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.LogopictureBox.Name = "LogopictureBox";
            this.LogopictureBox.Size = new System.Drawing.Size(133, 123);
            this.LogopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogopictureBox.TabIndex = 29;
            this.LogopictureBox.TabStop = false;
            // 
            // PictureLocationLabel
            // 
            this.PictureLocationLabel.AutoSize = true;
            this.PictureLocationLabel.Location = new System.Drawing.Point(390, 468);
            this.PictureLocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PictureLocationLabel.Name = "PictureLocationLabel";
            this.PictureLocationLabel.Size = new System.Drawing.Size(98, 16);
            this.PictureLocationLabel.TabIndex = 28;
            this.PictureLocationLabel.Text = "Picture location";
            // 
            // PictureLocation
            // 
            this.PictureLocation.Location = new System.Drawing.Point(365, 488);
            this.PictureLocation.Margin = new System.Windows.Forms.Padding(4);
            this.PictureLocation.Name = "PictureLocation";
            this.PictureLocation.Size = new System.Drawing.Size(272, 22);
            this.PictureLocation.TabIndex = 27;
            // 
            // VerifyPasswordLabel
            // 
            this.VerifyPasswordLabel.AutoSize = true;
            this.VerifyPasswordLabel.Location = new System.Drawing.Point(389, 401);
            this.VerifyPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VerifyPasswordLabel.Name = "VerifyPasswordLabel";
            this.VerifyPasswordLabel.Size = new System.Drawing.Size(143, 16);
            this.VerifyPasswordLabel.TabIndex = 26;
            this.VerifyPasswordLabel.Text = "Confirm your password";
            // 
            // VerifyPasswordText
            // 
            this.VerifyPasswordText.Location = new System.Drawing.Point(393, 420);
            this.VerifyPasswordText.Margin = new System.Windows.Forms.Padding(4);
            this.VerifyPasswordText.Name = "VerifyPasswordText";
            this.VerifyPasswordText.Size = new System.Drawing.Size(224, 22);
            this.VerifyPasswordText.TabIndex = 25;
            // 
            // ProfilePictureBtn
            // 
            this.ProfilePictureBtn.Location = new System.Drawing.Point(431, 520);
            this.ProfilePictureBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ProfilePictureBtn.Name = "ProfilePictureBtn";
            this.ProfilePictureBtn.Size = new System.Drawing.Size(131, 28);
            this.ProfilePictureBtn.TabIndex = 24;
            this.ProfilePictureBtn.Text = "Select picture";
            this.ProfilePictureBtn.UseVisualStyleBackColor = true;
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(410, 584);
            this.CreateAccountButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(177, 38);
            this.CreateAccountButton.TabIndex = 23;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(19, 167);
            this.LabelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(69, 16);
            this.LabelFirstName.TabIndex = 22;
            this.LabelFirstName.Text = "FirstName";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(318, 277);
            this.LabelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(67, 16);
            this.LabelPassword.TabIndex = 21;
            this.LabelPassword.Text = "Password";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(19, 277);
            this.LabelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(41, 16);
            this.LabelEmail.TabIndex = 20;
            this.LabelEmail.Text = "Email";
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(318, 167);
            this.LabelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(69, 16);
            this.LabelLastName.TabIndex = 19;
            this.LabelLastName.Text = "LastName";
            // 
            // LastNametext
            // 
            this.LastNametext.Location = new System.Drawing.Point(321, 187);
            this.LastNametext.Margin = new System.Windows.Forms.Padding(4);
            this.LastNametext.Name = "LastNametext";
            this.LastNametext.Size = new System.Drawing.Size(224, 22);
            this.LastNametext.TabIndex = 18;
            // 
            // FirstNametext
            // 
            this.FirstNametext.Location = new System.Drawing.Point(22, 187);
            this.FirstNametext.Margin = new System.Windows.Forms.Padding(4);
            this.FirstNametext.Name = "FirstNametext";
            this.FirstNametext.Size = new System.Drawing.Size(224, 22);
            this.FirstNametext.TabIndex = 17;
            // 
            // Logoutbutton
            // 
            this.Logoutbutton.Location = new System.Drawing.Point(998, 8);
            this.Logoutbutton.Name = "Logoutbutton";
            this.Logoutbutton.Size = new System.Drawing.Size(103, 29);
            this.Logoutbutton.TabIndex = 1;
            this.Logoutbutton.Text = "Log out";
            this.Logoutbutton.UseVisualStyleBackColor = true;
            this.Logoutbutton.Click += new System.EventHandler(this.Logoutbutton_Click);
            // 
            // Welkomlabel
            // 
            this.Welkomlabel.AutoSize = true;
            this.Welkomlabel.Location = new System.Drawing.Point(248, 47);
            this.Welkomlabel.Name = "Welkomlabel";
            this.Welkomlabel.Size = new System.Drawing.Size(100, 16);
            this.Welkomlabel.TabIndex = 3;
            this.Welkomlabel.Text = "Welkom admin:";
            // 
            // AdminNameLabel
            // 
            this.AdminNameLabel.AutoSize = true;
            this.AdminNameLabel.Location = new System.Drawing.Point(344, 47);
            this.AdminNameLabel.Name = "AdminNameLabel";
            this.AdminNameLabel.Size = new System.Drawing.Size(44, 16);
            this.AdminNameLabel.TabIndex = 4;
            this.AdminNameLabel.Text = "label1";
            // 
            // ProfilepictureBox
            // 
            this.ProfilepictureBox.Location = new System.Drawing.Point(5, 8);
            this.ProfilepictureBox.Name = "ProfilepictureBox";
            this.ProfilepictureBox.Size = new System.Drawing.Size(187, 52);
            this.ProfilepictureBox.TabIndex = 5;
            this.ProfilepictureBox.TabStop = false;
            // 
            // AdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1106, 638);
            this.Controls.Add(this.ProfilepictureBox);
            this.Controls.Add(this.AdminNameLabel);
            this.Controls.Add(this.Welkomlabel);
            this.Controls.Add(this.Logoutbutton);
            this.Controls.Add(this.UsertabControl);
            this.Name = "AdminMainPage";
            this.Text = "AdminMainPage";
            this.Load += new System.EventHandler(this.AdminMainPage_Load);
            this.UsertabControl.ResumeLayout(false);
            this.Usertab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Createtab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilepictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl UsertabControl;
        private System.Windows.Forms.TabPage Usertab;
        private System.Windows.Forms.TabPage Createtab;
        private System.Windows.Forms.Button Logoutbutton;
        private System.Windows.Forms.Label Welkomlabel;
        private System.Windows.Forms.Label AdminNameLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox ProfilepictureBox;
        private System.Windows.Forms.DataGridViewImageColumn ImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirsnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox LogopictureBox;
        private System.Windows.Forms.Label PictureLocationLabel;
        private System.Windows.Forms.TextBox PictureLocation;
        private System.Windows.Forms.Label VerifyPasswordLabel;
        private System.Windows.Forms.TextBox VerifyPasswordText;
        private System.Windows.Forms.Button ProfilePictureBtn;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.TextBox LastNametext;
        private System.Windows.Forms.TextBox FirstNametext;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordconfirmetext;
        private System.Windows.Forms.Label imageLabellabel2;
        private System.Windows.Forms.TextBox PictureLocation1;
        private System.Windows.Forms.Button selectPicture;
        private System.Windows.Forms.Button createAccount;
    }
}