using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_Data_Access_Layers;
using DTO_Data_Transfer_Object;

namespace BLL_Business_Logic_Layer
{
    public class BLL_Truyen
    {
        public static DataTable HienTruyen()
        {
            return DAL_Truyen.Instance.HienTruyen();
        }
        public bool ThemTruyen(DTO_Truyen truyen)
        {
            return DAL_Truyen.Instance.ThemTruyen(truyen);
        }
        public bool SuaTruyen(DTO_Truyen truyen)
        {
            return DAL_Truyen.Instance.SuaTruyen(truyen);
        }
        public bool XoaTruyen(string matruyen)
        {
            return DAL_Truyen.Instance.XoaTruyen(matruyen);
        }
        public DataTable TimTruyen(string timkiem)
        {
            return DAL_Truyen.Instance.TimTruyen(timkiem);
        }
        public void TangSLTruyen(string matruyen, int slnhap)
        {
             DAL_Truyen.Instance.TangSLTruyen(matruyen,slnhap); 
        }
        public void GiamSLTruyen(string matruyen, int slban)
        {
            DAL_Truyen.Instance.GiamSLTruyen(matruyen, slban);
        }

        public DataTable LoadTenTheLoai()
        {
            return DAL_Truyen.Instance.LoadTenTheLoai();
        }

        public DataTable Top5TruyenBanChay() 
        {
            return DAL_Truyen.Instance.Top5TruyenBanChay();
        }
    }
}
