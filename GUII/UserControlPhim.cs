using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUII
{
    public partial class UserControlPhim : UserControl
    {
        DataRow dl=null;
        public UserControlPhim()
        {
            InitializeComponent();
        }
        public void setText(string text)
        {
            title.Text = text;  
        }
        public void setNam(string text)
        {
            Name.Text = text;
        }
        public void setGiaVe(string text)
        {
           button1.Text=text;
        }
        public void setDatarow(DataRow dr)
        {
            dl = dr;
        }
        public void setPicture(Image img)
        {
           pictureBox1.Image = img;
            pictureBox1.SizeMode =  PictureBoxSizeMode.StretchImage;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           // this.Hide();
            var f =new frmChiTietPhimDatVe();
            frmChiTietPhimDatVe.dr = dl;
            f.setHinh(pictureBox1.Image);
            f.Show();
        }

        private void UserControlPhim_Load(object sender, EventArgs e)
        {
            title.MaximumSize = new Size(100, 0);

            title.TextAlign = ContentAlignment.MiddleCenter;
            title.AutoSize = true;
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }
    }
}
