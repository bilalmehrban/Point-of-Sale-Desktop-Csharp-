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
using POS.DAL;
using DGVPrinterHelper;

namespace POS.UI
{
    public partial class Sales_Analytics : Form
    {
        private static Sales_Analytics _instance;

        public static Sales_Analytics instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Sales_Analytics();
                return _instance;
            }
        }
        public Sales_Analytics()
        {
            InitializeComponent();
        }
        sales_analyticsdal dal = new sales_analyticsdal();
        Manage_Productsdal da = new Manage_Productsdal();
        product_detailsdal d = new product_detailsdal();

        double totalamount;
        double totalrevenue;
        double purchaseprice;
        private void Sales_Analytics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'posDataSet5.tbl_productdetails' table. You can move, or remove it, as needed.
            this.tbl_productdetailsTableAdapter1.Fill(this.posDataSet5.tbl_productdetails);
            // TODO: This line of code loads data into the 'posDataSet3.tbl_productdetails' table. You can move, or remove it, as needed.
            this.tbl_productdetailsTableAdapter.Fill(this.posDataSet3.tbl_productdetails);

            //To load data in DataGridView
            DataTable dt = dal.select();
            dgvsalesanalytics.DataSource = dt;



            //To calculate total quantity from table
            double[] columnData = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                   where row.Cells[7].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();
            txtquantity.Text = columnData.Sum().ToString();
            //To calculate total amount from table
            double[] columnData1 = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                   where row.Cells[9].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[9].FormattedValue)).ToArray();
            totalamount = columnData1.Sum();
            txtamount.Text = totalamount.ToString();
            //To calculate purchase price from table
            double[] columnData2 = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                    where row.Cells[10].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[10].FormattedValue)).ToArray();
            purchaseprice = columnData2.Sum();
            //to calculate total revenue
            totalrevenue = totalamount - purchaseprice;
            txtrevenue.Text =(totalrevenue).ToString();
            dgvsalesanalytics.DataSource = dt;
        }

        private void Sales_Analytics_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Get Keyword from Text box
            string keyword = txtsearch.Text;
            //Check if the keywords has value or not
            if (keyword != null)
            {
                //Show user based on keywords
                DataTable dt = dal.Search(keyword);
                dgvsalesanalytics.DataSource = dt;

                //To calculate total quantity from table
                double[] columnData = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                       where row.Cells[7].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();
                txtquantity.Text = columnData.Sum().ToString();
                //To calculate total amount from table
                double[] columnData1 = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                        where row.Cells[9].FormattedValue.ToString() != string.Empty
                                        select Convert.ToDouble(row.Cells[9].FormattedValue)).ToArray();
                totalamount = columnData1.Sum();
                txtamount.Text = totalamount.ToString();
                //To calculate purchase price from table
                double[] columnData2 = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                        where row.Cells[10].FormattedValue.ToString() != string.Empty
                                        select Convert.ToDouble(row.Cells[10].FormattedValue)).ToArray();
                purchaseprice = columnData2.Sum();
                //to calculate total revenue
                totalrevenue = totalamount - purchaseprice;
                txtrevenue.Text = (totalrevenue).ToString();
            }
            else
            {
                //show all users from the database
                DataTable dt = dal.select();
                dgvsalesanalytics.DataSource = dt;
            }
        }


        
        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            DataTable da = d.BetweenTwoDates((dt1).Value.ToString(), (dt2).Value.ToString());
            dgvsalesanalytics.DataSource = da;

            //To calculate total quantity from table
            double[] columnData = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                   where row.Cells[7].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();
            txtquantity.Text = columnData.Sum().ToString();
            //To calculate total amount from table
            double[] columnData1 = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                    where row.Cells[9].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[9].FormattedValue)).ToArray();
            totalamount = columnData1.Sum();
            txtamount.Text = totalamount.ToString();
            //To calculate purchase price from table
            double[] columnData2 = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                    where row.Cells[10].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[10].FormattedValue)).ToArray();
            purchaseprice = columnData2.Sum();
            //to calculate total revenue
            totalrevenue = totalamount - purchaseprice;
            txtrevenue.Text = (totalrevenue).ToString();
        }

        private void dt2_ValueChanged(object sender, EventArgs e)
        {
            DataTable da = d.BetweenTwoDates((dt1).Value.ToString(), (dt2).Value.ToString());
            dgvsalesanalytics.DataSource = da;

            //To calculate total quantity from table
            double[] columnData = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                   where row.Cells[7].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();
            txtquantity.Text = columnData.Sum().ToString();
            //To calculate total amount from table
            double[] columnData1 = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                    where row.Cells[9].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[9].FormattedValue)).ToArray();
            totalamount = columnData1.Sum();
            txtamount.Text = totalamount.ToString();
            //To calculate purchase price from table
            double[] columnData2 = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                    where row.Cells[10].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[10].FormattedValue)).ToArray();
            purchaseprice = columnData2.Sum();
            //to calculate total revenue
            totalrevenue = totalamount - purchaseprice;
            txtrevenue.Text = (totalrevenue).ToString();
        }

        private void btnmonth_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            DateTime thedate = System.DateTime.Today;
            thedate -= new TimeSpan(30, 0, 0,0);

            DataTable dat = d.MonthlyAndDailyData(date.ToString(),thedate.ToString()) ;
            dgvsalesanalytics.DataSource = dat;

            //To calculate total quantity from table
            double[] columnData = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                   where row.Cells[7].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();
            txtquantity.Text = columnData.Sum().ToString();
            //To calculate total amount from table
            double[] columnData1 = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                    where row.Cells[9].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[9].FormattedValue)).ToArray();
            totalamount = columnData1.Sum();
            txtamount.Text = totalamount.ToString();
            //To calculate purchase price from table
            double[] columnData2 = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                    where row.Cells[10].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[10].FormattedValue)).ToArray();
            purchaseprice = columnData2.Sum();
            //to calculate total revenue
            totalrevenue = totalamount - purchaseprice;
            txtrevenue.Text = (totalrevenue).ToString();
        }

        private void btntoday_Click(object sender, EventArgs e)
        {
            //To Create Variables for sale history 
            DateTime date = DateTime.Now;
            DateTime thedate = System.DateTime.Today;
            thedate -= new TimeSpan(1, 0, 0, 0);

            DataTable dat = d.MonthlyAndDailyData(date.ToString(), thedate.ToString());
            dgvsalesanalytics.DataSource = dat;

            //To calculate total quantity from table
            double[] columnData = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                   where row.Cells[7].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();
            txtquantity.Text = columnData.Sum().ToString();
            //To calculate total amount from table
            double[] columnData1 = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                    where row.Cells[9].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[9].FormattedValue)).ToArray();
            totalamount = columnData1.Sum();
            txtamount.Text = totalamount.ToString();
            //To calculate purchase price from table
            double[] columnData2 = (from DataGridViewRow row in dgvsalesanalytics.Rows
                                    where row.Cells[10].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[10].FormattedValue)).ToArray();
            purchaseprice = columnData2.Sum();
            //to calculate total revenue
            totalrevenue = totalamount - purchaseprice;
            txtrevenue.Text = (totalrevenue).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //code to print Bill
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "\r \r Time Paint & Hardware Store";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Products Sales History " + "\r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r" + "Total Quantity:" + txtquantity.Text + "\r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r" + "Total Amount:" + txtamount.Text + "\r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r" + "Total Revenue:" + txtrevenue.Text + "\r";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvsalesanalytics);
        }
    }
}
