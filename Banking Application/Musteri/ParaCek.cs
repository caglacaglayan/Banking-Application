﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CG_Bank.Musteri
{
    public partial class ParaCek : Form
    {
        public ParaCek()
        {
            InitializeComponent();
            HesapListele();
        }

        DatabaseConnection bag = new DatabaseConnection();

        private void GeriButton_Click(object sender, EventArgs e)
        {
            MusteriMenu gecis = new MusteriMenu();
            gecis.Show();
            this.Hide();
        }

        public void HesapListele()
        {
            string listele = "Select Id From Musteri_Hesaplari Where Musteri_Id='"+MusteriGiris.id+"'";

            var dr = bag.DataReader(listele);

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Id"]);
            }

            bag.CloseConnection();
        }

        int j;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            j = Convert.ToInt32(comboBox1.SelectedItem.ToString());
        }

        int tutar;
        int mevcut;
        private void ParaCekButton_Click(object sender, EventArgs e)
        {
            tutar = Convert.ToInt32(TutarBox.Text);

            string mevcutbul = "Select Bakiye From Musteri_Hesaplari Where Id='" +j+ "'";
            var dr = bag.DataReader(mevcutbul);

            if (dr.Read())
            {
                mevcut = Convert.ToInt32(dr["Bakiye"]);
            }
            bag.CloseConnection();

            if (mevcut - tutar < 0)
            {
                MessageBox.Show("Yetersiz bakiye!", "Message");
            }
            else
            {
                int yeni = mevcut - tutar;
                string guncelle = "Update Musteri_Hesaplari Set Bakiye='" + yeni + "' Where Id='" + j + "'";
                bag.SqlProcess(guncelle);
                MessageBox.Show("Para çekme işlemi başarılı!", "Message");
            }
        }
    }
}
