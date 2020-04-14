using DataAccess;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class ProductBUS
    {
        ProductDAO productDAO = new ProductDAO();
        public ProductBUS()
        {

        }
        public DataTable GetDataTableProducts()
        {
            return productDAO.GetDataTableProducts();
        }
        public bool InsertProduct(ProductDTO product)
        {
            return productDAO.InsertProduct(product);
        }
        public bool UpdateProduct(ProductDTO product)
        {
            return productDAO.UpdateProduct(product);
        }
        public bool DeleteProduct(ProductDTO product)
        {
            return productDAO.DeleteProduct(product);
        }
        public bool IsExistsInsert(ProductDTO product)
        {
            return productDAO.IsExistsInsert(product);
        }
        public bool IsExistsUpdate(ProductDTO product)
        {
            return productDAO.IsExistsUpdate(product);
        }
    }
}
