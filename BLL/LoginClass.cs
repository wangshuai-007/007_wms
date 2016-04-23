using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 仓库管理系统.Properties;
using 仓库管理系统.DAL;
using System.Configuration;
using System.Data;

namespace 仓库管理系统.BLL
{
    /// <summary>
    /// 实现对登陆操作的逻辑判定
    /// </summary>
    class LoginClass
    {
       
        /// <summary>
        /// 实现对登陆操作的逻辑判定
        /// </summary>
        /// <param name="用户名"></param>
        /// <param name="密码"></param>
        /// <returns>返回判定结果，true为验证成功，false为验证失败</returns>
        public bool JudgeUser(string userid, string password,string sername)
        {
            if (userid == "")
            {
                MessageBox.Show("请输入员工编号！","输入错误");
                return false;
            }
            else if (password == "")
            {
                MessageBox.Show("请输入密码！", "输入错误");
                return false;
            }
            else if (sername=="")
            {
                MessageBox.Show("请输入服务器名字！", "输入错误");
                return false;
            }
            else
            {
                string sqlstr = "select 密码 from 员工表 where 员工编号=" + userid;
                string sqltable = "select * from 员工表 where 员工编号=" + userid;
                //string sqlresult;
                if (DBHelper.SqlJudge(sqlstr))
                {
                    DataTable ds = new DataTable();
                    ds = DBHelper.SqlAdapter(sqltable);
                    if (ds.Rows[0]["密码"].ToString().Trim() == password.Trim())
                    {
                        IOHelper.uerName = ds.Rows[0]["姓名"].ToString().Trim();
                        if (ds.Rows[0]["权限"].ToString().Trim() == "管理员")
                        {
                            IOHelper.userRoot = true;
                        }
                        else
                            IOHelper.userRoot = false;
                        return true;
                    }
                    //foreach (DataRow item in ds.Rows)
                    //{
                    //    foreach (DataColumn item2 in ds.Columns)
                    //    {
                    //        if (item2.ColumnName == "密码")
                    //        {
                    //            if (Convert.ToString(item[item2]) == password.Trim())
                    //            {
                    //                return true;
                    //            }
                    //            else
                    //            {
                    //                MessageBox.Show("账号密码错误，请重新输入！");
                    //                return false;

                    //            }
                    //        }
                    //        else
                    //            continue;
                    //    }

                    //}
                    return false;
                }
                //if (DBHelper.SqlSelect(sqlstr,"密码", out sqlresult)&&sqlresult.Trim()==password)
                //{

                //    return true;

                //}
                else
                {
                    MessageBox.Show("账号密码错误，请重新输入！", "输入错误");
                    
                    return false;
                }
            }
        }
     
        /// <summary>
        /// 判断是否要删除以前的用户名
        /// </summary>
        /// <returns>True为要删除，False为不删除</returns>
        public bool JudgeDelate()
        {
            IOHelper users = new IOHelper();
            if (users.ReaderUser().Count>4)
            {
                return true;
            }
            else
                return false;
        }
    }
}
