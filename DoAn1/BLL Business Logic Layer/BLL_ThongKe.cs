using DAL_Data_Access_Layers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Business_Logic_Layer
{
    public class BLL_ThongKe
    {
        public DataTable HienThiDoanhThu(DateTime batdau, DateTime ketthuc)
        {
            return DAL_ThongKe.Instance.HienThiDoanhThu(batdau, ketthuc);
        }
    }
}
