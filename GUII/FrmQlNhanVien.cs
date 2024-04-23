using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DirectX.Common.Direct2D;
using DevExpress.Utils.CommonDialogs;
using OpenLibrary.Bussiness;


using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using BLL;
using DTO;
using DevExpress.Drawing.Internal.Fonts;
namespace GUII
{
    public partial class FrmQlNhanVien : Form
    { CtrQLNhanVien ctr = new CtrQLNhanVien();
       
        string srcimg = "";
       
    
        public FrmQlNhanVien()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmQlNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ctr.laydsNhanVienbt();
           /* comboboxTenLoaiNV.DataSource = ctr.laydsloaiNhanVien();
            comboboxTenLoaiNV.DisplayMember = "Tenloai";

            comboboxTenCN.DataSource = ctr.laydsChiNhanh();
            comboboxTenCN.DisplayMember = "TenChiNhanh";

            cbbTenChiNhanh.DataSource = ctr.laydsChiNhanh();
            cbbTenChiNhanh.DisplayMember = "TenChiNhanh";

            cbbTenloai.DataSource = ctr.laydsloaiNhanVien();
            cbbTenloai.DisplayMember = "Tenloai";*/
         //  pHinhand.Image = Properties.Resources.boemployee_32x32;



        }
        private bool xacthucthongtin()
        {
            if (txtHovaTen.Text == "") return false;
            if (txtEmail.Text == "") return false;
            if (txtSDT.Text == "") return false;
            if (txtDiaChi.Text == "") return false;

          
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
           if(xacthucthongtin()== true)
            {
                var s = ctr.laydsNhanVienbt();
                DataRow k = s.NewRow();
                k["HoTen"] = txtHovaTen.Text;
            
                k["SDT"] = txtSDT.Text;
                k["Diachi"] = txtDiaChi.Text;
                k["Email"] = txtEmail.Text;







                if (pHinhand.Image != null) {
                
              //      byte[] tam = Utility.ImageToByteArray(pHinhand.Image);
                }    
                    
                  
     
                  

                if (ctr.ThemMoiNhanvien(k) == false) MessageBox.Show("Lỗi");
            }
           else MessageBox.Show("Vui lồng điền đủ thông tin");
            dataGridView1.DataSource = ctr.laydsNhanVienbt();
        }

        

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            //dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //   var s = dataGridView1.CurrentRow?.Cells["MaNV"].Value.ToString();
            if (dataGridView1.CurrentRow == null) return;
           // if (dataGridView1.CurrentRow.Index > dataGridView1.Rows.Count)
          
            if (dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count)
            {
                string dk1 = "MaNguoiDung  = '" + dataGridView1.CurrentRow.Cells["MaNguoiDung"].Value.ToString() + "'";
                DataTable nvkethop = ctr.laydsNhanVienbt();
                DataRow[]  dr = nvkethop.Select(dk1);
                if(dr !=null && dr.Length != 0 )
                {
                    txtHovaTen.Text = dr[0]["HoTen"].ToString();
                   
                    txtSDT.Text = dataGridView1.CurrentRow.Cells["SDT"].Value.ToString();
                    txtDiaChi.Text = dr[0]["Diachi"].ToString();
        var s= dataGridView1.CurrentRow.Cells["MaNguoiDung"].Value.ToString(); ;
                    txtMaNV.Text = dataGridView1.CurrentRow.Cells["MaNguoiDung"].Value.ToString();
                
                    txtEmail.Text= txtMaNV.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                }



            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (xacthucthongtin() == true)
            {
             
                if (ctr.XoaNhanVien(int.Parse(txtMaNV.Text)) == false) MessageBox.Show("Lỗi");
            }    
            else MessageBox.Show("Vui lồng điền đủ thông tin");
            dataGridView1.DataSource = ctr.laydsNhanVienbt();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (xacthucthongtin() == true)
            {
                var s = ctr.laydsNhanVienbt();
                DataRow k = s.NewRow();

                k["HoTen"] = txtHovaTen.Text;
                k["CMND"] = txtEmail.Text;
                k["SDT"] = txtSDT.Text;
                k["Diachi"] = txtDiaChi.Text;
        
                k["Manguoidung"] = int.Parse(txtMaNV.Text);
              
             

               
            
               
            
                
           
                if (ctr.SuaNhanVien(k) == false) MessageBox.Show("Lỗi");
            }
            else MessageBox.Show("Vui lồng điền đủ thông tin");
            dataGridView1.DataSource = ctr.laydsNhanVienbt();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // TxtPassword.Text = Membership.GeneratePassword(8,3);
        }

        private void pHinhand_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {

                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.jdg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif)";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    pHinhand.Image = new Bitmap(dlg.FileName);
                    srcimg = dlg.FileName;
                    pHinhand.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void comboboxTenLoaiNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
