//-----------------------------------------------
// 财务系统-贷款结算单
// 贷款结算单查询画面
// 创建：2017.01.09 高振亮
// 修改：2017.01.09 高振亮
//-----------------------------------------------

using System;
using System.Linq;
using System.Windows.Forms;
using Sd.Model;
using Sd.UI.Properties;

namespace Sd.UI.Finance
{
    public partial class PaymentSearchFrm : Form
    {
        public PaymentSearchFrm()
        {
            InitializeComponent();
        }

        public PaymentSearchFrm(DateTime dtFrom, DateTime dtTo, int iMode)
        {
            InitializeComponent();

            dgvHkjsd.TabIndex = 0;

            dtpRqFrom.Value = dtFrom;
            dtpRqTo.Value = dtTo;
            chkRq.Checked = true;


            IBLL.IHkjsdService hkjsdService = new BLL.HkjsdService();

            IQueryable<zt_hkyfjsd> hkjsdList;

            switch (iMode)
            {
                case 2:
                    // 检索现金不为0
                    hkjsdList = hkjsdService.FindList(u =>
                                            (u.xj > 0 || u.xj < 0) &&
                                            u.fkrq >= dtpRqFrom.Value.Date &&
                                            u.fkrq <= dtpRqTo.Value.Date, "hkyfdid", true);
                    break;
                case 3:
                    // 检索转账不为0
                    hkjsdList = hkjsdService.FindList(u =>
                                            (u.zz > 0 || u.zz < 0) &&
                                            u.fkrq >= dtpRqFrom.Value.Date &&
                                            u.fkrq <= dtpRqTo.Value.Date, "hkyfdid", true);
                    break;
                default:
                    // 综合检索
                    hkjsdList = hkjsdService.FindList(u =>
                                            u.fkrq >= dtpRqFrom.Value.Date &&
                                            u.fkrq <= dtpRqTo.Value.Date, "hkyfdid", true);
                    break;
            }

            if (null == hkjsdList)
            {
                MessageBox.Show(MsgResx.search_result_null);
                return;
            }

            var result = hkjsdList.ToList();

            var searchResult = result.Select(u => new
            {
                付款结算单号 = u.hkyfdid.TrimEnd(),
                付款日期 = u.fkrq,
                供货商名称 = u.ghsmc.TrimEnd(),
                付款金额 = u.fkje.ToString("F"),
                现金 = u.xj.Value.ToString("F"),
                现金账户 = u.xjzh,
                转账 = u.zz.Value.ToString("F"),
                转账账户 = u.zzzh,
                舍零 = u.sr.Value.ToString("F"),
                其他 = u.qt.Value.ToString("F"),
                记账摘要 = u.bz,
                操作员 = u.czy,
                收银员 = u.syy,
                审核标志 = u.flag
            }).ToList();

            if (0 == searchResult.Count)
            {
                MessageBox.Show(MsgResx.search_result_null);

                return;
            }

            dgvHkjsd.DataSource = searchResult;
        }

        private void btnHkjsd_Click(object sender, EventArgs e)
        {
            Close();
        }  
    }
}
