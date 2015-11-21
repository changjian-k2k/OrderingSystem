using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OrderingSystem
{
    public class TestTableDB
    {
        public static SqlConnection GetConnection()
        {
            string connStr = Properties.Settings.Default.PennyPetOrderingConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            return conn;
        }

        public static void AddItem(string Name)
        {
            List<string> preStr = GetItems();
            string insStmt = "INSERT INTO TESTTABLE (NAME) VALUES (@Name)";
            SqlConnection conn = GetConnection();
            SqlCommand insCmd = new SqlCommand(insStmt, conn);
            insCmd.Parameters.AddWithValue("@Name", Name);
            try
            {
                conn.Open();
                int rlt = insCmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            List<string> sufStr = GetItems();
        }

        public static List<string> GetItems()
        {
            List<string> orderList = new List<string>();
            SqlConnection conn = GetConnection();
            string selStmt = "SELECT * FROM TESTTABLE";
            SqlCommand selCmd = new SqlCommand(selStmt, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = selCmd.ExecuteReader();
                while (reader.Read())
                {
                    string myStr = reader["NAME"].ToString();
                    orderList.Add(myStr);
                }
                reader.Close();
            }
            catch (SqlException ex) { throw ex; }
            finally { conn.Close(); }
            return orderList;
        }
    }
}
