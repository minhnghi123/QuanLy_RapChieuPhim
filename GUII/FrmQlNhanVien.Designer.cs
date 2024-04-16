namespace GUII
{
    partial class FrmQlNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboboxTenCN = new System.Windows.Forms.ComboBox();
            this.comboboxTenLoaiNV = new System.Windows.Forms.ComboBox();
            this.pHinhand = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbTenChiNhanh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbbTenloai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.tx = new System.Windows.Forms.Label();
            this.btntuTaopass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pHinhand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên Nhân viên";
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.Location = new System.Drawing.Point(257, 90);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.Size = new System.Drawing.Size(169, 26);
            this.txtHovaTen.TabIndex = 1;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(257, 142);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(169, 26);
            this.txtCMND.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CMND";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(257, 199);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(169, 26);
            this.txtSDT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "SĐT";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(257, 257);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(171, 26);
            this.txtDiaChi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(717, 220);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(169, 26);
            this.txtUserName.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "UserName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên Chi Nhánh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Loại nhân viên";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(745, 50);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 26);
            this.txtEmail.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "email";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(717, 274);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(169, 26);
            this.TxtPassword.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Password";
            // 
            // comboboxTenCN
            // 
            this.comboboxTenCN.FormattingEnabled = true;
            this.comboboxTenCN.Location = new System.Drawing.Point(745, 165);
            this.comboboxTenCN.Name = "comboboxTenCN";
            this.comboboxTenCN.Size = new System.Drawing.Size(121, 28);
            this.comboboxTenCN.TabIndex = 18;
            // 
            // comboboxTenLoaiNV
            // 
            this.comboboxTenLoaiNV.FormattingEnabled = true;
            this.comboboxTenLoaiNV.Location = new System.Drawing.Point(745, 100);
            this.comboboxTenLoaiNV.Name = "comboboxTenLoaiNV";
            this.comboboxTenLoaiNV.Size = new System.Drawing.Size(121, 28);
            this.comboboxTenLoaiNV.TabIndex = 19;
            this.comboboxTenLoaiNV.SelectedIndexChanged += new System.EventHandler(this.comboboxTenLoaiNV_SelectedIndexChanged);
            // 
            // pHinhand
            // 
            this.pHinhand.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pHinhand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pHinhand.Location = new System.Drawing.Point(978, 41);
            this.pHinhand.Name = "pHinhand";
            this.pHinhand.Size = new System.Drawing.Size(163, 205);
            this.pHinhand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pHinhand.TabIndex = 20;
            this.pHinhand.TabStop = false;
            this.pHinhand.Click += new System.EventHandler(this.pHinhand_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTenNV,
            this.CMND,
            this.SDT,
            this.Diachi,
            this.cbbTenChiNhanh,
            this.cbbTenloai,
            this.email});
            this.dataGridView1.Location = new System.Drawing.Point(42, 369);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 440);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân viên";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 150;
            // 
            // HoTenNV
            // 
            this.HoTenNV.DataPropertyName = "HoTenNV";
            this.HoTenNV.HeaderText = "Họ và Tên";
            this.HoTenNV.MinimumWidth = 8;
            this.HoTenNV.Name = "HoTenNV";
            this.HoTenNV.Width = 150;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND ";
            this.CMND.MinimumWidth = 8;
            this.CMND.Name = "CMND";
            this.CMND.Width = 150;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT ";
            this.SDT.MinimumWidth = 8;
            this.SDT.Name = "SDT";
            this.SDT.Width = 150;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa chỉ ";
            this.Diachi.MinimumWidth = 8;
            this.Diachi.Name = "Diachi";
            this.Diachi.Width = 150;
            // 
            // cbbTenChiNhanh
            // 
            this.cbbTenChiNhanh.HeaderText = "Tên Chi Nhánh";
            this.cbbTenChiNhanh.MinimumWidth = 8;
            this.cbbTenChiNhanh.Name = "cbbTenChiNhanh";
            this.cbbTenChiNhanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbbTenChiNhanh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbbTenChiNhanh.Width = 150;
            // 
            // cbbTenloai
            // 
            this.cbbTenloai.HeaderText = "Tên Loại Nhân viên";
            this.cbbTenloai.MinimumWidth = 8;
            this.cbbTenloai.Name = "cbbTenloai";
            this.cbbTenloai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbbTenloai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbbTenloai.Width = 150;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email ";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.Width = 150;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(68, 309);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(149, 54);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(259, 309);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 54);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(453, 309);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 54);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(259, 35);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(169, 26);
            this.txtMaNV.TabIndex = 26;
            // 
            // tx
            // 
            this.tx.AutoSize = true;
            this.tx.Location = new System.Drawing.Point(81, 35);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(103, 20);
            this.tx.TabIndex = 25;
            this.tx.Text = "Mã nhân viên";
            // 
            // btntuTaopass
            // 
            this.btntuTaopass.Location = new System.Drawing.Point(905, 267);
            this.btntuTaopass.Name = "btntuTaopass";
            this.btntuTaopass.Size = new System.Drawing.Size(131, 40);
            this.btntuTaopass.TabIndex = 27;
            this.btntuTaopass.Text = "Tự tạo pass";
            this.btntuTaopass.UseVisualStyleBackColor = true;
            this.btntuTaopass.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmQlNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 828);
            this.Controls.Add(this.btntuTaopass);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.tx);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pHinhand);
            this.Controls.Add(this.comboboxTenLoaiNV);
            this.Controls.Add(this.comboboxTenCN);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHovaTen);
            this.Controls.Add(this.label1);
            this.Name = "FrmQlNhanVien";
            this.Text = "FrmQlNhanVien";
            this.Load += new System.EventHandler(this.FrmQlNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pHinhand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboboxTenCN;
        private System.Windows.Forms.ComboBox comboboxTenLoaiNV;
        private System.Windows.Forms.PictureBox pHinhand;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label tx;
        private System.Windows.Forms.Button btntuTaopass;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbbTenChiNhanh;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbbTenloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}