using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace 仓库管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 下面的代码行提供本地化的数据格式。
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("zh-CN");
            // 下面的代码行提供本地化的应用程序用户界面。
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm logform = new LoginForm();
            if (logform.ShowDialog()==DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
