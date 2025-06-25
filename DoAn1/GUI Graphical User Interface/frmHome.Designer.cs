namespace GUI_Graphical_User_Interface
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btNhapHang = new Guna.UI2.WinForms.Guna2Button();
            this.btBanHang = new Guna.UI2.WinForms.Guna2Button();
            this.btTruyen = new Guna.UI2.WinForms.Guna2Button();
            this.btKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btHoaDonNhap = new Guna.UI2.WinForms.Guna2Button();
            this.btHoaDonBan = new Guna.UI2.WinForms.Guna2Button();
            this.btThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btThoat = new Guna.UI2.WinForms.Guna2Button();
            this.panelHienThiThongTin = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelHienThiThongTin);
            this.splitContainer1.Size = new System.Drawing.Size(1290, 619);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(226, 619);
            this.splitContainer2.SplitterDistance = 77;
            this.splitContainer2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI_Graphical_User_Interface.Properties.Resources.LogoMangaBook;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btNhapHang);
            this.flowLayoutPanel1.Controls.Add(this.btBanHang);
            this.flowLayoutPanel1.Controls.Add(this.btTruyen);
            this.flowLayoutPanel1.Controls.Add(this.btKhachHang);
            this.flowLayoutPanel1.Controls.Add(this.btNhanVien);
            this.flowLayoutPanel1.Controls.Add(this.btHoaDonNhap);
            this.flowLayoutPanel1.Controls.Add(this.btHoaDonBan);
            this.flowLayoutPanel1.Controls.Add(this.btThongKe);
            this.flowLayoutPanel1.Controls.Add(this.btDangXuat);
            this.flowLayoutPanel1.Controls.Add(this.btThoat);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(226, 538);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btNhapHang
            // 
            this.btNhapHang.BackColor = System.Drawing.Color.Gainsboro;
            this.btNhapHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNhapHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btNhapHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btNhapHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btNhapHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btNhapHang.FillColor = System.Drawing.Color.FloralWhite;
            this.btNhapHang.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btNhapHang.ForeColor = System.Drawing.Color.Black;
            this.btNhapHang.Image = global::GUI_Graphical_User_Interface.Properties.Resources.NhapHang;
            this.btNhapHang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btNhapHang.ImageSize = new System.Drawing.Size(38, 38);
            this.btNhapHang.Location = new System.Drawing.Point(3, 3);
            this.btNhapHang.Name = "btNhapHang";
            this.btNhapHang.Size = new System.Drawing.Size(220, 45);
            this.btNhapHang.TabIndex = 2;
            this.btNhapHang.Text = "Nhập hàng";
            this.btNhapHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btNhapHang.Click += new System.EventHandler(this.btNhapHang_Click);
            // 
            // btBanHang
            // 
            this.btBanHang.BackColor = System.Drawing.Color.Gainsboro;
            this.btBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBanHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBanHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBanHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBanHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBanHang.FillColor = System.Drawing.Color.FloralWhite;
            this.btBanHang.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btBanHang.ForeColor = System.Drawing.Color.Black;
            this.btBanHang.Image = global::GUI_Graphical_User_Interface.Properties.Resources.BanHang;
            this.btBanHang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btBanHang.ImageSize = new System.Drawing.Size(35, 35);
            this.btBanHang.Location = new System.Drawing.Point(3, 54);
            this.btBanHang.Name = "btBanHang";
            this.btBanHang.Size = new System.Drawing.Size(220, 45);
            this.btBanHang.TabIndex = 2;
            this.btBanHang.Text = "Bán hàng";
            this.btBanHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btBanHang.Click += new System.EventHandler(this.btBanHang_Click);
            // 
            // btTruyen
            // 
            this.btTruyen.BackColor = System.Drawing.Color.Gainsboro;
            this.btTruyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTruyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btTruyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btTruyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btTruyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btTruyen.FillColor = System.Drawing.Color.FloralWhite;
            this.btTruyen.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btTruyen.ForeColor = System.Drawing.Color.Black;
            this.btTruyen.Image = global::GUI_Graphical_User_Interface.Properties.Resources.Truyen;
            this.btTruyen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btTruyen.ImageSize = new System.Drawing.Size(35, 35);
            this.btTruyen.Location = new System.Drawing.Point(3, 105);
            this.btTruyen.Name = "btTruyen";
            this.btTruyen.Size = new System.Drawing.Size(220, 45);
            this.btTruyen.TabIndex = 2;
            this.btTruyen.Text = "Truyện";
            this.btTruyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btTruyen.Click += new System.EventHandler(this.btTruyen_Click);
            // 
            // btKhachHang
            // 
            this.btKhachHang.BackColor = System.Drawing.Color.Gainsboro;
            this.btKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btKhachHang.FillColor = System.Drawing.Color.FloralWhite;
            this.btKhachHang.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btKhachHang.Image = global::GUI_Graphical_User_Interface.Properties.Resources.KhachHang;
            this.btKhachHang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btKhachHang.ImageSize = new System.Drawing.Size(35, 35);
            this.btKhachHang.Location = new System.Drawing.Point(3, 156);
            this.btKhachHang.Name = "btKhachHang";
            this.btKhachHang.Size = new System.Drawing.Size(220, 45);
            this.btKhachHang.TabIndex = 2;
            this.btKhachHang.Text = "Khách hàng";
            this.btKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btKhachHang.Click += new System.EventHandler(this.btKhachHang_Click);
            // 
            // btNhanVien
            // 
            this.btNhanVien.BackColor = System.Drawing.Color.Gainsboro;
            this.btNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btNhanVien.FillColor = System.Drawing.Color.FloralWhite;
            this.btNhanVien.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btNhanVien.Image = global::GUI_Graphical_User_Interface.Properties.Resources.NhanVien;
            this.btNhanVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btNhanVien.ImageSize = new System.Drawing.Size(35, 35);
            this.btNhanVien.Location = new System.Drawing.Point(3, 207);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.Size = new System.Drawing.Size(220, 45);
            this.btNhanVien.TabIndex = 2;
            this.btNhanVien.Text = "Nhân viên";
            this.btNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btNhanVien.Click += new System.EventHandler(this.btNhanVien_Click);
            // 
            // btHoaDonNhap
            // 
            this.btHoaDonNhap.BackColor = System.Drawing.Color.Gainsboro;
            this.btHoaDonNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHoaDonNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btHoaDonNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btHoaDonNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btHoaDonNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btHoaDonNhap.FillColor = System.Drawing.Color.FloralWhite;
            this.btHoaDonNhap.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btHoaDonNhap.ForeColor = System.Drawing.Color.Black;
            this.btHoaDonNhap.Image = global::GUI_Graphical_User_Interface.Properties.Resources.HoaDon;
            this.btHoaDonNhap.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHoaDonNhap.ImageSize = new System.Drawing.Size(35, 35);
            this.btHoaDonNhap.Location = new System.Drawing.Point(3, 258);
            this.btHoaDonNhap.Name = "btHoaDonNhap";
            this.btHoaDonNhap.Size = new System.Drawing.Size(220, 45);
            this.btHoaDonNhap.TabIndex = 2;
            this.btHoaDonNhap.Text = "Hoá đơn nhập";
            this.btHoaDonNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHoaDonNhap.Click += new System.EventHandler(this.btHoaDonNhap_Click);
            // 
            // btHoaDonBan
            // 
            this.btHoaDonBan.BackColor = System.Drawing.Color.Gainsboro;
            this.btHoaDonBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHoaDonBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btHoaDonBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btHoaDonBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btHoaDonBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btHoaDonBan.FillColor = System.Drawing.Color.FloralWhite;
            this.btHoaDonBan.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btHoaDonBan.ForeColor = System.Drawing.Color.Black;
            this.btHoaDonBan.Image = global::GUI_Graphical_User_Interface.Properties.Resources.HoaDon;
            this.btHoaDonBan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHoaDonBan.ImageSize = new System.Drawing.Size(35, 35);
            this.btHoaDonBan.Location = new System.Drawing.Point(3, 309);
            this.btHoaDonBan.Name = "btHoaDonBan";
            this.btHoaDonBan.Size = new System.Drawing.Size(220, 45);
            this.btHoaDonBan.TabIndex = 2;
            this.btHoaDonBan.Text = "Hoá đơn bán";
            this.btHoaDonBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btHoaDonBan.Click += new System.EventHandler(this.btHoaDonBan_Click);
            // 
            // btThongKe
            // 
            this.btThongKe.BackColor = System.Drawing.Color.Gainsboro;
            this.btThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btThongKe.FillColor = System.Drawing.Color.FloralWhite;
            this.btThongKe.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btThongKe.ForeColor = System.Drawing.Color.Black;
            this.btThongKe.Image = global::GUI_Graphical_User_Interface.Properties.Resources.ThongKe;
            this.btThongKe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btThongKe.ImageSize = new System.Drawing.Size(32, 32);
            this.btThongKe.Location = new System.Drawing.Point(3, 360);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(220, 45);
            this.btThongKe.TabIndex = 2;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // btDangXuat
            // 
            this.btDangXuat.BackColor = System.Drawing.Color.Gainsboro;
            this.btDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDangXuat.FillColor = System.Drawing.Color.FloralWhite;
            this.btDangXuat.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btDangXuat.Image = global::GUI_Graphical_User_Interface.Properties.Resources.DangXuat;
            this.btDangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btDangXuat.ImageSize = new System.Drawing.Size(31, 31);
            this.btDangXuat.Location = new System.Drawing.Point(3, 411);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(220, 45);
            this.btDangXuat.TabIndex = 2;
            this.btDangXuat.Text = "Đăng xuất";
            this.btDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Gainsboro;
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btThoat.FillColor = System.Drawing.Color.FloralWhite;
            this.btThoat.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btThoat.ForeColor = System.Drawing.Color.Black;
            this.btThoat.Image = global::GUI_Graphical_User_Interface.Properties.Resources.Thoat;
            this.btThoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btThoat.ImageSize = new System.Drawing.Size(32, 32);
            this.btThoat.Location = new System.Drawing.Point(3, 462);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(220, 45);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // panelHienThiThongTin
            // 
            this.panelHienThiThongTin.BackgroundImage = global::GUI_Graphical_User_Interface.Properties.Resources.BackgroudHome;
            this.panelHienThiThongTin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHienThiThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHienThiThongTin.Location = new System.Drawing.Point(0, 0);
            this.panelHienThiThongTin.Name = "panelHienThiThongTin";
            this.panelHienThiThongTin.Size = new System.Drawing.Size(1060, 619);
            this.panelHienThiThongTin.TabIndex = 0;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 619);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MangaBook";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelHienThiThongTin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btNhapHang;
        private Guna.UI2.WinForms.Guna2Button btBanHang;
        private Guna.UI2.WinForms.Guna2Button btTruyen;
        private Guna.UI2.WinForms.Guna2Button btKhachHang;
        private Guna.UI2.WinForms.Guna2Button btNhanVien;
        private Guna.UI2.WinForms.Guna2Button btHoaDonNhap;
        private Guna.UI2.WinForms.Guna2Button btThongKe;
        private Guna.UI2.WinForms.Guna2Button btDangXuat;
        private Guna.UI2.WinForms.Guna2Button btThoat;
        private Guna.UI2.WinForms.Guna2Button btHoaDonBan;
    }
}