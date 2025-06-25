using DTO_Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Data_Access_Layers
{
    public class DAL_TheLoai 
    {
        private static DAL_TheLoai instance;

        public static DAL_TheLoai Instance
        {
            get { if (instance == null) instance = new DAL_TheLoai(); return instance; }
            private set { instance = value; }
        }
        private DAL_TheLoai() { }

        public DataTable HienThiTheLoai()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM TheLoai");
        }

        public bool ThemTheLoai(DTO_TheLoai theloai)
        {
            string query = "INSERT INTO dbo.TheLoai(MaTheLoai , TenTheLoai , MoTa)" + $"VALUES ( N'{theloai.MaTheLoai}' , N'{theloai.TenTheLoai}' , N'{theloai.MoTa}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaTheLoai(DTO_TheLoai theloai)
        {
            string query = $"Update TheLoai set TenTheLoai = N'{theloai.TenTheLoai}' , MoTa = N'{theloai.MoTa}' where MaTheLoai = '{theloai.MaTheLoai}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaTheLoai(string matl)
        {
            string query = $"DELETE FROM TheLoai WHERE MaTheLoai = '{matl}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable TimTheLoai(string tentl)
        {
            return DataProvider.Instance.ExecuteQuery($"SELECT * FROM TheLoai WHERE TenTheLoai LIKE N'%{tentl}%'");
        }

    }
}
