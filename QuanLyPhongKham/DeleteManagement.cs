using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham
{
    public class DeleteManagement
    {
        private DatabaseAdmin database = new DatabaseAdmin();
        public int deleteOne( string[] request)
        {
            string[] keyword = new string[] { "delete", "one" };
            QueryHelper queryHelper = new QueryHelper();
            string strDelete = queryHelper.create(keyword, request);
            return database.queryDelect(strDelete);
        }

        public int deleteAll(string[] request)
        {
            string[] keyword = new string[] { "delete", "all" };
            QueryHelper queryHelper = new QueryHelper();
        }
    }
}
