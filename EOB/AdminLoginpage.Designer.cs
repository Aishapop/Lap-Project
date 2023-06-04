namespace EOB
{
    partial class AdminLoginpage
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
            this.components = new System.ComponentModel.Container();
            this.returnbutton = new System.Windows.Forms.Button();
            this.LogopictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Loginbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // returnbutton
            // 
            this.returnbutton.Location = new System.Drawing.Point(1, -1);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(108, 46);
            this.returnbutton.TabIndex = 0;
            this.returnbutton.Text = "Back";
            this.returnbutton.UseVisualStyleBackColor = true;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            // 
            // LogopictureBox1
            // 
            this.LogopictureBox1.Image = global::EOB.Properties.Resources.EOB_Logo;
            this.LogopictureBox1.Location = new System.Drawing.Point(181, 13);
            this.LogopictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.LogopictureBox1.Name = "LogopictureBox1";
            this.LogopictureBox1.Size = new System.Drawing.Size(193, 183);
            this.LogopictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogopictureBox1.TabIndex = 1;
            this.LogopictureBox1.TabStop = false;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(179, 257);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 16);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email";
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(169, 285);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(228, 22);
            this.EmailText.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(169, 362);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(228, 22);
            this.PasswordText.TabIndex = 6;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(179, 334);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(67, 16);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(220, 418);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(108, 29);
            this.Loginbutton.TabIndex = 7;
            this.Loginbutton.Text = "LOGIN";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // AdminLoginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(547, 507);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LogopictureBox1);
            this.Controls.Add(this.returnbutton);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "AdminLoginpage";
            this.Text = "Adminpage";
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnbutton;
        private System.Windows.Forms.PictureBox LogopictureBox1;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button Loginbutton;
    }
}