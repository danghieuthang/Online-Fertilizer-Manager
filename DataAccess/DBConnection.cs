using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DBConnection
    {
      
        protected SqlConnection conn = new SqlConnection("server=.;database=FertilizerDB;uid=sa;pwd=12345678");
    }
}
