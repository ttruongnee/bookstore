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
    public class BLL_TheLoai
    {
        public DataTable HienTheLoai()
        {
            return DAL_TheLoai.Instance.HienThiTheLoai();
        }
        public bool ThemTheLoai(DTO_TheLoai theloai)
        {
            return DAL_TheLoai.Instance.ThemTheLoai(theloai);
        }
        public bool SuaTheLoai(DTO_TheLoai theloai)
        {
            return DAL_TheLoai.Instance.SuaTheLoai(theloai);
        }
        public bool XoaTheLoai(string matl)
        {
            return DAL_TheLoai.Instance.XoaTheLoai(matl);
        }
        public DataTable TimTheLoai(string tentl)
        {
            return DAL_TheLoai.Instance.TimTheLoai(tentl);
        }
    }
}
