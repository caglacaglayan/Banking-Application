using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CG_Bank.Musteri
{
    public partial class HesapAyrintilari : Form
    {
        public HesapAyrintilari(int id)
        {
            InitializeComponent();
        }

        DatabaseConnection bag = new DatabaseConnection();
    }
}
