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
    public partial class HastaKayitFormu : Form
    {
        private int _personelID;

        public HastaKayitFormu(int personelID)
        {
            InitializeComponent();
            _personelID = personelID;
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DUYGU\\SQLEXPRESS; Initial Catalog=ECZANE_APP; Integrated Security=True; Encrypt=True; TrustServerCertificate=True");
        DataTable hastaEkleForm = new DataTable();
        bool isEditing = false;

        

        private void HastaGoruntule()
        {
            hastaEkleForm.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Hastalar", baglanti);
            adapter.Fill(hastaEkleForm);
            HastaListelemeView.DataSource = hastaEkleForm;

            sutunGenislikAyarla();
            stilUygula();
        }

        private void Temizle()
        {
            HastaGoruntule();
        }

        private void stilUygula()
        {
            HastaListelemeView.AutoGenerateColumns = true;

            foreach (DataGridViewColumn column in HastaListelemeView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            HastaListelemeView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            HastaListelemeView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            HastaListelemeView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            HastaListelemeView.RowTemplate.Height = 30;

            HastaListelemeView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            HastaListelemeView.DefaultCellStyle.SelectionBackColor = Color.SlateGray;
            HastaListelemeView.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;

            HastaListelemeView.BorderStyle = BorderStyle.None;
            HastaListelemeView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            HastaListelemeView.EnableHeadersVisualStyles = false;
            HastaListelemeView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            HastaListelemeView.BackgroundColor = Color.WhiteSmoke;
        }

        private void sutunGenislikAyarla()
        {
            HastaListelemeView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            foreach (DataGridViewColumn col in HastaListelemeView.Columns)
            {
                if (col.Name == "HastaID") col.Width = 50;
                else if (col.Name == "HastaAdi") col.Width = 150;
                else if (col.Name == "HastaSoyadi") col.Width = 150;
                else if (col.Name == "HastaTc") col.Width = 120;
                else if (col.Name == "HastaTelNo") col.Width = 120;
                else if (col.Name == "HastaTeshis") col.Width = 200;
                else if (col.Name == "HastaAdresi") col.Width = 200;
                else if (col.Name == "HastaYakiniAdiSoyadi") col.Width = 150;
                else if (col.Name == "HastaYakiniTc") col.Width = 120;
                else if (col.Name == "HastaYakiniTelNo") col.Width = 120;
                else if (col.Name == "HastaKayitTarihi") col.Width = 120;
                else col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        private void btnHastaKayıtGeri_Click(object sender, EventArgs e)
        {
            PersonelFormu form = new PersonelFormu(_personelID);
            form.Show();
            this.Hide();
        }

        private void HastaKayitFormu_Load(object sender, EventArgs e)
        {
            HastaListelemeView.CellContentClick += HastaListelemeView_CellContentClick;
            HastaGoruntule();

        }

        private void btnHastaKaydet_Click(object sender, EventArgs e)
        {
            string HastaAdi = txtHastaAdi.Text.Trim();
            string HastaSoyadi = txtHastaSoyadi.Text.Trim();
            string HastaTc = txtHastaTc.Text.Trim();
            string HastaTelNo = txtHastaTelefon.Text.Trim();
            string HastaTeshis = txtHastaTeshis.Text.Trim();
            string HastaAdresi = txtHastaAdres.Text.Trim();
            string YakiniAdiSoyadi = txtYakinAdSoyad.Text.Trim();
            string YakiniTc = txtYakiniTc.Text.Trim();
            string YakiniTelNo = txtYakiniTelNo.Text.Trim();
            string HastaKayitTarihi = dtpHastaKayitTarihi.Value.ToString("yyyy-MM-dd");


            SqlCommand Komut = new SqlCommand("Insert Into Hastalar (HastaAdi, HastaSoyadi, HastaTc, HastaTelNo, HastaTeshis, HastaAdresi,HastaYakiniAdiSoyadi,HastaYakiniTc,HastaYakiniTelNo, HastaKayitTarihi) Values (@hastaadi, @hastasoyadi, @hastatc, @hastatelno, @hastateshis, @hastaadresi, @hastayakiniadisoyadi, @hastayakinitc, @hastayakinitelno, @hastakayittarihi)", baglanti);
            Komut.Parameters.AddWithValue("@hastaadi", HastaAdi);
            Komut.Parameters.AddWithValue("@hastasoyadi", HastaSoyadi);
            Komut.Parameters.AddWithValue("@hastatc", HastaTc);
            Komut.Parameters.AddWithValue("@hastatelno", HastaTelNo);
            Komut.Parameters.AddWithValue("@hastateshis", HastaTeshis);
            Komut.Parameters.AddWithValue("@hastaadresi", HastaAdresi);
            Komut.Parameters.AddWithValue("@hastayakiniadisoyadi", YakiniAdiSoyadi);
            Komut.Parameters.AddWithValue("@hastayakinitc", YakiniTc);
            Komut.Parameters.AddWithValue("@hastayakinitelno", YakiniTelNo);
            Komut.Parameters.AddWithValue("@hastakayittarihi", HastaKayitTarihi);

            baglanti.Open();
            Komut.ExecuteNonQuery();
            baglanti.Close();

            HastaGoruntule();
            Temizle();
        }


        private void btnHastaKayitGuncelle_Click(object sender, EventArgs e)
        {
            if (HastaListelemeView.CurrentRow != null)
            {
                if (!isEditing)
                {
                    DialogResult sonuc = MessageBox.Show("Bu ilacı güncellemek istediğinizden emin misiniz?", "Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.No)
                    {
                        return;
                    }


                    txtHastaAdi.Text = HastaListelemeView.CurrentRow.Cells["HastaAdi"].Value.ToString();
                    txtHastaSoyadi.Text = HastaListelemeView.CurrentRow.Cells["HastaSoyadi"].Value.ToString();
                    txtHastaTc.Text = HastaListelemeView.CurrentRow.Cells["HastaTc"].Value.ToString();
                    txtHastaTelefon.Text = HastaListelemeView.CurrentRow.Cells["HastaTelNo"].Value.ToString();
                    txtHastaTeshis.Text = HastaListelemeView.CurrentRow.Cells["HastaTeshis"].Value.ToString();
                    txtHastaAdres.Text = HastaListelemeView.CurrentRow.Cells["HastaAdresi"].Value.ToString();
                    txtYakinAdSoyad.Text = HastaListelemeView.CurrentRow.Cells["HastaYakiniAdiSoyadi"].Value.ToString();
                    txtYakiniTc.Text = HastaListelemeView.CurrentRow.Cells["HastaYakiniTc"].Value.ToString();
                    txtYakiniTelNo.Text = HastaListelemeView.CurrentRow.Cells["HastaYakiniTelNo"].Value.ToString();
                    dtpHastaKayitTarihi.Value = Convert.ToDateTime(HastaListelemeView.CurrentRow.Cells["HastaKayitTarihi"].Value);
                   
                    isEditing = true;
                }
                else
                {

                    string HastaAdi = txtHastaAdi.Text.Trim();
                    string HastaSoyadi = txtHastaSoyadi.Text.Trim();
                    string HastaTc = txtHastaTc.Text.Trim();
                    string HastaTelNo = txtHastaTelefon.Text.Trim();
                    string HastaTeshis = txtHastaTeshis.Text.Trim();
                    string HastaAdresi = txtHastaAdres.Text.Trim();
                    string HastaYakiniAdiSoyadi = txtYakinAdSoyad.Text.Trim();
                    string HastaYakiniTc = txtYakiniTc.Text.Trim();
                    string HastaYakiniTelNo = txtYakiniTelNo.Text.Trim();
                    string HastaKayitTarihi = dtpHastaKayitTarihi.Value.ToString("yyyy-MM-dd");

                    int hastaID = Convert.ToInt32(HastaListelemeView.CurrentRow.Cells["HastaID"].Value);


                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("UPDATE Hastalar SET HastaAdi = @hastaadi, hastasoyadi = @HastaSoyadi, HastaTc = @hastatc, HastaTelNo = @hastatelno, HastaTeshis = @hastateshis, HastaAdresi = @hastaadresi, HastaYakiniAdiSoyadi = @hastayakiniadisoyadi, HastaYakiniTc = @hastayakinitc, HastaYakiniTelNo = @hastayakinitelno, HastaKayitTarihi = @hastakayittarihi  WHERE HastaID = @id", baglanti);
                    komut.Parameters.AddWithValue("@hastaadi", HastaAdi);
                    komut.Parameters.AddWithValue("@hastasoyadi", HastaSoyadi);
                    komut.Parameters.AddWithValue("@hastatc", HastaTc);
                    komut.Parameters.AddWithValue("@hastatelno", HastaTelNo);
                    komut.Parameters.AddWithValue("@hastateshis", HastaTeshis);
                    komut.Parameters.AddWithValue("@hastaadresi", HastaAdresi);
                    komut.Parameters.AddWithValue("@hastayakiniadisoyadi", HastaYakiniAdiSoyadi);
                    komut.Parameters.AddWithValue("@hastayakinitc", HastaYakiniTc);
                    komut.Parameters.AddWithValue("@hastayakinitelno", HastaYakiniTelNo);
                    komut.Parameters.AddWithValue("@hastakayittarihi", HastaKayitTarihi);
                    komut.Parameters.AddWithValue("@id", hastaID);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    isEditing = false;
                    HastaGoruntule();
                    Temizle();

                    MessageBox.Show("İlaç başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnHastaKayitSil_Click(object sender, EventArgs e)
        {
            if (HastaListelemeView.CurrentRow != null)
            {
                DialogResult sonuc = MessageBox.Show("Bu görevi silmek istediğinizden emin misiniz?", "Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.No)
                {
                    return;
                }

                int hastaID = Convert.ToInt32(HastaListelemeView.CurrentRow.Cells["hastaID"].Value);

                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Hastalar WHERE HastaID = @id", baglanti);
                komut.Parameters.AddWithValue("@id", hastaID);
                komut.ExecuteNonQuery();
                baglanti.Close();


                HastaGoruntule();
                Temizle();



                MessageBox.Show("Görev silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }




        private void HastaListelemeView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
