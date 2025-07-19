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
    public partial class PersonelKayitFormu : Form
    {
        public PersonelKayitFormu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DUYGU\\SQLEXPRESS; Initial Catalog=ECZANE_APP; Integrated Security=True; Encrypt=True; TrustServerCertificate=True");
        DataTable personelKayitForm = new DataTable();
        bool isEditing = false;


        private void btnPersonelKayitGeri_Click(object sender, EventArgs e)
        {
            YoneticiFormu form = new YoneticiFormu();
            form.Show();
            this.Hide();
        }

        private void Temizle()
        {
            PersonelGetir();
        }
        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            string PerAdi = txtPerAdi.Text.Trim();
            string PerKullaniciAdi = txtPerKullaniciAdi.Text.Trim();
            string PerSifre = txtPerSifre.Text.Trim();
            string PerEposta = txtPerEposta.Text.Trim();
            string PerKayitTarihi = dtpPerKayitTarihi.MinDate.ToString();


            SqlCommand Komut = new SqlCommand("Insert Into Personeller(PersonelAdiSoyadi, PersonelKullaniciAdi, PersonelSifre, PersonelEPosta, PersonelKayitTarihi) Values(@peradi, @perkullaniciadi, @persifre, @pereposta, @perkayittatihi)", baglanti);
            Komut.Parameters.AddWithValue("@peradi", PerAdi);
            Komut.Parameters.AddWithValue("@perkullaniciadi", PerKullaniciAdi);
            Komut.Parameters.AddWithValue("@persifre", PerSifre);
            Komut.Parameters.AddWithValue("@pereposta", PerEposta);
            Komut.Parameters.AddWithValue("@perkayittatihi", PerKayitTarihi);

            baglanti.Open();
            Komut.ExecuteNonQuery();
            baglanti.Close();

            PersonelGetir();
            Temizle();

            MessageBox.Show("Kayıt başarıyla oluşturuldu!");


        }


        private void PersonelGetir()
        {
            personelKayitForm.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Personeller", baglanti);
            adapter.Fill(personelKayitForm);
            PersonellerView.DataSource = personelKayitForm;

            sutunGenislikAyarla();
            stilUygula();
        }

        private void PersonelKayitFormu_Load(object sender, EventArgs e)
        {
            PersonellerView.CellContentClick += PersonellerView_CellContentClick;
            PersonelGetir();
        }



        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            if (PersonellerView.CurrentRow != null)
            {
                if (!isEditing)
                {
                    DialogResult sonuc = MessageBox.Show("Bu görevi güncellemek istediğinizden emin misiniz?", "Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.No)
                    {
                        return;
                    }

                    txtPerAdi.Text = PersonellerView.CurrentRow.Cells["PersonelAdiSoyadi"].Value.ToString();
                    txtPerKullaniciAdi.Text = PersonellerView.CurrentRow.Cells["PersonelKullaniciAdi"].Value.ToString();
                    txtPerSifre.Text = PersonellerView.CurrentRow.Cells["PersonelSifre"].Value.ToString();
                    txtPerEposta.Text = PersonellerView.CurrentRow.Cells["PersonelEPosta"].Value.ToString();
                    dtpPerKayitTarihi.Value = Convert.ToDateTime(PersonellerView.CurrentRow.Cells["PersonelKayitTarihi"].Value);

                    isEditing = true;
                }
                else
                {
                    string PerAdi = txtPerAdi.Text.Trim();
                    string PerKullaniciAdi = txtPerKullaniciAdi.Text.Trim();
                    string PerSifre = txtPerSifre.Text.Trim();
                    string PerEposta = txtPerEposta.Text.Trim();
                    string PerKayitTarihi = dtpPerKayitTarihi.Value.ToString("yyyy-MM-dd");

                    int personelID = Convert.ToInt32(PersonellerView.CurrentRow.Cells["PersonelID"].Value);

                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("UPDATE Personeller SET PersonelAdiSoyadi = @peradi, PersonelKullaniciAdi = @perkullaniciadi, PersonelSifre = @persifre, PersonelEPosta = @pereposta, PersonelKayitTarihi = @perkayittatihi WHERE PersonelID = @id", baglanti);
                    komut.Parameters.AddWithValue("@peradi", PerAdi);
                    komut.Parameters.AddWithValue("@perkullaniciadi", PerKullaniciAdi);
                    komut.Parameters.AddWithValue("@persifre", PerSifre);
                    komut.Parameters.AddWithValue("@pereposta", PerEposta);
                    komut.Parameters.AddWithValue("@perkayittatihi", PerKayitTarihi);
                    komut.Parameters.AddWithValue("@id", personelID);

                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    isEditing = false;

                    PersonelGetir();
                    Temizle();

                    MessageBox.Show("Görev güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            if (PersonellerView.CurrentRow != null)
            {
                DialogResult sonuc = MessageBox.Show("Bu görevi silmek istediğinizden emin misiniz?", "Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.No)
                {
                    return; 
                }

                int personelID = Convert.ToInt32(PersonellerView.CurrentRow.Cells["PersonelID"].Value);

                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Personeller WHERE PersonelID = @id", baglanti);
                komut.Parameters.AddWithValue("@id", personelID);
                komut.ExecuteNonQuery();
                baglanti.Close();

               
                PersonelGetir();
                Temizle();

                MessageBox.Show("Görev silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }




        private void stilUygula()
        {
            PersonellerView.AutoGenerateColumns = true;

            foreach (DataGridViewColumn column in PersonellerView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            PersonellerView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            PersonellerView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            PersonellerView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            PersonellerView.RowTemplate.Height = 30;

            PersonellerView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            PersonellerView.DefaultCellStyle.SelectionBackColor = Color.SlateGray;
            PersonellerView.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;

            PersonellerView.BorderStyle = BorderStyle.None;
            PersonellerView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PersonellerView.EnableHeadersVisualStyles = false;
            PersonellerView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            PersonellerView.BackgroundColor = Color.WhiteSmoke;
        }

        private void sutunGenislikAyarla()
        {
            PersonellerView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            foreach (DataGridViewColumn col in PersonellerView.Columns)
            {
                if (col.Name == "id") col.Width = 50;
                else if (col.Name == "Gorev") col.Width = 200;
                else if (col.Name == "BaslangicTarihi") col.Width = 150;
                else if (col.Name == "BitisTarihi") col.Width = 150;
                else if (col.Name == "Kategori") col.Width = 150;
                else if (col.Name == "Oncelik") col.Width = 150;
                else if (col.Name == "Durum") col.Width = 60;
                else col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void PersonellerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
