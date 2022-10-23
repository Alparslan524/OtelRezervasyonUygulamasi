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
    public partial class frmKrediKart : Form
    {
        public frmKrediKart()
        {
            InitializeComponent();
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödeme Yapıldı!!");
            frmCalisanEkran frmcalisanekran = new frmCalisanEkran();
            frmcalisanekran.Show();
            this.Hide();
        }
    }
}
