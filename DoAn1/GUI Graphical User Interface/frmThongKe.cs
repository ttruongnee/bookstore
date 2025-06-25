using DTO_Data_Transfer_Object;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using BLL_Business_Logic_Layer;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_Graphical_User_Interface
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private BLL_Truyen BLL_Truyen = new BLL_Truyen();
        private BLL_NhanVien BLL_NhanVien = new BLL_NhanVien();
        private BLL_KhachHangThanhVien BLL_KhachHangThanhVien = new BLL_KhachHangThanhVien();

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            //thống kê truyện
            rvTop5Truyen.LocalReport.ReportEmbeddedResource = "GUI_Graphical_User_Interface.rpTop5Truyen.rdlc";
            ReportDataSource rDSTruyen = new ReportDataSource();
            rDSTruyen.Name = "DataSetTop5Truyen";
            rDSTruyen.Value = BLL_Truyen.Top5TruyenBanChay();
            rvTop5Truyen.LocalReport.DataSources.Add(rDSTruyen);

            //thống kê nhân viên
            rVTop5NV.LocalReport.ReportEmbeddedResource = "GUI_Graphical_User_Interface.rpTop5NV.rdlc";
            ReportDataSource rDSNhanVien = new ReportDataSource();
            rDSNhanVien.Name = "DataSetTop5NhanVien";
            rDSNhanVien.Value = BLL_NhanVien.Top5NhanVien();
            rVTop5NV.LocalReport.DataSources.Add(rDSNhanVien);

            //thống kê khách hàng
            rVTop5KH.LocalReport.ReportEmbeddedResource = "GUI_Graphical_User_Interface.rpTop5KH.rdlc";
            ReportDataSource rDSKhachHang = new ReportDataSource();
            rDSKhachHang.Name = "DataSetTop5KhachHang";
            rDSKhachHang.Value = BLL_KhachHangThanhVien.Top5KhachHang();
            rVTop5KH.LocalReport.DataSources.Add(rDSKhachHang);

            this.rvTop5Truyen.RefreshReport();
            this.rVTop5NV.RefreshReport();
            this.rVTop5KH.RefreshReport();

            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value= DateTime.Now;
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            // Gọi BLL để lấy dữ liệu thống kê doanh thu
            BLL_ThongKe bll = new BLL_ThongKe();
            DataTable dt = bll.HienThiDoanhThu(dtpNgayBatDau.Value, dtpNgayKetThuc.Value);

            // Truyền vào chart tổng nhập
            Series Nhap = new Series("Tổng nhập");
            Nhap.Points.DataBind(dt.AsEnumerable(), "NgayThangNam", "Tổng nhập", null);

            // Truyền vào chart tổng bán
            Series Ban = new Series("Tổng bán");
            Ban.Points.DataBind(dt.AsEnumerable(), "NgayThangNam", "Tổng bán", null);

            // Truyền vào chart tổng lãi
            Series Lai = new Series("Doanh thu");
            Lai.Points.DataBind(dt.AsEnumerable(), "NgayThangNam", "Doanh thu", null);

            // Cấu hình Chart Control
            chartDoanhThu.Series.Clear();
            chartDoanhThu.Series.Add(Nhap);
            chartDoanhThu.Series.Add(Ban);
            chartDoanhThu.Series.Add(Lai);

            // Định dạng giá trị tiền với dấu phẩy động
            chartDoanhThu.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0";

        }
    }
}
