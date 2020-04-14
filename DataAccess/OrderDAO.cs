using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class OrderDAO:DBConnection
    {
        public OrderDAO()
        {

        }
        public DataTable GetAllOrders()
        {
            DataTable result=new DataTable();
            string sql = "SELECT T.ID, T.TransactionID,T.Product, T.Price,T.Quantity, T.Total, Transactions.CustomerEmail, CreateDate FROM Transactions RIGHT OUTER JOIN(SELECT O.ID, O.TransactionID, P.Title AS Product, P.Price, O.Quantity, O.Total FROM Products AS P RIGHT OUTER JOIN Orders AS O ON P.ID= O.ProductID) AS T ON Transactions.ID = T.TransactionID";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                adapter.Fill(result);
            }
            catch (Exception ex)
            {

                throw new Exception("Error at GetDataTableOrder: "+ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
      
      
        public DataTable Searchorders(string dateFrom, string dateTo)
        {
            DataTable result = new DataTable();
            string sql = "SELECT T.ID, T.TransactionID,T.Product, T.Price,T.Quantity, T.Total, Transactions.CustomerEmail, CreateDate  FROM Transactions RIGHT OUTER JOIN (SELECT O.ID, O.TransactionID, P.Title AS Product, P.Price, O.Quantity, O.Total FROM Products AS P RIGHT OUTER JOIN Orders AS O ON P.ID=O.ProductID WHERE O.TransactionID IN(SELECT TransactionID FROM Transactions WHERE CreateDate BETWEEN @DateFrom AND @DateTo)) AS T ON Transactions.ID=T.TransactionID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@DateFrom", dateFrom);
            cmd.Parameters.AddWithValue("@DateTo", dateTo);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                adapter.Fill(result);
            }
            catch (Exception ex)
            {

                throw new Exception("Error at GetDataTableOrder: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public DataTable GetDataTableNumberPOfCategory()
        {
            DataTable result = new DataTable();
            string sql = "SELECT ID, C.Name, T.[Number Of Product] FROM Category C LEFT OUTER JOIN( SELECT P.CategoryID, SUM(O.Quantity) AS 'Number Of Product'FROM Orders AS O LEFT OUTER JOIN Products  as P  ON(O.ProductID = P.ID) GROUP BY CategoryID) AS T ON C.ID = T.CategoryID";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                adapter.Fill(result);
            }
            catch (Exception ex)
            {

                throw new Exception("Error at GetDataTableNumberPOfCategory: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public DataTable GetDataTableNumberPOfProduct()
        {
            DataTable result = new DataTable();
            string sql = "SELECT CONVERT(Nvarchar,ID) AS ProductID, Title, T.[Number Of Product] FROM Products RIGHT OUTER JOIN (SELECT ProductID, SUM(Quantity) As [Number Of Product] FROM Orders GROUP BY ProductID) AS T ON T.ProductID=Products.ID";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                adapter.Fill(result);
            }
            catch (Exception ex)
            {

                throw new Exception("Error at GetDataTableNumberPOfCategory: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public DataTable GetTopProductSellByWeek()
        {
            DataTable result = new DataTable();
            string sql = "SELECT TOP(5) CONVERT(Nvarchar,ID) AS ProductID, Title, T.[Number Of Product] FROM Products RIGHT OUTER JOIN (SELECT ProductID, SUM(Quantity) As [Number Of Product] FROM Orders, Transactions WHERE Orders.TransactionID=Transactions.ID AND DAY(GETDATE()-Transactions.CreateDate)<=@Day GROUP BY ProductID) AS T  ON T.ProductID=Products.ID ORDER BY T.[Number Of Product] DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Day", 7);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                adapter.Fill(result);
            }
            catch (Exception ex)
            {

                throw new Exception("Error at GetDataTableNumberPOfCategory: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
        public DataTable GetTopProductSellByMonth()
        {
            DataTable result = new DataTable();
            string sql = "SELECT TOP(5) CONVERT(Nvarchar,ID) AS ProductID, Title, T.[Number Of Product] FROM Products RIGHT OUTER JOIN (SELECT ProductID, SUM(Quantity) As [Number Of Product] FROM Orders, Transactions WHERE Orders.TransactionID=Transactions.ID AND DAY(GETDATE()-Transactions.CreateDate)<=@Day GROUP BY ProductID) AS T  ON T.ProductID=Products.ID ORDER BY T.[Number Of Product] DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Day", 30);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                adapter.Fill(result);
            }
            catch (Exception ex)
            {

                throw new Exception("Error at GetDataTableNumberPOfCategory: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
   
}
