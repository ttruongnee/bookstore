using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data_Transfer_Object
{
    public class DTO_TheLoai
    {
        private string maTheLoai;
        private string tenTheLoai;
        private string moTa;
        //Ctrl + R + E
        public string MaTheLoai { get => maTheLoai; set => maTheLoai = value; }
        public string TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }
        public string MoTa { get => moTa; set => moTa = value; }

        public DTO_TheLoai(string matheloai, string tentheloai, string mota)
        {
            this.MaTheLoai = matheloai;
            this.TenTheLoai = tentheloai;
            this.MoTa = mota;
        }   
        public DTO_TheLoai(DataRow row)
        {
            this.MaTheLoai = row["MaTheLoai"].ToString();
            this.TenTheLoai = row["TenTheLoai"].ToString();
            this.MoTa = row["MoTa"].ToString();
        }


    }
}
