using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

using QLTHUOC.BLL;
using QLTHUOC.DAL;

namespace QLTHUOC.GIAODIEN
{
    
    public partial class DangNhap : DevComponents.DotNetBar.OfficeForm
    {
        
        
        public DangNhap()
        {
            InitializeComponent();
        }

        NhanVienBL nv;
        public NhanVienBL Gettaikhoan()
        {
            return nv;
        }
        
        /// <summary>
        /// kiểm lỗi
        /// </summary>
        /// <returns></returns>
        bool KiemLoi()
        {
            StringBuilder Errors = new StringBuilder();
            if (txtTaiKhoan.TextLength == 0)//kiểm lỗi bỏ trống tên tài khoản
            {
                Errors.AppendLine("Vui lòng nhập tên tài khoản !");
                errorProvider1.SetError(txtTaiKhoan, "Vui lòng nhập tên tài khoản !");
                txtTaiKhoan.Focus();
            }
            else if (txtTaiKhoan.TextLength < 8)//kiểm lỗi độ dài kí tự tên tài khoản
            {
                Errors.AppendLine("Tài khoản phải có ít nhất 8 ký tự !");
                errorProvider1.SetError(txtTaiKhoan, "Tài khoản phải có ít nhất 8 ký tự ");
                txtTaiKhoan.Text = "";
                txtTaiKhoan.Focus();
            }
            if (txtMatKhau.TextLength == 0)//kiểm lỗi bỏ trống mật khẩu
            {
                Errors.AppendLine("Vui lòng nhập mật khẩu !");
                errorProvider1.SetError(txtMatKhau, "Vui lòng nhập mật khẩu !");
                txtMatKhau.Focus();
            }
            else if (txtMatKhau.TextLength < 8)//kiểm lỗi độ dài kí tự của mật khẩu
            {
                Errors.AppendLine("Mật khẩu phải có ít nhất 8 ký tự !");
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có ít nhất 8 ký tự !");
                txtMatKhau.Text = "";
                txtMatKhau.Focus();
            }
            if (Errors.Length > 0)
            {
                MessageBox.Show(Errors.ToString(), "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
                string id = txtTaiKhoan.Text;
                string pass = txtMatKhau.Text;
                nv = NhanVienDB.LayTenDangNhap(id);
            if(KiemLoi() == false)//kiểm lỗi
            {
                return;
            }
            else
            {
                
                //Nếu tài khoản đúng thì hiển thị thông báo chào mừng
                
                    if (nv.MatKhau == pass)
                    {
                        if (nv.ChucVu == "Quản Lí")
                        {
                            MessageBox.Show("Chào mừng quản lí " + nv.TenNV + " đã đăng nhập");
                        }

                        else if (nv.ChucVu == "Nhập Kho")
                        {
                            MessageBox.Show("Chào mừng nhân viên nhập kho" + nv.TenNV + "đã đăng nhập");
                        }
                        else
                        {
                            MessageBox.Show("Chào mừng nhân viên xuất kho " + nv.TenNV + " đã đăng nhập");
                        }
                        this.Close();
                    }
                
                //hoặc báo lỗi sai tài khoản 
                else
                {
                    MessageBox.Show("Mật khẩu hoặc tên đăng nhập không đúng, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Text = "";
                    txtTaiKhoan.Text = "";
                }
            }
        }

        
    }
}