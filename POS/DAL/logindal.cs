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
    class logindal
    {
        #region login fuction for database

        public bool login(loginbll u)
        {
            //Create a boolean variable and set its value to false and return it
            bool issuccess = false;
            //MEthod to connect Database
            connclass c = new connclass();
            SqlConnection conn = new SqlConnection(c.connection);
            try
            {
                //SQL Query to check login
                string query = "select * from tbl_users where user_name=@user_name AND password=@password AND user_type=@user_type";
                //Creating SQL Command to pass value
                SqlCommand cmd = new SqlCommand(query, conn);
                //Passing Values to the Variables
                cmd.Parameters.AddWithValue("@user_name", u.user_name);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
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
                    //Login Sucessful
                    issuccess = true;
                }
                else
                {
                    //Login Failed
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
