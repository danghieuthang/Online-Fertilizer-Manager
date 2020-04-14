using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CommentDTO
    {
        private int iD;
        private AccountDTO account;
        private ProductDTO product;
        private string message;
        private DateTime createDate;
        private bool status;

        public int ID { get => iD; set => iD = value; }
        public AccountDTO Account { get => account; set => account = value; }
        public ProductDTO Product { get => product; set => product = value; }
        public string Message { get => message; set => message = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public bool Status { get => status; set => status = value; }
    }
}
