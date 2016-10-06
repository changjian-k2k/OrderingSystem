using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OrderingSystem
{
    public static partial class OrderingSystemDB
    {
        public static void AddOrderingSystem(OrderingSystemForm os)
        {
            //string insStmt = "INSERT INTO OrderItem (Id, Buyer, Good, Price,Quantity,GoodColor,GoodSize,Remark,Address,OrderDate,ShipDate,Photo,PaymentStatus) VALUES (@id,@buyer,@good,@price,@quantity,@goodColor,@goodSize,@remark,@address,@orderDate,@shipDate,@photo,@paymentStatus)";
            //SqlConnection conn = GetConnection();
            //SqlCommand insCmd = new SqlCommand(insStmt, conn);
            //insCmd.Parameters.AddWithValue("@id", order.Id);
            string insStmt = "INSERT INTO OrderItem (ClientID,GoodID,Price,Quantity,Remark,OrderDate,ShipDate,Photo,PaymentStatus,Discount,Amount) VALUES (@clientID,@goodID,@price,@quantity,@remark,@orderDate,@shipDate,@photo,@paymentStatus,@discount,@amount)";
            SqlConnection conn = GetConnection();
            SqlCommand insCmd = new SqlCommand(insStmt, conn);
            insCmd.Parameters.AddWithValue("@clientID", os.ClientID);
            insCmd.Parameters.AddWithValue("@goodID", os.GoodID);
            insCmd.Parameters.AddWithValue("@price", os.Price);
            insCmd.Parameters.AddWithValue("@quantity", os.Quantity);
            if (os.Remark == null)
            {
                insCmd.Parameters.AddWithValue("@remark", DBNull.Value);
            }
            else
            {
                insCmd.Parameters.AddWithValue("@remark", os.Remark);
            }
            insCmd.Parameters.AddWithValue("@orderDate", os.OrderDate);
            insCmd.Parameters.AddWithValue("@shipDate", os.ShipDate);
            insCmd.Parameters.AddWithValue("@paymentStatus", os.PaymentStatus);
            insCmd.Parameters.AddWithValue("@discount", os.Discount);
            insCmd.Parameters.AddWithValue("@amount", os.Amount);

            try
            {
                conn.Open();
                insCmd.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }
        }

        public static List<OrderingSystemForm> GetOrderingSystem()
        {
            List<OrderingSystemForm> osList = new List<OrderingSystemForm>();
            SqlConnection conn = GetConnection();
            string selStmt = "SELECT * FROM OrderItem";
            SqlCommand selCmd = new SqlCommand(selStmt, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = selCmd.ExecuteReader();
                while (reader.Read())
                {
                    OrderingSystemForm osForm = new OrderingSystemForm();
                    osForm.Id = (int)reader["OrderID"];
                    osForm.ClientID = (int)reader["ClientID"];
                    osForm.GoodID = (int)reader["GoodID"];
                    osForm.Price = (decimal?)reader["Price"];
                    osForm.Quantity = (int)reader["Quantity"];
                    osForm.Remark = reader["Remark"].ToString();
                    osForm.OrderDate = (DateTime)reader["OrderDate"];
                    osForm.ShipDate = (DateTime)reader["ShipDate"];
                    osForm.PaymentStatus = reader["PaymentStatus"].ToString();
                    osForm.Discount = (decimal?)reader["Discount"];
                    osForm.Amount = (decimal?)reader["Amount"];

                    osList.Add(osForm);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }
            return osList;
        }
    }
}
