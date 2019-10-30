using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.BLL;

namespace POS.DAL
{
    class invoicedal
    {
        #region Insert data into database
        public bool insert(invoicebll u)
        {
            //Create a boolean variable and set its value to false and return it
            bool issucess = false;
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            try
            {
                //SQL Query to insert Data in DAtabase
                string query = "Insert into tbl_invoice(inv_no,customer_name,total_payable,paid_amount,discount,due_amount,change_amount,added_by,sales_date)Values(@inv_no,@customer_name,@total_payable,@paid_amount,@discount,@due_amount,@change_amount,@added_by,@sales_date)";
                //For Executing Command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Passing Values to the Variables
                cmd.Parameters.AddWithValue("@inv_no", u.inv_no);
                cmd.Parameters.AddWithValue("@customer_name", u.customer_name);
                cmd.Parameters.AddWithValue("@total_payable", u.total_payable);
                cmd.Parameters.AddWithValue("@paid_amount", u.paid_amount);
                cmd.Parameters.AddWithValue("@discount", u.discount);
                cmd.Parameters.AddWithValue("@due_amount", u.due_amount);
                cmd.Parameters.AddWithValue("@change_amount", u.change_amount);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@sales_date", u.sales_date);
                //Database Connection Open
                conn.Open();
                //To execute non query
                int row = cmd.ExecuteNonQuery();
                //If the query is executed Successfully then the value to rows will be greater than 0 else it will be less than 0
                if (row > 0)
                {
                    //Query Sucessfull
                    issucess = true;
                }
                else
                {
                    //Query Failed
                    issucess = false;
                }
            }
            catch (Exception ex)
            {
                //Throw Message if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Closing Connection
                conn.Close();
            }

            return issucess;
        }
        #endregion

        #region Search Data From DataBase (for Return Items)
        public DataTable Search(string id)
        {
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            //TO hold the data from database 
            DataTable dt = new DataTable();
            try
            {
                //SQL Query to search Data from DAtabase
                string query = "SELECT* FROM  tbl_invoice WHERE inv_no = " + id ;
                //For Executing Command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Getting DAta from dAtabase
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Database Connection Open
                conn.Open();
                //Fill Data in our DataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Throw Message if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Closing Connection
                conn.Close();
            }
            //Return the value in DataTable
            return dt;
        }
        #endregion

        #region Delete record in Data Base
        public bool delete(invoicebll u)
        {
            //Create a boolean variable and set its value to false and return it
            bool issucess = false;
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            try
            {
                //SQL Query to delete Data in DAtabase
                string query = "DELETE FROM tbl_invoice WHERE id=@id";
                //For Executing Command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Passing Values to the Variables
                cmd.Parameters.AddWithValue("@id", u.id);
                //Database Connection Open
                conn.Open();
                //To execute non query
                int row = cmd.ExecuteNonQuery();
                //If the query is executed Successfully then the value to rows will be greater than 0 else it will be less than 0
                if (row > 0)
                {
                    //Query Sucessfull
                    issucess = true;
                }
                else
                {
                    //Query Failed
                    issucess = false;
                }
            }

            catch (Exception ex)
            {
                //Throw Message if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Closing Connection
                conn.Close();
            }

            return issucess;
        }
        #endregion

        #region Update data into database
        public bool update(invoicebll u)
        {
            //Create a boolean variable and set its value to false and return it
            bool issucess = false;
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            try
            {
                //SQL Query to insert Data in DAtabase
                string query = "UPDATE tbl_invoice set inv_no=@inv_no, customer_name=@customer_name,total_payable=@total_payable,paid_amount=@paid_amount,discount=@discount,due_amount=@due_amount,change_amount=@change_amount,added_by=@added_by,sales_date=@sales_date WHERE id=@id";
                //For Executing Command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Passing Values to the Variables
                cmd.Parameters.AddWithValue("@id", u.id);
                cmd.Parameters.AddWithValue("@inv_no", u.inv_no);
                cmd.Parameters.AddWithValue("@customer_name", u.customer_name);
                cmd.Parameters.AddWithValue("@total_payable", u.total_payable);
                cmd.Parameters.AddWithValue("@paid_amount", u.paid_amount);
                cmd.Parameters.AddWithValue("@discount", u.discount);
                cmd.Parameters.AddWithValue("@due_amount", u.due_amount);
                cmd.Parameters.AddWithValue("@change_amount", u.change_amount);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@sales_date", u.sales_date);
                //Database Connection Open
                conn.Open();
                //To execute non query
                int row = cmd.ExecuteNonQuery();
                //If the query is executed Successfully then the value to rows will be greater than 0 else it will be less than 0
                if (row > 0)
                {
                    //Query Sucessfull
                    issucess = true;
                }
                else
                {
                    //Query Failed
                    issucess = false;
                }
            }
            catch (Exception ex)
            {
                //Throw Message if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Closing Connection
                conn.Close();
            }

            return issucess;
        }
        #endregion

        #region Show Data between Two dates
        public DataTable BetweenTwoDates(string d1, string d2)
        {
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            //TO hold the data from database 
            DataTable dt = new DataTable();
            try
            {
                //SQL Query to insert Data in DAtabase
                string query = "SELECT* FROM tbl_invoice WHERE sales_date BETWEEN '" + d1 + "' AND '" + d2 + "'";
                //For Executing Command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Getting DAta from dAtabase
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Database Connection Open
                conn.Open();
                //Fill Data in our DataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Throw Message if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Closing Connection
                conn.Close();
            }

            return dt;
        }
        #endregion

        #region Show Data Monthly And Daily
        public DataTable MonthlyAndDailyData(string d1, string d2)
        {
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            //TO hold the data from database 
            DataTable dt = new DataTable();
            //string d1 = DateTime.Now.ToString();
            try
            {
                //SQL Query to insert Data in DAtabase
                string query = "SELECT* FROM tbl_invoice WHERE sales_date BETWEEN '" + d2 + "' AND '" + d1 + "' ";
                //For Executing Command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Getting DAta from dAtabase
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Database Connection Open
                conn.Open();
                //Fill Data in our DataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Throw Message if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Closing Connection
                conn.Close();
            }

            return dt;
        }
        #endregion
    }


}
