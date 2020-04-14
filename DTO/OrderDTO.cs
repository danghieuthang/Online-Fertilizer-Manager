using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDTO
    {
        private int iD;
        private ProductDTO product;
        private int quantity;
        private float total;
        private TransactionDTO transaction;

        public int ID { get => iD; set => iD = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public ProductDTO Product { get => product; set => product = value; }
        public float Total { get => total; set => total = value; }
        public TransactionDTO Transaction { get => transaction; set => transaction = value; }
    }
}
