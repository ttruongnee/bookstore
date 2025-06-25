using DAL_Data_Access_Layers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Business_Logic_Layer
{
    public class BLL_ChiTietHoaDonNhap
    {
        public DataTable HienThiCTHoaDonNhap()
        {
            return DAL_ChiTietHoaDonNhap.Instance.HienThiCTHoaDonNhap();
        }
        public bool SuaCTHoaDonNhap(string mahdn, string truyen, int slnhap, int gianhap, int thanhtien)
        {
            return DAL_ChiTietHoaDonNhap.Instance.SuaCTHoaDonNhap(mahdn, truyen, slnhap, gianhap, thanhtien);
        }
        public bool XoaCTHoaDonNhap(string mahdn, string truyen, int slnhap, int gianhap, int thanhtien)
        {
            return DAL_ChiTietHoaDonNhap.Instance.XoaCTHoaDonNhap(mahdn, truyen, slnhap, gianhap, thanhtien);
        }
        public DataTable LoadTenTruyen()
        {
            return DAL_ChiTietHoaDonNhap.Instance.LoadTenTruyen();
        }
        public DataTable TimCTHoaDonNhap(string nvn)
        {
            return DAL_ChiTietHoaDonNhap.Instance.TimCTHoaDonNhap(nvn);
        }
    }
}
