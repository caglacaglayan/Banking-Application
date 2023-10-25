using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CG_Bank.Temsilci
{
    public partial class MusteriDurumlari : Form
    {
        public MusteriDurumlari()
        {
            InitializeComponent();
            MusteriListele(TemsilciGiris.id);
        }

        DatabaseConnection bag = new DatabaseConnection();

        public void DurumListele(string j)
        {
            string listele = "Select Gelir, Gider, Bakiye " +
                "From Musteriler " +
                "Where TC_No='" + j + "'";

            dataGridView1.DataSource = bag.GridSqlProcess(listele);
        }

        public void MusteriListele(int id)
        {
            string listele = "Select * From Musteriler,Temsilciler,Musteri_Temsilci " +
                "Where Musteriler.Id=Musteri_Temsilci.Musteri_Id AND Musteri_Temsilci.Temsilci_Id=Temsilciler.Id AND Temsilciler.Id='" + id + "'";

            var dr = bag.DataReader(listele);

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["TC_No"]);
            }

            bag.CloseConnection();
        }

        private void ListeleButton_Click(object sender, EventArgs e)
        {
            DurumListele(j);
        }

        private void GeriButton_Click(object sender, EventArgs e)
        {
            TemsilciMenu gecis = new TemsilciMenu();
            gecis.Show();
            this.Hide();
        }

        int i = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
        }

        string j = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            j = comboBox1.SelectedItem.ToString();
        }
    }
}
