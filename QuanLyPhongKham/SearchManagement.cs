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
        public DataTable find(string[] conditionstring)
        {
            switch (conditionstring.Length)
            {
                case 1:
                    return conditions[1].search(conditionstring);
                case 3:
                    return conditions[0].search(conditionstring);
                default:
                    return null;
            }
        }
    }
}