using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.BLL;
using POS.DAL;

namespace POS.UI
{
    public partial class Catagories : Form
    {
        private static Catagories _instance;

        public static Catagories instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Catagories();
                return _instance;
            }
        }
        public Catagories()
        {
            InitializeComponent();
            fillcombo();
        }

        Catagoriesbll u = new Catagoriesbll();
        Catagoriesdal dal = new Catagoriesdal();
        userdal da = new userdal();

        private void Catagories_Load(object sender, EventArgs e)
        {
            //To load data in DataGridView
            DataTable dt = dal.select();
            dgvcatagories.DataSource = dt;
        }

        private void dgvcatagories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //Checking if text boxes are empty or null
            if (Validation())
            {
                //Gettting Data FRom UI
                
                u.catagory = txtcatagory.Text;
                u.supplier = txtsupplier.Text;
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
                        dgvcatagories.DataSource = dt1;
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
                dgvcatagories.DataSource = dt;
            }
        }

        //Function to clear text bocxes after insert,update or delete data
        private void clear()
        {
            txtcatagory.Text = "";
            txtsupplier.Text = "";
        }

        private void dgvcatagories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of particular row
            int ri = e.RowIndex;
            txtid.Text = dgvcatagories.Rows[ri].Cells[0].Value.ToString();
            txtcatagory.Text = dgvcatagories.Rows[ri].Cells[1].Value.ToString();
            txtsupplier.Text = dgvcatagories.Rows[ri].Cells[2].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //Checking if text boxes are empty or null
            if (Validation())
            {
                //Gettting Data FRom UI
                u.id = Convert.ToInt32(txtid.Text);
                u.catagory = txtcatagory.Text;
                u.supplier = txtsupplier.Text;
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
                dgvcatagories.DataSource = dt;
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
                    dgvcatagories.DataSource = dt;
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
                dgvcatagories.DataSource = dt;
            }
            else
            {
                //show all users from the database
                DataTable dt = dal.select();
                dgvcatagories.DataSource = dt;
            }
        }

        //Function to check if Text Boxes are Empty or null
        private bool Validation()
        {
            bool result = false;
            if (String.IsNullOrEmpty(txtcatagory.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtcatagory, "Catagory Required");
            }
            else if (String.IsNullOrEmpty(txtsupplier.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtsupplier, "Supplier Required");
            }
            
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        #region fill combo box data
        public bool fillcombo()
        {
            bool issucess = false;
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            try
            {
                string query = "select* from tbl_suppliers";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader myreader;
                conn.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(1);
                    txtsupplier.Items.Add(sname);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return issucess;
        }
        #endregion

        private void Catagories_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void txtsupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


    }
}
