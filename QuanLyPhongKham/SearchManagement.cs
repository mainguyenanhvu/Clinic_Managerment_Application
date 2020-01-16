using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham
{
    public class SearchManagement
    {
        private Dictionary<int, Condition> conditions = new Dictionary<int, Condition> {
            { 0,new TimeCondition()},
            {1, new AttributeCondition() }
        };
        public DataTable find(Dictionary<string,string[]> condition)
        {
            if (condition.ContainsKey("time"))
                return conditions[0].search(condition["time"]);
            else 
                if (condition.ContainsKey("attribute"))
                return conditions[1].search(condition["attribute"]);
            return null;
        }
    }
}