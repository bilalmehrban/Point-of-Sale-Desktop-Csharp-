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

namespace POS.UI
{
    public partial class Suppliers : Form
    {
        private static Suppliers _instance;

        public static Suppliers instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Suppliers();
                return _instance;
            }
        }
        public Suppliers()
        {
            InitializeComponent();
        }
        suppliersbll u = new suppliersbll();
        suppliersdal dal = new suppliersdal();
        userdal da = new userdal();


        private void Suppliers_Load(object sender, EventArgs e)
        {
            //To load data in DataGridView
            DataTable dt = dal.select();
            dgvsuppliers.DataSource = dt;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //Checking if text boxes are empty or null
            if (Validation())
            {
                //Gettting Data FRom UI
                
                u.user_name = txtusername.Text;
                u.email = txtemail.Text;
                u.company = txtcompany.Text;
                u.adress = txtadress.Text;
                u.phone_no = txtphoneno.Text;
                //u.added_by = 1;
                u.added_date = DateTime.Now;

                //Getting Username of the logged in user
                string loggedUser = Login.loggedIn;
                usersbll usr = da.GetIDFromUsername(loggedUser);

                u.added_by = usr.id;
                //Inserting Data into DAtabase
                bool check1 = dal.exist(u);
                //Checking if Product Already Exist
                if (check1 == true)
                {
                    //Showing MessageBox
                    DialogResult = MessageBox.Show("Product already exist do you want to update", "Message", MessageBoxButtons.YesNo);
                    if (DialogResult == DialogResult.Yes)
                    {
                        u.id = Convert.ToInt32(txtid.Text);
                        //Update Data in DataBase
                        bool check = dal.update(u);
                        if (check == true)
                        {
                            MessageBox.Show("Record updated successfully");
                            clear();
                        }
                        else
                        {
                            MessageBox.Show("error");
                        }
                        //Refreshing Data Grid View
                        DataTable dt1 = dal.select();
                        dgvsuppliers.DataSource = dt1;
                    }
                }
                else
                {
                    //Inserting data in DataBase
                    bool check = dal.insert(u);
                    if (check == true)
                    {
                        MessageBox.Show("user data added successfully");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("error");
                    }
                }
                //Refreshing Data Grid View
                DataTable dt = dal.select();
                dgvsuppliers.DataSource = dt;
            }
        }

        //Function to clear text bocxes after insert,update or delete data
        private void clear()
        {
            txtusername.Text = "";
            txtemail.Text = "";
            txtcompany.Text = "";
            txtadress.Text = "";
            txtphoneno.Text = "";
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //Checking if text boxes are empty or null
            if (Validation())
            {
                //Gettting Data FRom UI
                u.id = Convert.ToInt32(txtid.Text);
                u.user_name = txtusername.Text;
                u.email = txtemail.Text;
                u.company = txtcompany.Text;
                u.adress = txtadress.Text;
                u.phone_no = txtphoneno.Text;
                
                //Updating Data into database
                bool check = dal.update(u);
                if (check == true)
                {
                    MessageBox.Show("record updated successfully");
                    clear();
                }
                else
                {
                    MessageBox.Show("error");
                }

                //Refreshing Data Grid View
                DataTable dt = dal.select();
                dgvsuppliers.DataSource = dt;
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if(Validation())
            {
                //Showing Dialog Box to get yes or no result
                DialogResult = MessageBox.Show("Are You Want to delete", "Message", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    //Getting User ID from Form
                    u.id = Convert.ToInt32(txtid.Text);
                    //Deleting Data From DataBase
                    bool check = dal.delete(u);
                    if (check == true)
                    {
                        MessageBox.Show("Record deleted sucessfully");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Record not deleted");
                    }
                    //refreshing Datagrid view
                    DataTable dt = dal.select();
                    dgvsuppliers.DataSource = dt;
                }
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //Get Keyword from Text box
            string keyword = txtsearch.Text;
            //Check if the keywords has value or not
            if (keyword != null)
            {
                //Show user based on keywords
                DataTable dt = dal.Search(keyword);
                dgvsuppliers.DataSource = dt;
            }
            else
            {
                //show all users from the database
                DataTable dt = dal.select();
                dgvsuppliers.DataSource = dt;
            }
        }

        private void dgvsuppliers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of particular row
            int ri = e.RowIndex;
            txtid.Text = dgvsuppliers.Rows[ri].Cells[0].Value.ToString();
            txtusername.Text = dgvsuppliers.Rows[ri].Cells[1].Value.ToString();
            txtemail.Text = dgvsuppliers.Rows[ri].Cells[2].Value.ToString();
            txtcompany.Text = dgvsuppliers.Rows[ri].Cells[3].Value.ToString();
            txtadress.Text = dgvsuppliers.Rows[ri].Cells[4].Value.ToString();
            txtphoneno.Text = dgvsuppliers.Rows[ri].Cells[5].Value.ToString();
        }

        //Function to check if Text Boxes are Empty or null
        private bool Validation()
        {
            bool result = false;
            if (String.IsNullOrEmpty(txtusername.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtusername, "Product Name Required");
            }
            else if (String.IsNullOrEmpty(txtcompany.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtcompany, "Product Catagory Required");
            }
            else if (String.IsNullOrEmpty(txtadress.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtadress, "Purchase Price Required");
            }
            else if (String.IsNullOrEmpty(txtphoneno.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtphoneno, "Retail Price Required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }
        private void Suppliers_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
