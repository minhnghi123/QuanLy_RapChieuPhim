using DevExpress.Utils.About;
using GUII;
using openLibrary.Presatation;
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
namespace QuanLySieuThi.quanly
{
    public partial class sanpham : Form
    {
        public string chuoi = "Select * from Phim";

        public sanpham()
        {
            InitializeComponent();
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();

        }

        public void clear()
        {



            dta1.Columns[0].HeaderText = "Mã Phim"; dta1.Columns[0].Width = 110;
            dta1.Columns[1].HeaderText = "Tên Phim"; dta1.Columns[1].Width = 150;
            dta1.Columns[2].HeaderText = "Dao Dien"; dta1.Columns[2].Width = 110;
            dta1.Columns[3].HeaderText = "Dien Vien"; dta1.Columns[3].Width = 110;
            dta1.Columns[4].HeaderText = " The Loai"; dta1.Columns[4].Width = 110;
            dta1.Columns[5].HeaderText = "Thoi Luong"; dta1.Columns[5].Width = 110;
            txt_masp.Focus();
            txt_masp.Text = "";
            txt_tensp.Text = "";
            txt_gianhap.Text = "";
            txt_giaban.Text = "";
            txt_solg.Text = "";
            txt_nsx.Text = "";
            pHinhand.Image = null;  
            int sc = dta1.Rows.Count;
            double thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
            {
                thanhtien++;
            }

        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string load1 = "Select * from Phim where TenPhim like N'%" + txt_search.Text + "%' ";
            chuoiketnoi.timkiem(load1, dta1);
            clear();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }


        private void sanpham_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dta1_Click(object sender, EventArgs e)
        {
            int curow = dta1.CurrentRow.Index;
            txt_masp.Text = dta1.Rows[curow].Cells[0].Value.ToString();
            txt_tensp.Text = dta1.Rows[curow].Cells[1].Value.ToString();
            txt_gianhap.Text = dta1.Rows[curow].Cells[2].Value.ToString();
            txt_giaban.Text = dta1.Rows[curow].Cells[3].Value.ToString();
            txt_solg.Text = dta1.Rows[curow].Cells[4].Value.ToString();
            txt_nsx.Text = dta1.Rows[curow].Cells[5].Value.ToString();
            if (dta1.Rows[curow].Cells[7].Value != DBNull.Value)
            {
                Byte[] tam = (Byte[])dta1.Rows[curow].Cells[7].Value;
                pHinhand.Image = Utility_img.ByteArrayToImage(tam);
            }
            else pHinhand.Image = null;
            txt_masp.Enabled = false;
            btn_them.Enabled = false;
            bnt_sua.Enabled = true;
            btn_xoa.Enabled = true;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (
            txt_tensp.Text == "" ||

            txt_gianhap.Text == "" ||
            txt_giaban.Text == "" ||
            txt_solg.Text == "" ||

            txt_nsx.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                //    Byte[] tam = Utility_img.ImageToByteArray(pictureBox1.Image); ;
                if(pHinhand.Image==null)
                {
                    byte[] tam = Utility_img.ImageToByteArray(pHinhand.Image);

                    string txt_mota = "Null nhe";
                    string sql1 = "Insert into Phim values(N'" + txt_tensp.Text + "',N'" + txt_gianhap.Text + "','" + txt_giaban.Text + "','" + txt_solg.Text + "'," + txt_nsx.Text + ",N' " + txt_mota + "',null)";
                    chuoiketnoi.them_dl(sql1, dta1);
                    chuoiketnoi.Chuoiketnoi(chuoi, dta1);
                    clear();
                }
                else
                {
                    byte[] tam = Utility_img.ImageToByteArray(pHinhand.Image);

                    string txt_mota = "Null nhe";
                    string sql1 = "Insert into Phim values(N'" + txt_tensp.Text + "',N'" + txt_gianhap.Text + "','" + txt_giaban.Text + "','" + txt_solg.Text + "'," + txt_nsx.Text + ",N' " + txt_mota + "',@BinaryData)";
                    chuoiketnoi.them_dlbinary(sql1, dta1, tam);
                    chuoiketnoi.Chuoiketnoi(chuoi, dta1);
                    clear();

                }
                
            }
        }

        private void bnt_sua_Click(object sender, EventArgs e)
        {
         
            if (pHinhand.Image !=null)
            {
                byte[] tam = Utility_img.ImageToByteArray(pHinhand.Image);
                string sql123 = "Update Phim set Hinanh = @BinaryData ,TenPhim = N'" + txt_tensp.Text + "',DaoDien = '" + txt_gianhap.Text + "',DienVien = '" + txt_giaban.Text + "',TheLoai = '" + txt_solg.Text + "',ThoiLuong = N'" + txt_nsx.Text + "' where MaPhim='" + txt_masp.Text + "'";
                chuoiketnoi.Execute1binary(sql123,tam);
                chuoiketnoi.Chuoiketnoi(chuoi, dta1);
                clear();
            }    
            else
            {   
            string sql = "Update Phim set TenPhim = N'" + txt_tensp.Text +  "',DaoDien = '" + txt_gianhap.Text + "',DienVien = '" + txt_giaban.Text + "',TheLoai = '" + txt_solg.Text +  "',ThoiLuong = N'" + txt_nsx.Text  + "' where MaPhim='" + txt_masp.Text + "'";
            chuoiketnoi.Execute1(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from Phim where maPhim= '" + txt_masp.Text + "'";
             chuoiketnoi.Execute(sql);
            chuoiketnoi.Chuoiketnoi(chuoi, dta1);
            clear();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            try
            {


              //  string duongdan = "";
               // String tenfile = "";
                NhapTenFilecs nhapTenFilecs = new NhapTenFilecs();
                nhapTenFilecs.Show();
                //tenfile = nhapTenFilecs.txt_tenFile.Text; 
              //  XuatExecl.export_phieu(dta1, duongdan, tenfile);
               // MessageBox.Show("Xuất file thành công ", "Thông báo ", MessageBoxButtons.OK);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            btn_them.Enabled = true;
            clear();

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        /*( private void txt_gianhap_KeyPress(object sender, KeyPressEventArgs e)
         {

             if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                 e.Handled = true;
         }

         private void txt_giaban_KeyPress(object sender, KeyPressEventArgs e)
         {

             if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                 e.Handled = true;
         }

         private void txt_solg_KeyPress(object sender, KeyPressEventArgs e)
         {

             if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                 e.Handled = true;
         }*/

        private void txt_gianhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MotaPhin motaPhin = new MotaPhin();
            motaPhin.Show();
            
            int curow = dta1.CurrentRow.Index;
            motaPhin.lb_tenphim.Text = dta1.Rows[curow].Cells[1].Value.ToString();
            motaPhin.txt_mota.Text = dta1.Rows[curow].Cells[6].Value.ToString();
            //string layPhimm =  "Select * from SuatChieu Where MaPhim='"+ txt_masp.Text + "'";
            //chuoiketnoi.Chuoiketnoi(layPhimm, motaPhin.dgvThongTinChiTiet); 

        }

        private void dta1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dta1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string srcimg = "";
        private void pHinhand_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {

                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.jdg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif)";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pHinhand.Image = new Bitmap(dlg.FileName);
                    srcimg = dlg.FileName;
                    pHinhand.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}
