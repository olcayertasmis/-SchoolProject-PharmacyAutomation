
namespace Eczane_Otomasyonu
{
    partial class StokBitenRapor
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
            this.EczaneOtomasyonDBDataSet1 = new Eczane_Otomasyonu.EczaneOtomasyonDBDataSet1();
            this.Stok_biten_ilaclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Stok_biten_ilaclarTableAdapter = new Eczane_Otomasyonu.EczaneOtomasyonDBDataSet1TableAdapters.Stok_biten_ilaclarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EczaneOtomasyonDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok_biten_ilaclarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Stok_biten_ilaclarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Eczane_Otomasyonu.Biten_ilaclar.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1420, 596);
            this.reportViewer1.TabIndex = 0;
            // 
            // EczaneOtomasyonDBDataSet1
            // 
            this.EczaneOtomasyonDBDataSet1.DataSetName = "EczaneOtomasyonDBDataSet1";
            this.EczaneOtomasyonDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Stok_biten_ilaclarBindingSource
            // 
            this.Stok_biten_ilaclarBindingSource.DataMember = "Stok_biten_ilaclar";
            this.Stok_biten_ilaclarBindingSource.DataSource = this.EczaneOtomasyonDBDataSet1;
            // 
            // Stok_biten_ilaclarTableAdapter
            // 
            this.Stok_biten_ilaclarTableAdapter.ClearBeforeFill = true;
            // 
            // StokBitenRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 596);
            this.Controls.Add(this.reportViewer1);
            this.Name = "StokBitenRapor";
            this.Text = "StokBitenRapor";
            this.Load += new System.EventHandler(this.StokBitenRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EczaneOtomasyonDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok_biten_ilaclarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Stok_biten_ilaclarBindingSource;
        private EczaneOtomasyonDBDataSet1 EczaneOtomasyonDBDataSet1;
        private EczaneOtomasyonDBDataSet1TableAdapters.Stok_biten_ilaclarTableAdapter Stok_biten_ilaclarTableAdapter;
    }
}