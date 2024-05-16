
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using GUII;
using QuanLySieuThi.quanly;

namespace DuAn_RapChieuPhim
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        public TrangChu(string isname)
        {
            InitializeComponent();
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            
        }
        private Form currentFormChild;
        private void OpenChildForm(Form chilForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(chilForm);
            panel_body.Tag = chilForm;
            chilForm.BringToFront();
            chilForm.Show();
        }
        private void btnQLPhim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new sanpham());
            label1.Text = btnQLPhim.Text;
        }
        private void btnRap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Rap());
            label1.Text = btnRap.Text;
        }
        private void btnQLSC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLSuatChieu());
            label1.Text = btnQLSC.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void btnDX_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap f = new DangNhap();
            f.Show();
        }
    }
}
