using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CG_Bank.Temsilci
{
    public partial class MusteriEkle : Form
    {
        int id2;
        public MusteriEkle(int id)
        {
            InitializeComponent();
            id2 = id;
        }

        DatabaseConnection bag = new DatabaseConnection();

        private void KaydetButton_Click(object sender, EventArgs e)
        {
            try
            {
                bag.OpenConnection();
                string kayit = "insert into Musteriler (Ad, Soyad, Telefon, Mail, TC_No, Adres, Sifre)" +
                    "values(@ad, @soyad, @telefon, @mail, @tc, @adres, @sifre)";
                string kayit2 = "insert into Musteri_Temsilci (Musteri_Id,Temsilci_Id) values(@musteriid,@temsilciid)";

                SqlCommand komut = new SqlCommand(kayit, bag.connection);
                komut.Parameters.AddWithValue("@ad", AdBox.Text);
                komut.Parameters.AddWithValue("@soyad", SoyadBox.Text);
                komut.Parameters.AddWithValue("@telefon", TelefonBox.Text);
                komut.Parameters.AddWithValue("@mail", MailBox.Text);
                komut.Parameters.AddWithValue("@tc", TCBox.Text);
                komut.Parameters.AddWithValue("@adres", AdresBox.Text);
                komut.Parameters.AddWithValue("@sifre", SifreBox.Text);

                komut.ExecuteNonQuery();

                string musteri = "Select Max(Id) From Musteriler";
                SqlCommand cmd = new SqlCommand(musteri, bag.connection);
                int musteriid = Convert.ToInt32(cmd.ExecuteScalar());

                string temsilci = "Select Id From Temsilciler Where Id='" + id2 + "'";
                SqlCommand cmd2 = new SqlCommand(temsilci, bag.connection);
                int temsilciid = Convert.ToInt32(cmd2.ExecuteScalar());

                SqlCommand komut2 = new SqlCommand(kayit2, bag.connection);

                komut2.Parameters.AddWithValue("@musteriid", musteriid);
                komut2.Parameters.AddWithValue("@temsilciid", temsilciid);

                komut2.ExecuteNonQuery();
                bag.CloseConnection();

                MessageBox.Show("Müşteri başarıyla eklendi!", "Message");

            }

            catch (Exception hata)
            {
                MessageBox.Show("Bu TC kimlik numarasina sahip müşteri zaten sistemde kayıtlı!", "Message");
            }
            
        }

        private void GeriButton_Click(object sender, EventArgs e)
        {
            MusteriListesi gecis = new MusteriListesi();
            gecis.Show();
            this.Hide();
        }

    }
}
