namespace POS.UI
{
    partial class Manage_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Products));
            this.label8 = new System.Windows.Forms.Label();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtretailprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpurchaseprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.dgvmanageproducts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.colourcode = new System.Windows.Forms.Label();
            this.txtcolourcode = new System.Windows.Forms.TextBox();
            this.txtcatagory = new System.Windows.Forms.ComboBox();
            this.txtsupplier = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtmaxdiscount = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanageproducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label8.Location = new System.Drawing.Point(625, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Product ID";
            // 
            // txtproductid
            // 
            this.txtproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtproductid.Location = new System.Drawing.Point(705, 105);
            this.txtproductid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.ReadOnly = true;
            this.txtproductid.Size = new System.Drawing.Size(169, 26);
            this.txtproductid.TabIndex = 0;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnupdate.Location = new System.Drawing.Point(708, 505);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(85, 31);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Crimson;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btndelete.Location = new System.Drawing.Point(799, 505);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 31);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnadd.Location = new System.Drawing.Point(626, 505);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 31);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(636, 462);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Quantity";
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtquantity.Location = new System.Drawing.Point(706, 461);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(169, 26);
            this.txtquantity.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.Location = new System.Drawing.Point(655, 416);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(618, 372);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Retail Price";
            // 
            // txtretailprice
            // 
            this.txtretailprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtretailprice.Location = new System.Drawing.Point(706, 370);
            this.txtretailprice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtretailprice.Name = "txtretailprice";
            this.txtretailprice.Size = new System.Drawing.Size(169, 26);
            this.txtretailprice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(596, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Purchase Price";
            // 
            // txtpurchaseprice
            // 
            this.txtpurchaseprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtpurchaseprice.Location = new System.Drawing.Point(706, 324);
            this.txtpurchaseprice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpurchaseprice.Name = "txtpurchaseprice";
            this.txtpurchaseprice.Size = new System.Drawing.Size(169, 26);
            this.txtpurchaseprice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(638, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(599, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Product Name";
            // 
            // txtproductname
            // 
            this.txtproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtproductname.Location = new System.Drawing.Point(705, 148);
            this.txtproductname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(169, 26);
            this.txtproductname.TabIndex = 1;
            // 
            // dgvmanageproducts
            // 
            this.dgvmanageproducts.AllowUserToAddRows = false;
            this.dgvmanageproducts.AllowUserToDeleteRows = false;
            this.dgvmanageproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmanageproducts.Location = new System.Drawing.Point(21, 99);
            this.dgvmanageproducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvmanageproducts.Name = "dgvmanageproducts";
            this.dgvmanageproducts.ReadOnly = true;
            this.dgvmanageproducts.RowTemplate.Height = 24;
            this.dgvmanageproducts.Size = new System.Drawing.Size(553, 446);
            this.dgvmanageproducts.TabIndex = 21;
            this.dgvmanageproducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmanageproducts_CellContentClick);
            this.dgvmanageproducts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvmanageproducts_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(253, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 39);
            this.label2.TabIndex = 20;
            this.label2.Text = "Manage Products";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(156, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Search:";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtsearch.Location = new System.Drawing.Point(214, 61);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(273, 26);
            this.txtsearch.TabIndex = 12;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label9.Location = new System.Drawing.Point(636, 282);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "Catagary";
            // 
            // colourcode
            // 
            this.colourcode.AutoSize = true;
            this.colourcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.colourcode.Location = new System.Drawing.Point(600, 193);
            this.colourcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.colourcode.Name = "colourcode";
            this.colourcode.Size = new System.Drawing.Size(93, 18);
            this.colourcode.TabIndex = 44;
            this.colourcode.Text = "Colour Code";
            // 
            // txtcolourcode
            // 
            this.txtcolourcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtcolourcode.Location = new System.Drawing.Point(706, 191);
            this.txtcolourcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcolourcode.Name = "txtcolourcode";
            this.txtcolourcode.Size = new System.Drawing.Size(169, 26);
            this.txtcolourcode.TabIndex = 2;
            // 
            // txtcatagory
            // 
            this.txtcatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtcatagory.FormattingEnabled = true;
            this.txtcatagory.Location = new System.Drawing.Point(706, 278);
            this.txtcatagory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcatagory.Name = "txtcatagory";
            this.txtcatagory.Size = new System.Drawing.Size(168, 28);
            this.txtcatagory.TabIndex = 4;
            // 
            // txtsupplier
            // 
            this.txtsupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtsupplier.FormattingEnabled = true;
            this.txtsupplier.Location = new System.Drawing.Point(707, 234);
            this.txtsupplier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsupplier.Name = "txtsupplier";
            this.txtsupplier.Size = new System.Drawing.Size(168, 28);
            this.txtsupplier.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtmaxdiscount
            // 
            this.txtmaxdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtmaxdiscount.FormattingEnabled = true;
            this.txtmaxdiscount.Items.AddRange(new object[] {
            "Drum",
            "Gallon",
            "Quarter",
            "Other"});
            this.txtmaxdiscount.Location = new System.Drawing.Point(705, 411);
            this.txtmaxdiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtmaxdiscount.Name = "txtmaxdiscount";
            this.txtmaxdiscount.Size = new System.Drawing.Size(168, 28);
            this.txtmaxdiscount.TabIndex = 45;
            // 
            // Manage_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 562);
            this.Controls.Add(this.txtmaxdiscount);
            this.Controls.Add(this.txtsupplier);
            this.Controls.Add(this.txtcatagory);
            this.Controls.Add(this.colourcode);
            this.Controls.Add(this.txtcolourcode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtretailprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpurchaseprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.dgvmanageproducts);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Manage_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Products";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Manage_Products_FormClosed);
            this.Load += new System.EventHandler(this.Manage_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanageproducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtretailprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpurchaseprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.DataGridView dgvmanageproducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label colourcode;
        private System.Windows.Forms.TextBox txtcolourcode;
        private System.Windows.Forms.ComboBox txtcatagory;
        private System.Windows.Forms.ComboBox txtsupplier;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox txtmaxdiscount;
    }
}