
namespace OtelRezervasyon
{
    partial class frmOdaAyarları
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtTabanFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblOdaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veriTabaniProjeDataSet = new OtelRezervasyon.VeriTabaniProjeDataSet();
            this.tbl_OdaTableAdapter = new OtelRezervasyon.VeriTabaniProjeDataSetTableAdapters.Tbl_OdaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblOdaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniProjeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Location = new System.Drawing.Point(12, 38);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(319, 39);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtTabanFiyat
            // 
            this.txtTabanFiyat.Location = new System.Drawing.Point(114, 12);
            this.txtTabanFiyat.Name = "txtTabanFiyat";
            this.txtTabanFiyat.Size = new System.Drawing.Size(217, 20);
            this.txtTabanFiyat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Taban Fiyat:";
            // 
            // tblOdaBindingSource
            // 
            this.tblOdaBindingSource.DataMember = "Tbl_Oda";
            this.tblOdaBindingSource.DataSource = this.veriTabaniProjeDataSet;
            // 
            // veriTabaniProjeDataSet
            // 
            this.veriTabaniProjeDataSet.DataSetName = "VeriTabaniProjeDataSet";
            this.veriTabaniProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_OdaTableAdapter
            // 
            this.tbl_OdaTableAdapter.ClearBeforeFill = true;
            // 
            // frmOdaAyarları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(386, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTabanFiyat);
            this.Controls.Add(this.btnGuncelle);
            this.Name = "frmOdaAyarları";
            this.Text = "Taban Fiyat";
            ((System.ComponentModel.ISupportInitialize)(this.tblOdaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniProjeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtTabanFiyat;
        private System.Windows.Forms.Label label1;
        private VeriTabaniProjeDataSet veriTabaniProjeDataSet;
        private System.Windows.Forms.BindingSource tblOdaBindingSource;
        private VeriTabaniProjeDataSetTableAdapters.Tbl_OdaTableAdapter tbl_OdaTableAdapter;
    }
}