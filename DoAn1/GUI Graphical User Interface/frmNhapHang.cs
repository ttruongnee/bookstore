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
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private BLL_HoaDonNhap BLL_HoaDonNhap = new BLL_HoaDonNhap();
        private BLL_GioHang BLL_GioHang = new BLL_GioHang();
        private BLL_Truyen BLL_Truyen = new BLL_Truyen();

        public int tongtien = 0;

        private void btThemHoaDon_Click(object sender, EventArgs e)
        {
            string mahd = tbMaHDN.Text;
            DateTime ngay = dtpNgayNhap.Value;
            string nvb = cbbNVNhap.Text;
            DataTable cthdn = BLL_GioHang.HienThiGioHang();
            try
            {
                DTO_HoaDonNhap hdn = new DTO_HoaDonNhap(mahd, ngay, tongtien, nvb);
                if (BLL_HoaDonNhap.ThemHoaDonNhap(hdn, cthdn))
                {
                    MessageBox.Show("Thêm thông tin hoá đơn thành công");
                    foreach (DataRow row in cthdn.Rows)
                    {
                        string matruyen = row["MaTruyen"].ToString();
                        int slnhap = (int)row["SoLuong"];
                        BLL_Truyen.TangSLTruyen(matruyen, slnhap);
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

        private void getKhoTruyen()
        {
            flpTruyen.Controls.Clear();
            DataTable dt = BLL_Truyen.HienTruyen();
            foreach (DataRow row in dt.Rows)
            {
                byte[] imageBytes = row["HinhAnh"] is DBNull ? null : (byte[])row["HinhAnh"];
                truyennhap t = new truyennhap();
                t.GanThongTin(
                    imageBytes,
                    row["TenTruyen"].ToString(),
                    row["MaTruyen"].ToString()
                );
                flpTruyen.Controls.Add(t);
            }
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            //tạo mã hoá đơn tự động
            tbMaHDN.Text = TaoMaHDN();
            //load tên nv
            LoadTenNVN();
            //load tt truyện
            getKhoTruyen();
            //thêm sk vào nút thêm hàng nhập vào ds
            ThemSKClick();
            //làm mới giỏ hàng trước khi sử dụng
            dtgTruyenNhap.DataSource = BLL_GioHang.XoaGioHang();
            //đặt lại giá trị mục ngày nhập
            dtpNgayNhap.Value = DateTime.Now;
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
                                    if (j.Name == "btNhap")
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
        public void Button_Click(object sender, EventArgs e)
        {
            dtgTruyenNhap.DataSource = BLL_GioHang.HienThiGioHang();

            lbTongTien.Text = tongtien.ToString("N0");
            tbMaHDN.Text = TaoMaHDN();
        }
        private void LoadTenNVN()
        {
            cbbNVNhap.DataSource = BLL_HoaDonNhap.LoadTenNVN();
            cbbNVNhap.DisplayMember = "HoTenNV";
        }
        private string TaoMaHDN()
        {
            return BLL_HoaDonNhap.TaoMaHDN();
        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            //làm mới giỏ hàng
            dtgTruyenNhap.DataSource = BLL_GioHang.XoaGioHang();
            //reset tổng tiền về 0 và hiển thị
            tongtien = 0;
            lbTongTien.Text = tongtien.ToString();
            //tạo lại mã tự động
            tbMaHDN.Text = TaoMaHDN();
        }


        private void dtgTruyenNhap_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            tongtien = 0;
            foreach (DataGridViewRow row in dtgTruyenNhap.Rows)
            {
                // Bỏ qua hàng dành cho nhập liệu mới
                if (!row.IsNewRow)
                {
                    // lấy tổng tiền là tổng cột thành tiền( cột thứ 5)
                    tongtien += (int)row.Cells[4].Value;
                }

            }
        }

        private void dtgTruyenNhap_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgTruyenNhap.Columns[e.ColumnIndex].Name == "Gia" || dtgTruyenNhap.Columns[e.ColumnIndex].Name == "ThanhTien")
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
