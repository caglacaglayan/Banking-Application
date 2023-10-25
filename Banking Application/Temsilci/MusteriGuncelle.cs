using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CG_Bank.Temsilci
{
    public partial class MusteriGuncelle : Form
    {
        int id1;
        public MusteriGuncelle(int id)
        {
            InitializeComponent();
            VeriGetir(id);
            id1 = id;
        }

        DatabaseConnection bag = new DatabaseConnection();

        void VeriGetir(int id)
        {
            string ara = "Select Telefon, Mail, Adres, Sifre From Musteriler Where Id='" + id + "'";
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
            bag.OpenConnection();
            string guncel = "Update Musteriler Set Adres=@adres, Telefon=@telefon, Mail=@mail, Sifre=@sifre, Where Id=@id";
            SqlCommand komut = new SqlCommand(guncel, bag.connection);
            komut.Parameters.AddWithValue("@id", id1);
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
            MusteriListesi gecis = new MusteriListesi();
            gecis.Show();
            this.Hide();
        }

    }
}
