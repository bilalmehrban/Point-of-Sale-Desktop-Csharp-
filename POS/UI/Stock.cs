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
using DGVPrinterHelper;

namespace POS.UI
{
    public partial class Stock : Form
    {
        private static Stock _instance;

        public static Stock instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Stock();
                return _instance;
            }
        }
        public Stock()
        {
            InitializeComponent();
        }
        Manage_Productsbll u = new Manage_Productsbll();
        Manage_Productsdal dal = new Manage_Productsdal();
        private void Stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'posDataSet1.tbl_stock' table. You can move, or remove it, as needed.
            //this.tbl_stockTableAdapter.Fill(this.posDataSet1.tbl_stock);
            //To load data in DataGridView
            DataTable dt = dal.select();
            dgvstock.DataSource = dt;
            dgvstock.Columns[0].Width = 40;
            dgvstock.Columns[1].Width = 90;
            dgvstock.Columns[2].Width = 45;
            dgvstock.Columns[3].Width = 60;
            dgvstock.Columns[4].Width = 60;
            dgvstock.Columns[5].Width = 60;
            dgvstock.Columns[6].Width = 60;
            dgvstock.Columns[7].Width = 60;
            dgvstock.Columns[8].Width = 40;
            dgvstock.Columns[9].Width = 40;
            dgvstock.Columns[0].Width = 90;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //Get Keyword from Text box
            string keyword = txtsearch.Text;
            //Check if the keywords has value or not
            if (keyword != null)
            {
                //Show Data based on keywords
                DataTable dt = dal.Search(keyword);
               dgvstock.DataSource = dt;
            }
            else
            {
                //show all Data from the database
                DataTable dt = dal.select();
                dgvstock.DataSource = dt;
            }
        }

        private void dgvstock_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Manage_Products manage = new Manage_Products();
            manage.Show();
            this.Hide();
        }

        private void dgvstock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Stock_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //code to print Bill
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "\r \r Time Paint & Hardware Store \r \r \r \r \r \r \r \r Stock";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvstock);
        }
    }
}
