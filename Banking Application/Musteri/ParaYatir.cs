using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CG_Bank.Musteri
{
    public partial class ParaYatir : Form
    {
        public ParaYatir()
        {
            InitializeComponent();
            HesapListele();
        }

        DatabaseConnection bag = new DatabaseConnection();

        public void HesapListele()
        {
            string listele = "Select Id From Musteri_Hesaplari Where Musteri_Id='" + MusteriGiris.id + "'";

            var dr = bag.DataReader(listele);

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Id"]);
            }

            bag.CloseConnection();
        }

        private void GeriButton_Click(object sender, EventArgs e)
        {
            MusteriMenu gecis = new MusteriMenu();
            gecis.Show();
            this.Hide();
        }

        int tutar;
        int mevcut;
        private void ParaYatirButton_Click(object sender, EventArgs e)
        {
            tutar = Convert.ToInt32(TutarBox.Text);

            string mevcutbul = "Select Bakiye From Musteri_Hesaplari Where Id='" + j + "'";
            var dr = bag.DataReader(mevcutbul);

            if (dr.Read())
            {
                mevcut = Convert.ToInt32(dr["Bakiye"]);
            }
            bag.CloseConnection();

            int yeni = mevcut + tutar;
            string guncelle = "Update Musteri_Hesaplari Set Bakiye='" + yeni + "' Where Id='" + j + "'";
            bag.SqlProcess(guncelle);
            MessageBox.Show("Para yatırma işlemi başarılı!", "Message");
        }

        int j;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            j = Convert.ToInt32(comboBox1.SelectedItem.ToString());
        }
    }
}
