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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI_Graphical_User_Interface
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private BLL_TaiKhoan BLL_TaiKhoan = new BLL_TaiKhoan();

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            //tbTaiKhoan.Focus();  //Đặt con trỏ vào control, nhưng chỉ hoạt động khi control đã sẵn sàng nhận focus.Nếu control chưa sẵn sàng (ví dụ: form chưa hoàn toàn tải xong), Focus() sẽ không hoạt động.
            tbTaiKhoan.Select();  //yêu cầu control nhận focus. Nếu control chưa sẵn sàng nhận focus ngay lập tức, nó sẽ nhận focus ngay khi có thể.

        }

        private static int Quyen = 0;
        public static int getQuyen()
        {
            return Quyen;
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string user = tbTaiKhoan.Text;
            string pass = tbMatKhau.Text;
            if (Login(user, pass))
            {
                Quyen = BLL_TaiKhoan.Quyen(user);
                Hide();  //ẩn form đăng nhập
                frmHome Home = new frmHome();
                //Home.ShowDialog();
                //this.Close();
                Home.Show();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không đúng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTaiKhoan.Focus();
            }
        }
        bool Login(string userName, string passWord)
        {
            return BLL_TaiKhoan.Login(userName, passWord);
        }

        //kiểm tra text nhập vào textbox tên đăng nhập là gì? (null hay không?)
        private void tbTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTaiKhoan.Text))
            {
                tbTaiKhoan.Focus();
                errorProvider1.SetError(tbTaiKhoan, "Vui lòng nhập tên đăng nhập!");
            }
            else
            {
                errorProvider1.SetError(tbTaiKhoan, null);
            }
        }

        //sự kiện xảy ra khi control mất focus (ví dụ chuyển con trỏ sang textbox khác) để check textbox tên đăng nhập có thông tin hay chưa
        private void tbTaiKhoan_Validating(object sender, CancelEventArgs e)
        {
            tbTaiKhoan_TextChanged(sender, e);

        }

        //kiểm tra text nhập vào textbox mật khẩu là gì? (null hay không?)
        private void tbMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMatKhau.Text))
            {
                tbMatKhau.Focus();
                errorProvider1.SetError(tbMatKhau, "Vui lòng nhập mật khẩu!");
            }
            else
            {
                errorProvider1.SetError(tbMatKhau, null);
            }
        }

        //sự kiện xảy ra khi control mất focus (ví dụ chuyển con trỏ sang textbox khác) để check textbox mật khẩu có thông tin hay chưa
        private void tbMatKhau_Validating(object sender, CancelEventArgs e)
        {
            tbMatKhau_TextChanged(sender, e);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            ClassHoTro.Thoat();
        }
    }
}
