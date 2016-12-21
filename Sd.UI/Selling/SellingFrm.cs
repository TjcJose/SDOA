//-----------------------------------------------
// 销售系统-销售单
// 销售单画面
// 创建：2016.11.14 高振亮
// 修改：2016.11.14 高振亮
//-----------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sd.BLL;
using Sd.IBLL;
using System.Threading;
using Microsoft.Reporting.WinForms;
using Sd.Model;
using Sd.Model.Rdlc;
using Sd.UI.Common;
using Sd.UI.Properties;

namespace Sd.UI.Selling
{
    public partial class SellingFrm : Form
    {
        // 操作标识，1：增加，2：删除，3：修改
        private int _operationMode;

        public xsd XsdInfo;

        public SellingFrm()
        {
            InitializeComponent();
        }

        private void SellingFrm_Load(object sender, EventArgs e)
        {
            // 下拉框数据绑定
            CombBind();
        }

        #region 重写事件

        /// <summary>
        /// 重写ProcessDialogKey，主要用于【回车】切换控件
        /// </summary>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData != Keys.Enter) return base.ProcessDialogKey(keyData);

            switch (ActiveControl.Name)
            {
                case "txtSgddh":
                    // 为了执行txtSgddh_KeyPress
                    return base.ProcessDialogKey(keyData);
                case "combKhid":
                    if (string.IsNullOrWhiteSpace(combKhid.Text))
                    {
                        MessageBox.Show(lblKhid.Text + ComValueResx.comp_not_null);
                        combKhid.Focus();
                        return true;
                    }

                    //string khidTemp;

                    foreach (
                        var item in
                            combKhid.Items.Cast<object>()
                                .Where(item => item.ToString().Contains(combKhid.Text.ToUpper())))
                    {
                        combKhid.Text = item.GetType().GetProperty("khmc").GetValue(item, null).ToString();
                        break;
                    }
                    break;
                case "txtMpssm":
                    if (null != dgvXsdmx.CurrentCell)
                    {
                        dgvXsdmx.BeginEdit(true);
                        return true;
                    }
                    break;
            }

            keyData = Keys.Tab;

            return base.ProcessDialogKey(keyData);
        }

        #endregion

        #region Click事件

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmReset();

            _operationMode = 1;

            btnAdd.Enabled = false;

            btnRefund.Enabled = false;

            btnUpdate.Enabled = false;

            btnReview.Enabled = false;

            btnSearch.Enabled = false;

            dgvXsdmx.ReadOnly = false;

            dgvXsdmx.Rows.Add();

            txtSgddh.Focus();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // 增加和更新时处理
            if (_operationMode != 1 && _operationMode != 3)
            {
                return;
            }

            if (null == dgvXsdmx.CurrentRow)
            {
                return;
            }

            dgvXsdmx.Rows.Remove(dgvXsdmx.CurrentRow);

            if (dgvXsdmx.RowCount != 0)
            {
                return;
            }

