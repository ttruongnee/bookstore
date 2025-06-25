using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data_Transfer_Object
{
    public class DTO_ChiTietHoaDonNhap
    {
        private string maHoaDonNhap;
        private string maTruyen;
        private int soLuongNhap;
        private int giaNhap;
        private int thanhTien;

        public string MaHoaDonNhap { get => maHoaDonNhap; set => maHoaDonNhap = value; }
        public string MaTruyen { get => maTruyen; set => maTruyen = value; }
        public int SoLuongNhap { get => soLuongNhap; set => soLuongNhap = value; }
        public int GiaNhap { get => giaNhap; set => giaNhap = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }

        public DTO_ChiTietHoaDonNhap(string mahdn, string matruyen, int slnhap, int gianhap,int thanhtien)
        {
            this.maHoaDonNhap = mahdn;
            this.MaTruyen = matruyen;
            this.SoLuongNhap = slnhap;
            this.GiaNhap = gianhap;
            this.ThanhTien = thanhtien;
        }
        public DTO_ChiTietHoaDonNhap(DataRow row) 
        {
            this.maHoaDonNhap = row["MaHoaDonNhap"].ToString();
            this.MaTruyen = row["MaTruyen"].ToString();
            this.SoLuongNhap = (int)row["SoLuongNhap"];
            this.GiaNhap = (int)row["GiaNhap"];
            this.ThanhTien = (int)row["ThanhTien"];
        }
    }
}
