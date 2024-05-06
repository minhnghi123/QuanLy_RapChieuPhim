using QuanLySieuThi;
using QuanLySieuThi.quanly;
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
    public partial class NhapTenFilecs : Form
    {
        public NhapTenFilecs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string duongdan = "";
            String tenfile = "";
            tenfile = txt_tenFile.Text;
            sanpham  sanpham = new sanpham();   
            XuatExecl.export_phieu(sanpham.dta1, duongdan, tenfile);
            MessageBox.Show("Xuất file thành công ", "Thông báo ", MessageBoxButtons.OK);
            this.Close();   
        }

        private void txt_tenFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void NhapTenFilecs_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
