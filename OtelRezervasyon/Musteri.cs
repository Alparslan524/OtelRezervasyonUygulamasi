using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace OtelRezervasyon
{
    public class Musteri
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader oku;
        public Musteri()
        {
            Baglan();
        }

        void Baglan()
        {
            baglanti = new SqlConnection("Data Source=MONSTERT7;Initial Catalog=VeriTabaniProje;Integrated Security=True");
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }

        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TelNo { get; set; }
        public string EPosta { get; set; }
        public int GeciciMusteriID { get; set; }
        public float OdenecekTutar { get; set; }
        public float AnaPara { get; set; }
        public DateTime GirisTarih { get; set; }
        public DateTime CikisTarih { get; set; }


        public int MusteriIDCekme(Musteri m)
        {
            try
            {
                baglanti.Open();
                komut.CommandText = ("select MusteriID from Tbl_Musteri where Iletisim=@pIletisimbir");
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@pIletisimbir", m.TelNo);
                oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    m.GeciciMusteriID = Convert.ToInt32(oku["MusteriID"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "MusteriID okuma sırasında bu hatayı aldınız.");
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();

                }
            }

            return m.GeciciMusteriID;
        }

        public void MusteriKaydet(Musteri m)
        {
            try
            {
                baglanti.Open();
                komut.CommandText = ("insert into Tbl_Musteri  values (@pMusteriAd,@pMusteriSoyad,@pIletisim,@pEPosta)");
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@pMusteriAd", m.Isim);
                komut.Parameters.AddWithValue("@pMusteriSoyad", m.Soyisim);
                komut.Parameters.AddWithValue("@pIletisim", m.TelNo);
                komut.Parameters.AddWithValue("@pEPosta", m.EPosta);
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Musteri Kaydederken bu hatayı aldınız");
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }


        }

        public void UcretCekme(Musteri m)
        {
            try
            {
                baglanti.Open();
                komut.CommandText = ("select TbnFiyat from Tbl_Oda where ODAID=1 ");
                komut.CommandType = CommandType.Text;
                oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    m.OdenecekTutar = Convert.ToInt32(oku["TbnFiyat"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "TabanFiyat çekme sırasında hata aldınız");
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }

        public void UcretOdeme(Musteri m)
        {

            try
            {
                baglanti.Open();
                komut.CommandText = ("select * from Tbl_AnaPara ");
                komut.CommandType = CommandType.Text;
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    m.AnaPara = Convert.ToInt32(oku["AnaPara"]);
                }


                SqlConnection baglanti1 = new SqlConnection("Data Source=MONSTERT7;Initial Catalog=VeriTabaniProje;Integrated Security=True");
                SqlCommand komut1 = new SqlCommand();
                komut1.Connection = baglanti1;
                baglanti1.Open();
                m.AnaPara = m.OdenecekTutar + m.AnaPara;
                komut1.CommandText = ("update Tbl_AnaPara set AnaPara=@pAnaPara");
                komut1.CommandType = CommandType.Text;
                komut1.Parameters.AddWithValue("@pAnaPara", m.AnaPara);
                komut1.ExecuteReader();
                baglanti1.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Ucret Odeme sırasında bu hatayı aldınız");
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }


        }

        public void RezSil(Musteri m)
        {
            try
            {
                baglanti.Open();
                komut.CommandText = ("update Tbl_Oda set OdenecekTutar=NULL,RezNo=NULL,RezTarih=NULL,GirisTarihi=NULL,CikisTarihi=NULL,MusteriID=NULL,DoluMu='False' where MusteriID=@pMusteriID");
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@pMusteriID", m.GeciciMusteriID);
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Rezsilerken bu hatayı aldınız");
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }

        }

        public void MusteriSil(Musteri m)
        {
            try
            {
                baglanti.Open();
                komut.CommandText = ("delete from Tbl_Musteri where MusteriID=@pMusteriIDaa");
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@pMusteriIDaa", m.GeciciMusteriID);
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Musteri silerken bu hatayı aldınız");
            }
            finally
            {
                if (baglanti != null)
                {
                    baglanti.Close();
                }
            }

        }

        public void RezGuncelle(Musteri m)
        {
            try
            {
                SqlConnection baglanti2;
                SqlCommand komut2;
                
                baglanti2 = new SqlConnection("Data Source=MONSTERT7;Initial Catalog=VeriTabaniProje;Integrated Security=True");
                komut2 = new SqlCommand();
                komut2.Connection = baglanti2;

                TimeSpan fark;
                fark = DateTime.Parse(m.CikisTarih.ToString()) - DateTime.Parse(m.GirisTarih.ToString());
                baglanti2.Open();
                komut2.CommandText = ("update Tbl_Oda set OdenecekTutar=(@pFark*(110)/(100)*TbnFiyat),RezTarih=GETDATE(),GirisTarihi=@pGirisTarih,CikisTarihi=@pCikisTarih where MusteriID=@pMusteriID");
                komut2.CommandType = CommandType.Text;
                komut2.Parameters.AddWithValue("@pFark", fark.Days);
                komut2.Parameters.AddWithValue("@pGirisTarih", m.GirisTarih);
                komut2.Parameters.AddWithValue("@pCikisTarih", m.CikisTarih);
                komut2.Parameters.AddWithValue("@pMusteriID", m.GeciciMusteriID);
                komut2.ExecuteNonQuery();
                m.UcretCekme(m);
                m.OdenecekTutar = m.OdenecekTutar * (110) / (100);
                m.UcretOdeme(m);
                baglanti2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Rezgüncelle bu hatayı aldınız");
            }
        }
    }
}
