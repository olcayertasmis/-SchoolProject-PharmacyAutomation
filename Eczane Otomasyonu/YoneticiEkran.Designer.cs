
namespace Eczane_Otomasyonu
{
    partial class YoneticiEkran
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
            this.BtnLog = new System.Windows.Forms.Button();
            this.BtnIlac = new System.Windows.Forms.Button();
            this.BtnHasta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPersonel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLog
            // 
            this.BtnLog.Location = new System.Drawing.Point(85, 84);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.Size = new System.Drawing.Size(103, 38);
            this.BtnLog.TabIndex = 0;
            this.BtnLog.Text = "Log Kayıtları";
            this.BtnLog.UseVisualStyleBackColor = true;
            // 
            // BtnIlac
            // 
            this.BtnIlac.Location = new System.Drawing.Point(85, 154);
            this.BtnIlac.Name = "BtnIlac";
            this.BtnIlac.Size = new System.Drawing.Size(103, 37);
            this.BtnIlac.TabIndex = 1;
            this.BtnIlac.Text = "İlaç Bilgileri";
            this.BtnIlac.UseVisualStyleBackColor = true;
            // 
            // BtnHasta
            // 
            this.BtnHasta.Location = new System.Drawing.Point(85, 229);
            this.BtnHasta.Name = "BtnHasta";
            this.BtnHasta.Size = new System.Drawing.Size(103, 40);
            this.BtnHasta.TabIndex = 2;
            this.BtnHasta.Text = "Hasta Bilgileri";
            this.BtnHasta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yönetici Sayfasına Hoşgeldiniz";
            // 
            // BtnPersonel
            // 
            this.BtnPersonel.Location = new System.Drawing.Point(85, 295);
            this.BtnPersonel.Name = "BtnPersonel";
            this.BtnPersonel.Size = new System.Drawing.Size(103, 44);
            this.BtnPersonel.TabIndex = 4;
            this.BtnPersonel.Text = "Personel Bilgileri";
            this.BtnPersonel.UseVisualStyleBackColor = true;
            // 
            // YoneticiEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 391);
            this.Controls.Add(this.BtnPersonel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHasta);
            this.Controls.Add(this.BtnIlac);
            this.Controls.Add(this.BtnLog);
            this.Name = "YoneticiEkran";
            this.Text = "YoneticiEkran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLog;
        private System.Windows.Forms.Button BtnIlac;
        private System.Windows.Forms.Button BtnHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPersonel;
    }
}