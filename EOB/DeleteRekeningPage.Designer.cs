namespace EOB
{
    partial class DeleteRekeningPage
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
            this.RekeningenDropDown = new System.Windows.Forms.ComboBox();
            this.MijnRekeningen = new System.Windows.Forms.Label();
            this.DeleteRekeningButton = new System.Windows.Forms.Button();
            this.DeleteRekeningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(1, 0);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 37);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "Back";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // RekeningenDropDown
            // 
            this.RekeningenDropDown.FormattingEnabled = true;
            this.RekeningenDropDown.Location = new System.Drawing.Point(100, 107);
            this.RekeningenDropDown.Name = "RekeningenDropDown";
            this.RekeningenDropDown.Size = new System.Drawing.Size(160, 21);
            this.RekeningenDropDown.TabIndex = 3;
            this.RekeningenDropDown.SelectedIndexChanged += new System.EventHandler(this.RekeningenDropDown_SelectedIndexChanged);
            // 
            // MijnRekeningen
            // 
            this.MijnRekeningen.AutoSize = true;
            this.MijnRekeningen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MijnRekeningen.Location = new System.Drawing.Point(97, 88);
            this.MijnRekeningen.Name = "MijnRekeningen";
            this.MijnRekeningen.Size = new System.Drawing.Size(101, 16);
            this.MijnRekeningen.TabIndex = 4;
            this.MijnRekeningen.Text = "Mijn rekeningen";
            // 
            // DeleteRekeningButton
            // 
            this.DeleteRekeningButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRekeningButton.Location = new System.Drawing.Point(110, 166);
            this.DeleteRekeningButton.Name = "DeleteRekeningButton";
            this.DeleteRekeningButton.Size = new System.Drawing.Size(127, 23);
            this.DeleteRekeningButton.TabIndex = 5;
            this.DeleteRekeningButton.Text = "Delete";
            this.DeleteRekeningButton.UseVisualStyleBackColor = true;
            this.DeleteRekeningButton.Click += new System.EventHandler(this.DeleteRekeningButton_Click);
            // 
            // DeleteRekeningLabel
            // 
            this.DeleteRekeningLabel.AutoSize = true;
            this.DeleteRekeningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRekeningLabel.Location = new System.Drawing.Point(82, 24);
            this.DeleteRekeningLabel.Name = "DeleteRekeningLabel";
            this.DeleteRekeningLabel.Size = new System.Drawing.Size(204, 31);
            this.DeleteRekeningLabel.TabIndex = 6;
            this.DeleteRekeningLabel.Text = "Delete rekening";
            // 
            // DeleteRekeningPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(367, 306);
            this.Controls.Add(this.DeleteRekeningLabel);
            this.Controls.Add(this.DeleteRekeningButton);
            this.Controls.Add(this.MijnRekeningen);
            this.Controls.Add(this.RekeningenDropDown);
            this.Controls.Add(this.ReturnButton);
            this.Name = "DeleteRekeningPage";
            this.Text = "DeleteRekeningPage";
            this.Load += new System.EventHandler(this.DeleteRekeningPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ComboBox RekeningenDropDown;
        private System.Windows.Forms.Label MijnRekeningen;
        private System.Windows.Forms.Button DeleteRekeningButton;
        private System.Windows.Forms.Label DeleteRekeningLabel;
    }
}