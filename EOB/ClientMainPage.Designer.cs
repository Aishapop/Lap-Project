namespace EOB
{
    partial class ClientMainPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.OverschrijvingenDropDown = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.automatischeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZichtrekeningenLabel = new System.Windows.Forms.Label();
            this.SpaarrekeningenLabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.BalanceOfZichtrekeningLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.OverschrijvingenDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.OverschrijvingenDropDown);
            this.panel1.Controls.Add(this.ProfilePicture);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 101);
            this.panel1.TabIndex = 0;
            // 
            // OverschrijvingenDropDown
            // 
            this.OverschrijvingenDropDown.Dock = System.Windows.Forms.DockStyle.None;
            this.OverschrijvingenDropDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripLabel1});
            this.OverschrijvingenDropDown.Location = new System.Drawing.Point(135, 12);
            this.OverschrijvingenDropDown.Name = "OverschrijvingenDropDown";
            this.OverschrijvingenDropDown.Size = new System.Drawing.Size(137, 25);
            this.OverschrijvingenDropDown.TabIndex = 4;
            this.OverschrijvingenDropDown.Text = "Overschrijvingen";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(96, 22);
            this.toolStripLabel1.Text = "Overschrijvingen";
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Location = new System.Drawing.Point(713, 12);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(75, 75);
            this.ProfilePicture.TabIndex = 1;
            this.ProfilePicture.TabStop = false;
            this.ProfilePicture.Click += new System.EventHandler(this.ProfilePicture_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::EOB.Properties.Resources.EOB_Logo;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(100, 100);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automatischeToolStripMenuItem,
            this.normaleToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::EOB.Properties.Resources.EOB_Logo;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // automatischeToolStripMenuItem
            // 
            this.automatischeToolStripMenuItem.Name = "automatischeToolStripMenuItem";
            this.automatischeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.automatischeToolStripMenuItem.Text = "Automatische";
            // 
            // normaleToolStripMenuItem
            // 
            this.normaleToolStripMenuItem.Name = "normaleToolStripMenuItem";
            this.normaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.normaleToolStripMenuItem.Text = "Normale";
            // 
            // ZichtrekeningenLabel
            // 
            this.ZichtrekeningenLabel.AutoSize = true;
            this.ZichtrekeningenLabel.Location = new System.Drawing.Point(43, 141);
            this.ZichtrekeningenLabel.Name = "ZichtrekeningenLabel";
            this.ZichtrekeningenLabel.Size = new System.Drawing.Size(110, 13);
            this.ZichtrekeningenLabel.TabIndex = 1;
            this.ZichtrekeningenLabel.Text = "ZICHTREKENINGEN";
            // 
            // SpaarrekeningenLabel
            // 
            this.SpaarrekeningenLabel.AutoSize = true;
            this.SpaarrekeningenLabel.Location = new System.Drawing.Point(281, 140);
            this.SpaarrekeningenLabel.Name = "SpaarrekeningenLabel";
            this.SpaarrekeningenLabel.Size = new System.Drawing.Size(114, 13);
            this.SpaarrekeningenLabel.TabIndex = 2;
            this.SpaarrekeningenLabel.Text = "SPAARREKENINGEN";
            this.SpaarrekeningenLabel.Click += new System.EventHandler(this.Spaarrekeningen_Click);
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(46, 196);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(46, 13);
            this.BalanceLabel.TabIndex = 3;
            this.BalanceLabel.Text = "Balance";
            // 
            // BalanceOfZichtrekeningLabel
            // 
            this.BalanceOfZichtrekeningLabel.AutoSize = true;
            this.BalanceOfZichtrekeningLabel.Location = new System.Drawing.Point(46, 213);
            this.BalanceOfZichtrekeningLabel.Name = "BalanceOfZichtrekeningLabel";
            this.BalanceOfZichtrekeningLabel.Size = new System.Drawing.Size(35, 13);
            this.BalanceOfZichtrekeningLabel.TabIndex = 4;
            this.BalanceOfZichtrekeningLabel.Text = "label1";
            this.BalanceOfZichtrekeningLabel.Click += new System.EventHandler(this.BalanceOfZichtrekeningLabel_Click);
            // 
            // ClientMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BalanceOfZichtrekeningLabel);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.SpaarrekeningenLabel);
            this.Controls.Add(this.ZichtrekeningenLabel);
            this.Controls.Add(this.panel1);
            this.Name = "ClientMainPage";
            this.Text = "ClientMainPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.OverschrijvingenDropDown.ResumeLayout(false);
            this.OverschrijvingenDropDown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.ToolStrip OverschrijvingenDropDown;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem automatischeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normaleToolStripMenuItem;
        private System.Windows.Forms.Label ZichtrekeningenLabel;
        private System.Windows.Forms.Label SpaarrekeningenLabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label BalanceOfZichtrekeningLabel;
    }
}