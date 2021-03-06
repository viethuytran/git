using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using quanlynhasach.HeThongLuuTru;
using quanlynhasach.HeThongXuLy;
using System.IO;
using QuanLyNhaSach;
using System.Diagnostics;

namespace quanlynhasach.HeThongGiaoDien
{
    public partial class frmquanlytheloai : Form
    {
        TheLoaiDTO tlHienTai = new TheLoaiDTO();
        public frmquanlytheloai()
        {
            InitializeComponent();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        public void HienThiDanhSach()
        {
            dgvTheLoai.DataSource = TheLoaiDAO.GetTheLoaiAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TheLoaiDTO tl = new TheLoaiDTO();
            tl.TenTheLoai = txtTenTheLoai.Text;
            if (TheLoaiBUS.ThemTheLoai(tl) == false)
            { 
                MessageBox.Show("Du lieu nhap vao da co trong co so du lieu","Thong bao");
            }
            HienThiDanhSach();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            TheLoaiDTO tl = new TheLoaiDTO();
            tl.TenTheLoai = txtTenTheLoai.Text;
            if (TheLoaiBUS.XoaTheLoai(tl) == false)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                HienThiDanhSach();
            }
            
        }

        private void dgvTheLoai_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTheLoai.SelectedCells.Count > 0)
            {
                int row = dgvTheLoai.SelectedCells[0].RowIndex;
                DongToiTheLoaiHienTai(dgvTheLoai.Rows[row]);
                txtMaTheLoai.Text = tlHienTai.MaTheLoai.ToString();
                txtTenTheLoai.Text = tlHienTai.TenTheLoai;
            }
        }
        void DongToiTheLoaiHienTai(DataGridViewRow row)
        {
            tlHienTai.MaTheLoai = (int)row.Cells[0].Value;
            tlHienTai.TenTheLoai = (string)row.Cells[1].Value;
          
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            TheLoaiDTO tl = new TheLoaiDTO();
            tl.TenTheLoai = txtTenTheLoai.Text;
            tl.MaTheLoai = int.Parse(txtMaTheLoai.Text);
            if (TheLoaiBUS.SuaTheLoai(tl) == false)
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
            }
            else
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                HienThiDanhSach();
            }
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            string oldPath = Directory.GetCurrentDirectory();
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            string strPathName = of.FileName;
            Directory.SetCurrentDirectory(oldPath);
            DataTable dt = ExcelRead.getSheet(strPathName, "sheet1");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TheLoaiDTO tl = new TheLoaiDTO();
                tl.TenTheLoai = dt.Rows[i].ItemArray[1].ToString();
                TheLoaiDAO.Insert(tl);
            }
            MessageBox.Show("Import dữ liệu thành công ...", "Thông báo");
            HienThiDanhSach();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

            string oldPath = Directory.GetCurrentDirectory();
            SaveFileDialog sf = new SaveFileDialog();
            sf.ShowDialog();
            string strFileName = sf.FileName;
            Directory.SetCurrentDirectory(oldPath);
            ExcelWrite myExcel = new ExcelWrite();
            List<String> list = myExcel.DGVToExcel(dgvTheLoai);
            String filePath = Directory.GetCurrentDirectory() + strFileName;
            myExcel.WriteDateToExcel(strFileName, list, "A1", "B1", "A2");
            MessageBox.Show("Export dữ liệu thành công...", "Thông báo");
            Process.Start(strFileName);
        }
        
       
    }
}