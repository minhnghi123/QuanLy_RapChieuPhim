using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DuAn_RapChieuPhim
{
    public partial class Rap : Form
    {
        private SqlConnection conn;
        CtrRap ctr = new CtrRap();
        public Rap()
        {
            InitializeComponent();
        }
        public void connect()
        {
            //Lấy chuỗi kết nối CSDL
            string strcon = "Data Source=LAPTOP-PICGBI40\\HONGPHUC;Initial Catalog=QL_RapChieuPhim;Integrated Security=True;";
            try
            {
                conn = new SqlConnection(strcon);
                // Mở kết nối
                conn.Open();
                //Ko làm gì thì đóng kết nối lại
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Không kết nối được CSDL", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnthoatRap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool KiemTraThongTin()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Ban chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            return true;
        }
        private void btnthemRap_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SP_ThemRap";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = textBox1.Text;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = textBox2.Text;
                    cmd.Parameters.Add("@address", SqlDbType.VarChar).Value = textBox3.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dgvrap.DataSource = ctr.suatRap();
                    Reset();
                    MessageBox.Show("Đã thêm mới rạp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
            private void btnxoaRap_Click(object sender, EventArgs e)
            {
                try
                {      
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "SP_XoaRap";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = textBox1.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dgvrap.DataSource= ctr.suatRap();
                    Reset();
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void btnsuaRap_Click(object sender, EventArgs e)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã rạp cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Focus();
                }
                else if (KiemTraThongTin())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand();

                        cmd.CommandText = "SP_SuaRap";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = textBox1.Text;
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = textBox2.Text;
                        cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = textBox3.Text;
                        
                        cmd.Connection = conn;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        dgvrap.DataSource = ctr.suatRap();
                        Reset();
                        MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            private void Rap_Load(object sender, EventArgs e)
            {
                connect();
                dgvrap.DataSource = ctr.suatRap();
            }

            private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                DataGridViewSelectedCellCollection cell = dgvrap.SelectedCells;
                if (cell.Count > 0)
                {
                    DataGridViewRow row = dgvrap.Rows[e.RowIndex];
                    textBox1.Text = row.Cells["MaRapChieu"].Value.ToString();
                    textBox2.Text = row.Cells["TenRap"].Value.ToString();
                    textBox3.Text = row.Cells["DiaChi"].Value.ToString();
                }
            }
            public void Reset()
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            private void btnReset_Click(object sender, EventArgs e)
            {
                Reset();

            }
        }
    } 
