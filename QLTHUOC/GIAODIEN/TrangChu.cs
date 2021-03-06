using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

using QLTHUOC.BLL;

namespace QLTHUOC.GIAODIEN
{
    public partial class TrangChu : DevComponents.DotNetBar.RibbonForm
    {
        public TrangChu()
        {
            InitializeComponent();
        }
        NhanVienBL nv;
        public NhanVienBL Gettaikhoan()
        {
            return nv;
        }
        private void TrangChu_Load(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.ShowDialog();
            nv = dn.Gettaikhoan();
            lblTenTaiKhoan.Text = nv.TenNV;

            if (nv.ChucVu == "Quản Lí")//quyền của quản lí
            {
                btnDangNhap.Enabled = true;
                btnDangXuat.Enabled = true;
                btnDoiMatKhau.Enabled = true;
                //btnLapHoaDon.Enabled = false;
                //btnQLHoaDon.Enabled = true;
                btnPhieuNhap.Enabled = false;
                //btnQLPhieuNhap.Enabled = true;
                btnThuoc.Enabled = false;
                btnCuaHang.Enabled = false;
                btnNhaCC.Enabled = false;
                btnNhanVien.Enabled = true;
                btnQLThuoc.Enabled = false;
                btnPhieuNhap.Enabled = false;
                btnHoaDon.Enabled = false;
                //btnQLPN.Enabled = true;
                //btnQLHD.Enabled = true;
                btnPhieuXuat.Enabled = false;
                btnThoat.Enabled = true;
                btnXuat.Enabled = false;
                btnNhap.Enabled = false;

            }
      

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
        }

       

       
    }
}