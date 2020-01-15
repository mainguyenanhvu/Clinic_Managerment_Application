using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyPhongKham
{
    public class Condition
    {
        protected DatabaseAdmin database = new DatabaseAdmin();
        public virtual DataTable search(string[] conditionstring)
        {
            return null;
        }
    }
}