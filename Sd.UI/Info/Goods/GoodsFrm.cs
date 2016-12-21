using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Sd.BLL;
using Sd.IBLL;
using Sd.Model;
using Sd.UI.Properties;

namespace Sd.UI.Info.Goods
{
    public partial class GoodsFrm : Form
    {
        private readonly IGoodsService _goodsService;
        // 操作标识，1：增加，2：删除，3：修改
        private int _operationMode;

        public GoodsFrm()
        {
            _goodsService = new GoodsService();
            InitializeComponent();
        }

        private void GoodsFrm_Load(object sender, EventArgs e)
        {
            btnDel.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;

            FrmDataBind();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _operationMode = 1;

            btnAdd.Enabled = false;

            btnDel.Enabled = false;

            btnUpdate.Enabled = false;

            btnSearch.Enabled = false;

            btnSave.Enabled = true;

            FrmClear();

            FrmEnable(true);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSpid.Text))
            {
                MessageBox.Show(MsgResx.check_pk_null, ComValueResx.confrim);
                return;
            }

            if (MessageBox.Show(MsgResx.confrim_delete, ComValueResx.confrim, MessageBoxButtons.YesNo) !=
                DialogResult.Yes) return;

            _operationMode = 2;

            var deleteGoods = _goodsService.Find(u => u.spid.Contains(txtSpid.Text));

            if (null == deleteGoods)
            {
                MessageBox.Show(MsgResx.delete_check);
                return;
            }

