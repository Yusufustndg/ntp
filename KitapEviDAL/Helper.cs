using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEviDAL
{
    public class Helper
    {
        public int ExecuteNonQuery(string komuttext, SqlParameter[] p, CommandType type = CommandType.StoredProcedure)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
                using (SqlCommand komut = new SqlCommand(komuttext, baglanti))
                {
                    baglanti.Open();
                    komut.CommandType = type;
                    if (p != null)
                    {
                        komut.Parameters.AddRange(p);

                    }
                    return komut.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public SqlDataReader ExecuteReader(string komuttext, SqlParameter[] p = null, CommandType type = CommandType.StoredProcedure)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);

                using (SqlCommand komut = new SqlCommand(komuttext, baglanti))
                {
                    baglanti.Open();
                    komut.CommandType = type;
                    if (p != null)
                    {
                        komut.Parameters.AddRange(p);
                    }
                    return komut.ExecuteReader(CommandBehavior.CloseConnection);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataTable MyDataTable(string cmdtext, SqlParameter[] p = null, CommandType type = CommandType.StoredProcedure)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmdtext, cn);
                da.SelectCommand.CommandType = type;
                if (p != null)
                {
                    da.SelectCommand.Parameters.AddRange(p);
                }
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
