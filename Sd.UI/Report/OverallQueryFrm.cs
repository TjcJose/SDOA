using System;
using System.Windows.Forms;
using Sd.Model;
using Sd.UI.Finance;
using Sd.UI.Selling;

namespace Sd.UI.Report
{
    public partial class OverallQueryFrm : Form
    {
        private jkdsr _jkdsrInfo = new jkdsr();
        private fkdsr _fkdsrInfo = new fkdsr();
        private int _iHzlbMode; // 汇总类别

        public OverallQueryFrm()
        {
            InitializeComponent();
        }

        private void OverallQueryFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            rbZh.Checked = false;
            rbXj.Checked = false;
            rbZz.Checked = false;
            rbYs.Checked = false;

            _jkdsrInfo = null;
            _fkdsrInfo = null;

            IBLL.IReportService reportService = new BLL.ReportService();
            reportService.GetZhfkdlhb(dtpFrom.Value.Date.ToShortDateString(), dtpTo.Value.Date.ToShortDateString(), "审核2");
            reportService.GetZhjkdlhb(dtpFrom.Value.Date.ToShortDateString(), dtpTo.Value.Date.ToShortDateString(), "审核2");

            IBLL.IJkdsrService jkdsrService = new BLL.JkdsrService();
            _jkdsrInfo = jkdsrService.Find(u => u.czy.Equals("审核2"));

            IBLL.IFkdsrService fkdsrService = new BLL.FkdsrService();
            _fkdsrInfo = fkdsrService.Find(u => u.czy.Equals("审核2"));

            rbZh.Checked = true;
        }

