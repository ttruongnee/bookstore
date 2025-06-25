using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data_Transfer_Object
{
    public class DTO_HoaDonNhap
    {
        private string maHoaDonNhap;
        private DateTime ngayNhap;
        private int tongTien;
        private string maNhanVienNhap;

        public string MaHoaDonNhap { get => maHoaDonNhap; set => maHoaDonNhap = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public string MaNhanVienNhap { get => maNhanVienNhap; set => maNhanVienNhap = value; }

        public DTO_HoaDonNhap(string maHoaDonNhap, DateTime ngayNhap, int tongTien, string maNhanVienNhap)
        {
            this.MaHoaDonNhap = maHoaDonNhap;
            this.NgayNhap = ngayNhap;
            this.TongTien = tongTien;
            this.MaNhanVienNhap = maNhanVienNhap;
        }

        public DTO_HoaDonNhap(DataRow row)
        {
            this.MaHoaDonNhap = row["MaHoaDonNhap"].ToString();
            this.NgayNhap = (DateTime)row["NgayNhap"];
            this.TongTien = (int)row["TongTien"];
            this.MaNhanVienNhap = row["MaNhanVienNhap"].ToString();
        }
    }
}
