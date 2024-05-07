using BLL;
using DevExpress.XtraCharts.Native;
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
    public partial class frmQLSuatChieu : Form
    {
        DataRow dr;
        ctrSuatChieu ctr =new ctrSuatChieu();
        public frmQLSuatChieu()
        {
            InitializeComponent();
        }

        private void frmQLSuatChieu_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy    hh:00:00 tt";
            var s = dateTimePicker1.Text;
            dataGridView1.DataSource = ctr.suachieu();
            textBox1.ReadOnly = true;
            comboBox2.DataSource = ctr.Phim();
            comboBox2.DisplayMember = "TenPhim";
            comboBox2.ValueMember = "MaPhim";
            comboBox3.DataSource = ctr.PHong();
            comboBox3.DisplayMember = "MaPhongChieu";
            //    comboBox3.ValueMember = "MaPhim";
            dr = ctr.suachieu().NewRow();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            if (dataGridView1.CurrentRow.Index >= dataGridView1.Rows.Count) return;

            comboBox2.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
       //     comboBox2.SelectedIndex = comboBox2.FindString();
            dateTimePicker1.Value = (DateTime) dataGridView1.CurrentRow.Cells[3].Value;
            comboBox3.SelectedIndex = comboBox3.FindString(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            //     numericUpDown1.Value;
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        private void textBox123_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dr[1] = comboBox2.SelectedValue;
            dr[2] = comboBox3.Text;
            dr[3] = dateTimePicker1.Value;
            dr[4] = decimal.Parse(textBox2.Text);

            if (ctr.inserSuatChieu(dr))
                MessageBox.Show("thành công");
            else MessageBox.Show("thất bại");
            dataGridView1.DataSource = ctr.suachieu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var s = textBox1.Text;
            if (ctr.xoa(textBox1.Text))
                MessageBox.Show("thành công");
            else MessageBox.Show("thất bại");
            dataGridView1.DataSource = ctr.suachieu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dr[0] = textBox1.Text;
            dr[1] = comboBox2.SelectedValue;
            dr[2] = comboBox3.Text;
            dr[3] = dateTimePicker1.Value;
            dr[4] = decimal.Parse(textBox2.Text);

            if (ctr.update(dr))
                MessageBox.Show("thành công");
            else MessageBox.Show("thất bại");
            dataGridView1.DataSource = ctr.suachieu();

        }
    }
}
