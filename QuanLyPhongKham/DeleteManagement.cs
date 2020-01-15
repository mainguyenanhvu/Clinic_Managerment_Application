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
            return database.queryDelete(strDelete);
        }

        public int deleteAll(string[] request)
        {
            string[] keyword = new string[] { "delete", "all" };
            TimeManagementHelper timeManagementHelper = new TimeManagementHelper(request);
            QueryHelper queryHelper = new QueryHelper();
            string strDelete = queryHelper.create(keyword, timeManagementHelper);
            return database.queryDelete(strDelete);
        }
    }
}
