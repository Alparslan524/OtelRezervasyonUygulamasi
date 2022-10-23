using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtelRezervasyon
{
    public partial class frmCalisanAyarlari : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=MONSTERT7;Initial Catalog=VeriTabaniProje;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adap = new SqlDataAdapter();
        DataSet dts = new DataSet();

        public frmCalisanAyarlari()
        {
            InitializeComponent();
        }

       

        private void btnAnaMEnu_Click(object sender, EventArgs e)
        {
            frmYonetici frmyonetici = new frmYonetici();
            frmyonetici.Show();
            this.Hide();
        } 
        
        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            calısanAyarları ek = new calısanAyarları();
            ek.Ekle(txtCalisanİsim,txtCalisanSoyisim,txtCalısanSifre,txtKullaniciAdi);
        }

        public void gridView()
        {
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Tbl_Calisan";
            adap = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adap.Fill(tbl);
            dataGridView1.DataSource = tbl;


        }
        private void btnCalisanListele_Click(object sender, EventArgs e)
        {
            gridView();
        }

       
    }
}
