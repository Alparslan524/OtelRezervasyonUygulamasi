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
    public partial class frmCalisanEkran : Form
    {
       
        public frmCalisanEkran()
        {
            InitializeComponent();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            frmGiris giris_Formu = new frmGiris();
            giris_Formu.Show();
            this.Hide();
        }

        private void btnRezervasyonOlustur_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            TimeSpan fark;
            fark = DateTime.Parse(dateTimePickerGirisTarihi.Text) - DateTime.Now;

            musteri.Isim = txtIsim.Text;
            musteri.Soyisim = txtSoyisim.Text;
            musteri.TelNo = txtTelefon.Text;
            musteri.EPosta = txtEposta.Text;
            musteri.GirisTarih = DateTime.Parse(dateTimePickerGirisTarihi.Text);
            musteri.CikisTarih = DateTime.Parse(dateTimePickerCikisTarihi.Text);
            musteri.MusteriKaydet(musteri);
            musteri.GeciciMusteriID = musteri.MusteriIDCekme(musteri);

            frmKrediKart frmkredikart = new frmKrediKart();
           
            if (fark.Days>90)
            {
                OnOdemeliRez onOdemeliRez = new OnOdemeliRez();
                onOdemeliRez.RezAl(musteri);
                frmkredikart.Show();
                this.Hide();
            }
            else if (fark.Days>60 && fark.Days<90)
            {
                AltmisGunOncedenRez altmisGunOncedenRez = new AltmisGunOncedenRez();
                altmisGunOncedenRez.RezAl(musteri);
            }
            else if (fark.Days<60)
            {
                StandartRez standartRez = new StandartRez();
                standartRez.RezAl(musteri);
            }
           




        }

        private void btnRezervasyonIptal_Click(object sender, EventArgs e)
        {
            frmRezervasyonSil frmrezervasyonsil = new frmRezervasyonSil();
            frmrezervasyonsil.Show();
            this.Hide();

        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            frmCalisanRapor frmcalisanrapor = new frmCalisanRapor();
            frmcalisanrapor.Show();
            this.Hide();
        }

        private void btnRezGuncelle_Click(object sender, EventArgs e)
        {
            frmRezGuncelle frmrezguncelle = new frmRezGuncelle();
            frmrezguncelle.Show();
            this.Hide();
        }
    }
}
