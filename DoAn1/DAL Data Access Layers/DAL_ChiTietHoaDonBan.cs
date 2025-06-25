using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Data_Access_Layers
{
    public class DAL_ChiTietHoaDonBan
    {
        private static DAL_ChiTietHoaDonBan instance;

        public static DAL_ChiTietHoaDonBan Instance 
        {
            get { if (instance == null) instance = new DAL_ChiTietHoaDonBan(); return instance; }
            private set { instance = value; }
        }
        public DataTable HienThiCTHoaDonBan()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC sp_HienThiChiTietHoaDonBan");
        }
        public bool SuaCTHoaDonBan(string mahdb, string truyen, int slban, int giaban, int thanhtien)
        {
            string query = $"EXEC sp_SuaCTHoaDonBan @MaHoaDonBan = '{mahdb}' , @TenTruyen = N'{truyen}' , @SoLuongBan = {slban} , @GiaBan = {giaban} , @ThanhTien = {thanhtien}";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool XoaCTHoaDonBan(string mahdb, string truyen, int slban, int giaban, int thanhtien)
        {
            string query = $"EXEC sp_XoaCTHoaDonBan @MaHoaDonBan = '{mahdb}' , @TenTruyen = N'{truyen}' , @SoLuongBan = {slban} , @GiaBan = {giaban} , @ThanhTien = {thanhtien}";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public DataTable LoadTenTruyen()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT TenTruyen FROM Truyen");
        }
        public int GiaBanTheoTruyen(string tentruyen)
        {
            object gia = DataProvider.Instance.ExecuteScalar($"SELECT Gia FROM Truyen WHERE TenTruyen = N'{tentruyen}'");
            if (gia != null)
            {
                return (int)gia;
            }
            return 0;
        }
        public DataTable TimCTHoaDonBan(string nvb)
        {
            return DataProvider.Instance.ExecuteQuery($"EXEC sp_TimCTHoaDonBan @TenNVB = N'{nvb}'");
        }
    }
}
