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
    public class BLL_HoaDonNhap
    {
        public DataTable HienThiHoaDonNhap()
        {
            return DAL_HoaDonNhap.Instance.HienThiHoaDonNhap();
        }
        public bool SuaHoaDonNhap(DTO_HoaDonNhap hdn)
        {
            return DAL_HoaDonNhap.Instance.SuaHoaDonNhap(hdn);
        }
        public bool XoaHoaDonNhap(string mahdn)
        {
            return DAL_HoaDonNhap.Instance.XoaHoaDonNhap(mahdn);
        }
        public DataTable TimHoaDonNhap(string tennv)
        {
            return DAL_HoaDonNhap.Instance.TimHoaDonNhap(tennv);
        }
        public DataTable LoadTenNVN()
        {
            return DAL_HoaDonNhap.Instance.LoadTenNVN();
        }
        public string TaoMaHDN()
        {
            return DAL_HoaDonNhap.Instance.TaoMaHDN();
        }
        public bool ThemHoaDonNhap(DTO_HoaDonNhap hdn, DataTable cthdn)
        {
            return DAL_HoaDonNhap.Instance.ThemHoaDonNhap(hdn, cthdn);
        }
        public bool CapNhatTongTien(string mahdn)
        {
            return DAL_HoaDonNhap.Instance.CapNhatTongTien(mahdn);
        }
    }
}
