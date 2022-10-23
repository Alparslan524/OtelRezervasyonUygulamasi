using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyon
{
    public partial class frmCalisanRapor : Form
    {
        public frmCalisanRapor()
        {
            InitializeComponent();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            frmCalisanEkran frmcalisanekran = new frmCalisanEkran();
            frmcalisanekran.Show();
            this.Hide();
        }

        private void frmCalisanRapor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veriTabaniProjeDataSet5.GunlukGelenlerRaporu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gunlukGelenlerRaporuTableAdapter.Fill(this.veriTabaniProjeDataSet5.GunlukGelenlerRaporu);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gunlukGelenlerRaporuTableAdapter.FillBy(this.veriTabaniProjeDataSet5.GunlukGelenlerRaporu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gunlukGelenlerRaporuTableAdapter.FillBy1(this.veriTabaniProjeDataSet5.GunlukGelenlerRaporu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gunlukGelenlerRaporuTableAdapter.FillBy2(this.veriTabaniProjeDataSet5.GunlukGelenlerRaporu);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
