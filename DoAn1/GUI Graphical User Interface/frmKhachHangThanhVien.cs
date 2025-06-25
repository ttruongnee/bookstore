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
    public partial class frmKhachHangThanhVien : Form
    {
        public frmKhachHangThanhVien()
        {
            InitializeComponent();
        }

        private BLL_KhachHangThanhVien BLL_KhachHangThanhVien = new BLL_KhachHangThanhVien();

        private void frmKhachHangThanhVien_Load(object sender, EventArgs e)
        {
            dtGKhachHang.DataSource = BLL_KhachHangThanhVien.HienThiKHTV();
        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            dtGKhachHang.DataSource = BLL_KhachHangThanhVien.HienThiKHTV();
            ClassHoTro.Moi(splitContainer1.Panel2);
            ClassHoTro.Moi(panel1);
            dtpHSDTheTV.Value = DateTime.Now;
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
                if (checknull(tbMaKHTV) && checknull(tbHoTen) && checknull(tbSoDienThoai) && checknull(tbDiaChi))
                {
                    DTO_KhachHangThanhVien khtv = new DTO_KhachHangThanhVien(tbMaKHTV.Text, tbHoTen.Text, tbSoDienThoai.Text, tbDiaChi.Text, dtpHSDTheTV.Value);
                    if (BLL_KhachHangThanhVien.ThemKHTV(khtv))
                    {
                        MessageBox.Show("Thêm thông tin khách hàng thành viên thành công");
                        btMoi_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin khách hàng thành viên không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }

            }
            catch
            {
                MessageBox.Show("Có lỗi khi thêm thông tin khách hàng thành viên, vui lòng kiểm tra lại");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (checknull(tbMaKHTV) && checknull(tbHoTen) && checknull(tbSoDienThoai) && checknull(tbDiaChi))
                    {
                        DTO_KhachHangThanhVien khtv = new DTO_KhachHangThanhVien(tbMaKHTV.Text, tbHoTen.Text, tbSoDienThoai.Text, tbDiaChi.Text, dtpHSDTheTV.Value);
                        if (BLL_KhachHangThanhVien.SuaKHTV(khtv))
                        {
                            MessageBox.Show("Cập nhật thông tin khách hàng thành viên thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin khách hàng thành viên thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng thành viên cần sửa!");
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi khi thay đổi thông tin khách hàng thành viên, vui lòng kiểm tra lại");
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

                    if (BLL_KhachHangThanhVien.XoaKHTV(tbMaKHTV.Text))
                    {
                        MessageBox.Show("Xóa thông tin khách hàng thành viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin khách hàng thành viên thất bại");
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi khi xoá thông tin khách hàng thành viên, vui lòng kiểm tra lại");
                }
            }
            btMoi_Click(sender, e);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string hotenkhtv = tbTimKiem.Text;
            dtGKhachHang.DataSource = BLL_KhachHangThanhVien.TimKHTV(hotenkhtv);
            //ClassHoTro.Moi(splitContainer1.Panel2);
            ClassHoTro.Moi(panel1);
            dtpHSDTheTV.Value = DateTime.Now;
        }

        private void dtGThongTinKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGKhachHang.Rows[e.RowIndex];
                tbMaKHTV.Text = row.Cells["MaKHTV"].Value.ToString();
                tbHoTen.Text = row.Cells["HoTenKHTV"].Value.ToString();
                tbSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                tbDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                if (row.Cells["HSDTheThanhVien"].Value is DBNull)
                {
                    dtpHSDTheTV.Value = DateTime.Now;
                }
                else
                {
                    dtpHSDTheTV.Value = (DateTime)row.Cells["HSDTheThanhVien"].Value;
                }
            }
        }

        private void btGiaHan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn gia hạn không?", "Gia hạn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_KhachHangThanhVien.GiaHanTTV(tbMaKHTV.Text.ToString(), dtpHSDTheTV.Value.AddMonths(1).ToShortDateString()))
                    {
                        MessageBox.Show("Đã gia hạn thẻ thành viên thêm 1 tháng!");
                    }
                    else
                    {
                        MessageBox.Show("Gia hạn thẻ thành viên thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            btMoi_Click(sender, e);
        }
    }
}
