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
    public class OnOdemeliRez : IRezAl
    {
        SqlConnection baglanti;
        SqlCommand komut;
        
        public OnOdemeliRez()
        {
            Baglan();
        }
        
        void Baglan()
        {
            baglanti = new SqlConnection("Data Source=MONSTERT7;Initial Catalog=VeriTabaniProje;Integrated Security=True");
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }

        public void RezAl(Musteri m)
        {
            TimeSpan fark;
            fark = DateTime.Parse(m.CikisTarih.ToString()) - DateTime.Parse(m.GirisTarih.ToString());

            try
            {
                baglanti.Open();
                komut.CommandText = ("declare @sayac int " +
                                     "declare @Dolumu bit " +
                                     "set @sayac=1 " +
                                     "while (@sayac<46) " +
                                     "begin " +
                                         "select @Dolumu = (select DoluMu from Tbl_Oda where ODAID=@sayac) " +
                                         "if(@Dolumu='0') " +
                                         "begin " +
                                             "update Tbl_Oda set OdenecekTutar=@pFiyat, RezNo=1,RezTarih=GETDATE(),GirisTarihi = @pGirisTarihi,CikisTarihi = @pCikisTarihi,MusteriID = @pMusteriID ,DoluMu='1' where ODAID = @sayac " +
                                             "break " +
                                         "end " +
                                        "select @sayac=@sayac+1 " +
                                     "end ");
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@pGirisTarihi", m.GirisTarih);
                komut.Parameters.AddWithValue("@pCikisTarihi", m.CikisTarih);
                komut.Parameters.AddWithValue("@pMusteriID", m.GeciciMusteriID);
                m.UcretCekme(m);
                m.OdenecekTutar =(m.OdenecekTutar * 75)/(100)*(fark.Days);
                komut.Parameters.AddWithValue("@pFiyat", m.OdenecekTutar);
                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "OnÖdemeliRez'de bu hatayı aldınız");
            }
            finally
            {
                if (baglanti!=null)
                {
                    baglanti.Close();
                }
            }
            MessageBox.Show("Rezervasyon türünüz Ön Ödemelidir."+"\n"+"Ödenecek Tutar: "+m.OdenecekTutar+"\n"+"Ödeme Sayfasına Aktarılıyorsunuz");
            m.UcretOdeme(m);
            
        
        }
    }
}
