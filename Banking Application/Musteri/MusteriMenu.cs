using System;
using System.Windows.Forms;

namespace CG_Bank.Musteri
{
    public partial class MusteriMenu : Form
    {
        public MusteriMenu()
        {
            InitializeComponent();
            IsimCek();
        }

        DatabaseConnection bag = new DatabaseConnection();

        private void IsimCek()
        {
            string tc;
            string isim, soyisim;
            tc = MusteriGiris.tcno;

            string com = "Select Ad, Soyad From Musteriler Where TC_No='" + tc + "'";
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

        private void toGuncellemeButton_Click(object sender, EventArgs e)
        {
            BilgiGuncelle gecis = new BilgiGuncelle();
            gecis.Show();
            this.Hide();
        }

        private void CekButton_Click(object sender, EventArgs e)
        {
            ParaCek gecis = new ParaCek();
            gecis.Show();
            this.Hide();
        }

        private void YatırButton_Click(object sender, EventArgs e)
        {
            ParaYatir gecis = new ParaYatir();
            gecis.Show();
            this.Hide();
        }

        private void GonderButton_Click(object sender, EventArgs e)
        {
            ParaGonder gecis = new ParaGonder();
            gecis.Show();
            this.Hide();
        }

        private void HesaplarimButton_Click(object sender, EventArgs e)
        {
            Hesaplarim gecis = new Hesaplarim();
            gecis.Show();
            this.Hide();
        }

        private void KredilerimButton_Click(object sender, EventArgs e)
        {
            Kredilerim gecis = new Kredilerim();
            gecis.Show();
            this.Hide();
        }

        private void AylikOzetButton_Click(object sender, EventArgs e)
        {
            AylikOzet gecis = new AylikOzet();
            gecis.Show();
            this.Hide();
        }
    }
}
