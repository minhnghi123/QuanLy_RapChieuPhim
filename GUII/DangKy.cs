using GUII;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using OpenLibrary.DataAccess;
using DevExpress.XtraPivotGrid.Utils.DateHelpers;

namespace DuAn_RapChieuPhim
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        public bool CheckAccount(string ac) //check mat khau va tk
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{1,24}$");
        }
        //public bool CheckEmail(string em) // check email
        //{
        //    return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{1,20}@gmail.com(.vn|)$");
        //}

        private void lblDN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            this.Close();
            var f = new DangNhap();
            // Gắn sự kiện Closed cho Form Phim để hiển thị lại Form TrangChu khi Form Phim đóng
            f.Closed += (s, args) => this.Show();
            f.ShowDialog();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string UserName = textBox_TenTaiKhoanDK.Text;
            string PassWord = textBox_MatKhauDK.Text;
            string Email = textBox_EmailDK.Text;
            string MaLoai = textBox_MaLoai.Text;
            if (!CheckAccount(UserName)) { MessageBox.Show("tên tài khoản dài từ 1-24 ký tự!"); return; }
            if (!CheckAccount(PassWord)) { MessageBox.Show("tên mạt khẩu dài từ 1-24 ký tự!"); return; }
            //if (!CheckAccount(Email)) { MessageBox.Show("vui lòng nhập đúng định dạng email!"); return; }
            try
            {
                string query = "insert into [USER] values ('" + UserName + "','" + PassWord + "','" + Email + "','" + MaLoai + "')";
                modify.Command(query);
                if (MessageBox.Show("đăng ký thành công! bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký, vui lòng đăng ký tên tài khoản khác");
            }
        }
    }
}
