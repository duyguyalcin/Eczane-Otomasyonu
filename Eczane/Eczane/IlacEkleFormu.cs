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
    public partial class IlacEkleFormu : Form
    {
        

        public IlacEkleFormu()
        {
            InitializeComponent();
           
        }


        SqlConnection baglanti = new SqlConnection("Data Source=DUYGU\\SQLEXPRESS; Initial Catalog=ECZANE_APP; Integrated Security=True; Encrypt=True; TrustServerCertificate=True");
        DataTable ilacEkleFormu = new DataTable();
        bool isEditing = false;

        private void btnIlacEkleGeri_Click(object sender, EventArgs e)
        {
            YoneticiFormu form = new YoneticiFormu();   
            form.Show();
            this.Hide();
        }

        private void btnIlacKaydet_Click(object sender, EventArgs e)
        {

            string IlacAdi = txtIlacAdi.Text.Trim();
            string IlacGTIN = txtGtin.Text.Trim();
            string UreticiFirma = txtUreticiFirma.Text.Trim();
            string IlacTuru = cmbIlacTuru.Text.Trim();
            string IlacSKT = dtpIlacSkt.Value.ToString("yyyy-MM-dd");
            string IlacGelisTarihi = dtpIlacGelisTarihi.Value.ToString("yyyy-MM-dd");
            string IlacAdeti = txtIlacAdeti.Text.Trim();
            string IlacFiyati = txtIlacFiyati.Text.Trim();  
            

            SqlCommand Komut = new SqlCommand("Insert Into Ilaclar (IlacAdi, GTIN, UreticiFirma, IlacSKT, IlacTuru, IlacGelisTarihi,IlacAdeti, IlacFiyati) Values(@ilacadi, @gtin, @ureticifirma, @ilacskt, @ilacturu, @ilacgelistarihi, @ilacadeti, @ilacfiyati)", baglanti);
            Komut.Parameters.AddWithValue("@ilacadi", IlacAdi);
            Komut.Parameters.AddWithValue("@gtin", IlacGTIN);
            Komut.Parameters.AddWithValue("@ureticifirma", UreticiFirma);
            Komut.Parameters.AddWithValue("@ilacturu", IlacTuru);
            Komut.Parameters.AddWithValue("@ilacskt", IlacSKT);
            Komut.Parameters.AddWithValue("@ilacgelistarihi", IlacGelisTarihi);
            Komut.Parameters.AddWithValue("@ilacadeti", IlacAdeti);
            Komut.Parameters.AddWithValue("@ilacfiyati", IlacFiyati);
            

            baglanti.Open();
            Komut.ExecuteNonQuery();
            baglanti.Close();

            IlacGoruntule();
            Temizle();


            MessageBox.Show("Kayıt başarıyla oluşturuldu!");

        }

        private void btnIlacEkleGuncelle_Click(object sender, EventArgs e)
        {
            if (IlclarView.CurrentRow != null)
            {
                if (!isEditing)
                {
                    DialogResult sonuc = MessageBox.Show("Bu ilacı güncellemek istediğinizden emin misiniz?", "Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.No)
                    {
                        return;
                    }

                    
                    txtIlacAdi.Text = IlclarView.CurrentRow.Cells["IlacAdi"].Value.ToString();
                    txtGtin.Text = IlclarView.CurrentRow.Cells["GTIN"].Value.ToString();
                    txtUreticiFirma.Text = IlclarView.CurrentRow.Cells["UreticiFirma"].Value.ToString();
                    cmbIlacTuru.Text = IlclarView.CurrentRow.Cells["IlacTuru"].Value.ToString();
                    dtpIlacSkt.Value = Convert.ToDateTime(IlclarView.CurrentRow.Cells["IlacSKT"].Value);
                    dtpIlacGelisTarihi.Value = Convert.ToDateTime(IlclarView.CurrentRow.Cells["IlacGelisTarihi"].Value);
                    txtIlacAdeti.Text = IlclarView.CurrentRow.Cells["IlacAdeti"].Value.ToString();
                    txtIlacFiyati.Text = IlclarView.CurrentRow.Cells["IlacFiyati"].Value.ToString();
                    


                    isEditing = true;
                }
                else
                {
                    
                    string IlacAdi = txtIlacAdi.Text.Trim();
                    string IlacGTIN = txtGtin.Text.Trim();
                    string UreticiFirma = txtUreticiFirma.Text.Trim();
                    string IlacTuru = cmbIlacTuru.Text.Trim();
                    string IlacSKT = dtpIlacSkt.Value.ToString("yyyy-MM-dd");
                    string IlacGelisTarihi = dtpIlacGelisTarihi.Value.ToString("yyyy-MM-dd");
                    string IlacAdeti = txtIlacAdeti.Text.Trim();
                    string IlacFiyati = txtIlacFiyati.Text.Trim();
                    


                    int ilacID = Convert.ToInt32(IlclarView.CurrentRow.Cells["IlacID"].Value);

                    
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("UPDATE Ilaclar SET IlacAdi = @ilacadi, GTIN = @gtin, UreticiFirma = @ureticifirma, IlacSKT = @ilacskt, IlacTuru = @ilacturu, IlacGelisTarihi = @ilacgelistarihi, IlacAdeti = @ilacadeti, IlacFiyati = @ilacfiyati WHERE IlacID = @id", baglanti);
                    komut.Parameters.AddWithValue("@ilacadi", IlacAdi);
                    komut.Parameters.AddWithValue("@gtin", IlacGTIN);
                    komut.Parameters.AddWithValue("@ureticifirma", UreticiFirma);
                    komut.Parameters.AddWithValue("@ilacturu", IlacTuru);
                    komut.Parameters.AddWithValue("@ilacskt", IlacSKT);
                    komut.Parameters.AddWithValue("@ilacgelistarihi", IlacGelisTarihi);
                    komut.Parameters.AddWithValue("@ilacadeti", IlacAdeti);
                    komut.Parameters.AddWithValue("@ilacfiyati", IlacFiyati);
                   
                    komut.Parameters.AddWithValue("@id", ilacID);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    isEditing = false;
                    IlacGoruntule();
                    Temizle();

                    MessageBox.Show("İlaç başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private void btnIlacSil_Click(object sender, EventArgs e)
        {
            if (IlclarView.CurrentRow != null)
            {
                DialogResult sonuc = MessageBox.Show("Bu görevi silmek istediğinizden emin misiniz?", "Güncelleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.No)
                {
                    return; 
                }

                int ilacID = Convert.ToInt32(IlclarView.CurrentRow.Cells["IlacID"].Value);

                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Ilaclar WHERE IlacID = @id", baglanti);
                komut.Parameters.AddWithValue("@id", ilacID);
                komut.ExecuteNonQuery();
                baglanti.Close();


                IlacGoruntule();
                Temizle();



                MessageBox.Show("Görev silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void Temizle()
        {
            IlacGoruntule();
        }


        private void IlacGoruntule()
        {
            ilacEkleFormu.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ilaclar", baglanti);
            adapter.Fill(ilacEkleFormu);
            IlclarView.DataSource = ilacEkleFormu;

            sutunGenislikAyarla();
            stilUygula();
        }

        private void stilUygula()
        {
            IlclarView.AutoGenerateColumns = true;

            foreach (DataGridViewColumn column in IlclarView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            IlclarView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            IlclarView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            IlclarView.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            IlclarView.RowTemplate.Height = 30;

            IlclarView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            IlclarView.DefaultCellStyle.SelectionBackColor = Color.SlateGray;
            IlclarView.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;

            IlclarView.BorderStyle = BorderStyle.None;
            IlclarView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            IlclarView.EnableHeadersVisualStyles = false;
            IlclarView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            IlclarView.BackgroundColor = Color.WhiteSmoke;
        }

        private void sutunGenislikAyarla()
        {
            IlclarView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            foreach (DataGridViewColumn col in IlclarView.Columns)
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

        private void IlclarView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IlacEkleFormu_Load(object sender, EventArgs e)
        {
            cmbIlacTuru.Items.AddRange(new string[] { "Ağrı Kesici", "Ateş Düşürücü", "Astım", "Vitamin","Antibiyotik","Antidepresan" });

            cmbIlacTuru.SelectedIndex = -1;

            IlclarView.CellContentClick += IlclarView_CellContentClick;
            IlacGoruntule();
        }
    }
}
