using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace 仓库管理系统.BLL
{
    class QueryInfoClass
    {
        public static DataTable QueryEmp()
        {
            DataTable dt = new DataTable();
            string sqlstr = "select * from 员工表";
            dt= DBHelper.SqlAdapter(sqlstr);
            return dt;
        }
    }
}
