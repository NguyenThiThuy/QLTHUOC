using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLTHUOC.BLL
{
   public class NHANVIEN
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public Boolean GioiTinh { get; set; }
        public string TenDangNhap {get; set;}
        public string MatKhau {get; set;}
        public string ChucVu { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public int SDT { get; set; }

    }
}
