using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CG_Bank.Musteri
{
    public partial class Hesaplarim : Form
    {
        public Hesaplarim()
        {
            InitializeComponent();
        }

        DatabaseConnection bag = new DatabaseConnection();

        public void HesapListele(int id)
        {
            string listele = "Select Musteri_Hesaplari.Id, Doviz_Turu.Doviz, Musteri_Hesaplari.Bakiye " +
                "From Musteriler, Musteri_Hesaplari, Doviz_Turu " +
                "Where Musteriler.Id=Musteri_Hesaplari.Musteri_Id AND Doviz_Turu.Id=Musteri_Hesaplari.Tur_Id AND Musteriler.Id='" + id + "'" +
                " AND Musteri_Hesaplari.Onay=1";

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
            HesapListele(MusteriGiris.id);
        }

        private void EkleButton_Click(object sender, EventArgs e)
        {
            HesapEkle gecis = new HesapEkle();
            gecis.Show();
            this.Hide();
        }

        private void DuzenleButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                HesapAyrintilari gecis = new HesapAyrintilari(id);
                gecis.Show();
                this.Hide();
            } 
        }

        public void HesapSil(int id)
        {
            string bakiyeal = "Select Bakiye From Musteri_Hesaplari Where Id='"+id+"'";
            int bakiye;

            var dr = bag.DataReader(bakiyeal);
            if (dr.Read())
            {
                bakiye = Convert.ToInt32(dr["Bakiye"].ToString());
                if (bakiye != 0)
                {
                    MessageBox.Show("Bakiyesi 0 olmayan bir hesap silinemez!", "Message");
                    bag.CloseConnection();
                }
                else
                {
                    string sil = "Update Musteri_Hesaplari Set Onay=0, Onay_Turu='sil' Where Id ='" + id + "'";
                    bag.SqlProcess(sil);
                    MessageBox.Show("Hesap silme talebi başarıyla oluşturuldu!", "Message");
                }
            }
        }

        private void SilButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(drow.Cells[0].Value);
                    HesapSil(id);
                    HesapListele(MusteriGiris.id);
                }
            }

            catch (Exception hata)
            {
                MessageBox.Show("Bakiyesi 0 olmayan bir hesap silinemez!", "Message");
            }
        }

    }
}
