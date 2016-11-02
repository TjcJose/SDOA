using System;
using System.Windows.Forms;
using Sd.BLL;
using Sd.IBLL;
using Sd.UI.Properties;

namespace Sd.UI
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            IGsxxService gsxxService = new GsxxService();
            var gsxx =  gsxxService.Find(u => true);
            if (null != gsxx)
            {
                Text = gsxx.gsmc.Trim();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == string.Empty || txtPwd.Text == string.Empty)
            {
                lblMsg.Text = MsgResx.login_txt_user_pwd;
                txtUser.Focus();
                return;
            }

            IUserService userService = new UserService();

            lblMsg.Text =MsgResx.login_btn_logining;
            Refresh();

            /*if (userService.Exist(u => u.gh.Equals(txtUser.Text) && u.pwd.Equals(txtPwd.Text)))
            {
                Hide();
                var user = userService.Find(u => u.gh.Equals(txtUser.Text) && u.pwd.Equals(txtPwd.Text));
                var mainFrm = new MainFrm
                {
                    Text = Text,
                    tsslCzy = {Text = user.czy}
                };
                mainFrm.Show();
            }
            else
            {
                lblMsg.Text = MsgResx.login_error_001;
                txtUser.Focus();
                txtPwd.SelectAll();
            }*/
        }

        private void txtUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (txtUser.Text == string.Empty)
                {
                    lblMsg.Text = MsgResx.login_txt_user;
                    txtUser.Focus();
                    return;
                }
                txtPwd.Focus();
            }
        }

        private void txtPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (txtPwd.Text == string.Empty)
                {
                    lblMsg.Text = MsgResx.login_txt_pwd;
                    txtPwd.Focus();
                    return;
                }
                btnLogin.Focus();
            }
        }
    }
}
