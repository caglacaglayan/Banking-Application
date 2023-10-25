using System;
using System.Windows.Forms;

namespace CG_Bank.Mudur
{
    public partial class MudurGiris : Form
    {
        public MudurGiris()
        {
            InitializeComponent();
        }

        DatabaseConnection bag = new DatabaseConnection();

        public static string tcno;

        private void AnasayfaButton_Click(object sender, EventArgs e)
        {
            Anasayfa gecis = new Anasayfa();
            gecis.Show();
            this.Hide();
        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            tcno = TCBox.Text;

            string com = "Select * From Mudur Where TC_No='" + TCBox.Text + "'And Sifre='" + SifreBox.Text + "'";
            var dr = bag.DataReader(com);

            if (dr.Read())
            {
                Anasayfa gecis = new Anasayfa();
                gecis.Show();
                this.Hide();
                bag.CloseConnection();
            }

            else
            {
                MessageBox.Show("TC No veya şifre hatalı!", "Message");
                bag.CloseConnection();
            }
        }
    }
}
