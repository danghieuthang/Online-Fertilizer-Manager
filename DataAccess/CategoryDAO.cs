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
    public class CategoryDAO:DBConnection
    {

        public CategoryDAO()
        {

        }

        public DataTable GetDataTableCategory()
        {
           
            DataTable result = new DataTable();
            string sql = "SELECT ID, Name FROM Category";
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

                throw new Exception("Error at GetDataTableCategory");
            }
            finally
            {
                conn.Close();
            }
            return result;

        }

        public bool InsertCategory(CategoryDTO category)
        {
            bool result;
            string sql = "INSERT INTO Category(Name) VALUES(@Name)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", category.Name);
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

                throw new Exception("Error at InsertCategory: "+ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public bool IsExistsCategory(string categoryName)
        {
            bool result;
            string sql = "SELECT Name FROM Category WHERE Name=@Name";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", categoryName);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                result = reader.Read();
            }
            catch (Exception ex)
            {

                throw new Exception("Error at InsertCategory: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public bool UpdateCategory(CategoryDTO category)
        {
            bool result;
            string sql = "UPDATE Category SET Name=@Name WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", category.Name);
            cmd.Parameters.AddWithValue("@ID", category.ID);

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

                throw new Exception("Error at UpdateCategory: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public bool DeleteCategory(CategoryDTO category)
        {
            bool result;
            string sql = "DELETE FROM Category WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID", category.ID);
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

                throw new Exception("Error at DeleteCategory: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
