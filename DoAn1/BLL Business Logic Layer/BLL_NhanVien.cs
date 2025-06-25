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
    public class BLL_NhanVien
    {
        public DataTable HienThiNhanVien()
        {
            return DAL_NhanVien.Instance.HienThiNhanVien();
        }
        public bool ThemNhanVien(DTO_NhanVien nhanvien)
        {
            return DAL_NhanVien.Instance.ThemNhanVien(nhanvien);
        }
        public bool SuaNhanVien(DTO_NhanVien nhanvien)
        {
            return DAL_NhanVien.Instance.SuaNhanVien(nhanvien);
        }
        public bool XoaNhanVien(string manv)
        {
            return DAL_NhanVien.Instance.XoaNhanVien(manv);
        }
        public DataTable TimNhanVien(string hotennv)
        {
            return DAL_NhanVien.Instance.TimNhanVien(hotennv);
        }
        public DataTable Top5NhanVien()
        {
            return DAL_NhanVien.Instance.Top5NhanVien();
        }
    }
}
