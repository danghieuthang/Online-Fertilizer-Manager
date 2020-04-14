using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDTO
    {
        private int iD;
        private string title;
        private string description;
        private float price;
        private CategoryDTO category;
        private int quantity;
        private bool status;
        private string image;

        public int ID { get => iD; set => iD = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public float Price { get => price; set => price = value; }
        public CategoryDTO Category { get => category; set => category = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public bool Status { get => status; set => status = value; }
        public string Image { get => image; set => image = value; }
    }
}
