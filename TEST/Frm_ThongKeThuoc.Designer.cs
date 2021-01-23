namespace TEST
{
    partial class Frm_ThongKeThuoc
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
            this.MedicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new TEST.DataSet1();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cachedReport1 = new CrystalDecisions.ReportSource.CachedReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MedicineTableAdapter = new TEST.DataSet1TableAdapters.MedicineTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicineBindingSource
            // 
            this.MedicineBindingSource.DataMember = "Medicine";
            this.MedicineBindingSource.DataSource = this.DataSet1;
            this.MedicineBindingSource.CurrentChanged += new System.EventHandler(this.MedicineBindingSource_CurrentChanged);
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MedicineBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TEST.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1285, 714);
            this.reportViewer1.TabIndex = 0;
            // 
            // MedicineTableAdapter
            // 
            this.MedicineTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_ThongKeThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 714);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ThongKeThuoc";
            this.Text = "Frm_ThongKeThuoc";
            this.Load += new System.EventHandler(this.Frm_ThongKeThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CrystalDecisions.ReportSource.CachedReport cachedReport1;
        private System.Windows.Forms.BindingSource MedicineBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.MedicineTableAdapter MedicineTableAdapter;
    }
}