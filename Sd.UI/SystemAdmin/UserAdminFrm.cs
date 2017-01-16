using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sd.UI.Properties;
using Sd.BLL;
using Sd.IBLL;
using Sd.Model;

namespace Sd.UI.SystemAdmin
{
    public partial class UserAdminFrm : Form
    {
        private int _operationMode;
        private readonly IUserService _userService = new UserService();

        public UserAdminFrm()
        {
            InitializeComponent();
        }

        private void UserAdminFrm_Load(object sender, EventArgs e)
        {
            combUserId.DataSource = _userService.FindList(u => true, "gh", true).Select(u => new { u.gh, u.czy}).ToList();//提取数据
            combUserId.DisplayMember = "gh";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            _operationMode = 1;
            btnAdd.Enabled = false;//false表示不可用
            btnDel.Enabled = true;
            btnPwdReset.Enabled = false;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnExit.Enabled = true;
            ResetFrm();
          
        }
        /// <summary>
        /// 画面重置
        /// </summary>
        private void ResetFrm()
        {
            combUserId.Text = "";
            txtUserName.Text = "";
           
            txtNewPwd.Text = "";
            txtUserName.Focus();
        }

        /// <summary>
        /// 取得password
        /// </summary>
        /// <returns></returns>
        private password Getpassword()
        {
            return new password
            {
                czy = txtUserName.Text.Trim(),
                gh = combUserId.Text.Trim(),
                jmpw = "000000"
                
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 必填项Chk
            if (string.IsNullOrWhiteSpace(combUserId.Text) ||
                string.IsNullOrWhiteSpace(txtUserName.Text) )
                
            {
                MessageBox.Show(MsgResx.check_pk_null, ComValueResx.confrim,
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return;
            }

            if (1 == _operationMode)
            {
                //添加该用户
                var addResult = _userService.Add(
                    new password
                    {
                        // 添加 zzj
                        czy = txtUserName.Text.Trim(),
                        gh = combUserId.Text.Trim(),
                        jmpw = "000000"
                    });

                if (null != addResult)
                {
                    MessageBox.Show(MsgResx.add_success, ComValueResx.confrim, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //绑定数据库
                    ResetFrm();
                    combUserId.DataSource = _userService.FindList(u => true, "gh", true).Select(u => new { u.gh, u.czy }).ToList();//提取数据
                    combUserId.DisplayMember = "gh";
                    btnAdd.Enabled = true;//false表示不可用
                    btnDel.Enabled = true;
                    btnPwdReset.Enabled = true;
                    btnSave.Enabled = true;
                    btnClear.Enabled = true;
                    btnExit.Enabled = true;
                }
                else
                {
                    MessageBox.Show(MsgResx.user_add_chk, ComValueResx.confrim, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    btnAdd.Enabled = true;//false表示不可用
                    btnDel.Enabled = true;
                    btnPwdReset.Enabled = true;
                    btnSave.Enabled = true;
                    btnClear.Enabled = true;
                    btnExit.Enabled = true;
                }
            }
            else if (3 == _operationMode)
            {
                if( _userService.Update(Getpassword()))
                {
                    ResetFrm();
                    MessageBox.Show(MsgResx.update_success, ComValueResx.confrim, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    combUserId.DataSource = _userService.FindList(u => true, "gh", true).Select(u => new { u.gh, u.czy }).ToList();//提取数据
                    combUserId.DisplayMember = "gh";
                    btnAdd.Enabled = true;//false表示不可用
                    btnDel.Enabled = true;
                    btnPwdReset.Enabled = true;
                    btnSave.Enabled = true;
                    btnClear.Enabled = true;
                    btnExit.Enabled = true;
                }
                else
                {
                    MessageBox.Show(MsgResx.update_fail, ComValueResx.confrim, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    btnAdd.Enabled = true;//false表示不可用
                    btnDel.Enabled = true;
                    btnPwdReset.Enabled = true;
                    btnSave.Enabled = true;
                    btnClear.Enabled = true;
                    btnExit.Enabled = true;
                }
            }
        }

        private void combUserId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (0 < combUserId.Items.Count && null != combUserId.SelectedItem)
            {
                _operationMode = 3; // 选中数据， 可进行修改

                txtUserName.Text = combUserId.SelectedItem.GetType()
                .GetProperty("czy")
                .GetValue(combUserId.SelectedItem, null).ToString().Trim();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetFrm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (3 == _operationMode)
            {
                var result = MessageBox.Show(this, MsgResx.confrim_delete, ComValueResx.confrim, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK) return;
            }
            
            if ( _userService.Delete(Getpassword()))
            {
                MessageBox.Show(MsgResx.delete_success, ComValueResx.confrim, MessageBoxButtons.OK, MessageBoxIcon.Information);
                              ResetFrm();
                              combUserId.DataSource = _userService.FindList(u => true, "gh", true).Select(u => new { u.gh, u.czy }).ToList();//提取数据
                              combUserId.DisplayMember = "gh";
            }
            else
            {
                MessageBox.Show(MsgResx.delete_fail, ComValueResx.confrim, MessageBoxButtons.OK, MessageBoxIcon.Information);
                combUserId.DataSource = _userService.FindList(u => true, "gh", true).Select(u => new { u.gh, u.czy }).ToList();//提取数据
                combUserId.DisplayMember = "gh";
            }
        }

        private void combUserId_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(combUserId.Text))
            {
                txtUserName.Text = "";
            }
        }
        private void mimaReset()
        {
            txtOldPwd.Text="000000";
        }

        private void btnPwdReset_Click(object sender, EventArgs e)
        {
              
            _operationMode = 4;
            btnAdd.Enabled = true;//false表示不可用
            btnDel.Enabled = true;
            btnPwdReset.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnExit.Enabled = true;
            mimaReset();
            if(txtOldPwd.Text=="000000")
            {
                MessageBox.Show(MsgResx.reset_success, ComValueResx.confrim, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetFrm();
                combUserId.DataSource = _userService.FindList(u => true, "gh", true).Select(u => new { u.gh, u.czy }).ToList();//提取数据
                combUserId.DisplayMember = "gh";
              }

           
           
        }
        }
    }
