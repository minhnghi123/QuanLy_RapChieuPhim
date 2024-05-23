namespace DuAn_RapChieuPhim
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.textBox_MatKhauDK = new System.Windows.Forms.TextBox();
            this.textBox_TenTaiKhoanDK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_EmailDK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDN = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_MaLoai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(-2, -103);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(1209, 610);
            this.pictureEdit1.TabIndex = 1;
            // 
            // textBox_MatKhauDK
            // 
            this.textBox_MatKhauDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MatKhauDK.Location = new System.Drawing.Point(185, 86);
            this.textBox_MatKhauDK.Name = "textBox_MatKhauDK";
            this.textBox_MatKhauDK.Size = new System.Drawing.Size(274, 27);
            this.textBox_MatKhauDK.TabIndex = 15;
            // 
            // textBox_TenTaiKhoanDK
            // 
            this.textBox_TenTaiKhoanDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TenTaiKhoanDK.Location = new System.Drawing.Point(185, 33);
            this.textBox_TenTaiKhoanDK.Name = "textBox_TenTaiKhoanDK";
            this.textBox_TenTaiKhoanDK.Size = new System.Drawing.Size(274, 27);
            this.textBox_TenTaiKhoanDK.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(41, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên tài khoản:";
            // 
            // textBox_EmailDK
            // 
            this.textBox_EmailDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EmailDK.Location = new System.Drawing.Point(185, 144);
            this.textBox_EmailDK.Name = "textBox_EmailDK";
            this.textBox_EmailDK.Size = new System.Drawing.Size(274, 27);
            this.textBox_EmailDK.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(41, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email:";
            // 
            // lblDN
            // 
            this.lblDN.AutoSize = true;
            this.lblDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDN.Location = new System.Drawing.Point(376, 316);
            this.lblDN.Name = "lblDN";
            this.lblDN.Size = new System.Drawing.Size(259, 20);
            this.lblDN.TabIndex = 19;
            this.lblDN.TabStop = true;
            this.lblDN.Text = "Đã có tài khoản? Đăng nhập ngay";
            this.lblDN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDN_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, -70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 38);
            this.label3.TabIndex = 20;
            this.label3.Text = "WELCOME TO PHT";
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangKy.Location = new System.Drawing.Point(157, 308);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(133, 39);
            this.btnDangKy.TabIndex = 21;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(41, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mã Loại:";
            // 
            // textBox_MaLoai
            // 
            this.textBox_MaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MaLoai.Location = new System.Drawing.Point(185, 220);
            this.textBox_MaLoai.Name = "textBox_MaLoai";
            this.textBox_MaLoai.Size = new System.Drawing.Size(274, 27);
            this.textBox_MaLoai.TabIndex = 23;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.textBox_MaLoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDN);
            this.Controls.Add(this.textBox_EmailDK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_MatKhauDK);
            this.Controls.Add(this.textBox_TenTaiKhoanDK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.TextBox textBox_MatKhauDK;
        private System.Windows.Forms.TextBox textBox_TenTaiKhoanDK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_EmailDK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lblDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_MaLoai;
    }
}