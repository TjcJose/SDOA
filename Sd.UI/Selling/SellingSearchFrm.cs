//-----------------------------------------------
// 销售系统-销售单
// 销售单查询画面
// 创建：2016.12.05 高振亮
// 修改：2016.12.05 高振亮
//-----------------------------------------------

using System;
using System.Linq;
using System.Windows.Forms;
using Sd.BLL;
using Sd.IBLL;
using Sd.Model;
using Sd.UI.Properties;

namespace Sd.UI.Selling
{
    public partial class SellingSearchFrm : Form
    {
        private readonly SellingFrm _sellingFrm;

        private readonly IXsdmxService _xsdmxService = new XsdmxService();

        public SellingSearchFrm()
        {
            InitializeComponent();
        }

        public SellingSearchFrm(SellingFrm sellingFrm)
        {
            InitializeComponent();

            _sellingFrm = sellingFrm;
        }

        private void SellingSearchFrm_Load(object sender, EventArgs e)
        {
            // 直属客户
            ICustomerService customerService = new CustomerService();
            combKhid.DataSource =
                customerService.FindList(u => u.stopSign.Equals("0"), "khid", true)
                    .Select(u => new { khid = u.khid.Trim(), khmc = u.khmc.Trim() })
                    .ToList();
            combKhid.DisplayMember = "khmc";

            combKhid.Text = "";
            //dtpXsrqFrom.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddYears(-1);  

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IXsdService xsdService = new XsdService();
            if (!xsdService.Exist(u => u.xsdid.Contains(txtTyphcc.Text)))
            {
                return;
            }

            IQueryable<xsd> xsdList;

            if (chkXsrq.Checked)
            {
                xsdList = xsdService.FindList(u =>
                    (u.xsdid.Contains(txtTyphcc.Text) || u.sgddh.Contains(txtTyphcc.Text) || u.bz.Contains(txtTyphcc.Text)) &&
                    u.khmc.Contains(combKhid.Text) &&
                    u.ejkh.Contains(txtEjkh.Text) &&
                    u.tel.Contains(txtTel.Text) &&
                    u.address.Contains(txtAddress.Text) &&
                    u.xsrq > dtpXsrqFrom.Value &&
                    u.xsrq < dtpXsrqTo.Value, "xsdid", true);
            }
            else
            {
                xsdList = xsdService.FindList(u =>
                    (u.xsdid.Contains(txtTyphcc.Text) || u.sgddh.Contains(txtTyphcc.Text) || u.bz.Contains(txtTyphcc.Text)) &&
                    u.khmc.Contains(combKhid.Text) &&
                    u.ejkh.Contains(txtEjkh.Text) &&
                    u.tel.Contains(txtTel.Text) &&
                    u.address.Contains(txtAddress.Text), "xsdid", true);
            }

            if (null == xsdList)
            {
                MessageBox.Show(MsgResx.search_result_null);
                return;
            }

            var searchResult = xsdList.Select(u => new
            {
                销售单编号 = u.xsdid.TrimEnd(),
                打印 = u.print_bz.TrimEnd(),
                合同号 = u.sgddh.TrimEnd(),
                营业员 = u.yyy.TrimEnd(),
                业务员 = u.ywy.TrimEnd(),
                日期 = u.xsrq,
                总金额 = u.zje,
                二级客户 = u.ejkh.TrimEnd(),
                电话 = u.tel.TrimEnd(),
                地址 = u.address.TrimEnd()
            }).ToList();

            if (0 == searchResult.Count)
            {
                MessageBox.Show(MsgResx.search_result_null);

                return;
            }

            dgvXsd.DataSource = searchResult;

            if (null != dgvXsd.CurrentRow)
            {
                dgvXsd.Tag = dgvXsd.CurrentRow.Index;
            }
        }

        private void dgvXsd_SelectionChanged(object sender, EventArgs e)
        {
            if (null == dgvXsd.CurrentRow)
            {
                return;
            }

            var xsdid = dgvXsd.CurrentRow.Cells["销售单编号"].Value.ToString();

            var xsdmxList = _xsdmxService.FindList(u =>
                u.xsdid.Equals(xsdid), "xsdlsh", true);
            dgvXsdmx.DataSource = xsdmxList.Select(u=> new
            {
                销售单编号 = u.xsdid.TrimEnd(),
                商品编码 = u.spid.TrimEnd(),
                单位 = u.dw,
                销售价 = u.spxx.xsj,
                数量 = u.xssl,
                金额 = u.xsje
            }).ToList();

            dgvXsdmx.ClearSelection();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvXsd_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            XsdInfoSelected();
        }

        private void dgvXsd_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            XsdInfoSelected();
        }

        private void XsdInfoSelected()
        {
            if (null == dgvXsd.CurrentRow)
            {
                return;
            }

            var xsdid = dgvXsd.CurrentRow.Cells["销售单编号"].Value.ToString();

            IXsdService xsdService = new XsdService();

            _sellingFrm.XsdInfo = xsdService.Find(u => u.xsdid.Equals(xsdid));

            Close();
        }

    }
}
