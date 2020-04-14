using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO:DBConnection
    {
        public ProductDAO()
        {

        }
        public DataTable GetDataTableProducts()
        {
            DataTable result=new DataTable();
            string sql = "SELECT ID, Title, Description, Price, CategoryID, Quantity, Status, Image FROM Products";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                adapter.Fill(result);
            }
            catch (Exception)
            {

                throw new Exception("Error at GetDataTableProducts");
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public bool IsExistsInsert(ProductDTO product)
        {
            bool result = true;
            string sql = "SELECT ID FROM Products WHERE Title=@Title";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Title", product.Title);
            
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                result = reader.HasRows;
            }
            catch (Exception ex)
            {

                throw new Exception("Error at InsertProduct: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public bool IsExistsUpdate(ProductDTO product)
        {
            bool result = true;
            string sql = "SELECT ID FROM Products WHERE Title=@Title AND ID!=@ID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Title", product.Title);
            cmd.Parameters.AddWithValue("@ID", product.ID);


            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                result = reader.HasRows;
            }
            catch (Exception ex)
            {

                throw new Exception("Error at InsertProduct: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public bool InsertProduct(ProductDTO product)
        {
            bool result = true;
            string sql = "INSERT INTO Products(Title, Description, Price, Quantity, Status, Image, CategoryID) " +
                "VALUES(@Title, @Description, @Price, @Quantity, @Status, @Image, @CategoryID)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Title", product.Title);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
            cmd.Parameters.AddWithValue("@Status", product.Status);
            cmd.Parameters.AddWithValue("@Image", product.Image);
            cmd.Parameters.AddWithValue("@CategoryID", product.Category.ID);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {

                throw new Exception("Error at InsertProduct: "+ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public bool UpdateProduct(ProductDTO product)
        {
            bool result = true;
            string sql = "UPDATE Products " +
                "SET Title= @Title, Description= @Description, " +
                "Price= @Price, Quantity= @Quantity, Status= @Status, " +
                "Image= @Image, CategoryID= @CategoryID " +
                "WHERE ID= @ID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Title", product.Title);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@Quantity", product.Quantity);
            cmd.Parameters.AddWithValue("@Status", product.Status);
            cmd.Parameters.AddWithValue("@Image", product.Image);
            cmd.Parameters.AddWithValue("@CategoryID", product.Category.ID);
            cmd.Parameters.AddWithValue("@ID", product.ID);

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {

                throw new Exception("Error at UpdateProduct: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public bool DeleteProduct(ProductDTO product)
        {
            bool result = true;
            string sql = "UPDATE Products SET Status='False' WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", product.ID);

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                result = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {

                throw new Exception("Error at DeleteProduct: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
