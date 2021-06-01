
namespace Eczane_Otomasyonu
{
    partial class IlacEkran
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.TbAdet = new System.Windows.Forms.TextBox();
            this.TbFiyat = new System.Windows.Forms.TextBox();
            this.TbAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.TbYenilac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtUretim = new System.Windows.Forms.DateTimePicker();
            this.DtSonKullanim = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnTurEkle = new System.Windows.Forms.Button();
            this.CbilacTur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(839, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(681, 572);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(170, 77);
            this.BtnKaydet.TabIndex = 18;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(501, 572);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(174, 77);
            this.BtnGüncelle.TabIndex = 17;
            this.BtnGüncelle.Text = "GÜNCELLE";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(201, 572);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(183, 77);
            this.BtnSil.TabIndex = 16;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // TbAdet
            // 
            this.TbAdet.Location = new System.Drawing.Point(161, 287);
            this.TbAdet.Name = "TbAdet";
            this.TbAdet.Size = new System.Drawing.Size(163, 22);
            this.TbAdet.TabIndex = 15;
            // 
            // TbFiyat
            // 
            this.TbFiyat.Location = new System.Drawing.Point(161, 250);
            this.TbFiyat.Name = "TbFiyat";
            this.TbFiyat.Size = new System.Drawing.Size(163, 22);
            this.TbFiyat.TabIndex = 14;
            this.TbFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFiyat_KeyPress);
            // 
            // TbAd
            // 
            this.TbAd.Location = new System.Drawing.Point(161, 215);
            this.TbAd.Name = "TbAd";
            this.TbAd.Size = new System.Drawing.Size(163, 22);
            this.TbAd.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "İlaç adı";
            // 
            // BtnGeri
            // 
            this.BtnGeri.Location = new System.Drawing.Point(12, 572);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(183, 77);
            this.BtnGeri.TabIndex = 19;
            this.BtnGeri.Text = "GERİ";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // TbYenilac
            // 
            this.TbYenilac.Location = new System.Drawing.Point(229, 107);
            this.TbYenilac.Name = "TbYenilac";
            this.TbYenilac.Size = new System.Drawing.Size(184, 22);
            this.TbYenilac.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "İLAC TÜRÜ";
            // 
            // DtUretim
            // 
            this.DtUretim.Location = new System.Drawing.Point(497, 216);
            this.DtUretim.Name = "DtUretim";
            this.DtUretim.Size = new System.Drawing.Size(335, 22);
            this.DtUretim.TabIndex = 22;
            // 
            // DtSonKullanim
            // 
            this.DtSonKullanim.Location = new System.Drawing.Point(497, 255);
            this.DtSonKullanim.Name = "DtSonKullanim";
            this.DtSonKullanim.Size = new System.Drawing.Size(335, 22);
            this.DtSonKullanim.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Üretim Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Son Kullanım Tarihi";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.BtnTurEkle);
            this.groupBox1.Controls.Add(this.CbilacTur);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbYenilac);
            this.groupBox1.Location = new System.Drawing.Point(432, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 244);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "YENİ İLAC TÜRÜ";
            // 
            // BtnTurEkle
            // 
            this.BtnTurEkle.Location = new System.Drawing.Point(214, 173);
            this.BtnTurEkle.Name = "BtnTurEkle";
            this.BtnTurEkle.Size = new System.Drawing.Size(199, 65);
            this.BtnTurEkle.TabIndex = 23;
            this.BtnTurEkle.Text = "Yeni İlac Türü Ekle";
            this.BtnTurEkle.UseVisualStyleBackColor = true;
            this.BtnTurEkle.Click += new System.EventHandler(this.BtnTurEkle_Click);
            // 
            // CbilacTur
            // 
            this.CbilacTur.FormattingEnabled = true;
            this.CbilacTur.Location = new System.Drawing.Point(229, 39);
            this.CbilacTur.Name = "CbilacTur";
            this.CbilacTur.Size = new System.Drawing.Size(184, 24);
            this.CbilacTur.TabIndex = 22;
            // 
            // IlacEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtSonKullanim);
            this.Controls.Add(this.DtUretim);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.TbAdet);
            this.Controls.Add(this.TbFiyat);
            this.Controls.Add(this.TbAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IlacEkran";
            this.Text = "IlacEkran";
            this.Load += new System.EventHandler(this.IlacEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox TbAdet;
        private System.Windows.Forms.TextBox TbFiyat;
        private System.Windows.Forms.TextBox TbAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.TextBox TbYenilac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtUretim;
        private System.Windows.Forms.DateTimePicker DtSonKullanim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnTurEkle;
        private System.Windows.Forms.ComboBox CbilacTur;
    }
}