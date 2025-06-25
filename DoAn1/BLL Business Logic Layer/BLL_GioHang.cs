using DAL_Data_Access_Layers;
using DTO_Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BLL_Business_Logic_Layer
{
    public class BLL_GioHang
    {

        public DataTable HienThiGioHang()
        {
            return DAL_GioHang.Instance.HienThiGioHang();
        }
        public bool ThemGioHang(string mahdb, string matruyen, int slban, int giaban)
        {
            return DAL_GioHang.Instance.ThemGioHang(mahdb, matruyen, slban, giaban);
        }
        public bool XoaGioHang()
        {
            return DAL_GioHang.Instance.XoaGioHang();
        }
    }
}
