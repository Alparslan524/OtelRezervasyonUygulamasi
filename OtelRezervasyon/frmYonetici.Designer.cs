
namespace OtelRezervasyon
{
    partial class frmYonetici
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
            this.btnYoneticiRapor = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnYoneticiOda = new System.Windows.Forms.Button();
            this.btnYoneticiCalisanAyarlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYoneticiRapor
            // 
            this.btnYoneticiRapor.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnYoneticiRapor.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYoneticiRapor.Location = new System.Drawing.Point(89, 138);
            this.btnYoneticiRapor.Name = "btnYoneticiRapor";
            this.btnYoneticiRapor.Size = new System.Drawing.Size(167, 31);
            this.btnYoneticiRapor.TabIndex = 0;
            this.btnYoneticiRapor.Text = "Rapor";
            this.btnYoneticiRapor.UseVisualStyleBackColor = false;
            this.btnYoneticiRapor.Click += new System.EventHandler(this.btnYoneticiRapor_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Location = new System.Drawing.Point(89, 195);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(167, 50);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnYoneticiOda
            // 
            this.btnYoneticiOda.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnYoneticiOda.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYoneticiOda.Location = new System.Drawing.Point(89, 41);
            this.btnYoneticiOda.Name = "btnYoneticiOda";
            this.btnYoneticiOda.Size = new System.Drawing.Size(167, 30);
            this.btnYoneticiOda.TabIndex = 0;
            this.btnYoneticiOda.Text = "Oda Ayarları";
            this.btnYoneticiOda.UseVisualStyleBackColor = false;
            this.btnYoneticiOda.Click += new System.EventHandler(this.btnYoneticiOda_Click);
            // 
            // btnYoneticiCalisanAyarlar
            // 
            this.btnYoneticiCalisanAyarlar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnYoneticiCalisanAyarlar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYoneticiCalisanAyarlar.Location = new System.Drawing.Point(89, 90);
            this.btnYoneticiCalisanAyarlar.Name = "btnYoneticiCalisanAyarlar";
            this.btnYoneticiCalisanAyarlar.Size = new System.Drawing.Size(167, 30);
            this.btnYoneticiCalisanAyarlar.TabIndex = 0;
            this.btnYoneticiCalisanAyarlar.Text = "Çalışan Ayarları";
            this.btnYoneticiCalisanAyarlar.UseVisualStyleBackColor = false;
            this.btnYoneticiCalisanAyarlar.Click += new System.EventHandler(this.btnYoneticiCalisanAyarlar_Click);
            // 
            // frmYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(353, 293);
            this.Controls.Add(this.btnYoneticiCalisanAyarlar);
            this.Controls.Add(this.btnYoneticiOda);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnYoneticiRapor);
            this.Name = "frmYonetici";
            this.Text = "Yönetici Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYoneticiRapor;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnYoneticiOda;
        private System.Windows.Forms.Button btnYoneticiCalisanAyarlar;
    }
}