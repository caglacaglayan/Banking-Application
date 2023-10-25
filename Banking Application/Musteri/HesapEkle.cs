using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CG_Bank.Musteri
{
    public partial class HesapEkle : Form
    {
        public HesapEkle()
        {
            InitializeComponent();
            DovizListele();
        }

        DatabaseConnection bag = new DatabaseConnection();

        private void KaydetButton_Click(object sender, EventArgs e)
        {
            bag.OpenConnection();
            string ekle = "Insert into Musteri_Hesaplari (Musteri_Id, Tur_Id, Onay, Onay_Turu, Bakiye) values (@musteriid, @turid, @onay, @onayturu, @bakiye)";

            SqlCommand komut = new SqlCommand(ekle, bag.connection);
            komut.Parameters.AddWithValue("@musteriid", MusteriGiris.id);
            komut.Parameters.AddWithValue("@turid", turid);
            komut.Parameters.AddWithValue("@onay", 0);
            komut.Parameters.AddWithValue("@onayturu", "ekle");
            komut.Parameters.AddWithValue("@bakiye", BakiyeBox.Text);

            komut.ExecuteNonQuery();
            bag.CloseConnection();

            MessageBox.Show("Hesap açma talebi başarıyla oluşturuldu!", "Message");
        }

        public void DovizListele()
        {
            string listele = "Select * From Doviz_Turu ";

            var dr = bag.DataReader(listele);

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Doviz"]);
            }

            bag.CloseConnection();
        }

        private void GeriButton_Click(object sender, EventArgs e)
        {
            Hesaplarim gecis = new Hesaplarim();
            gecis.Show();
            this.Hide();
        }

        string j = "";
        int turid;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            j = comboBox1.SelectedItem.ToString();

            string tur = "Select Id From Doviz_Turu Where Doviz='"+j+"'";
            var dr = bag.DataReader(tur);

            if (dr.Read())
            {
                turid = Convert.ToInt32(dr["Id"].ToString());
            }
            bag.CloseConnection();
        }
    }
}
