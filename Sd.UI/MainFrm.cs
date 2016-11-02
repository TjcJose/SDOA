using System;
using System.Windows.Forms;

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
    }
}
