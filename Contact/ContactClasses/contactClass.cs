using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Contact.ContactClasses
{
    internal class contactClass
    {

        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

       //static string myConnectionString = ConfigurationManager.ConnectionStrings["myConnectionStr"].ConnectionString;

        static string myConnectionString = "data source=localhost\\SQLEXPRESS; database=ContactApp; Integrated Security=True;Encrypt=False;";

        //SqlConnection conn = null;
        

        public DataTable Select()
        {
            //Database Connection
            SqlConnection conn = new(myConnectionString);
            //Creating Datatable Object
            DataTable dt = new();

            try
            {
                //Writing SQL Query
                string sql = "SELECT * FROM ContactTable";
                //Creating SqlCommand Object using sql and conn
                SqlCommand cmd = new(sql, conn);
                //Creating DataAdapter Object adapter using cmd
                SqlDataAdapter adapter = new(cmd);
                conn.Open();
                //filling datatable using adapter
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {
                Console.WriteLine("Something Went Wrong. => ",ex);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Inserting Data into Database
        
        public bool Insert(contactClass c)
        {
            
            bool isSuccess = false;

            SqlConnection conn = new(myConnectionString);

            try
            {
                //Create Sql Query to insert data
                string sql = "INSERT INTO ContactTable (FirstName, LastName, ContactNo, Address, Gender) " +
                    "VALUES(@FirstName, @LastName, @ContactNo, @Address, @Gender)";
                //Creating Sql Command using sql, and conn
                SqlCommand cmd = new(sql,conn);
                
                //Creating Parameters to add data
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);


                //Connection open
                conn.Open();    

                int rows = cmd.ExecuteNonQuery();

                if(rows > 0) { 
                    isSuccess = true;
                    //MessageBox.Show("Inserted");
                }
                else
                {
                    isSuccess =false;
                    //MessageBox.Show("Not Inserted");
                }
                //Console.WriteLine("Insertion Successful");
            }
            catch(Exception ex) 
            { 
                Console.WriteLine($"Something Went Wrong. => ", ex); 
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        

        //Method to Update Data
        public bool Update(contactClass c)
        {
            //MessageBox.Show("Update Method Called");
            bool isSuccess = false;

            SqlConnection conn = new(myConnectionString);
            
            try
            {
                // SQL to Update data in our database
                string sql = "UPDATE ContactTable SET FirstName = @FirstName, LastName = @LastName, ContactNo = @ContactNo, Address = @Address, Gender = @Gender WHERE ContactID = @ContactID";
                
                //Creating SQL Command 
                SqlCommand cmd = new(sql,conn);
                cmd.Parameters.AddWithValue("ContactID", c.ContactID);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                //MessageBox.Show("Update Method Called Last Name",c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                //MessageBox.Show("Update Method Called ContactNo",c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                //MessageBox.Show("Update Method Called Address",c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                //MessageBox.Show("Update Method Called Gender",c.Gender);
                //Open the connection
                conn.Open();    

                int rows = cmd.ExecuteNonQuery();
                
                if(rows > 0)
                {
                    isSuccess=true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Something Went Wrong : ", ex);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        

        // Creating Method to delete the Data

        public bool Delete(contactClass c) { 
        
            bool isSuccess = false;

            //Creating SQL COnnecting 

            SqlConnection conn = new(myConnectionString);

            try
            {
                //SQL command to Delete the Data
                string sql = "DELETE FROM ContactTable WHERE ContactID = @ContactID";
                //creating sql command using sql and conn
                SqlCommand cmd = new(sql,conn);

                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;  
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something Went Wrong : ",ex);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        
        }
    
    }
}
