using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace OtelRezervasyon
{
    internal class calısanAyarları
    {
        SqlConnection conn = new SqlConnection("Data Source=MONSTERT7;Initial Catalog=VeriTabaniProje;Integrated Security=True");
        SqlCommand cmd;
        
         

        //calısan ekleme sorgusu
        public void Ekle(TextBox name, TextBox surname, TextBox password, TextBox userName)
        {
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Tbl_Calisan(CALISANAD, CALISANSOYAD, CalisanSifre, CalisanKullanici) values('" + name.Text + "','" + surname.Text + "','" + password.Text + "','" + userName.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(name.Text +" "+ surname.Text+" "+ " İsimli Çalışan Sisteme Kaydı Gerçekleştirildi.");
        }
        
        
    }

}
