//-----------------------------------------------
// 财务系统-其他收入单
// 其他收入单查询画面
// 创建：2017.01.09 高振亮
// 修改：2017.01.09 高振亮
//-----------------------------------------------

using System;
using System.Linq;
using System.Windows.Forms;
using Sd.Common;
using Sd.Model;
using Sd.UI.Properties;

namespace Sd.UI.Finance
{
    public partial class InComeSearchFrm : Form
    {
        public InComeSearchFrm()
        {
            InitializeComponent();
        }

        public InComeSearchFrm(DateTime dtFrom, DateTime dtTo, int iMode)
        {
            InitializeComponent();

            dgvQtsrd.TabIndex = 0;

            dtpRqFrom.Value = dtFrom;
            dtpRqTo.Value = dtTo;
            chkSrrq.Checked = true;

            IBLL.IQtsrdService qtsrdService = new BLL.QtsrdService();

            IQueryable<qtsrd> qtsrdList;

            switch (iMode)
            {
                case 2:
                    // 检索现金不为0
                    qtsrdList = qtsrdService.FindList(u =>
                        (u.xj > 0 || u.xj < 0) &&
                        u.djlx.Contains("其它收入单") &&
                        u.rq >= dtpRqFrom.Value.Date &&
                        u.rq <= dtpRqTo.Value.Date, "qtsrdid", true);
                    break;
                case 3:
                    // 检索转账不为0
                    qtsrdList = qtsrdService.FindList(u =>
                        (u.zz > 0 || u.zz < 0) &&
                        u.djlx.Contains("其它收入单") &&
                        u.rq >= dtpRqFrom.Value.Date &&
                        u.rq <= dtpRqTo.Value.Date, "qtsrdid", true);
                    break;
                default:
                    // 综合检索
                    qtsrdList = qtsrdService.FindList(u =>
                        u.djlx.Contains("其它收入单") &&
                        u.rq >= dtpRqFrom.Value.Date &&
                        u.rq <= dtpRqTo.Value.Date, "qtsrdid", true);
                    break;
            }

            if (null == qtsrdList)
            {
                MessageBox.Show(MsgResx.search_result_null);
                return;
            }

            var result = qtsrdList.ToList();

            var searchResult = result.Select(u => new
            {
                收入单号 = u.qtsrdid.TrimEnd(),
                日期 = u.rq,
                单据类型 =  u.djlx.TrimEnd(),
                收入总额 = u.srje.ToString("F"),
                现金 = u.xj.Value.ToString("F"),
                现金账户 = u.xjzh,
                转账 = u.zz.Value.ToString("F"),
                转账账户 = u.zzzh,
                其他收款 = u.qt.Value.ToString("F"),
                操作员 = StringUtil.StrTrimEnd(u.czy),
                记账摘要 = StringUtil.StrTrimEnd(u.bz),
                审核标志 = u.flag
            }).ToList();

            if (0 == searchResult.Count)
            {
                MessageBox.Show(MsgResx.search_result_null);

                return;
            }

            dgvQtsrd.DataSource = searchResult;

            if (null != dgvQtsrd.CurrentRow)
            {
                dgvQtsrd.Tag = dgvQtsrd.CurrentRow.Index;
            }

            dgvQtsrd.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvQtsrd_SelectionChanged(object sender, EventArgs e)
        {
            if (null == dgvQtsrd.CurrentRow)
            {
                return;
            }

            var qtsrdid = dgvQtsrd.CurrentRow.Cells["收入单号"].Value.ToString();

            var qtsrmxService = new BLL.QtsrmxService();

            var qtsrmxbList = qtsrmxService.FindList(u =>
                u.qtsrdid.Equals(qtsrdid), "lsh", true).ToList();
            dgvQtsrmx.DataSource = qtsrmxbList.Select(u => new
            {
                付款单号 = u.qtsrdid.TrimEnd(),
                类别名称 = u.lbmc.TrimEnd(),
                损益科目 = u.kjkmmc.TrimEnd(),
                摘要名称 = u.zymc.TrimEnd(),
                金额 = u.je.ToString("F"),
                现金 = u.xj.Value.ToString("F"),
                转账 = u.zz.Value.ToString("F"),
                其他收款 = u.qt.Value.ToString("F"),
                部门 = u.bmfy,
                收营员 = u.syy

            }).ToList();

            dgvQtsrmx.ClearSelection();
        }


    }
}