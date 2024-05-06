using DuAn_RapChieuPhim;
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
    public partial class frmChiTietPhimDatVe : Form
    {
        public static DataRow dr;
        public frmChiTietPhimDatVe()
        {
            InitializeComponent();
        }

        private void frmChiTietPhimDatVe_Load(object sender, EventArgs e)
        {
            txtMaphim.Text = dr["MaPhim"].ToString();
            txtTenphim.Text = dr["TenPhim"].ToString();
            txtDaoDien.Text = dr["DaoDien"].ToString();
            txtDienVien.Text = dr["DienVien"].ToString();
            richTextBox1.Text = dr["MoTa"].ToString();
            textBox5.Text = dr["ThoiLuong"].ToString();
            comboBox1.SelectedText = dr["TheLoai"].ToString();

            txtMaphim.ReadOnly = true;
            txtTenphim.ReadOnly = true;
            txtDaoDien.ReadOnly = true;
            txtDienVien.ReadOnly = true;
            richTextBox1.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox1.Text = dr["GiaVe"].ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var f = new HoaDon();
            f.Show();
        }
    }
}
