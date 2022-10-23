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
    public partial class frmOdaAyarları : Form
    {
        public frmOdaAyarları()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MONSTERT7;Initial Catalog=VeriTabaniProje;Integrated Security=True");
        int TabanFiyatı = 0;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTabanFiyat.Text == string.Empty)
            {
                MessageBox.Show("Lütfen fiyat giriniz.", "Hata");
            }
            else
            {
                //Taban fiyat veri tabanında güncellenecektir 
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Update Tbl_Oda set TbnFiyat=@P1", baglanti);
                
                cmd.Parameters.AddWithValue("@P1", txtTabanFiyat.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Taban fiyat güncellenmiştir.", "Fiyat");
                TabanFiyatı = Convert.ToInt32(txtTabanFiyat.Text);
                this.Close();
            }
        }

   
       

        //private void frmOdaAyarları_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'veriTabaniProjeDataSet.Tbl_Oda' table. You can move, or remove it, as needed.
        //    this.tbl_OdaTableAdapter.Fill(this.veriTabaniProjeDataSet.Tbl_Oda);

        //}

        
    }
}
