namespace EOB
{
    partial class MyAccountsOverviewPage
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
            this.RekeningBalancesListView = new System.Windows.Forms.ListView();
            this.ZichtrekeningNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BalanceZichtrekening = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpaarrekeningNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RekeningBalancesListView
            // 
            this.RekeningBalancesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ZichtrekeningNr,
            this.SpaarrekeningNr,
            this.BalanceZichtrekening});
            this.RekeningBalancesListView.HideSelection = false;
            this.RekeningBalancesListView.Location = new System.Drawing.Point(96, 115);
            this.RekeningBalancesListView.Name = "RekeningBalancesListView";
            this.RekeningBalancesListView.Size = new System.Drawing.Size(299, 250);
            this.RekeningBalancesListView.TabIndex = 8;
            this.RekeningBalancesListView.UseCompatibleStateImageBehavior = false;
            this.RekeningBalancesListView.View = System.Windows.Forms.View.Details;
            // 
            // ZichtrekeningNr
            // 
            this.ZichtrekeningNr.Text = "ZichtrekeningNr";
            this.ZichtrekeningNr.Width = 99;
            // 
            // BalanceZichtrekening
            // 
            this.BalanceZichtrekening.Text = "Balance €";
            this.BalanceZichtrekening.Width = 83;
            // 
            // SpaarrekeningNr
            // 
            this.SpaarrekeningNr.Text = "SpaarrekeningNr";
            this.SpaarrekeningNr.Width = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rekeningen Overview";
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(2, 1);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(75, 37);
            this.ReturnButton.TabIndex = 21;
            this.ReturnButton.Text = "Back";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // MyAccountsOverviewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RekeningBalancesListView);
            this.Name = "MyAccountsOverviewPage";
            this.Text = "MyAccountsOverviewPage";
            this.Load += new System.EventHandler(this.MyAccountsOverviewPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView RekeningBalancesListView;
        private System.Windows.Forms.ColumnHeader ZichtrekeningNr;
        private System.Windows.Forms.ColumnHeader SpaarrekeningNr;
        private System.Windows.Forms.ColumnHeader BalanceZichtrekening;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReturnButton;
    }
}