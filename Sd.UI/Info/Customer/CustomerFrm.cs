using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sd.BLL;
using Sd.IBLL;

namespace Sd.UI.Info.Customer
{
    public partial class CustomerFrm : Form
    {
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
            ICustomerService customerService = new CustomerService();
            var customer = customerService.FindList(u => true, "khid", true);
            combJskhmc.DataSource = customer.Select(u => new { khid = u.khid, khmc = u.khmc }).ToList();
            combJskhmc.DisplayMember = "khmc";
            combJskhmc.Text = "";

            #endregion

            // 客户信息
            dgvKh.DataSource = customer.ToList();
        }
    }
}
