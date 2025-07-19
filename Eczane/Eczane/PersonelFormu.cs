using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eczane
{
    public partial class PersonelFormu : Form
    {
        private int _personelID;

        public PersonelFormu(int personelID)
        {
            InitializeComponent();
            _personelID = personelID;
        }

        private void btnPCikis_Click(object sender, EventArgs e)
        {
            GirisFormu form = new GirisFormu();
            form.Show();
            this.Hide();
        }

        private void btnHastaKayit_Click(object sender, EventArgs e)
        {
            int personelID = 1;
            HastaKayitFormu form = new HastaKayitFormu(personelID);
            form.Show();
            this.Hide();
        }

        private void btnHatirlatmalar_Click(object sender, EventArgs e)
        {

            int personelID = 1;
            HatirlatmaFormu form = new HatirlatmaFormu(personelID);
            form.Show();
            this.Hide();

        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            int personelID = 1; // burada oturum açan personelin ID'si neyse onu al
            SatisFormu form = new SatisFormu(personelID); // ✅ Doğru
            form.Show();
            this.Hide();
        }
    }
}
