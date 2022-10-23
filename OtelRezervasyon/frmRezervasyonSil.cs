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
    public partial class frmRezervasyonSil : Form
    {
        public frmRezervasyonSil()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.TelNo =txtRezervasyonSilTelNo.Text;
            m.GeciciMusteriID=m.MusteriIDCekme(m);
            m.RezSil(m);
            m.MusteriSil(m);
            MessageBox.Show("Müşteri Silindi");
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            frmCalisanEkran frmcalisanekran = new frmCalisanEkran();
            frmcalisanekran.Show();
            this.Hide();
        }
    }
}
