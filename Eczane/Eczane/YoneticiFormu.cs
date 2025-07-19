using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczane
{
    public partial class YoneticiFormu : Form
    {

        

        public YoneticiFormu()
        {
            InitializeComponent();
            
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DUYGU\\SQLEXPRESS; Initial Catalog=ECZANE_APP; Integrated Security=True; Encrypt=True; TrustServerCertificate=True");


        private void yoneticiGetir()
        { 

        }

        private void btnOdemePlani_Click(object sender, EventArgs e)
        {
            OdemePlanFormu form = new OdemePlanFormu();
            form.Show();
            this.Hide();
        }

        private void btnIlacEkle_Click(object sender, EventArgs e)
        {
            IlacEkleFormu form = new IlacEkleFormu();
            form.Show();
            this.Hide();
        }

        private void btnPersonelKayit_Click(object sender, EventArgs e)
        {
            PersonelKayitFormu form = new PersonelKayitFormu();
            form.Show();
            this.Hide();
        }

        private void btnCıkış_Click(object sender, EventArgs e)
        {
            GirisFormu form = new GirisFormu();
            form.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
