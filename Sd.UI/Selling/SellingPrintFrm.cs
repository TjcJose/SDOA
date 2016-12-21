using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Sd.Model.Rdlc;

namespace Sd.UI.Selling
{
    public partial class SellingPrintFrm : Form
    {
        public SellingPrintFrm()
        {
            InitializeComponent();
        }

        public SellingPrintFrm(IEnumerable<SellingDetail> pList)
        {
            InitializeComponent();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("SellingDetailDs", pList));
            
        }

        private void SellingPrintFrm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
