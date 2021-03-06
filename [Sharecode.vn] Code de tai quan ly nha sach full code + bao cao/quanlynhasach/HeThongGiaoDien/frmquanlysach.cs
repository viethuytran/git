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
    public partial class frmquanlysach : Form
    {
        public frmquanlysach()
        {
            InitializeComponent();
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {        
            dgvTheLoai.ValueMember = "MaTheLoai";
            dgvTheLoai.DisplayMember = "TenTheLoai";
            dgvTheLoai.DataSource = TheLoaiDAO.GetTheLoaiAll();
            cbTheLoai.ValueMember = "MaTheLoai";
            cbTheLoai.DisplayMember = "TenTheLoai";
            cbTheLoai.DataSource = TheLoaiDAO.GetTheLoaiAll();
            cbTimTheLoai.ValueMember = "MaTheLoai";
            cbTimTheLoai.DisplayMember = "TenTheLoai";
            cbTimTheLoai.DataSource = TheLoaiDAO.GetTheLoaiAll();
            HienThiDanhSach();  
        }
        public void HienThiDanhSach()
        {
            dgvSach.DataSource = SachDAO.SelectSachAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SachDTO s = new SachDTO();
            s.TenSach = txtTenSach.Text;
            s.TacGia = txtTacGia.Text;
            try
            {
                s.SoLuongTon = int.Parse(txtSoLuongTon.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng tồn không được để trống và điền vào số");
                return;
            }
            s.GiaBan = int.Parse(txtGiaBan.Text);
            s.MaTheLoai = int.Parse(cbTheLoai.SelectedValue.ToString());

            if (SachBUS.ThemSach(s) == false)
            {
                MessageBox.Show("Sách đã tồn tại trong CSDL");
            }
            HienThiDanhSach();

        }

        private void dvSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSach.SelectedRows.Count > 0)
            {
                txtMaSach.Text = dgvSach.SelectedRows[0].Cells[0].Value.ToString();
                txtTenSach.Text = dgvSach.SelectedRows[0].Cells[1].Value.ToString();
                txtGiaBan.Text = dgvSach.SelectedRows[0].Cells[2].Value.ToString();
                txtSoLuongTon.Text = dgvSach.SelectedRows[0].Cells[3].Value.ToString();
                txtTacGia.Text = dgvSach.SelectedRows[0].Cells[4].Value.ToString();
                cbTheLoai.SelectedValue = dgvSach.SelectedRows[0].Cells[5].Value;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtGiaBan.Clear();
            txtSoLuongTon.Clear();
            txtTacGia.Clear(); 
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
                SachDTO s = new SachDTO();
                s.TenSach = dt.Rows[i].ItemArray[1].ToString();
                s.GiaBan = int.Parse(dt.Rows[i].ItemArray[2].ToString());
                s.SoLuongTon = int.Parse(dt.Rows[i].ItemArray[3].ToString());
                s.TacGia = dt.Rows[i].ItemArray[4].ToString();
                s.MaTheLoai = int.Parse(dt.Rows[i].ItemArray[5].ToString());
                SachDAO.Insert(s);
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
            List<String> list = myExcel.DGVToExcel(dgvSach);
            String filePath = Directory.GetCurrentDirectory() + strFileName;
            myExcel.WriteDateToExcel(strFileName, list, "A1", "F1", "A2");
            MessageBox.Show("Export dữ liệu thành công...", "Thông báo");
            Process.Start(strFileName);
        }

        private void cbTimTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string i = cbTimTheLoai.SelectedValue.ToString();
            HienThiDanhSach2(i);
        }
        public void HienThiDanhSach2(string ma)
        {
            SachDTO s = new SachDTO();
            s.MaTheLoai = int.Parse(ma);
            dgvSach.DataSource = SachDAO.SelectSachLikeMaTheLoai(s);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SachDTO s = new SachDTO();
            try
            {
                s.MaSach = int.Parse(txtMaSach.Text);
            }
            catch
            {
                MessageBox.Show("Mã sách không được rỗng chọn từ danh sách bên dưới để cập nhật");
            }
            if (SachBUS.XoaSach(s) == false)
            {
                MessageBox.Show("Mã sách không tồn tại trong CSDL");
            }
            HienThiDanhSach();
            MessageBox.Show("Xóa thành công");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SachDTO s = new SachDTO();
            try
            {
                s.MaSach = int.Parse(txtMaSach.Text);
            }
            catch
            {
                MessageBox.Show("Mã sách không được rỗng chọn từ danh sách bên dưới để cập nhật");
            }
            
            s.TenSach = txtTenSach.Text;
            s.TacGia = txtTacGia.Text;
            try
            {
                s.SoLuongTon = int.Parse(txtSoLuongTon.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng tồn không được để trống và điền vào số");
                return;
            }
            s.GiaBan = int.Parse(txtGiaBan.Text);
            s.MaTheLoai = int.Parse(cbTheLoai.SelectedValue.ToString());

            if (SachBUS.CapNhatSach(s) == false)
            {
                MessageBox.Show("Mã sách không tồn tại trong CSDL");
            }
            HienThiDanhSach();
            MessageBox.Show("Cập nhật thành công");
        }




    }
}