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
    public partial class frmRezGuncelle : Form
    {
        public frmRezGuncelle()
        {
            InitializeComponent();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            frmCalisanEkran frmcalisanekran = new frmCalisanEkran();
            frmcalisanekran.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.TelNo = txtRezervasyonSilTelNo.Text;
            m.GeciciMusteriID = m.MusteriIDCekme(m);
            m.GirisTarih = DateTime.Parse(dateTimePickerGiris.Text);
            m.CikisTarih = DateTime.Parse(dateTimePickerCikis.Text);
            m.RezGuncelle(m);
            MessageBox.Show("Güncelleme tamamlanmıştır."+"\n"+"Ödeyeceğiniz ek ücret: "+m.OdenecekTutar);
            frmKrediKart frmkredikart = new frmKrediKart();
            frmkredikart.Show();
            this.Hide();






        }
    }
}
