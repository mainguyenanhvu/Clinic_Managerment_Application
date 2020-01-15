using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyPhongKham
{
    public class TimeCondition : Condition
    {

        override public DataTable search(string[] conditionstring)
        {
            TimeManagementHelper timeHelper = new TimeManagementHelper(conditionstring);
            QueryHelper queryHelper = new QueryHelper();
            string querySearch = queryHelper.create(new string[] { "select", "time" }, timeHelper);
            return database.querySearch(querySearch);
        }
    }
}