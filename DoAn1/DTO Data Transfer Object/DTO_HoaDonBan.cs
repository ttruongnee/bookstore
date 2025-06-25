using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data_Transfer_Object
{
    public class DTO_HoaDonBan
    {
        private string maHoaDonBan;
        private DateTime ngayBan;
        private int tongTien;
        private string maNhanVienBan;
        private string maKHTV;

        public string MaHoaDonBan { get => maHoaDonBan; set => maHoaDonBan = value; }
        public DateTime NgayBan { get => ngayBan; set => ngayBan = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public string MaNhanVienBan { get => maNhanVienBan; set => maNhanVienBan = value; }
        public string MaKHTV { get => maKHTV; set => maKHTV = value; }

        public DTO_HoaDonBan(string maHoaDonBan, DateTime ngayBan, int tongTien, string maNVBan, string maKHTV)
        { 
            this.MaHoaDonBan = maHoaDonBan;
            this.NgayBan = ngayBan;
            this.TongTien = tongTien;
            this.MaNhanVienBan = maNVBan;
            this.MaKHTV = maKHTV;
        }

        public DTO_HoaDonBan(DataRow row)
        {
            this.MaHoaDonBan = row["MaHoaDonBan"].ToString();
            this.NgayBan = (DateTime)row["NgayBan"];
            this.TongTien = (int)row["TongTien"];
            this.MaNhanVienBan = row["MaNhanVienBan"].ToString();
            this.MaKHTV = row["MaKHTV"].ToString();
        }
    }
}
