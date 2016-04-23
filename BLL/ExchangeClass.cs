using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using 仓库管理系统.DAL;

namespace 仓库管理系统.BLL
{
    class ExchangeClass
    {
        public static Dictionary<string,string> employeeName=new Dictionary<string, string>();
        public static List<string> employeeID=new List<string>();
        public static Dictionary<string, string> employeeRoot = new Dictionary<string, string>();
        /// <summary>
        /// 读取表中的一列数据
        /// </summary>
        /// <param name="select">查询的列名</param>
        /// <returns>所查询列的泛型数组</returns>
        public static List<string> ReadOneColumns(string select)
        {
            DataTable table = new DataTable();
            DBHelper read = new DBHelper();
            List<string> employeeid = new List<string>(); 
            if (select=="员工编号")
            {
                string sqlstr = "select * from 员工表";
                table=DBHelper.SqlAdapter(sqlstr);
                foreach (DataRow item in table.Rows)
                {                    
                    employeeID.Add(item["员工编号"].ToString().Trim());
                    employeeName.Add(item["员工编号"].ToString().Trim(),item["姓名"].ToString().Trim());
                    employeeRoot.Add(item["员工编号"].ToString().Trim(), item["权限"].ToString().Trim());
                    if (item["员工编号"].ToString().Trim()!=IOHelper.userId)
                    {
                    employeeid.Add(item["员工编号"].ToString().Trim());

                    }
                }
            }
            else if (select=="姓名")
            {
                string sqlstr = "select 姓名 from 员工表";
                table=DBHelper.SqlAdapter(sqlstr);
            }
            return employeeid ;
        }
        /// <summary>
        /// 读取表中某一行的某一个字段
        /// </summary>
        /// <param name="select">字段名称</param>
        /// <returns>查询结果</returns>
        public static string ReadOne(string select)
        {
            DataTable dt = new DataTable();
            if (select=="权限")
            {
                string sqlstr = "select 权限 from 员工表 where 员工编号= "+IOHelper.userId;
                dt = DBHelper.SqlAdapter(sqlstr);
                return dt.Rows[0]["权限"].ToString().Trim();                
            }
            return "0";
        }
        /// <summary>
        /// 获取当前用户的权限
        /// </summary>
        public static void RemenberRoot()
        {
            string root= ReadOne("权限");
            if (root == "管理员")
            {
                IOHelper.userRoot = true;
            }
            else
                IOHelper.userRoot = false;
        }
        public static void RemenberRoot(string userId)
        {

        }
    }
}
