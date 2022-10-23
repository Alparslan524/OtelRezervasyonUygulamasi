
namespace OtelRezervasyon
{
    partial class frmRezGuncelle
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
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.txtRezervasyonSilTelNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dateTimePickerGiris = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCikis = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.Red;
            this.btnAnaMenu.Location = new System.Drawing.Point(332, 132);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(154, 65);
            this.btnAnaMenu.TabIndex = 9;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // txtRezervasyonSilTelNo
            // 
            this.txtRezervasyonSilTelNo.Location = new System.Drawing.Point(468, 20);
            this.txtRezervasyonSilTelNo.Name = "txtRezervasyonSilTelNo";
            this.txtRezervasyonSilTelNo.Size = new System.Drawing.Size(223, 20);
            this.txtRezervasyonSilTelNo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Silmek İstediğiniz Rezervasyona Ait Telefon Numarasını Giriniz :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Location = new System.Drawing.Point(468, 55);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(223, 46);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dateTimePickerGiris
            // 
            this.dateTimePickerGiris.Location = new System.Drawing.Point(129, 55);
            this.dateTimePickerGiris.Name = "dateTimePickerGiris";
            this.dateTimePickerGiris.Size = new System.Drawing.Size(306, 20);
            this.dateTimePickerGiris.TabIndex = 10;
            // 
            // dateTimePickerCikis
            // 
            this.dateTimePickerCikis.Location = new System.Drawing.Point(129, 81);
            this.dateTimePickerCikis.Name = "dateTimePickerCikis";
            this.dateTimePickerCikis.Size = new System.Drawing.Size(306, 20);
            this.dateTimePickerCikis.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(35, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Çıkış Tarihi :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Giriş Tarihi :";
            // 
            // frmRezGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(765, 234);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dateTimePickerCikis);
            this.Controls.Add(this.dateTimePickerGiris);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.txtRezervasyonSilTelNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Name = "frmRezGuncelle";
            this.Text = "Rezervasyon Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.TextBox txtRezervasyonSilTelNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DateTimePicker dateTimePickerGiris;
        private System.Windows.Forms.DateTimePicker dateTimePickerCikis;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}