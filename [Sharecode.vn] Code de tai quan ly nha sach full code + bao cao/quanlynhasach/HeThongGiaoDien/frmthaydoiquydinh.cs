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
    public partial class frmthaydoiquydinh : Form
    {
        public frmthaydoiquydinh()
        {
            InitializeComponent();
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthaydoi_Click(object sender, EventArgs e)
        {
            DataTable dt = ThamSoDAO.GetThamSoAll();
            int mathamso = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            ThamSoDTO ts = new ThamSoDTO();
            ts.MaThamSo = mathamso;
            if (chkchophep.Checked == true)
            {
                ts.DieuKienThu = 1;
            }
            else
            {
                ts.DieuKienThu = 0;
            }
            try
            {
                ts.SoLuongNhapMin = UInt64.Parse(txtslnhapmin.Text);
                ts.LuongTonMin = UInt64.Parse(txtdssltonmin.Text);
                ts.NoMin = UInt64.Parse(txttiennomin.Text);
                ts.TonSauKhiBan = UInt64.Parse(txtsltonsaukhiban.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn phải nhập vào kiểu số");

            }
            catch (OverflowException)
            {
                MessageBox.Show("Số không được âm");
            }

            ThamSoDAO.Update(ts);
            MessageBox.Show("Thay đổi thành công");
        }

        private void btnmacdinh_Click(object sender, EventArgs e)
        {
            txtslnhapmin.Text = "150";
            txtdssltonmin.Text = "300";
            txttiennomin.Text = "20000";
            txtsltonsaukhiban.Text = "20";
            chkchophep.Checked = true;
        }
    }
}