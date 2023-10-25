using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CG_Bank.Temsilci
{
    public partial class BekleyenKrediOnaylari : Form
    {
        public BekleyenKrediOnaylari()
        {
            InitializeComponent();
        }

        DatabaseConnection bag = new DatabaseConnection();

        public void OnayListele(int id)
        {
            string listele = "Select Musteri_Kredileri.Id, Musteriler.Ad, Musteriler.Soyad, Doviz_Turu.Doviz, Musteri_Kredileri.Toplam_Tutar " +
                "From Musteriler, Musteri_Kredileri, Doviz_Turu, Musteri_Temsilci, Temsilciler " +
                "Where Musteriler.Id=Musteri_Kredileri.Musteri_Id AND Doviz_Turu.Id=Musteri_Kredileri.Tur_Id " +
                "AND Musteriler.Id=Musteri_Temsilci.Musteri_Id AND Musteri_Temsilci.Temsilci_Id=Temsilciler.Id AND Temsilciler.Id='" + id + "'" +
                " AND Musteri_Kredileri.Onay=0";

            dataGridView1.DataSource = bag.GridSqlProcess(listele);
        }

        private void GeriButton_Click(object sender, EventArgs e)
        {
            TemsilciMenu gecis = new TemsilciMenu();
            gecis.Show();
            this.Hide();
        }

        private void OnaylaButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                Onayla(id);
            }
        }

        public void Onayla(int id)
        {
            string onay = "Update Musteri_Kredileri Set Onay=1 Where Id='" + id + "'";
            bag.SqlProcess(onay);
            MessageBox.Show("Seçilen işlem başarıyla onaylandı.", "Message");
        }

        private void ReddetButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                Reddet(id);
            }
        }

        public void Reddet(int id)
        {
            string onay = "Delete From Musteri_Kredileri Where Id = '" + id + "'";
            bag.SqlProcess(onay);
            MessageBox.Show("Seçilen işlem başarıyla reddedildi.", "Message");
        }

        private void ListeleButton_Click(object sender, EventArgs e)
        {
            OnayListele(TemsilciGiris.id);
        }

        int i = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
        }
    }
}
