using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sd.UI.Info.Department
{
    public partial class BigDepartmnetFrm : Form
    {
        // 编号
        private int id = 0;
        public BigDepartmnetFrm()
        {
            InitializeComponent();
            txtbigDepartmentCode.Focus();
            BindBigDepartment();
        }

        private void BindBigDepartment()
        {
            // 根据实际情况绑定 zzj
            DataTable departmentDb = new DataTable();
            dgvBigDepartment.AutoGenerateColumns = false;
            dgvBigDepartment.DataSource = departmentDb;
            if (dgvBigDepartment.SelectedRows.Count > 0)
            {
                dgvBigDepartment.ClearSelection();
            }
        }

        /// <summary>
        /// 行选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvBigDepartment_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBigDepartment.DataSource != null)
            {
                DataTable dt = (DataTable)dgvBigDepartment.DataSource;
                if (dt.Rows.Count > 0)
                {
                    if (dgvBigDepartment.SelectedRows.Count > 0)
                    {
                        id = int.Parse(dgvBigDepartment.SelectedRows[0].Cells[0].Value.ToString());

                        txtbigDepartmentCode.Text = dgvBigDepartment.SelectedRows[0].Cells[1].Value.ToString();// 大部门编码
                        txtbigDepartmentName.Text = dgvBigDepartment.SelectedRows[0].Cells[2].Value.ToString();// 大部门名称
                        txtpym.Text = dgvBigDepartment.SelectedRows[0].Cells[3].Value.ToString();//拼音码
                        txtpxbm.Text = dgvBigDepartment.SelectedRows[0].Cells[4].Value.ToString();//排序编码
                        txtpxbm.Text = dgvBigDepartment.SelectedRows[0].Cells[5].Value.ToString();//备注
                        btnAdd.Text = "修改";
                        btnDel.Visible = true;
                    }
                }
            }
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
        /// 重置
        /// </summary>
        private void Reset()
        {
            id = 0;
            txtbigDepartmentID.Text = "";
            txtbigDepartmentCode.Text = "";
            txtbigDepartmentName.Text = "";
            txtpym.Text = "";
            txtpxbm.Text = "";
            txtbz.Text = "";
            btnAdd.Text = "添加";
            btnDel.Visible = false;
            txtbigDepartmentCode.Focus();
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

            DialogResult result = MessageBox.Show(this, "确认要删除此大部门吗?", "追梦办公软件", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {

               // 大部门检查并删除 zzj

                if (true)
                {
                    MessageBox.Show("大部门删除成功", "追梦办公软件", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindBigDepartment();
                    Reset();
                }
                else
                {
                    MessageBox.Show("大部门删除失败，请重试", "追梦办公软件", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            } 
        }

        /// <summary>
        /// 添加或修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbigDepartmentCode.Text))
            {
                MessageBox.Show("请输入大部门编号", "追梦办公软件", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtbigDepartmentName.Text))
            {
                MessageBox.Show("请输入大部门名称", "追梦办公软件", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtpym.Text))
            {
                MessageBox.Show("请输入拼音码", "追梦办公软件", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtpxbm.Text))
            {
                MessageBox.Show("请输入排序编码", "追梦办公软件", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
            if (id == 0)
            {
                // 添加 zzj
                if (true)
                {
                    MessageBox.Show("大部门添加成功", "追梦办公软件", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindBigDepartment();
                    Reset();
                }
                else
                {
                    MessageBox.Show("大部门添加失败", "追梦办公软件", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                // 修改 zzj
                if (true)
                {
                    MessageBox.Show("大部门修改成功", "追梦办公软件", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindBigDepartment();
                    Reset();
                }
                else
                {
                    MessageBox.Show("大部门修改失败", "追梦办公软件", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }
    }
}
