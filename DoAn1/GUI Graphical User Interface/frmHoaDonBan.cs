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
    public partial class frmHoaDonBan : Form
    {
        private BLL_HoaDonBan BLL_HoaDonBan = new BLL_HoaDonBan();
        private BLL_ChiTietHoaDonBan BLL_ChiTietHoaDonBan = new BLL_ChiTietHoaDonBan();

        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            int quyen = frmDangNhap.getQuyen();
            if (quyen == 0)
            {
                //đóng chức năng với nhân viên
                btSua.Enabled = false;
                btXoa.Enabled = false;
            }
            LoadTenNVB();
            LoadMaKHTV();
            LoadTenTruyen();
            btMoi_Click(sender, e);
        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            dtgHoaDonBan.DataSource = BLL_HoaDonBan.HienThiHoaDonBan();
            dtgChiTietHoaDonBan.DataSource = BLL_ChiTietHoaDonBan.HienThiCTHoaDonBan();
            ClassHoTro.Moi(panel1);
            dtpNgayBan.Value = DateTime.Now;
        }

        private void LoadTenNVB()
        {
            cbbNhanVienBan.DataSource = BLL_HoaDonBan.LoadTenNVB();
            cbbNhanVienBan.DisplayMember = "HoTenNV";
        }
        private void LoadMaKHTV()
        {
            cbbMaKHTV.DataSource = BLL_HoaDonBan.LoadMaKHTV();
            cbbMaKHTV.DisplayMember = "MaKHTV";
        }

        private void LoadTenTruyen()
        {
            cbbTruyen.DataSource = BLL_ChiTietHoaDonBan.LoadTenTruyen();
            cbbTruyen.DisplayMember = "TenTruyen";
        }


        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //sửa hoá đơn
                if (dtgHoaDonBan.SelectedRows.Count > 0)
                {
                    string mahdb = tbMaHoaDonBan.Text.ToString();
                    DateTime ngayban = DateTime.Parse(dtpNgayBan.Value.ToShortDateString());
                    string nvban = cbbNhanVienBan.Text.ToString();
                    string khtv = cbbMaKHTV.Text.ToString();
                    try
                    {
                        DTO_HoaDonBan hdb = new DTO_HoaDonBan(mahdb, ngayban, int.Parse(tbTongTien.Text), nvban, khtv);
                        if (BLL_HoaDonBan.SuaHoaDonBan(hdb))
                        {
                            MessageBox.Show("Cập nhật thông tin hoá đơn bán thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin hoá đơn bán thất bại");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Cập nhật thông tin hoá đơn bán thất bại");
                    }
                }

                //sửa chi tiết hoá đơn
                if (dtgChiTietHoaDonBan.SelectedRows.Count > 0)
                {
                    try
                    {
                        string ctmahdb = tbCTMaHoaDonBan.Text.ToString();
                        string matruyen = cbbTruyen.Text.ToString();
                        int slban = int.Parse(nudSoLuong.Value.ToString());
                        int giaban = int.Parse(tbGiaBan.Text);
                        int thanhtien = int.Parse(tbThanhTien.Text);

                        if (BLL_ChiTietHoaDonBan.SuaCTHoaDonBan(ctmahdb, matruyen, slban, giaban, thanhtien))
                        {
                            BLL_HoaDonBan.CapNhatTongTien(ctmahdb);
                            MessageBox.Show("Cập nhật thông tin chi tiết hoá đơn bán thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin chi tiết hoá đơn bán thất bại");
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("Cập nhật thông tin chi tiết hoá đơn bán thất bại");
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
                    if (BLL_HoaDonBan.XoaHoaDonBan(tbMaHoaDonBan.Text))
                    {
                        MessageBox.Show("Xóa thông tin hoá đơn bán thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin hoá đơn bán thất bại");
                    }
                }
                catch  
                {
                    MessageBox.Show("Xóa thông tin hoá đơn bán thất bại");
                }


                //xoá chi tiết hoá đơn
                if (dtgChiTietHoaDonBan.SelectedRows.Count > 0)
                {
                    try
                    {
                        string ctmahdb = tbCTMaHoaDonBan.Text.ToString();
                        string matruyen = cbbTruyen.Text.ToString();
                        int slban = int.Parse(nudSoLuong.Value.ToString());
                        int giaban = int.Parse(tbGiaBan.Text);
                        int thanhtien = int.Parse(tbThanhTien.Text);
                        if (BLL_ChiTietHoaDonBan.XoaCTHoaDonBan(ctmahdb, matruyen, slban, giaban, thanhtien))
                        {
                            BLL_HoaDonBan.CapNhatTongTien(ctmahdb);
                            MessageBox.Show("Xoá thông tin chi tiết hoá đơn bán thành công");
                        }
                        else
                        {
                            MessageBox.Show("Xoá thông tin chi tiết hoá đơn bán thất bại");
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("Xoá thông tin chi tiết hoá đơn bán thất bại");
                    }
                }
            }
            btMoi_Click(sender, e);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string nvban = tbTimKiem.Text;
            dtgHoaDonBan.DataSource = BLL_HoaDonBan.TimHoaDonBan(nvban);
            dtgChiTietHoaDonBan.DataSource = BLL_ChiTietHoaDonBan.TimCTHoaDonBan(nvban);
        }

        private void dtgHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dtgHoaDonBan.Rows[e.RowIndex];
                    tbMaHoaDonBan.Text = row.Cells["MaHoaDonBan"].Value.ToString();
                    if (row.Cells["NgayBan"].Value is DBNull)
                    {
                        dtpNgayBan.Value = DateTime.Now;
                    }
                    else
                    {
                        dtpNgayBan.Value = (DateTime)row.Cells["NgayBan"].Value;
                    }
                    tbTongTien.Text = row.Cells["TongTien"].Value.ToString();
                    cbbNhanVienBan.Text = row.Cells["NhanVienBan"].Value.ToString();
                    cbbMaKHTV.Text = row.Cells["KhachHangThanhVien"].Value.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void dtgChiTietHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow row = this.dtgChiTietHoaDonBan.Rows[e.RowIndex];
                    tbCTMaHoaDonBan.Text = row.Cells["CTMaHoaDonBan"].Value.ToString();
                    cbbTruyen.Text = row.Cells["MaTruyen"].Value.ToString();
                    nudSoLuong.Text = row.Cells["SoLuongBan"].Value.ToString();
                    tbGiaBan.Text = row.Cells["GiaBan"].Value.ToString();
                    tbThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                // Khi số lượng thay đổi, tính toán lại thành tiền
                int thanhTien = int.Parse(tbGiaBan.Text) * (int)nudSoLuong.Value;
                tbThanhTien.Text = thanhTien.ToString();
            }
            catch { }

        }

        private void cbbTruyen_SelectedIndexChanged(object sender, EventArgs e)
        {

                tbGiaBan.Text = BLL_ChiTietHoaDonBan.GiaBanTheoTruyen(cbbTruyen.Text).ToString();       
            
        }

        private void dtgHoaDonBan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgHoaDonBan.Columns[e.ColumnIndex].Name == "TongTien")
            {
                if (e.Value is int giaTien)
                {
                    // Định dạng giá trị kiểu int thành chuỗi với dấu phẩy ngăn cách hàng nghìn
                    e.Value = giaTien.ToString("N0");
                    e.FormattingApplied = true; // Đánh dấu đã xử lý định dạng
                }
            }
        }

        private void dtgChiTietHoaDonBan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgChiTietHoaDonBan.Columns[e.ColumnIndex].Name == "GiaBan" || dtgChiTietHoaDonBan.Columns[e.ColumnIndex].Name == "ThanhTien")
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
