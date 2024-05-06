namespace GUII
{
    partial class NhapTenFilecs
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
            this.lb_tenFile = new System.Windows.Forms.Label();
            this.txt_tenFile = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_tenFile
            // 
            this.lb_tenFile.AutoSize = true;
            this.lb_tenFile.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_tenFile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_tenFile.Location = new System.Drawing.Point(66, 53);
            this.lb_tenFile.Name = "lb_tenFile";
            this.lb_tenFile.Size = new System.Drawing.Size(330, 40);
            this.lb_tenFile.TabIndex = 0;
            this.lb_tenFile.Text = "Hãy nhập tên File :";
            // 
            // txt_tenFile
            // 
            this.txt_tenFile.Location = new System.Drawing.Point(87, 125);
            this.txt_tenFile.Multiline = true;
            this.txt_tenFile.Name = "txt_tenFile";
            this.txt_tenFile.Size = new System.Drawing.Size(284, 38);
            this.txt_tenFile.TabIndex = 1;
            this.txt_tenFile.TextChanged += new System.EventHandler(this.txt_tenFile_TextChanged);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnIn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIn.Location = new System.Drawing.Point(145, 238);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(130, 45);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "IN";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(319, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NhapTenFilecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 320);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txt_tenFile);
            this.Controls.Add(this.lb_tenFile);
            this.Name = "NhapTenFilecs";
            this.Text = "NhapTenFilecs";
            this.Load += new System.EventHandler(this.NhapTenFilecs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tenFile;
        public System.Windows.Forms.TextBox txt_tenFile;
        public System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button button2;
    }
}