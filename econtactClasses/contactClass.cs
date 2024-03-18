using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econtact.econtactClasses
{
    class contactClass
    {
        //gettter & setter properties
        //Acts as Data carrier in our Application
        public int ContactID { get; set; }
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string  Address { get; set; }
        public string Gender { get; set; }
        public int RowIndex { get; internal set; }

        // Create DB connection
        static string myConnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting from Database
        public DataTable Select()
        {
            // step 1. Database connection
            SqlConnection conn = new SqlConnection(myConnstrng);
            //Object of our DataTable 
            DataTable dt = new DataTable();
            try
            {
                //step 2. writing sql query
                string sql = "SELECT * FROM tbl_contact";
                // create cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adpter = new SqlDataAdapter(cmd);
                conn.Open();
                adpter.Fill(dt);

            }
            catch(Exception e)
            {

            }
            finally
            {
                conn.Close();


            }
            return dt;
        }
        //Inserting Data into DataBase
        public bool Insert(contactClass c)
        {
            //creatng a default return type and setting its value to false
            bool isSuccess = false;
            //step 1. connection Db
            SqlConnection conn = new SqlConnection(myConnstrng);
            try {
                // step 2. create sql query
                string sql = "INSERT INTO tbl_contact(FirstName,LastName,ContactNo,Address,Gender) VALUES(@FirstName,@LastName,@ContactNo,@Address,@Gender)";
                //CREATING SQL command using conn and sql;
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating parameters to add data;
                cmd.Parameters.AddWithValue("@FirstName",c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
             //connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully the value will be greater than zero else its value will be zero
                //
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {

            }
            finally{
                conn.Close();
            }

            return isSuccess;
        }
        //method to update data in database from our application
        public bool Update(contactClass c)
        {
            //creatng a default return type and setting its value to false
            bool isSuccess = false;
            //step 1. connection Db
            SqlConnection conn = new SqlConnection(myConnstrng);
            try
            {
                // step 2.  sql to update data in our database
                string sql = "UPDATE tbl_contact SET FirstName=@FirstName, LastName=@LastName, ContactNo=@ContactNo, Address=@Address, Gender=@Gender WHERE ContactID=@ContactID";

                //CREATING SQL command using conn and sql;
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating parameters to add value
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                //connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully the value will be greater than zero else its value will be zero
                //
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        //method to delete data from database
        public bool Delete(contactClass c)
        {
            //creatng a default return type and setting its value to false
            bool isSuccess = false;
            //step 1. connection Db
            SqlConnection conn = new SqlConnection(myConnstrng);
            try
            {
                // step 2.  sql to delete data in our database
                string sql = "DELETE FROM  tbl_contact where ContactID=@ContactID";
                //CREATING SQL command using conn and sql;
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating parameters to add value
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                //connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully the value will be greater than zero else its value will be zero
                //
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }





    }
}
