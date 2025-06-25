using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Data_Access_Layers
{
    public class DAL_GioHang
    {
        private static DAL_GioHang instance;

        public static DAL_GioHang Instance
        {
            get { if (instance == null) instance = new DAL_GioHang(); return instance; }
            private set { instance = value; }
        }
        public DataTable HienThiGioHang()
        {
            return DataProvider.Instance.ExecuteQuery("select * from GioHang");
        }
        public bool ThemGioHang(string mahd, string matruyen, int sl, int gia)
        {
            string query = $"INSERT INTO dbo.GioHang(MaHoaDon, MaTruyen, SoLuong, Gia, ThanhTien) VALUES( '{mahd}' , '{matruyen}' , {sl} , {gia} , {sl * gia})";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool XoaGioHang()
        {
            string query = "delete from GioHang";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}
