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
        public static void AddGood(GoodForm good)
        {
            string insStmt = "INSERT INTO Good (Name, Color, Size, Price, Photo) VALUES (@name,@color,@size,@price,@photo)";
            SqlConnection conn = GetConnection();
            SqlCommand insCmd = new SqlCommand(insStmt, conn);
            insCmd.Parameters.AddWithValue("@name", good.Name ?? strNull);
            insCmd.Parameters.AddWithValue("@color", good.Color ?? strNull);
            insCmd.Parameters.AddWithValue("@size", good.Size ?? strNull);
            insCmd.Parameters.AddWithValue("@price", good.Price ?? 0);
            insCmd.Parameters.AddWithValue("@photo", good.Photo ?? strNull);

            try
            {
                conn.Open();
                insCmd.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close();  }
        }

        public static List<GoodForm> GetGood()
        {
            List<GoodForm> goodList = new List<GoodForm>();
            SqlConnection conn = GetConnection();
            string selStmt = "SELECT * FROM Good";
            SqlCommand selCmd = new SqlCommand(selStmt, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = selCmd.ExecuteReader();
                while (reader.Read())
                {
                    GoodForm good = new GoodForm();
                    good.Id = (int)reader["GoodID"];
                    good.Name = reader["Name"].ToString();
                    good.Color = reader["Color"].ToString();
                    good.Size = reader["Size"].ToString();
                    good.Price = (decimal?)reader["Price"];

                    goodList.Add(good);
                }
            }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }

            return goodList;
        }
    }
}
