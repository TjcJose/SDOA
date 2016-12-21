//-----------------------------------------------
// 销售系统-销售单
// 销售单信息画面
// 创建：2016.11.29 高振亮
// 修改：2016.11.29 高振亮
//-----------------------------------------------

using System;
using System.Linq;
using System.Windows.Forms;
using Sd.BLL;
using Sd.IBLL;
using Sd.Model;

namespace Sd.UI.Selling
{
    public partial class SellingInfoFrm : Form
    {
        private readonly string _strXsdid;

        private readonly SellingFrm _sellingFrm;

        private IQueryable<xsd> _xsdInfos; 

        public SellingInfoFrm()
        {
            InitializeComponent();
        }

        public SellingInfoFrm(SellingFrm sellingFrm, string strKey)
        {
            InitializeComponent();
            _strXsdid = strKey;
            _sellingFrm = sellingFrm;
        }

        private void SellingInfoFrm_Load(object sender, EventArgs e)
        {
            IXsdService xsdService = new XsdService();
            _xsdInfos = xsdService.FindList(u => u.xsdid.Contains(_strXsdid) || u.sgddh.Contains(_strXsdid), "xsdid", true);
            if (null == _xsdInfos)
            {
                return;
            }

            dgvXsdInfo.DataSource = _xsdInfos.Select(u => new
            {
                销售单编号 = u.xsdid,
                合同号 = u.sgddh ?? u.xsdid,
                营业员 = u.yyy,
                业务员 = u.ywy,
                销售日期 = u.xsrq,
                直属客户 = u.khmc,
                二级客户 = u.ejkh,
                电话 = u.tel,
                地址 = u.address
            }).ToList();
        }

        private void dgvXsdInfo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            XsdInfoSelected();
        }

        private void dgvXsdInfo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            XsdInfoSelected();
        }

        private void XsdInfoSelected()
        {
            if (null == dgvXsdInfo.CurrentRow)
            {
                return;
            }

            var strKhid = dgvXsdInfo.CurrentRow.Cells["销售单编号"].Value.ToString();

            _sellingFrm.XsdInfo =
                _xsdInfos.First(u => u.xsdid.Equals(strKhid));

            Close();
        }
    }
}
