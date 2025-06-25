using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Data_Transfer_Object;
using System.Data;
using System.Data.SqlClient;

namespace DAL_Data_Access_Layers
{
    public class DAL_Truyen 
    {
        private static DAL_Truyen instance;

        public static DAL_Truyen Instance 
        {
            get { if (instance == null) instance = new DAL_Truyen(); return instance; }
            private set { instance = value; }
        }

        public DataTable HienTruyen()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC sp_HienThiThongTinTruyen");
        }

        public DataTable LoadTenTheLoai()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT TenTheLoai FROM TheLoai");
        }
        public bool ThemTruyen(DTO_Truyen truyen)
        {
            string query = $"EXEC sp_ThemThongTinTruyen @MaTruyen , @TenTruyen , @MaTheLoai , @TacGia , @SoLuong , @Gia , @HinhAnh";
            object[] parameter = new object[] { truyen.MaTruyen, truyen.TenTruyen, truyen.MaTheLoai, truyen.TacGia, truyen.SoLuong, truyen.Gia, truyen.HinhAnh };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameter);
            return result > 0;
        }

        public bool SuaTruyen(DTO_Truyen truyen)
        {
            string query = $"EXEC sp_CapNhatThongTinTruyen @MaTruyen , @TenTruyen , @MaTheLoai , @TacGia , @SoLuong , @Gia , @HinhAnh";
            object[] parameter = new object[] { truyen.MaTruyen, truyen.TenTruyen, truyen.MaTheLoai, truyen.TacGia, truyen.SoLuong, truyen.Gia, truyen.HinhAnh };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameter);

            return result > 0;
        }

        public bool XoaTruyen(string matruyen)
        {
            string query = $"DELETE FROM Truyen WHERE MaTruyen = '{matruyen}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimTruyen(string timkiem)
        {
            return DataProvider.Instance.ExecuteQuery($"EXEC sp_TimThongTinTruyen @DoiTuong = N'{timkiem}'");
        }

        public void GiamSLTruyen(string matruyen, int slban)
        {
            DataProvider.Instance.ExecuteNonQuery($"UPDATE Truyen SET SoLuong = SoLuong - {slban} WHERE MaTruyen = '{matruyen}'");
        }
        public void TangSLTruyen(string matruyen, int slban)
        {
            DataProvider.Instance.ExecuteNonQuery($"UPDATE Truyen SET SoLuong = SoLuong + {slban} WHERE MaTruyen = '{matruyen}'");
        }
        public DataTable Top5TruyenBanChay()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC sp_Top5TruyenBanChay");
        }

    }
}
