using System;
using System.Windows.Forms;

namespace CG_Bank.Musteri
{
    public partial class MusteriGiris : Form
    {
        public MusteriGiris()
        {
            InitializeComponent();
        }

        DatabaseConnection bag = new DatabaseConnection();

        public static string tcno;
        public static int id;

        private void AnasayfaButton_Click(object sender, EventArgs e)
        {
            Anasayfa gecis = new Anasayfa();
            gecis.Show();
            this.Hide();
        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            tcno = TCBox.Text;

            string com = "Select * From Musteriler Where TC_No='" + TCBox.Text + "'And Sifre='" + SifreBox.Text + "'";
            var dr = bag.DataReader(com);

            if (dr.Read())
            {
                MusteriMenu gecis = new MusteriMenu();
                gecis.Show();
                this.Hide();
                bag.CloseConnection();
                IdCek();
            }

            else
            {
                MessageBox.Show("TC No veya şifre hatalı!", "Message");
                bag.CloseConnection();
            }
        }

        public void IdCek()
        {

            string com = "Select Id From Musteriler Where TC_No='" + tcno + "'";

            var dr = bag.DataReader(com);

            if (dr.Read())
            {
                id = Convert.ToInt32(dr["Id"].ToString());
            }

            bag.CloseConnection();
        }
    }
}
