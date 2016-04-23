using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Helpers;
using 仓库管理系统.DAL;
using 仓库管理系统.Properties;
using DevExpress.XtraScheduler;
using 仓库管理系统.BLL;
using 仓库管理系统.UI;
using DevExpress.XtraTab;

namespace 仓库管理系统
{

    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<string> read = new List<string>();
        public MainForm()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“storage_WMSDataSet.员工表”中。您可以根据需要移动或删除它。
            this.员工表TableAdapter.Fill(this.storage_WMSDataSet.员工表);
            UserNamebarStaticItem.Caption = "当前用户：" + IOHelper.uerName;
            TimeBSI.Caption = "登陆时间：" + DateTime.Now.ToString("yyy-MM-dd hh:mm:ss");
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("你确定要退出吗？", "退出系统", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Dispose();
                Application.Exit();
            }
            else
                e.Cancel = true;
        }
        /// <summary>
        /// 换班
        /// </summary>
        private void ExchangeUser()
        {
            LoginClass Relogin = new LoginClass();
            IOHelper rewrite = new IOHelper();
            if (Relogin.JudgeUser(EmpIDCbxe.Text, EmpPswTxtE.Text, DBHelper.SerName))
            {
                rewrite.WriteConfig(DBHelper.SerName, EmpIDCbxe.Text, EmpPswTxtE.Text, IOHelper.PswChk);
                rewrite.RemenberUser(EmpIDCbxe.Text);
                ExchangeClass.RemenberRoot();
                xtraTabControl1.CloseButtonClick( sender, e);
                UserNamebarStaticItem.Caption = "当前用户：" + EmpNameLableC.Text;

            }
        }
        private void AddTablePage(string newpage)
        {
            foreach (XtraTabPage item in xtraTabControl1.TabPages)
            {
                if (item.Text==newpage)
                {
                    xtraTabControl1.SelectedTabPage = item;
                    return;
                }
            }
            switch (newpage)
            {
                case "交接班":
                    XtraTabPage xpage = new  XtraTabPage();
                    xpage.Controls.Add(ExchangeTablePage);
                    break;
                default:
                    break;
            }
           
        
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EmpIDCbxe.Properties.Items.Clear();
            ExchangeTablePage.PageVisible = true;//显示交接班页面
            xtraTabControl1.SelectedTabPageIndex = 0;//切换到交接班页面
            UserIDLableC.Text = IOHelper.userId;
            UserNameLableC.Text = IOHelper.uerName;
            if (IOHelper.userRoot)
            {
                UserRootLbl.Text = "管理员";
            }
            else
            {
                UserRootLbl.Text = "标准用户";
            }
            ExchangeClass readid = new ExchangeClass();
            if (read.Count == 0)
            {
                read.AddRange(ExchangeClass.ReadOneColumns("员工编号"));
            }
            foreach (string item in read)
            {
                EmpIDCbxe.Properties.Items.Add(item);
            }
            EmpIDCbxe.Reset();
            EmpPswTxtE.Reset();

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ribbonStatusBar1_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ExchangeTablePage.PageVisible = false;
        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void EmpIDCbxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string employeeid = EmpIDCbxe.Text;
            EmpNameLableC.Text = ExchangeClass.employeeName[employeeid];
            EmpRootLbl.Text = ExchangeClass.employeeRoot[employeeid];
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            ExchangeUser();
        }

        private void xtraTabPage1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void xtraTabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExchangeUser();
            }
        }

        private void EmpPswTxtE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExchangeUser();
            }

        }

        private void EmpIDCbxe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExchangeUser();
            }

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddUserForm adduser = new AddUserForm();
            adduser.ShowDialog();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = QueryInfoClass.QueryEmp();
        }
        /// <summary>
        /// 绘制每行数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator&&(e.RowHandle)>=0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QueryEmpTabPage.PageVisible = true;

        }
        /// <summary>
        /// 关闭选项卡方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs EArg = 
                (DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs)e;
            string name = EArg.Page.Text;//得到关闭选项卡的text
            //遍历选项卡，找到要关闭的（text）选项卡，并关闭
            foreach (XtraTabPage item in xtraTabControl1.TabPages)
            {
                if (item.Text==name)
                {
                    xtraTabControl1.TabPages.Remove(item);
                    item.Dispose();
                    return;
                }
            }
        }
    }
}
