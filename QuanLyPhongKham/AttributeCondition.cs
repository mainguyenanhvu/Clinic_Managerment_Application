using System.Data;
using System.Data.SqlClient;

namespace QuanLyPhongKham
{
    public class AttributeCondition : Condition
    {
        override public DataTable search(string[] conditionstring)
        {
            StringSearch stringSearch = new StringSearch(conditionstring[0]);
            QueryHelper queryHelper = new QueryHelper();
            string querySearch = queryHelper.create(new string[] { "select", "attribute" }, stringSearch);
            return database.querySearch(querySearch);
        }
    }
}