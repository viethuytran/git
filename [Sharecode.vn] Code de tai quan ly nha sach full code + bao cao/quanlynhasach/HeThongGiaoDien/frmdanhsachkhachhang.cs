using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using quanlynhasach.HeThongLuuTru;
using quanlynhasach.HeThongXuLy;

namespace quanlynhasach.HeThongGiaoDien
{
    public partial class frmdanhsachkhachhang : Form
    {
        public frmdanhsachkhachhang()
        {
            InitializeComponent();
        }

        private void frmdanhsachkhachhang_Load(object sender, EventArgs e)
        {
            hienthidanhsach();
        }
        public void hienthidanhsach()
        {
            dskhachhang.DataSource = KhachHangDAO.GetKhachHangAll();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radtatca_CheckedChanged(object sender, EventArgs e)
        {
            hienthidanhsach();
        }

        private void raddienthoai_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Text = "0";
            timkiemdienthoai();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (radtenkh.Checked == true)
            {
                timkiemtenkh();
            }
            if (raddiachi.Checked == true)
            {
                timkiemdiachi();
            }
            if (raddienthoai.Checked == true)
            {
                timkiemdienthoai();
            }
            if (rademail.Checked == true)
            {
                timkiememail();
            }
        }
        public void timkiemtenkh()
        {

            KhachHangDTO kh = new KhachHangDTO();
            kh.HoTenKhachHang = txttimkiem.Text;
            dskhachhang.DataSource = KhachHangDAO.SelectKhachHangLikeTen(kh);
        }
        public void timkiemdiachi()
        {

            KhachHangDTO kh = new KhachHangDTO();
            kh.DiaChi = txttimkiem.Text;
            dskhachhang.DataSource = KhachHangDAO.SelectKhachHangLikeDiaChi(kh);
        }
        public void timkiememail()
        {

            KhachHangDTO kh = new KhachHangDTO();
            kh.Email = txttimkiem.Text;
            dskhachhang.DataSource = KhachHangDAO.SelectKhachHangLikeEmail(kh);
        }
        public void timkiemdienthoai()
        {
            KhachHangDTO kh = new KhachHangDTO();
            try
            {
                kh.DienThoai = Int64.Parse(txttimkiem.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Điện thoại phải điền vào số", "Thông báo");
                return;
            }
            dskhachhang.DataSource = KhachHangDAO.SelectKhachHangLikeDienThoai(kh);
        }

        private void rademail_CheckedChanged(object sender, EventArgs e)
        {
            timkiememail();
        }

        private void raddiachi_CheckedChanged(object sender, EventArgs e)
        {
            timkiemdiachi();
        }

        private void radtenkh_CheckedChanged(object sender, EventArgs e)
        {
            timkiemtenkh();
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            if (dskhachhang.SelectedRows.Count > 0)
            {
                frmphieuthutien.makh = dskhachhang.SelectedRows[0].Cells[0].Value.ToString();
                frmhoadonbansach.makh= dskhachhang.SelectedRows[0].Cells[0].Value.ToString();
            }
            this.Close();
        }
    }
}