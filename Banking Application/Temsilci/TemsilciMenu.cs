using System;
using System.Windows.Forms;

namespace CG_Bank.Temsilci
{
    public partial class TemsilciMenu : Form
    {
        public TemsilciMenu()
        {
            InitializeComponent();
            IsimCek();
        }

        DatabaseConnection bag = new DatabaseConnection();

        private void IsimCek()
        {
            string tc;
            string isim, soyisim;
            tc = TemsilciGiris.tcno;

            string com = "Select Ad, Soyad From Temsilciler Where TC_No='" + tc + "'";
            var dr = bag.DataReader(com);

            if (dr.Read())
            {
                isim = dr["Ad"].ToString();
                soyisim = dr["Soyad"].ToString();
                label2.Text = isim + ' ' + soyisim;
            }

            bag.CloseConnection();
        }

        private void AnasayfaButton_Click(object sender, EventArgs e)
        { 
            Anasayfa gecis = new Anasayfa();
            gecis.Show();
            this.Hide();
        }

        private void MusterilerButton_Click(object sender, EventArgs e)
        {
            MusteriListesi gecis = new MusteriListesi();
            gecis.Show();
            this.Hide();
        }

        private void HesapOnaylariButton_Click(object sender, EventArgs e)
        {
            BekleyenHesapOnaylari gecis = new BekleyenHesapOnaylari();
            gecis.Show();
            this.Hide();
        }

        private void KrediOnaylariButton_Click(object sender, EventArgs e)
        {
            BekleyenKrediOnaylari gecis = new BekleyenKrediOnaylari();
            gecis.Show();
            this.Hide();
        }

        private void GenelDurumlarButton_Click(object sender, EventArgs e)
        {
            MusteriDurumlari gecis = new MusteriDurumlari();
            gecis.Show();
            this.Hide();
        }

        private void MusteriIslemleriButton_Click(object sender, EventArgs e)
        {
            MusteriIslemleri gecis = new MusteriIslemleri();
            gecis.Show();
            this.Hide();
        }

    }
}
