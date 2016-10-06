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
        public static void AddClient(ClientForm client)
        {
            string insStmt = "INSERT INTO Client (Address, NameWeChat, Phone, Addressee) VALUES (@address,@name,@phone,@addressee)";
            SqlConnection conn = GetConnection();
            SqlCommand insCmd = new SqlCommand(insStmt, conn);
            insCmd.Parameters.AddWithValue("@address", client.Address ?? strNull);
            insCmd.Parameters.AddWithValue("@name", client.Name ?? strNull);
            insCmd.Parameters.AddWithValue("@phone", client.Phone ?? strNull);
            insCmd.Parameters.AddWithValue("@addressee", client.Addressee ?? strNull);

            try
            {
                conn.Open();
                insCmd.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }
        }

        public static List<ClientForm> GetClient()
        {
            List<ClientForm> clientList = new List<ClientForm>();
            SqlConnection conn = GetConnection();
            string selStmt = "SELECT * FROM Client";
            SqlCommand selCmd = new SqlCommand(selStmt, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = selCmd.ExecuteReader();
                while (reader.Read())
                {
                    ClientForm client = new ClientForm();
                    client.Id = (int)reader["ClientID"];
                    client.Address = reader["Address"].ToString();
                    client.Name = reader["NameWeChat"].ToString();
                    client.Phone = reader["Phone"].ToString();
                    client.Addressee = reader["Addressee"].ToString();

                    clientList.Add(client);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }
            return clientList;
        }
    }
}
