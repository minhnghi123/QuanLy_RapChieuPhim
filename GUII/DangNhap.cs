using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using DuAn_RapChieuPhim;
namespace GUII
{
    public partial class DangNhap : Form
    {
        QL_TAIKHOAN TaiKhoan  = new QL_TAIKHOAN();
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoan.TaiKhoan = txtTaiKhoan.Text;
            TaiKhoan.MatKhau = txtMatKhau.Text;
            string getUser = TaiKhoanBLL.CheckLogin(TaiKhoan);
            switch(getUser)
            {
                case "Yeu Cau Nhap Tai Khoan":
                    MessageBox.Show("Yeu Cau Nhap Tai Khoan");
                    return; 
                case "Yeu Cau Nhap Mat Khau":
                    MessageBox.Show("Yeu Cau Nhap Mat Khau");
                    return;
                case "Tai Khoan Hoac Mat Khau Khong Chinh Xac":
                    MessageBox.Show("Tai Khoan Hoac Mat Khau Khong Chinh Xac");
                    return; 
            }
            MessageBox.Show("DANG NHAP THANH CONG");
            this.Hide();
            var f = new TrangChu();
            f.Show();

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }
    }
}
