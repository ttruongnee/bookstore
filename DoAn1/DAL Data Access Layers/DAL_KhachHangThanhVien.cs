using DTO_Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Data_Access_Layers
{
    public class DAL_KhachHangThanhVien
    {
        private static DAL_KhachHangThanhVien instance;

        public static DAL_KhachHangThanhVien Instance
        {
            get { if (instance == null) instance = new DAL_KhachHangThanhVien(); return instance; }
            private set { instance = value; }
        }
        public DataTable HienThiKHTV()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM KhachHangThanhVien");
        }
        public bool ThemKHTV(DTO_KhachHangThanhVien khtv)
        {
            string query = $"INSERT INTO dbo.KhachHangThanhVien(MaKHTV, HoTenKHTV, SoDienThoai, DiaChi, HSDTheThanhVien) VALUES('{khtv.MaKHTV}' , N'{khtv.HoTenKHTV}' , '{khtv.SoDienThoai}' , N'{khtv.DiaChi}' , '{khtv.HSDTheThanhVien}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool SuaKHTV(DTO_KhachHangThanhVien khtv)
        {
            string query = $"Update KhachHangThanhVien set HoTenKHTV = N'{khtv.HoTenKHTV}' , SoDienThoai = N'{khtv.SoDienThoai}' , DiaChi = N'{khtv.DiaChi}' , HSDTheThanhVien = '{khtv.HSDTheThanhVien}' where MaKHTV = '{khtv.MaKHTV}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool XoaKHTV(string makhtv)
        {
            string query = $"DELETE FROM KhachHangThanhVien WHERE MaKHTV = '{makhtv}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public DataTable TimKHTV(string hotenkhtv)
        {
            return DataProvider.Instance.ExecuteQuery($"SELECT * FROM KhachHangThanhVien WHERE HoTenKHTV LIKE N'%{hotenkhtv}%'");
        }
        public bool GiaHanTTV(string makhtv, string hsdttv)
        {
            string query = $"Update KhachHangThanhVien set HSDTheThanhVien = '{hsdttv}' where MaKHTV = '{makhtv}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public DataTable Top5KhachHang()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC sp_Top5KhachHangTiemNang");
        }
    }
}
