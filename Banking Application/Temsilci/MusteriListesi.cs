using System;
using System.Windows.Forms;
using System.Data;

namespace CG_Bank.Temsilci
{
    public partial class MusteriListesi : Form
    {
        public MusteriListesi()
        {
            InitializeComponent();
        }

        DatabaseConnection bag = new DatabaseConnection();

        public void MusteriListele(int id)
        {
            string listele = "Select Musteriler.Id, Musteriler.Ad, Musteriler.Soyad, Musteriler.TC_No, Musteriler.Telefon, Musteriler.Mail " +
                "From Musteriler,Temsilciler,Musteri_Temsilci " +
                "Where Musteriler.Id=Musteri_Temsilci.Musteri_Id AND Musteri_Temsilci.Temsilci_Id=Temsilciler.Id AND Temsilciler.Id='" + id + "'";

            dataGridView1.DataSource = bag.GridSqlProcess(listele);
        }

        public void MusteriSil(int id)
        {
            string sil = "Delete From Musteriler Where Id = '" + id + "'";

            bag.SqlProcess(sil);
        }

        private void ListeleButton_Click(object sender, EventArgs e)
        {
            MusteriListele(TemsilciGiris.id);
        }

        int i = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            int id = TemsilciGiris.id;
            MusteriEkle gecis = new MusteriEkle(id); //ekleme ekranına
            gecis.Show();
            this.Hide();
        }

        private void DuzenleButton_Click(object sender, EventArgs e)
        {
            int id;
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                id = Convert.ToInt32(drow.Cells[0].Value);
                MusteriGuncelle gecis = new MusteriGuncelle(id); // düzenleme ekranına
                gecis.Show();
                this.Hide();
            }
        }

        private void SilButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                MusteriSil(id);
                MusteriListele(TemsilciGiris.id);
                MessageBox.Show("Seçilen müşteri başarıyla silindi.", "Message");
            }
        }

        private void GeriButton_Click(object sender, EventArgs e)
        {
            TemsilciMenu gecis = new TemsilciMenu();
            gecis.Show();
            this.Hide();
        }

    }
}
