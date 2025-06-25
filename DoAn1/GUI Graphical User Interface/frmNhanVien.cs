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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private BLL_NhanVien BLL_NhanVien = new BLL_NhanVien();

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            //int quyen = frmDangNhap.getQuyen();
            //if (quyen == 0)
            //{
            //    //đóng chức năng với nhân viên
            //    btThem.Visible= false;
            //    btSua.Visible= false;
            //    btXoa.Visible= false;
            //}
            dtGNhanVien.DataSource = BLL_NhanVien.HienThiNhanVien();
        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            dtGNhanVien.DataSource = BLL_NhanVien.HienThiNhanVien();
            ClassHoTro.Moi(splitContainer1.Panel2);
        }

        private bool checknull(TextBox tb)
        {
            if (tb.Text.Trim() != "")
            {
                return true;
            }
            return false;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (checknull(tbMaNV) && checknull(tbHoTen) && checknull(tbGioiTinh) && checknull(tbQueQuan) && checknull(tbSDT))
                {
                    DTO_NhanVien nhanvien = new DTO_NhanVien(tbMaNV.Text, tbHoTen.Text, tbGioiTinh.Text, tbQueQuan.Text, tbSDT.Text);
                    if (BLL_NhanVien.ThemNhanVien(nhanvien))
                    {
                        MessageBox.Show("Thêm thông tin nhân viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin nhân viên thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thêm thông tin nhân viên, vui lòng kiểm tra lại");
            }
            btMoi_Click(sender, e);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (checknull(tbMaNV) && checknull(tbHoTen) && checknull(tbGioiTinh) && checknull(tbQueQuan) && checknull(tbSDT))
                    {
                        DTO_NhanVien nhanvien = new DTO_NhanVien(tbMaNV.Text, tbHoTen.Text, tbGioiTinh.Text, tbQueQuan.Text, tbSDT.Text);
                        if (BLL_NhanVien.SuaNhanVien(nhanvien))
                        {
                            MessageBox.Show("Cập nhật thông tin nhân viên thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin nhân viên thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên cần sửa!");
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi khi thay đổi thông tin nhân viên, vui lòng kiểm tra lại");
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
                    if (BLL_NhanVien.XoaNhanVien(tbMaNV.Text))
                    {
                        MessageBox.Show("Xóa thông tin nhân viên thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin nhân viên thất bại.");
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi khi xoá thông tin nhân viên, vui lòng kiểm tra lại");
                }
            }
            btMoi_Click(sender, e);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string hotennv = tbTimKiem.Text;
            dtGNhanVien.DataSource = BLL_NhanVien.TimNhanVien(hotennv);
            ClassHoTro.Moi(splitContainer1.Panel2);
            tbTimKiem.Text = hotennv;
        }

        private void dtGThongTinNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGNhanVien.Rows[e.RowIndex];
                tbMaNV.Text = row.Cells["MaNV"].Value.ToString();
                tbHoTen.Text = row.Cells["HoTenNV"].Value.ToString();
                tbGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                tbQueQuan.Text = row.Cells["QueQuan"].Value.ToString();
                tbSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
            }
        }
    }
}
