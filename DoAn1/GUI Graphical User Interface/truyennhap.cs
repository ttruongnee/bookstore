using BLL_Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Graphical_User_Interface
{
    public partial class truyennhap : UserControl
    {
        public truyennhap()
        {
            InitializeComponent();
        }
        public int SoLuongNhap
        {
            get { return int.Parse(tbSLN.Text); }
            set { tbSLN.Text = value.ToString(); }
        }
        public void GanThongTin(byte[] HinhAnh, string tenTruyen, string maTruyen)
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
        }

        private BLL_HoaDonNhap BLL_HoaDonNhap = new BLL_HoaDonNhap();
        private BLL_GioHang BLL_GioHang = new BLL_GioHang();

        public int slkho;
        public static int sln = 1;
        public static int giaban = 0;
        public static string matruyen = null;
        private void btNhap_Click(object sender, EventArgs e)
        {
            if (SoLuongNhap > 0)
            {
                string mahdb = BLL_HoaDonNhap.TaoMaHDN();
                string matruyen = getMaTruyen();
                sln = getSLNhap();
                int gianhap = getGiaNhap();
                BLL_GioHang.ThemGioHang(mahdb, matruyen, sln, gianhap);
            }
            else
            {
                MessageBox.Show("Không thể nhập ít hơn 1 quyển");
            }
            
        }
        public int getSLNhap()
        {
            return int.Parse(tbSLN.Text.ToString());
        }
        public string getMaTruyen()
        {
            return lbMaTruyen.Text.ToString();
        }
        public int getGiaNhap()
        {
            return int.Parse(tbGiaNhap.Text.ToString());
        }

        private void btGiam_Click(object sender, EventArgs e)
        {
            if (SoLuongNhap > 0)
            {
                SoLuongNhap -= 1;
            }
        }

        private void btTang_Click(object sender, EventArgs e)
        {
            SoLuongNhap += 1;
        }

        private void tbSLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số và không phải là ký tự điều khiển (như Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho nhập ký tự không hợp lệ
            }
        }

        private void tbGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự nhập vào có phải là số và không phải là ký tự điều khiển (như Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho nhập ký tự không hợp lệ
            }
            else if (e.KeyChar == '0' && tbGiaNhap.Text.Length == 0)
            {
                e.Handled = true; // Ngăn không cho nhập số 0 đầu tiên nếu đó là ký tự đầu tiên
            }
        }

        private void tbGiaNhap_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu tbGiaNhap trống
            if (tbGiaNhap.Text == "")
            {
                // Đặt giá trị mặc định là 0
                tbGiaNhap.Text = "0";
            }
        }

        private void tbSLN_Leave(object sender, EventArgs e)
        {
            // Kiểm tra nếu tbSLN trống
            if (tbSLN.Text == "")
            {
                // Đặt giá trị mặc định là 1
                tbSLN.Text = "1";
            }
        }
    }
}
