using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CG_Bank.Musteri
{
    public partial class Kredilerim : Form
    {
        public Kredilerim()
        {
            InitializeComponent();
        }

        DatabaseConnection bag = new DatabaseConnection();

        public void KrediListele(int id)
        {
            string listele = "Select Musteri_Kredileri.Id, Doviz_Turu.Doviz, Musteri_Kredileri.Toplam_Tutar, Musteri_Kredileri.Vade, Faizler.Oran " +
                "From Musteriler, Musteri_Kredileri, Doviz_Turu, Faizler " +
                "Where Musteriler.Id=Musteri_Kredileri.Musteri_Id AND Doviz_Turu.Id=Musteri_Kredileri.Tur_Id AND Musteriler.Id='" + id + "'" +
                " AND Musteri_Kredileri.Onay=1 AND Faizler.Id=Musteri_Kredileri.Faiz_Id";

            dataGridView1.DataSource = bag.GridSqlProcess(listele);
        }

        private void GeriButton_Click(object sender, EventArgs e)
        {
            MusteriMenu gecis = new MusteriMenu();
            gecis.Show();
            this.Hide();
        }

        int i = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
        }

        private void ListeleButton_Click(object sender, EventArgs e)
        {
            KrediListele(MusteriGiris.id);
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            KrediEkle gecis = new KrediEkle();
            gecis.Show();
            this.Hide();
        }

        private void TumunuOdeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
