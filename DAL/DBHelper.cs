using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 仓库管理系统
{
    class DBHelper
    {
        public static bool LogFlag = false;
        public static bool ReturnFlag = false;
        public static string SerName;
        public static SqlConnection con;
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="SerName">数据库名称</param>
        public static void ConServer(string SerName)
        {
            try
            {
                //1.连接通道的连接字符串
                string conStr = "server = " + SerName + ";database=Storage_WMS;integrated security=sspi";
                //string conStr = "server = " + SerName + ";database=Storage;integrated security=true";
                //2.连接通道对象
                con = new SqlConnection(conStr);
                //3.打开通道
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("服务器设置错误！");

            }
        }
        /// <summary>
        /// 判断数据库中是否存在元素
        /// </summary>
        /// <param name="sqlstr">SQL查询语句</param>
        /// <returns>是否存在</returns>
        public static bool SqlJudge(string sqlstr)
        {
            try
            {
                ConServer(SerName);
                using (SqlCommand cmd=new SqlCommand(sqlstr,con))
                {
                    cmd.CommandText = sqlstr;
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {                       
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (SqlException e)
            {

                throw e;
            }

        }
        ///// <summary>
        ///// sql查询语句,查询一个结果
        ///// </summary>
        ///// <param name="sqlstr">查询语句</param>
        /////  <param name="sqltype">查询的列</param>
        ///// <returns>有无数据</returns>
        //public static bool SqlSelect(string sqlstr,string sqltype, out string sqlresult)
        //{
        //    //新建连接，打开通道
        //    ConServer(SerName);
        //    //新建工人，从con（道路）去数据库执行SqlStr
        //    using (SqlCommand cmd = new SqlCommand(sqlstr, con))
        //    {
        //        try
        //        {
        //            cmd.CommandText = sqlstr;
        //            //将查询结果返回给reader
        //            SqlDataReader reader = cmd.ExecuteReader();
        //            if (reader.Read())
        //            {
        //                sqlresult = reader.GetString(reader.GetOrdinal(sqltype));
        //                con.Close();
        //                return true;
        //            }
        //            else
        //            {
        //                sqlresult = "-1";
        //                con.Close();
        //                return false;
        //            }
        //        }
        //        catch (System.Data.SqlClient.SqlException e)
        //        {
        //            con.Close();
        //            throw e;
        //        }
        //    }



        //}
        /// <summary>
        /// 查询结果集
        /// </summary>
        /// <param name="sqlstr">SQL查询语句</param>
        /// <returns>结果集</returns>
        public static DataTable SqlAdapter(string sqlstr)
        {
            try
            {
                ConServer(SerName);//新建连接，打开通道
                using (SqlDataAdapter da = new SqlDataAdapter())//实例化SqlDataAdapter
                {
                    using (SqlCommand cmd = new SqlCommand(sqlstr, con))//设置SQL查询语句
                    {
                        da.SelectCommand = cmd;//设置为以实例化SqlDataAdapter的查询语句
                        DataTable ds = new DataTable();//实例化数据集
                        da.Fill(ds);//把数据填充到DataSet中
                        return ds;
                    }
                }
            }
            catch (SqlException e)
            {
                con.Close();
                throw e;
            }
        }
        public static void SqlDml(string sqlstr)
        {
            try
            {
                ConServer(SerName);
                using (SqlCommand cmd = new SqlCommand(sqlstr, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {

                throw e;
            }

        }
    }
}
