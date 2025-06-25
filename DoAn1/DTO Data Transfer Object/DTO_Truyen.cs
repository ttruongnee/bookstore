using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data_Transfer_Object
{
    public class DTO_Truyen
    {
        private string maTruyen;
        private string tenTruyen;
        private string maTheLoai;
        private string tacGia;
        private int soLuong;
        private int gia;
        private byte[] hinhAnh;

        public DTO_Truyen(string matruyen, string tentruyen, string matheloai, string tacgia, int soluong, int gia, byte[] hinhanh)
        {
            this.MaTruyen = matruyen;
            this.TenTruyen = tentruyen;
            this.MaTheLoai = matheloai;
            this.TacGia = tacgia;
            this.SoLuong = soluong;
            this.Gia = gia;
            this.HinhAnh = hinhanh;
        }
        public DTO_Truyen(DataRow row) 
        {
            this.MaTruyen = row["MaTruyen"].ToString();
            this.TenTruyen = row["TenTruyen"].ToString();
            this.MaTheLoai = row["MaTheLoai"].ToString();
            this.TacGia = row["TacGia"].ToString();
            this.SoLuong = (int)row["SoLuong"];
            this.Gia = (int)row["Gia"];
            this.HinhAnh = (byte[])row["HinhAnh"];
        }
        public string MaTruyen { get => maTruyen; set => maTruyen = value; }
        public string TenTruyen { get => tenTruyen; set => tenTruyen = value; }
        public string MaTheLoai { get => maTheLoai; set => maTheLoai = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int Gia { get => gia; set => gia = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
    }
}
