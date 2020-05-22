using KitapEviDAL;
using Model;
using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapEviSistemi
{
    public partial class Listeleme : Form
    {
        public Listeleme()
        {
            InitializeComponent();
        }

        private void gridliste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtkitap.Rows[e.RowIndex].Cells["GorevliNo"] != null)
            {
                txtbasimtarih.Text = dtkitap.Rows[e.RowIndex].Cells["Basım Tarihi"].Value.ToString();
                txtkitaptürü.Text = dtkitap.Rows[e.RowIndex].Cells["Kitap Türü"].Value.ToString();
                txtkitapadi.Text = dtkitap.Rows[e.RowIndex].Cells["Kitap Adı"].Value.ToString();
                txtyazarbilgileri.Text = dtkitap.Rows[e.RowIndex].Cells["Yazar Bilgileri"].Value.ToString();
            }


        }
    }
}
