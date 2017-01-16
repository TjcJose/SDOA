using System;
using System.Linq;
using System.Windows.Forms;
using Sd.Model;
using Sd.UI.Properties;

namespace Sd.UI.Onroad
{
    public partial class TransportSearchFrm : Form
    {
        public TransportSearchFrm()
        {
            InitializeComponent();
        }

        public TransportSearchFrm(DateTime dtFrom, DateTime dtTo, int iMode)
        {
            InitializeComponent();

            /*dtpYsrqFrom.Value = dtFrom;
            dtpYsrqTo.Value = dtTo;
            chkYsrq.Checked = true;

            IBLL.IZtysdService xsdhdService = new BLL.ZtysdService();

            IQueryable<zt_ysd> ztysdList;

            switch (iMode)
            {
                case 2:
                    // 检索现金不为0
                    ztysdList = xsdhdService.FindList(u =>
                                            (u.xj > 0 || u.xj < 0) &&
                                            u.dhrq >= dtpYsrqFrom.Value.Date &&
                                            u.dhrq <= dtpYsrqTo.Value.Date, "ysdid", true);
                    break;
                case 3:
                    // 检索转账不为0
                    ztysdList = xsdhdService.FindList(u =>
                                            (u.zz > 0 || u.zz < 0) &&
                                            u.dhrq >= dtpYsrqFrom.Value.Date &&
                                            u.dhrq <= dtpYsrqTo.Value.Date, "ysdid", true);
                    break;
                case 4:
                    // 检索欠款不为0
                    ztysdList = xsdhdService.FindList(u =>
                                            (u.ys > 0 || u.ys < 0) &&
                                            u.dhrq >= dtpYsrqFrom.Value.Date &&
                                            u.dhrq <= dtpYsrqTo.Value.Date, "ysdid", true);
                    break;
                default:
                    // 综合检索
                    ztysdList = xsdhdService.FindList(u =>
                                            u.dhrq >= dtpYsrqFrom.Value.Date &&
                                            u.dhrq <= dtpYsrqTo.Value.Date, "ysdid", true);
                    break;
            }

            if (null == ztysdList)
            {
                MessageBox.Show(MsgResx.search_result_null);
                return;
            }

            var searchResult = ztysdList.Select(u => new
            {
                销售订货单号 = u.ysdid.TrimEnd(),
                打印 = u.print_bz.TrimEnd(),
                合同号 = u.ddh.TrimEnd(),
                营业员 = u.yyy.TrimEnd(),
                业务员 = u.ywy.TrimEnd(),
                日期 = u.dhrq,
                实收 = u.ssze,
                现金 = u.xj,
                转账 = u.zz,
                应收 = u.ys,
                二级客户 = u.ejkh.TrimEnd(),
                电话 = u.tel.TrimEnd(),
                地址 = u.address.TrimEnd()
            }).ToList();

            if (0 == searchResult.Count)
            {
                MessageBox.Show(MsgResx.search_result_null);

                return;
            }

            dgvXsdhd.DataSource = searchResult;

            if (null != dgvXsdhd.CurrentRow)
            {
                dgvXsdhd.Tag = dgvXsdhd.CurrentRow.Index;
            }

            dgvXsdhd.Focus();*/
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
