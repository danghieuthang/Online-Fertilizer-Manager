using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DataAccess;
using System.Data;

namespace Bussiness
{
    public class AccountBUS
    {
        AccountDAO accountDAO = new AccountDAO();
        public AccountBUS()
        {

        }
        public AccountDTO checkLogin(string email, string password)
        {
            return accountDAO.checkLogin(email, password);
        }
        public DataTable GetAllAccounts()
        {
            return accountDAO.GetAllAccounts();
        }
        public bool InsertAccount(AccountDTO account)
        {
            return accountDAO.InsertAccount(account);
        }
        public bool UpdateAccount(AccountDTO account)
        {
            return accountDAO.UpdateAccount(account);
        }
        public bool DeleteAccount(AccountDTO account)
        {
            return accountDAO.DeleteAccount(account);
        }
        public bool IsExistsEmail(string email)
        {
            return accountDAO.IsExistsEmail(email);
        }
    }
}