            if (_goodsService.Delete(deleteGoods))
            {
                MessageBox.Show(MsgResx.delete_success, ComValueResx.confrim);

                var goodsList = _goodsService.FindList(u => true, "spid", true);

                dgvGoods.DataSource = goodsList.Select(u => new
                {
                    商品编码 = u.spid,
                    编码型号 = u.pm,
                    品牌 = u.pmlb,
                    厂家 = u.ghsmc,
                    产品系列 = u.cpxl,
                    商品分类 = u.spfllsh,
                    单位 = u.dw,
                    系数 = u.xs,
                    类型 = u.lx,
                    规格 = u.gg,
                    原价 = u.db1,
                    折扣率 = u.zkl1,
                    销售价 = u.xsj,
                    限价折扣率 = u.xjzkl1,
                    限价 = u.xj1
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

            btnAdd.Enabled = false;

            btnDel.Enabled = false;

            btnUpdate.Enabled = false;

            btnSearch.Enabled = false;

            btnSave.Enabled = true;

            FrmEnable(true);

            txtSpid.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var goodsList =  _goodsService.FindList(u => true, "spid", true);

            if (!string.IsNullOrWhiteSpace(txtSpid.Text))
            {
                goodsList = goodsList.Where(u => u.spid.Contains(txtSpid.Text.Trim()));
            }

            if (!string.IsNullOrWhiteSpace(txtPm.Text))
            {
                goodsList = goodsList.Where(u => u.spid.Contains(txtPm.Text.Trim()));
            }

            if (!string.IsNullOrWhiteSpace(combPmlb.Text))
            {
                goodsList = goodsList.Where(u => u.pmlb.Contains(combPmlb.Text.Trim()));
            }

            if (!string.IsNullOrWhiteSpace(combGhsmc.Text))
            {
                goodsList = goodsList.Where(u => u.ghsmc.Contains(combGhsmc.Text.Trim()));
            }

            dgvGoods.DataSource = goodsList.Select(u=>new
            {
                商品编码 = u.spid,
                编码型号 = u.pm,
                品牌 = u.pmlb,
                厂家 = u.ghsmc,
                产品系列 = u.cpxl,
                商品分类 = u.spfllsh,
                单位= u.dw,
                系数 = u.xs,
                类型 = u.lx,
                规格 = u.gg,
                原价 = u.db1,
                折扣率 = u.zkl1,
                销售价 = u.xsj,
                限价折扣率 = u.xjzkl1,
                限价 = u.xj1
            }).ToList();

            dgvGoods.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            // Check
            if (string.IsNullOrWhiteSpace(txtSpid.Text) || string.IsNullOrWhiteSpace(combCpxllsh.Text)
                || string.IsNullOrWhiteSpace(txtXs.Text))
            {
                MessageBox.Show(MsgResx.check_pk_null);
                return;
            }

            int iXs;

            if (!int.TryParse(txtXs.Text, out iXs))
            {
                txtXs.Focus();
                txtXs.SelectAll();
                return;
            }

            decimal dTemp;

            if (!decimal.TryParse(txtXsj.Text, out dTemp))
            {
                txtXsj.SelectAll();
                txtXsj.Focus();
                return;
            }

            if (!decimal.TryParse(txtXjzkl1.Text, out dTemp))
            {
                txtXjzkl1.SelectAll();
                txtXjzkl1.Focus();
                return;
            }

            if (!decimal.TryParse(txtXj1.Text, out dTemp))
            {
                txtXj1.SelectAll();
                txtXj1.Focus();
                return;
            }

            switch (_operationMode)
            {
                case 1:
                    // 增加
                    var addGoods = _goodsService.Find(u => u.spid.Trim().Equals(txtSpid.Text.Trim()));

                    if (null != addGoods)
                    {
                        MessageBox.Show(MsgResx.add_fail);
                        txtSpid.Focus();
                        txtSpid.SelectAll();
                        return;
                    }

                    MessageBox.Show(null == _goodsService.Add(GetSpxx()) ? MsgResx.add_fail : MsgResx.add_success);

                    break;
                    
                case 3:
                    // 修改
  
                    MessageBox.Show(_goodsService.Update(GetSpxx()) ? MsgResx.update_success : MsgResx.update_fail);

                    break;
                default:
                    return;
            }

            _operationMode = 0;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            _operationMode = 0;

            FrmClear();

            FrmEnable(true);

            btnDel.Enabled = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;

            btnAdd.Enabled = true;
            btnSearch.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvGoods_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DgvSelectChange();
        }

        private void dgvGoods_KeyUp(object sender, KeyEventArgs e)
        {
            DgvSelectChange();
        }

        private void FrmDataBind()
        {
            new Thread(delegate()
            {
                combPmlb.Invoke((MethodInvoker)delegate
                {
                    // 品牌
                    ISpPpService spPpService = new SpPpService();
                    combPmlb.DataSource = spPpService.FindList(u => true, "pmmc", true).Select(u => u.pmmc).ToList();
                    combPmlb.Text = "";

                    // 产品系列
                    ICpXlService cpXlService = new CpXlService();
                    combCpxllsh.DataSource =
                        cpXlService.FindList(u => true, "", true).Select(u => new { u.lsh, u.cpxlmc }).ToList();
                    combCpxllsh.DisplayMember = "cpxlmc";
                    combCpxllsh.SelectedIndex = 0;

                    // 商品分类
                    ISpflService sfplService = new SpflService();
                    combSpfllsh.DataSource =
                        sfplService.FindList(u => true, "lsh", true).Select(u => new { u.lsh, u.spflmc }).ToList();
                    combSpfllsh.DisplayMember = "spflmc";

                    // 计量单位
                    IJlDwbService jlDwbService = new JlDwbService();
                    combDw.DataSource = jlDwbService.FindList(u => true, "dwdm", true).Select(u => u.dw).ToList();

                    // 类型
                    ICpXlLxService cpXlLxService = new CpXlLxService();
                    combLx.DataSource = cpXlLxService.FindList(u => true, "cpxllxbm", true).Select(u => u.cpxllxmc).ToList();

                    // 厂家
                    IGhsxxService ghsxxService = new GhsxxService();
                    combGhsmc.DataSource =
                        ghsxxService.FindList(u => u.StopSign != "0", "ghsid", true).Select(u => u.ghsmc).ToList();
                    combGhsmc.Text = "";

                    // 产品规格
                    IGgxxbService ggxxbService = new GgxxbService();
                    combGg.DataSource = ggxxbService.FindList(u => true, "gg", true).Select(u => u.gg).ToList();
                });
            }){IsBackground = true}.Start();
            
        }

        /// <summary>
        /// 画面控件初期化
        /// </summary>
        private void FrmClear()
        {
            txtSpid.Text = "";
            txtPm.Text = "";
            combGhsmc.Text = "";
            combPmlb.Text = "";
            combCpxllsh.SelectedIndex = 0;
            combSpfllsh.Text = "";
            combDw.SelectedIndex = 0;
            txtXs.Text = "";
            combLx.SelectedIndex = 0;
            combGg.SelectedIndex = 0;
            txtDb1.Text = "";
            txtZkl1.Text = "";
            txtXsj.Text = "";
            txtXjzkl1.Text = "";
            txtXj1.Text = "";
        }

        /// <summary>
        /// 获取画面字段的值
        /// </summary>
        /// <returns></returns>
        private spxx GetSpxx()
        {
            return new spxx
            {
                spid = txtSpid.Text.Trim(),
                pm = txtPm.Text.Trim(),
                pmlb = combPmlb.Text,
                ghsmc = combGhsmc.Text, // 厂家
                cpxl = combCpxllsh.Text,
                spfllsh = 0, //TODO 待完善
                dw = combDw.Text,
                xs = int.Parse(txtXs.Text),
                lx = combLx.Text,
                gg = combGg.Text,
                db1 = decimal.Parse(txtDb1.Text),
                zkl1 = decimal.Parse(txtZkl1.Text),
                xsj = decimal.Parse(txtXsj.Text),
                xjzkl1 = decimal.Parse(txtXjzkl1.Text),
                xj1 = decimal.Parse(txtXj1.Text)
            };
        }

        /// <summary>
        /// Dgv换行的时，数据变换
        /// </summary>
        private void DgvSelectChange()
        {
            if (0 >= dgvGoods.SelectedRows.Count) return;

            var selectedRow = dgvGoods.SelectedRows[0];

            txtSpid.Text = selectedRow.Cells["商品编码"].Value.ToString().Trim();
            txtPm.Text = selectedRow.Cells["编码型号"].Value.ToString();
            combPmlb.Text = selectedRow.Cells["品牌"].Value.ToString();
            combGhsmc.Text = selectedRow.Cells["厂家"].Value.ToString();
            combCpxllsh.Text = selectedRow.Cells["产品系列"].Value == null ? "-" : selectedRow.Cells["产品系列"].Value.ToString();
            combSpfllsh.Text = selectedRow.Cells["商品分类"].Value.ToString();
            combDw.Text = selectedRow.Cells["单位"].Value.ToString();
            txtXs.Text = string.Format("{0:N0}", selectedRow.Cells["系数"].Value);
            combLx.Text = selectedRow.Cells["类型"].Value.ToString();
            combGg.Text = selectedRow.Cells["规格"].Value.ToString();
            txtDb1.Text = string.Format("{0:N}",selectedRow.Cells["原价"].Value);
            txtZkl1.Text = string.Format("{0:N0}", selectedRow.Cells["折扣率"].Value);
            txtXsj.Text = string.Format("{0:N}",selectedRow.Cells["销售价"].Value);
            txtXjzkl1.Text = string.Format("{0:N0}", selectedRow.Cells["限价折扣率"].Value);
            txtXj1.Text = string.Format("{0:N}", selectedRow.Cells["限价"].Value);

            if (_operationMode == 1)
            {
                txtSpid.SelectAll();
                txtSpid.Focus();
            }
            else
            {
                FrmEnable(false);
                btnDel.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        /// <summary>
        /// 设置画面空间是否可用
        /// </summary>
        /// <param name="bEnable"></param>
        private void FrmEnable(bool bEnable)
        {
            txtSpid.Enabled = bEnable;
            txtPm.Enabled = bEnable;
            combGhsmc.Enabled = bEnable;
            combPmlb.Enabled = bEnable;
            combCpxllsh.Enabled = bEnable;
            combSpfllsh.Enabled = bEnable;
            combDw.Enabled = bEnable;
            txtXs.Enabled = bEnable;
            combLx.Enabled = bEnable;
            combGg.Enabled = bEnable;
            txtDb1.Enabled = bEnable;
            txtZkl1.Enabled = bEnable;
            txtXsj.Enabled = bEnable;
            txtXjzkl1.Enabled = bEnable;
            txtXj1.Enabled = bEnable;
        }
    }
}
