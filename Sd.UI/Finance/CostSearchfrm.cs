//-----------------------------------------------
// 财务系统-财务
// 其他费用单查询画面
// 创建：2017.01.10 高振亮
// 修改：2017.01.10 高振亮
//-----------------------------------------------

using System;
using System.Linq;
using System.Windows.Forms;
using Sd.Common;
using Sd.Model;
using Sd.UI.Properties;

namespace Sd.UI.Finance
{
    public partial class CostSearchfrm : Form
    {
        public CostSearchfrm()
        {
            InitializeComponent();
        }

        public CostSearchfrm(DateTime dtFrom, DateTime dtTo, int iMode)
        {
            InitializeComponent();

            dgvFykzd.TabIndex = 0;

            dtpRqFrom.Value = dtFrom;
            dtpRqTo.Value = dtTo;
            chkRq.Checked = true;

            IBLL.IFykzdService fykzdService = new BLL.FykzdService();

            IQueryable<fykzd> jhyfbList;

            switch (iMode)
            {
                case 2:
                    // 检索现金不为0
                    jhyfbList = fykzdService.FindList(u =>
                                            (u.xj > 0 || u.xj < 0) &&
                                            u.rq >= dtpRqFrom.Value.Date &&
                                            u.rq <= dtpRqTo.Value.Date, "fykzdid", true);
                    break;
                case 3:
                    // 检索转账不为0
                    jhyfbList = fykzdService.FindList(u =>
                                            (u.zz > 0 || u.zz < 0) &&
                                            u.rq >= dtpRqFrom.Value.Date &&
                                            u.rq <= dtpRqTo.Value.Date, "fykzdid", true);
                    break;
                default:
                    // 综合检索
                    jhyfbList = fykzdService.FindList(u =>
                                            u.rq >= dtpRqFrom.Value.Date &&
                                            u.rq <= dtpRqTo.Value.Date, "fykzdid", true);
                    break;
            }

            if (null == jhyfbList)
            {
                MessageBox.Show(MsgResx.search_result_null);
                return;
            }

            var result = jhyfbList.ToList();

            var searchResult = result.Select(u => new
            {
                费用开支单号 = u.fykzdid.TrimEnd(),
                单据类型 = u.djlx.TrimEnd(),
                损益类型 = u.dysy.TrimEnd(),
                日期 = u.rq,
                总金额 = u.fyje.ToString("F"),
                现金 = u.xj.Value.ToString("F"),
                现金账户 = StringUtil.StrTrimEnd(u.xjzh),
                转账 = u.zz.Value.ToString("F"),
                转账账户 = StringUtil.StrTrimEnd(u.zzzh),
                其他费用 = u.qt.Value.ToString("F"),
                操作员 = StringUtil.StrTrimEnd(u.czy),
                记账摘要 = u.bz,
                审核标志 = u.flag
            }).ToList();

            if (0 == searchResult.Count)
            {
                MessageBox.Show(MsgResx.search_result_null);

                return;
            }

            dgvFykzd.DataSource = searchResult;

            dgvFykzd.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvFykzd_SelectionChanged(object sender, EventArgs e)
        {
            if (null == dgvFykzd.CurrentRow)
            {
                return;
            }

            var fykzdid = dgvFykzd.CurrentRow.Cells["费用开支单号"].Value.ToString();

            var fykzdmxService = new BLL.FykzdmxService();

            var jhyfmxbList = fykzdmxService.FindList(u =>
                u.fykzdid.Equals(fykzdid), "lsh", true).ToList();
            dgvFykzdmx.DataSource = jhyfmxbList.Select(u => new
            {
                付款单号 = u.fykzdid.TrimEnd(),
                费用类别 = u.lbmc.TrimEnd(),
                摘要 = u.zymc,
                支付金额 = u.fyje.ToString("F"),
                现金 = u.xj.Value.ToString("F"),
                转账 = u.zz.Value.ToString("F"),
                其他金额 = u.qt.Value.ToString("F"),
                付款人 = u.syy,
                客户费用 = u.khfy,
                营业员 = u.yyy,
                业务员 = u.ywy,
                凭据号 = u.pjh
            }).ToList();

            dgvFykzdmx.ClearSelection();
        }
    }
}