using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_Data_Access_Layers;
using DTO_Data_Transfer_Object;
using System.Xml.Linq;

namespace BLL_Business_Logic_Layer
{
    public class BLL_TaiKhoan
    {
        public DataTable HienTaiKhoan()
        {
            return DAL_TaiKhoan.Instance.HienTaiKhoan();
        }
        public bool ThemTaiKhoan(string user, string pass, int quyen)
        {
            return DAL_TaiKhoan.Instance.ThemTaiKhoan(user, pass, quyen);
        }
        public bool SuaTaiKhoan(string user, string pass, int quyen)
        {
            return DAL_TaiKhoan.Instance.SuaTaiKhoan(user, pass, quyen);
        }
        public bool XoaTaiKhoan(string user)
        {
            return DAL_TaiKhoan.Instance.XoaTaiKhoan(user);
        }
        public bool ResetPassword(string user)
        {
            return DAL_TaiKhoan.Instance.ResetPassword(user);
        }
        public bool Login(string username, string password)
        {
            return DAL_TaiKhoan.Instance.Login(username, password);
        }
        public int Quyen(string user)
        {
            return DAL_TaiKhoan.Instance.Quyen(user);
        }
    }
}
