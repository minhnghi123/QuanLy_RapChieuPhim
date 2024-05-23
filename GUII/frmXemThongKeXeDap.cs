using BLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUII
{
    public partial class frmXemThongKeXeDap : Form
    {
        ctrXemThongKeXeDap ctr = new ctrXemThongKeXeDap();
        DataTable dt;
        public frmXemThongKeXeDap()
        {
            InitializeComponent();
        }

        private void frmXemThongKeXeDap_Load(object sender, EventArgs e)
        {
         //   this.reportViewer1.

            this.reportViewer1.RefreshReport();
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        { dt  = ctr.layThongKeXeDap();
            var s = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            var reportDataSource1 = new ReportDataSource("DataSet1", dt);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUII.Report1.rdlc";
            this.reportViewer1.RefreshReport();

                      

        }
    }
}
