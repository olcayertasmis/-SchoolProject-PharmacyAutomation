
namespace Eczane_Otomasyonu
{
    partial class GunRaporu
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EczaneOtomasyonDBDataSet2 = new Eczane_Otomasyonu.EczaneOtomasyonDBDataSet2();
            this.GunSonuViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GunSonuViewTableAdapter = new Eczane_Otomasyonu.EczaneOtomasyonDBDataSet2TableAdapters.GunSonuViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EczaneOtomasyonDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunSonuViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GunSonuViewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Eczane_Otomasyonu.GunSonu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1425, 596);
            this.reportViewer1.TabIndex = 0;
            // 
            // EczaneOtomasyonDBDataSet2
            // 
            this.EczaneOtomasyonDBDataSet2.DataSetName = "EczaneOtomasyonDBDataSet2";
            this.EczaneOtomasyonDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GunSonuViewBindingSource
            // 
            this.GunSonuViewBindingSource.DataMember = "GunSonuView";
            this.GunSonuViewBindingSource.DataSource = this.EczaneOtomasyonDBDataSet2;
            // 
            // GunSonuViewTableAdapter
            // 
            this.GunSonuViewTableAdapter.ClearBeforeFill = true;
            // 
            // GunRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 596);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GunRaporu";
            this.Text = "GunRaporu";
            this.Load += new System.EventHandler(this.GunRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EczaneOtomasyonDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunSonuViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GunSonuViewBindingSource;
        private EczaneOtomasyonDBDataSet2 EczaneOtomasyonDBDataSet2;
        private EczaneOtomasyonDBDataSet2TableAdapters.GunSonuViewTableAdapter GunSonuViewTableAdapter;
    }
}