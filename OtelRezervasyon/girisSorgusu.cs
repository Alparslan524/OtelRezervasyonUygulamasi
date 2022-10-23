using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data;

namespace OtelRezervasyon
{
    internal class girisSorgusu
    {
        

        SqlConnection conn = new SqlConnection("Data Source=MONSTERT7;Initial Catalog=VeriTabaniProje;Integrated Security=True");
        SqlCommand cmd ;
        SqlDataReader read ;
        
        // yönetici giriş sorgusu
        public SqlDataReader yoneticiGirisSorgu(TextBox kullanıcı_adı,TextBox sifre)
        {
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Tbl_Yonetici where YONETICIKULLANICI='" + kullanıcı_adı.Text + "' and YONETICISIFRE='" + sifre.Text + "'";
            cmd.CommandType = CommandType.Text;
            read = cmd.ExecuteReader();

            if (read.Read() == true)
            {

                frmGiris formgir = new frmGiris();
                MessageBox.Show("Giriş başarılı");
                frmYonetici frmyonetici = new frmYonetici();
                frmyonetici.Show();
                

            }

            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata");

            }

            conn.Close();

            return read;

        }


        // çalışan giriş sorgusu
        public SqlDataReader empGirisSorgu(TextBox kullanıcı_adı, TextBox sifre)
        {
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Tbl_Calisan where CalisanKullanici='" + kullanıcı_adı.Text + "' and CalisanSifre='" + sifre.Text + "'";
            cmd.CommandType = CommandType.Text;
            read = cmd.ExecuteReader();

            if (read.Read() == true)
            {
                frmGiris formgir = new frmGiris();
                MessageBox.Show("Giriş başarılı");
                frmCalisanEkran calısan = new frmCalisanEkran();
                calısan.Show();
            }

            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata");

            }

            conn.Close();

            return read;
        }
   
    }
}
