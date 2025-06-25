using DAL_Data_Access_Layers;
using DTO_Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Business_Logic_Layer
{
    public class BLL_KhachHangThanhVien
    {
        public DataTable HienThiKHTV()
        {
            return DAL_KhachHangThanhVien.Instance.HienThiKHTV();
        }
        public bool ThemKHTV(DTO_KhachHangThanhVien khtv)
        {
            return DAL_KhachHangThanhVien.Instance.ThemKHTV(khtv);
        }
        public bool SuaKHTV(DTO_KhachHangThanhVien khtv)
        {
            return DAL_KhachHangThanhVien.Instance.SuaKHTV(khtv);
        }
        public bool XoaKHTV(string makhtv)
        {
            return DAL_KhachHangThanhVien.Instance.XoaKHTV(makhtv);
        }
        public DataTable TimKHTV(string hotenkhtv)
        {
            return DAL_KhachHangThanhVien.Instance.TimKHTV(hotenkhtv);
        }
        public bool GiaHanTTV(string makhtv, string hsdttv)
        {
            return DAL_KhachHangThanhVien.Instance.GiaHanTTV(makhtv, hsdttv);
        }
        public DataTable Top5KhachHang()
        {
            return DAL_KhachHangThanhVien.Instance.Top5KhachHang();
        }
    }
}
