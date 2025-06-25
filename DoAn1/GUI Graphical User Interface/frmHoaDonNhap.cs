using BLL_Business_Logic_Layer;
using DTO_Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Graphical_User_Interface
{
    public partial class frmHoaDonNhap : Form
    {
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }

        private BLL_HoaDonNhap BLL_HoaDonNhap = new BLL_HoaDonNhap();
        private BLL_ChiTietHoaDonNhap BLL_ChiTietHoaDonNhap = new BLL_ChiTietHoaDonNhap();

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            int quyen = frmDangNhap.getQuyen();
            if (quyen == 0)
            {
                //đóng chức năng với nhân viên
                btSua.Enabled = false;
                btXoa.Enabled = false;
            }
            LoadTenNVB();
            btMoi_Click(sender, e);
        }

        private void LoadTenNVB()
        {
            cbbNhanVienNhap.DataSource = BLL_HoaDonNhap.LoadTenNVN();
            cbbNhanVienNhap.DisplayMember = "HoTenNV";
        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            dtgHoaDonNhap.DataSource = BLL_HoaDonNhap.HienThiHoaDonNhap();
            dtgChiTietHDN.DataSource = BLL_ChiTietHoaDonNhap.HienThiCTHoaDonNhap();
            ClassHoTro.Moi(panel1);
            dtpNgayNhap.Value = DateTime.Now;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //sửa hoá đơn nhập
                if (dtgHoaDonNhap.SelectedRows.Count > 0)
                {
                    string mahdn = tbMaHoaDonNhap.Text.ToString();
                    DateTime ngaynhap = DateTime.Parse(dtpNgayNhap.Value.ToShortDateString());
                    string nvnhap = cbbNhanVienNhap.Text.ToString();
                    try
                    {
                        DTO_HoaDonNhap hdn = new DTO_HoaDonNhap(mahdn, ngaynhap, int.Parse(tbTongTien.Text), nvnhap);
                        if (BLL_HoaDonNhap.SuaHoaDonNhap(hdn))
                        {
                            MessageBox.Show("Cập nhật thông tin hoá đơn nhập thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin hoá đơn nhập thất bại");
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("Cập nhật thông tin hoá đơn nhập thất bại");
                    }
                }
                //sửa chi tiết hoá đơn nhập
                if (dtgChiTietHDN.SelectedRows.Count > 0)
                {  
                    try
                    {
                        string ctmhdn = tbCTMaHoaDonNhap.Text.ToString();
                        string matruyen = cbbTruyen.Text.ToString();
                        int slnhap = int.Parse(nudSoLuong.Value.ToString());
                        int gianhap = int.Parse(tbGiaNhap.Text);
                        int thanhtien = int.Parse(tbThanhTien.Text);

                        if (BLL_ChiTietHoaDonNhap.SuaCTHoaDonNhap(ctmhdn, matruyen, slnhap, gianhap, thanhtien))
                        {
                            BLL_HoaDonNhap.CapNhatTongTien(ctmhdn);
                            MessageBox.Show("Cập nhật thông tin chi tiết hoá đơn nhập thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin chi tiết hoá đơn nhập thất bại");
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("Cập nhật thông tin chi tiết hoá đơn nhập thất bại");
                    }
                }
            }
            btMoi_Click(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_HoaDonNhap.XoaHoaDonNhap(tbMaHoaDonNhap.Text))
                    {
                        MessageBox.Show("Xóa thông tin hoá đơn nhập thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin hoá đơn nhập thất bại");
                    }
                }
                catch 
                {
                    MessageBox.Show("Xóa thông tin hoá đơn nhập thất bại");
                }

                if (dtgChiTietHDN.SelectedRows.Count > 0)
                {
                    try
                    {
                        string ctmhdn = tbCTMaHoaDonNhap.Text.ToString();
                        string matruyen = cbbTruyen.Text.ToString();
                        int slnhap = int.Parse(nudSoLuong.Value.ToString());
                        int gianhap = int.Parse(tbGiaNhap.Text);
                        int thanhtien = int.Parse(tbThanhTien.Text);

                        if (BLL_ChiTietHoaDonNhap.XoaCTHoaDonNhap(ctmhdn, matruyen, slnhap, gianhap, thanhtien))
                        {
                            BLL_HoaDonNhap.CapNhatTongTien(ctmhdn);
                            MessageBox.Show("Xoá thông tin chi tiết hoá đơn nhập thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xoá thông tin chi tiết hoá đơn nhập thất bại");
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("Xoá thông tin chi tiết hoá đơn nhập thất bại");
                    }
                }
            }
            btMoi_Click(sender, e);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string nvnhap = tbTimKiem.Text;
            dtgHoaDonNhap.DataSource = BLL_HoaDonNhap.TimHoaDonNhap(nvnhap);
            dtgChiTietHDN.DataSource = BLL_ChiTietHoaDonNhap.TimCTHoaDonNhap(nvnhap);
        }

        private void dtgHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgHoaDonNhap.Rows[e.RowIndex];
                tbMaHoaDonNhap.Text = row.Cells["MaHoaDonNhap"].Value.ToString();
                if (row.Cells["NgayNhap"].Value is DBNull)
                {
                    dtpNgayNhap.Value = DateTime.Now;
                }
                else
                {
                    dtpNgayNhap.Value = (DateTime)row.Cells["NgayNhap"].Value;
                }
                tbTongTien.Text = row.Cells["TongTien"].Value.ToString();
                cbbNhanVienNhap.Text = row.Cells["NhanVienNhap"].Value.ToString();
            }
        }

        private void dtgChiTietHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgChiTietHDN.Rows[e.RowIndex];
                tbCTMaHoaDonNhap.Text = row.Cells["CTMaHoaDonNhap"].Value.ToString();
                cbbTruyen.Text = row.Cells["TenTruyen"].Value.ToString();
                tbGiaNhap.Text = row.Cells["GiaNhap"].Value.ToString();
                nudSoLuong.Text = row.Cells["SoLuongNhap"].Value.ToString();
                tbThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();
            }
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                // Khi số lượng thay đổi, tính toán lại thành tiền
                int thanhTien = int.Parse(tbGiaNhap.Text) * (int)nudSoLuong.Value;
                tbThanhTien.Text = thanhTien.ToString();
            }
            catch { }
        }

        private void tbGiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbGiaNhap.Text) && int.TryParse(nudSoLuong.Text, out int donGiaNhap))
            {
                int soLuong = (int)nudSoLuong.Value;
                float thanhTien = donGiaNhap * soLuong;
                tbThanhTien.Text = thanhTien.ToString();
            }
        }


        private void dtgHoaDonNhap_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgHoaDonNhap.Columns[e.ColumnIndex].Name == "TongTien")
            {
                if (e.Value is int giaTien)
                {
                    // Định dạng giá trị kiểu int thành chuỗi với dấu phẩy ngăn cách hàng nghìn
                    e.Value = giaTien.ToString("N0");
                    e.FormattingApplied = true; // Đánh dấu đã xử lý định dạng
                }
            }
        }

        private void dtgChiTietHDN_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgChiTietHDN.Columns[e.ColumnIndex].Name == "GiaNhap" || dtgChiTietHDN.Columns[e.ColumnIndex].Name == "ThanhTien")
            {
                if (e.Value is int giaTien)
                {
                    // Định dạng giá trị kiểu int thành chuỗi với dấu phẩy ngăn cách hàng nghìn
                    e.Value = giaTien.ToString("N0");
                    e.FormattingApplied = true; // Đánh dấu đã xử lý định dạng
                }
            }
        }
    }
}
