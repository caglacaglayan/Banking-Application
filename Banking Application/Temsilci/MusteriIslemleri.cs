using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Bank.Temsilci
{
    public partial class MusteriIslemleri : Form
    {
        public MusteriIslemleri()
        {
            InitializeComponent();
        }

        DatabaseConnection bag = new DatabaseConnection();

        private void GeriButton_Click(object sender, EventArgs e)
        {
            TemsilciMenu gecis = new TemsilciMenu();
            gecis.Show();
            this.Hide();
        }
    }
}
