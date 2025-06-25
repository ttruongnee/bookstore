using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Data_Access_Layers
{
    public class DAL_ChiTietHoaDonNhap
    {
        private static DAL_ChiTietHoaDonNhap instance;

        public static DAL_ChiTietHoaDonNhap Instance 
        {
            get { if (instance == null) instance = new DAL_ChiTietHoaDonNhap(); return instance; }
            private set { instance = value; }
        }
        public DataTable HienThiCTHoaDonNhap()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC sp_HienThiChiTietHoaDonNhap");
        }
        public bool SuaCTHoaDonNhap(string mahdn, string truyen, int slnhap, int gianhap, int thanhtien)
        {
            string query = $"EXEC sp_SuaCTHoaDonNhap @MaHoaDonNhap = '{mahdn}' , @TenTruyen = N'{truyen}' , @SoLuongNhap = {slnhap} , @GiaNhap = {gianhap} , @ThanhTien = {thanhtien}";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool XoaCTHoaDonNhap(string mahdn, string truyen, int slnhap, int gianhap, int thanhtien)
        {
            string query = $"EXEC sp_XoaCTHoaDonNhap @MaHoaDonNhap = '{mahdn}' , @TenTruyen = N'{truyen}' , @SoLuongNhap = {slnhap} , @GiaNhap = {gianhap} , @ThanhTien = {thanhtien}";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public DataTable TimCTHoaDonNhap(string nvn)
        {
            return DataProvider.Instance.ExecuteQuery($"EXEC sp_TimCTHoaDonNhap @TenNVN = N'{nvn}'");
        }
        public DataTable LoadTenTruyen()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT TenTruyen FROM Truyen");
        }
    }
}
