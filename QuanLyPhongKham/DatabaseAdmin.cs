using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyPhongKham
{
    public class DatabaseAdmin
    {
        //private string connectionString = System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString();
        private SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["QLPKConnectionString"].ToString());
        public DatabaseAdmin()
        {
            connection.Open();
        }
        public DataTable querySearch(string queryString)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter(queryString, connection);
            DataTable dttb = new DataTable();
            sqlDa.Fill(dttb);
            return dttb;
        }

        ~DatabaseAdmin()
        {
            connection.Close();
        }
    }
}