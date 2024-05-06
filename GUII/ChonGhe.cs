using GUII;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DuAn_RapChieuPhim
{
    public partial class ChonGhe : Form
    {
        BLL.ChonGhe ctr = new BLL.ChonGhe();
        public static DataRow dr;
        private int clickLightCoral = 0;
        private int clickDeepPink = 0;
        private int clickPlum = 0;
        int mave = 0;
        DataRow dr2;
        DataTable dt;
        public ChonGhe()
        {
            InitializeComponent();

        }
       
        private void btnTieptuc_Click(object sender, EventArgs e)
        {

            
             


            
           
            var f = new frmHoaDon();
            f.dt = dt;
            f.Show();
            
              

            
            
            //var f = new HoaDon();
            //// Gắn sự kiện Closed cho Form Phim để hiển thị lại Form TrangChu khi Form Phim đóng
            //f.Closed += (s, args) => this.Show();
            //f.ShowDialog();
        }

        private void btnLightCoral(object sender, EventArgs e)
        {
            
            Button clickedButton = sender as Button;
            if (clickLightCoral % 2 == 0)
            {
                dr2["MaVe"] = mave++;
                DataRow s = dr2;
                s["MaGheNgoi"] = clickedButton.Text;
                var s123 = clickedButton.Text;
                dt.Rows.Add(s.ItemArray);
                // Chuyển màu lần click thứ nhất
                clickedButton.BackColor = Color.Red;
            }
            else
            {
                
                // Chuyển lại màu cũ khi click lần thứ hai
                clickedButton.BackColor = Color.LightCoral; // Màu mặc định của nền Form
            }
            if(clickedButton.BackColor!= Color.Red)
            {
                DataRow[] drr = dt.Select("MaGheNgoi='" + clickedButton.Text + "'");
                for (int i = 0; i < drr.Length; i++)
                    drr[i].Delete();
                dt.AcceptChanges();
            }    
            clickLightCoral++;
        }

        private void btnDeepPink(object sender, EventArgs e)
            
        {
            Button clickedButton = sender as Button;
            if (clickDeepPink % 2 == 0)
            {
                dr2["MaVe"] = mave++;
                DataRow s = dr2;
                s["MaGheNgoi"] = clickedButton.Text;
                var s123 = clickedButton.Text;
                dt.Rows.Add(s.ItemArray);
                // Chuyển màu lần click thứ nhất
                clickedButton.BackColor = Color.Red;
            }
            else
            {
               
                // Chuyển lại màu cũ khi click lần thứ hai
                clickedButton.BackColor = Color.DeepPink; // Màu mặc định của nền Form
            }
            clickDeepPink++;

            if (clickedButton.BackColor != Color.Red)
            {
                DataRow[] drr = dt.Select("MaGheNgoi='" + clickedButton.Text + "'");
                for (int i = 0; i < drr.Length; i++)
                    drr[i].Delete();
                dt.AcceptChanges();
            }
        }

        private void btnPlum(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickPlum % 2 == 0)
            {
                dr2["MaVe"] = mave++;
                DataRow s = dr2;
                s["MaGheNgoi"] = clickedButton.Text;
                var s123 = clickedButton.Text;
                dt.Rows.Add(s.ItemArray);
                // Chuyển màu lần click thứ nhất
                clickedButton.BackColor = Color.Red;
            }
            else
            {
                
                // Chuyển lại màu cũ khi click lần thứ hai
                clickedButton.BackColor = Color.Plum; // Màu mặc định của nền Form
            }
            clickPlum++;
            if (clickedButton.BackColor != Color.Red)
            {
                DataRow[] drr = dt.Select("MaGheNgoi='" + clickedButton.Text + "'");
                for (int i = 0; i < drr.Length; i++)
                    drr[i].Delete();
                dt.AcceptChanges();
            }
        }

        private void ChonGhe_Load(object sender, EventArgs e)
        { dr2 = ctr.getve().NewRow();
            mave = ctr.getve().Rows.Count;
            
            dr2["MaVe"] = mave++;
           
            dr2["MaSuatChieu"] = dr["MaSuatChieu"];
            dr2["GiaVe"] = dr["GiaVe"];
            dr2["MaSuatChieu"] = dr["MaSuatChieu"];
            dr2["PhuongThucThanhToan"] = "Tiền mặt";
            dr2["NgayDat"] = DateTime.Now;
            dt = ctr.getve().Clone();
            
        }
    }
}
