using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using quanlynhasach.HeThongXuLy;
using quanlynhasach.HeThongLuuTru;

namespace quanlynhasach.HeThongGiaoDien
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            NguoiDungDTO nd = new NguoiDungDTO();
            nd.TenNguoiDung = txtTaiKhoan.Text;
            nd.MatKhau = txtMatKhau.Text;
            nd.PhanQuyen = cmbphanquyen.Text;
            bool isLogin = NguoiDungDAO.KiemTraNguoiDung(nd);
            if (isLogin == true)
            {
                this.Hide();
                frmmain f1 = new frmmain();
                f1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai tên người dùng, mật khẩu hoặc quyền đăng nhập!", "Cảnh báo");
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            cmbphanquyen.Items.Add("User");
            cmbphanquyen.Items.Add("Admin");
        }
    }
}