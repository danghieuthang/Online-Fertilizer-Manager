using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoryDTO
    {
        private int iD;
        private string name;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
    }
}
