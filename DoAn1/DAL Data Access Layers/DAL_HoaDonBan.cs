using DTO_Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_Data_Access_Layers
{
    public class DAL_HoaDonBan
    {
        private static DAL_HoaDonBan instance;

        public static DAL_HoaDonBan Instance
        {
            get { if (instance == null) instance = new DAL_HoaDonBan(); return instance; }
            private set { instance = value; }
        }

        public DataTable HienThiHoaDonBan()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC sp_GetAllHoaDonBan");
        }

        public bool SuaHoaDonBan(DTO_HoaDonBan hdb)
        {
            string query = $"EXEC sp_UpdateHoaDonBan @MaHoaDonBan = '{hdb.MaHoaDonBan}' , @TenNhanVienBan = N'{hdb.MaNhanVienBan}' , @MaKHTV = N'{hdb.MaKHTV.Trim()}' , @NgayBan = '{hdb.NgayBan}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool CapNhatTongTien(string mahdb)
        {
            string query = $"UPDATE HoaDonBan SET TongTien = (SELECT ISNULL(SUM(ThanhTien), 0) FROM ChiTietHoaDonBan WHERE MaHoaDonBan = '{mahdb}') WHERE MaHoaDonBan = '{mahdb}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool XoaHoaDonBan(string mahdb)
        {
            string query = $"DELETE FROM HoaDonBan WHERE MaHoaDonBan = '{mahdb}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public DataTable TimHoaDonBan(string nvban)
        {
            return DataProvider.Instance.ExecuteQuery($"EXEC sp_TimHoaDonBan @TenNVB = N'{nvban}'");
        }
        public DataTable LoadTenNVB()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT HoTenNV FROM NhanVien");
        }
        public DataTable LoadMaKHTV()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT MaKHTV FROM KhachHangThanhVien");
        }
        public string TaoMaHDB()
        {
            return DataProvider.Instance.ExecuteScalar($@"SELECT CONCAT('B', RIGHT(CONCAT('00000',ISNULL(right(max(MaHoaDonBan),4),0) + 1),4)) FROM dbo.HoaDonBan where MaHoaDonBan like 'B%'").ToString();
        }
        public bool ThemHoaDonBan(DTO_HoaDonBan hdb, DataTable cthdb)
        {
            int result = 0;
            bool kt = false;

            if (cthdb.Rows.Count > 0)
            {
                string queryHDB = $"EXEC sp_ThemHoaDonBan @MaHoaDonBan = '{hdb.MaHoaDonBan}' , @NgayBan = '{hdb.NgayBan}' , @TenNhanVienBan = N'{hdb.MaNhanVienBan}' , @MaKHTV = '{hdb.MaKHTV}' , @TongTien = {hdb.TongTien}";
                DataProvider.Instance.ExecuteNonQuery(queryHDB);

                foreach (DataRow row in cthdb.Rows)
                {
                    string matruyen = row["MaTruyen"].ToString();
                    int slban = (int)row["SoLuong"];
                    int giaban = (int)row["Gia"];
                    int thanhtien = slban * giaban;
                    string queryCTB = $"INSERT INTO ChiTietHoaDonBan (MaHoaDonBan, MaTruyen, SoLuongBan, GiaBan, ThanhTien)VALUES ('{hdb.MaHoaDonBan}' , '{matruyen}' , {slban} , {giaban} , {thanhtien})";
                    result = DataProvider.Instance.ExecuteNonQuery(queryCTB);
                    if (result > 0)
                    {
                        kt = true;
                    }
                }
            }
            return kt;
        }
    }
}
