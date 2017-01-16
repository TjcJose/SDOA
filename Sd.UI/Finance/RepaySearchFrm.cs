//-----------------------------------------------
// 财务系统-还款单
// 还款单查询画面
// 创建：2017.01.05 高振亮
// 修改：2017.01.05 高振亮
//-----------------------------------------------

using System;
using System.Linq;
using System.Windows.Forms;
using Sd.Common;
using Sd.Model;
using Sd.UI.Properties;

namespace Sd.UI.Finance
{
    public partial class RepaySearchFrm : Form
    {
        public RepaySearchFrm()
        {
            InitializeComponent();
        }

        public RepaySearchFrm(DateTime dtFrom, DateTime dtTo, int iMode)
        {
            InitializeComponent();

            dgvHkd.TabIndex = 0;

            dtpHkrqFrom.Value = dtFrom;
            dtpHkrqTo.Value = dtTo;
            chkHkrq.Checked = true;


            IBLL.IHshkdService hshkdService = new BLL.HshkdService();

            IQueryable<hshkd> xsdhdList;

            switch (iMode)
            {
                case 2:
                    // 检索现金不为0
                    xsdhdList = hshkdService.FindList(u =>
                                            (u.hkxj > 0 || u.hkxj < 0) &&
                                            u.rq >= dtpHkrqFrom.Value.Date &&
                                            u.rq <= dtpHkrqTo.Value.Date, "hshkdid", true);
                    break;
                case 3:
                    // 检索转账不为0
                    xsdhdList = hshkdService.FindList(u =>
                                            (u.hkzz > 0 || u.hkzz < 0) &&
                                            u.rq >= dtpHkrqFrom.Value.Date &&
                                            u.rq <= dtpHkrqTo.Value.Date, "hshkdid", true);
                    break;
                default:
                    // 综合检索
                    xsdhdList = hshkdService.FindList(u =>
                                            u.rq >= dtpHkrqFrom.Value.Date &&
                                            u.rq <= dtpHkrqTo.Value.Date, "hshkdid", true);
                    break;
            }

            if (null == xsdhdList)
            {
                MessageBox.Show(MsgResx.search_result_null);
                return;
            }

            var result = xsdhdList.ToList();

            var searchResult = result.Select(u => new
            {
                回款单号 = u.hshkdid.TrimEnd(),
                客户名称 = u.khmc.TrimEnd(),
                合同号 = StringUtil.StrTrimEnd(u.ddh),
                日期 = u.rq,
                回款金额 = u.hkje.ToString("F"),
                现金 = u.hkxj.Value.ToString("F"),
                现金账户 = StringUtil.StrTrimEnd(u.xjzh),
                转账 = u.hkzz.Value.ToString("F"),
                转账账户 = StringUtil.StrTrimEnd(u.zzzh),
                刷卡 = u.skje.Value.ToString("F"),
                刷卡去向 = StringUtil.StrTrimEnd(u.skzh),
                舍零 = u.hksr.Value.ToString("F"),
                其他 = u.qt.Value.ToString("F")
            }).ToList();

            if (0 == searchResult.Count)
            {
                MessageBox.Show(MsgResx.search_result_null);

                return;
            }

            dgvHkd.DataSource = searchResult;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
