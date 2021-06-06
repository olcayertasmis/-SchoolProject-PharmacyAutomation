
namespace Eczane_Otomasyonu
{
    partial class HastaEkran
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbAd = new System.Windows.Forms.TextBox();
            this.TbSoyad = new System.Windows.Forms.TextBox();
            this.TbTc = new System.Windows.Forms.TextBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TbTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbAdres = new System.Windows.Forms.RichTextBox();
            this.BtnGeri = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "T.C ";
            // 
            // TbAd
            // 
            this.TbAd.Location = new System.Drawing.Point(415, 201);
            this.TbAd.Name = "TbAd";
            this.TbAd.Size = new System.Drawing.Size(100, 22);
            this.TbAd.TabIndex = 4;
            // 
            // TbSoyad
            // 
            this.TbSoyad.Location = new System.Drawing.Point(415, 236);
            this.TbSoyad.Name = "TbSoyad";
            this.TbSoyad.Size = new System.Drawing.Size(100, 22);
            this.TbSoyad.TabIndex = 5;
            // 
            // TbTc
            // 
            this.TbTc.Location = new System.Drawing.Point(415, 273);
            this.TbTc.MaxLength = 11;
            this.TbTc.Name = "TbTc";
            this.TbTc.Size = new System.Drawing.Size(100, 22);
            this.TbTc.TabIndex = 6;
            this.TbTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTc_KeyPress);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(153, 463);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(120, 44);
            this.BtnSil.TabIndex = 7;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(526, 463);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(111, 44);
            this.BtnGüncelle.TabIndex = 8;
            this.BtnGüncelle.Text = "GÜNCELLE";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(681, 463);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(107, 44);
            this.BtnKaydet.TabIndex = 9;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TbTel
            // 
            this.TbTel.Location = new System.Drawing.Point(415, 310);
            this.TbTel.MaxLength = 10;
            this.TbTel.Name = "TbTel";
            this.TbTel.Size = new System.Drawing.Size(100, 22);
            this.TbTel.TabIndex = 12;
            this.TbTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTc_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefon";
            // 
            // TbAdres
            // 
            this.TbAdres.Location = new System.Drawing.Point(415, 347);
            this.TbAdres.Name = "TbAdres";
            this.TbAdres.Size = new System.Drawing.Size(100, 96);
            this.TbAdres.TabIndex = 14;
            this.TbAdres.Text = "";
            // 
            // BtnGeri
            // 
            this.BtnGeri.Location = new System.Drawing.Point(12, 463);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(120, 44);
            this.BtnGeri.TabIndex = 15;
            this.BtnGeri.Text = "GERİ";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // HastaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.TbAdres);
            this.Controls.Add(this.TbTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.TbTc);
            this.Controls.Add(this.TbSoyad);
            this.Controls.Add(this.TbAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HastaEkran";
            this.Text = "MÜŞTERİ BİLGİLERİ";
            this.Load += new System.EventHandler(this.HastaEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbAd;
        private System.Windows.Forms.TextBox TbSoyad;
        private System.Windows.Forms.TextBox TbTc;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TbTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox TbAdres;
        private System.Windows.Forms.Button BtnGeri;
    }
}