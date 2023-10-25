using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CG_Bank.Musteri
{
    public partial class AylikOzet : Form
    {
        public AylikOzet()
        {
            InitializeComponent();
        }

        private void GeriButton_Click(object sender, EventArgs e)
        {
            MusteriMenu gecis = new MusteriMenu();
            gecis.Show();
            this.Hide();
        }
    }
}
