using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Graphical_User_Interface
{
    public class ClassHoTro
    {
        public static void Thoat()
        {
            DialogResult Thoat;
            Thoat = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Thoat == DialogResult.Yes)
            {
                //phương thức này sẽ kích hoạt đến FormClosing của tất cả các Form đang mở
                Application.Exit();
            }
        }


        public static void Moi(Panel panel1)
        {
            foreach (Control ctr in panel1.Controls)
            {
                if (ctr is TextBox || ctr is MaskedTextBox || ctr is ComboBox || ctr is NumericUpDown)
                {
                    ctr.Text = null;
                }
                else if (ctr is GroupBox)
                {
                    foreach (Control i in ctr.Controls)
                    {
                        if (i is TextBox || i is MaskedTextBox || i is ComboBox || i is NumericUpDown)
                        {
                            i.Text = null;
                        }
                    }
                }
            }
        }

        public static byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)  //chuyển hình ảnh thành mảng byte
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);  //lưu dữ liệu ảnh vào luồng MemoryStream
                byte[] imageBytes = ms.ToArray();  //chuyển đổi dữ liệu từ luồng thành mảng byte
                return imageBytes;
            }
        }
        public static Image Base64ToImage(byte[] imageBytes)  //chuyển mảng byte thành hình ảnh
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))   //tạo đối tượng MemoryStream từ mảng byte imageBytes
            {
                Image image = Image.FromStream(ms);  //chuyển đổi dữ liệu từ luồng thành hình ảnh
                return image;
            }
        }
    }
}
