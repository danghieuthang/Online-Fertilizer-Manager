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
    public class CategoryBUS
    {
        CategoryDAO categoryDAO = new CategoryDAO();
        public CategoryBUS()
        {          
        }
        public DataTable GetDataTableCategory()
        {
            return categoryDAO.GetDataTableCategory();
        }
        public bool InsertCategory(CategoryDTO category)
        {
            return categoryDAO.InsertCategory(category);
        }
        public bool DeleteCategory(CategoryDTO category)
        {
            return categoryDAO.DeleteCategory(category);
        }
        public bool UpdateCategory(CategoryDTO category)
        {
            return categoryDAO.UpdateCategory(category);
        }
        public bool IsExistsCategory(string categoryName)
        {
            return categoryDAO.IsExistsCategory(categoryName);
        }

    }
}
