namespace EOB
{
    partial class NormaleOverschrijvingPage
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
            this.OntvangerRekeningNrText = new System.Windows.Forms.TextBox();
            this.MijnRekeningenDropDown = new System.Windows.Forms.ComboBox();
            this.BedragText = new System.Windows.Forms.TextBox();
            this.OverschrijvenButton = new System.Windows.Forms.Button();
            this.MijnRekeningenLabel = new System.Windows.Forms.Label();
            this.RekeningNrOntvangerLabel = new System.Windows.Forms.Label();
            this.BedragLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(0, 0);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 37);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "Back";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // OntvangerRekeningNrText
            // 
            this.OntvangerRekeningNrText.Location = new System.Drawing.Point(111, 140);
            this.OntvangerRekeningNrText.Name = "OntvangerRekeningNrText";
            this.OntvangerRekeningNrText.Size = new System.Drawing.Size(152, 20);
            this.OntvangerRekeningNrText.TabIndex = 3;
            this.OntvangerRekeningNrText.Text = "BE";
            // 
            // MijnRekeningenDropDown
            // 
            this.MijnRekeningenDropDown.FormattingEnabled = true;
            this.MijnRekeningenDropDown.Location = new System.Drawing.Point(111, 94);
            this.MijnRekeningenDropDown.Name = "MijnRekeningenDropDown";
            this.MijnRekeningenDropDown.Size = new System.Drawing.Size(152, 21);
            this.MijnRekeningenDropDown.TabIndex = 4;
            // 
            // BedragText
            // 
            this.BedragText.Location = new System.Drawing.Point(111, 182);
            this.BedragText.Name = "BedragText";
            this.BedragText.Size = new System.Drawing.Size(152, 20);
            this.BedragText.TabIndex = 5;
            this.BedragText.Text = "€";
            // 
            // OverschrijvenButton
            // 
            this.OverschrijvenButton.Location = new System.Drawing.Point(125, 228);
            this.OverschrijvenButton.Name = "OverschrijvenButton";
            this.OverschrijvenButton.Size = new System.Drawing.Size(124, 23);
            this.OverschrijvenButton.TabIndex = 6;
            this.OverschrijvenButton.Text = "Overschrijven";
            this.OverschrijvenButton.UseVisualStyleBackColor = true;
            this.OverschrijvenButton.Click += new System.EventHandler(this.OverschrijvenButton_Click);
            // 
            // MijnRekeningenLabel
            // 
            this.MijnRekeningenLabel.AutoSize = true;
            this.MijnRekeningenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MijnRekeningenLabel.Location = new System.Drawing.Point(108, 75);
            this.MijnRekeningenLabel.Name = "MijnRekeningenLabel";
            this.MijnRekeningenLabel.Size = new System.Drawing.Size(101, 16);
            this.MijnRekeningenLabel.TabIndex = 19;
            this.MijnRekeningenLabel.Text = "Mijn rekeningen";
            // 
            // RekeningNrOntvangerLabel
            // 
            this.RekeningNrOntvangerLabel.AutoSize = true;
            this.RekeningNrOntvangerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RekeningNrOntvangerLabel.Location = new System.Drawing.Point(108, 121);
            this.RekeningNrOntvangerLabel.Name = "RekeningNrOntvangerLabel";
            this.RekeningNrOntvangerLabel.Size = new System.Drawing.Size(141, 16);
            this.RekeningNrOntvangerLabel.TabIndex = 20;
            this.RekeningNrOntvangerLabel.Text = "Rekeningnr Ontvanger";
            // 
            // BedragLabel
            // 
            this.BedragLabel.AutoSize = true;
            this.BedragLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedragLabel.Location = new System.Drawing.Point(108, 163);
            this.BedragLabel.Name = "BedragLabel";
            this.BedragLabel.Size = new System.Drawing.Size(52, 16);
            this.BedragLabel.TabIndex = 21;
            this.BedragLabel.Text = "Bedrag";
            // 
            // NormaleOverschrijvingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(398, 343);
            this.Controls.Add(this.BedragLabel);
            this.Controls.Add(this.RekeningNrOntvangerLabel);
            this.Controls.Add(this.MijnRekeningenLabel);
            this.Controls.Add(this.OverschrijvenButton);
            this.Controls.Add(this.BedragText);
            this.Controls.Add(this.MijnRekeningenDropDown);
            this.Controls.Add(this.OntvangerRekeningNrText);
            this.Controls.Add(this.ReturnButton);
            this.Name = "NormaleOverschrijvingPage";
            this.Text = "NormaleOverschrijvingPage";
            this.Load += new System.EventHandler(this.NormaleOverschrijvingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.TextBox OntvangerRekeningNrText;
        private System.Windows.Forms.ComboBox MijnRekeningenDropDown;
        private System.Windows.Forms.TextBox BedragText;
        private System.Windows.Forms.Button OverschrijvenButton;
        private System.Windows.Forms.Label MijnRekeningenLabel;
        private System.Windows.Forms.Label RekeningNrOntvangerLabel;
        private System.Windows.Forms.Label BedragLabel;
    }
}