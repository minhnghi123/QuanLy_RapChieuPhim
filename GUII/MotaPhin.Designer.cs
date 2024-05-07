namespace GUII
{
    partial class MotaPhin
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
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lb_tenphim = new System.Windows.Forms.Label();
            this.picturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(54, 86);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(555, 311);
            this.txt_mota.TabIndex = 0;
            this.txt_mota.TextChanged += new System.EventHandler(this.txt_mota_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "MÔ TẢ PHIM";
            // 
            // lb_tenphim
            // 
            this.lb_tenphim.AutoSize = true;
            this.lb_tenphim.Font = new System.Drawing.Font("Tahoma", 22.2F);
            this.lb_tenphim.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_tenphim.Location = new System.Drawing.Point(310, 19);
            this.lb_tenphim.Name = "lb_tenphim";
            this.lb_tenphim.Size = new System.Drawing.Size(185, 45);
            this.lb_tenphim.TabIndex = 3;
            this.lb_tenphim.Text = "...............";
            // 
            // picturebox
            // 
            this.picturebox.Location = new System.Drawing.Point(680, 82);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(399, 394);
            this.picturebox.TabIndex = 5;
            this.picturebox.TabStop = false;
            // 
            // MotaPhin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 676);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.lb_tenphim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mota);
            this.Name = "MotaPhin";
            this.Text = "MotaPhin";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_tenphim;
        private System.Windows.Forms.PictureBox picturebox;
    }
}