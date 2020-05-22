using BL;
using Model;
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
    public partial class Ekle : Form
    {
        public Ekle()
        {
            InitializeComponent();
        }

        private void kaydetbtn_Click(object sender, EventArgs e)
        {
            KitapBL gorevli = new KitapBL();
            if (gorevli.KitapEkle(new KitapModel(txtbasimtarih.Text,txtkitapsayısı.Text,txtkitaptürü.Text, txtkitapadi.Text, txtyazarbilgileri.Text)))
            {
                MessageBox.Show("Kitap Eklendi");
                dtkitap.DataSource = "";
                dtkitap.DataSource = new KitapBL().KitapListeTablo();
            }
            else 
            {
                MessageBox.Show("Kitap Eklenemedi");
            }
        }
    }
}
