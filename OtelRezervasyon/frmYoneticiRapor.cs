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
    public partial class frmYoneticiRapor : Form
    {
        public frmYoneticiRapor()
        {
            InitializeComponent();
        }

        private void frmYoneticiRapor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veriTabaniProjeDataSet4.BeklenenOdaGelirRaporu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.beklenenOdaGelirRaporuTableAdapter.Fill(this.veriTabaniProjeDataSet4.BeklenenOdaGelirRaporu);
            // TODO: Bu kod satırı 'veriTabaniProjeDataSet3.BeklenenDolulukraporu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.beklenenDolulukraporuTableAdapter.Fill(this.veriTabaniProjeDataSet3.BeklenenDolulukraporu);

        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            frmYonetici frmyonetici = new frmYonetici();
            frmyonetici.Show();
            this.Hide();
        }
    }
}
