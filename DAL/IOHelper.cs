using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Collections;
using 仓库管理系统.BLL;
using System.Reflection;
using 仓库管理系统.Properties;
using System.Xml;
using System.Windows.Forms;

namespace 仓库管理系统.DAL
{
   
    class IOHelper
    {
        public static bool PswChk;
        public static string userId;
        public static string password;
        public static string uerName;
        public static bool userRoot;
        /// <summary>
        /// 读取配置文件
        /// </summary>
        public void ReadConfig()
        {
            userId = Settings.Default.UerID;
            password = Settings.Default.Password;
            DBHelper.SerName = Settings.Default.SerName;
            PswChk = Settings.Default.PswChk;
            uerName = Settings.Default.UerName;
        }
        /// <summary>
        /// 存储设置
        /// </summary>
        /// <param name="sername">服务器名</param>
        /// <param name="userid">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="pswchk">记住密码标记</param>
        public void WriteConfig(string sername, string userid, string password, bool pswchk)
        {
            Settings.Default.SerName = sername;
            Settings.Default.UerID = userid;
            Settings.Default.Password = password;
            Settings.Default.PswChk = pswchk;
            Settings.Default.Save();
        }
        /// <summary>
        /// 读取登陆成功的用户列表
        /// </summary>
        /// <returns>返回的是用户名list表</returns>
        public List<string>  ReaderUser()
        {
            List<string> users = new List<string>();
            users.AddRange(ConfigurationManager.AppSettings["users"].Split(','));
                       return users;
            //foreach (var item in ConfigurationManager.AppSettings.AllKeys)
            //{
            //    users=
            //}
            //if (ConfigurationManager.AppSettings[key] == null)
            //    return false;
            //else
            //{
            //    return true;
            //}
            
        }
        /// <summary>
        /// 保存用户名
        /// </summary>
        /// <param name="userid">登陆成功的用户名</param>
        public void RemenberUser(string userid)
        {
            LoginClass judge = new LoginClass();
            List<string> users = new List<string>();
            string remenber="";
            users.AddRange(ReaderUser());
            if (!users.Contains(Settings.Default.UerID))
            {
                
                users.Add(userid); 
            }
            if (judge.JudgeDelate())
            {
                users.RemoveAt(0);
            }
            for (int i = 0; i < users.Count-1; i++)
            {
                users[i] = users[i] + ",";
            }
            foreach (var item in users)
            {
                remenber = remenber + item;
            }
            //把remenber保存进仓库管理系统.exe.config
            try
            {
                XmlDocument doc = new XmlDocument();
                string strinFileName = Application.StartupPath+ "\\仓库管理系统.exe.config";
                //加载整个XML文件，可以使用Xpath查询
                doc.Load(strinFileName);
                //XmlNode node = doc.GetElementById("add");
                //XmlNodeList nodes = node.ChildNodes;
                XmlNodeList nodes = doc.SelectNodes("configuration//appSettings//add");//支持XPATH查询
                foreach (XmlNode item in nodes)
                {
                    item.Attributes["value"].Value = remenber;
                    //item["value"].InnerText = remenber;
                    //if (item["add"].InnerText)
                    //{

                    //}
                }
                doc.Save(strinFileName);
            }
            catch (Exception e)
            {

                throw e;
            }
            ////读取程序集的配置文件
            //string assemblyConfigFile = Assembly.GetEntryAssembly().Location;
            //string appDomainConfigFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;

            ////新建配置文件连接
            ////string ass=Assembly.
            ////Configuration config = ConfigurationManager.OpenExeConfiguration(Assembly.GetEntryAssembly().Location);

            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //AppSettingsSection appsettins = (AppSettingsSection)config.GetSection("app.config");
            ////更新配置文件
            ////config.AppSettings.
            //config.AppSettings.Settings["users"].Value = remenber;
            ////保存文件
            //config.Save();
            ////刷新配置文件
            //ConfigurationManager.RefreshSection("app.config");
        }
    }
}
