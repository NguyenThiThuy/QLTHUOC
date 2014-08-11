using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using QLTHUOC.BLL;

namespace QLTHUOC.DAL
{
    public class NhanVienDB
    {
        /// <summary>
        /// lấy các nhân viên theo câu lệnh sql
        /// </summary>
        /// <param name="Sql"></param>
        /// <returns></returns>
        static public List<NhanVienBL> SelecBySql(String Sql)
        {
            SqlConnection Connection = KetNoi.GetConnection();
            try
            {
                SqlCommand Command = new SqlCommand(Sql, Connection);

                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                List<NhanVienBL> Items = new List<NhanVienBL>();
                while (Reader.Read())
                {
                    NhanVienBL Item = new NhanVienBL
                    {
                        MaNV = Convert.ToString(Reader["MaNV"]),
                        TenNV = Convert.ToString(Reader["TenNV"]),
                        MatKhau = Convert.ToString(Reader["MatKhau"]),
                        NgaySinh = Convert.ToDateTime(Reader["NgaySinh"]),
                        GioiTinh = Convert.ToBoolean(Reader["GioiTinh"]),
                        DiaChi = Convert.ToString(Reader["DiaChi"]),
                        TenDangNhap = Convert.ToString(Reader["TenDangNhap"]),
                        ChucVu = Convert.ToString(Reader["ChucVu"]),
                        Email=Convert.ToString(Reader["Email"]),
                        SDT=Convert.ToInt32(Reader["SDT"])
                    };

                    Items.Add(Item);
                }

                Connection.Close();
                return Items;
            }
            finally
            {
                Connection.Close();
            }

        }
        /// <summary>
        /// Lấy tên đăng nhập của nhân viên
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public NhanVienBL LayTenDangNhap(string id)
        {
            string Sql = @"SELECT * FROM NhanVien WHERE TenDangNhap = '" + id + "'";
            List<NhanVienBL> items = NhanVienDB.SelecBySql(Sql);
            return items[0];

        }
    }
}
