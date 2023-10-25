using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CG_Bank.Musteri
{
    public partial class ParaGonder : Form
    {
        public ParaGonder()
        {
            InitializeComponent();
            GondericiHesapListele();
        }

        DatabaseConnection bag = new DatabaseConnection();

        private void GeriButton_Click(object sender, EventArgs e)
        {
            MusteriMenu gecis = new MusteriMenu();
            gecis.Show();
            this.Hide();
        }

        int tutar;
        int gondericimevcut;
        int alicimevcut;
        private void GonderButton_Click(object sender, EventArgs e)
        {
            tutar = Convert.ToInt32(TutarBox.Text);

            string gonderenmevcutbul = "Select Bakiye From Musteri_Hesaplari Where Id='" + i + "'";
            var dr = bag.DataReader(gonderenmevcutbul);

            if (dr.Read())
            {
                gondericimevcut = Convert.ToInt32(dr["Bakiye"]);
            }
            bag.CloseConnection();

            string alicimevcutbul = "Select Bakiye From Musteri_Hesaplari Where Id='" + j + "'";
            var dr2 = bag.DataReader(alicimevcutbul);

            if (dr2.Read())
            {
                alicimevcut = Convert.ToInt32(dr2["Bakiye"]);
            }
            bag.CloseConnection();


            if (gondericimevcut - tutar < 0)
            {
                MessageBox.Show("Yetersiz bakiye!", "Message");
            }
            else
            {
                int yenigonderici = gondericimevcut - tutar;
                int yenialici = alicimevcut + tutar;

                string guncelle = "Update Musteri_Hesaplari Set Bakiye='" + yenigonderici + "' Where Id='" + i + "'";
                bag.SqlProcess(guncelle);

                string guncelle2 = "Update Musteri_Hesaplari Set Bakiye='" + yenialici + "' Where Id='" + j + "'";
                bag.SqlProcess(guncelle2);

                MessageBox.Show("Para gönderme işlemi başarılı!", "Message");
            }
        }

        public void GondericiHesapListele()
        {
            string listele = "Select Id From Musteri_Hesaplari Where Musteri_Id='" + MusteriGiris.id + "'";

            var dr = bag.DataReader(listele);

            while (dr.Read())
            {
                GondericiBox.Items.Add(dr["Id"]);
            }

            bag.CloseConnection();
        }

        public void AliciHesapListele()
        {
            int turid;
            string turcek = "Select Tur_Id From Musteri_Hesaplari Where Id='" + i + "'";
            var dr1 = bag.DataReader(turcek);

            if (dr1.Read())
            {
                turid = Convert.ToInt32(dr1["Tur_Id"]);
                bag.CloseConnection();

                string listele = "Select Id From Musteri_Hesaplari " +
                    "Where Musteri_Id != '" + MusteriGiris.id + "' AND Tur_Id='" + turid + "'";

                var dr = bag.DataReader(listele);

                if (dr.Read())
                {
                    AliciBox.Items.Add(dr["Id"]);
                }
            }

            bag.CloseConnection();
        }

        int i;
        private void GondericiBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = Convert.ToInt32(GondericiBox.SelectedItem.ToString());
            AliciBox.Items.Clear();
            AliciHesapListele();
        }

        int j;
        private void AliciBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            j = Convert.ToInt32(AliciBox.SelectedItem.ToString());
        }
    }
}