        private void rbZh_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbZh.Checked) return;

            if (_jkdsrInfo == null || _fkdsrInfo == null)
            {
                _jkdsrInfo = null;
                _fkdsrInfo = null;
            }
            else
            {
                txtZsr.Text = _jkdsrInfo.hj1_fss == null ? "0": _jkdsrInfo.hj1_fss.Value.ToString("F");
                txtXssr.Text = _jkdsrInfo.xshj == null ? "0" : _jkdsrInfo.xshj.Value.ToString("F");
                txtDjsr.Text = _jkdsrInfo.yshj == null ? "0" : _jkdsrInfo.yshj.Value.ToString("F");
                txtHksr.Text = _jkdsrInfo.qkhj == null ? "0" : _jkdsrInfo.qkhj.Value.ToString("F");
                txtQtsr.Text = _jkdsrInfo.qthj == null ? "0" : _jkdsrInfo.qthj.Value.ToString("F");

                txtZzc.Text = _fkdsrInfo.hj1_fss==null? "0":_fkdsrInfo.hj1_fss.Value.ToString("F");
                txtFghk.Text = _fkdsrInfo.hkhj_sjs == null ? "0" : _fkdsrInfo.hkhj_sjs.Value.ToString("F");
                txtZtyf.Text = _fkdsrInfo.yfhj_sjs == null ? "0" : _fkdsrInfo.yfhj_sjs.Value.ToString("F"); 
                txtQtfy.Text = _fkdsrInfo.kzhj_sjs == null ? "0" : _fkdsrInfo.kzhj_sjs.Value.ToString("F");
                txtGzzf.Text = _fkdsrInfo.gzhj_sjs == null ? "0" : _fkdsrInfo.gzhj_sjs.Value.ToString("F");
                txtSyzf.Text = _fkdsrInfo.ycl_hjs == null ? "0" : _fkdsrInfo.ycl_hjs.Value.ToString("F");

                if (_jkdsrInfo.hj1_fss == null || _fkdsrInfo.hj1_fss == null)
                {
                    txtZyye.Text = "";
                }
                else
                {
                    txtZyye.Text = (_jkdsrInfo.hj1_fss.Value - _fkdsrInfo.hj1_fss.Value).ToString("F");
                }
                _iHzlbMode = 1;
            }
        }

        private void rbXj_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbXj.Checked) return;

            if (_jkdsrInfo == null || _fkdsrInfo == null)
            {
                _jkdsrInfo = null;
                _fkdsrInfo = null;
            }
            else
            {
                txtZsr.Text = _jkdsrInfo.shxj_fss == null ? "0" : _jkdsrInfo.shxj_fss.Value.ToString("F");
                txtXssr.Text = _jkdsrInfo.xsxj == null ? "0" : _jkdsrInfo.xsxj.Value.ToString("F");
                txtDjsr.Text = _jkdsrInfo.ysxj == null ? "0" : _jkdsrInfo.ysxj.Value.ToString("F");
                txtHksr.Text = _jkdsrInfo.qkxj == null ? "0" : _jkdsrInfo.qkxj.Value.ToString("F");
                txtQtsr.Text = _jkdsrInfo.qtxj == null ? "0" : _jkdsrInfo.qtxj.Value.ToString("F");

                txtZzc.Text = _fkdsrInfo.shxj_fss == null ? "0" : _fkdsrInfo.shxj_fss.Value.ToString("F");
                txtFghk.Text = _fkdsrInfo.hkxj_fss == null ? "0" : _fkdsrInfo.hkxj_fss.Value.ToString("F");
                txtZtyf.Text = _fkdsrInfo.yfxj_fss == null ? "0" : _fkdsrInfo.yfxj_fss.Value.ToString("F");
                txtQtfy.Text = _fkdsrInfo.qtxj_fss == null ? "0" : _fkdsrInfo.qtxj_fss.Value.ToString("F");
                txtGzzf.Text = _fkdsrInfo.gzxj_fss == null ? "0" : _fkdsrInfo.gzxj_fss.Value.ToString("F");
                txtSyzf.Text = _fkdsrInfo.ycl_hjs1 == null ? "0" : _fkdsrInfo.ycl_hjs1.Value.ToString("F");

                if (_jkdsrInfo.shxj_fss == null || _fkdsrInfo.shxj_fss == null)
                {
                    txtZyye.Text = "";
                }
                else
                {
                    txtZyye.Text = (_jkdsrInfo.shxj_fss.Value - _fkdsrInfo.shxj_fss.Value).ToString("F");
                }

                _iHzlbMode = 2;
            }
        }

        private void rbZz_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbZz.Checked) return;

            if (_jkdsrInfo == null || _fkdsrInfo == null)
            {
                _jkdsrInfo = null;
                _fkdsrInfo = null;
            }
            else
            {
                txtZsr.Text = _jkdsrInfo.zzsr_fss == null ? "0" : _jkdsrInfo.zzsr_fss.Value.ToString("F");
                txtXssr.Text = _jkdsrInfo.xszz == null ? "0" : _jkdsrInfo.xszz.Value.ToString("F");
                txtDjsr.Text = _jkdsrInfo.yszz == null ? "0" : _jkdsrInfo.yszz.Value.ToString("F");
                txtHksr.Text = _jkdsrInfo.qkzz == null ? "0" : _jkdsrInfo.qkzz.Value.ToString("F");
                txtQtsr.Text = _jkdsrInfo.qtzz == null ? "0" : _jkdsrInfo.qtzz.Value.ToString("F");

                txtZzc.Text = _fkdsrInfo.zzsr_fss == null ? "0" : _fkdsrInfo.zzsr_fss.Value.ToString("F");
                txtFghk.Text = _fkdsrInfo.hkzz_fss == null ? "0" : _fkdsrInfo.hkzz_fss.Value.ToString("F");
                txtZtyf.Text = _fkdsrInfo.yfzz_fss == null ? "0" : _fkdsrInfo.yfzz_fss.Value.ToString("F");
                txtQtfy.Text = _fkdsrInfo.qtzz_fss == null ? "0" : _fkdsrInfo.qtzz_fss.Value.ToString("F");
                txtGzzf.Text = _fkdsrInfo.gzzz_fss == null ? "0" : _fkdsrInfo.gzzz_fss.Value.ToString("F");
                txtSyzf.Text = _fkdsrInfo.ycl_sjs == null ? "0" : _fkdsrInfo.ycl_sjs.Value.ToString("F");

                if (_jkdsrInfo.zzsr_fss == null || _fkdsrInfo.zzsr_fss == null)
                {
                    txtZyye.Text = "";
                }
                else
                {
                    txtZyye.Text = (_jkdsrInfo.zzsr_fss.Value - _fkdsrInfo.zzsr_fss.Value).ToString("F");
                }

                _iHzlbMode = 3;
            }
        }

        private void rbYs_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbYs.Checked) return;

            if (_jkdsrInfo == null || _fkdsrInfo == null)
            {
                _jkdsrInfo = null;
                _fkdsrInfo = null;
            }
            else
            {
                txtZsr.Text = _jkdsrInfo.yszk_fss == null ? "0" : _jkdsrInfo.yszk_fss.Value.ToString("F");
                txtXssr.Text = _jkdsrInfo.xsqk == null ? "0" : _jkdsrInfo.xsqk.Value.ToString("F");
                txtDjsr.Text = _jkdsrInfo.ysys == null ? "0" : _jkdsrInfo.ysys.Value.ToString("F");
                txtHksr.Text = "";
                txtQtsr.Text = "";

                txtZzc.Text = "";
                txtFghk.Text = "";
                txtZtyf.Text = "";
                txtQtfy.Text = "";
                txtGzzf.Text = "";
                txtSyzf.Text = "";

                txtZyye.Text = "";

                _iHzlbMode = 4;
            }
        }

        private void btnXssr_Click(object sender, EventArgs e)
        {
            var sellingSearchFrm = new SellingSearchFrm(dtpFrom.Value, dtpTo.Value, _iHzlbMode);
            sellingSearchFrm.ShowDialog();
        }

        private void btnDjsr_Click(object sender, EventArgs e)
        {
            var frm = new SellingIndentSearchFrm(dtpFrom.Value, dtpTo.Value, _iHzlbMode);
            frm.ShowDialog();
        }

        private void btnHksr_Click(object sender, EventArgs e)
        {
            if (4 == _iHzlbMode)
            {
                return;
            }

            var frm = new RepaySearchFrm(dtpFrom.Value, dtpTo.Value, _iHzlbMode);
            frm.ShowDialog();
        }

        private void btnQtsr_Click(object sender, EventArgs e)
        {
            if (4 == _iHzlbMode)
            {
                return;
            }

            var frm = new InComeSearchFrm(dtpFrom.Value, dtpTo.Value, _iHzlbMode);
            frm.ShowDialog();
        }

        private void btnFghk_Click(object sender, EventArgs e)
        {
            if (4 == _iHzlbMode)
            {
                return;
            }

            var frm = new PaymentSearchFrm(dtpFrom.Value, dtpTo.Value, _iHzlbMode);
            frm.ShowDialog();
        }

        private void btnZtyf_Click(object sender, EventArgs e)
        {
            if (4 == _iHzlbMode)
            {
                return;
            }

            var frm = new FreightSearchFrm(dtpFrom.Value, dtpTo.Value, _iHzlbMode);
            frm.ShowDialog();
        }

        private void btnQtfy_Click(object sender, EventArgs e)
        {
            if (4 == _iHzlbMode)
            {
                return;
            }

            var frm = new CostSearchfrm(dtpFrom.Value, dtpTo.Value, _iHzlbMode);
            frm.ShowDialog();
        }
    }
}
