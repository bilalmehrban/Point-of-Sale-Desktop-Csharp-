namespace POS.UI
{
    partial class Sales_Analytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Analytics));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dgvsalesanalytics = new System.Windows.Forms.DataGridView();
            this.tblproductdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posDataSet3 = new POS.posDataSet3();
            this.btntoday = new System.Windows.Forms.Button();
            this.btnmonth = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtrevenue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tbl_productdetailsTableAdapter = new POS.posDataSet3TableAdapters.tbl_productdetailsTableAdapter();
            this.posDataSet5 = new POS.posDataSet5();
            this.tblproductdetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_productdetailsTableAdapter1 = new POS.posDataSet5TableAdapters.tbl_productdetailsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesanalytics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductdetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(372, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 39);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sales Analytics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(69, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Search:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(530, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "From:";
            // 
            // dt1
            // 
            this.dt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dt1.Location = new System.Drawing.Point(582, 80);
            this.dt1.Margin = new System.Windows.Forms.Padding(2);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(164, 23);
            this.dt1.TabIndex = 26;
            this.dt1.ValueChanged += new System.EventHandler(this.dt1_ValueChanged);
            // 
            // dt2
            // 
            this.dt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dt2.Location = new System.Drawing.Point(802, 78);
            this.dt2.Margin = new System.Windows.Forms.Padding(2);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(164, 23);
            this.dt2.TabIndex = 28;
            this.dt2.ValueChanged += new System.EventHandler(this.dt2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(766, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "To:";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtsearch.Location = new System.Drawing.Point(123, 80);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(344, 29);
            this.txtsearch.TabIndex = 29;
            this.txtsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvsalesanalytics
            // 
            this.dgvsalesanalytics.AllowUserToAddRows = false;
            this.dgvsalesanalytics.AllowUserToDeleteRows = false;
            this.dgvsalesanalytics.AutoGenerateColumns = false;
            this.dgvsalesanalytics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsalesanalytics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.codeDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvsalesanalytics.DataSource = this.tblproductdetailsBindingSource1;
            this.dgvsalesanalytics.Location = new System.Drawing.Point(33, 117);
            this.dgvsalesanalytics.Margin = new System.Windows.Forms.Padding(2);
            this.dgvsalesanalytics.Name = "dgvsalesanalytics";
            this.dgvsalesanalytics.ReadOnly = true;
            this.dgvsalesanalytics.RowTemplate.Height = 24;
            this.dgvsalesanalytics.Size = new System.Drawing.Size(713, 460);
            this.dgvsalesanalytics.TabIndex = 32;
            // 
            // tblproductdetailsBindingSource
            // 
            this.tblproductdetailsBindingSource.DataMember = "tbl_productdetails";
            this.tblproductdetailsBindingSource.DataSource = this.posDataSet3;
            // 
            // posDataSet3
            // 
            this.posDataSet3.DataSetName = "posDataSet3";
            this.posDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btntoday
            // 
            this.btntoday.BackColor = System.Drawing.Color.DodgerBlue;
            this.btntoday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btntoday.ForeColor = System.Drawing.Color.White;
            this.btntoday.Location = new System.Drawing.Point(754, 115);
            this.btntoday.Margin = new System.Windows.Forms.Padding(2);
            this.btntoday.Name = "btntoday";
            this.btntoday.Size = new System.Drawing.Size(94, 67);
            this.btntoday.TabIndex = 33;
            this.btntoday.Text = "Today,s Sale";
            this.btntoday.UseVisualStyleBackColor = false;
            this.btntoday.Click += new System.EventHandler(this.btntoday_Click);
            // 
            // btnmonth
            // 
            this.btnmonth.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnmonth.ForeColor = System.Drawing.Color.White;
            this.btnmonth.Location = new System.Drawing.Point(876, 115);
            this.btnmonth.Margin = new System.Windows.Forms.Padding(2);
            this.btnmonth.Name = "btnmonth";
            this.btnmonth.Size = new System.Drawing.Size(92, 67);
            this.btnmonth.TabIndex = 34;
            this.btnmonth.Text = "Monthly Sale";
            this.btnmonth.UseVisualStyleBackColor = false;
            this.btnmonth.Click += new System.EventHandler(this.btnmonth_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(810, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Total Quantity";
            // 
            // txtquantity
            // 
            this.txtquantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtquantity.Location = new System.Drawing.Point(754, 247);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.ReadOnly = true;
            this.txtquantity.Size = new System.Drawing.Size(215, 53);
            this.txtquantity.TabIndex = 37;
            this.txtquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtamount.Location = new System.Drawing.Point(754, 349);
            this.txtamount.Margin = new System.Windows.Forms.Padding(2);
            this.txtamount.Name = "txtamount";
            this.txtamount.ReadOnly = true;
            this.txtamount.Size = new System.Drawing.Size(215, 53);
            this.txtamount.TabIndex = 39;
            this.txtamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(810, 326);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Total Amount";
            // 
            // txtrevenue
            // 
            this.txtrevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtrevenue.Location = new System.Drawing.Point(754, 448);
            this.txtrevenue.Margin = new System.Windows.Forms.Padding(2);
            this.txtrevenue.Name = "txtrevenue";
            this.txtrevenue.ReadOnly = true;
            this.txtrevenue.Size = new System.Drawing.Size(215, 53);
            this.txtrevenue.TabIndex = 41;
            this.txtrevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(810, 426);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Total Revenue";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(754, 524);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 53);
            this.button4.TabIndex = 43;
            this.button4.Text = "Print Report";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbl_productdetailsTableAdapter
            // 
            this.tbl_productdetailsTableAdapter.ClearBeforeFill = true;
            // 
            // posDataSet5
            // 
            this.posDataSet5.DataSetName = "posDataSet5";
            this.posDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblproductdetailsBindingSource1
            // 
            this.tblproductdetailsBindingSource1.DataMember = "tbl_productdetails";
            this.tblproductdetailsBindingSource1.DataSource = this.posDataSet5;
            // 
            // tbl_productdetailsTableAdapter1
            // 
            this.tbl_productdetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "inv_no";
            this.dataGridViewTextBoxColumn3.HeaderText = "inv_no";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "product_id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 40;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "product_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "product_name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 50;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn5.HeaderText = "price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn6.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 40;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "discount";
            this.dataGridViewTextBoxColumn7.HeaderText = "discount";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 40;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn8.HeaderText = "total";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "purchase_price";
            this.dataGridViewTextBoxColumn9.HeaderText = "purchase_price";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "added_by";
            this.dataGridViewTextBoxColumn10.HeaderText = "added_by";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 40;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "added_date";
            this.dataGridViewTextBoxColumn11.HeaderText = "added_date";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 80;
            // 
            // Sales_Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 602);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtrevenue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnmonth);
            this.Controls.Add(this.btntoday);
            this.Controls.Add(this.dgvsalesanalytics);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dt2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sales_Analytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales_Analytics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sales_Analytics_FormClosed);
            this.Load += new System.EventHandler(this.Sales_Analytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesanalytics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductdetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dgvsalesanalytics;
        private System.Windows.Forms.Button btntoday;
        private System.Windows.Forms.Button btnmonth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtrevenue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addeddateDataGridViewTextBoxColumn;
        private posDataSet3 posDataSet3;
        private System.Windows.Forms.BindingSource tblproductdetailsBindingSource;
        private posDataSet3TableAdapters.tbl_productdetailsTableAdapter tbl_productdetailsTableAdapter;
        private posDataSet5 posDataSet5;
        private System.Windows.Forms.BindingSource tblproductdetailsBindingSource1;
        private posDataSet5TableAdapters.tbl_productdetailsTableAdapter tbl_productdetailsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}