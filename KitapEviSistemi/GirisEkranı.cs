using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapEviSistemi
{
    public partial class GirisEkranı : Form
    {
        public GirisEkranı()
        {
            InitializeComponent();
        }

        private void GörList_Click(object sender, EventArgs e)
        {
            Listeleme listeleme = new Listeleme();
            new Listeleme().Show();
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {

            KitapSayisi kitapSayisi = new KitapSayisi();
            new KitapSayisi().Show();
        }
    }
}
