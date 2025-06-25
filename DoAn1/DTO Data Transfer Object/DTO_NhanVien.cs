using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data_Transfer_Object
{
    public class DTO_NhanVien
    {
        private string maNV;
        private string hoTenNV;
        private string gioiTinh;
        private string queQuan;
        private string soDienThoai;
        
        public DTO_NhanVien(string manv, string hotennv, string gioitinh, string quequan, string sodienthoai)
        {
            this.MaNV = manv;
            this.HoTenNV= hotennv;
            this.GioiTinh= gioitinh;
            this.QueQuan= quequan;
            this.SoDienThoai= sodienthoai;
        }
        public DTO_NhanVien(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.HoTenNV = row["HoTenNV"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.QueQuan = row["QueQuan"].ToString();
            this.SoDienThoai = row["SoDienThoai"].ToString();
        }
        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
    }
}
