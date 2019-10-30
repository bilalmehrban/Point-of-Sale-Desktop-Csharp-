namespace POS.UI
{
    partial class Catagories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catagories));
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcatagory = new System.Windows.Forms.TextBox();
            this.dgvcatagories = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtsupplier = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcatagories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtsearch.Location = new System.Drawing.Point(255, 89);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(411, 34);
            this.txtsearch.TabIndex = 59;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnupdate.Location = new System.Drawing.Point(946, 587);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(110, 38);
            this.btnupdate.TabIndex = 58;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.Crimson;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btndel.Location = new System.Drawing.Point(1062, 587);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(100, 38);
            this.btndel.TabIndex = 57;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label8.Location = new System.Drawing.Point(902, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 24);
            this.label8.TabIndex = 56;
            this.label8.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtid.Location = new System.Drawing.Point(946, 331);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(224, 30);
            this.txtid.TabIndex = 55;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.btnadd.Location = new System.Drawing.Point(835, 587);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 38);
            this.btnadd.TabIndex = 54;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(860, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(845, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Catagory";
            // 
            // txtcatagory
            // 
            this.txtcatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtcatagory.Location = new System.Drawing.Point(946, 383);
            this.txtcatagory.Name = "txtcatagory";
            this.txtcatagory.Size = new System.Drawing.Size(224, 30);
            this.txtcatagory.TabIndex = 44;
            // 
            // dgvcatagories
            // 
            this.dgvcatagories.AllowUserToAddRows = false;
            this.dgvcatagories.AllowUserToDeleteRows = false;
            this.dgvcatagories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcatagories.Location = new System.Drawing.Point(48, 137);
            this.dgvcatagories.Name = "dgvcatagories";
            this.dgvcatagories.ReadOnly = true;
            this.dgvcatagories.RowTemplate.Height = 24;
            this.dgvcatagories.Size = new System.Drawing.Size(740, 550);
            this.dgvcatagories.TabIndex = 43;
            this.dgvcatagories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcatagories_CellContentClick);
            this.dgvcatagories.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcatagories_RowHeaderMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(543, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 48);
            this.label2.TabIndex = 42;
            this.label2.Text = "Catagories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(142, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "Search by:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtsupplier
            // 
            this.txtsupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtsupplier.FormattingEnabled = true;
            this.txtsupplier.Location = new System.Drawing.Point(946, 443);
            this.txtsupplier.Name = "txtsupplier";
            this.txtsupplier.Size = new System.Drawing.Size(224, 33);
            this.txtsupplier.TabIndex = 61;
            this.txtsupplier.SelectedIndexChanged += new System.EventHandler(this.txtsupplier_SelectedIndexChanged);
            // 
            // Catagories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 704);
            this.Controls.Add(this.txtsupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcatagory);
            this.Controls.Add(this.dgvcatagories);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Catagories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catagories";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Catagories_FormClosed);
            this.Load += new System.EventHandler(this.Catagories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcatagories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcatagory;
        private System.Windows.Forms.DataGridView dgvcatagories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox txtsupplier;
    }
}