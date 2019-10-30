namespace POS.UI
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvstock = new System.Windows.Forms.DataGridView();
            this.tblstockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posDataSet1 = new POS.posDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.tbl_stockTableAdapter = new POS.posDataSet1TableAdapters.tbl_stockTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtsearch.Location = new System.Drawing.Point(233, 79);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(411, 34);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(148, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // dgvstock
            // 
            this.dgvstock.AllowUserToAddRows = false;
            this.dgvstock.AllowUserToDeleteRows = false;
            this.dgvstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstock.Location = new System.Drawing.Point(48, 139);
            this.dgvstock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvstock.Name = "dgvstock";
            this.dgvstock.ReadOnly = true;
            this.dgvstock.RowTemplate.Height = 24;
            this.dgvstock.Size = new System.Drawing.Size(1199, 545);
            this.dgvstock.TabIndex = 7;
            this.dgvstock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstock_CellContentClick);
            this.dgvstock.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvstock_RowHeaderMouseDoubleClick);
            // 
            // tblstockBindingSource
            // 
            this.tblstockBindingSource.DataMember = "tbl_stock";
            this.tblstockBindingSource.DataSource = this.posDataSet1;
            // 
            // posDataSet1
            // 
            this.posDataSet1.DataSetName = "posDataSet1";
            this.posDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(453, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 48);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stock";
            // 
            // tbl_stockTableAdapter
            // 
            this.tbl_stockTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(961, 63);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(285, 65);
            this.button4.TabIndex = 44;
            this.button4.Text = "Print Stock";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 715);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvstock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Stock_FormClosed);
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvstock;
        private System.Windows.Forms.Label label4;
        private posDataSet1 posDataSet1;
        private System.Windows.Forms.BindingSource tblstockBindingSource;
        private posDataSet1TableAdapters.tbl_stockTableAdapter tbl_stockTableAdapter;
        private System.Windows.Forms.Button button4;
    }
}