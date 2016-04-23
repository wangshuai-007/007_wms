using System;
using System.Collections.Generic;
using System.Windows.Forms;
using 仓库管理系统.BLL;
using 仓库管理系统.DAL;
using System.Configuration;
using 仓库管理系统.Properties;


namespace 仓库管理系统
{
    public partial class LoginForm : Form
    {
        /// <summary>
        /// 显示默认界面
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            IOHelper read = new IOHelper();
            List<string> output = new List<string>();
            output.AddRange(read.ReaderUser());
            output.Reverse();         
            comboBox1.DataSource =output ;
            IOHelper load = new IOHelper();
            load.ReadConfig();
            SerTxt.Text = DBHelper.SerName;
            if (IOHelper.PswChk == true)
            {
                comboBox1.Text = IOHelper.userId;
                textBox2.Text = IOHelper.password;
                PswChk.Checked = true;
            }
          
            


        }
        private void Login()
        {
            LoginClass init = new LoginClass();
            IOHelper write = new IOHelper();
            LoginForm login=new LoginForm();
            string user = comboBox1.Text;
            string psw = textBox2.Text;
            string sername = SerTxt.Text;
            if (init.JudgeUser(user, psw, sername))
            {
                write.WriteConfig(sername, user, psw, PswChk.Checked);
                write.RemenberUser(user);
                DialogResult = DialogResult.OK;
                //Panel
                //SplitContainer

            }
            else
                textBox2.Clear();


        }
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (SetBtn.Text == "设置↑")
                {
                    SetBtn.Text = "设置↓";
                    this.Height = 197;
                }
                else
                {
                    SetBtn.Text = "设置↑";
                    this.Height = 267;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(ConfigurationManager.AppSettings.Count));
            //comboBox1.DataSource = ConfigurationManager.AppSettings.Count;
            //comboBox1.Items.Add("13");
            //comboBox1.Items.AddRange(ConfigurationManager.AppSettings.AllKeys);
            textBox2.Clear();
            if (comboBox1.Text==Settings.Default.UerID)
            {
                textBox2.Text = Settings.Default.Password;
            }

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
         
           
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            //if (comboBox1.Items.Count>0)
            //{
            //    comboBox1.DataSource = null;
            //    comboBox1.Items.Clear();

            //}
            //comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("你确定要退出吗？", "退出系统", MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk) == DialogResult.Yes)
            //{
            //    Dispose();
            //    Application.Exit();
            //}
            //else
            //    e.Cancel = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
