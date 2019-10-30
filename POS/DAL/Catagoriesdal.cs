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
    class Catagoriesdal
    {
        #region select data from database

        public DataTable select()
        {
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            //TO hold the data from database
            DataTable dt = new DataTable();
            try
            {
                //SQL Query to Get Data From DAtabase
                string query = "select* from tbl_catagories";
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

        #region Insert data into database
        public bool insert(Catagoriesbll u)
        {
            //Create a boolean variable and set its value to false and return it
            bool issucess = false;
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            try
            {
                //SQL Query to insert Data in DAtabase
                string query = "Insert into tbl_catagories(catagory,supplier,added_by,added_date)Values(@catagory,@supplier,@added_by,@added_date)";
                //For Executing Command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Passing Values to the Variables
                cmd.Parameters.AddWithValue("@catagory", u.catagory);
                cmd.Parameters.AddWithValue("@supplier", u.supplier);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
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

        #region Update data in database

        public bool update(Catagoriesbll u)
        {
            //Create a boolean variable and set its value to false and return it
            bool issucess = false;
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            try
            {
                //SQL Query to update Data in DAtabase
                string query = "UPDATE tbl_catagories set catagory=@catagory,supplier=@supplier,added_by=@added_by,added_date=@added_date WHERE id=@id";
                //For Executing Command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Passing Values to the Variables
                cmd.Parameters.AddWithValue("@id", u.id);
                cmd.Parameters.AddWithValue("@catagory", u.catagory);
                cmd.Parameters.AddWithValue("@supplier", u.supplier);
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

        #region Delete record in Data Base
        public bool delete(Catagoriesbll u)
        {
            //Create a boolean variable and set its value to false and return it
            bool issucess = false;
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            try
            {
                //SQL Query to delete Data in DAtabase
                string query = "DELETE FROM tbl_catagories WHERE id=@id";
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
                    //Query Sucessfull
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

        #region Search Data From DataBase
        public DataTable Search(string keyword)
        {
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            //TO hold the data from database
            DataTable dt = new DataTable();
            try
            {
                //SQL Query to search Data from DAtabase
                string query = "SELECT* FROM  tbl_catagories WHERE id Like '%" + keyword + "%' OR catagory like '%" + keyword + "%' OR supplier like '%" + keyword + "%' OR company like '%" + keyword + "%'";
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

        #region If Product exist

        public bool exist(Catagoriesbll u)
        {
            //Create a boolean variable and set its value to false and return it
            bool issuccess = false;
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            try
            {
                //SQL Query to selecte Data from DAtabase
                string query = "select * from tbl_catagories where catagory=@catagory AND supplier=@supplier AND company=@company";
                //For Executing Command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Passing Values to the Variables
                cmd.Parameters.AddWithValue("@catagory", u.catagory);
                cmd.Parameters.AddWithValue("@supplier", u.supplier);
                //Getting DAta from dAtabase
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //TO hold the data from database
                DataTable dt = new DataTable();
                //Database Connection Open
                conn.Open();
                //Fill Data in our DataTable
                adapter.Fill(dt);
                //Checking The rows in DataTable
                if (dt.Rows.Count > 0)
                {
                    //Data Exist
                    issuccess = true;
                }
                else
                {
                    //Data not exist
                    issuccess = false;
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
            return issuccess;
        }


        #endregion
    }
}
