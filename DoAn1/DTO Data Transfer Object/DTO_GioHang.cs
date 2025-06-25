using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data_Transfer_Object
{
    public class DTO_GioHang
    {
        private string maHoaDon;
        private string maTruyen;
        private int soLuong;
        private int gia;
        private int thanhTien;

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaTruyen { get => maTruyen; set => maTruyen = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int Gia { get => gia; set => gia = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }

        public DTO_GioHang(string mahd, string matruyen, int sl, int gia, int thanhtien)
        {
            this.maHoaDon = mahd;
            this.MaTruyen = matruyen;
            this.SoLuong = sl;
            this.Gia = gia;
            this.ThanhTien = thanhtien;
        }
        public DTO_GioHang(DataRow row)
        {
            this.maHoaDon = row["MaHoaDon"].ToString();
            this.MaTruyen = row["MaTruyen"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            this.Gia = (int)row["Gia"];
            this.ThanhTien = (int)row["ThanhTien"];
        }
    }
}
