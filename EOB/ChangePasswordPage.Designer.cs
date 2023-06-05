namespace EOB
{
    partial class ChangePasswordPage
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.OldPasswordText = new System.Windows.Forms.TextBox();
            this.NewPasswordText = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.VerifyNewPasswordText = new System.Windows.Forms.TextBox();
            this.VerifyNewPasswordLabel = new System.Windows.Forms.Label();
            this.ChangePasswordTitle = new System.Windows.Forms.Label();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(0, 0);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 37);
            this.ReturnButton.TabIndex = 3;
            this.ReturnButton.Text = "Back";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPasswordLabel.Location = new System.Drawing.Point(115, 91);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(90, 16);
            this.OldPasswordLabel.TabIndex = 4;
            this.OldPasswordLabel.Text = "Old password";
            // 
            // OldPasswordText
            // 
            this.OldPasswordText.Location = new System.Drawing.Point(118, 110);
            this.OldPasswordText.Name = "OldPasswordText";
            this.OldPasswordText.Size = new System.Drawing.Size(150, 20);
            this.OldPasswordText.TabIndex = 5;
            // 
            // NewPasswordText
            // 
            this.NewPasswordText.Location = new System.Drawing.Point(118, 152);
            this.NewPasswordText.Name = "NewPasswordText";
            this.NewPasswordText.Size = new System.Drawing.Size(150, 20);
            this.NewPasswordText.TabIndex = 7;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordLabel.Location = new System.Drawing.Point(115, 133);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(96, 16);
            this.NewPasswordLabel.TabIndex = 6;
            this.NewPasswordLabel.Text = "New password";
            // 
            // VerifyNewPasswordText
            // 
            this.VerifyNewPasswordText.Location = new System.Drawing.Point(118, 194);
            this.VerifyNewPasswordText.Name = "VerifyNewPasswordText";
            this.VerifyNewPasswordText.Size = new System.Drawing.Size(150, 20);
            this.VerifyNewPasswordText.TabIndex = 9;
            // 
            // VerifyNewPasswordLabel
            // 
            this.VerifyNewPasswordLabel.AutoSize = true;
            this.VerifyNewPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyNewPasswordLabel.Location = new System.Drawing.Point(115, 175);
            this.VerifyNewPasswordLabel.Name = "VerifyNewPasswordLabel";
            this.VerifyNewPasswordLabel.Size = new System.Drawing.Size(130, 16);
            this.VerifyNewPasswordLabel.TabIndex = 8;
            this.VerifyNewPasswordLabel.Text = "Verify new password";
            // 
            // ChangePasswordTitle
            // 
            this.ChangePasswordTitle.AutoSize = true;
            this.ChangePasswordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordTitle.Location = new System.Drawing.Point(90, 19);
            this.ChangePasswordTitle.Name = "ChangePasswordTitle";
            this.ChangePasswordTitle.Size = new System.Drawing.Size(233, 31);
            this.ChangePasswordTitle.TabIndex = 10;
            this.ChangePasswordTitle.Text = "Change password";
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(135, 238);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(100, 23);
            this.ChangePasswordButton.TabIndex = 11;
            this.ChangePasswordButton.Text = "Change";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ChangePasswordPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(397, 330);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.ChangePasswordTitle);
            this.Controls.Add(this.VerifyNewPasswordText);
            this.Controls.Add(this.VerifyNewPasswordLabel);
            this.Controls.Add(this.NewPasswordText);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.OldPasswordText);
            this.Controls.Add(this.OldPasswordLabel);
            this.Controls.Add(this.ReturnButton);
            this.Name = "ChangePasswordPage";
            this.Text = "ChangePasswordPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.TextBox OldPasswordText;
        private System.Windows.Forms.TextBox NewPasswordText;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.TextBox VerifyNewPasswordText;
        private System.Windows.Forms.Label VerifyNewPasswordLabel;
        private System.Windows.Forms.Label ChangePasswordTitle;
        private System.Windows.Forms.Button ChangePasswordButton;
    }
}