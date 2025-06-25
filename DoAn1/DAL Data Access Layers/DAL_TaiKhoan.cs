using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Data_Access_Layers
{
    public class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan instance;

        public static DAL_TaiKhoan Instance 
        {
            get { if (instance == null) instance = new DAL_TaiKhoan(); return instance; }
            private set { instance = value; }
        }

        public DataTable HienTaiKhoan()
        {
            return DataProvider.Instance.ExecuteQuery("Select * FROM TaiKhoan");
        }
        public bool ThemTaiKhoan(string user, string pass, int quyen)
        {
            string query = string.Format("INSERT TaiKhoan (UserName, PassWord, Quyen)VALUES  ('{0}', N'{1}', {2})", user, pass, quyen);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SuaTaiKhoan(string user, string pass, int quyen)
        {
            string query = string.Format("UPDATE TaiKhoan SET PassWord = '{1}', Quyen = {2} WHERE UserName = N'{0}'", user, pass, quyen);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool XoaTaiKhoan(string user)
        {
            string query = string.Format("Delete TaiKhoan where UserName = N'{0}'", user);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool ResetPassword(string name)
        {
            string query = string.Format("update TaiKhoan set PassWord = N'123' where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool Login(string userName, string passWord)
        {
            string query = "sp_Login @UserName , @PassWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord});

            return result.Rows.Count > 0;
        }
        public int Quyen(string user)
        {
            string query = $"select Quyen from TaiKhoan where UserName = '{user}'";
            
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            int quyen = 0;
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                quyen = (int)row["Quyen"];
            }
            return quyen;
            
        }
    }
}
