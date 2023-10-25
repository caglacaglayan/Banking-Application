using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CG_Bank.Musteri
{
    public partial class KrediEkle : Form
    {
        public KrediEkle()
        {
            InitializeComponent();
            DovizListele();
        }

        DatabaseConnection bag = new DatabaseConnection();

        private void KaydetButton_Click(object sender, EventArgs e)
        {
            bag.OpenConnection();
            string ekle = "Insert into Musteri_Kredileri (Musteri_Id, Tur_Id, Toplam_Tutar, Vade, Faiz_Id, Onay) values (@musteriid, @turid, @tutar, @vade, @faizid, @onay)";

            SqlCommand komut = new SqlCommand(ekle, bag.connection);
            komut.Parameters.AddWithValue("@musteriid", MusteriGiris.id);
            komut.Parameters.AddWithValue("@turid", turid);
            komut.Parameters.AddWithValue("@tutar", TutarBox.Text);
            komut.Parameters.AddWithValue("@vade", VadeBox.Text);
            komut.Parameters.AddWithValue("@faizid", 900);
            komut.Parameters.AddWithValue("@onay", 0);

            komut.ExecuteNonQuery();
            bag.CloseConnection();

            MessageBox.Show("Kredi çekme talebi başarıyla oluşturuldu!", "Message");
        }

        private void GeriButton_Click(object sender, EventArgs e)
        {
            Kredilerim gecis = new Kredilerim();
            gecis.Show();
            this.Hide();
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

        string j = "";
        int turid;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            j = comboBox1.SelectedItem.ToString();

            string tur = "Select Id From Doviz_Turu Where Doviz='" + j + "'";
            var dr = bag.DataReader(tur);

            if (dr.Read())
            {
                turid = Convert.ToInt32(dr["Id"].ToString());
            }
            bag.CloseConnection();
        }
    }
}
