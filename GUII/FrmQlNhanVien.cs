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
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ctr.laydsNhanVien();
            comboboxTenLoaiNV.DataSource = ctr.laydsloaiNhanVien();
            comboboxTenLoaiNV.DisplayMember = "Tenloai";

            comboboxTenCN.DataSource = ctr.laydsChiNhanh();
            comboboxTenCN.DisplayMember = "TenChiNhanh";

            cbbTenChiNhanh.DataSource = ctr.laydsChiNhanh();
            cbbTenChiNhanh.DisplayMember = "TenChiNhanh";

            cbbTenloai.DataSource = ctr.laydsloaiNhanVien();
            cbbTenloai.DisplayMember = "Tenloai";
         //  pHinhand.Image = Properties.Resources.boemployee_32x32;



        }
        private bool xacthucthongtin()
        {
            if (txtHovaTen.Text == "") return false;
            if (txtCMND.Text == "") return false;
            if (txtSDT.Text == "") return false;
            if (txtDiaChi.Text == "") return false;
            if (txtEmail.Text == "") return false;
            if (txtMaNV.Text == "") return false;
            if (txtUserName.Text == "") return false;
            if (TxtPassword.Text == "") return false;
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
           if(xacthucthongtin()== true)
            {
                var s = ctr.laydsNhanVienbt();
                DataRow k = s.NewRow();

                k["HoTenNV"] = txtHovaTen.Text;
                k["CMND"] = txtCMND.Text;
                k["SDT"] = txtSDT.Text;
                k["Diachi"] = txtDiaChi.Text;
                k["email"] = txtEmail.Text;
                k["MaNV"] = int.Parse(txtMaNV.Text);
                DataTable ChiNhanh = ctr.laydsChiNhanh();
                DataTable LoaiNV = ctr.laydsloaiNhanVien();
                var i = comboboxTenLoaiNV.SelectedIndex;

                k["Maloainv"] = int.Parse(LoaiNV.Rows[i]["Maloai"].ToString());
                i = comboboxTenCN.SelectedIndex;
                k["MaCN"] = int.Parse(ChiNhanh.Rows[i]["MachiNhanh"].ToString());

                k["Username"] = txtUserName.Text;
                k["password"] = TxtPassword.Text;
                if (pHinhand.Image != null) {
                
              //      byte[] tam = Utility.ImageToByteArray(pHinhand.Image);
                }    
                    
                  
     
                  

                if (ctr.ThemMoiNhanvien(k) == false) MessageBox.Show("Lỗi");
            }
           else MessageBox.Show("Vui lồng điền đủ thông tin");
            dataGridView1.DataSource = ctr.laydsNhanVien();
        }

        

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            comboboxTenLoaiNV.DataSource = ctr.laydsloaiNhanVien();
            comboboxTenLoaiNV.DisplayMember = "Tenloai";
            comboboxTenCN.DataSource = ctr.laydsChiNhanh();
            comboboxTenCN.DisplayMember = "TenChiNhanh";
            //dataGridView1.CurrentRow.Cells[0].Value.ToString();
         //   var s = dataGridView1.CurrentRow?.Cells["MaNV"].Value.ToString();
            if (dataGridView1.CurrentRow!=null && dataGridView1.CurrentRow.Index < dataGridView1.RowCount && dataGridView1.CurrentRow?.Cells["MaNV"].Value.ToString()!=null && dataGridView1.CurrentRow?.Cells["MaNV"].Value.ToString() != "")
            {
                string dk1 = "MaNV = '" + dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString() + "'";
                DataTable nvkethop = ctr.laydsNhanVien();
                DataRow[]  dr = nvkethop.Select(dk1);
                if(dr !=null && dr.Length != 0 )
                {
                    txtHovaTen.Text = dr[0]["HoTenNV"].ToString();
                    txtCMND.Text = dr[0]["CMND"].ToString();
                    txtSDT.Text = dataGridView1.CurrentRow.Cells["SDT"].Value.ToString();
                    txtDiaChi.Text = dr[0]["Diachi"].ToString();
                    txtEmail.Text = dr[0]["email"].ToString();
                    txtMaNV.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
                    txtUserName.Text = dr[0]["Username"].ToString(); ;
                    TxtPassword.Text = dr[0]["password"].ToString(); ;
  
                    DataTable ChiNhanh = ctr.laydsChiNhanh();
          
                    if (dr[0]["hinhanh"] != null )
                    {
                       byte[] bytes = (byte[]) dr[0]["hinhanh"];
                     

                    }
                      //  k[""] = System.Text.Encoding.UTF8.GetString(Utility.ImageToByteArray(pHinhand.Image)); ;
                    string dk = "MachiNhanh = '" + dr[0]["MaCN"].ToString() + "'";
                    DataRow[] dr2 = ChiNhanh.Select(dk);
                    DataTable LoaiNV = ctr.laydsloaiNhanVien();

                    comboboxTenCN.SelectedItem = ChiNhanh.Rows.IndexOf(dr2[0]);
                    // cbbTenChiNhanh.Selected. = ChiNhanh.Rows.IndexOf(dr2[0]);
                    dk = "Maloai = '" + dr[0]["Maloainv"].ToString() + "'";
                    DataRow[] dr3 = LoaiNV.Select(dk);

                    comboboxTenLoaiNV.SelectedIndex = LoaiNV.Rows.IndexOf(dr3[0]);
                    //    cbbTenloai.SelectedIndex = LoaiNV.Rows.IndexOf(dr3[0]);
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
            dataGridView1.DataSource = ctr.laydsNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (xacthucthongtin() == true)
            {
                var s = ctr.laydsNhanVienbt();
                DataRow k = s.NewRow();

                k["HoTenNV"] = txtHovaTen.Text;
                k["CMND"] = txtCMND.Text;
                k["SDT"] = txtSDT.Text;
                k["Diachi"] = txtDiaChi.Text;
                k["email"] = txtEmail.Text;
                k["MaNV"] = int.Parse(txtMaNV.Text);
                DataTable ChiNhanh = ctr.laydsChiNhanh();
                DataTable LoaiNV = ctr.laydsloaiNhanVien();
                var i = comboboxTenLoaiNV.SelectedIndex;

                k["Maloainv"] = int.Parse(LoaiNV.Rows[i]["Maloai"].ToString());
                i = comboboxTenCN.SelectedIndex;
                k["MaCN"] = int.Parse(ChiNhanh.Rows[i]["MachiNhanh"].ToString());
               
            
                k["Username"] = txtUserName.Text;
                k["password"] = TxtPassword.Text;
           
                if (ctr.SuaNhanVien(k) == false) MessageBox.Show("Lỗi");
            }
            else MessageBox.Show("Vui lồng điền đủ thông tin");
            dataGridView1.DataSource = ctr.laydsNhanVien();
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
    }
}
