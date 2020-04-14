using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
   public class OrderBUS
    {
        OrderDAO orderDAO = new OrderDAO();
        public OrderBUS()
        {

        }
        public DataTable GetDataTableAllOrder()
        {
            return orderDAO.GetAllOrders();
        }
        public DataTable GetDataTableSearch(string dateFrom, string dateTo)
        {
            return orderDAO.Searchorders(dateFrom, dateTo);
        }
        public DataTable GetDataTableNumberPOfCategory()
        {
            return orderDAO.GetDataTableNumberPOfCategory();
        }
        public DataTable GetDataTableNumberProductSell()
        {
            return orderDAO.GetDataTableNumberPOfProduct();
        }
        public DataTable GetTopProductSellByWeek()
        {
            return orderDAO.GetTopProductSellByWeek();
        }
        public DataTable GetTopProductSellByMonth()
        {
            return orderDAO.GetTopProductSellByMonth();
        }
       

    }
}
