using DTO_Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Data_Access_Layers
{
    public class DAL_HoaDonNhap
    {
        private static DAL_HoaDonNhap instance;

        public static DAL_HoaDonNhap Instance 
        {
            get { if (instance == null) instance = new DAL_HoaDonNhap(); return instance; }
            private set { instance = value; }
        }
        public DataTable HienThiHoaDonNhap()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC sp_GetAllHoaDonNhap");
        }
        public bool SuaHoaDonNhap(DTO_HoaDonNhap hdn)
        {
            string query = $"EXEC sp_UpdateHoaDonNhap @MaHoaDonNhap = '{hdn.MaHoaDonNhap}' , @NgayNhap = N'{hdn.NgayNhap}' , @TenNhanVienNhap = N'{hdn.MaNhanVienNhap}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool XoaHoaDonNhap(string mahdn)
        {
            string query = $"DELETE FROM HoaDonNhap WHERE MaHoaDonNhap = '{mahdn}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public DataTable TimHoaDonNhap(string nvnhap)
        {
            return DataProvider.Instance.ExecuteQuery($"EXEC sp_TimHoaDonNhap @TenNVN = N'{nvnhap}'");
        }
        public DataTable LoadTenNVN()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT HoTenNV FROM NhanVien");
        }
        public string TaoMaHDN()
        {
            return DataProvider.Instance.ExecuteScalar($@"SELECT CONCAT('N', RIGHT(CONCAT('00000',ISNULL(right(max(MaHoaDonNhap),4),0) + 1),4)) FROM dbo.HoaDonNhap where MaHoaDonNhap like 'N%'").ToString();
        }
        public bool ThemHoaDonNhap(DTO_HoaDonNhap hdn, DataTable cthdn)
        {
            if (cthdn.Rows.Count > 0)
            {
                string queryHDB = $"EXEC sp_ThemHoaDonNhap @MaHoaDonNhap = '{hdn.MaHoaDonNhap}' , @NgayNhap = '{hdn.NgayNhap}' , @TenNhanVienNhap = N'{hdn.MaNhanVienNhap}' , @TongTien = {hdn.TongTien}";
                DataProvider.Instance.ExecuteNonQuery(queryHDB);
            }
            int result = 0;
            bool kt = false;
            foreach (DataRow row in cthdn.Rows)
            {
                string matruyen = row["MaTruyen"].ToString();
                int slnhap = (int)row["SoLuong"];
                int gianhap = (int)row["Gia"];
                int thanhtien = slnhap * gianhap;
                string queryCTN = $"INSERT INTO ChiTietHoaDonNhap (MaHoaDonNhap, MaTruyen, SoLuongNhap, GiaNhap, ThanhTien)VALUES ('{hdn.MaHoaDonNhap}' , '{matruyen}' , {slnhap} , {gianhap} , {thanhtien})";
                result = DataProvider.Instance.ExecuteNonQuery(queryCTN);
                if (result > 0)
                {
                    kt = true;
                }

            }
            return kt;
        }
        public bool CapNhatTongTien(string mahdn)
        {
            string query = $"UPDATE HoaDonNhap SET TongTien = (SELECT ISNULL(SUM(ThanhTien), 0) FROM ChiTietHoaDonNhap WHERE MaHoaDonNhap = '{mahdn}') WHERE MaHoaDonNhap = '{mahdn}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;

        }
    }
}
