using KitapEviDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class KitapBL
    {

        public DataTable KitapListeTablo()
        {
            Helper hlp = new Helper();
            DataTable dt = hlp.MyDataTable("spGorevliListesi");
            if (dt != null)
            {
                return dt;
            }
            return dt;
        }
        public bool KitapEkle(KitapModel Kitap)
        {
            try
            {
                Helper hlp = new Helper();
                SqlParameter[] p =
                {
                    new SqlParameter("@KitapAdi",Kitap.kitapAdi),
                    new SqlParameter("@YazarBilgileri",Kitap.yazarBilgileri),
                    new SqlParameter("@KitapBasimTarihi",Kitap.basimTarihi),
                    new SqlParameter("@KitapTürü",Kitap.kitapTürü),
                    //new SqlParameter("@KitapId",Kitap.kitapId),
                };
                return hlp.ExecuteNonQuery("spKitapEkle", p) > 0;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
