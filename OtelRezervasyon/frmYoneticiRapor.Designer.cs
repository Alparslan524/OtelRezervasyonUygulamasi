
namespace OtelRezervasyon
{
    partial class frmYoneticiRapor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ayİçindekiRezervasyonSayısıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervasyonTipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beklenenDolulukraporuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veriTabaniProjeDataSet3 = new OtelRezervasyon.VeriTabaniProjeDataSet3();
            this.beklenenDolulukraporuTableAdapter = new OtelRezervasyon.VeriTabaniProjeDataSet3TableAdapters.BeklenenDolulukraporuTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.günİçindekiGelirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.günİçindekiOrtalamaGelirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beklenenOdaGelirRaporuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veriTabaniProjeDataSet4 = new OtelRezervasyon.VeriTabaniProjeDataSet4();
            this.beklenenOdaGelirRaporuTableAdapter = new OtelRezervasyon.VeriTabaniProjeDataSet4TableAdapters.BeklenenOdaGelirRaporuTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beklenenDolulukraporuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniProjeDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beklenenOdaGelirRaporuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniProjeDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ayİçindekiRezervasyonSayısıDataGridViewTextBoxColumn,
            this.rezervasyonTipiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.beklenenDolulukraporuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(368, 146);
            this.dataGridView1.TabIndex = 0;
            // 
            // ayİçindekiRezervasyonSayısıDataGridViewTextBoxColumn
            // 
            this.ayİçindekiRezervasyonSayısıDataGridViewTextBoxColumn.DataPropertyName = "1 Ay içindeki Rezervasyon Sayısı";
            this.ayİçindekiRezervasyonSayısıDataGridViewTextBoxColumn.HeaderText = "1 Ay içindeki Rezervasyon Sayısı";
            this.ayİçindekiRezervasyonSayısıDataGridViewTextBoxColumn.Name = "ayİçindekiRezervasyonSayısıDataGridViewTextBoxColumn";
            this.ayİçindekiRezervasyonSayısıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rezervasyonTipiDataGridViewTextBoxColumn
            // 
            this.rezervasyonTipiDataGridViewTextBoxColumn.DataPropertyName = "Rezervasyon tipi";
            this.rezervasyonTipiDataGridViewTextBoxColumn.HeaderText = "Rezervasyon tipi";
            this.rezervasyonTipiDataGridViewTextBoxColumn.Name = "rezervasyonTipiDataGridViewTextBoxColumn";
            this.rezervasyonTipiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beklenenDolulukraporuBindingSource
            // 
            this.beklenenDolulukraporuBindingSource.DataMember = "BeklenenDolulukraporu";
            this.beklenenDolulukraporuBindingSource.DataSource = this.veriTabaniProjeDataSet3;
            // 
            // veriTabaniProjeDataSet3
            // 
            this.veriTabaniProjeDataSet3.DataSetName = "VeriTabaniProjeDataSet3";
            this.veriTabaniProjeDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beklenenDolulukraporuTableAdapter
            // 
            this.beklenenDolulukraporuTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Önümüzdeki 1 ay içindeki Doluluk sayısı";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tarihDataGridViewTextBoxColumn,
            this.günİçindekiGelirDataGridViewTextBoxColumn,
            this.günİçindekiOrtalamaGelirDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.beklenenOdaGelirRaporuBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(411, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(377, 146);
            this.dataGridView2.TabIndex = 2;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // günİçindekiGelirDataGridViewTextBoxColumn
            // 
            this.günİçindekiGelirDataGridViewTextBoxColumn.DataPropertyName = "30 Gün İçindeki Gelir";
            this.günİçindekiGelirDataGridViewTextBoxColumn.HeaderText = "30 Gün İçindeki Gelir";
            this.günİçindekiGelirDataGridViewTextBoxColumn.Name = "günİçindekiGelirDataGridViewTextBoxColumn";
            this.günİçindekiGelirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // günİçindekiOrtalamaGelirDataGridViewTextBoxColumn
            // 
            this.günİçindekiOrtalamaGelirDataGridViewTextBoxColumn.DataPropertyName = "30 Gün İçindeki Ortalama Gelir ";
            this.günİçindekiOrtalamaGelirDataGridViewTextBoxColumn.HeaderText = "30 Gün İçindeki Ortalama Gelir ";
            this.günİçindekiOrtalamaGelirDataGridViewTextBoxColumn.Name = "günİçindekiOrtalamaGelirDataGridViewTextBoxColumn";
            this.günİçindekiOrtalamaGelirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beklenenOdaGelirRaporuBindingSource
            // 
            this.beklenenOdaGelirRaporuBindingSource.DataMember = "BeklenenOdaGelirRaporu";
            this.beklenenOdaGelirRaporuBindingSource.DataSource = this.veriTabaniProjeDataSet4;
            // 
            // veriTabaniProjeDataSet4
            // 
            this.veriTabaniProjeDataSet4.DataSetName = "VeriTabaniProjeDataSet4";
            this.veriTabaniProjeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // beklenenOdaGelirRaporuTableAdapter
            // 
            this.beklenenOdaGelirRaporuTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(451, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Önümüzdeki 1 ay içindeki Gelir Raporu\r\n\r\n";
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.Red;
            this.btnAnaMenu.Location = new System.Drawing.Point(358, 168);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(87, 28);
            this.btnAnaMenu.TabIndex = 3;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // frmYoneticiRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(808, 221);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmYoneticiRapor";
            this.Text = "Yönetici Rapor";
            this.Load += new System.EventHandler(this.frmYoneticiRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beklenenDolulukraporuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniProjeDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beklenenOdaGelirRaporuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniProjeDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private VeriTabaniProjeDataSet3 veriTabaniProjeDataSet3;
        private System.Windows.Forms.BindingSource beklenenDolulukraporuBindingSource;
        private VeriTabaniProjeDataSet3TableAdapters.BeklenenDolulukraporuTableAdapter beklenenDolulukraporuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayİçindekiRezervasyonSayısıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervasyonTipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private VeriTabaniProjeDataSet4 veriTabaniProjeDataSet4;
        private System.Windows.Forms.BindingSource beklenenOdaGelirRaporuBindingSource;
        private VeriTabaniProjeDataSet4TableAdapters.BeklenenOdaGelirRaporuTableAdapter beklenenOdaGelirRaporuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn günİçindekiGelirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn günİçindekiOrtalamaGelirDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnaMenu;
    }
}