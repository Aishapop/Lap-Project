namespace EOB
{
    partial class HistoryTransactionsPage
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
            this.ReturnButton = new System.Windows.Forms.Button();
            this.HistoryOfTransactionsListView = new System.Windows.Forms.ListView();
            this.MijnRekening = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OntvangerRekeningNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bedrag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MyTransactionHistoryLabel = new System.Windows.Forms.Label();
            this.FilterButton = new System.Windows.Forms.Button();
            this.MijnrekeningNrDropDown = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            // HistoryOfTransactionsListView
            // 
            this.HistoryOfTransactionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MijnRekening,
            this.OntvangerRekeningNr,
            this.Bedrag,
            this.Datum});
            this.HistoryOfTransactionsListView.HideSelection = false;
            this.HistoryOfTransactionsListView.Location = new System.Drawing.Point(1, 101);
            this.HistoryOfTransactionsListView.Name = "HistoryOfTransactionsListView";
            this.HistoryOfTransactionsListView.Size = new System.Drawing.Size(494, 254);
            this.HistoryOfTransactionsListView.TabIndex = 3;
            this.HistoryOfTransactionsListView.UseCompatibleStateImageBehavior = false;
            this.HistoryOfTransactionsListView.View = System.Windows.Forms.View.Details;
            this.HistoryOfTransactionsListView.SelectedIndexChanged += new System.EventHandler(this.HistoryOfTransactionsListView_SelectedIndexChanged);
            // 
            // MijnRekening
            // 
            this.MijnRekening.Text = "Mijn rekeningnr";
            this.MijnRekening.Width = 128;
            // 
            // OntvangerRekeningNr
            // 
            this.OntvangerRekeningNr.Text = "Ontvanger rekening";
            this.OntvangerRekeningNr.Width = 145;
            // 
            // Bedrag
            // 
            this.Bedrag.Text = "Bedrag €";
            this.Bedrag.Width = 96;
            // 
            // Datum
            // 
            this.Datum.Text = "Datum";
            this.Datum.Width = 120;
            // 
            // MyTransactionHistoryLabel
            // 
            this.MyTransactionHistoryLabel.AutoSize = true;
            this.MyTransactionHistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyTransactionHistoryLabel.Location = new System.Drawing.Point(242, 22);
            this.MyTransactionHistoryLabel.Name = "MyTransactionHistoryLabel";
            this.MyTransactionHistoryLabel.Size = new System.Drawing.Size(203, 31);
            this.MyTransactionHistoryLabel.TabIndex = 4;
            this.MyTransactionHistoryLabel.Text = "Mijn transacties";
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(501, 125);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(160, 25);
            this.FilterButton.TabIndex = 5;
            this.FilterButton.Text = "Filter op mijn rekeningNr";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // MijnrekeningNrDropDown
            // 
            this.MijnrekeningNrDropDown.Name = "MijnrekeningNrDropDown";
            this.MijnrekeningNrDropDown.Size = new System.Drawing.Size(61, 4);
            // 
            // HistoryTransactionsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(668, 469);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.MyTransactionHistoryLabel);
            this.Controls.Add(this.HistoryOfTransactionsListView);
            this.Controls.Add(this.ReturnButton);
            this.Name = "HistoryTransactionsPage";
            this.Text = "HistoryTransactionsPage";
            this.Load += new System.EventHandler(this.HistoryTransactionsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ListView HistoryOfTransactionsListView;
        private System.Windows.Forms.ColumnHeader MijnRekening;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Bedrag;
        private System.Windows.Forms.ColumnHeader OntvangerRekeningNr;
        private System.Windows.Forms.Label MyTransactionHistoryLabel;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.ContextMenuStrip MijnrekeningNrDropDown;
    }
}