            if (DialogResult.Yes == MessageBox.Show(MsgResx.delete_confirm, ComValueResx.confrim, MessageBoxButtons.YesNo))
            {
                if (3 == _operationMode)
                {
                    IXsdService xsdService = new XsdService();
                    if (xsdService.Exist(u => u.xsdid != txtXsdid.Text))
                    {
                        MessageBox.Show(MsgResx.delete_check);
                        return;
                    }

                    var xsdInfoDel = xsdService.Find(u => u.xsdid == txtXsdid.Text);

                    // 判断是否已经审核
                    if ("1" == xsdInfoDel.flag)
                    {
                        MessageBox.Show(MsgResx.review_already);
                        return;
                    }

                    // 修改模式下，删除本单
                    IXsdmxService xsdmxService = new XsdmxService();

                    if (xsdmxService.PatchDelete(u=>u.xsdid == txtXsdid.Text))
                    {
                        MessageBox.Show(xsdService.Delete(new xsd
                        {
                            xsdid = txtXsdid.Text
                        })
                            ? MsgResx.delete_success
                            : MsgResx.delete_fail);
                    }
                    else
                    {
                        MessageBox.Show(MsgResx.delete_fail);
                    }
                }

                FrmReset();
                
            }
            else
            {
                dgvXsdmx.Rows.Add();
                dgvXsdmx.BeginEdit(true);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // chk:是否已经审核
            IXsdService xsdService = new XsdService();

            if (!xsdService.Exist(u => u.xsdid == txtXsdid.Text))
            {
                MessageBox.Show(MsgResx.delete_check);
                return;
            }

            var xsdInfo = xsdService.Find(u => u.xsdid == txtXsdid.Text);

            if ("1".Equals(xsdInfo.flag))
            {
                MessageBox.Show(MsgResx.update_chk_reviewed);
                return;
            }

            _operationMode = 3;

            btnAdd.Enabled = false;

            btnRefund.Enabled = false;

            btnUpdate.Enabled = false;

            btnReview.Enabled = false;

            btnSearch.Enabled = false;

            btnPrint.Enabled = false;

            dgvXsdmx.ReadOnly = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _operationMode = 5;

            XsdInfo = null;

            var sellingSearchFrm = new SellingSearchFrm(this);
            sellingSearchFrm.ShowDialog();

            if (null == XsdInfo)
            {
                return;
            }

            if ("1".Equals(XsdInfo.flag))
            {
                btnUpdate.Enabled = false;
                btnReview.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;
                btnReview.Enabled = true;
            }

            txtXsdid.Text = XsdInfo.xsdid.TrimEnd();
            txtSgddh.Text = null == XsdInfo.sgddh ? "": XsdInfo.sgddh.TrimEnd();
            combKhid.Text = XsdInfo.khmc.TrimEnd();
            combXsbid.Text = XsdInfo.xsbxx.xsbmc.TrimEnd();
            combZl.Text = XsdInfo.zl.TrimEnd();
            combYyy.Text = XsdInfo.yyy.TrimEnd();
            combYyy.Text = XsdInfo.ywy.TrimEnd();
            txtEjkh.Text = XsdInfo.ejkh.TrimEnd();
            txtTel.Text = XsdInfo.tel.TrimEnd();
            txtAddress.Text = XsdInfo.address.TrimEnd();
            txtMpssm.Text = XsdInfo.mpssm;
            txtHjzje.Text = null == XsdInfo.hjzje ? "0": XsdInfo.hjzje.Value.ToString("F1");
            txtSr.Text = null == XsdInfo.sr ? "0" : XsdInfo.sr.Value.ToString("F1");
            txtSsze.Text = null == XsdInfo.ssze ? "0" : XsdInfo.ssze.Value.ToString("F1");
            txtXj.Text = null == XsdInfo.xj ? "0" : XsdInfo.xj.Value.ToString("F1");
            txtZz.Text = null == XsdInfo.zz ? "0" : XsdInfo.zz.Value.ToString("F1");
            txtYs.Text = null == XsdInfo.ys ? "0" : XsdInfo.ys.Value.ToString("F1");
            txtSdr.Text = XsdInfo.sdr;

            var xsdid = XsdInfo.xsdid.TrimEnd();

             IXsdmxService xsdmxService = new XsdmxService();

            var xsdmxList = xsdmxService.FindList(u =>
                u.xsdid.Equals(xsdid), "xsdlsh", true);
            dgvXsdmx.Rows.Clear();

            new Thread(delegate()
            {
                dgvXsdmx.Invoke((MethodInvoker) delegate
                {
                    foreach (var item in xsdmxList)
                    {
                        if (null == item.spxx)
                        {
                            continue;
                        }
                        dgvXsdmx.Rows.Add();
                        dgvXsdmx.Rows[dgvXsdmx.RowCount - 1].Cells["商品编码"].Value = item.spid.TrimEnd();
                        dgvXsdmx.Rows[dgvXsdmx.RowCount - 1].Cells["编码型号"].Value = item.spxx.pm.TrimEnd();
                        dgvXsdmx.Rows[dgvXsdmx.RowCount - 1].Cells["原单价"].Value = item.spxx.db1;
                        dgvXsdmx.Rows[dgvXsdmx.RowCount - 1].Cells["折扣"].Value = item.spxx.zkl1;
                        dgvXsdmx.Rows[dgvXsdmx.RowCount - 1].Cells["销售价"].Value = null == item.spxx.xsj
                            ? "0"
                            : item.spxx.xsj.Value.ToString("F1");
                        dgvXsdmx.Rows[dgvXsdmx.RowCount - 1].Cells["单位"].Value = item.dw;
                        dgvXsdmx.Rows[dgvXsdmx.RowCount - 1].Cells["数量"].Value = item.xssl.ToString("F0");
                        dgvXsdmx.Rows[dgvXsdmx.RowCount - 1].Cells["金额"].Value = item.xsje.ToString("F1");
                    }
                });
            }){IsBackground = true}.Start();

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            FrmReset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // check
            // 增加和更新时处理
            if (_operationMode != 1 && _operationMode != 3)
            {
                return;
            }

            // 销售单明细Chk：是否为空
            if (0 == dgvXsdmx.RowCount)
            {
                MessageBox.Show(MsgResx.xsdmx_null);
                return;
            }

            // 合计金额Chk：是否和Dgv合计相等
            var sumJe = GetHjzje();

            if (!txtHjzje.Text.Equals(sumJe))
            {
                MessageBox.Show(MsgResx.hjzje_error);
                return;
            }

            // 金额Chk：判断输入的金额符合格式
            decimal decSr, decSs, decXj, decZz, decYs;

            if (!decimal.TryParse(txtSr.Text, out decSr))
            {
                MessageBox.Show(MsgResx.input_money_chk + lblSr.Text);
                txtSr.Focus();
                txtSr.SelectAll();
                return;
            }

            if (!decimal.TryParse(txtSsze.Text, out decSs))
            {
                MessageBox.Show(MsgResx.input_money_chk + lblSsze.Text);
                txtSsze.Focus();
                txtSsze.SelectAll();
                return;
            }

            if (!decimal.TryParse(txtXj.Text, out decXj))
            {
                MessageBox.Show(MsgResx.input_money_chk + lblXj.Text);
                txtXj.Focus();
                txtXj.SelectAll();
                return;
            }

            if (!decimal.TryParse(txtZz.Text, out decZz))
            {
                MessageBox.Show(MsgResx.input_money_chk + lblZz.Text);
                txtZz.Focus();
                txtZz.SelectAll();
                return;
            }

            if (!decimal.TryParse(txtYs.Text, out decYs))
            {
                MessageBox.Show(MsgResx.input_money_chk + lblYs.Text);
                txtYs.Focus();
                txtYs.SelectAll();
                return;
            }

            if (decSs != decXj + decZz + decYs)
            {
                MessageBox.Show(MsgResx.input_money_ssze);
                txtXj.Focus();
                txtXj.SelectAll();
                return;
            }

            
            if (1 == _operationMode)
            {
                // 添加销售单信息
                AddXsdInfo();
            }
            else
            {
                // 更新销售单信息
                UpdateXsdInfo();
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            // check
            IXsdService xsdService = new XsdService();
            var reviewXsd = xsdService.Find(u => u.xsdid == txtXsdid.Text);
            if (null == reviewXsd)
            {
                return;
            }

            if ("1".Equals(reviewXsd.flag))
            {
                MessageBox.Show(MsgResx.review_already);
            }
            else
            {
                reviewXsd.flag = "1";
                reviewXsd.sdr = "审单人"; //TODO 审单人

                MessageBox.Show(xsdService.Update(reviewXsd) ? MsgResx.review_success : MsgResx.review_faild);

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtXsdid.Text))
            {
                return;
            }

            IXsdService xsdService = new XsdService();
            var reviewXsd = xsdService.Find(u => u.xsdid == txtXsdid.Text);
            if (null == reviewXsd)
            {
                MessageBox.Show(MsgResx.delete_check);
                return;
            }

            if (null != reviewXsd.printCount)
            {
                MessageBox.Show(MsgResx.print_already);
                return;
            }

            /*var comPrint = new ComPrint();
            comPrint.Run("SellingPrintRdlc.rdlc", "SellingDetailDs", GetDgvToList(dgvXsdmx));*/
            var printFrm = new SellingPrintFrm(GetDgvToList(dgvXsdmx));
            printFrm.ShowDialog();
        }

