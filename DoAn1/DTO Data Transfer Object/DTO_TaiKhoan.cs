using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data_Transfer_Object
{
    public class DTO_TaiKhoan
    {
        private string userName;
        private string passWord;
        private int quyen;

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int Quyen { get => quyen; set => quyen = value; }

        public DTO_TaiKhoan(string user, string pass, int quyen)
        {
            this.UserName = user;
            this.PassWord = pass;
            this.Quyen = quyen;
        }
        public DTO_TaiKhoan(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.PassWord = row["PassWord"].ToString();
            this.Quyen = (int)row["Quyen"];
        }
    }
}
