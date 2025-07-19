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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Eczane
{
    public partial class SatisFormu : Form
    {

        private int _personelID;

        public SatisFormu(int personelID)
        {
            InitializeComponent();
            _personelID = personelID;
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DUYGU\\SQLEXPRESS; Initial Catalog=ECZANE_APP; Integrated Security=True; Encrypt=True; TrustServerCertificate=True");
        DataTable satisForm = new DataTable();
        DataTable eklenenIlaclar = new DataTable();

        bool isEditing = false;



        private void btnSatısGeri_Click(object sender, EventArgs e)
        {
            PersonelFormu form = new PersonelFormu(_personelID);
            form.Show();
            this.Hide();
        }

        private void SatisFormu_Load(object sender, EventArgs e)
        {
            satisForm.Columns.Add("IlacAdi", typeof(string));
            SonucView.DataSource = satisForm;


            eklenenIlaclar.Columns.Add("IlacID", typeof(int));
            eklenenIlaclar.Columns.Add("IlacAdi", typeof(string));
            eklenenIlaclar.Columns.Add("IlacFiyat", typeof(int));
            EklenenIlaclarView.DataSource = eklenenIlaclar;



            SonucView.CellContentClick += SonucView_CellContentClick;

            EklenenIlaclarView.CellDoubleClick += EklenenIlaclarView_CellDoubleClick;


            IlacGoruntule();

            OdemeTipleriniYukle();
        }


        private void IlacGoruntule()
        {
            satisForm.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ilaclar", baglanti);
            adapter.Fill(satisForm);
            SonucView.DataSource = satisForm;


        }


        private void txtilacAra_TextChanged(object sender, EventArgs e)
        {
            string filtre = txtilacAra.Text.Trim().Replace("'", "''"); // SQL injection önlemi

            // Sadece 'Ad' sütununa göre filtreleme yap
            (SonucView.DataSource as DataTable).DefaultView.RowFilter = $"IlacAdi LIKE '%{filtre}%'";

        }


        private void SonucView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow secilenSatir = SonucView.Rows[e.RowIndex];

                int ilacID = Convert.ToInt32(secilenSatir.Cells["IlacID"].Value);
                string ilacAdi = secilenSatir.Cells["IlacAdi"].Value.ToString();
                int ilacFiyat = Convert.ToInt32(secilenSatir.Cells["IlacFiyati"].Value);

                bool zatenEklendi = eklenenIlaclar.AsEnumerable()
                    .Any(row => row.Field<int>("IlacID") == ilacID);

                if (!zatenEklendi)
                {
                    eklenenIlaclar.Rows.Add(ilacID, ilacAdi, ilacFiyat);
                    ToplamFiyatHesapla(); // ✔ Fiyatı güncelle
                }
                else
                {
                    MessageBox.Show("Bu ilaç zaten eklendi!");
                }
            }


        }




        private void SonucView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EklenenIlaclarView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EklenenIlaclarView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DialogResult sonuc = MessageBox.Show("Bu ilacı silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo);
                if (sonuc == DialogResult.No)
                {
                    return;
                }

                DataGridViewRow secilenSatir = EklenenIlaclarView.Rows[e.RowIndex];
                int silinecekID = Convert.ToInt32(secilenSatir.Cells["IlacID"].Value);

                foreach (DataRow row in eklenenIlaclar.Rows)
                {
                    if (Convert.ToInt32(row["IlacID"]) == silinecekID)
                    {
                        eklenenIlaclar.Rows.Remove(row);
                        ToplamFiyatHesapla(); // ✔ Silince fiyatı güncelle
                        break;
                    }
                }
            }

        }


        private void btnSatıs_Click(object sender, EventArgs e)
        {
            string hastaTc = txtHastaTc.Text.Trim();
            DateTime tarih = dtpTarih.Value;
            string recete = txtRecete.Text.Trim();
            int secilenOdemeTipiID;

            if (cmbOdemeTipi.SelectedIndex == -1 || !int.TryParse(cmbOdemeTipi.SelectedValue?.ToString(), out secilenOdemeTipiID))
            {
                MessageBox.Show("Lütfen bir ödeme tipi seçiniz!");
                return;
            }

            int hastaID = -1;
            using (SqlCommand komut = new SqlCommand("SELECT HastaID FROM Hastalar WHERE HastaTc = @tc", baglanti))
            {
                komut.Parameters.AddWithValue("@tc", hastaTc);

                baglanti.Open();
                object sonuc = komut.ExecuteScalar();
                baglanti.Close();

                if (sonuc != null)
                {
                    hastaID = Convert.ToInt32(sonuc);
                }
                else
                {
                    MessageBox.Show("Bu TC'ye sahip hasta bulunamadı!");
                    return;
                }
            }



            if (eklenenIlaclar.Rows.Count == 0)
            {
                MessageBox.Show("Satış için en az bir ilaç eklemelisiniz!");
                return;
            }

            foreach (DataRow row in eklenenIlaclar.Rows)
            {
                int ilacID = Convert.ToInt32(row["IlacID"]);
                int ilacFiyat = Convert.ToInt32(row["IlacFiyat"]);
                int adet = 1;

                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Odemeler 
            (PersonelID, IlacID, HastaID, OdemeTutari, OdemeTipiID, SatisTarihi, Adet)
            VALUES (@personelID, @ilacID, @hastaID, @tutar, @odemeTipiID, @satisTarihi, @adet)", baglanti))
                {
                    cmd.Parameters.AddWithValue("@personelID", _personelID);
                    cmd.Parameters.AddWithValue("@ilacID", ilacID);
                    cmd.Parameters.AddWithValue("@hastaID", hastaID);
                    cmd.Parameters.AddWithValue("@tutar", ilacFiyat * adet);
                    cmd.Parameters.AddWithValue("@odemeTipiID", secilenOdemeTipiID);
                    cmd.Parameters.AddWithValue("@satisTarihi", tarih);
                    cmd.Parameters.AddWithValue("@adet", adet);

                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                }

                using (SqlCommand stokDusur = new SqlCommand("UPDATE Ilaclar SET IlacAdeti = IlacAdeti - @adet WHERE IlacID = @ilacID", baglanti))
                {
                    stokDusur.Parameters.AddWithValue("@adet", adet);
                    stokDusur.Parameters.AddWithValue("@ilacID", ilacID);

                    baglanti.Open();
                    stokDusur.ExecuteNonQuery();
                    baglanti.Close();
                }

            }

            MessageBox.Show("Satış başarıyla kaydedildi!");

            eklenenIlaclar.Clear();
            txtFiyat.Text = "0"; // ✔ Fiyat sıfırla
            txtRecete.Clear();
            txtHastaTc.Clear();
            cmbOdemeTipi.SelectedIndex = -1;


        }


        private void OdemeTipleriniYukle()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT OdemeTipiID, OdemeTipi FROM OdemeTipleri", baglanti);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbOdemeTipi.DataSource = dt;
                cmbOdemeTipi.DisplayMember = "OdemeTipi";      // ComboBox’ta gözüken kısım
                cmbOdemeTipi.ValueMember = "OdemeTipiID";      // Arka planda saklanan ID
                cmbOdemeTipi.SelectedIndex = -1;               // Varsayılan olarak seçili gelmesin
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödeme tipleri yüklenemedi: " + ex.Message);
            }
        }



        private void ToplamFiyatHesapla()
        {
            int toplam = 0;

            foreach (DataRow row in eklenenIlaclar.Rows)
            {
                int fiyat = Convert.ToInt32(row["IlacFiyat"]);
                toplam += fiyat;
            }

            txtFiyat.Text = toplam.ToString();
        }





    }
}