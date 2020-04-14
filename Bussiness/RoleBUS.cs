using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class RoleBUS
    {
        RoleDAO roleDAO = new RoleDAO();
        public RoleBUS()
        {

        }
        public DataTable GetAllRoles()
        {
            return roleDAO.GetAllRoles();
        }
    }
}
