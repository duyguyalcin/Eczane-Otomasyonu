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
    public partial class HatirlatmaFormu : Form
    {
        private int _personelID;

        public HatirlatmaFormu(int personelID)
        {
            InitializeComponent();
            _personelID = personelID;
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DUYGU\\SQLEXPRESS; Initial Catalog=ECZANE_APP; Integrated Security=True; Encrypt=True; TrustServerCertificate=True");
        DataTable hatirlatmatForm = new DataTable();
        bool isEditing = false;

        private void btnHatırlatmaGeri_Click(object sender, EventArgs e)
        {
            PersonelFormu form = new PersonelFormu(_personelID);
            form.Show();
            this.Hide();
        }

        private void btnHatirlatmaekle_Click(object sender, EventArgs e)
        {
            string HastaTc = txtHastaTcHatırlatma.Text.Trim();
            string Ilac = txtHatırlatmaIlac.Text.Trim();
            string KayitTarihi = dtpHatirlatmabaslangic.Value.ToString("yyyy-MM-dd");
            string HatirlatmaTarihi = dtpHatirlatmaTarihi.Value.ToString("yyyy-MM-dd");
            string Not = txtHatirlatmaNotu.Text.Trim();


            int hastaID = -1;
            using (SqlCommand komut = new SqlCommand("SELECT HastaID FROM Hastalar WHERE HastaTc = @tc", baglanti))
            {
                komut.Parameters.AddWithValue("@tc", HastaTc);

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

            
            using (SqlCommand komut = new SqlCommand("INSERT INTO Hatirlatmalar (HastaID, IlacID, HatirlatmaTarihi, HatirlatmaNotu, KayitTarihi) VALUES (@hastaID, @ilac, @hatirlatmaTarihi, @not, @kayitTarihi)", baglanti))
            {
                komut.Parameters.AddWithValue("@hastaID", hastaID);
                komut.Parameters.AddWithValue("@ilac", Ilac);
                komut.Parameters.AddWithValue("@hatirlatmaTarihi", HatirlatmaTarihi);
                komut.Parameters.AddWithValue("@not", Not);
                komut.Parameters.AddWithValue("@kayitTarihi", KayitTarihi);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Hatırlatma başarıyla eklendi!");
            }

            HatirlatmaGoruntule();
            
        }

        private void btnHatirlatmaGuncelle_Click(object sender, EventArgs e)
        {
            if (hatırlatmalarView.CurrentRow != null)
            {
                if (!isEditing)
                {
                    DialogResult sonuc = MessageBox.Show("Bu Hatırlatmayı güncellemek istediğinizden emin misiniz?", "Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.No)
                    {
                        return;
                    }

                    int hastaID = Convert.ToInt32(hatırlatmalarView.CurrentRow.Cells["HastaID"].Value);

                    using (SqlCommand komut = new SqlCommand("SELECT HastaTc FROM Hastalar WHERE HastaID = @id", baglanti))
                    {
                        komut.Parameters.AddWithValue("@id", hastaID);
                        baglanti.Open();
                        object sonucTc = komut.ExecuteScalar();
                        baglanti.Close();

                        if (sonucTc != null)
                        {
                            txtHastaTcHatırlatma.Text = sonucTc.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bu ID'ye sahip hasta bulunamadı!");
                            return;
                        }
                    }

                    txtHatırlatmaIlac.Text = hatırlatmalarView.CurrentRow.Cells["IlacID"].Value.ToString();
                    dtpHatirlatmabaslangic.Value = Convert.ToDateTime(hatırlatmalarView.CurrentRow.Cells["KayitTarihi"].Value);
                    dtpHatirlatmaTarihi.Value = Convert.ToDateTime(hatırlatmalarView.CurrentRow.Cells["HatirlatmaTarihi"].Value);
                    txtHatirlatmaNotu.Text = hatırlatmalarView.CurrentRow.Cells["HatirlatmaNotu"].Value.ToString();

                    isEditing = true;
                }
                else
                {
                    string HastaTc = txtHastaTcHatırlatma.Text.Trim();
                    string IlacKod = txtHatırlatmaIlac.Text.Trim();
                    string HatirlatmaBaslangic = dtpHatirlatmabaslangic.Value.ToString("yyyy-MM-dd");
                    string HatirlatmaTarihi = dtpHatirlatmaTarihi.Value.ToString("yyyy-MM-dd");
                    string HatirlatmaNotu = txtHatirlatmaNotu.Text.Trim();

                    int hatirlatmaID = Convert.ToInt32(hatırlatmalarView.CurrentRow.Cells["HatirlatmaID"].Value);

                    int hastaID;
                    using (SqlCommand komut = new SqlCommand("SELECT HastaID FROM Hastalar WHERE HastaTc = @tc", baglanti))
                    {
                        komut.Parameters.AddWithValue("@tc", HastaTc);
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

                    
                    using (SqlCommand komut = new SqlCommand("UPDATE Hatirlatmalar SET HastaID=@hastaid, IlacID=@ilac, HatirlatmaTarihi=@hatirlatmatarihi, HatirlatmaNotu=@not, KayitTarihi=@kayittarihi WHERE HatirlatmaID=@id", baglanti))
                    {
                        komut.Parameters.AddWithValue("@hastaid", hastaID);  
                        komut.Parameters.AddWithValue("@ilac", IlacKod);
                        komut.Parameters.AddWithValue("@hatirlatmatarihi", HatirlatmaTarihi);
                        komut.Parameters.AddWithValue("@not", HatirlatmaNotu);
                        komut.Parameters.AddWithValue("@kayittarihi", HatirlatmaBaslangic);
                        komut.Parameters.AddWithValue("@id", hatirlatmaID);

                        baglanti.Open();
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }

                    isEditing = false;
                    HatirlatmaGoruntule();
                    

                    MessageBox.Show("Hatırlatma başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void HatirlatmaGoruntule()
        {
            hatirlatmatForm.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Hatirlatmalar INNER JOIN Hastalar ON Hatirlatmalar.HastaID = Hastalar.HastaID", baglanti);
            adapter.Fill(hatirlatmatForm);
            hatırlatmalarView.DataSource = hatirlatmatForm;

            
        }

        private void HatirlatmaFormu_Load(object sender, EventArgs e)
        {

            hatırlatmalarView.CellContentClick += hatırlatmalarView_CellContentClick;
            HatirlatmaGoruntule();

        }

        private void hatırlatmalarView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void btnYaklasanHatirlatmalar_Click(object sender, EventArgs e)
        {

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Hatirlatmalar WHERE CONVERT(date, HatirlatmaTarihi) BETWEEN CONVERT(date, GETDATE()) AND CONVERT(date, DATEADD(DAY, 3, GETDATE()))\r\n", baglanti);
            DataTable yaklasan = new DataTable();
            adapter.Fill(yaklasan);
            hatırlatmalarView.DataSource = yaklasan;


        }



        private void btnHatirlatmaSil_Click(object sender, EventArgs e)
        {
            if (hatırlatmalarView.CurrentRow != null)
            {
                DialogResult sonuc = MessageBox.Show("Bu görevi silmek istediğinizden emin misiniz?", "Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.No)
                {
                    return;
                }

                int hatirlatmaID = Convert.ToInt32(hatırlatmalarView.CurrentRow.Cells["HatirlatmaID"].Value);

                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Hatirlatmalar WHERE HatirlatmaID = @id", baglanti);
                komut.Parameters.AddWithValue("@id", hatirlatmaID);
                komut.ExecuteNonQuery();
                baglanti.Close();


                HatirlatmaGoruntule();
                



                MessageBox.Show("Görev silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void btnTum_Click_1(object sender, EventArgs e)
        {
            hatirlatmatForm.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Hatirlatmalar", baglanti);
            adapter.Fill(hatirlatmatForm);
            hatırlatmalarView.DataSource = hatirlatmatForm;

        }

        private void grpHatırlatmalar_Enter(object sender, EventArgs e)
        {

        }
    }
}
