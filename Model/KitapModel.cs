using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class KitapModel
    {
        

        public KitapModel(string KitapId, string BasimTarihi, string KitapTürü, string KitapAdi, string YazarBilgileri)
        {
            KitapId = kitapId;
            BasimTarihi = basimTarihi;
            KitapTürü = kitapTürü;
            KitapAdi = kitapAdi;
            YazarBilgileri = yazarBilgileri;
            
        }
        public KitapModel(string BasimTarihi, string KitapTürü, string KitapAdi, string YazarBilgileri)
        {

            BasimTarihi = basimTarihi;
            KitapTürü = kitapTürü;
            KitapAdi = kitapAdi;
            YazarBilgileri = yazarBilgileri;
        }

        public string kitapId { get; set; }
        public string basimTarihi { get; set; }
        public string kitapTürü { get; set; }
        public string kitapAdi { get; set; }
        public string YazarBilgileri { get; set; }
        public string yazarBilgileri { get; }

       
        
    }
}


