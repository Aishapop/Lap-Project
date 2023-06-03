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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DepositButton = new System.Windows.Forms.Button();
            this.OverschrijvingenDropdownMenu = new System.Windows.Forms.Button();
            this.DropDownMenuOfOverschrijvingen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.automatischToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normaalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfilePicturePictureBox = new System.Windows.Forms.PictureBox();
            this.DropDownMenuOfPfp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.ZichtrekeningenLabel = new System.Windows.Forms.Label();
            this.SpaarrekeningenLabel = new System.Windows.Forms.Label();
            this.ZichtrekeningHistoryButton = new System.Windows.Forms.Button();
            this.SpaarrekeningHistoryButton = new System.Windows.Forms.Button();
            this.ZichtrekeningBalancesListView = new System.Windows.Forms.ListView();
            this.ZichtrekeningNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BalanceZichtrekening = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpaarrekeningBalancesListView = new System.Windows.Forms.ListView();
            this.SpaarrekeningNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BalanceSpaarrekening = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.DropDownMenuOfOverschrijvingen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicturePictureBox)).BeginInit();
            this.DropDownMenuOfPfp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.DepositButton);
            this.panel1.Controls.Add(this.OverschrijvingenDropdownMenu);
            this.panel1.Controls.Add(this.ProfilePicturePictureBox);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 101);
            this.panel1.TabIndex = 0;
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(294, 12);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(120, 25);
            this.DepositButton.TabIndex = 3;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // OverschrijvingenDropdownMenu
            // 
            this.OverschrijvingenDropdownMenu.ContextMenuStrip = this.DropDownMenuOfOverschrijvingen;
            this.OverschrijvingenDropdownMenu.Location = new System.Drawing.Point(140, 12);
            this.OverschrijvingenDropdownMenu.Name = "OverschrijvingenDropdownMenu";
            this.OverschrijvingenDropdownMenu.Size = new System.Drawing.Size(120, 25);
            this.OverschrijvingenDropdownMenu.TabIndex = 2;
            this.OverschrijvingenDropdownMenu.Text = "Overschrijvingen";
            this.OverschrijvingenDropdownMenu.UseVisualStyleBackColor = true;
            this.OverschrijvingenDropdownMenu.Click += new System.EventHandler(this.OverschrijvingenDropdownMenu_Click);
            // 
            // DropDownMenuOfOverschrijvingen
            // 
            this.DropDownMenuOfOverschrijvingen.BackColor = System.Drawing.Color.SlateGray;
            this.DropDownMenuOfOverschrijvingen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automatischToolStripMenuItem,
            this.normaalToolStripMenuItem});
            this.DropDownMenuOfOverschrijvingen.Name = "DropDownMenuOfOverschrijvingen";
            this.DropDownMenuOfOverschrijvingen.Size = new System.Drawing.Size(143, 48);
            // 
            // automatischToolStripMenuItem
            // 
            this.automatischToolStripMenuItem.Name = "automatischToolStripMenuItem";
            this.automatischToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.automatischToolStripMenuItem.Text = "Automatisch";
            this.automatischToolStripMenuItem.Click += new System.EventHandler(this.automatischToolStripMenuItem_Click);
            // 
            // normaalToolStripMenuItem
            // 
            this.normaalToolStripMenuItem.Name = "normaalToolStripMenuItem";
            this.normaalToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.normaalToolStripMenuItem.Text = "Normaal";
            // 
            // ProfilePicturePictureBox
            // 
            this.ProfilePicturePictureBox.ContextMenuStrip = this.DropDownMenuOfPfp;
            this.ProfilePicturePictureBox.Location = new System.Drawing.Point(459, 12);
            this.ProfilePicturePictureBox.Name = "ProfilePicturePictureBox";
            this.ProfilePicturePictureBox.Size = new System.Drawing.Size(75, 75);
            this.ProfilePicturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicturePictureBox.TabIndex = 1;
            this.ProfilePicturePictureBox.TabStop = false;
            this.ProfilePicturePictureBox.Click += new System.EventHandler(this.ProfilePicturePictureBox_Click);
            // 
            // DropDownMenuOfPfp
            // 
            this.DropDownMenuOfPfp.BackColor = System.Drawing.Color.SlateGray;
            this.DropDownMenuOfPfp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.DropDownMenuOfPfp.Name = "DropDownMenuOfPfp";
            this.DropDownMenuOfPfp.Size = new System.Drawing.Size(125, 70);
            // 
            // passwordToolStripMenuItem
            // 
            this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            this.passwordToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.passwordToolStripMenuItem.Text = "Password";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
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
            // ZichtrekeningenLabel
            // 
            this.ZichtrekeningenLabel.AutoSize = true;
            this.ZichtrekeningenLabel.Location = new System.Drawing.Point(70, 156);
            this.ZichtrekeningenLabel.Name = "ZichtrekeningenLabel";
            this.ZichtrekeningenLabel.Size = new System.Drawing.Size(110, 13);
            this.ZichtrekeningenLabel.TabIndex = 1;
            this.ZichtrekeningenLabel.Text = "ZICHTREKENINGEN";
            this.ZichtrekeningenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpaarrekeningenLabel
            // 
            this.SpaarrekeningenLabel.AutoSize = true;
            this.SpaarrekeningenLabel.Location = new System.Drawing.Point(367, 156);
            this.SpaarrekeningenLabel.Name = "SpaarrekeningenLabel";
            this.SpaarrekeningenLabel.Size = new System.Drawing.Size(114, 13);
            this.SpaarrekeningenLabel.TabIndex = 2;
            this.SpaarrekeningenLabel.Text = "SPAARREKENINGEN";
            this.SpaarrekeningenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SpaarrekeningenLabel.Click += new System.EventHandler(this.Spaarrekeningen_Click);
            // 
            // ZichtrekeningHistoryButton
            // 
            this.ZichtrekeningHistoryButton.Location = new System.Drawing.Point(73, 172);
            this.ZichtrekeningHistoryButton.Name = "ZichtrekeningHistoryButton";
            this.ZichtrekeningHistoryButton.Size = new System.Drawing.Size(105, 25);
            this.ZichtrekeningHistoryButton.TabIndex = 5;
            this.ZichtrekeningHistoryButton.Text = "HISTORY";
            this.ZichtrekeningHistoryButton.UseVisualStyleBackColor = true;
            this.ZichtrekeningHistoryButton.Click += new System.EventHandler(this.ZichtrekeningHistoryButton_Click);
            // 
            // SpaarrekeningHistoryButton
            // 
            this.SpaarrekeningHistoryButton.Location = new System.Drawing.Point(370, 172);
            this.SpaarrekeningHistoryButton.Name = "SpaarrekeningHistoryButton";
            this.SpaarrekeningHistoryButton.Size = new System.Drawing.Size(105, 25);
            this.SpaarrekeningHistoryButton.TabIndex = 6;
            this.SpaarrekeningHistoryButton.Text = "HISTORY";
            this.SpaarrekeningHistoryButton.UseVisualStyleBackColor = true;
            this.SpaarrekeningHistoryButton.Click += new System.EventHandler(this.SpaarrekeningHistoryButton_Click);
            // 
            // ZichtrekeningBalancesListView
            // 
            this.ZichtrekeningBalancesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ZichtrekeningNr,
            this.BalanceZichtrekening});
            this.ZichtrekeningBalancesListView.HideSelection = false;
            this.ZichtrekeningBalancesListView.Location = new System.Drawing.Point(12, 225);
            this.ZichtrekeningBalancesListView.Name = "ZichtrekeningBalancesListView";
            this.ZichtrekeningBalancesListView.Size = new System.Drawing.Size(228, 118);
            this.ZichtrekeningBalancesListView.TabIndex = 7;
            this.ZichtrekeningBalancesListView.UseCompatibleStateImageBehavior = false;
            this.ZichtrekeningBalancesListView.View = System.Windows.Forms.View.Details;
            this.ZichtrekeningBalancesListView.SelectedIndexChanged += new System.EventHandler(this.ZichtrekeningBalancesListView_SelectedIndexChanged);
            // 
            // ZichtrekeningNr
            // 
            this.ZichtrekeningNr.Text = "ZichtrekeningNr";
            this.ZichtrekeningNr.Width = 99;
            // 
            // BalanceZichtrekening
            // 
            this.BalanceZichtrekening.Text = "Balance €";
            this.BalanceZichtrekening.Width = 72;
            // 
            // SpaarrekeningBalancesListView
            // 
            this.SpaarrekeningBalancesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SpaarrekeningNr,
            this.BalanceSpaarrekening});
            this.SpaarrekeningBalancesListView.HideSelection = false;
            this.SpaarrekeningBalancesListView.Location = new System.Drawing.Point(306, 225);
            this.SpaarrekeningBalancesListView.Name = "SpaarrekeningBalancesListView";
            this.SpaarrekeningBalancesListView.Size = new System.Drawing.Size(228, 118);
            this.SpaarrekeningBalancesListView.TabIndex = 8;
            this.SpaarrekeningBalancesListView.UseCompatibleStateImageBehavior = false;
            this.SpaarrekeningBalancesListView.View = System.Windows.Forms.View.Details;
            this.SpaarrekeningBalancesListView.SelectedIndexChanged += new System.EventHandler(this.SpaarrekeningBalancesListView_SelectedIndexChanged);
            // 
            // SpaarrekeningNr
            // 
            this.SpaarrekeningNr.Text = "SpaarrekeningNr";
            this.SpaarrekeningNr.Width = 99;
            // 
            // BalanceSpaarrekening
            // 
            this.BalanceSpaarrekening.Text = "Balance €";
            this.BalanceSpaarrekening.Width = 72;
            // 
            // ClientMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(546, 581);
            this.Controls.Add(this.SpaarrekeningBalancesListView);
            this.Controls.Add(this.ZichtrekeningBalancesListView);
            this.Controls.Add(this.SpaarrekeningHistoryButton);
            this.Controls.Add(this.ZichtrekeningHistoryButton);
            this.Controls.Add(this.SpaarrekeningenLabel);
            this.Controls.Add(this.ZichtrekeningenLabel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ClientMainPage";
            this.Text = "ClientMainPage";
            this.Load += new System.EventHandler(this.ClientMainPage_Load);
            this.panel1.ResumeLayout(false);
            this.DropDownMenuOfOverschrijvingen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicturePictureBox)).EndInit();
            this.DropDownMenuOfPfp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox ProfilePicturePictureBox;
        private System.Windows.Forms.Label ZichtrekeningenLabel;
        private System.Windows.Forms.Label SpaarrekeningenLabel;
        private System.Windows.Forms.Button ZichtrekeningHistoryButton;
        private System.Windows.Forms.Button SpaarrekeningHistoryButton;
        private System.Windows.Forms.ListView ZichtrekeningBalancesListView;
        private System.Windows.Forms.ColumnHeader ZichtrekeningNr;
        private System.Windows.Forms.ColumnHeader BalanceZichtrekening;
        private System.Windows.Forms.ListView SpaarrekeningBalancesListView;
        private System.Windows.Forms.ColumnHeader SpaarrekeningNr;
        private System.Windows.Forms.ColumnHeader BalanceSpaarrekening;
        private System.Windows.Forms.ContextMenuStrip DropDownMenuOfPfp;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button OverschrijvingenDropdownMenu;
        private System.Windows.Forms.ContextMenuStrip DropDownMenuOfOverschrijvingen;
        private System.Windows.Forms.ToolStripMenuItem automatischToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normaalToolStripMenuItem;
        private System.Windows.Forms.Button DepositButton;
    }
}