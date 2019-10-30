namespace POS.UI.Sales_Man
{
    partial class Sale_Register
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale_Register));
            this.dgvstock = new System.Windows.Forms.DataGridView();
            this.tblstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posDataSet2 = new POS.posDataSet2();
            this._25jan2019LABVPDataSet1 = new POS._25jan2019LABVPDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpaidamount = new System.Windows.Forms.TextBox();
            this.txtchangeamount = new System.Windows.Forms.TextBox();
            this.txtdueamount = new System.Windows.Forms.TextBox();
            this.cmbcustomer = new System.Windows.Forms.ComboBox();
            this.txtcomment = new System.Windows.Forms.TextBox();
            this.dtsalesdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.dgvinvoice = new System.Windows.Forms.DataGridView();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncomplete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txttotal1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbl_stockTableAdapter = new POS.posDataSet2TableAdapters.tbl_stockTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.lblinvoiceno = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._25jan2019LABVPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstock
            // 
            this.dgvstock.AllowUserToAddRows = false;
            this.dgvstock.AllowUserToDeleteRows = false;
            this.dgvstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstock.Location = new System.Drawing.Point(739, 161);
            this.dgvstock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvstock.Name = "dgvstock";
            this.dgvstock.ReadOnly = true;
            this.dgvstock.RowTemplate.Height = 24;
            this.dgvstock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvstock.Size = new System.Drawing.Size(571, 294);
            this.dgvstock.TabIndex = 0;
            this.dgvstock.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvstock_RowHeaderMouseClick);
            // 
            // tblstockBindingSource
            // 
            this.tblstockBindingSource.DataMember = "tbl_stock";
            this.tblstockBindingSource.DataSource = this.posDataSet2;
            // 
            // posDataSet2
            // 
            this.posDataSet2.DataSetName = "posDataSet2";
            this.posDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _25jan2019LABVPDataSet1
            // 
            this._25jan2019LABVPDataSet1.DataSetName = "_25jan2019LABVPDataSet";
            this._25jan2019LABVPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(747, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paid Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(747, 594);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(747, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Return Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(747, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Due Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(747, 633);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sales Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(747, 677);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Comment:";
            // 
            // txtpaidamount
            // 
            this.txtpaidamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtpaidamount.Location = new System.Drawing.Point(900, 473);
            this.txtpaidamount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpaidamount.Name = "txtpaidamount";
            this.txtpaidamount.Size = new System.Drawing.Size(312, 26);
            this.txtpaidamount.TabIndex = 7;
            this.txtpaidamount.TextChanged += new System.EventHandler(this.txtpaidamount_TextChanged);
            // 
            // txtchangeamount
            // 
            this.txtchangeamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtchangeamount.Location = new System.Drawing.Point(900, 555);
            this.txtchangeamount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtchangeamount.Name = "txtchangeamount";
            this.txtchangeamount.ReadOnly = true;
            this.txtchangeamount.Size = new System.Drawing.Size(312, 26);
            this.txtchangeamount.TabIndex = 8;
            this.txtchangeamount.TextChanged += new System.EventHandler(this.txtchangeamount_TextChanged);
            // 
            // txtdueamount
            // 
            this.txtdueamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtdueamount.Location = new System.Drawing.Point(900, 516);
            this.txtdueamount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdueamount.Name = "txtdueamount";
            this.txtdueamount.ReadOnly = true;
            this.txtdueamount.Size = new System.Drawing.Size(312, 26);
            this.txtdueamount.TabIndex = 9;
            this.txtdueamount.TextChanged += new System.EventHandler(this.txtdueamount_TextChanged);
            // 
            // cmbcustomer
            // 
            this.cmbcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbcustomer.FormattingEnabled = true;
            this.cmbcustomer.Location = new System.Drawing.Point(900, 594);
            this.cmbcustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbcustomer.Name = "cmbcustomer";
            this.cmbcustomer.Size = new System.Drawing.Size(312, 28);
            this.cmbcustomer.TabIndex = 10;
            this.cmbcustomer.SelectedIndexChanged += new System.EventHandler(this.cmbcustomer_SelectedIndexChanged);
            // 
            // txtcomment
            // 
            this.txtcomment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtcomment.Location = new System.Drawing.Point(900, 674);
            this.txtcomment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcomment.Multiline = true;
            this.txtcomment.Name = "txtcomment";
            this.txtcomment.Size = new System.Drawing.Size(312, 54);
            this.txtcomment.TabIndex = 11;
            // 
            // dtsalesdate
            // 
            this.dtsalesdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtsalesdate.Location = new System.Drawing.Point(900, 635);
            this.dtsalesdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtsalesdate.Name = "dtsalesdate";
            this.dtsalesdate.Size = new System.Drawing.Size(312, 26);
            this.dtsalesdate.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(765, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Search items:";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtsearch.Location = new System.Drawing.Point(751, 117);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(531, 30);
            this.txtsearch.TabIndex = 13;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(55, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Item Name";
            // 
            // txtitemname
            // 
            this.txtitemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtitemname.Location = new System.Drawing.Point(51, 110);
            this.txtitemname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.ReadOnly = true;
            this.txtitemname.Size = new System.Drawing.Size(203, 30);
            this.txtitemname.TabIndex = 16;
            // 
            // dgvinvoice
            // 
            this.dgvinvoice.AllowUserToAddRows = false;
            this.dgvinvoice.AllowUserToDeleteRows = false;
            this.dgvinvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinvoice.Location = new System.Drawing.Point(52, 187);
            this.dgvinvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvinvoice.Name = "dgvinvoice";
            this.dgvinvoice.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "Delete";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvinvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvinvoice.RowTemplate.Height = 24;
            this.dgvinvoice.Size = new System.Drawing.Size(635, 294);
            this.dgvinvoice.TabIndex = 15;
            this.dgvinvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinvoice_CellContentClick);
            this.dgvinvoice.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvinvoice_CellValueNeeded);
            this.dgvinvoice.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvinvoice_RowHeaderMouseClick);
            this.dgvinvoice.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvinvoice_RowHeaderMouseDoubleClick);
            // 
            // txtdiscount
            // 
            this.txtdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtdiscount.Location = new System.Drawing.Point(219, 550);
            this.txtdiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(312, 26);
            this.txtdiscount.TabIndex = 24;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtsubtotal.Location = new System.Drawing.Point(229, 615);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(424, 34);
            this.txtsubtotal.TabIndex = 23;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txttotal.Location = new System.Drawing.Point(219, 507);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(312, 26);
            this.txttotal.TabIndex = 22;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(67, 550);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Discount:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(67, 507);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 751);
            this.splitter1.TabIndex = 26;
            this.splitter1.TabStop = false;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnclear.Location = new System.Drawing.Point(517, 677);
            this.btnclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(136, 54);
            this.btnclear.TabIndex = 27;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncomplete
            // 
            this.btncomplete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btncomplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btncomplete.Location = new System.Drawing.Point(237, 678);
            this.btncomplete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncomplete.Name = "btncomplete";
            this.btncomplete.Size = new System.Drawing.Size(259, 54);
            this.btncomplete.TabIndex = 28;
            this.btncomplete.Text = "Complete Sale and Print";
            this.btncomplete.UseVisualStyleBackColor = false;
            this.btncomplete.Click += new System.EventHandler(this.btncomplete_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnsave.Location = new System.Drawing.Point(83, 677);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(136, 54);
            this.btnsave.TabIndex = 29;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(533, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(292, 48);
            this.label11.TabIndex = 30;
            this.label11.Text = "Sales Register";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(275, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Price";
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtprice.Location = new System.Drawing.Point(271, 110);
            this.txtprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(121, 30);
            this.txtprice.TabIndex = 31;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(555, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "Total";
            // 
            // txttotal1
            // 
            this.txttotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txttotal1.Location = new System.Drawing.Point(549, 110);
            this.txttotal1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotal1.Name = "txttotal1";
            this.txttotal1.ReadOnly = true;
            this.txttotal1.Size = new System.Drawing.Size(136, 30);
            this.txttotal1.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(419, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "Quantity";
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtquantity.Location = new System.Drawing.Point(416, 110);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(119, 30);
            this.txtquantity.TabIndex = 35;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnadd.Location = new System.Drawing.Point(373, 146);
            this.btnadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(144, 34);
            this.btnadd.TabIndex = 37;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.ForeColor = System.Drawing.Color.Crimson;
            this.label16.Location = new System.Drawing.Point(85, 619);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 25);
            this.label16.TabIndex = 38;
            this.label16.Text = "Total Payable:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.Location = new System.Drawing.Point(541, 146);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 34);
            this.button5.TabIndex = 42;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbl_stockTableAdapter
            // 
            this.tbl_stockTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(1111, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 29);
            this.label10.TabIndex = 43;
            this.label10.Text = "Invoice No: ";
            // 
            // lblinvoiceno
            // 
            this.lblinvoiceno.AutoSize = true;
            this.lblinvoiceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblinvoiceno.Location = new System.Drawing.Point(1253, 32);
            this.lblinvoiceno.Name = "lblinvoiceno";
            this.lblinvoiceno.Size = new System.Drawing.Size(0, 29);
            this.lblinvoiceno.TabIndex = 44;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Sale_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 751);
            this.Controls.Add(this.lblinvoiceno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txttotal1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncomplete);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtitemname);
            this.Controls.Add(this.dgvinvoice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dtsalesdate);
            this.Controls.Add(this.txtcomment);
            this.Controls.Add(this.cmbcustomer);
            this.Controls.Add(this.txtdueamount);
            this.Controls.Add(this.txtchangeamount);
            this.Controls.Add(this.txtpaidamount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvstock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sale_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale_Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sale_Register_FormClosed);
            this.Load += new System.EventHandler(this.Sale_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._25jan2019LABVPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstock;
        private _25jan2019LABVPDataSet _25jan2019LABVPDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpaidamount;
        private System.Windows.Forms.TextBox txtchangeamount;
        private System.Windows.Forms.TextBox txtdueamount;
        private System.Windows.Forms.ComboBox cmbcustomer;
        private System.Windows.Forms.TextBox txtcomment;
        private System.Windows.Forms.DateTimePicker dtsalesdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.DataGridView dgvinvoice;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncomplete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txttotal1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private posDataSet2 posDataSet2;
        private System.Windows.Forms.BindingSource tblstockBindingSource;
        private posDataSet2TableAdapters.tbl_stockTableAdapter tbl_stockTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblinvoiceno;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}