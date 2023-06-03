namespace EOB
{
    partial class DepositPage
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
            this.BedragText = new System.Windows.Forms.TextBox();
            this.SoortenRekeningDropDown = new System.Windows.Forms.ComboBox();
            this.DepositButton = new System.Windows.Forms.Button();
            this.BedragLabel = new System.Windows.Forms.Label();
            this.SoortRekeningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(0, 0);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 37);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "Back";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // BedragText
            // 
            this.BedragText.Location = new System.Drawing.Point(116, 117);
            this.BedragText.Name = "BedragText";
            this.BedragText.Size = new System.Drawing.Size(157, 20);
            this.BedragText.TabIndex = 3;
            this.BedragText.Text = "€";
            this.BedragText.TextChanged += new System.EventHandler(this.BedragText_TextChanged);
            // 
            // SoortenRekeningDropDown
            // 
            this.SoortenRekeningDropDown.FormattingEnabled = true;
            this.SoortenRekeningDropDown.Location = new System.Drawing.Point(116, 159);
            this.SoortenRekeningDropDown.Name = "SoortenRekeningDropDown";
            this.SoortenRekeningDropDown.Size = new System.Drawing.Size(157, 21);
            this.SoortenRekeningDropDown.TabIndex = 4;
            this.SoortenRekeningDropDown.SelectedIndexChanged += new System.EventHandler(this.SoortenRekeningDropDown_SelectedIndexChanged);
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(116, 217);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(157, 23);
            this.DepositButton.TabIndex = 5;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // BedragLabel
            // 
            this.BedragLabel.AutoSize = true;
            this.BedragLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BedragLabel.Location = new System.Drawing.Point(113, 98);
            this.BedragLabel.Name = "BedragLabel";
            this.BedragLabel.Size = new System.Drawing.Size(52, 16);
            this.BedragLabel.TabIndex = 6;
            this.BedragLabel.Text = "Bedrag";
            // 
            // SoortRekeningLabel
            // 
            this.SoortRekeningLabel.AutoSize = true;
            this.SoortRekeningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoortRekeningLabel.Location = new System.Drawing.Point(113, 140);
            this.SoortRekeningLabel.Name = "SoortRekeningLabel";
            this.SoortRekeningLabel.Size = new System.Drawing.Size(94, 16);
            this.SoortRekeningLabel.TabIndex = 7;
            this.SoortRekeningLabel.Text = "Soort rekening";
            // 
            // DepositPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(388, 311);
            this.Controls.Add(this.SoortRekeningLabel);
            this.Controls.Add(this.BedragLabel);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.SoortenRekeningDropDown);
            this.Controls.Add(this.BedragText);
            this.Controls.Add(this.returnButton);
            this.Name = "DepositPage";
            this.Text = "DepositPage";
            this.Load += new System.EventHandler(this.DepositPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TextBox BedragText;
        private System.Windows.Forms.ComboBox SoortenRekeningDropDown;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Label BedragLabel;
        private System.Windows.Forms.Label SoortRekeningLabel;
    }
}