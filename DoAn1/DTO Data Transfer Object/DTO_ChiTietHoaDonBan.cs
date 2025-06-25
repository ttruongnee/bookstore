using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data_Transfer_Object
{
    public class DTO_ChiTietHoaDonBan
    {
        private string maHoaDonBan;
        private string maTruyen;
        private int soLuongBan;
        private int giaBan;
        private int thanhTien;

        public string MaHoaDonBan { get => maHoaDonBan; set => maHoaDonBan = value; }
        public string MaTruyen { get => maTruyen; set => maTruyen = value; }
        public int SoLuongBan { get => soLuongBan; set => soLuongBan = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }

        public DTO_ChiTietHoaDonBan(string mahdb, string matruyen, int slban, int giaban, int thanhtien)
        {
            this.maHoaDonBan = mahdb;
            this.MaTruyen = matruyen;
            this.SoLuongBan = slban;
            this.GiaBan = giaban;
            this.ThanhTien = thanhtien;
        }
        public DTO_ChiTietHoaDonBan(DataRow row)
        {
            this.maHoaDonBan = row["MaHoaDonBan"].ToString();
            this.MaTruyen = row["MaTruyen"].ToString();
            this.SoLuongBan = (int)row["SoLuongBan"];
            this.GiaBan = (int)row["GiaBan"];
            this.ThanhTien = (int)row["ThanhTien"];
        }
    }
}
