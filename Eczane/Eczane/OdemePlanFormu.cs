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
    public partial class OdemePlanFormu : Form
    {
        public OdemePlanFormu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DUYGU\\SQLEXPRESS; Initial Catalog=ECZANE_APP; Integrated Security=True; Encrypt=True; TrustServerCertificate=True");


        private void btnOdemePlanıGeri_Click(object sender, EventArgs e)
        {
            YoneticiFormu form = new YoneticiFormu();
            form.Show();
            this.Hide();
        }

        private void OdemePlanFormu_Load(object sender, EventArgs e)
        {
            btnOnayla.Enabled = true;
            btnOnayla.Visible = true;
            btnYeniOdeme.Enabled = false;
            btnYeniOdeme.Visible = false;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            
            List<string> secilenOdemeTipleri = new List<string>();

            if (chbNakit.Checked)
                secilenOdemeTipleri.Add("Nakit");
            if (chbHavaleEfet.Checked)
                secilenOdemeTipleri.Add("Havale/EFT");
            if (chbKart.Checked)
                secilenOdemeTipleri.Add("Banka/Kredi Kartı");
            if (chbQR.Checked)
                secilenOdemeTipleri.Add("QR");

            if (secilenOdemeTipleri.Count == 0)
            {
                MessageBox.Show("Lütfen bir ödeme şekli seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            baglanti.Open();
            foreach (string odemeTipi in secilenOdemeTipleri)
            {
                SqlCommand komut = new SqlCommand("INSERT INTO OdemeTipleri (OdemeTipi) VALUES (@odemetipi)", baglanti);
                komut.Parameters.AddWithValue("@odemetipi", odemeTipi);
                komut.ExecuteNonQuery();
            }
            baglanti.Close();

            
            string odemeTipleriMetni = string.Join("\n", secilenOdemeTipleri);
            MessageBox.Show("Seçilen Ödeme Şekilleri:\n" + odemeTipleriMetni, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnOnayla.Enabled = false;
            btnOnayla.Visible = false;
            btnYeniOdeme.Enabled = true;
            btnYeniOdeme.Visible = true;

        }


        

        private void btnYeniOdeme_Click(object sender, EventArgs e)
        {
          
            baglanti.Open();
            SqlCommand komut = new SqlCommand("TRUNCATE TABLE OdemeTipleri", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();


          
            MessageBox.Show("Yeni Ödeme Planı Oluştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            


            btnOnayla.Enabled = true;
            btnOnayla.Visible = true;
            btnYeniOdeme.Enabled = false;
            btnYeniOdeme.Visible = false;
        }
    }
}
