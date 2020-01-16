using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham
{
    public class MedicalCondition : Condition
    {
        public override DataTable search(string[] conditionstring)
        {
            QueryHelper queryHelper = new QueryHelper();
            string querySearch = queryHelper.create(new string[] { "select", "medical" }, conditionstring);
            return database.querySearch(querySearch);
        }
    }
}
