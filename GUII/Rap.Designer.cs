namespace DuAn_RapChieuPhim
{
    partial class Rap
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
            this.components = new System.ComponentModel.Container();
            this.dgvrap = new System.Windows.Forms.DataGridView();
            this.MaRapChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnthoatRap = new System.Windows.Forms.Button();
            this.btnxoaRap = new System.Windows.Forms.Button();
            this.btnsuaRap = new System.Windows.Forms.Button();
            this.btnthemRap = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvrap
            // 
            this.dgvrap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaRapChieu,
            this.TenRap,
            this.DiaChi});
            this.dgvrap.Location = new System.Drawing.Point(456, 23);
            this.dgvrap.Name = "dgvrap";
            this.dgvrap.RowHeadersWidth = 51;
            this.dgvrap.RowTemplate.Height = 24;
            this.dgvrap.Size = new System.Drawing.Size(613, 558);
            this.dgvrap.TabIndex = 1;
            this.dgvrap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaRapChieu
            // 
            this.MaRapChieu.DataPropertyName = "MaRapChieu";
            this.MaRapChieu.HeaderText = "Mã rạp phim";
            this.MaRapChieu.MinimumWidth = 6;
            this.MaRapChieu.Name = "MaRapChieu";
            this.MaRapChieu.Width = 125;
            // 
            // TenRap
            // 
            this.TenRap.DataPropertyName = "TenRap";
            this.TenRap.HeaderText = "Tên Rạp Phim";
            this.TenRap.MinimumWidth = 6;
            this.TenRap.Name = "TenRap";
            this.TenRap.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(72, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 558);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(141, 117);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(218, 96);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(141, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 26);
            this.textBox2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnthoatRap);
            this.groupBox2.Controls.Add(this.btnxoaRap);
            this.groupBox2.Controls.Add(this.btnsuaRap);
            this.groupBox2.Controls.Add(this.btnthemRap);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(17, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 195);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(127, 80);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 44);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnthoatRap
            // 
            this.btnthoatRap.Location = new System.Drawing.Point(240, 123);
            this.btnthoatRap.Name = "btnthoatRap";
            this.btnthoatRap.Size = new System.Drawing.Size(85, 44);
            this.btnthoatRap.TabIndex = 3;
            this.btnthoatRap.Text = "Thoát";
            this.btnthoatRap.UseVisualStyleBackColor = true;
            this.btnthoatRap.Click += new System.EventHandler(this.btnthoatRap_Click);
            // 
            // btnxoaRap
            // 
            this.btnxoaRap.Location = new System.Drawing.Point(240, 36);
            this.btnxoaRap.Name = "btnxoaRap";
            this.btnxoaRap.Size = new System.Drawing.Size(85, 44);
            this.btnxoaRap.TabIndex = 2;
            this.btnxoaRap.Text = "Xóa";
            this.btnxoaRap.UseVisualStyleBackColor = true;
            this.btnxoaRap.Click += new System.EventHandler(this.btnxoaRap_Click);
            // 
            // btnsuaRap
            // 
            this.btnsuaRap.Location = new System.Drawing.Point(18, 123);
            this.btnsuaRap.Name = "btnsuaRap";
            this.btnsuaRap.Size = new System.Drawing.Size(85, 44);
            this.btnsuaRap.TabIndex = 1;
            this.btnsuaRap.Text = "Sửa";
            this.btnsuaRap.UseVisualStyleBackColor = true;
            this.btnsuaRap.Click += new System.EventHandler(this.btnsuaRap_Click);
            // 
            // btnthemRap
            // 
            this.btnthemRap.Location = new System.Drawing.Point(18, 36);
            this.btnthemRap.Name = "btnthemRap";
            this.btnthemRap.Size = new System.Drawing.Size(85, 44);
            this.btnthemRap.TabIndex = 0;
            this.btnthemRap.Text = "Thêm";
            this.btnthemRap.UseVisualStyleBackColor = true;
            this.btnthemRap.Click += new System.EventHandler(this.btnthemRap_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(144, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 26);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên rạp phim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã rạp phim:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvrap);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 604);
            this.panel1.TabIndex = 3;
            // 
            // Rap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 604);
            this.Controls.Add(this.panel1);
            this.Name = "Rap";
            this.Text = "Rap";
            this.Load += new System.EventHandler(this.Rap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvrap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        //private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnthoatRap;
        private System.Windows.Forms.Button btnxoaRap;
        private System.Windows.Forms.Button btnsuaRap;
        private System.Windows.Forms.Button btnthemRap;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaRapChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        //private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}