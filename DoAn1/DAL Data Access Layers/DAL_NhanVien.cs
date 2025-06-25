using DTO_Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Data_Access_Layers
{
    public class DAL_NhanVien
    {
        private static DAL_NhanVien instance;

        public static DAL_NhanVien Instance 
        {
            get { if (instance == null) instance = new DAL_NhanVien(); return instance; }
            private set { instance = value; }
        }
        public DataTable HienThiNhanVien()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM NhanVien");
        }
        public bool ThemNhanVien(DTO_NhanVien nhanvien)
        {
            string query = $"INSERT INTO dbo.NhanVien(MaNV, HoTenNV, GioiTinh, QueQuan, SoDienThoai)VALUES('{nhanvien.MaNV}' , N'{nhanvien.HoTenNV}' , N'{nhanvien.GioiTinh}' , N'{nhanvien.QueQuan}' , '{nhanvien.SoDienThoai}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
            public bool SuaNhanVien(DTO_NhanVien nhanvien)
            {
                string query = $"Update NhanVien set HoTenNV = N'{nhanvien.HoTenNV}' , GioiTinh = N'{nhanvien.GioiTinh}' , QueQuan = N'{nhanvien.QueQuan}' , SoDienThoai = '{nhanvien.SoDienThoai}' where MaNV = '{nhanvien.MaNV}'";
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
        public bool XoaNhanVien(string manv)
        {
            string query = $"DELETE FROM NhanVien WHERE MaNV = '{manv}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public DataTable TimNhanVien(string hotennv)
        {
            return DataProvider.Instance.ExecuteQuery($"SELECT * FROM NhanVien WHERE HoTenNV LIKE N'%{hotennv}%'");
        }
        public DataTable Top5NhanVien()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC sp_Top5NhanVienXuatSac");
        }
    }
}
