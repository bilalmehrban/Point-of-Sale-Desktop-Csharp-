using DGVPrinterHelper;
using POS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.UI
{
    public partial class Invoice_Details : Form
    {
        private static Invoice_Details _instance;

        public static Invoice_Details instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Invoice_Details();
                return _instance;
            }
        }
        public Invoice_Details()
        {
            InitializeComponent();
        }

        invoicedetailsdal dal = new invoicedetailsdal();
        invoicedal dal1 = new invoicedal();

        private void Invoice_Details_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void Invoice_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'posDataSet4.tbl_invoice' table. You can move, or remove it, as needed.
            this.tbl_invoiceTableAdapter.Fill(this.posDataSet4.tbl_invoice);
            DataTable dt = dal.select();
            dgvinvoicedetails.DataSource = dt;

            double[] columnData = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                   where row.Cells[3].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[3].FormattedValue)).ToArray();
            txttotalamount.Text = columnData.Sum().ToString();

            double[] columnData1 = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                   where row.Cells[6].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[6].FormattedValue)).ToArray();
            txtdueamount.Text = columnData1.Sum().ToString();

            double[] columnData2 = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                    where row.Cells[7].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();
            txtreturnamount.Text = columnData2.Sum().ToString();
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
                dgvinvoicedetails.DataSource = dt;

                double[] columnData = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                       where row.Cells[3].FormattedValue.ToString() != string.Empty
                                       select Convert.ToDouble(row.Cells[3].FormattedValue)).ToArray();
                txttotalamount.Text = columnData.Sum().ToString();

                double[] columnData1 = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                        where row.Cells[6].FormattedValue.ToString() != string.Empty
                                        select Convert.ToDouble(row.Cells[6].FormattedValue)).ToArray();
                txtdueamount.Text = columnData1.Sum().ToString();

                double[] columnData2 = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                        where row.Cells[7].FormattedValue.ToString() != string.Empty
                                        select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();
                txtreturnamount.Text = columnData2.Sum().ToString();
            }
            else
            {
                //show all users from the database
                DataTable dt = dal.select();
                dgvinvoicedetails.DataSource = dt;
            }
        }

        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            DataTable da = dal1.BetweenTwoDates((dt1).Value.ToString(), (dt2).Value.ToString());
            dgvinvoicedetails.DataSource = da;

            double[] columnData = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                   where row.Cells[3].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[3].FormattedValue)).ToArray();
            txttotalamount.Text = columnData.Sum().ToString();

            double[] columnData1 = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                    where row.Cells[6].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[6].FormattedValue)).ToArray();
            txtdueamount.Text = columnData1.Sum().ToString();

            double[] columnData2 = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                    where row.Cells[7].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();
            txtreturnamount.Text = columnData2.Sum().ToString();
        }

        private void dt2_ValueChanged(object sender, EventArgs e)
        {
            DataTable da = dal1.BetweenTwoDates((dt1).Value.ToString(), (dt2).Value.ToString());
            dgvinvoicedetails.DataSource = da;

            double[] columnData = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                   where row.Cells[3].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[3].FormattedValue)).ToArray();
            txttotalamount.Text = columnData.Sum().ToString();

            double[] columnData1 = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                    where row.Cells[6].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[6].FormattedValue)).ToArray();
            txtdueamount.Text = columnData1.Sum().ToString();

            double[] columnData2 = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                    where row.Cells[7].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();
            txtreturnamount.Text = columnData2.Sum().ToString();
        }

        private void btntoday_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            DateTime thedate = System.DateTime.Today;
            thedate -= new TimeSpan(1, 0, 0, 0);

            DataTable dat = dal1.MonthlyAndDailyData(date.ToString(), thedate.ToString());
            dgvinvoicedetails.DataSource = dat;

            double[] columnData = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                   where row.Cells[3].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[3].FormattedValue)).ToArray();
            txttotalamount.Text = columnData.Sum().ToString();

            double[] columnData1 = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                    where row.Cells[6].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[6].FormattedValue)).ToArray();
            txtdueamount.Text = columnData1.Sum().ToString();

            double[] columnData2 = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                    where row.Cells[7].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();
            txtreturnamount.Text = columnData2.Sum().ToString();
        }

        private void btnmonth_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            DateTime thedate = System.DateTime.Today;
            thedate -= new TimeSpan(30, 0, 0, 0);

            DataTable dat = dal1.MonthlyAndDailyData(date.ToString(), thedate.ToString());
            dgvinvoicedetails.DataSource = dat;

            double[] columnData = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                   where row.Cells[3].FormattedValue.ToString() != string.Empty
                                   select Convert.ToDouble(row.Cells[3].FormattedValue)).ToArray();
            txttotalamount.Text = columnData.Sum().ToString();

            double[] columnData1 = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                    where row.Cells[6].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[6].FormattedValue)).ToArray();
            txtdueamount.Text = columnData1.Sum().ToString();

            double[] columnData2 = (from DataGridViewRow row in dgvinvoicedetails.Rows
                                    where row.Cells[7].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells[7].FormattedValue)).ToArray();
            txtreturnamount.Text = columnData2.Sum().ToString();
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
            printer.Footer = "Invoice Sales History " + "\r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r" + "Total Amount:" + txttotalamount.Text + "\r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r" + "Due Amount:" + txtdueamount.Text + "\r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r \r" + "Change Amount:" + txtreturnamount.Text + "\r";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvinvoicedetails);
        }
    }
}
