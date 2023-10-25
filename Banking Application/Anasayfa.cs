using CG_Bank.Musteri;
using CG_Bank.Mudur;
using CG_Bank.Temsilci;
using System;
using System.Windows.Forms;


namespace CG_Bank
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void toMusteriGiris_Click(object sender, EventArgs e)
        {
            MusteriGiris gecis = new MusteriGiris();
            gecis.Show();
            this.Hide();
        }

        private void toTemsilciGiris_Click(object sender, EventArgs e)
        {
            TemsilciGiris gecis = new TemsilciGiris();
            gecis.Show();
            this.Hide();
        }

        private void toMudurGiris_Click(object sender, EventArgs e)
        {
            MudurGiris gecis = new MudurGiris();
            gecis.Show();
            this.Hide();
        }
    }
}
