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
    public partial class Users : Form
    {
        private static Users _instance;

        public static Users instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Users();
                return _instance;
            }
        }
        public Users()
        {
            InitializeComponent();
        }


        usersbll u = new usersbll();
        userdal dal = new userdal();
        

        private void button1_Click(object sender, EventArgs e)
        {
        //Checking if text boxes are empty or null
        if(Validation())
        {
            //Gettting Data FRom UI
            
            u.user_name = txtusername.Text;
            u.user_type = txtusertype.Text;
            u.password = txtpassword.Text;
            u.email = txtemail.Text;
            u.cnic = txtcnic.Text;
            u.adress = txtaddress.Text;
            u.phone_no = txtphoneno.Text; 
            //u.added_by = 1;
            u.added_date = DateTime.Now;

            //Getting Username of the logged in user
            string loggedUser = Login.loggedIn;
            usersbll usr = dal.GetIDFromUsername(loggedUser);

            u.added_by = usr.id;

            //Inserting Data into DAtabase
            bool check1 = dal.exist(u);

            //Checking if Product Already Exist
            if(check1 == true)
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
                        dgvusers.DataSource = dt1;
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
            dgvusers.DataSource = dt;
          }
        }

        //Function to clear text bocxes after insert,update or delete data
        private void clear()
        {
            txtusername.Text = "";
            txtusertype.Text = "";
            txtpassword.Text = "";
            txtemail.Text = "";
            txtcnic.Text = "";
            txtaddress.Text = "";
            txtphoneno.Text = "";
        }

        private void Users_Load(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of particular row
            int ri = e.RowIndex;
            txtid.Text = dgvusers.Rows[ri].Cells[0].Value.ToString();
            txtusername.Text = dgvusers.Rows[ri].Cells[1].Value.ToString();
            txtusertype.Text = dgvusers.Rows[ri].Cells[2].Value.ToString();
            txtpassword.Text = dgvusers.Rows[ri].Cells[3].Value.ToString();
            txtemail.Text = dgvusers.Rows[ri].Cells[4].Value.ToString();
            txtcnic.Text = dgvusers.Rows[ri].Cells[5].Value.ToString();
            txtaddress.Text = dgvusers.Rows[ri].Cells[6].Value.ToString();
            txtphoneno.Text = dgvusers.Rows[ri].Cells[7].Value.ToString();
        }

        private void Users_Load_1(object sender, EventArgs e)
        {
            //To load data in DataGridView
            DataTable dt = dal.select();
            dgvusers.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Checking if text boxes are empty or null
            if (Validation())
            {
                //Gettting Data FRom UI
                u.id = Convert.ToInt32(txtid.Text);
                u.user_name = txtusername.Text;
                u.user_type = txtusertype.Text;
                u.password = txtpassword.Text;
                u.email = txtemail.Text;
                u.cnic = txtcnic.Text;
                u.adress = txtaddress.Text;
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
                dgvusers.DataSource = dt;
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
                    dgvusers.DataSource = dt;
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
                dgvusers.DataSource = dt;
            }
            else
            {
                //show all users from the database
                DataTable dt = dal.select();
                dgvusers.DataSource = dt;
            }
        }

        //Function to check if Text Boxes are Empty or null
        private bool Validation()
        {
            bool result = false;
            if (String.IsNullOrEmpty(txtusername.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtusername, "User Name Required");
            }
            else if (String.IsNullOrEmpty(txtusertype.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtusertype, "User Type Required");
            }
            else if (String.IsNullOrEmpty(txtpassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtpassword, "Password Required");
            }
            else if (String.IsNullOrEmpty(txtaddress.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtaddress, "User AddressRequired");
            }
            else if (String.IsNullOrEmpty(txtphoneno.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtphoneno, "User Contact No Required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
