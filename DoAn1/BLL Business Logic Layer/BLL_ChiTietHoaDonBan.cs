using DAL_Data_Access_Layers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Business_Logic_Layer
{
    public class BLL_ChiTietHoaDonBan
    {
        public DataTable HienThiCTHoaDonBan()
        {
            return DAL_ChiTietHoaDonBan.Instance.HienThiCTHoaDonBan();
        }
        public bool SuaCTHoaDonBan(string mahdb, string truyen, int slban, int giaban, int thanhtien)
        {
            return DAL_ChiTietHoaDonBan.Instance.SuaCTHoaDonBan(mahdb, truyen, slban, giaban, thanhtien);
        }
        public bool XoaCTHoaDonBan(string mahdb, string truyen, int slban, int giaban, int thanhtien)
        {
            return DAL_ChiTietHoaDonBan.Instance.XoaCTHoaDonBan(mahdb, truyen, slban, giaban, thanhtien);
        }
        public DataTable LoadTenTruyen()
        {
            return DAL_ChiTietHoaDonBan.Instance.LoadTenTruyen();
        }
        public int GiaBanTheoTruyen(string tentruyen)
        {
            return DAL_ChiTietHoaDonBan.Instance.GiaBanTheoTruyen(tentruyen);
        }
        public DataTable TimCTHoaDonBan(string nvb)
        {
            return DAL_ChiTietHoaDonBan.Instance.TimCTHoaDonBan(nvb);
        }
    }
}
