//-----------------------------------------------
// 信息系统-客户
// 客户画面
// 创建：2016.11.03 高振亮
// 修改：2016.11.03 高振亮
//-----------------------------------------------

using System;
using System.Linq;
using System.Threading;
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
        // 操作标识，1：增加，2：删除，3：修改
        private int _operationMode;

        public CustomerFrm()
        {
            InitializeComponent();
        }

        private void CustomerFrm_Load(object sender, EventArgs e)
        {
            btnDel.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;

            #region combobox绑定数据

            // 客户信息
            //new Thread(
            //    delegate()
            //    {
            //        dgvCustomer.Invoke((MethodInvoker) delegate
            //        {


            //            // 销区名称
            //            IXqxxService xqxxService = new XqxxService();
            //            combXqmc.DataSource = xqxxService.FindList(u => true, "xqid", true).ToList();
            //            combXqmc.DisplayMember = "xqmc";

            //            dgvCustomer.DataSource = customer.Select(u => new
            //            {
            //                客户编码 = u.khid,
            //                客户名称 = u.khmc,
            //                业务员 = u.ywy,
            //                种类 = u.zlmc,
            //                手机 = u.sj,
            //                电话 = u.tel,
            //                地址 = u.address,
            //                开户行 = u.khh,
            //                账号 = u.zh,
            //                税号 = u.sh,
            //                信誉额 = u.bp,
            //                欠款提醒期限 = u.arrearDay,
            //                欠款提醒额度 = u.arrearMoney,
            //                销售部 = u.xsbmc,
            //                销区名称 = u.xqmc,
            //                结算客户 = u.khmc, // TODO
            //                联系人 = u.lxr,
            //                邮编 = u.yb,
            //                邮箱 = u.email
            //            }).ToList();

            //            dgvCustomer.ClearSelection();
            //            SetCompetenceEnabled(true);
            //            ClearFrm();

            //            txtKhmc.Focus();
            //        });
            //    }).Start();

            #endregion
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _operationMode = 1;

            // 种类表
            IZlService zlService = new ZlService();
            combZlmc.DataSource = zlService.FindList(u => true, "zldm", true).Select(u => u.zlmc).ToList();

            // 业务员
            IZyxxService zyxxService = new ZyxxService();
            combYwy.DataSource = zyxxService.FindList(u => true, "zyid", true).Select(u => u.name).ToList();
            combYwy.Text = "";

            // 销售部
            IXsbxxService xsbxxService = new XsbxxService();
            combXsbmc.DataSource = xsbxxService.FindList(u => true, "xsbid", true).Select(u => u.xsbmc).ToList();

            // 结算客户
            var customer = _customerService.FindList(u => true, "khid", true);
            combJskhmc.DataSource = customer.Select(u => new { u.khid, u.khmc }).ToList();
            combJskhmc.DisplayMember = "khmc";
            combJskhmc.Text = "";

            SetCompetenceEnabled(true);

            btnAdd.Enabled = false;

            btnDel.Enabled = false;

            btnUpdate.Enabled = false;

            btnSearch.Enabled = false;

            ClearFrm();

            txtKhmc.Focus();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKhmc.Text))
            {
                MessageBox.Show(MsgResx.check_pk_null, ComValueResx.confrim);
                return;
            }

            if (MessageBox.Show(MsgResx.confrim_delete, ComValueResx.confrim, MessageBoxButtons.YesNo) !=
                DialogResult.Yes) return;

            _operationMode = 2;

            var deleteKhxx = _customerService.Find(u => u.khid.Contains(txtKhid.Text));

            if (null == deleteKhxx)
            {
                MessageBox.Show(MsgResx.delete_check);
                return;
            }

            if (_customerService.Delete(deleteKhxx))
            {
                MessageBox.Show(MsgResx.delete_success, ComValueResx.confrim);

                var customer = _customerService.FindList(u => true, "khid", true);

                dgvCustomer.DataSource = customer.Select(u => new
                {
                    客户编码 = u.khid,
                    客户名称 = u.khmc,
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
            else
            {
                MessageBox.Show(MsgResx.delete_fail, ComValueResx.confrim);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _operationMode = 3;

            SetCompetenceEnabled(true);

            txtKhmc.Enabled = false;

            btnAdd.Enabled = false;

            btnDel.Enabled = false;

            btnUpdate.Enabled = false;

            btnSearch.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _operationMode = 4;

            IQueryable<khxx> customer;

            if (!string.IsNullOrWhiteSpace(txtKhmc.Text))
            {
                customer = _customerService.FindList(u => u.khmc.Contains(txtKhmc.Text), "", true);
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txtSj.Text))
                {
                    customer = _customerService.FindList(u => u.sj.Contains(txtSj.Text), "", true);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(txtAddress.Text))
                    {
                        customer = _customerService.FindList(u => u.address.Contains(txtAddress.Text), "", true);
                    }
                    else
                    {
                        if (!string.IsNullOrWhiteSpace(txtZh.Text))
                        {
                            customer = _customerService.FindList(u => u.zh.Contains(txtZh.Text), "", true);
                        }
                        else
                        {
                            if (!string.IsNullOrWhiteSpace(txtSh.Text))
                            {
                                customer = _customerService.FindList(u => u.sh.Contains(txtSh.Text), "", true);
                            }
                            else
                            {
                                customer = string.IsNullOrWhiteSpace(txtTel.Text) ?
                                    _customerService.FindList(u => true, "", true) :
                                    _customerService.FindList(u => u.tel.Contains(txtTel.Text), "", true);
                            }
                        }
                    }
                }
            }

            // 客户信息
            dgvCustomer.DataSource = customer.Select(u => new
            {
                客户编码 = u.khid,
                客户名称 = u.khmc,
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

            dgvCustomer.ClearSelection();
            SetCompetenceEnabled(true);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (_operationMode)
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

        private void btnQuit_Click(object sender, EventArgs e)
        {
            _operationMode = 0;

            btnAdd.Enabled = true;

            btnDel.Enabled = true;

            btnUpdate.Enabled = true;

            btnSearch.Enabled = true;

            SetCompetenceEnabled(true);

            ClearFrm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtKhmc_TextChanged(object sender, EventArgs e)
        {
            if (1 == _operationMode)
            {
                txtKhid.Text = string.IsNullOrWhiteSpace(txtKhmc.Text) ? "" : StringUtil.GetFirstPinyin(txtKhmc.Text);
            }
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

        private void dgvCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (0 >= dgvCustomer.SelectedRows.Count)
            {
                return;
            }

            SetCompetenceEnabled(false);

            var dgvCustomerSelectedRow = dgvCustomer.SelectedRows[0];

            txtKhmc.Text = dgvCustomerSelectedRow.Cells["客户名称"].Value.ToString();
            txtKhid.Text = dgvCustomerSelectedRow.Cells["客户编码"].Value.ToString();
            combZlmc.Text = dgvCustomerSelectedRow.Cells["种类"].Value.ToString();
            combYwy.Text = dgvCustomerSelectedRow.Cells["业务员"].Value == null ? "" :
                dgvCustomerSelectedRow.Cells["业务员"].Value.ToString();
            combXsbmc.Text = dgvCustomerSelectedRow.Cells["销售部"].Value.ToString();
            combJskhmc.Text = dgvCustomerSelectedRow.Cells["结算客户"].Value.ToString();
            combXqmc.Text = dgvCustomerSelectedRow.Cells["销区名称"].Value.ToString();
            txtBp.Text = dgvCustomerSelectedRow.Cells["信誉额"].Value == null ? "0" : dgvCustomerSelectedRow.Cells["信誉额"].Value.ToString();
            txtSj.Text = dgvCustomerSelectedRow.Cells["手机"].Value.ToString();
            txtTel.Text = dgvCustomerSelectedRow.Cells["电话"].Value.ToString();
            txtAddress.Text = dgvCustomerSelectedRow.Cells["地址"].Value.ToString();
            txtKhh.Text = dgvCustomerSelectedRow.Cells["开户行"].Value.ToString();
            txtZh.Text = dgvCustomerSelectedRow.Cells["账号"].Value.ToString();
            txtSh.Text = dgvCustomerSelectedRow.Cells["税号"].Value.ToString();
            txtYb.Text = dgvCustomerSelectedRow.Cells["邮编"].Value.ToString();
            txtArrearDay.Text = dgvCustomerSelectedRow.Cells["欠款提醒期限"].Value.ToString();
            txtArrearMoney.Text = dgvCustomerSelectedRow.Cells["欠款提醒额度"].Value.ToString();
            txtLxr.Text = dgvCustomerSelectedRow.Cells["联系人"].Value == null ? "" :
                dgvCustomerSelectedRow.Cells["联系人"].Value.ToString();
            txtEmail.Text = dgvCustomerSelectedRow.Cells["邮箱"].Value == null ? "" :
                dgvCustomerSelectedRow.Cells["邮箱"].Value.ToString();

        }

        /// <summary>
        /// 添加客户的处理
        /// </summary>
        private void AddCustomer()
        {
            if (string.IsNullOrWhiteSpace(txtKhmc.Text))
            {
                MessageBox.Show(MsgResx.check_pk_null);
                return;
            }

            // 画面字段为空的处理
            SetCombDefault();

            MessageBox.Show(null == _customerService.Add(GetKhxx()) ? MsgResx.add_fail : MsgResx.add_success);
        }

        /// <summary>
        /// 更新客户的处理
        /// </summary>
        private void UpdateCustomer()
        {
            // 画面字段为空的处理
            SetCombDefault();

            MessageBox.Show(_customerService.Update(GetKhxx()) ? MsgResx.update_success : MsgResx.update_fail);
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
                ywy = combYwy.Text.Trim(),
                xsbmc = combXsbmc.Text.Trim(),
                jskhid = txtKhid.Text.Trim(),
                xqmc = combXqmc.Text.Trim(),
                bp = string.IsNullOrWhiteSpace(txtBp.Text.Trim()) ? 0 : decimal.Parse(txtBp.Text.Trim()),
                sj = txtSj.Text.Trim(),
                tel = txtTel.Text.Trim(),
                address = txtAddress.Text.Trim(),
                khh = txtKhh.Text.Trim(),
                zh = txtZh.Text.Trim(),
                sh = txtSh.Text.Trim(),
                yb = txtYb.Text.Trim(),
                arrearDay = string.IsNullOrWhiteSpace(txtArrearDay.Text.Trim()) ? 0 : int.Parse(txtArrearDay.Text.Trim()),
                arrearMoney = string.IsNullOrWhiteSpace(txtArrearMoney.Text.Trim()) ? 0 : decimal.Parse(txtArrearMoney.Text.Trim()),
                email = txtEmail.Text.Trim()
            };
        }

        /// <summary>
        /// 设置控件是否可用
        /// </summary>
        /// <param name="bEnabled">true：可用</param>
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
            txtYb.Enabled = bEnabled;
            txtEmail.Enabled = bEnabled;
        }

        /// <summary>
        /// 清空画面
        /// </summary>
        private void ClearFrm()
        {
            txtKhmc.Text = "";
            txtKhid.Text = "";
            combZlmc.Text = "";
            combYwy.Text = "";
            combXsbmc.Text = "";
            combJskhmc.Text = "";
            combXqmc.Text = "";
            txtBp.Text = "";
            txtSj.Text = "";
            txtTel.Text = "";
            txtAddress.Text = "";
            txtKhh.Text = "";
            txtZh.Text = "";
            txtSh.Text = "";
            txtYb.Text = "";
            txtArrearDay.Text = "";
            txtArrearMoney.Text = "";
            txtLxr.Text = "";
            txtEmail.Text = "";
        }
    }
}
