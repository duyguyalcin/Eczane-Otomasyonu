using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Eczane
{
    public partial class GirisFormu : Form
    {
        
        public GirisFormu()
        {
            InitializeComponent();
            
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DUYGU\\SQLEXPRESS; Initial Catalog=ECZANE_APP; Integrated Security=True; Encrypt=True; TrustServerCertificate=True");


        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            string YoneticiKullaniciAdi = txtYoneticiKullaniciAdi.Text.Trim();
            string YoneticiSifre = txtYoneticiSifre.Text.Trim();


            if (YoneticiKullaniciAdi == "" || YoneticiSifre == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            SqlCommand Komut = new SqlCommand("SELECT YoneticiID FROM Yonetici WHERE YoneticiKullaniciAdi = @yusername AND YoneticiSifre = @ypassword", baglanti);
            Komut.Parameters.AddWithValue("@yusername",YoneticiKullaniciAdi);
            Komut.Parameters.AddWithValue("@ypassword", YoneticiSifre);

            baglanti.Open();
            object sonuc = Komut.ExecuteScalar();
            baglanti.Close();

            if(sonuc != null)
            {
                Convert.ToInt32(sonuc);
                YoneticiFormu form = new YoneticiFormu();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }

        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {

            string PersoneliKullaniciAdi = txtPersonelKullaniciAdi.Text.Trim();
            string PersonelSifre = txtPersonelSifre.Text.Trim();


            if (PersoneliKullaniciAdi == "" || PersonelSifre == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            SqlCommand Komut = new SqlCommand("SELECT PersonelID FROM Personeller WHERE PersonelKullaniciAdi = @perusername AND PersonelSifre = @perpassword", baglanti);
            Komut.Parameters.AddWithValue("@perusername", PersoneliKullaniciAdi);
            Komut.Parameters.AddWithValue("@perpassword", PersonelSifre);

            baglanti.Open();
            object psonuc = Komut.ExecuteScalar();
            baglanti.Close();

            if (psonuc != null)
            {
                int girisYapanPersonelID = Convert.ToInt32(psonuc); // ✅ ID'yi al
                PersonelFormu form = new PersonelFormu(girisYapanPersonelID); // ✅ ID'yi gönder
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }


            
        }

        

    }
}