        #endregion

        #region Leave事件

        private void combKhid_Leave(object sender, EventArgs e)
        {
            combXsbid.Focus();
        }

        private void combXsbid_Leave(object sender, EventArgs e)
        {
            if (_operationMode != 1)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(combXsbid.Text))
            {
                if (0 == combXsbid.Items.Count)
                {
                    return;
                }

                MessageBox.Show(lblXsbid.Text + ComValueResx.comp_not_null);

                combXsbid.Focus();

                return; // true 表示已处理
            }

            if (null == combXsbid.SelectedItem)
            {
                if (0 == combXsbid.Items.Count)
                {
                    return;
                }

                combXsbid.SelectedIndex = 0;
                combXsbid.Focus();

                return;
            }

            SetTxtXsdidFromDb();

        }

        private void txtSr_Leave(object sender, EventArgs e)
        {
            decimal srDecimal;
            if (!decimal.TryParse(txtSr.Text, out srDecimal))
            {
                MessageBox.Show(MsgResx.input_money_chk + lblSr.Text);
                txtSr.Focus();
            }
            else
            {
                txtSsze.Text = (decimal.Parse(txtHjzje.Text) - srDecimal).ToString("F1");
            }
        }

        #endregion

        #region TextChanged事件

        private void txtHjzje_TextChanged(object sender, EventArgs e)
        {
            decimal hjzjeDecimal;

            if (decimal.TryParse(txtHjzje.Text, out hjzjeDecimal))
            {
                txtSsze.Text = (hjzjeDecimal - decimal.Parse(txtSr.Text)).ToString("F1");
            }
        }

        #endregion

        #region 键盘事件

        private void txtSgddh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSgddh.Text))
            {

                combKhid.Focus();
                return;
            }

            IXsdService xsdService = new XsdService();
            if (!xsdService.Exist(u => u.xsdid.Contains(txtSgddh.Text.Trim()) || u.sgddh.Contains(txtSgddh.Text.Trim())))
            {
                MessageBox.Show(MsgResx.input_id_null);
            }
            else
            {
                e.Handled = true;
                var sellingInfoFrm = new SellingInfoFrm(this, txtSgddh.Text.Trim());
                sellingInfoFrm.ShowDialog();

                if (null != XsdInfo)
                {

                    txtSgddh.Text = XsdInfo.sgddh.TrimEnd();
                    combKhid.Text = XsdInfo.khmc.TrimEnd();
                    combXsbid.Text = XsdInfo.xsbxx.xsbmc.TrimEnd();
                    combZl.Text = XsdInfo.zl.TrimEnd();
                    combYyy.Text = XsdInfo.yyy.TrimEnd();
                    combYyy.Text = XsdInfo.ywy.TrimEnd();
                    txtEjkh.Text = XsdInfo.ejkh.TrimEnd();
                    txtTel.Text = XsdInfo.tel.TrimEnd();
                    txtAddress.Text = XsdInfo.address.TrimEnd();
                    SetTxtXsdidFromDb();
                    txtMpssm.Focus();
                }
                else
                {
                    combKhid.Focus();
                }
            }
        }

        #endregion

        #region Dgv处理

        private void dgvXsdmx_KeyUp(object sender, KeyEventArgs e)
        {
            // 增加和更新时处理
            if (_operationMode != 1 && _operationMode != 3)
            {
                return;
            }
            if (e.KeyData != Keys.Enter)
            {
                return;
            }

            if (null == dgvXsdmx.CurrentCell)
            {
                return;
            }

            if (dgvXsdmx.CurrentCell.Value == null)
            {
                MessageBox.Show(dgvXsdmx.CurrentCell.OwningColumn.Name + ComValueResx.comp_not_null);
                dgvXsdmx.BeginEdit(true);
                return;
            }

            switch (dgvXsdmx.CurrentCell.ColumnIndex)
            {
                case 0:
                    IGoodsService goodsService = new GoodsService();

                    var spxx = goodsService.Find(u => u.spid.Contains(dgvXsdmx.CurrentCell.Value.ToString().Trim()));

                    if (null == spxx)
                    {
                        dgvXsdmx.BeginEdit(true);
                        return;
                    }

                    dgvXsdmx.CurrentCell.Value = spxx.spid.TrimEnd(); // 商品编码
                    dgvXsdmx.Rows[dgvXsdmx.CurrentCell.RowIndex].Cells[1].Value = spxx.pm.TrimEnd(); // 编码型号
                    dgvXsdmx.Rows[dgvXsdmx.CurrentCell.RowIndex].Cells[2].Value =
                        null == spxx.db1 ? "0" : spxx.db1.Value.ToString("F1"); // 原价
                    dgvXsdmx.Rows[dgvXsdmx.CurrentCell.RowIndex].Cells[3].Value =
                        null == spxx.zkl1 ? "0" : spxx.zkl1.Value.ToString("F1"); // 折扣
                    dgvXsdmx.Rows[dgvXsdmx.CurrentCell.RowIndex].Cells[4].Value =
                        null == spxx.xsj ? "0" : spxx.xsj.Value.ToString("F1"); // 销售价
                    dgvXsdmx.Rows[dgvXsdmx.CurrentCell.RowIndex].Cells[5].Value = spxx.dw.TrimEnd(); // 单位

                    dgvXsdmx.CurrentCell =
                        dgvXsdmx.Rows[dgvXsdmx.CurrentCell.RowIndex].Cells["数量"];
                    dgvXsdmx.BeginEdit(true);
                    break;
                case 6:
                    if (dgvXsdmx.CurrentRow == null)
                    {
                        return;
                    }
                    int iSl;

                    if (
                        !int.TryParse(dgvXsdmx.Rows[dgvXsdmx.CurrentCell.RowIndex].Cells["数量"].Value.ToString(), out iSl))
                    {
                        MessageBox.Show(ComValueResx.input_int);
                        dgvXsdmx.BeginEdit(true);
                        return;
                    }

                    if (null == dgvXsdmx.Rows[dgvXsdmx.CurrentCell.RowIndex].Cells[4].Value)
                    {
                        MessageBox.Show(dgvXsdmx.CurrentCell.OwningColumn.Name + ComValueResx.comp_not_null);
                        return;
                    }

                    dgvXsdmx.Rows[dgvXsdmx.CurrentCell.RowIndex].Cells["金额"].Value =
                        decimal.Parse(dgvXsdmx.Rows[dgvXsdmx.CurrentCell.RowIndex].Cells[4].Value.ToString())*
                        int.Parse(dgvXsdmx.Rows[dgvXsdmx.CurrentCell.RowIndex].Cells["数量"].Value.ToString());

                    dgvXsdmx.CurrentCell =
                        dgvXsdmx.Rows[dgvXsdmx.CurrentCell.RowIndex].Cells["金额"];

                    var sum = GetHjzje();

                    if (null == sum)
                    {
                        return;
                    }

                    txtHjzje.Text = sum;

                    break;

                case 7:
                    if (dgvXsdmx.CurrentRow == null)
                    {
                        return;
                    }

                    for (var i = 0; i < dgvXsdmx.CurrentRow.Cells.Count; i++)
                    {
                        var cell = dgvXsdmx.CurrentRow.Cells[i];
                        if (null != cell.Value)
                        {
                            continue;
                        }

                        dgvXsdmx.CurrentCell = cell;
                        dgvXsdmx.BeginEdit(true);
                        return;
                    }

                    dgvXsdmx.Rows.Add();

                    dgvXsdmx.CurrentCell =
                        dgvXsdmx.Rows[dgvXsdmx.CurrentCell.RowIndex + 1].Cells[0];

                    break;

                default:
                    dgvXsdmx.CurrentCell =
                        dgvXsdmx.Rows[dgvXsdmx.CurrentCell.RowIndex].Cells[dgvXsdmx.CurrentCell.ColumnIndex + 1];
                    break;
            }
        }

        private void dgvXsdmx_Leave(object sender, EventArgs e)
        {
            // 删除空白行
            if (1 < dgvXsdmx.RowCount && null == dgvXsdmx.Rows[dgvXsdmx.RowCount - 1].Cells[0].Value && !btnDel.Focused)
            {
                dgvXsdmx.Rows.RemoveAt(dgvXsdmx.RowCount - 1);
            }
        }

        private void dgvXsdmx_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            var sum = GetHjzje();

            if (null == sum)
            {
                return;
            }

            txtHjzje.Text = sum;
        }

        #endregion

        #region 自定义方法

        /// <summary>
        /// 获取总金额
        /// </summary>
        /// <returns></returns>
        private string GetHjzje()
        {
            decimal sum = 0;

            foreach (DataGridViewRow dgvRow in dgvXsdmx.Rows)
            {
                if (null == dgvRow.Cells["金额"].Value)
                {
                    dgvXsdmx.CurrentCell = null == dgvRow.Cells["商品编码"].Value
                        ? dgvRow.Cells["商品编码"]
                        : dgvRow.Cells["数量"];

                    dgvXsdmx.BeginEdit(true);
                    return null;
                }

                sum = sum + decimal.Parse(dgvRow.Cells["金额"].Value.ToString());
            }

            return sum.ToString("F1");
        }

        /// <summary>
        /// 下拉框数据初始化
        /// </summary>
        private void CombBind()
        {
            var thread = new Thread(delegate()
            {
                combKhid.Invoke((MethodInvoker) delegate
                {
                    // 直属客户
                    ICustomerService customerService = new CustomerService();
                    combKhid.DataSource =
                        customerService.FindList(u => u.stopSign.Equals("0"), "khid", true)
                            .Select(u => new {khid = u.khid.Trim(), khmc = u.khmc.Trim()})
                            .ToList();
                    combKhid.DisplayMember = "khmc";

                    // 销售部
                    IXsbxxService xsbxxService = new XsbxxService();
                    combXsbid.DataSource =
                        xsbxxService.FindList(u => u.stopsign.Equals("0"), "xsbid", true)
                            .Select(u => new {xsbid = u.xsbid.Trim(), xsbmc = u.xsbmc.Trim()})
                            .ToList();
                    combXsbid.DisplayMember = "xsbmc";

                    // 种类
                    IZlService zlService = new ZlService();
                    combZl.DataSource = zlService.FindList(u => true, "zldm", true).Select(u => u.zlmc.Trim()).ToList();

                    // 职员信息
                    IZyxxService zyxxService = new ZyxxService();
                    var zyxxList = zyxxService.FindList(u => true, "zyid", true);
                    combYyy.DataSource =
                        zyxxList.Where(u => u.zw.Trim().Equals("营业员")).Select(u => u.name.Trim()).ToList();
                    combYwy.DataSource =
                        zyxxList.Where(u => u.zw.Trim().Equals("业务员")).Select(u => u.name.Trim()).ToList();
                    combSjsid.DataSource =
                        zyxxList.Where(u => u.zw.Trim().Equals("设计师")).Select(u => u.name.Trim()).ToList();

                    combKhid.Text = "";
                    combYyy.Text = "";
                    combYwy.Text = "";
                    combSjsid.Text = "";
                });
            }) {IsBackground = true};
            thread.Start();
        }

        /// <summary>
        /// 设置销售单号
        /// </summary>
        private void SetTxtXsdidFromDb()
        {
            var xsbId = combXsbid.SelectedItem.GetType()
                .GetProperty("xsbid")
                .GetValue(combXsbid.SelectedItem, null);

            if (null != xsbId && 3 < xsbId.ToString().Length)
            {
                xsbId = xsbId.ToString().Substring(0, 3);
            }

            ISellingService sellingService = new SellingService();
            txtXsdid.Text = xsbId + sellingService.GetPh(combXsbid.Text).PadLeft(7, '0');

            if (10 != txtSgddh.Text.Length)
            {
                txtSgddh.Text = txtXsdid.Text;
            }
        }
        /// <summary>
        /// 画面控件重置
        /// </summary>
        private void FrmReset()
        {
            _operationMode = 0;

            txtXsdid.Text = "";

            dtpXsrq.Text = DateTime.Now.ToLongTimeString();

            txtSgddh.Text = "";

            txtEjkh.Text = "";

            txtTel.Text = "";

            txtAddress.Text = "";

            txtMpssm.Text = "";

            txtHjzje.Text = ComValueResx.txtIntDefault;

            txtSr.Text = ComValueResx.txtIntDefault;

            txtSsze.Text = ComValueResx.txtIntDefault;

            txtXj.Text = ComValueResx.txtIntDefault;

            txtZz.Text = ComValueResx.txtIntDefault;

            txtYs.Text = ComValueResx.txtIntDefault;

            txtInSpbm.Text = "";

            //chkAutoRead.Checked = true;

            txtSdr.Text = "";

            txtBz3.Text = "";

            combKhid.Text = "";

            combXsbid.Text = "";

            combZl.Text = "";

            combYyy.Text = "";

            combYwy.Text = "";

            combSjsid.Text = "";

            dgvXsdmx.Rows.Clear();

            btnDel.Enabled = true;
            btnAdd.Enabled = true;
            btnExit.Enabled = true;
            btnPrint.Enabled = true;
            btnQuit.Enabled = true;
            btnRefund.Enabled = true;
            btnReview.Enabled = false;
            btnSave.Enabled = true;
            btnSearch.Enabled = true;
            btnUpdate.Enabled = false;

            btnAdd.Focus();
        }

        /// <summary>
        /// 添加销售单信息
        /// </summary>
        private void AddXsdInfo()
        {
            IXsdService xsdService = new XsdService();

            var xsdAdd = xsdService.Add(GetXsdInfoFromFrm());
            if (null == xsdAdd)
            {
                MessageBox.Show(MsgResx.add_fail);
                return;
            }

            IXsdmxService xsdmxService = new XsdmxService();

            if (xsdmxService.PatchById(GetXsdmxInfoFromDgv(), "add"))
            {
                MessageBox.Show(MsgResx.add_success);
            }
            else
            {
                xsdService.Delete(xsdAdd);
                MessageBox.Show(MsgResx.add_fail);
            }
        }

        /// <summary>
        /// 更新销售单信息
        /// </summary>
        private void UpdateXsdInfo()
        {
            // chk:是否已经审核
            IXsdService xsdService = new XsdService();

            if (!xsdService.Exist(u => u.xsdid == txtXsdid.Text))
            {
                MessageBox.Show(MsgResx.delete_check);
                return;
            }

            var xsdInfo = xsdService.Find(u => u.xsdid == txtXsdid.Text);

            if ("1".Equals(xsdInfo.flag))
            {
                MessageBox.Show(MsgResx.update_chk_reviewed);
                return;
            }

            // 先更新销售单明细
            IXsdmxService xsdmxService = new XsdmxService();

            if (xsdmxService.PatchDelete(u => u.xsdid == txtXsdid.Text))
            {
                if (xsdmxService.PatchById(GetXsdmxInfoFromDgv(), "add"))
                {
                    if (xsdService.NewUpdate(t => t.xsdid == txtXsdid.Text, u => new xsd()
                    {
                        sgddh = txtSgddh.Text,
                        khid =
                            combKhid.SelectedItem.GetType()
                            .GetProperty("khid")
                            .GetValue(combKhid.SelectedItem, null)
                            .ToString()
                            .TrimEnd(),
                        khmc = combKhid.Text.Trim(),
                        xsbid =
                            combXsbid.SelectedItem.GetType()
                                .GetProperty("xsbid")
                                .GetValue(combXsbid.SelectedItem, null)
                                .ToString(),
                        zl = combZl.Text,
                        yyy = combYyy.Text,
                        ywy = combYwy.Text,
                        ejkh = txtEjkh.Text,
                        tel = txtTel.Text.Trim(),
                        address = txtAddress.Text,
                        mpssm = txtMpssm.Text,
                        zje = decimal.Parse(txtHjzje.Text),
                        hjzje = decimal.Parse(txtHjzje.Text),
                        sr = decimal.Parse(txtSr.Text),
                        ssze = decimal.Parse(txtSsze.Text),
                        xj = decimal.Parse(txtXj.Text),
                        zz = decimal.Parse(txtZz.Text),
                        ys = decimal.Parse(txtYs.Text),
                        syy = txtSyy.Text,
                        sjsid = "yll"
                    }))
                    {
                        _operationMode = 0;

                        btnAdd.Enabled = true;

                        btnRefund.Enabled = true;

                        btnUpdate.Enabled = true;

                        btnReview.Enabled = true;

                        btnSearch.Enabled = true;

                        btnPrint.Enabled = true;

                        dgvXsdmx.ReadOnly = true;

                        MessageBox.Show(MsgResx.update_success);
                        return;
                    }
                }
            }

            MessageBox.Show(MsgResx.update_fail);
        }

        /// <summary>
        /// 取得画面销售单信息
        /// </summary>
        /// <returns></returns>
        private xsd GetXsdInfoFromFrm()
        {
            return new xsd
            {
                khid =
                    combKhid.SelectedItem.GetType()
                        .GetProperty("khid")
                        .GetValue(combKhid.SelectedItem, null)
                        .ToString()
                        .TrimEnd(),
                khmc = combKhid.Text.Trim(),
                xsbid =
                    combXsbid.SelectedItem.GetType()
                        .GetProperty("xsbid")
                        .GetValue(combXsbid.SelectedItem, null)
                        .ToString(),
                zl = combZl.Text,
                yyy = combYyy.Text,
                ywy = combYwy.Text,
                ejkh = txtEjkh.Text,
                tel = txtTel.Text.Trim(),
                address = txtAddress.Text,
                mpssm = txtMpssm.Text,
                zje = decimal.Parse(txtHjzje.Text),
                hjzje = decimal.Parse(txtHjzje.Text),
                sr = decimal.Parse(txtSr.Text),
                ssze = decimal.Parse(txtSsze.Text),
                xj = decimal.Parse(txtXj.Text),
                zz = decimal.Parse(txtZz.Text),
                ys = decimal.Parse(txtYs.Text),
                syy = txtSyy.Text,
                sjsid = "yll"
            };
        }
        /// <summary>
        /// 获取销售单明细
        /// </summary>
        /// <returns></returns>
        private List<xsdmx> GetXsdmxInfoFromDgv()
        {
            return (from DataGridViewRow dgvRow in dgvXsdmx.Rows
                select new xsdmx
                {
                    xsdid = txtXsdid.Text,
                    spid = dgvRow.Cells["商品编码"].Value.ToString(),
                    dw = dgvRow.Cells["单位"].Value.ToString(),
                    kqid = "1001", //TODO 库区ID
                    xsdj = decimal.Parse(dgvRow.Cells["销售价"].Value.ToString()),
                    xssl = decimal.Parse(dgvRow.Cells["数量"].Value.ToString()),
                    xsje = decimal.Parse(dgvRow.Cells["金额"].Value.ToString()),
                    color = "-"
                }).ToList();
        }

        public List<SellingDetail> GetDgvToList(DataGridView dgv)
        {
            return (from DataGridViewRow dgvRow in dgvXsdmx.Rows
                select new SellingDetail
                {
                    商品名称 = dgvRow.Cells["商品编码"].Value.ToString(),
                    单位 = dgvRow.Cells["单位"].Value.ToString(),
                    价格 = dgvRow.Cells["销售价"].Value.ToString(),
                    数量 = dgvRow.Cells["数量"].Value.ToString(),
                    金额 = dgvRow.Cells["金额"].Value.ToString()
                }).ToList();
        }

        #endregion
    }
}
