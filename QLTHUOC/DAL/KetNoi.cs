using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;



namespace QLTHUOC.DAL
{
    static public class KetNoi
    {
        static public SqlConnection GetConnection()
        {

            string Chuoi_Ket_Noi = ConfigurationManager.ConnectionStrings["KetNoi"].ConnectionString;
            SqlConnection kn = new SqlConnection(Chuoi_Ket_Noi);
            return kn;
        }
    }
}
