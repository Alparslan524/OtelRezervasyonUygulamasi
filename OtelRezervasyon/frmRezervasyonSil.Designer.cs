
namespace OtelRezervasyon
{
    partial class frmRezervasyonSil
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
            this.veriTabaniProjeDataSet2 = new OtelRezervasyon.VeriTabaniProjeDataSet2();
            this.veriTabaniProjeDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRezervasyonSilTelNo = new System.Windows.Forms.TextBox();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniProjeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniProjeDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // veriTabaniProjeDataSet2
            // 
            this.veriTabaniProjeDataSet2.DataSetName = "VeriTabaniProjeDataSet2";
            this.veriTabaniProjeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veriTabaniProjeDataSet2BindingSource
            // 
            this.veriTabaniProjeDataSet2BindingSource.DataSource = this.veriTabaniProjeDataSet2;
            this.veriTabaniProjeDataSet2BindingSource.Position = 0;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Location = new System.Drawing.Point(299, 57);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(175, 32);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Sil";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Silmek İstediğiniz Rezervasyona Ait Telefon Numarasını Giriniz :";
            // 
            // txtRezervasyonSilTelNo
            // 
            this.txtRezervasyonSilTelNo.Location = new System.Drawing.Point(32, 69);
            this.txtRezervasyonSilTelNo.Name = "txtRezervasyonSilTelNo";
            this.txtRezervasyonSilTelNo.Size = new System.Drawing.Size(207, 20);
            this.txtRezervasyonSilTelNo.TabIndex = 4;
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.Red;
            this.btnAnaMenu.Location = new System.Drawing.Point(489, 34);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(176, 55);
            this.btnAnaMenu.TabIndex = 5;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // frmRezervasyonSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(732, 135);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.txtRezervasyonSilTelNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Name = "frmRezervasyonSil";
            this.Text = "Rezervasyon Sil";
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniProjeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniProjeDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource veriTabaniProjeDataSet2BindingSource;
        private VeriTabaniProjeDataSet2 veriTabaniProjeDataSet2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRezervasyonSilTelNo;
        private System.Windows.Forms.Button btnAnaMenu;
    }
}