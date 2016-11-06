//-----------------------------------------------
// 信息系统-客户
// 客户画面
// 创建：2016.11.03 高振亮
// 修改：2016.11.03 高振亮
//-----------------------------------------------

using System;
using System.Linq;
using System.Windows.Forms;
using Sd.BLL;
using Sd.Common;
using Sd.IBLL;
using Sd.Model;
using Sd.UI.Properties;

namespace Sd.UI.Info.Customer
{
    public partial class CustomerFrm : Form
    {
        private readonly ICustomerService _customerService = new CustomerService();

        public int OperationMode;

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

            // 销区名称
            IXqxxService xqxxService = new XqxxService();
            combXqmc.DataSource = xqxxService.FindList(u => true, "xqid", true).ToList();
            combXqmc.DisplayMember = "xqmc";

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
                税号 = u.sh,
                信誉额 = u.bp,
                欠款提醒期限 = u.arrearDay,
                欠款提醒额度 = u.arrearMoney,
                销售部 = u.xsbmc,
                销区名称 = u.xqmc,
                结算客户 = u.khmc, // TODO
                联系人 = u.lxr,
                邮编 = u.yb,
                邮箱 = u.email
            }).ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperationMode = 1;

            SetCompetenceEnabled(true);

            btnAdd.Enabled = false;

            btnDel.Enabled = false;

            btnUpdate.Enabled = false;

            btnSearch.Enabled = false;

        }

        private void txtKhmc_TextChanged(object sender, EventArgs e)
        {
            txtKhid.Text = string.IsNullOrWhiteSpace(txtKhmc.Text) ? "" : StringUtil.GetFirstPinyin(txtKhmc.Text);
        }

        private void txtBp_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBp.Text))
            {
                txtBp.Text = ComValueResx.txtIntDefault;
            }
        }

        private void txtArrearDay_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArrearDay.Text))
            {
                txtArrearDay.Text = ComValueResx.txtIntDefault;
            }
        }

        private void txtArrearMoney_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArrearMoney.Text))
            {
                txtArrearMoney.Text = ComValueResx.txtIntDefault;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(MsgResx.confrim_delete, ComValueResx.confrim, MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                OperationMode = 2;

                if (_customerService.Exist(u => u.khid.Contains(txtKhid.Text)))
                {
                    _customerService.Delete(GetKhxx());
                }
            }
            
        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (0 > e.RowIndex)
            {
                return;
            }

            //txtKhid.Text = dgvCustomer.Rows[e.RowIndex].Cells["客户编码"].Value.ToString();
            txtKhmc.Text = dgvCustomer.Rows[e.RowIndex].Cells["客户名称"].Value.ToString();
            combZlmc.Text = dgvCustomer.Rows[e.RowIndex].Cells["种类"].Value.ToString();
            combYwy.Text = dgvCustomer.Rows[e.RowIndex].Cells["业务员"].Value == null ? "": 
                dgvCustomer.Rows[e.RowIndex].Cells["业务员"].Value.ToString();
            combXsbmc.Text = dgvCustomer.Rows[e.RowIndex].Cells["销售部"].Value.ToString();
            combJskhmc.Text = dgvCustomer.Rows[e.RowIndex].Cells["结算客户"].Value.ToString();
            combXqmc.Text = dgvCustomer.Rows[e.RowIndex].Cells["销区名称"].Value.ToString();
            txtBp.Text = dgvCustomer.Rows[e.RowIndex].Cells["信誉额"].Value.ToString();
            txtSj.Text = dgvCustomer.Rows[e.RowIndex].Cells["手机"].Value.ToString();
            txtTel.Text = dgvCustomer.Rows[e.RowIndex].Cells["电话"].Value.ToString();
            txtAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells["地址"].Value.ToString();
            txtKhh.Text = dgvCustomer.Rows[e.RowIndex].Cells["开户行"].Value.ToString();
            txtZh.Text = dgvCustomer.Rows[e.RowIndex].Cells["账号"].Value.ToString();
            txtSh.Text = dgvCustomer.Rows[e.RowIndex].Cells["税号"].Value.ToString();
            txtYb.Text = dgvCustomer.Rows[e.RowIndex].Cells["邮编"].Value.ToString();
            txtArrearDay.Text = dgvCustomer.Rows[e.RowIndex].Cells["欠款提醒期限"].Value.ToString();
            txtArrearMoney.Text = dgvCustomer.Rows[e.RowIndex].Cells["欠款提醒额度"].Value.ToString();
            txtLxr.Text = dgvCustomer.Rows[e.RowIndex].Cells["联系人"].Value == null ? "" :
                dgvCustomer.Rows[e.RowIndex].Cells["联系人"].Value.ToString();
            txtEmail.Text = dgvCustomer.Rows[e.RowIndex].Cells["邮箱"].Value == null ? "":
                dgvCustomer.Rows[e.RowIndex].Cells["邮箱"].Value.ToString();

            SetCompetenceEnabled(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (OperationMode)
            {
                case 1:
                    // 添加客户
                    AddCustomer();
                    break;
                case 3:
                    // 更新客户
                    UpdateCustomer();
                    break;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OperationMode = 3;

            SetCompetenceEnabled(true);

            txtKhmc.Enabled = false;

            btnAdd.Enabled = false;

            btnDel.Enabled = false;

            btnUpdate.Enabled = false;

            btnSearch.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OperationMode = 4;
        }

        /// <summary>
        /// 添加客户的处理
        /// </summary>
        private void AddCustomer()
        {
            // 画面字段为空的处理
            SetCombDefault();

            _customerService.Add(GetKhxx());
        }

        /// <summary>
        /// 更新客户的处理
        /// </summary>
        private void UpdateCustomer()
        {
            // 画面字段为空的处理
            SetCombDefault();

            _customerService.Update(GetKhxx());
        }

        /// <summary>
        /// 画面字段为空的处理
        /// </summary>
        private void SetCombDefault()
        {
            if (string.IsNullOrWhiteSpace(combXqmc.Text))
            {
                combXqmc.Text = ComValueResx.combTextDefault;
            }

            if (string.IsNullOrWhiteSpace(combXsbmc.Text))
            {
                combXsbmc.Text = ComValueResx.combTextDefault;
            }

            if (string.IsNullOrWhiteSpace(combZlmc.Text))
            {
                combZlmc.Text = ComValueResx.combTextDefault;
            }
        }

        /// <summary>
        /// 取得画面客户信息
        /// </summary>
        /// <returns></returns>
        private khxx GetKhxx()
        {
            return new khxx
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
            };
        }

        private void SetCompetenceEnabled(bool bEnabled)
        {
            txtKhmc.Enabled = bEnabled;
            combZlmc.Enabled = bEnabled;
            combYwy.Enabled = bEnabled;
            combXsbmc.Enabled = bEnabled;
            combJskhmc.Enabled = bEnabled;
            combXqmc.Enabled = bEnabled;
            txtBp.Enabled = bEnabled;
            txtSj.Enabled = bEnabled;
            txtTel.Enabled = bEnabled;
            txtAddress.Enabled = bEnabled;
            txtKhh.Enabled = bEnabled;
            txtZh.Enabled = bEnabled;
            txtSh.Enabled = bEnabled;
            txtArrearDay.Enabled = bEnabled;
            txtArrearMoney.Enabled = bEnabled;
            txtLxr.Enabled = bEnabled;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            OperationMode = 0;

            btnAdd.Enabled = true;

            btnDel.Enabled = true;

            btnUpdate.Enabled = true;

            btnSearch.Enabled = true;
        }
    }
}
