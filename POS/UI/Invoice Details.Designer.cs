namespace POS.UI
{
    partial class Invoice_Details
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
            this.txtreturnamount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdueamount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttotalamount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnmonth = new System.Windows.Forms.Button();
            this.btntoday = new System.Windows.Forms.Button();
            this.dgvinvoicedetails = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.posDataSet4 = new POS.posDataSet4();
            this.tblinvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_invoiceTableAdapter = new POS.posDataSet4TableAdapters.tbl_invoiceTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpayableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvoicedetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblinvoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtreturnamount
            // 
            this.txtreturnamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtreturnamount.Location = new System.Drawing.Point(728, 447);
            this.txtreturnamount.Margin = new System.Windows.Forms.Padding(2);
            this.txtreturnamount.Name = "txtreturnamount";
            this.txtreturnamount.ReadOnly = true;
            this.txtreturnamount.Size = new System.Drawing.Size(215, 53);
            this.txtreturnamount.TabIndex = 57;
            this.txtreturnamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(784, 423);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "Change Amount";
            // 
            // txtdueamount
            // 
            this.txtdueamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtdueamount.Location = new System.Drawing.Point(728, 348);
            this.txtdueamount.Margin = new System.Windows.Forms.Padding(2);
            this.txtdueamount.Name = "txtdueamount";
            this.txtdueamount.ReadOnly = true;
            this.txtdueamount.Size = new System.Drawing.Size(215, 53);
            this.txtdueamount.TabIndex = 55;
            this.txtdueamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(784, 325);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 54;
            this.label9.Text = "Due Amount";
            // 
            // txttotalamount
            // 
            this.txttotalamount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txttotalamount.Location = new System.Drawing.Point(728, 246);
            this.txttotalamount.Margin = new System.Windows.Forms.Padding(2);
            this.txttotalamount.Name = "txttotalamount";
            this.txttotalamount.ReadOnly = true;
            this.txttotalamount.Size = new System.Drawing.Size(215, 53);
            this.txttotalamount.TabIndex = 53;
            this.txttotalamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(784, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Total Amount";
            // 
            // btnmonth
            // 
            this.btnmonth.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnmonth.ForeColor = System.Drawing.Color.White;
            this.btnmonth.Location = new System.Drawing.Point(850, 114);
            this.btnmonth.Margin = new System.Windows.Forms.Padding(2);
            this.btnmonth.Name = "btnmonth";
            this.btnmonth.Size = new System.Drawing.Size(92, 67);
            this.btnmonth.TabIndex = 51;
            this.btnmonth.Text = "Monthly Sale";
            this.btnmonth.UseVisualStyleBackColor = false;
            this.btnmonth.Click += new System.EventHandler(this.btnmonth_Click);
            // 
            // btntoday
            // 
            this.btntoday.BackColor = System.Drawing.Color.DodgerBlue;
            this.btntoday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btntoday.ForeColor = System.Drawing.Color.White;
            this.btntoday.Location = new System.Drawing.Point(728, 114);
            this.btntoday.Margin = new System.Windows.Forms.Padding(2);
            this.btntoday.Name = "btntoday";
            this.btntoday.Size = new System.Drawing.Size(94, 67);
            this.btntoday.TabIndex = 50;
            this.btntoday.Text = "Today,s Sale";
            this.btntoday.UseVisualStyleBackColor = false;
            this.btntoday.Click += new System.EventHandler(this.btntoday_Click);
            // 
            // dgvinvoicedetails
            // 
            this.dgvinvoicedetails.AllowUserToAddRows = false;
            this.dgvinvoicedetails.AllowUserToDeleteRows = false;
            this.dgvinvoicedetails.AutoGenerateColumns = false;
            this.dgvinvoicedetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinvoicedetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.invnoDataGridViewTextBoxColumn,
            this.totalpayableDataGridViewTextBoxColumn,
            this.paidamountDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.dueamountDataGridViewTextBoxColumn,
            this.changeamountDataGridViewTextBoxColumn,
            this.addedbyDataGridViewTextBoxColumn,
            this.salesdateDataGridViewTextBoxColumn});
            this.dgvinvoicedetails.DataSource = this.tblinvoiceBindingSource;
            this.dgvinvoicedetails.Location = new System.Drawing.Point(-6, 116);
            this.dgvinvoicedetails.Margin = new System.Windows.Forms.Padding(2);
            this.dgvinvoicedetails.Name = "dgvinvoicedetails";
            this.dgvinvoicedetails.ReadOnly = true;
            this.dgvinvoicedetails.RowTemplate.Height = 24;
            this.dgvinvoicedetails.Size = new System.Drawing.Size(713, 460);
            this.dgvinvoicedetails.TabIndex = 49;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtsearch.Location = new System.Drawing.Point(97, 79);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(344, 29);
            this.txtsearch.TabIndex = 48;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // dt2
            // 
            this.dt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dt2.Location = new System.Drawing.Point(776, 77);
            this.dt2.Margin = new System.Windows.Forms.Padding(2);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(164, 23);
            this.dt2.TabIndex = 47;
            this.dt2.ValueChanged += new System.EventHandler(this.dt2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(740, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "To:";
            // 
            // dt1
            // 
            this.dt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dt1.Location = new System.Drawing.Point(556, 79);
            this.dt1.Margin = new System.Windows.Forms.Padding(2);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(164, 23);
            this.dt1.TabIndex = 45;
            this.dt1.ValueChanged += new System.EventHandler(this.dt1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(504, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(43, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Search:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(346, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 39);
            this.label2.TabIndex = 42;
            this.label2.Text = "Invoice Details";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(728, 523);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 53);
            this.button4.TabIndex = 58;
            this.button4.Text = "Print Report";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // posDataSet4
            // 
            this.posDataSet4.DataSetName = "posDataSet4";
            this.posDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblinvoiceBindingSource
            // 
            this.tblinvoiceBindingSource.DataMember = "tbl_invoice";
            this.tblinvoiceBindingSource.DataSource = this.posDataSet4;
            // 
            // tbl_invoiceTableAdapter
            // 
            this.tbl_invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "customer_name";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            this.customernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invnoDataGridViewTextBoxColumn
            // 
            this.invnoDataGridViewTextBoxColumn.DataPropertyName = "inv_no";
            this.invnoDataGridViewTextBoxColumn.HeaderText = "inv_no";
            this.invnoDataGridViewTextBoxColumn.Name = "invnoDataGridViewTextBoxColumn";
            this.invnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.invnoDataGridViewTextBoxColumn.Width = 40;
            // 
            // totalpayableDataGridViewTextBoxColumn
            // 
            this.totalpayableDataGridViewTextBoxColumn.DataPropertyName = "total_payable";
            this.totalpayableDataGridViewTextBoxColumn.HeaderText = "total_payable";
            this.totalpayableDataGridViewTextBoxColumn.Name = "totalpayableDataGridViewTextBoxColumn";
            this.totalpayableDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalpayableDataGridViewTextBoxColumn.Width = 80;
            // 
            // paidamountDataGridViewTextBoxColumn
            // 
            this.paidamountDataGridViewTextBoxColumn.DataPropertyName = "paid_amount";
            this.paidamountDataGridViewTextBoxColumn.HeaderText = "paid_amount";
            this.paidamountDataGridViewTextBoxColumn.Name = "paidamountDataGridViewTextBoxColumn";
            this.paidamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidamountDataGridViewTextBoxColumn.Width = 80;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountDataGridViewTextBoxColumn.Width = 40;
            // 
            // dueamountDataGridViewTextBoxColumn
            // 
            this.dueamountDataGridViewTextBoxColumn.DataPropertyName = "due_amount";
            this.dueamountDataGridViewTextBoxColumn.HeaderText = "due_amount";
            this.dueamountDataGridViewTextBoxColumn.Name = "dueamountDataGridViewTextBoxColumn";
            this.dueamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.dueamountDataGridViewTextBoxColumn.Width = 80;
            // 
            // changeamountDataGridViewTextBoxColumn
            // 
            this.changeamountDataGridViewTextBoxColumn.DataPropertyName = "change_amount";
            this.changeamountDataGridViewTextBoxColumn.HeaderText = "change_amount";
            this.changeamountDataGridViewTextBoxColumn.Name = "changeamountDataGridViewTextBoxColumn";
            this.changeamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.changeamountDataGridViewTextBoxColumn.Width = 80;
            // 
            // addedbyDataGridViewTextBoxColumn
            // 
            this.addedbyDataGridViewTextBoxColumn.DataPropertyName = "added_by";
            this.addedbyDataGridViewTextBoxColumn.HeaderText = "added_by";
            this.addedbyDataGridViewTextBoxColumn.Name = "addedbyDataGridViewTextBoxColumn";
            this.addedbyDataGridViewTextBoxColumn.ReadOnly = true;
            this.addedbyDataGridViewTextBoxColumn.Width = 40;
            // 
            // salesdateDataGridViewTextBoxColumn
            // 
            this.salesdateDataGridViewTextBoxColumn.DataPropertyName = "sales_date";
            this.salesdateDataGridViewTextBoxColumn.HeaderText = "sales_date";
            this.salesdateDataGridViewTextBoxColumn.Name = "salesdateDataGridViewTextBoxColumn";
            this.salesdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesdateDataGridViewTextBoxColumn.Width = 90;
            // 
            // Invoice_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 598);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtreturnamount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdueamount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txttotalamount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnmonth);
            this.Controls.Add(this.btntoday);
            this.Controls.Add(this.dgvinvoicedetails);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dt2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Invoice_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice_Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Invoice_Details_FormClosed);
            this.Load += new System.EventHandler(this.Invoice_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvoicedetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblinvoiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtreturnamount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdueamount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttotalamount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnmonth;
        private System.Windows.Forms.Button btntoday;
        private System.Windows.Forms.DataGridView dgvinvoicedetails;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private posDataSet4 posDataSet4;
        private System.Windows.Forms.BindingSource tblinvoiceBindingSource;
        private posDataSet4TableAdapters.tbl_invoiceTableAdapter tbl_invoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpayableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesdateDataGridViewTextBoxColumn;
    }
}