using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using 仓库管理系统.DAL;
using 仓库管理系统.BLL;

namespace 仓库管理系统.UI
{
    public partial class AddUserForm : DevExpress.XtraEditors.XtraForm
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserConfireBtn_Click(object sender, EventArgs e)
        {
            User addUser = new User();
            if (AddUserNameTxt.Text == "")
            {
                MessageBox.Show("请填写姓名！", "输入错误");
            }
            else
                       if (AddUserSexCmb.Text == "")
            {
                MessageBox.Show("请选择性别！", "输入错误");
            }
            else

            if (AddUserTelTxt.Text == "")
            {
                MessageBox.Show("请填写联系方式！", "输入错误");

            }
            else if (AddUserBirthData.Text == "")
            {
                MessageBox.Show("请选择出生日期！", "输入错误");

            }
            else if (AddUserPswTxt.Text == "")
            {
                MessageBox.Show("请填写密码！", "输入错误");

            }
            else if (AddUserRePswTxt.Text == "")
            {
                MessageBox.Show("请填写确认密码！", "输入错误");
            }
            else if (AddUserPswTxt.Text != AddUserRePswTxt.Text)
            {
                MessageBox.Show("两次输入的密码不一致！", "输入错误");
            }
            else if (AddUserIdTxt.Text == "")
            {
                MessageBox.Show("请填写员工编号！", "输入错误");
            }
            else if (AddUserAddrTxt.Text == "")
            {
                MessageBox.Show("请填写家庭地址！", "输入错误");
            }
            else if (Convert.ToInt32((DateTime.Now.Year - AddUserBirthData.DateTime.Year)) <= 0)
            {
                MessageBox.Show("请选择正确的出生日期！", "输入错误");
            }

            else
            {
                addUser.UserName = AddUserNameTxt.Text;
                addUser.UserSex = AddUserSexCmb.Text;
                addUser.UserTel = AddUserTelTxt.Text;
                addUser.UserRoot = AddUserRootCmb.Text;
                addUser.UserPsw = AddUserPswTxt.Text;
                addUser.UserId = AddUserIdTxt.Text;
                addUser.UserBirthday = AddUserBirthData.Text;
                addUser.UserAddr = AddUserAddrTxt.Text;
                addUser.UserAge = (DateTime.Now.Year - AddUserBirthData.DateTime.Year).ToString();
                if (@AddInformationClass.AddUser(AddUserNameTxt.Text, AddUserSexCmb.Text, AddUserTelTxt.Text, AddUserRootCmb.Text,
                    AddUserPswTxt.Text, AddUserIdTxt.Text, AddUserBirthData.DateTime.ToString("yyyy-MM-dd"), AddUserAddrTxt.Text, 
                    (DateTime.Now.Year - AddUserBirthData.DateTime.Year).ToString()))
                {
                    Close();
                }
                
            }
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            if (!IOHelper.userRoot)
            {
                AddUserRootCmb.Properties.ReadOnly = true;
            }
        }
    }
    public class User
    {
        public string UserName;
        public string UserId;
        public string UserSex;
        public string UserBirthday;
        public string UserAge;
        public string UserTel;
        public string UserAddr;
        public string UserRoot;
        public string UserPsw;
    }
}