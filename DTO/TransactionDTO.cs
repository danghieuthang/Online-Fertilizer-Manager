using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TransactionDTO
    {
        private int iD;
        private float total;
        private DateTime createDate;
        private AccountDTO customer;
        private bool status;

        public int ID { get => iD; set => iD = value; }
        public float Total { get => total; set => total = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public AccountDTO Customer { get => customer; set => customer = value; }
        public bool Status { get => status; set => status = value; }
    }
}
