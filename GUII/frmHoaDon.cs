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
    public partial class frmHoaDon : Form
    {
        ctrHoaDon ctr = new ctrHoaDon();
        public DataTable dt;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QL_RapChieuPhimDataSet.Ve' table. You can move, or remove it, as needed.
            this.VeTableAdapter.Fill(this.QL_RapChieuPhimDataSet.Ve);

            this.reportViewer1.RefreshReport();

         
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            var s = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            var reportDataSource1 = new ReportDataSource("DataSet1", dt);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUII.HoaDon.rdlc";
            this.reportViewer1.RefreshReport();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctr.capnhathoadon(dt);
       //     Message
            this.Close();
        }
    }
}
