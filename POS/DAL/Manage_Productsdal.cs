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
    class Manage_Productsdal
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
                string query = "select* from tbl_stock";
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
        public bool insert(Manage_Productsbll u)
        {
            //Create a boolean variable and set its value to false and return it
            bool issucess = false;
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            try
            {
                //SQL Query to insert Data in DAtabase
                string query = "Insert into tbl_stock(product_name,colour_code,supplier,catagory,purchase_price,retail_price,type,quantity,added_by,added_date)Values(@product_name,@colour_code,@supplier,@catagory,@purchase_price,@retail_price,@type,@quantity,@added_by,@added_date)";
                //For Executing Command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Passing Values to the Variables
                cmd.Parameters.AddWithValue("@product_name", u.product_name);
                cmd.Parameters.AddWithValue("@colour_code", u.colour_code);
                cmd.Parameters.AddWithValue("@supplier" , u.supplier);
                cmd.Parameters.AddWithValue("@catagory", u.catagory);     
                cmd.Parameters.AddWithValue("@purchase_price", u.purchase_price);
                cmd.Parameters.AddWithValue("@retail_price", u.retail_price);
                cmd.Parameters.AddWithValue("@type", u.type);
                cmd.Parameters.AddWithValue("@quantity", u.quantity);
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

        internal bool update(Manage_Productsbll u)
        {
            throw new NotImplementedException();
        }


        #endregion

        #region Update data in database

        public bool update_(Manage_Productsbll u)
        {
            //Create a boolean variable and set its value to false and return it
            bool issucess = false;
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            try
            {
                //SQL Query to update Data in DAtabase
                string query = "UPDATE tbl_stock set product_name=@product_name,colour_code=@colour_code,supplier=@supplier,catagory=@catagory,purchase_price=@purchase_price,retail_price=@retail_price,type=@type,quantity=@quantity WHERE id=@id";
                //For Executing Command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Passing Values to the Variables
                cmd.Parameters.AddWithValue("@id", u.id);
                cmd.Parameters.AddWithValue("@product_name", u.product_name);
                cmd.Parameters.AddWithValue("@colour_code", u.colour_code);
                cmd.Parameters.AddWithValue("@supplier", u.supplier);
                cmd.Parameters.AddWithValue("@catagory", u.catagory);
                cmd.Parameters.AddWithValue("@purchase_price", u.purchase_price);
                cmd.Parameters.AddWithValue("@retail_price", u.retail_price);
                cmd.Parameters.AddWithValue("@type", u.type); 
                cmd.Parameters.AddWithValue("@quantity", u.quantity);
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
        public bool delete(Manage_Productsbll u)
        {
            //Create a boolean variable and set its value to false and return it
            bool issucess = false;
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            try
            {
                //SQL Query to delete Data in DAtabase
                string query = "DELETE FROM tbl_stock WHERE id=@id";
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
                string query = "SELECT* FROM  tbl_stock WHERE colour_code Like '%" + keyword + "%' OR product_name like '%" + keyword + "%' OR supplier like '%" + keyword + "%' OR catagory like '%" + keyword + "%' OR id like '%" + keyword + "%'";
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

        public bool exist(Manage_Productsbll u)
        {
            //Create a boolean variable and set its value to false and return it
            bool issuccess = false;
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            try
            {
                //SQL Query to selecte Data from DAtabase
                string query = "select * from tbl_stock where product_name=@product_name AND supplier=@supplier AND catagory=@catagory AND colour_code=@colour_code AND type=@type";
                //For Executing Command
                SqlCommand cmd = new SqlCommand(query, conn);
                //Passing Values to the Variables
                cmd.Parameters.AddWithValue("@type", u.type);
                cmd.Parameters.AddWithValue("@product_name", u.product_name);
                cmd.Parameters.AddWithValue("@supplier", u.supplier);
                cmd.Parameters.AddWithValue("@catagory", u.catagory);
                cmd.Parameters.AddWithValue("@colour_code", u.colour_code);
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

        #region TO GET PRODUCT ID BASED ON PRODUCT NAME and Type
        public Manage_Productsbll GetProductIDFromName(string ProductName, string type, string code)
        {
            //First Create an Object of BLL and REturn it
            Manage_Productsbll p = new Manage_Productsbll();
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            //Data TAble to Holdthe data temporarily
            DataTable dt = new DataTable();

            try
            {
                //SQL Query to Get id based on Name
                string sql = "SELECT id FROM tbl_stock WHERE product_name='" + ProductName + "' AND type = '"+ type + "' AND colour_code = '" + code + "'";
                //Create the SQL Data Adapter to Execute the Query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                //Passing the CAlue from Adapter to DAtatable
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //Pass the value from dt to DeaCustBLL dc
                    p.id = int.Parse(dt.Rows[0]["id"].ToString());
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

            return p;
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
                string sql = "SELECT quantity FROM tbl_stock WHERE id = " + id;

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
                string sql = "UPDATE tbl_stock SET quantity=@quantity WHERE id=@id";

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

        #region METHOD TO INCREASE PRODUCT
        public bool IncreaseProduct(int id, decimal IncreaseQty)
        {
            //Create a Boolean Variable and SEt its value to False
            bool success = false;

            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);

            try
            {
                //Get the Current Qty From dAtabase based on id
                decimal currentQty = GetProductQty(id);

                //Increase the Current Quantity by the qty purchased from Dealer
                decimal NewQty = currentQty + IncreaseQty;

                //Update the Prudcty Quantity Now
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

        #region TO GET PRODUCT PRICE BASED ON PRODUCT id
        public Manage_Productsbll GetProductpriceFromId(string id)
        {
            //First Create an Object of BLL and REturn it
            Manage_Productsbll p = new Manage_Productsbll();
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            //Data TAble to Holdthe data temporarily
            DataTable dt = new DataTable();

            try
            {
                //SQL Query to Get id based on Name
                string sql = "SELECT purchase_price FROM tbl_stock WHERE id='" + id + "'";
                //Create the SQL Data Adapter to Execute the Query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                //Passing the VAlue from Adapter to DAtatable
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //Pass the value from dt to variable 
                   p.purchase_price =  dt.Rows[0]["purchase_price"].ToString();
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

            return p;
        }
        #endregion
    }
}
