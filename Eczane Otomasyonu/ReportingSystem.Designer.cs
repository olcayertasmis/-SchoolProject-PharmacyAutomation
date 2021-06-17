
namespace Eczane_Otomasyonu
{
    partial class ReportingSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportingSystem));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnStokGoster = new System.Windows.Forms.Button();
            this.BtnStokRapor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGunuRaporla = new System.Windows.Forms.Button();
            this.BtnGunuGoster = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnTarihGecenlerGoster = new System.Windows.Forms.Button();
            this.BtnTarihGecenlerRaporla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnStokGoster
            // 
            this.BtnStokGoster.BackColor = System.Drawing.Color.Transparent;
            this.BtnStokGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStokGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStokGoster.ForeColor = System.Drawing.Color.Black;
            this.BtnStokGoster.Location = new System.Drawing.Point(300, 342);
            this.BtnStokGoster.Name = "BtnStokGoster";
            this.BtnStokGoster.Size = new System.Drawing.Size(134, 47);
            this.BtnStokGoster.TabIndex = 1;
            this.BtnStokGoster.Text = "GÖSTER";
            this.BtnStokGoster.UseVisualStyleBackColor = false;
            this.BtnStokGoster.Click += new System.EventHandler(this.BtnStokGoster_Click);
            // 
            // BtnStokRapor
            // 
            this.BtnStokRapor.BackColor = System.Drawing.Color.Transparent;
            this.BtnStokRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStokRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStokRapor.ForeColor = System.Drawing.Color.Black;
            this.BtnStokRapor.Location = new System.Drawing.Point(440, 342);
            this.BtnStokRapor.Name = "BtnStokRapor";
            this.BtnStokRapor.Size = new System.Drawing.Size(134, 47);
            this.BtnStokRapor.TabIndex = 2;
            this.BtnStokRapor.Text = "RAPORLA";
            this.BtnStokRapor.UseVisualStyleBackColor = false;
            this.BtnStokRapor.Click += new System.EventHandler(this.BtnStokRapor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "STOĞU BİTEN İLAÇLAR :";
            // 
            // BtnGunuRaporla
            // 
            this.BtnGunuRaporla.BackColor = System.Drawing.Color.Transparent;
            this.BtnGunuRaporla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGunuRaporla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGunuRaporla.ForeColor = System.Drawing.Color.Black;
            this.BtnGunuRaporla.Location = new System.Drawing.Point(440, 286);
            this.BtnGunuRaporla.Name = "BtnGunuRaporla";
            this.BtnGunuRaporla.Size = new System.Drawing.Size(134, 47);
            this.BtnGunuRaporla.TabIndex = 4;
            this.BtnGunuRaporla.Text = "RAPORLA";
            this.BtnGunuRaporla.UseVisualStyleBackColor = false;
            this.BtnGunuRaporla.Click += new System.EventHandler(this.BtnGunuRaporla_Click);
            // 
            // BtnGunuGoster
            // 
            this.BtnGunuGoster.BackColor = System.Drawing.Color.Transparent;
            this.BtnGunuGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGunuGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGunuGoster.ForeColor = System.Drawing.Color.Black;
            this.BtnGunuGoster.Location = new System.Drawing.Point(300, 286);
            this.BtnGunuGoster.Name = "BtnGunuGoster";
            this.BtnGunuGoster.Size = new System.Drawing.Size(134, 47);
            this.BtnGunuGoster.TabIndex = 5;
            this.BtnGunuGoster.Text = "GÖSTER";
            this.BtnGunuGoster.UseVisualStyleBackColor = false;
            this.BtnGunuGoster.Click += new System.EventHandler(this.BtnGunuGoster_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "24 SAATTE YAPILAN SATIŞLAR :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "TARİHİ GEÇEN İLAÇLAR :";
            // 
            // BtnTarihGecenlerGoster
            // 
            this.BtnTarihGecenlerGoster.BackColor = System.Drawing.Color.Transparent;
            this.BtnTarihGecenlerGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTarihGecenlerGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTarihGecenlerGoster.ForeColor = System.Drawing.Color.Black;
            this.BtnTarihGecenlerGoster.Location = new System.Drawing.Point(300, 229);
            this.BtnTarihGecenlerGoster.Name = "BtnTarihGecenlerGoster";
            this.BtnTarihGecenlerGoster.Size = new System.Drawing.Size(134, 47);
            this.BtnTarihGecenlerGoster.TabIndex = 8;
            this.BtnTarihGecenlerGoster.Text = "GÖSTER";
            this.BtnTarihGecenlerGoster.UseVisualStyleBackColor = false;
            this.BtnTarihGecenlerGoster.Click += new System.EventHandler(this.BtnTarihGecenlerGoster_Click);
            // 
            // BtnTarihGecenlerRaporla
            // 
            this.BtnTarihGecenlerRaporla.BackColor = System.Drawing.Color.Transparent;
            this.BtnTarihGecenlerRaporla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnTarihGecenlerRaporla.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnTarihGecenlerRaporla.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnTarihGecenlerRaporla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTarihGecenlerRaporla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTarihGecenlerRaporla.ForeColor = System.Drawing.Color.Black;
            this.BtnTarihGecenlerRaporla.Location = new System.Drawing.Point(440, 229);
            this.BtnTarihGecenlerRaporla.Name = "BtnTarihGecenlerRaporla";
            this.BtnTarihGecenlerRaporla.Size = new System.Drawing.Size(134, 47);
            this.BtnTarihGecenlerRaporla.TabIndex = 7;
            this.BtnTarihGecenlerRaporla.Text = "RAPORLA";
            this.BtnTarihGecenlerRaporla.UseVisualStyleBackColor = false;
            this.BtnTarihGecenlerRaporla.Click += new System.EventHandler(this.BtnTarihGecenlerRaporla_Click);
            // 
            // ReportingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 401);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnTarihGecenlerGoster);
            this.Controls.Add(this.BtnTarihGecenlerRaporla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGunuGoster);
            this.Controls.Add(this.BtnGunuRaporla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStokRapor);
            this.Controls.Add(this.BtnStokGoster);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportingSystem";
            this.Text = "RAPOR EKRANI";
            this.Load += new System.EventHandler(this.ReportingSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnStokGoster;
        private System.Windows.Forms.Button BtnStokRapor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGunuRaporla;
        private System.Windows.Forms.Button BtnGunuGoster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnTarihGecenlerGoster;
        private System.Windows.Forms.Button BtnTarihGecenlerRaporla;
    }
}