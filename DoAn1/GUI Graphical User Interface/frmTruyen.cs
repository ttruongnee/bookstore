using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BLL_Business_Logic_Layer;
using DTO_Data_Transfer_Object;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_Graphical_User_Interface
{
    public partial class frmTruyen : Form
    {
        private BLL_Truyen BLL_Truyen = new BLL_Truyen();
        private BLL_TheLoai BLL_TheLoai = new BLL_TheLoai();

        public frmTruyen()
        {
            InitializeComponent();
        }

        private void frmTruyen_Load(object sender, EventArgs e)
        {
            //thông tin form truyện
            btMoi_Click(sender, e);

            //thông tin form thể loại
            btMoiTL_Click(sender, e);

        }

        private void btnImage_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png,.jpg)|*.png;*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ptrAnh.Image = Image.FromFile(openFile.FileName);
                ptrAnh.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            dtGKhoTruyen.DataSource = BLL_Truyen.HienTruyen();
            LoadTenTheLoai();
            ClassHoTro.Moi(splitContainer1.Panel2);
            ClassHoTro.Moi(panel1);
            ClassHoTro.Moi(panel2);
            ptrAnh.Image = GUI_Graphical_User_Interface.Properties.Resources.NoImage;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                string matruyen = tbMaTruyen.Text.ToString();
                string tentruyen = tbTenTruyen.Text.ToString();
                string theloai = cbbTheLoai.Text.ToString();
                string tacgia = tbTacGia.Text.ToString();
                int soluong = int.Parse(nudSoLuong.Text);
                int gia = int.Parse(tbGia.Text);
                byte[] hinhanh = ClassHoTro.ImageToBase64(ptrAnh.Image, System.Drawing.Imaging.ImageFormat.Png);
                DTO_Truyen truyen = new DTO_Truyen(matruyen, tentruyen, theloai, tacgia, soluong, gia, hinhanh);
                if (BLL_Truyen.ThemTruyen(truyen))
                {
                    MessageBox.Show("Thêm thông tin truyện thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thông tin truyện thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Thêm thông tin truyện thất bại");
            }
            btMoi_Click(sender, e);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dtGKhoTruyen.SelectedRows.Count > 0)
                {
                    try
                    {

                        string matruyen = tbMaTruyen.Text.ToString();
                        string tentruyen = tbTenTruyen.Text.ToString();
                        string theloai = cbbTheLoai.Text.ToString();
                        string tacgia = tbTacGia.Text.ToString();
                        int soluong = int.Parse(nudSoLuong.Text);
                        int gia = int.Parse(tbGia.Text);
                        byte[] hinhanh = ClassHoTro.ImageToBase64(ptrAnh.Image, System.Drawing.Imaging.ImageFormat.Png);
                        DTO_Truyen truyen = new DTO_Truyen(matruyen, tentruyen, theloai, tacgia, soluong, gia, hinhanh);
                        if (BLL_Truyen.SuaTruyen(truyen))
                        {
                            MessageBox.Show("Cập nhật thông tin truyện thành công");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin truyện thất bại");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Cập nhật thông tin truyện thất bại");
                    }
                }
            }
            btMoi_Click(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_Truyen.XoaTruyen(tbMaTruyen.Text))
                    {
                        MessageBox.Show("Xóa thông tin truyện thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin truyện thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            btMoi_Click(sender, e);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string timkiem = tbTimKiem.Text;
            dtGKhoTruyen.DataSource = BLL_Truyen.TimTruyen(timkiem);
            ClassHoTro.Moi(panel2);
            ptrAnh.Image = GUI_Graphical_User_Interface.Properties.Resources.NoImage;
        }

        private void dtGThongTinKhoTruyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGKhoTruyen.Rows[e.RowIndex];
                tbMaTruyen.Text = row.Cells["MaTruyen"].Value.ToString();
                tbTenTruyen.Text = row.Cells["TenTruyen"].Value.ToString();
                tbTacGia.Text = row.Cells["TacGia"].Value.ToString();
                cbbTheLoai.Text = row.Cells["TheLoai"].Value.ToString();
                nudSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                tbGia.Text = row.Cells["Gia"].Value.ToString();
                if (row.Cells["HinhAnh"].Value != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row.Cells["HinhAnh"].Value;
                    ptrAnh.Image = ClassHoTro.Base64ToImage(imageBytes);
                    ptrAnh.SizeMode = PictureBoxSizeMode.Zoom; // Đặt chế độ hiển thị ảnh để fit với kích thước của PictureBox
                }
                else
                {
                    ptrAnh.Image = null; // Nếu không có ảnh, đặt PictureBox thành null
                }
            }
        }
        private void LoadTenTheLoai()
        {
            cbbTheLoai.DataSource = BLL_Truyen.LoadTenTheLoai();
            cbbTheLoai.DisplayMember = "TenTheLoai";
        }

        private void btMoiTL_Click(object sender, EventArgs e)
        {
            dtGTheLoai.DataSource = BLL_TheLoai.HienTheLoai();
            ClassHoTro.Moi(splitContainer2.Panel2);
        }

        private bool checknull(TextBox tb)
        {
            if (tb.Text.Trim() != "")
            {
                return true;
            }
            return false;
        }

        private void btThemTL_Click(object sender, EventArgs e)
        {
            try
            {
                if (checknull(tbMaTheLoai) && checknull(tbTenTheLoai))
                {
                    DTO_TheLoai theloai = new DTO_TheLoai(tbMaTheLoai.Text, tbTenTheLoai.Text, tbMoTa.Text);
                    if (BLL_TheLoai.ThemTheLoai(theloai))
                    {
                        MessageBox.Show("Thêm thông tin thể loại thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin thể loại thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thêm thông tin thể loại truyện, vui lòng kiểm tra lại");
            }
            btMoiTL_Click(sender, e);
        }

        private void btSuaTL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (checknull(tbMaTheLoai) && checknull(tbTenTheLoai))
                    {
                        DTO_TheLoai theloai = new DTO_TheLoai(tbMaTheLoai.Text, tbTenTheLoai.Text, tbMoTa.Text);
                        if (BLL_TheLoai.SuaTheLoai(theloai))
                        {
                            MessageBox.Show("Cập nhật thông tin thể loại thành công");
                            btMoiTL_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin thể loại thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    }
                }
                catch
                {
                    MessageBox.Show("Cập nhật thông tin thể loại thất bại");
                }
            }
        }

        private void btXoaTL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_TheLoai.XoaTheLoai(tbMaTheLoai.Text))
                    {
                        MessageBox.Show("Xóa thông tin thể loại thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin thể loại thất bại");
                    }
                }
                catch
                {
                    MessageBox.Show($"Tồn tại truyện có thể loại là {tbTenTheLoai.Text} nên không thể xoá");
                }
            }
            btMoiTL_Click(sender, e);
        }

        private void btTimKiemTL_Click(object sender, EventArgs e)
        {
            string tentheloai = tbTimKiemTL.Text;
            dtGTheLoai.DataSource = BLL_TheLoai.TimTheLoai(tentheloai);
            ClassHoTro.Moi(splitContainer2.Panel2);
        }

        private void dtGTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGTheLoai.Rows[e.RowIndex];
                tbMaTheLoai.Text = row.Cells["MaTheLoai"].Value.ToString();
                tbTenTheLoai.Text = row.Cells["TenTheLoai"].Value.ToString();
                tbMoTa.Text = row.Cells["MoTa"].Value.ToString();
            }
        }

        private void dtGKhoTruyen_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtGKhoTruyen.Columns[e.ColumnIndex].Name == "Gia")
            {
                if (e.Value is int giaTien)
                {
                    // Định dạng giá trị kiểu int thành chuỗi với dấu phẩy ngăn cách hàng nghìn
                    e.Value = giaTien.ToString("N0");
                    e.FormattingApplied = true; // Đánh dấu đã xử lý định dạng
                }
            }
        }
    }
}
