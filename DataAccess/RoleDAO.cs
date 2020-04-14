using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RoleDAO:DBConnection
    {
  
        public RoleDAO()
        {

        }

        public DataTable GetAllRoles()
        {
            DataTable result = new DataTable();
            string sql = "SELECT ID, Name FROM Roles";
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
            catch (Exception ex)
            {

                throw new Exception("Error at GetAllRoles: "+ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
