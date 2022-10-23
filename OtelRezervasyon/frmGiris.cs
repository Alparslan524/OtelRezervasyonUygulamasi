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
    public partial class frmGiris : Form
    {
        // girisSorgusu sınıfıdan nesne
        girisSorgusu giris = new girisSorgusu();
       
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == string.Empty || txtSifre.Text == string.Empty)
            {
                MessageBox.Show("Lütfen bilgileri giriniz.", "Hata");
            }

            else
            {
                if (comboBoxCalisan.Text == "Seçiniz...")
                {
                    MessageBox.Show("Çalışan türü seçiniz", "Hata");
                }
                else
                {
                    if (comboBoxCalisan.Text == "Yönetici")
                    {
                        //giris referansından yoneticiGirisSorgu fonk. cagrısı
                        giris.yoneticiGirisSorgu(txtKullaniciAdi,txtSifre);
                        this.Hide();
                    }
                    if (comboBoxCalisan.Text == "Çalışan")
                    {
                        //giris referansından empGirisSorgu fonk. cagrısı
                        giris.empGirisSorgu(txtKullaniciAdi, txtSifre);
                        this.Hide();
                    }
                }
            }
        }
    }
}
