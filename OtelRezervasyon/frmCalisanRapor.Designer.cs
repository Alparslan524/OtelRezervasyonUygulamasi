
namespace OtelRezervasyon
{
    partial class frmCalisanRapor
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
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.müşteriİsmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervasyonAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaNumarasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.çıkışTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunlukGelenlerRaporuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veriTabaniProjeDataSet5 = new OtelRezervasyon.VeriTabaniProjeDataSet5();
            this.label1 = new System.Windows.Forms.Label();
            this.fillBy2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.gunlukGelenlerRaporuTableAdapter = new OtelRezervasyon.VeriTabaniProjeDataSet5TableAdapters.GunlukGelenlerRaporuTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukGelenlerRaporuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniProjeDataSet5)).BeginInit();
            this.fillBy2ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.BackColor = System.Drawing.Color.Red;
            this.btnAnaMenu.Location = new System.Drawing.Point(380, 251);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(119, 50);
            this.btnAnaMenu.TabIndex = 0;
            this.btnAnaMenu.Text = "Ana Menü";
            this.btnAnaMenu.UseVisualStyleBackColor = false;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
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
            this.müşteriİsmiDataGridViewTextBoxColumn,
            this.rezervasyonAdıDataGridViewTextBoxColumn,
            this.odaNumarasıDataGridViewTextBoxColumn,
            this.çıkışTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gunlukGelenlerRaporuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(395, 173);
            this.dataGridView1.TabIndex = 1;
            // 
            // müşteriİsmiDataGridViewTextBoxColumn
            // 
            this.müşteriİsmiDataGridViewTextBoxColumn.DataPropertyName = "Müşteri İsmi";
            this.müşteriİsmiDataGridViewTextBoxColumn.HeaderText = "Müşteri İsmi";
            this.müşteriİsmiDataGridViewTextBoxColumn.Name = "müşteriİsmiDataGridViewTextBoxColumn";
            this.müşteriİsmiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rezervasyonAdıDataGridViewTextBoxColumn
            // 
            this.rezervasyonAdıDataGridViewTextBoxColumn.DataPropertyName = "Rezervasyon Adı";
            this.rezervasyonAdıDataGridViewTextBoxColumn.HeaderText = "Rezervasyon Adı";
            this.rezervasyonAdıDataGridViewTextBoxColumn.Name = "rezervasyonAdıDataGridViewTextBoxColumn";
            this.rezervasyonAdıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odaNumarasıDataGridViewTextBoxColumn
            // 
            this.odaNumarasıDataGridViewTextBoxColumn.DataPropertyName = "Oda Numarası";
            this.odaNumarasıDataGridViewTextBoxColumn.HeaderText = "Oda Numarası";
            this.odaNumarasıDataGridViewTextBoxColumn.Name = "odaNumarasıDataGridViewTextBoxColumn";
            this.odaNumarasıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // çıkışTarihiDataGridViewTextBoxColumn
            // 
            this.çıkışTarihiDataGridViewTextBoxColumn.DataPropertyName = "Çıkış Tarihi";
            this.çıkışTarihiDataGridViewTextBoxColumn.HeaderText = "Çıkış Tarihi";
            this.çıkışTarihiDataGridViewTextBoxColumn.Name = "çıkışTarihiDataGridViewTextBoxColumn";
            this.çıkışTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gunlukGelenlerRaporuBindingSource
            // 
            this.gunlukGelenlerRaporuBindingSource.DataMember = "GunlukGelenlerRaporu";
            this.gunlukGelenlerRaporuBindingSource.DataSource = this.veriTabaniProjeDataSet5;
            // 
            // veriTabaniProjeDataSet5
            // 
            this.veriTabaniProjeDataSet5.DataSetName = "VeriTabaniProjeDataSet5";
            this.veriTabaniProjeDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(116, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Günlük Gelenler Raporu";
            // 
            // fillBy2ToolStrip
            // 
            this.fillBy2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy2ToolStripButton});
            this.fillBy2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy2ToolStrip.Name = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Size = new System.Drawing.Size(892, 28);
            this.fillBy2ToolStrip.TabIndex = 3;
            this.fillBy2ToolStrip.Text = "fillBy2ToolStrip";
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(53, 25);
            this.fillBy2ToolStripButton.Text = "Sırala";
            this.fillBy2ToolStripButton.Click += new System.EventHandler(this.fillBy2ToolStripButton_Click);
            // 
            // gunlukGelenlerRaporuTableAdapter
            // 
            this.gunlukGelenlerRaporuTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(471, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(419, 173);
            this.dataGridView2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(600, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Günlük Doluluk Oranı";
            // 
            // frmCalisanRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(892, 339);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.fillBy2ToolStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAnaMenu);
            this.Name = "frmCalisanRapor";
            this.Text = "Çalışan Rapor Ekranı";
            this.Load += new System.EventHandler(this.frmCalisanRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunlukGelenlerRaporuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veriTabaniProjeDataSet5)).EndInit();
            this.fillBy2ToolStrip.ResumeLayout(false);
            this.fillBy2ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private VeriTabaniProjeDataSet5 veriTabaniProjeDataSet5;
        private System.Windows.Forms.BindingSource gunlukGelenlerRaporuBindingSource;
        private VeriTabaniProjeDataSet5TableAdapters.GunlukGelenlerRaporuTableAdapter gunlukGelenlerRaporuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriİsmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervasyonAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaNumarasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn çıkışTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
    }
}