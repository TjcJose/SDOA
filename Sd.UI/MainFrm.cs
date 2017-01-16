using System;
using System.Linq;
using System.Windows.Forms;
using Sd.Model;
using Sd.UI.Info.Customer;
using Sd.UI.Info.Department;
using Sd.UI.Info.Goods;
using Sd.UI.Report;
using Sd.UI.Selling;
using Sd.UI.SystemAdmin;

namespace Sd.UI
{
    public partial class MainFrm : Form
    {
        public MainFrm(password user)
        {
            InitializeComponent();
            // 开启双缓存，解决加载图片闪烁
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            var competenceList = user.CompetenceSet.Where(u=> u.CompetenceID.ToString().Contains("000000") && u.Valid).Select(u=>u.CompetenceName).ToList();

            foreach (ToolStripItem item in menuStrip1.Items)
            {
                if (competenceList.Contains(item.Name))
                {
                    item.Enabled = true;
                }
                else
                {
                    item.Enabled = false;
                }
            }

            menuStrip1.Items[menuStrip1.Items.Count - 1].Enabled = true;
        }
        private void MainFrm_Load(object sender, EventArgs e)
        {
            //加载皮肤 Application.StartupPath.Substring(0,Application.StartupPath.LastIndexOf(@"\"));           
            skinEngine.SkinFile = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf(@"\", StringComparison.Ordinal)) + @"\Skins\office2007.ssk";
            //MainFrmResx.FrmSkinPath;
            skinEngine.Active = false;
        }

        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
             Application.Exit();
        }

        private void 权限管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var authorityFrm = new AuthorityFrm();
            authorityFrm.ShowDialog();
        }

        private void 大部门ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bigDepartmnetFrm = new BigDepartmnetFrm();
            bigDepartmnetFrm.ShowDialog();
        }

        private void 商品信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var goodsFrm = new GoodsFrm();
            goodsFrm.ShowDialog();
        }

        private void 客户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerFrm = new CustomerFrm();
            customerFrm.ShowDialog();
        }

        private void 销售单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sellingFrm = new SellingFrm();
            sellingFrm.ShowDialog();
        }
        private void 综合查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var overallQueryFrm = new OverallQueryFrm();
            overallQueryFrm.ShowDialog();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userAdminFrm = new UserAdminFrm();
            userAdminFrm.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
