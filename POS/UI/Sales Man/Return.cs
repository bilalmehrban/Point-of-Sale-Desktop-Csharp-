using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.BLL;
using POS.DAL;

namespace POS.UI.Sales_Man
{
     
    public partial class Return : Form
    {
        private static Return _instance;

        public static Return instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Return();
                return _instance;
            }
        }
        product_detailsdal dal = new product_detailsdal();
        product_detailsbll bll = new product_detailsbll();
        invoicedal dal1 = new invoicedal();
        invoicebll bll1 = new invoicebll();
        Manage_Productsdal dal2 = new Manage_Productsdal();
        Manage_Productsbll bll2 = new Manage_Productsbll();

        public Return()
        {
            InitializeComponent();
        }

        private void Return_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        double quantity;
        decimal quantity1;
        int pid, id;

        bool update = false;
        bool updatere = false;
        double pa, da, ca , tp;
        double a, b, d;
        private void dgvinvoice_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ri = e.RowIndex;
            quantity = Convert.ToDouble(dgvinvoice.Rows[ri].Cells[5].Value);
            if (quantity <= 0)
            {
                bll.id = Convert.ToInt32(dgvinvoice.Rows[ri].Cells[0].Value);
                dal.delete(bll);
            }

            
            pid =Convert.ToInt32(dgvinvoice.Rows[ri].Cells[1].Value);
       
            quantity1 = 1;
            dal2.IncreaseProduct(pid,quantity1);

            id = Convert.ToInt32(dgvinvoice.Rows[ri].Cells[0].Value);
            dal.DecreaseProduct(id, quantity1);

            



           
            double sum = 0;
            string inv_no = txtsearch.Text;
           
                //Show user based on keywords
                DataTable dt = dal.Search(inv_no);
                dgvinvoice.DataSource = dt;

            if (!update)
            {
                try
                {
                    update = true;
                    
                    //To calculate total from table
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        a = Convert.ToDouble(dt.Rows[i][4]);
                        b = Convert.ToDouble(dt.Rows[i][5]);
                        sum = sum + (a * b);
                    }
                    txttotal.Text = sum.ToString();
                    d = Convert.ToDouble(txtdiscount.Text);
                    txtsubtotal.Text = (sum - ((sum * d) / 100)).ToString();
                }
                finally
                {
                    update = false;
                }
            }
            
                DataTable dt1 = dal1.Search(inv_no);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    txtdiscount.Text = dt1.Rows[i][4].ToString();
                    pa =Convert.ToDouble( dt1.Rows[i][3]);
                    da = Convert.ToDouble(dt1.Rows[i][5]);
                    ca = Convert.ToDouble(dt1.Rows[i][6]);
                    tp = Convert.ToDouble( dt1.Rows[i][2]);
                    cmbcustomer.Text = dt1.Rows[i][1].ToString();
                    dtsalesdate.Text = dt1.Rows[i][7].ToString();
                }

            if(!updatere)
            {
                try
                {
                    updatere = true;
                    if (pa == 0)
                    {
                        txtpaidamount.Text = "0";
                        txtdueamount.Text = (da - (tp - (Convert.ToDouble(txtsubtotal.Text)))).ToString();
                        txtchangeamount.Text = "0";
                    }
                    if(pa > 0)
                    {
                        if(da == 0)
                        {
                            txtchangeamount.Text = (ca + (tp - (Convert.ToDouble(txtsubtotal.Text)))).ToString();
                            txtdueamount.Text = "0";
                        }
                        if (da < (tp - (Convert.ToDouble(txtsubtotal.Text))))
                        {
                            txtchangeamount.Text = (ca + ((tp - (Convert.ToDouble(txtsubtotal.Text))) - da)).ToString();
                            txtdueamount.Text = "0";
                        }
                        if (da > (tp - (Convert.ToDouble(txtsubtotal.Text))))
                        {
                            txtdueamount.Text = (da - (tp - (Convert.ToDouble(txtsubtotal.Text)))).ToString();
                            txtchangeamount.Text = "0";
                        }
                    }

                }
                finally
                {
                    updatere = false;
                }
              }

            }

        

        private void dgvinvoice_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ri = e.RowIndex;
            quantity = Convert.ToDouble(dgvinvoice.Rows[ri].Cells[5].Value);
            bll.id = Convert.ToInt32(dgvinvoice.Rows[ri].Cells[0].Value);
            dal.delete(bll);

            pid = Convert.ToInt32(dgvinvoice.Rows[ri].Cells[1].Value);

            quantity1 =Convert.ToDecimal( quantity);
            dal2.IncreaseProduct(pid, quantity1);

            id = Convert.ToInt32(dgvinvoice.Rows[ri].Cells[0].Value);
            dal.DecreaseProduct(id, quantity1);

            double sum = 0;
            string inv_no = txtsearch.Text;

            //Show user based on keywords
            DataTable dt = dal.Search(inv_no);
            dgvinvoice.DataSource = dt;

            if (!update)
            {
                try
                {
                    update = true;

                    //To calculate total from table
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        a = Convert.ToDouble(dt.Rows[i][4]);
                        b = Convert.ToDouble(dt.Rows[i][5]);
                        sum = sum + (a * b);
                    }
                    txttotal.Text = sum.ToString();
                    d = Convert.ToDouble(txtdiscount.Text);
                    txtsubtotal.Text = (sum - ((sum * d) / 100)).ToString();
                }
                finally
                {
                    update = false;
                }
            }

            DataTable dt1 = dal1.Search(inv_no);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                txtdiscount.Text = dt1.Rows[i][4].ToString();
                pa = Convert.ToDouble(dt1.Rows[i][3]);
                da = Convert.ToDouble(dt1.Rows[i][5]);
                ca = Convert.ToDouble(dt1.Rows[i][6]);
                tp = Convert.ToDouble(dt1.Rows[i][2]);
                cmbcustomer.Text = dt1.Rows[i][1].ToString();
                dtsalesdate.Text = dt1.Rows[i][7].ToString();
            }

            if (!updatere)
            {
                try
                {
                    updatere = true;
                    if (pa == 0)
                    {
                        txtpaidamount.Text = "0";
                        txtdueamount.Text = (da - (tp - (Convert.ToDouble(txtsubtotal.Text)))).ToString();
                        txtchangeamount.Text = "0";
                    }
                    if (pa > 0)
                    {
                        if (da == 0)
                        {
                            txtchangeamount.Text = (ca + (tp - (Convert.ToDouble(txtsubtotal.Text)))).ToString();
                            txtdueamount.Text = "0";
                        }
                        if (da < (tp - (Convert.ToDouble(txtsubtotal.Text))))
                        {
                            txtchangeamount.Text = (ca + ((tp - (Convert.ToDouble(txtsubtotal.Text))) - da)).ToString();
                            txtdueamount.Text = "0";
                        }
                        if (da > (tp - (Convert.ToDouble(txtsubtotal.Text))))
                        {
                            txtdueamount.Text = (da - (tp - (Convert.ToDouble(txtsubtotal.Text)))).ToString();
                            txtchangeamount.Text = "0";
                        }
                    }

                }
                finally
                {
                    updatere = false;
                }
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string inv_no = txtsearch.Text;
            if (inv_no != null)
            {
                //Show user based on keywords
                DataTable dt = dal.Search(inv_no);
                dgvinvoice.DataSource = dt;

                double sum = 0;
                //To calculate total from table
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    a = Convert.ToDouble(dt.Rows[i][4]);
                    b = Convert.ToDouble(dt.Rows[i][5]);
                    sum = sum + (a * b);
                }
                txttotal.Text = sum.ToString();

                DataTable dt1 = dal1.Search(inv_no);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    txtdiscount.Text = dt1.Rows[i][4].ToString();
                    txtsubtotal.Text = dt1.Rows[i][2].ToString();
                    txtpaidamount.Text = dt1.Rows[i][3].ToString();
                    txtdueamount.Text = dt1.Rows[i][5].ToString();
                    txtchangeamount.Text = dt1.Rows[i][6].ToString();
                    cmbcustomer.Text = dt1.Rows[i][1].ToString();
                    dtsalesdate.Text = dt1.Rows[i][7].ToString();
                }

            }
        }
        ////boolean type variable for succes
        //bool sucess1 = false;
        bool x = false;
        decimal quantity11;
        double t1, t2, p, q;
        private void btnsave_Click(object sender, EventArgs e)
        {
             if(Validation1())
             {
                string inv_no = txtsearch.Text;
                DataTable dt1 = dal1.Search(inv_no);
                //Show user based on keywords
                DataTable dt = dal.Search(inv_no);
                if (dgvinvoice.Rows.Count == 0)
                {
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        bll1.id = Convert.ToInt32(dt1.Rows[i][0]);
                    }
                    bool x = false;
                    x = dal1.delete(bll1);
                    if(x == true)
                    {
                        MessageBox.Show("Data Deleted Succesfully");

                        //Celar the Data Grid View and Clear all the TExtboxes
                        dgvinvoice.DataSource = null;
                        dgvinvoice.Rows.Clear();

                        txttotal.Text = "";
                        txtdiscount.Text = "";
                        txtsubtotal.Text = "";
                        txtpaidamount.Text = "";
                        txtdueamount.Text = "";
                        txtchangeamount.Text = "";
                        cmbcustomer.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error in deleting data");
                    }
                }
                else
                {
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        bll1.id = Convert.ToInt32(dt1.Rows[i][0]);
                        bll1.added_by =Convert.ToInt32( dt1.Rows[i][8]);
                        bll1.inv_no = Convert.ToInt32(dt1.Rows[i][9]);
                    }
                    bll1.customer_name = cmbcustomer.Text;
                    bll1.total_payable = txtsubtotal.Text;
                    bll1.paid_amount = txtpaidamount.Text;
                    bll1.discount = txtdiscount.Text;
                    bll1.due_amount = txtdueamount.Text;
                    bll1.change_amount = txtchangeamount.Text;
                    bll1.sales_date =Convert.ToDateTime( dtsalesdate.Text);
                    //Inserting Data into DAtabase
                    bool w = dal1.update(bll1);
                    

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        
                        //Get the Product name and convert it to id
                        bll.id =Convert.ToInt32( dt.Rows[i][0]) ;
                        bll.product_id = Convert.ToInt32(dt.Rows[i][1]);
                        bll.product_name = dt.Rows[i][3].ToString();
                        bll.price = dt.Rows[i][4].ToString();
                        bll.quantity = dt.Rows[i][5].ToString();
                        bll.discount = txtdiscount.Text;
                        bll.inv_no = dt.Rows[i][2].ToString();
                        bll.type = dt.Rows[i][9].ToString();
                        quantity11 = Convert.ToDecimal(bll.quantity);
                        q = Convert.ToDouble(dt.Rows[i][5]);

                        //Method to get purchase price an multiply it with quantity
                        Manage_Productsbll price = dal2.GetProductpriceFromId((dt.Rows[i][1]).ToString());
                        p = Convert.ToDouble ((Convert.ToDouble(price.purchase_price)) * q);
                        bll.purchase_price = p.ToString();

                        //Getting total value by calculating discount
                        t1 = Convert.ToDouble(txtdiscount.Text);
                        t2 = Convert.ToDouble(dt.Rows[i][4]) * q;
                        bll.total = (t2 - (t2 * t1) / 100).ToString();

                        bll.added_by =Convert.ToInt32( dt.Rows[i][10]);
                        bll.added_date = Convert.ToDateTime(dtsalesdate.Text);

                        // Inserting Data into DAtabase
                        x = dal.update(bll);
                        //sucess1 = w && x;
                    }

                    if (w == true && x == true)
                    {


                        MessageBox.Show("Data Updated Succesfullay");

                        //Celar the Data Grid View and Clear all the TExtboxes
                        dgvinvoice.DataSource = null;
                        dgvinvoice.Rows.Clear();

                        txttotal.Text = "";
                        txtdiscount.Text = "";
                        txtsubtotal.Text = "";
                        txtpaidamount.Text = "";
                        txtdueamount.Text = "";
                        txtchangeamount.Text = "";
                        cmbcustomer.Text = "";
                        
                    }
                    else
                    {
                        //Transaction Failed
                        MessageBox.Show("Failed to update");
                    }
                }
            }
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validation1()
        {
            bool result = false;
            if (String.IsNullOrEmpty(txtsubtotal.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtsubtotal, "Total Payable required");
            }
            else if (String.IsNullOrEmpty(cmbcustomer.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cmbcustomer, "Customer name required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

    }
}
