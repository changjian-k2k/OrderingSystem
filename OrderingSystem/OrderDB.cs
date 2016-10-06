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
        private static string strNull = "NULL";
        public static SqlConnection GetConnection()
        {
            //string conStr = Properties.Settings.Default.PennyPetOrderingConnectionString;
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\SkyDrive\Projects\OrderingSystem\OrderingSystem\PennyPetOrdering.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conStr);
            return conn;
        }

        public static void AddOrder(OrderForm order)
        {
            //string insStmt = "INSERT INTO OrderItem (Id, Buyer, Good, Price,Quantity,GoodColor,GoodSize,Remark,Address,OrderDate,ShipDate,Photo,PaymentStatus) VALUES (@id,@buyer,@good,@price,@quantity,@goodColor,@goodSize,@remark,@address,@orderDate,@shipDate,@photo,@paymentStatus)";
            //SqlConnection conn = GetConnection();
            //SqlCommand insCmd = new SqlCommand(insStmt, conn);
            //insCmd.Parameters.AddWithValue("@id", order.Id);
            string insStmt = "INSERT INTO OrderItem (Buyer, Good, Price,Quantity,GoodColor,GoodSize,Remark,Address,OrderDate,ShipDate,Photo,PaymentStatus) VALUES (@buyer,@good,@price,@quantity,@goodColor,@goodSize,@remark,@address,@orderDate,@shipDate,@photo,@paymentStatus)";
            SqlConnection conn = GetConnection();
            SqlCommand insCmd = new SqlCommand(insStmt, conn);
            insCmd.Parameters.AddWithValue("@buyer", order.Buyer);
            insCmd.Parameters.AddWithValue("@good", order.Good);
            insCmd.Parameters.AddWithValue("@price", order.Price);
            insCmd.Parameters.AddWithValue("@quantity", order.Quantity);
            insCmd.Parameters.AddWithValue("@goodColor", order.GoodColor);
            insCmd.Parameters.AddWithValue("@goodSize", order.GoodSize);
            if (order.Remark == null)
            {
                insCmd.Parameters.AddWithValue("@remark", DBNull.Value);
            }
            else
            {
                insCmd.Parameters.AddWithValue("@remark", order.Remark);
            }
            insCmd.Parameters.AddWithValue("@address", order.Address);
            insCmd.Parameters.AddWithValue("@orderDate", order.OrderDate);
            insCmd.Parameters.AddWithValue("@shipDate", order.ShipDate);
            if (order.Photo == null)
            {
                insCmd.Parameters.AddWithValue("@photo", DBNull.Value);
            }
            else
            {
                insCmd.Parameters.AddWithValue("@photo", order.Photo);
            }
            insCmd.Parameters.AddWithValue("@paymentStatus", order.PaymentStatus);

            //string insStmt = "INSERT INTO OrderItem (Buyer, Good) VALUES (@buyer,@good)";
            //SqlConnection conn = GetConnection();
            //SqlCommand insCmd = new SqlCommand(insStmt, conn);
            //insCmd.Parameters.AddWithValue("@buyer", order.Buyer);
            //insCmd.Parameters.AddWithValue("@good", order.Good);

            try
            {
                conn.Open();
                insCmd.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }
        }

        public static List<OrderForm> GetOrder()
        {
            List<OrderForm> orderList = new List<OrderForm>();
            SqlConnection conn = GetConnection();
            string selStmt = "SELECT * FROM OrderItem";
            SqlCommand selCmd = new SqlCommand(selStmt, conn);
            //try
            //{
            //    conn.Open();
            //    SqlDataReader reader = selCmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        OrderForm order = new OrderForm();
            //        order.Id = (int)reader["Id"];
            //        order.Buyer = reader["Buyer"].ToString();
            //        order.Good = reader["Good"].ToString();
            //        order.Price = (decimal)reader["Price"];
            //        order.Quantity = (int)reader["Quantity"];
            //        order.GoodColor = reader["GoodColor"].ToString();
            //        order.GoodSize = reader["GoodSize"].ToString();
            //        order.Remark = reader["Remark"].ToString();
            //        order.Address = reader["Address"].ToString();
            //        order.OrderDate = (DateTime)reader["OrderDate"];
            //        order.ShipDate = (DateTime)reader["ShipDate"];
            //        order.Photo = reader["Photo"].ToString();
            //        order.PaymentStatus = reader["PaymentStatus"].ToString();
            //        orderList.Add(order);
            //    }
            //    reader.Close();
            //}
            //catch (SqlException ex) { throw ex; }
            //finally { conn.Close(); }
            return orderList;
        }
    }
}
