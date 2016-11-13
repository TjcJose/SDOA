using System;
using System.Windows.Forms;
using Sd.UI.Info.Customer;
using Sd.UI.Info.Department;
using Sd.UI.Info.Goods;
using Sd.UI.SystemAdmin;

namespace Sd.UI
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
           
            //加载皮肤 Application.StartupPath.Substring(0,Application.StartupPath.LastIndexOf(@"\"));           
            skinEngine.SkinFile = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf(@"\", StringComparison.Ordinal)) +  @"\Skins\office2007.ssk";
            //MainFrmResx.FrmSkinPath;
            skinEngine.Active = true;
            // 开启双缓存，解决加载图片闪烁
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
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
    }
}
