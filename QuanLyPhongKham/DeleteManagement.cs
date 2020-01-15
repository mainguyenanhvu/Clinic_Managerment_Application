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
        public int delete(string[] keyword, string[] request)
        {
            QueryHelper queryHelper = new QueryHelper();
            string strDelete = queryHelper.create(keyword, request);
            return database.queryDelect(strDelete);
        }
    }
}
