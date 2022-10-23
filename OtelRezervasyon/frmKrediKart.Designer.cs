
namespace OtelRezervasyon
{
    partial class frmKrediKart
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
            this.txtKrediKartıNumarasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSonKullanmaTarihi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKrediKartıNumarasi
            // 
            this.txtKrediKartıNumarasi.Location = new System.Drawing.Point(162, 47);
            this.txtKrediKartıNumarasi.Name = "txtKrediKartıNumarasi";
            this.txtKrediKartıNumarasi.Size = new System.Drawing.Size(209, 20);
            this.txtKrediKartıNumarasi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kredi Kartı Numarası";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(162, 84);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(209, 20);
            this.txtIsim.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(115, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsim";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(162, 122);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(209, 20);
            this.txtSoyisim.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(91, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyisim";
            // 
            // txtSonKullanmaTarihi
            // 
            this.txtSonKullanmaTarihi.Location = new System.Drawing.Point(157, 170);
            this.txtSonKullanmaTarihi.Name = "txtSonKullanmaTarihi";
            this.txtSonKullanmaTarihi.Size = new System.Drawing.Size(54, 20);
            this.txtSonKullanmaTarihi.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(112, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "SKT";
            // 
            // txtCvv
            // 
            this.txtCvv.Location = new System.Drawing.Point(295, 170);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(76, 20);
            this.txtCvv.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(254, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "CVV";
            // 
            // btnOde
            // 
            this.btnOde.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnOde.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOde.Location = new System.Drawing.Point(134, 220);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(118, 39);
            this.btnOde.TabIndex = 2;
            this.btnOde.Text = "Öde";
            this.btnOde.UseVisualStyleBackColor = false;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // frmKrediKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(408, 304);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCvv);
            this.Controls.Add(this.txtSonKullanmaTarihi);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.txtKrediKartıNumarasi);
            this.Name = "frmKrediKart";
            this.Text = "Ödeme Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKrediKartıNumarasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSonKullanmaTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOde;
    }
}