
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
    public class AccountDAO : DBConnection
    {
        public AccountDAO()
        {

        }
        public AccountDTO checkLogin(string email, string password)
        {
            AccountDTO result = null;
            string sql = "SELECT A.Name, RoleID, R.Name AS RoleName, CreateDate FROM Accounts AS A, Roles AS R WHERE A.RoleID = R.ID AND Email =@Email AND Password=@Password AND Status='True'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataReader dr;
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string name = dr["Name"].ToString();
                    int roleID = int.Parse(dr["RoleID"].ToString());
                    string roleName = dr["RoleName"].ToString();
                    DateTime createDate = DateTime.Parse(dr["CreateDate"].ToString());
                    result = new AccountDTO
                    {
                        Email = email,
                        Name = name,
                        Role = new RoleDTO { ID = roleID, Name = roleName },
                        CreateDate = createDate
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public DataTable GetAllAccounts()
        {
            DataTable result = new DataTable();
            string sql = "SELECT Email, Name, Password, RoleID, Status, CreateDate FROM Accounts";
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

                throw;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public bool InsertAccount(AccountDTO account)
        {
            bool result;
            string sql = "INSERT INTO Accounts(Email, Name, Password, RoleID, Status, CreateDate) VALUES(@Email, @Name, @Password, @RoleID, @Status, @CreateDate)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Email", account.Email);
            cmd.Parameters.AddWithValue("@Name", account.Name);
            cmd.Parameters.AddWithValue("@Password", account.Password);
            cmd.Parameters.AddWithValue("@RoleID", account.Role.ID);
            cmd.Parameters.AddWithValue("@Status", account.Status);
            cmd.Parameters.AddWithValue("@CreateDate", account.CreateDate);
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

                throw new Exception("Error at InsertAccount: "+ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public bool UpdateAccount(AccountDTO account)
        {
            bool result;
            string sql = "UPDATE Accounts " +
                " SET Name= @Name, Password= @Password, RoleID= @RoleID, Status= @Status, CreateDate= @CreateDate WHERE Email=@Email";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Email", account.Email);
            cmd.Parameters.AddWithValue("@Name", account.Name);
            cmd.Parameters.AddWithValue("@Password", account.Password);
            cmd.Parameters.AddWithValue("@RoleID", account.Role.ID);
            cmd.Parameters.AddWithValue("@Status", account.Status);
            cmd.Parameters.AddWithValue("@CreateDate", account.CreateDate);
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

                throw new Exception("Error at InsertAccount: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public bool DeleteAccount(AccountDTO account)
        {
            bool result;
            string sql = "UPDATE Accounts SET Status='False' WHERE Email=@Email";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Email", account.Email);
           
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

                throw new Exception("Error at InsertAccount: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public bool IsExistsEmail(string email)
        {
            bool result;
            string sql = "SELECT Email FROM Accounts WHERE Email=@Email";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Email", email);  
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

                throw new Exception("Error at IsExistsEmail: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

    }
}
