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
    class product_detailsdal
    {
        #region Insert data into database
        public bool insert(product_detailsbll u)
        {
            //Create a boolean variable and set its value to false and return it
            bool issucess = false;
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            try
            {
                //SQL Query to insert Data in DAtabase
                string query = "Insert into tbl_productdetails(product_id,product_name,price,quantity,discount,total,purchase_price,inv_no,type,added_by,added_date,code)Values(@product_id,@product_name,@price,@quantity,@discount,@total,@purchase_price,@inv_no,@type,@added_by,@added_date,@code)";
                //For Executing Command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Passing Values to the Variables
                cmd.Parameters.AddWithValue("@product_id", u.product_id);
                cmd.Parameters.AddWithValue("@product_name", u.product_name);
                cmd.Parameters.AddWithValue("@price", u.price);
                cmd.Parameters.AddWithValue("@quantity", u.quantity);
                cmd.Parameters.AddWithValue("@discount", u.discount);
                cmd.Parameters.AddWithValue("@total", u.total);
                cmd.Parameters.AddWithValue("@purchase_price", u.purchase_price);
                cmd.Parameters.AddWithValue("@inv_no", u.inv_no);
                cmd.Parameters.AddWithValue("@type", u.type);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@code", u.code);
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
        public bool update(product_detailsbll u)
        {
            //Create a boolean variable and set its value to false and return it
            bool issucess = false;
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            try
            {
                //SQL Query to insert Data in DAtabase
                string query = "UPDATE tbl_productdetails set product_id=@product_id,product_name=@product_name,price=@price,quantity=@quantity,discount=@discount,total=@total,purchase_price=@purchase_price,inv_no=@inv_no,type=@type,added_by=@added_by,added_date=@added_date,code=@code WHERE id=@id";
                //For Executing Command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Passing Values to the Variables
                cmd.Parameters.AddWithValue("@id", u.id);
                cmd.Parameters.AddWithValue("@product_id", u.product_id);
                cmd.Parameters.AddWithValue("@product_name", u.product_name);
                cmd.Parameters.AddWithValue("@price", u.price);
                cmd.Parameters.AddWithValue("@quantity", u.quantity);
                cmd.Parameters.AddWithValue("@discount", u.discount);
                cmd.Parameters.AddWithValue("@total", u.total);
                cmd.Parameters.AddWithValue("@purchase_price", u.purchase_price);
                cmd.Parameters.AddWithValue("@inv_no", u.inv_no);
                cmd.Parameters.AddWithValue("@type", u.type);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@code", u.code);
                //Database Connection Open
                conn.Open();
                //To execute non query
                int rows = cmd.ExecuteNonQuery();
                //If the query is executed Successfully then the value to rows will be greater than 0 else it will be less than 0
                if (rows > 0)
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
                string query = "SELECT* FROM tbl_productdetails WHERE added_date BETWEEN '"+d1+"' AND '"+d2+"'";
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

        #region Search Data From DataBase
        public DataTable Search(string inv_no)
        {
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            //TO hold the data from database 
            DataTable dt = new DataTable();
            try
            {
                //SQL Query to search Data from DAtabase
                string query = "SELECT* FROM  tbl_productdetails WHERE inv_no = " + inv_no ;
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
                string query = "SELECT* FROM tbl_productdetails WHERE added_date BETWEEN '" + d2 + "' AND '" + d1 + "' ";
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

        #region METHOD TO GET CURRENT QUantity from the Database based on Product ID
        public decimal GetProductQty(int id)
        {
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            //Create a Decimal Variable and set its default value to 0
            decimal quantity = 0;

            //Create Data Table to save the data from database temporarily
            DataTable dt = new DataTable();

            try
            {
                //Write WQL Query to Get Quantity from Database
                string sql = "SELECT quantity FROM tbl_productdetails WHERE id = " + id;

                //Cerate A SqlCommand
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create a SQL Data Adapter to Execute the query
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open DAtabase Connection
                conn.Open();

                //PAss the calue from Data Adapter to DataTable
                adapter.Fill(dt);

                //Lets check if the datatable has value or not
                if (dt.Rows.Count > 0)
                {
                    quantity = decimal.Parse(dt.Rows[0]["quantity"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return quantity;
        }
        #endregion

        #region METHOD TO UPDATE QUANTITY
        public bool UpdateQuantity(int id, decimal quantity)
        {

            //Create a Boolean Variable and Set its value to false
            bool success = false;

            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);

            try
            {
                //Write the SQL Query to Update Qty
                string sql = "UPDATE tbl_productdetails SET quantity=@quantity WHERE id=@id";

                //Create SQL Command to Pass the calue into Queyr
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing the VAlue trhough parameters
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@id", id);

                //Open Database Connection
                conn.Open();

                //Create Int Variable and Check whether the query is executed Successfully or not
                int rows = cmd.ExecuteNonQuery();
                //Lets check if the query is executed Successfully or not
                if (rows > 0)
                {
                    //Query Executed Successfully
                    success = true;
                }
                else
                {
                    //Failed to Execute Query
                    success = false;
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

            return success;
        }
        #endregion

        #region METHOD TO DECREASE PRODUCT
        public bool DecreaseProduct(int id, decimal quantity)
        {
            //Create Boolean Variable and SEt its Value to false
            bool success = false;

            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);

            try
            {
                //Get the Current product Quantity
                decimal currentQty = GetProductQty(id);

                //Decrease the Product Quantity based on product sales
                decimal NewQty = currentQty - quantity;

                //Update Product in Database
                success = UpdateQuantity(id, NewQty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return success;
        }
        #endregion

        #region Delete record in Data Base
        public bool delete(product_detailsbll u)
        {
            //Create a boolean variable and set its value to false and return it
            bool issucess = false;
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            try
            {
                //SQL Query to delete Data in DAtabase
                string query = "DELETE FROM tbl_productdetails WHERE id=@id";
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

    }
}
