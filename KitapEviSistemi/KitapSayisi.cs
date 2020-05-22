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
    public partial class KitapSayisi : Form
    {
        public KitapSayisi()
        {
            InitializeComponent();
        }

        private void Adetbtn_Click(object sender, EventArgs e)
        {
            Ekle kitapSayisi = new Ekle();
            new Ekle().Show();
        }
    }
}
