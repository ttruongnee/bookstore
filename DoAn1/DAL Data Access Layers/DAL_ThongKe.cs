using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Data_Access_Layers
{
    public class DAL_ThongKe
    {
        private static DAL_ThongKe instance;

        public static DAL_ThongKe Instance 
        {
            get { if (instance == null) instance = new DAL_ThongKe(); return instance; }
            private set { instance = value; }
        }
        public DataTable HienThiDoanhThu(DateTime batdau, DateTime ketthuc)
        {
            return DataProvider.Instance.ExecuteQuery($"EXEC sp_DoanhThu @NgayBatDau = '{batdau}', @NgayKetThuc = '{ketthuc}'");
        }
    }
}
