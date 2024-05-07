using BLL;
using DevExpress.XtraBars.Controls;
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
    public partial class frmDatVeXemPhim : Form
    {
        ctrDatVePhim ctr = new ctrDatVePhim();
        DataTable phimdanchieu;
        private List<UserControlPhim> customControls = new List<UserControlPhim>();
        public frmDatVeXemPhim()
        {
            InitializeComponent();
            phimdanchieu = ctr.getPhimDanchieu();
        }

        private void frmDatVeXemPhim_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 3; i++)
            //{
                
            //    item.SetText($"{i + 1:00}");
            //    customControls.Add(item);
            //    flowLayoutPanel1.Controls.Add(item);
            //}
            foreach (DataRow dtRow in phimdanchieu.Rows)
            {
                var item = new UserControlPhim();
                item.setText(dtRow["TenPhim"].ToString());

                item.setGiaVe(dtRow["GiaVe"].ToString());
                item.setDatarow(dtRow);
                if (dtRow["Hinanh"] != DBNull.Value)
                {
                    byte[] bytes = (byte[])dtRow["Hinanh"];
                    Image img = Utility_img.ByteArrayToImage(bytes); ;
                    item.setPicture(img);
                }
                var tam123 = (DateTime)dtRow["ThoiGianChieu"];
                String hourMinute = tam123.ToString("HH:mm");
                item.setNam(hourMinute + " " + dtRow["MaSuatChieu"].ToString());
                customControls.Add(item);
                flowLayoutPanel1.Controls.Add(item);

            }

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight; // Hiển thị từ trái phải
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.Padding = new Padding(10); // Khoảng cách giữa các custom control
            flowLayoutPanel1.AutoSize = false;

         
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = new sanpham();
            s.Show();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable tam = ctr.getPhiMDangChieuseachr(txt_search.Text);
            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow dtRow in tam.Rows)
            {
                var item = new UserControlPhim();
                item.setText(dtRow["TenPhim"].ToString());

                item.setGiaVe(dtRow["GiaVe"].ToString());
                item.setDatarow(dtRow);
                if (dtRow["Hinanh"] != DBNull.Value)
                {
                    byte[] bytes = (byte[])dtRow["Hinanh"];
                    Image img = Utility_img.ByteArrayToImage(bytes); ;
                    item.setPicture(img);
                }
                var tam123 = (DateTime)dtRow["ThoiGianChieu"];
                String hourMinute = tam123.ToString("HH:mm");
                item.setNam(hourMinute + " " + dtRow["MaSuatChieu"].ToString());
                customControls.Add(item);
                flowLayoutPanel1.Controls.Add(item);

            }

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight; // Hiển thị từ trái phải
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.Padding = new Padding(10); // Khoảng cách giữa các custom control
            flowLayoutPanel1.AutoSize = false;
        }
    }
}
