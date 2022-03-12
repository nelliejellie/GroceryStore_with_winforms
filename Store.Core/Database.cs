using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Store.Core
{
    public static class Database
    {
        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
      
        public static void InsertIntoDatabase(Product prod)
        {
            SqlConnection con = new SqlConnection(Database.connectionString);
            string query = $"INSERT INTO Store.dbo.Products (id,Name,Price,Quantity) VALUES('{prod.Id}','{prod.Name}',{prod.Price},{prod.Quantity})";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();               

            }
            catch (SqlException e)
            {
                e.ToString();
            }
            finally
            {
                con.Close();
            }
        }
        public static List<string> CheckUserValidation(string username, string password)
        {

            // Create a connection string  
            
            string SQL = $"SELECT * FROM Store.dbo.Users WHERE username = '{username}' and password = '{password}'";

            // create a connection object  
            SqlConnection conn = new SqlConnection(Database.connectionString);

            // Create a command object  
            SqlCommand cmd = new SqlCommand(SQL, conn);
            conn.Open();

            // Call ExecuteReader to return a DataReader  
            SqlDataReader reader = cmd.ExecuteReader();

            List<string> valids = new List<string>();
            while (reader.Read())
            {
                valids.Add(reader["username"].ToString());
                valids.Add(reader["password"].ToString());
            }

            //Release resources  
            reader.Close();
            conn.Close();

            return valids;
        }
        public static List<Product> GetAllProduct()
        {
            string SQL = "SELECT * FROM Store.dbo.Products";
            SqlConnection conn = new SqlConnection(Database.connectionString);

            SqlCommand cmd = new SqlCommand(SQL, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product prod = new Product()
                {
                    Id = reader["id"].ToString(),
                    Name = reader["Name"].ToString(),
                    Price = Convert.ToInt32(reader["Price"]),
                    Quantity = Convert.ToInt32(reader["Quantity"])
                };
                products.Add(prod);
            }

            return products;
        }
        public static Product GetOneProduct(string id)
        {
            string SQL = $"SELECT * FROM Store.dbo.Products WHERE id = '{id}'";
            SqlConnection conn = new SqlConnection(Database.connectionString);

            SqlCommand cmd = new SqlCommand(SQL, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Product prod = new Product()
                    {
                        Id = reader["id"].ToString(),
                        Name = reader["Name"].ToString(),
                        Price = Convert.ToInt32(reader["Price"]),
                        Quantity = Convert.ToInt32(reader["Quantity"])
                    };
                    return prod;
                }


            }
            catch (SqlException e)
            {
                e.ToString();
            }
            finally
            {
                conn.Close();
            }
            return default;
        }
        public static string DeleteProduct(string id)
        {
            string SQL = $"DELETE FROM Store.dbo.Products WHERE id = '{id}'";
            SqlConnection conn = new SqlConnection(Database.connectionString);

            SqlCommand cmd = new SqlCommand(SQL, conn);
            

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return $"product with {id} has been deleted successfully";
                
            }
            catch (SqlException e)
            {
                return $"{e.ToString()}";
            }
            finally
            {
                conn.Close();
            }
            
        }
        public static Product UpdateProduct(string id, int value, int previousQuantity)
        {
            string SQL = $"update Store.dbo.Products set Quantity = {previousQuantity - value} where id = '{id}'";
            SqlConnection conn = new SqlConnection(Database.connectionString);

            SqlCommand cmd = new SqlCommand(SQL, conn);
            

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Product prod = new Product()
                    {
                        Id = reader["id"].ToString(),
                        Name = reader["Name"].ToString(),
                        Price = Convert.ToInt32(reader["Price"]),
                        Quantity = Convert.ToInt32(reader["Quantity"])
                    };
                    return prod;
                }
                    

            }
            catch (SqlException e)
            {
                e.ToString();
            }
            finally
            {               
                conn.Close();
            }
            return default;
        }
    }
}
