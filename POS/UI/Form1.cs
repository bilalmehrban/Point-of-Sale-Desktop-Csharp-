using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.UI;
using POS.UI.Sales_Man;

namespace POS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ShowForm(Form f)
        {
            f.MdiParent = this;
            f.Show();
            f.Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowForm(Stock.instance);
            //Stock obj= new Stock();
            //   obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowForm(Sales_Analytics.instance);
            //Sales_Analytics obj = new Sales_Analytics();
            //obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowForm(Invoice_Details.instance);
            //Manage_Products obj = new Manage_Products();
            //obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //Suppliers obj = new Suppliers();
            //obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowForm(Sale_Register.instance);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            //Catagories obj = new Catagories();
            //obj.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Getting username 
            lblusername.Text = Login.loggedIn;
        }

       
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login obj = new Login();
            Main ob = new Main();
            //Closing all Forms and show login form
               DialogResult result = MessageBox.Show("Do You Want to LogOut and Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ob.Close();
                    obj.Show();
                }
                else
                {
                     e.Cancel = true;
                }
        }

        private void button8_Click(object sender, EventArgs e)
        {
               
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(Users.instance);
        }

        private void catagoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(Catagories.instance);
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(Suppliers.instance);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ShowForm(Return.instance);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void invoiceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            ShowForm(Manage_Products.instance);
        }
    }
}
