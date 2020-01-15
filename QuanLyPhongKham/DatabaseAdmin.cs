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

        internal int queryDelect(string queryString)
        {
            SqlCommand cmdP = new SqlCommand(queryString, connection);
            var resP = cmdP.ExecuteNonQuery();
            if (resP == null) return 0;
            return (int)resP;
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