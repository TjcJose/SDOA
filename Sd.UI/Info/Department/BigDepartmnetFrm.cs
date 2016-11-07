//-----------------------------------------------
// 信息系统-部门
// 大部门信息画面
// 创建：2016.11.06 张志杰
// 修改：2016.11.07 高振亮
//-----------------------------------------------

using System;
using System.Linq;
using System.Windows.Forms;
using Sd.BLL;
using Sd.IBLL;
using Sd.Model;
using Sd.UI.Properties;

namespace Sd.UI.Info.Department
{
    public partial class BigDepartmnetFrm : Form
    {
        // 编号
        private int _operationMode;

        private readonly IBigDepartmentService _bigDepartmentService = new BigDepartmentService();

        public BigDepartmnetFrm()
        {
            InitializeComponent();
            txtbigDepartmentCode.Focus();
            BindBigDepartment();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BigDepartmnetFrm_Load(object sender, EventArgs e)
        {
            dgvBigDepartment.ClearSelection();
            Reset();
        }

        /// <summary>
        /// 行选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBigDepartment_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBigDepartment.SelectedRows.Count <= 0) return;

            _operationMode = int.Parse(dgvBigDepartment.SelectedRows[0].Cells[0].Value.ToString());

            txtbigDepartmentCode.Text = dgvBigDepartment.SelectedRows[0].Cells[1].Value.ToString();// 大部门编码
            txtbigDepartmentName.Text = dgvBigDepartment.SelectedRows[0].Cells[2].Value.ToString();// 大部门名称
            txtpym.Text = dgvBigDepartment.SelectedRows[0].Cells[3].Value.ToString();//拼音码
            txtpxbm.Text = dgvBigDepartment.SelectedRows[0].Cells[4].Value.ToString();//排序编码
            txtpxbm.Text = dgvBigDepartment.SelectedRows[0].Cells[5].Value.ToString();//备注
            btnAdd.Text = ComValueResx.btn_update_name;//修改
            btnDel.Visible = true;
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvBigDepartment.ClearSelection();
            Reset();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show(this, MsgResx.confrim_delete, ComValueResx.confrim, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK) return;
            // 大部门检查并删除 zzj

            if (_bigDepartmentService.Delete(GetBigDepartment()))
            {
                MessageBox.Show(MsgResx.delete_success, ComValueResx.confrim, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindBigDepartment();
                Reset();
            }
            else
            {
                MessageBox.Show(MsgResx.delete_fail, ComValueResx.confrim, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 添加或修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbigDepartmentCode.Text) || string.IsNullOrWhiteSpace(txtbigDepartmentName.Text))
            {
                MessageBox.Show(MsgResx.check_pk_null, ComValueResx.confrim, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            
            if (_operationMode == 0)
            {
                // 添加 zzj
                var addResult =  _bigDepartmentService.Add(GetBigDepartment());

                if (null != addResult)
                {
                    MessageBox.Show(MsgResx.add_success, ComValueResx.confrim, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindBigDepartment();
                    Reset();
                }
                else
                {
                    MessageBox.Show(MsgResx.add_fail, ComValueResx.confrim, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                // 修改 zzj
                if (_bigDepartmentService.Update(GetBigDepartment()))
                {
                    MessageBox.Show(MsgResx.update_success, ComValueResx.confrim, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindBigDepartment();
                    Reset();
                }
                else
                {
                    MessageBox.Show(MsgResx.update_fail, ComValueResx.confrim, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// 绑定dgvBigDepartment
        /// </summary>
        private void BindBigDepartment()
        {
            dgvBigDepartment.AutoGenerateColumns = false;

            dgvBigDepartment.DataSource = _bigDepartmentService.FindList(u => true, "bigDepartmentID", true).ToList();

            if (dgvBigDepartment.SelectedRows.Count > 0)
            {
                dgvBigDepartment.ClearSelection();
            }
        }

        /// <summary>
        /// 重置
        /// </summary>
        private void Reset()
        {
            _operationMode = 0;
            txtbigDepartmentID.Text = "";
            txtbigDepartmentCode.Text = "";
            txtbigDepartmentName.Text = "";
            txtpym.Text = "";
            txtpxbm.Text = "";
            txtbz.Text = "";
            btnAdd.Text = ComValueResx.btn_add_name;
            btnDel.Visible = false;
            txtbigDepartmentCode.Focus();
        }

        private bigDepartment GetBigDepartment()
        {
            return new bigDepartment
            {
                bigDepartmentID = int.Parse(txtbigDepartmentID.Text.Trim()),
                bigDepartmentCode = txtbigDepartmentCode.Text.Trim(),
                bigDepartmentName = txtbigDepartmentName.Text.Trim(),
                bz = txtbz.Text.Trim(),
                pxbm = txtpxbm.Text.Trim(),
                pym = txtpym.Text.Trim()
            };
        }
    }
}
