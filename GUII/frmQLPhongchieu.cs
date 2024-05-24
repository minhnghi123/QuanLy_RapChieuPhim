using BLL;
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
    public partial class frmQLPhongchieu : Form
    {
        DataRow dr;
        ctrPhongChieu ctr = new ctrPhongChieu();
        public frmQLPhongchieu()
        {
            InitializeComponent();
        }

        private void frmQLPhongchieu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ctr.PHong();
            dr = ctr.PHong().NewRow();
            comboBox2.DataSource = ctr.rap();
            comboBox2.DisplayMember = "TenRap";
            comboBox2.ValueMember= "MaRapChieu";
            textBox1.ReadOnly = true;
        }
      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            if (dataGridView1.CurrentRow.Index >= dataGridView1.Rows.Count) return;


            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox2.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            dr[1] = comboBox2.SelectedValue;
  

            if (ctr.inserSuatChieu(dr))
                MessageBox.Show("thành công");
            else MessageBox.Show("thất bại");
            dataGridView1.DataSource = ctr.PHong();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var s = textBox1.Text;
            if (ctr.xoa(textBox1.Text))
                MessageBox.Show("thành công");
            else MessageBox.Show("thất bại");
            dataGridView1.DataSource = ctr.PHong();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dr[0] = textBox1.Text;
            dr[1] = comboBox2.SelectedValue;
  
       

            if (ctr.update(dr))
                MessageBox.Show("thành công");
            else MessageBox.Show("thất bại");
            dataGridView1.DataSource = ctr.PHong();

        }
    }
}
