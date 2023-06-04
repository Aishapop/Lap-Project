namespace EOB
{
    partial class AutomatischeOverschrijvingPage
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
            this.TermijnDropDownMenu = new System.Windows.Forms.ComboBox();
            this.OntvangersRekeningNR = new System.Windows.Forms.TextBox();
            this.BedragText = new System.Windows.Forms.TextBox();
            this.BeginDateAutoOverschrij = new System.Windows.Forms.DateTimePicker();
            this.EndDateAutoOverschrij = new System.Windows.Forms.DateTimePicker();
            this.OntvangerRekeningNRLabel = new System.Windows.Forms.Label();
            this.BedragLabel = new System.Windows.Forms.Label();
            this.TermijnLabel = new System.Windows.Forms.Label();
            this.BeginDatumLabel = new System.Windows.Forms.Label();
            this.EindeDatumLabel = new System.Windows.Forms.Label();
            this.ToevoegenAutoOverschrButton = new System.Windows.Forms.Button();
            this.MijnRekeningenDropDown = new System.Windows.Forms.ComboBox();
            this.MijnRekeningenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(1, 0);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 37);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "Back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // TermijnDropDownMenu
            // 
            this.TermijnDropDownMenu.AutoCompleteCustomSource.AddRange(new string[] {
            "wekelijks",
            "maandelijks",
            "jaarlijks"});
            this.TermijnDropDownMenu.FormattingEnabled = true;
            this.TermijnDropDownMenu.Items.AddRange(new object[] {
            "wekelijks",
            "maandelijks",
            "jaarlijks"});
            this.TermijnDropDownMenu.Location = new System.Drawing.Point(133, 224);
            this.TermijnDropDownMenu.Name = "TermijnDropDownMenu";
            this.TermijnDropDownMenu.Size = new System.Drawing.Size(200, 21);
            this.TermijnDropDownMenu.TabIndex = 2;
            this.TermijnDropDownMenu.SelectedIndexChanged += new System.EventHandler(this.TermijnDropDownMenu_SelectedIndexChanged);
            // 
            // OntvangersRekeningNR
            // 
            this.OntvangersRekeningNR.Location = new System.Drawing.Point(133, 140);
            this.OntvangersRekeningNR.Name = "OntvangersRekeningNR";
            this.OntvangersRekeningNR.Size = new System.Drawing.Size(200, 20);
            this.OntvangersRekeningNR.TabIndex = 3;
            this.OntvangersRekeningNR.Text = "BE";
            this.OntvangersRekeningNR.TextChanged += new System.EventHandler(this.OntvangersRekeningNR_TextChanged);
            // 
            // BedragText
            // 
            this.BedragText.Location = new System.Drawing.Point(133, 182);
            this.BedragText.Name = "BedragText";
            this.BedragText.Size = new System.Drawing.Size(200, 20);
            this.BedragText.TabIndex = 4;
            this.BedragText.Text = "€";
            this.BedragText.TextChanged += new System.EventHandler(this.BedragText_TextChanged);
            // 
            // BeginDateAutoOverschrij
            // 
            this.BeginDateAutoOverschrij.Location = new System.Drawing.Point(133, 267);
            this.BeginDateAutoOverschrij.Name = "BeginDateAutoOverschrij";
            this.BeginDateAutoOverschrij.Size = new System.Drawing.Size(200, 20);
            this.BeginDateAutoOverschrij.TabIndex = 5;
            this.BeginDateAutoOverschrij.ValueChanged += new System.EventHandler(this.BeginDateAutoOverschrij_ValueChanged);
            // 
            // EndDateAutoOverschrij
            // 
            this.EndDateAutoOverschrij.Location = new System.Drawing.Point(132, 309);
            this.EndDateAutoOverschrij.Name = "EndDateAutoOverschrij";
            this.EndDateAutoOverschrij.Size = new System.Drawing.Size(200, 20);
            this.EndDateAutoOverschrij.TabIndex = 6;
            this.EndDateAutoOverschrij.ValueChanged += new System.EventHandler(this.EndDateAutoOverschrij_ValueChanged);
            // 
            // OntvangerRekeningNRLabel
            // 
            this.OntvangerRekeningNRLabel.AutoSize = true;
            this.OntvangerRekeningNRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OntvangerRekeningNRLabel.Location = new System.Drawing.Point(129, 117);
            this.OntvangerRekeningNRLabel.Name = "OntvangerRekeningNRLabel";
            this.OntvangerRekeningNRLabel.Size = new System.Drawing.Size(142, 16);
            this.OntvangerRekeningNRLabel.TabIndex = 7;
            this.OntvangerRekeningNRLabel.Text = "RekeningNr ontvanger";
            // 
            // BedragLabel
            // 
            this.BedragLabel.AutoSize = true;
            this.BedragLabel.BackColor = System.Drawing.Color.SlateGray;
            this.BedragLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedragLabel.Location = new System.Drawing.Point(129, 163);
            this.BedragLabel.Name = "BedragLabel";
            this.BedragLabel.Size = new System.Drawing.Size(121, 16);
            this.BedragLabel.TabIndex = 12;
            this.BedragLabel.Text = "Bedrag Per Maand";
            // 
            // TermijnLabel
            // 
            this.TermijnLabel.AutoSize = true;
            this.TermijnLabel.BackColor = System.Drawing.Color.SlateGray;
            this.TermijnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TermijnLabel.Location = new System.Drawing.Point(130, 205);
            this.TermijnLabel.Name = "TermijnLabel";
            this.TermijnLabel.Size = new System.Drawing.Size(52, 16);
            this.TermijnLabel.TabIndex = 13;
            this.TermijnLabel.Text = "Termijn";
            // 
            // BeginDatumLabel
            // 
            this.BeginDatumLabel.AutoSize = true;
            this.BeginDatumLabel.BackColor = System.Drawing.Color.SlateGray;
            this.BeginDatumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginDatumLabel.Location = new System.Drawing.Point(130, 248);
            this.BeginDatumLabel.Name = "BeginDatumLabel";
            this.BeginDatumLabel.Size = new System.Drawing.Size(82, 16);
            this.BeginDatumLabel.TabIndex = 14;
            this.BeginDatumLabel.Text = "Begin datum";
            // 
            // EindeDatumLabel
            // 
            this.EindeDatumLabel.AutoSize = true;
            this.EindeDatumLabel.BackColor = System.Drawing.Color.SlateGray;
            this.EindeDatumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EindeDatumLabel.Location = new System.Drawing.Point(130, 290);
            this.EindeDatumLabel.Name = "EindeDatumLabel";
            this.EindeDatumLabel.Size = new System.Drawing.Size(74, 16);
            this.EindeDatumLabel.TabIndex = 15;
            this.EindeDatumLabel.Text = "Eind datum";
            // 
            // ToevoegenAutoOverschrButton
            // 
            this.ToevoegenAutoOverschrButton.Location = new System.Drawing.Point(157, 357);
            this.ToevoegenAutoOverschrButton.Name = "ToevoegenAutoOverschrButton";
            this.ToevoegenAutoOverschrButton.Size = new System.Drawing.Size(138, 23);
            this.ToevoegenAutoOverschrButton.TabIndex = 16;
            this.ToevoegenAutoOverschrButton.Text = "Toevoegen";
            this.ToevoegenAutoOverschrButton.UseVisualStyleBackColor = true;
            this.ToevoegenAutoOverschrButton.Click += new System.EventHandler(this.ToevoegenAutoOverschrButton_Click);
            // 
            // MijnRekeningenDropDown
            // 
            this.MijnRekeningenDropDown.FormattingEnabled = true;
            this.MijnRekeningenDropDown.Location = new System.Drawing.Point(132, 93);
            this.MijnRekeningenDropDown.Name = "MijnRekeningenDropDown";
            this.MijnRekeningenDropDown.Size = new System.Drawing.Size(200, 21);
            this.MijnRekeningenDropDown.TabIndex = 17;
            this.MijnRekeningenDropDown.SelectedIndexChanged += new System.EventHandler(this.MijnRekeningenDropDown_SelectedIndexChanged);
            // 
            // MijnRekeningenLabel
            // 
            this.MijnRekeningenLabel.AutoSize = true;
            this.MijnRekeningenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MijnRekeningenLabel.Location = new System.Drawing.Point(129, 74);
            this.MijnRekeningenLabel.Name = "MijnRekeningenLabel";
            this.MijnRekeningenLabel.Size = new System.Drawing.Size(101, 16);
            this.MijnRekeningenLabel.TabIndex = 18;
            this.MijnRekeningenLabel.Text = "Mijn rekeningen";
            // 
            // AutomatischeOverschrijvingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.MijnRekeningenLabel);
            this.Controls.Add(this.MijnRekeningenDropDown);
            this.Controls.Add(this.ToevoegenAutoOverschrButton);
            this.Controls.Add(this.EindeDatumLabel);
            this.Controls.Add(this.BeginDatumLabel);
            this.Controls.Add(this.TermijnLabel);
            this.Controls.Add(this.BedragLabel);
            this.Controls.Add(this.OntvangerRekeningNRLabel);
            this.Controls.Add(this.EndDateAutoOverschrij);
            this.Controls.Add(this.BeginDateAutoOverschrij);
            this.Controls.Add(this.BedragText);
            this.Controls.Add(this.OntvangersRekeningNR);
            this.Controls.Add(this.TermijnDropDownMenu);
            this.Controls.Add(this.returnButton);
            this.Name = "AutomatischeOverschrijvingPage";
            this.Text = "AutomatischeOverschrijving";
            this.Load += new System.EventHandler(this.AutomatischeOverschrijving_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.ComboBox TermijnDropDownMenu;
        private System.Windows.Forms.TextBox OntvangersRekeningNR;
        private System.Windows.Forms.TextBox BedragText;
        private System.Windows.Forms.DateTimePicker BeginDateAutoOverschrij;
        private System.Windows.Forms.DateTimePicker EndDateAutoOverschrij;
        private System.Windows.Forms.Label OntvangerRekeningNRLabel;
        private System.Windows.Forms.Label BedragLabel;
        private System.Windows.Forms.Label TermijnLabel;
        private System.Windows.Forms.Label BeginDatumLabel;
        private System.Windows.Forms.Label EindeDatumLabel;
        private System.Windows.Forms.Button ToevoegenAutoOverschrButton;
        private System.Windows.Forms.ComboBox MijnRekeningenDropDown;
        private System.Windows.Forms.Label MijnRekeningenLabel;
    }
}