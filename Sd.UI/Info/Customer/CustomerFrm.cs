using System;
using System.Linq;
using System.Windows.Forms;
using Sd.BLL;
using Sd.Common;
using Sd.IBLL;
using Sd.Model;

namespace Sd.UI.Info.Customer
{
    public partial class CustomerFrm : Form
    {
        readonly ICustomerService _customerService = new CustomerService();

        public CustomerFrm()
        {
            InitializeComponent();
        }

        private void CustomerFrm_Load(object sender, EventArgs e)
        {
            #region combobox绑定数据
            // 种类表
            IZlService zlService = new ZlService();
            combZlmc.DataSource = zlService.FindList(u => true, "zldm", true).Select(u=>u.zlmc).ToList();
            
            // 业务员
            IZyxxService zyxxService = new ZyxxService();
            combYwy.DataSource = zyxxService.FindList(u => true, "zyid", true).Select(u => u.name).ToList();
            combYwy.Text = "";

            // 销售部
            IXsbxxService xsbxxService = new XsbxxService();
            combXsbmc.DataSource = xsbxxService.FindList(u => true, "xsbid", true).Select(u => u.xsbmc).ToList();

            // 结算客户
            var customer = _customerService.FindList(u => true, "khid", true);
            combJskhmc.DataSource = customer.Select(u => new {u.khid, u.khmc }).ToList();
            combJskhmc.DisplayMember = "khmc";
            combJskhmc.Text = "";

            #endregion

            // 客户信息
            dgvCustomer.DataSource  = customer.Select(u=>new
            {
                客户编码 = u.khid,
                客户名称 =u.khmc,
                业务员 = u.ywy,
                种类 = u.zlmc,
                手机 = u.sj,
                电话 = u.tel,
                地址 = u.address,
                开户行 = u.khh,
                账号 = u.zh,
                税号 = u.sh
            }).ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 画面字段Check

            // 
            _customerService.Add(
                new khxx
                {
                    khid = txtKhid.Text.Trim(),
                    khmc = txtKhmc.Text.Trim(),
                    zlmc = combZlmc.Text.Trim(),
                    ywy = combYwy.Text,
                    xsbmc = combXsbmc.Text.Trim(),
                    jskhid = txtKhid.Text.Trim(),
                    xqmc = combXqmc.Text.Trim(),
                    bp = int.Parse(txtBp.Text.Trim()),
                    sj = txtSj.Text.Trim(),
                    tel = txtTel.Text.Trim(),
                    address = txtAddress.Text.Trim(),
                    khh = txtKhh.Text.Trim(),
                    zh = txtZh.Text.Trim(),
                    sh = txtSh.Text.Trim(),
                    yb = txtYb.Text.Trim(),
                    arrearDay = int.Parse(txtArrearDay.Text.Trim()),
                    arrearMoney = int.Parse(txtArrearMoney.Text.Trim()),
                    email = txtEmail.Text.Trim()
                });

        }

        private void txtKhmc_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKhmc.Text))
            {
                txtKhid.Text = "";
            }
            else
            {
                txtKhid.Text = StringUtil.GetFirstPinyin(txtKhmc.Text);
            }
        }

        private void txtBp_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBp.Text))
            {
                txtBp.Text = "0";
            }
        }

        private void txtArrearDay_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArrearDay.Text))
            {
                txtArrearDay.Text = "0";
            }
        }

        private void txtArrearMoney_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArrearMoney.Text))
            {
                txtArrearMoney.Text = "0";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtKhid.Text = dgvCustomer.Rows[e.RowIndex].Cells["客户编码"].Value.ToString();
            txtKhmc.Text = dgvCustomer.Rows[e.RowIndex].Cells["客户名称"].Value.ToString();
            combZlmc.Text = dgvCustomer.Rows[e.RowIndex].Cells["种类"].Value.ToString();
            combYwy.Text = dgvCustomer.Rows[e.RowIndex].Cells["业务员"].Value.ToString();
            combXsbmc.Text = dgvCustomer.Rows[e.RowIndex].Cells["销售部"].Value.ToString();
            combJskhmc.Text = dgvCustomer.Rows[e.RowIndex].Cells["结算客户"].Value.ToString();

        }
    }
}
