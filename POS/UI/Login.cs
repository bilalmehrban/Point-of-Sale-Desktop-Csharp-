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
using POS.UI.Sales_Man;

namespace POS.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        loginbll u = new loginbll();
        logindal dal = new logindal();
        public static string loggedIn;

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Checking if text boxes are empty or null
            if (Validation())
            {
                //Gettting Data FRom UI
                u.user_name = txtusername.Text.Trim();
                u.password = txtpassword.Text.Trim();
                u.user_type = txtusertype.Text.Trim();
                //Checking the login credentials
                bool check = dal.login(u);
                if (check == true)
                {
                    //Login Successfull
                    loggedIn = u.user_name;
                    //Need to open Respective Forms based on User Type
                    switch (u.user_type)
                    {
                        case "Admin":
                            {
                                //Display Admin Dashboard
                                Main admin = new Main();
                                admin.Show();
                                this.Hide();

                            }
                            break;
                        case "Sales Man":
                            {
                                //Display SalesMan Dashboard
                                mainform obj = new mainform();
                                obj.Show();
                                this.Hide();
                            }
                            break;
                        default:
                            {
                                //Display an error message
                                MessageBox.Show("Invalid user type");
                            }
                            break;
                    }
                }

                else
                {
                    //login Failed
                    MessageBox.Show("Incorrect Credentials");
                }
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
            else if (String.IsNullOrEmpty(txtpassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtpassword, "Password Required");
            }
            else if (String.IsNullOrEmpty(txtusertype.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtusertype, "User Type Required");
            }
            else
            {
                errorProvider1.Clear();
                result = true;
            }
            return result;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
