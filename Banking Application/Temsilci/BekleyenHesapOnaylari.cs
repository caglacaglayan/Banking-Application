using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CG_Bank.Temsilci
{
    public partial class BekleyenHesapOnaylari : Form
    {
        public BekleyenHesapOnaylari()
        {
            InitializeComponent();
        }

        DatabaseConnection bag = new DatabaseConnection();

        public void OnayListele(int id)
        {
            string listele = "Select Musteri_Hesaplari.Id, Musteriler.Ad, Musteriler.Soyad, Doviz_Turu.Doviz, Musteri_Hesaplari.Bakiye, Musteri_Hesaplari.Onay_Turu " +
                "From Musteriler, Musteri_Hesaplari, Doviz_Turu, Musteri_Temsilci, Temsilciler " +
                "Where Musteriler.Id=Musteri_Hesaplari.Musteri_Id AND Doviz_Turu.Id=Musteri_Hesaplari.Tur_Id " +
                "AND Musteriler.Id=Musteri_Temsilci.Musteri_Id AND Musteri_Temsilci.Temsilci_Id=Temsilciler.Id AND Temsilciler.Id='"+id+"'" +
                " AND Musteri_Hesaplari.Onay=0";

            dataGridView1.DataSource = bag.GridSqlProcess(listele);
        }

        private void GeriButton_Click(object sender, EventArgs e)
        {
            TemsilciMenu gecis = new TemsilciMenu();
            gecis.Show();
            this.Hide();
        }

        private void ListeleButton_Click(object sender, EventArgs e)
        {
            OnayListele(TemsilciGiris.id);
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
            string onayturu;
            string onay = "";

            string com = "Select Onay_Turu From Musteri_Hesaplari Where Id='" + id + "'";
            var dr = bag.DataReader(com);

            if (dr.Read())
            {
                onayturu = dr["Onay_Turu"].ToString();
                if (onayturu == "sil")
                {
                    onay = "Delete From Musteri_Hesaplari Where Id = '" + id + "'";
                }
                else if (onayturu == "ekle")
                {
                    onay = "Update Musteri_Hesaplari Set Onay=1, Onay_Turu='valid' Where Id='" + id + "'";
                }
            }
            bag.CloseConnection();

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
            string onayturu;
            string reddet = "";

            string com = "Select Onay_Turu From Musteri_Hesaplari Where Id='" + id + "'";
            var dr = bag.DataReader(com);

            if (dr.Read())
            {
                onayturu = dr["Onay_Turu"].ToString();
                if (onayturu == "ekle")
                {
                    reddet = "Delete From Musteri_Hesaplari Where Id = '" + id + "'";
                }
                else if (onayturu == "sil")
                {
                    reddet = "Update Musteri_Hesaplari Set Onay=1, Onay_Turu='valid' Where Id='" + id + "'";
                }
            }
            bag.CloseConnection();

            bag.SqlProcess(reddet);
            MessageBox.Show("Seçilen işlem başarıyla reddedildi.", "Message");
        }

        int i = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
        }
    }
}
