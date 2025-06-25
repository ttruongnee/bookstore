using BLL_Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Graphical_User_Interface
{
    public partial class truyen : UserControl
    {
        public truyen()
        {
            InitializeComponent();
        }
        public int SoLuongMua
        {
            get { return int.Parse(lbSL.Text); }
            set { lbSL.Text = value.ToString(); }
        }

        private BLL_HoaDonBan BLL_HoaDonBan = new BLL_HoaDonBan();
        private BLL_GioHang BLL_GioHang = new BLL_GioHang();

        public void GanThongTin(byte[] HinhAnh, string tenTruyen, string maTruyen, int gia, int sLKho)
        {
            try
            {
                if (!(HinhAnh is DBNull) && HinhAnh.Length > 0)
                {
                    ptrAnh.Image = ClassHoTro.Base64ToImage(HinhAnh);
                    ptrAnh.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    ptrAnh.Image = Properties.Resources.NoImage;
                    ptrAnh.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                ptrAnh.Image = Properties.Resources.NoImage;
                ptrAnh.SizeMode = PictureBoxSizeMode.Zoom;
                Console.WriteLine($"ERROR LOADING IMAGE: {ex.Message}");
            }

            lbTenTruyen.Text = tenTruyen;
            lbMaTruyen.Text = maTruyen.ToString();
            lbGiaBan.Text = gia.ToString("N0");
            lbSoLuongKho.Text = sLKho.ToString();
        }


        private void btTang_Click(object sender, EventArgs e)
        {
            int slkho = int.Parse(lbSoLuongKho.Text);
            if (SoLuongMua < slkho)
            {
                SoLuongMua += 1;
            }
        }

        private void btGiam_Click(object sender, EventArgs e)
        {
            if (SoLuongMua > 0)
            {
                SoLuongMua -= 1;
            }
        }

        public int slkho;
        public static int slb = 1;
        public static int giaban = 0;
        public static string matruyen = null;
        public void btMua_Click(object sender, EventArgs e)
        {
            if (SoLuongMua > 0)
            {
                string mahdb = BLL_HoaDonBan.TaoMaHDB();
                string matruyen = getMaTruyen();
                slb = getSLBan();
                int giaban = getGiaBan();
                BLL_GioHang.ThemGioHang(mahdb, matruyen, slb, giaban);
            }
            else
            {
                MessageBox.Show("Số lượng mua tối thiểu là 1 quyển");
            }
            
        }
        public int getSLBan()
        {
            return int.Parse(lbSL.Text.ToString());
        }
        public string getMaTruyen()
        {
            return lbMaTruyen.Text.ToString();
        }
        public int getGiaBan()
        {
            return int.Parse(lbGiaBan.Text.ToString().Replace(",",""));
        }
    }
}
