using System;
using System.Linq;
using System.Windows.Forms;
using Sd.BLL;
using Sd.Model;
using Sd.UI.Properties;

namespace Sd.UI.Selling
{
    public partial class SellingIndentSearchFrm : Form
    {
        public SellingIndentSearchFrm()
        {
            InitializeComponent();
        }

        public SellingIndentSearchFrm(DateTime dtFrom, DateTime dtTo, int iMode)
        {
            InitializeComponent();

            dtpDhrqFrom.Value = dtFrom;
            dtpDhrqTo.Value = dtTo;
            chkDhrq.Checked = true;

            IBLL.IXsdhdService xsdhdService = new BLL.XsdhdService();

            IQueryable<xsdhd> xsdhdList;

            switch (iMode)
            {
                case 2:
                    // 检索现金不为0
                    xsdhdList = xsdhdService.FindList(u =>
                                            (u.xj > 0 || u.xj < 0) &&
                                            u.dhrq >= dtpDhrqFrom.Value.Date &&
                                            u.dhrq <= dtpDhrqTo.Value.Date, "xsdhdid", true);
                    break;
                case 3:
                    // 检索转账不为0
                    xsdhdList = xsdhdService.FindList(u =>
                                            (u.zz > 0 || u.zz < 0) &&
                                            u.dhrq >= dtpDhrqFrom.Value.Date &&
                                            u.dhrq <= dtpDhrqTo.Value.Date, "xsdhdid", true);
                    break;
                case 4:
                    // 检索欠款不为0
                    xsdhdList = xsdhdService.FindList(u =>
                                            (u.ys > 0 || u.ys < 0) &&
                                            u.dhrq >= dtpDhrqFrom.Value.Date &&
                                            u.dhrq <= dtpDhrqTo.Value.Date, "xsdhdid", true);
                    break;
                default:
                    // 综合检索
                    xsdhdList = xsdhdService.FindList(u =>
                                            u.dhrq >= dtpDhrqFrom.Value.Date &&
                                            u.dhrq <= dtpDhrqTo.Value.Date, "xsdhdid", true);
                    break;
            }

            if (null == xsdhdList)
            {
                MessageBox.Show(MsgResx.search_result_null);
                return;
            }

            var searchResult = xsdhdList.Select(u => new
            {
                销售订货单号 = u.xsdhdid.TrimEnd(),
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

            dgvXsdhd.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvXsdhd_SelectionChanged(object sender, EventArgs e)
        {
            if (null == dgvXsdhd.CurrentRow)
            {
                return;
            }

            var xsdhdid = dgvXsdhd.CurrentRow.Cells["销售订货单号"].Value.ToString();

            var xsdhdmxService = new XsdhdmxService();

            var xsdhdmxList = xsdhdmxService.FindList(u =>
                u.xsdhdid.Equals(xsdhdid), "lsh", true);
            dgvXsdhdmx.DataSource = xsdhdmxList.Select(u => new
            {
                销售订货单号 = u.xsdhdid.TrimEnd(),
                商品编码 = u.spid.TrimEnd(),
                单位 = u.dw,
                单价 = u.dbj,
                数量 = u.xssl,
                金额 = u.xsje
            }).ToList();

            dgvXsdhdmx.ClearSelection();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
