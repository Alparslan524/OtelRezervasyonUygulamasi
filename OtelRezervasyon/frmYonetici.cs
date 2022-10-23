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
    public partial class frmYonetici : Form
    {
        public frmYonetici()
        {
            InitializeComponent();
        }

        private void btnYoneticiOda_Click(object sender, EventArgs e)
        {
            frmOdaAyarları oda_ayar = new frmOdaAyarları();
            oda_ayar.Show();
        }

        private void btnYoneticiCalisanAyarlar_Click(object sender, EventArgs e)
        {
            frmCalisanAyarlari calisan_Ayarlari = new frmCalisanAyarlari();
            calisan_Ayarlari.Show();
            this.Hide();
        }

        private void btnYoneticiRapor_Click(object sender, EventArgs e)
        {
            frmYoneticiRapor frmyoneticirapor = new frmYoneticiRapor();
            frmyoneticirapor.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmGiris giris_Formu = new frmGiris();
            giris_Formu.Show();
            this.Hide();
        }
    }
}
