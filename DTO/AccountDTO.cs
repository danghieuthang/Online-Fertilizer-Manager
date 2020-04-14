using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class AccountDTO
    {
        private string email;
        private string name;
        private string password;
        private RoleDTO role;
        private bool status;
        private DateTime createDate;

        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public bool Status { get => status; set => status = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public RoleDTO Role { get => role; set => role = value; }
    }
}
