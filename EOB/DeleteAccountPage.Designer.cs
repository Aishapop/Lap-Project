namespace EOB
{
    partial class DeleteAccountPage
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
            this.DeleteAccountLabel = new System.Windows.Forms.Label();
            this.NoButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.TextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(1, 1);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 37);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "Back";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // DeleteAccountLabel
            // 
            this.DeleteAccountLabel.AutoSize = true;
            this.DeleteAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAccountLabel.Location = new System.Drawing.Point(133, 29);
            this.DeleteAccountLabel.Name = "DeleteAccountLabel";
            this.DeleteAccountLabel.Size = new System.Drawing.Size(199, 31);
            this.DeleteAccountLabel.TabIndex = 3;
            this.DeleteAccountLabel.Text = "Delete Account";
            // 
            // NoButton
            // 
            this.NoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoButton.Location = new System.Drawing.Point(172, 200);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(100, 30);
            this.NoButton.TabIndex = 4;
            this.NoButton.Text = "NO";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesButton.Location = new System.Drawing.Point(172, 139);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(100, 30);
            this.YesButton.TabIndex = 5;
            this.YesButton.Text = "YES";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLabel.Location = new System.Drawing.Point(63, 85);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(335, 20);
            this.TextLabel.TabIndex = 6;
            this.TextLabel.Text = "Are you sure you want to delete your account?";
            // 
            // DeleteAccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(446, 317);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.DeleteAccountLabel);
            this.Controls.Add(this.ReturnButton);
            this.Name = "DeleteAccountPage";
            this.Text = "DeleteAccountPage";
            this.Load += new System.EventHandler(this.DeleteAccountPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label DeleteAccountLabel;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Label TextLabel;
    }
}