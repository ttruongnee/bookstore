using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data_Transfer_Object
{
    public class DTO_KhachHangThanhVien
    {
        private string maKHTV;
        private string hoTenKHTV;
        private string soDienThoai;
        private string diaChi;
        private DateTime hSDTheThanhVien;

        public string MaKHTV { get => maKHTV; set => maKHTV = value; }
        public string HoTenKHTV { get => hoTenKHTV; set => hoTenKHTV = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime HSDTheThanhVien { get => hSDTheThanhVien; set => hSDTheThanhVien = value; }

        public DTO_KhachHangThanhVien(string makhtv, string hotenkhtv, string sodienthoai, string diachi, DateTime hsdttv)
        {
            this.MaKHTV= makhtv;
            this.HoTenKHTV= hotenkhtv;
            this.SoDienThoai = sodienthoai;
            this.DiaChi = diachi;
            this.HSDTheThanhVien= hsdttv;          
        }
        public DTO_KhachHangThanhVien(DataRow row)
        {
            this.MaKHTV = row["MaKHTV"].ToString();
            this.HoTenKHTV = row["HoTenKHTV"].ToString();
            this.SoDienThoai = row["SoDienThoai"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.HSDTheThanhVien = (DateTime)row["HSDTheThanhVien"];
        }

    }
}
