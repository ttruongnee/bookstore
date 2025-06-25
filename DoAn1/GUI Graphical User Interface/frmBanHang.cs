using BLL_Business_Logic_Layer;
using DTO_Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Graphical_User_Interface
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private BLL_HoaDonBan BLL_HoaDonBan = new BLL_HoaDonBan();
        private BLL_GioHang BLL_GioHang = new BLL_GioHang();
        private BLL_Truyen BLL_Truyen = new BLL_Truyen();

        public int tongtien = 0;

        //public static bool themsach = false;
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            //tạo mã tự động
            LoadMaKHTV();
            tbMaHDBan.Text = TaoMaHDB();

            //lấy tên nv bán vào cbb
            LoadTenNVB();

            //hiển thị thông tin truyện
            getKhoTruyen();

            //thêm sự kiện click vào nút đặt sản phẩm vào giỏ hàng
            ThemSKClick();

            //làm mới giỏ hàng
            dtgGioHang.DataSource = BLL_GioHang.XoaGioHang();

            //chuyển dữ liệu về mặc định
            dtpNgayBan.Value = DateTime.Now;
            cbbMaKHTV.Text = "";
        }
        private string TaoMaHDB()
        {
            return BLL_HoaDonBan.TaoMaHDB();
        }

        private void getKhoTruyen()
        {
            flpTruyen.Controls.Clear();
            DataTable dt = BLL_Truyen.HienTruyen();
            foreach (DataRow row in dt.Rows)
            {
                byte[] imageBytes = row["HinhAnh"] is DBNull ? null : (byte[])row["HinhAnh"];
                truyen t = new truyen();
                t.GanThongTin(
                    imageBytes,
                    row["TenTruyen"].ToString(),
                    row["MaTruyen"].ToString(),
                    (int)row["Gia"],
                    (int)row["SoLuong"]
                );
                flpTruyen.Controls.Add(t);
            }
        }
        private void LoadTenNVB()
        {
            cbbNVBan.DataSource = BLL_HoaDonBan.LoadTenNVB();
            cbbNVBan.DisplayMember = "HoTenNV";
        }
        private void LoadMaKHTV()
        {
            cbbMaKHTV.DataSource = BLL_HoaDonBan.LoadMaKHTV();
            cbbMaKHTV.DisplayMember = "MaKHTV";
        }

        private void ThemSKClick()
        {
            foreach (Control ctr in flpTruyen.Controls)
            {
                if (ctr is UserControl)
                {
                    foreach (Control i in ctr.Controls)
                    {
                        if (i is GroupBox gr)
                        {
                            foreach (Control j in gr.Controls)
                            {
                                if (j is Button)
                                {
                                    if (j.Name == "btMua")
                                    {
                                        j.Click += Button_Click;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            dtgGioHang.DataSource = BLL_GioHang.HienThiGioHang();

            tbMaHDBan.Text = TaoMaHDB();
            checkkhtv();
            lbTongTien.Text = tongtien.ToString("N0");
        }

        private void btThemHoaDon_Click(object sender, EventArgs e)
        {
            string mahdb = tbMaHDBan.Text;
            DateTime ngayban = dtpNgayBan.Value;
            string nvb = cbbNVBan.Text;
            string makhtv = cbbMaKHTV.Text;
            DataTable cthdb = BLL_GioHang.HienThiGioHang();
            try
            {
                DTO_HoaDonBan hdb = new DTO_HoaDonBan(mahdb, ngayban, tongtien, nvb, makhtv);
                if (BLL_HoaDonBan.ThemHoaDonBan(hdb, cthdb))
                {
                    MessageBox.Show("Thêm thông tin hoá đơn thành công");
                    foreach (DataRow row in cthdb.Rows)
                    {
                        string matruyen = row["MaTruyen"].ToString();
                        int slban = (int)row["SoLuong"];
                        BLL_Truyen.GiamSLTruyen(matruyen, slban);
                    }
                }
                else
                {
                    MessageBox.Show("Thêm thông tin hoá đơn không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            getKhoTruyen();
            ThemSKClick();
            btMoi_Click(sender, e);
        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            //xoá giỏ hàng
            dtgGioHang.DataSource = BLL_GioHang.XoaGioHang();

            //reset tổng tiền về 0 và hiển thị
            tongtien = 0;
            lbTongTien.Text = tongtien.ToString();

            //chạy lại tạo mã hoá đơn tự động
            tbMaHDBan.Text = TaoMaHDB();

            //đặt lại thông tin cho cbb
            cbbMaKHTV.Text = "";
            cbbMaKHTV.Enabled = true;
        }

        //giảm giá 5% cho mỗi sản phẩm khi khách hàng mua là khách hàng thành viên
        private void checkkhtv()
        {
            foreach (DataRowView row in cbbMaKHTV.Items)
            {
                if (cbbMaKHTV.Text == row["MaKHTV"].ToString())
                {
                    tongtien -= (tongtien / 5);
                    cbbMaKHTV.Enabled = false;
                }
            }
        }

        private void dtgGioHang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            tongtien = 0;
            foreach (DataGridViewRow row in dtgGioHang.Rows)
            {
                // Bỏ qua hàng dành cho nhập liệu mới
                if (!row.IsNewRow)
                {
                    // lấy tổng tiền là tổng cột thành tiền( cột thứ 5)
                    tongtien += (int)row.Cells[4].Value;
                }
            }
        }

        private void dtgGioHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgGioHang.Columns[e.ColumnIndex].Name == "Gia" || dtgGioHang.Columns[e.ColumnIndex].Name == "ThanhTien")
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

