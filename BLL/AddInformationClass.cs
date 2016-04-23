using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using 仓库管理系统.DAL;

namespace 仓库管理系统.BLL
{
    class AddInformationClass
    {
        public static bool AddUser(string username, string usersex, string usertel, string userroot, string userpsw, string userid, string userbirth, string useraddr, string userage)
        {
            if (!DBHelper.SqlJudge("select 员工编号 from 员工表 where 员工编号 = " + userid))
            {
                string sqlstr = @"insert into 员工表(姓名,性别,联系电话,权限,密码,员工编号,出生日期,家庭住址,年龄)
values(" + "'" + username + "'," + "'" + usersex + "'," + "'" + usertel + "'," + "'" + userroot + "'," + "'" +
userpsw + "'," + "'" + userid + "'," + "'" + userbirth + "'," + "'" + useraddr + "'," + "'" + userage + "')";
                DBHelper.SqlDml(sqlstr);
                MessageBox.Show("添加成功！", "新增用户添加成功");
                return true;
            }
            else
            {
                MessageBox.Show("员工编号已存在，请重新输入！", "输入错误");

                return false;
            }

        }
        //public static string JudgeNull(string input,string judgeType)
        //{
        //    if (input=="")
        //    {
        //        MessageBox.Show("请输入" + judgeType, "输入错误!");
        //    }
        //    else
        //    {
        //        input = "'" + input + "'";
        //        return input;
        //    }

        //}
    }
}
