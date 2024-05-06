namespace GUII
{
    partial class frmHoaDon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QL_RapChieuPhimDataSet = new GUII.QL_RapChieuPhimDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VeTableAdapter = new GUII.QL_RapChieuPhimDataSetTableAdapters.VeTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QL_RapChieuPhimDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // VeBindingSource
            // 
            this.VeBindingSource.DataMember = "Ve";
            this.VeBindingSource.DataSource = this.QL_RapChieuPhimDataSet;
            // 
            // QL_RapChieuPhimDataSet
            // 
            this.QL_RapChieuPhimDataSet.DataSetName = "QL_RapChieuPhimDataSet";
            this.QL_RapChieuPhimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUII.HoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 23);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1304, 438);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // VeTableAdapter
            // 
            this.VeTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hoàn tất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 518);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QL_RapChieuPhimDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VeBindingSource;
        private QL_RapChieuPhimDataSet QL_RapChieuPhimDataSet;
        private QL_RapChieuPhimDataSetTableAdapters.VeTableAdapter VeTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}