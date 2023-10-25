using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CG_Bank.Musteri
{
    public partial class BilgiGuncelle : Form
    {
        public BilgiGuncelle()
        {
            InitializeComponent();
            VeriGetir();
        }

        DatabaseConnection bag = new DatabaseConnection();

        void VeriGetir()
        {
            string tc;
            tc = MusteriGiris.tcno;

            string ara = "Select Telefon, Mail, Adres, Sifre From Musteriler Where TC_No='" + tc + "'";
            var dr = bag.DataReader(ara);

            if (dr.Read())
            {
                AdresBox.Text = dr["Adres"].ToString();
                TelefonBox.Text = dr["Telefon"].ToString();
                MailBox.Text = dr["Mail"].ToString();
                SifreBox.Text = dr["Sifre"].ToString();
            }

            bag.CloseConnection();
        }

        private void KaydetButton_Click(object sender, EventArgs e)
        {
            string tc;
            tc = MusteriGiris.tcno;

            bag.OpenConnection();
            string guncel = "Update Musteriler Set Adres=@adres, Telefon=@telefon, Mail=@mail, Sifre=@sifre Where TC_No=@tc";
            SqlCommand komut = new SqlCommand(guncel, bag.connection);
            komut.Parameters.AddWithValue("@tc", tc);
            komut.Parameters.AddWithValue("@adres", AdresBox.Text);
            komut.Parameters.AddWithValue("@telefon", TelefonBox.Text);
            komut.Parameters.AddWithValue("@mail", MailBox.Text);
            komut.Parameters.AddWithValue("@sifre", SifreBox.Text);
            komut.ExecuteNonQuery();

            bag.CloseConnection();

            MessageBox.Show("Bilgiler başarıyla güncellendi.", "Message");
        }

        private void GeriButton_Click(object sender, EventArgs e)
        {
            MusteriMenu gecis = new MusteriMenu();
            gecis.Show();
            this.Hide();
        }
        
    }
}
