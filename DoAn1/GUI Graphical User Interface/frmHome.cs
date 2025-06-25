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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        private Form FormCon;

        private void MoFormCon(Form Con)
        {
            if (FormCon != null)
            {
                FormCon.Close();
            }
            FormCon = Con;

            // Đặt form con thành không phải cấp cao nhất để có thể nhúng nó vào trong panel
            Con.TopLevel = false;

            // Loại bỏ viền của form con
            Con.FormBorderStyle = FormBorderStyle.None;

            // Đặt form con điền đầy panel cha
            Con.Dock = DockStyle.Fill;

            // Thêm form con vào danh sách Controls của panel cha
            panelHienThiThongTin.Controls.Add(Con);

            // Gán form con vào thuộc tính Tag của panel cha để dễ dàng truy cập lại sau này
            panelHienThiThongTin.Tag = Con;


            // Đưa form con lên trên cùng của form để đảm bảo nó không bị che khuất bởi các control khác
            Con.BringToFront();

            // Hiển thị form con
            Con.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            int quyen = frmDangNhap.getQuyen();
            if (quyen == 0)
            {
                //đóng chức năng với nhân viên
                btNhanVien.Visible = false;
                btThongKe.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (FormCon != null)
            {
                FormCon.Close();
            }
        }

        private void btNhapHang_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmNhapHang());

        }

        private void btBanHang_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmBanHang());
        }
        
        private void btTruyen_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmTruyen());
        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmKhachHangThanhVien());
        }

        private void btNhanVien_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmNhanVien());
        }

        private void btHoaDonNhap_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmHoaDonNhap());
        }

        private void btHoaDonBan_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmHoaDonBan());
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmThongKe());
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult DangXuat;
            DangXuat = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DangXuat == DialogResult.Yes)
            {
                Hide();
                frmDangNhap login = new frmDangNhap();
                login.Show();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            ClassHoTro.Thoat();
        }
    }
}
