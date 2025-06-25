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
    public class BLL_HoaDonBan
    {
        public DataTable HienThiHoaDonBan()
        {
            return DAL_HoaDonBan.Instance.HienThiHoaDonBan();
        }
        public bool SuaHoaDonBan(DTO_HoaDonBan hdb)
        {
            return DAL_HoaDonBan.Instance.SuaHoaDonBan(hdb);
        }
        public bool CapNhatTongTien(string mahdb)
        {
            return DAL_HoaDonBan.Instance.CapNhatTongTien(mahdb);
        }
        public bool XoaHoaDonBan(string mahdb)
        {
            return DAL_HoaDonBan.Instance.XoaHoaDonBan(mahdb);
        }
        public DataTable TimHoaDonBan(string tennv)
        {
            return DAL_HoaDonBan.Instance.TimHoaDonBan(tennv);
        }
        public DataTable LoadTenNVB()
        {
            return DAL_HoaDonBan.Instance.LoadTenNVB();
        }
        public DataTable LoadMaKHTV()
        {
            return DAL_HoaDonBan.Instance.LoadMaKHTV();
        }
        public string TaoMaHDB()
        {
            return DAL_HoaDonBan.Instance.TaoMaHDB();
        }
        public bool ThemHoaDonBan(DTO_HoaDonBan hdb, DataTable cthdb)
        {
            return DAL_HoaDonBan.Instance.ThemHoaDonBan(hdb, cthdb);
        }
    }
}
