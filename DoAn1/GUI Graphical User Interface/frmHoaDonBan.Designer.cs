namespace GUI_Graphical_User_Interface
{
    partial class frmHoaDonBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMoi = new System.Windows.Forms.Button();
            this.gbHoaDonNhap = new System.Windows.Forms.GroupBox();
            this.cbbMaKHTV = new System.Windows.Forms.ComboBox();
            this.cbbNhanVienBan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaHoaDonBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbChiTietHoaDonNhap = new System.Windows.Forms.GroupBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbbTruyen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbThanhTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCTMaHoaDonBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGiaBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.dtgChiTietHoaDonBan = new System.Windows.Forms.DataGridView();
            this.CTMaHoaDonBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTruyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgHoaDonBan = new System.Windows.Forms.DataGridView();
            this.MaHoaDonBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHangThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSua = new System.Windows.Forms.Button();
            this.dtpNgayBan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel1.SuspendLayout();
            this.gbHoaDonNhap.SuspendLayout();
            this.gbChiTietHoaDonNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietHoaDonBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDonBan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.btMoi);
            this.panel1.Controls.Add(this.gbHoaDonNhap);
            this.panel1.Controls.Add(this.gbChiTietHoaDonNhap);
            this.panel1.Controls.Add(this.tbTimKiem);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btTimKiem);
            this.panel1.Controls.Add(this.dtgChiTietHoaDonBan);
            this.panel1.Controls.Add(this.dtgHoaDonBan);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 603);
            this.panel1.TabIndex = 0;
            // 
            // btMoi
            // 
            this.btMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btMoi.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btMoi.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btMoi.Location = new System.Drawing.Point(27, 542);
            this.btMoi.Name = "btMoi";
            this.btMoi.Size = new System.Drawing.Size(124, 47);
            this.btMoi.TabIndex = 42;
            this.btMoi.Text = "Mới";
            this.btMoi.UseVisualStyleBackColor = false;
            this.btMoi.Click += new System.EventHandler(this.btMoi_Click);
            // 
            // gbHoaDonNhap
            // 
            this.gbHoaDonNhap.Controls.Add(this.dtpNgayBan);
            this.gbHoaDonNhap.Controls.Add(this.cbbMaKHTV);
            this.gbHoaDonNhap.Controls.Add(this.cbbNhanVienBan);
            this.gbHoaDonNhap.Controls.Add(this.label5);
            this.gbHoaDonNhap.Controls.Add(this.label2);
            this.gbHoaDonNhap.Controls.Add(this.tbMaHoaDonBan);
            this.gbHoaDonNhap.Controls.Add(this.label4);
            this.gbHoaDonNhap.Controls.Add(this.tbTongTien);
            this.gbHoaDonNhap.Controls.Add(this.label10);
            this.gbHoaDonNhap.Controls.Add(this.label3);
            this.gbHoaDonNhap.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbHoaDonNhap.Location = new System.Drawing.Point(27, 14);
            this.gbHoaDonNhap.Margin = new System.Windows.Forms.Padding(4);
            this.gbHoaDonNhap.Name = "gbHoaDonNhap";
            this.gbHoaDonNhap.Padding = new System.Windows.Forms.Padding(4);
            this.gbHoaDonNhap.Size = new System.Drawing.Size(445, 275);
            this.gbHoaDonNhap.TabIndex = 36;
            this.gbHoaDonNhap.TabStop = false;
            this.gbHoaDonNhap.Text = "Hoá đơn bán";
            // 
            // cbbMaKHTV
            // 
            this.cbbMaKHTV.FormattingEnabled = true;
            this.cbbMaKHTV.Location = new System.Drawing.Point(183, 221);
            this.cbbMaKHTV.Name = "cbbMaKHTV";
            this.cbbMaKHTV.Size = new System.Drawing.Size(235, 32);
            this.cbbMaKHTV.TabIndex = 121;
            // 
            // cbbNhanVienBan
            // 
            this.cbbNhanVienBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNhanVienBan.FormattingEnabled = true;
            this.cbbNhanVienBan.Location = new System.Drawing.Point(183, 172);
            this.cbbNhanVienBan.Name = "cbbNhanVienBan";
            this.cbbNhanVienBan.Size = new System.Drawing.Size(235, 32);
            this.cbbNhanVienBan.TabIndex = 121;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(74, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 115;
            this.label5.Text = "Ngày bán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 113;
            this.label2.Text = "Mã hoá đơn bán:";
            // 
            // tbMaHoaDonBan
            // 
            this.tbMaHoaDonBan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.tbMaHoaDonBan.Location = new System.Drawing.Point(183, 36);
            this.tbMaHoaDonBan.Name = "tbMaHoaDonBan";
            this.tbMaHoaDonBan.Size = new System.Drawing.Size(235, 32);
            this.tbMaHoaDonBan.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(77, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 116;
            this.label4.Text = "Tổng tiền:";
            // 
            // tbTongTien
            // 
            this.tbTongTien.Enabled = false;
            this.tbTongTien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.tbTongTien.Location = new System.Drawing.Point(183, 123);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(235, 32);
            this.tbTongTien.TabIndex = 118;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(77, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 24);
            this.label10.TabIndex = 117;
            this.label10.Text = "Mã KHTV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(34, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 117;
            this.label3.Text = "Nhân viên bán:";
            // 
            // gbChiTietHoaDonNhap
            // 
            this.gbChiTietHoaDonNhap.Controls.Add(this.nudSoLuong);
            this.gbChiTietHoaDonNhap.Controls.Add(this.cbbTruyen);
            this.gbChiTietHoaDonNhap.Controls.Add(this.label1);
            this.gbChiTietHoaDonNhap.Controls.Add(this.label11);
            this.gbChiTietHoaDonNhap.Controls.Add(this.tbThanhTien);
            this.gbChiTietHoaDonNhap.Controls.Add(this.label6);
            this.gbChiTietHoaDonNhap.Controls.Add(this.tbCTMaHoaDonBan);
            this.gbChiTietHoaDonNhap.Controls.Add(this.label7);
            this.gbChiTietHoaDonNhap.Controls.Add(this.tbGiaBan);
            this.gbChiTietHoaDonNhap.Controls.Add(this.label8);
            this.gbChiTietHoaDonNhap.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbChiTietHoaDonNhap.Location = new System.Drawing.Point(521, 14);
            this.gbChiTietHoaDonNhap.Margin = new System.Windows.Forms.Padding(4);
            this.gbChiTietHoaDonNhap.Name = "gbChiTietHoaDonNhap";
            this.gbChiTietHoaDonNhap.Padding = new System.Windows.Forms.Padding(4);
            this.gbChiTietHoaDonNhap.Size = new System.Drawing.Size(436, 275);
            this.gbChiTietHoaDonNhap.TabIndex = 35;
            this.gbChiTietHoaDonNhap.TabStop = false;
            this.gbChiTietHoaDonNhap.Text = "Chi tiết hoá đơn bán";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(176, 173);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(235, 32);
            this.nudSoLuong.TabIndex = 127;
            this.nudSoLuong.ValueChanged += new System.EventHandler(this.nudSoLuong_ValueChanged);
            // 
            // cbbTruyen
            // 
            this.cbbTruyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTruyen.FormattingEnabled = true;
            this.cbbTruyen.Location = new System.Drawing.Point(176, 81);
            this.cbbTruyen.Name = "cbbTruyen";
            this.cbbTruyen.Size = new System.Drawing.Size(235, 32);
            this.cbbTruyen.TabIndex = 121;
            this.cbbTruyen.SelectedIndexChanged += new System.EventHandler(this.cbbTruyen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(93, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 123;
            this.label1.Text = "Truyện:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(62, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 24);
            this.label11.TabIndex = 121;
            this.label11.Text = "Thành tiền:";
            // 
            // tbThanhTien
            // 
            this.tbThanhTien.Enabled = false;
            this.tbThanhTien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.tbThanhTien.Location = new System.Drawing.Point(176, 221);
            this.tbThanhTien.Name = "tbThanhTien";
            this.tbThanhTien.Size = new System.Drawing.Size(235, 32);
            this.tbThanhTien.TabIndex = 122;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(14, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 24);
            this.label6.TabIndex = 121;
            this.label6.Text = "Mã hoá đơn bán:";
            // 
            // tbCTMaHoaDonBan
            // 
            this.tbCTMaHoaDonBan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.tbCTMaHoaDonBan.Location = new System.Drawing.Point(176, 37);
            this.tbCTMaHoaDonBan.Name = "tbCTMaHoaDonBan";
            this.tbCTMaHoaDonBan.Size = new System.Drawing.Size(235, 32);
            this.tbCTMaHoaDonBan.TabIndex = 122;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(76, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 24);
            this.label7.TabIndex = 124;
            this.label7.Text = "Số lượng:";
            // 
            // tbGiaBan
            // 
            this.tbGiaBan.Enabled = false;
            this.tbGiaBan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.tbGiaBan.Location = new System.Drawing.Point(176, 124);
            this.tbGiaBan.Name = "tbGiaBan";
            this.tbGiaBan.Size = new System.Drawing.Size(235, 32);
            this.tbGiaBan.TabIndex = 126;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(85, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 125;
            this.label8.Text = "Giá bán:";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTimKiem.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbTimKiem.Location = new System.Drawing.Point(661, 550);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(296, 32);
            this.tbTimKiem.TabIndex = 40;
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btXoa.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btXoa.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btXoa.Location = new System.Drawing.Point(353, 542);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(124, 47);
            this.btXoa.TabIndex = 39;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btTimKiem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btTimKiem.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btTimKiem.Location = new System.Drawing.Point(526, 541);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(124, 47);
            this.btTimKiem.TabIndex = 41;
            this.btTimKiem.Text = "Tìm kiếm ";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // dtgChiTietHoaDonBan
            // 
            this.dtgChiTietHoaDonBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgChiTietHoaDonBan.BackgroundColor = System.Drawing.Color.White;
            this.dtgChiTietHoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgChiTietHoaDonBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CTMaHoaDonBan,
            this.MaTruyen,
            this.SoLuongBan,
            this.GiaBan,
            this.ThanhTien});
            this.dtgChiTietHoaDonBan.Location = new System.Drawing.Point(521, 296);
            this.dtgChiTietHoaDonBan.Name = "dtgChiTietHoaDonBan";
            this.dtgChiTietHoaDonBan.RowHeadersWidth = 51;
            this.dtgChiTietHoaDonBan.RowTemplate.Height = 24;
            this.dtgChiTietHoaDonBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgChiTietHoaDonBan.Size = new System.Drawing.Size(436, 233);
            this.dtgChiTietHoaDonBan.TabIndex = 37;
            this.dtgChiTietHoaDonBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgChiTietHoaDonBan_CellClick);
            this.dtgChiTietHoaDonBan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgChiTietHoaDonBan_CellFormatting);
            // 
            // CTMaHoaDonBan
            // 
            this.CTMaHoaDonBan.DataPropertyName = "MaHoaDonBan";
            this.CTMaHoaDonBan.HeaderText = "Mã HĐB";
            this.CTMaHoaDonBan.MinimumWidth = 6;
            this.CTMaHoaDonBan.Name = "CTMaHoaDonBan";
            this.CTMaHoaDonBan.Width = 109;
            // 
            // MaTruyen
            // 
            this.MaTruyen.DataPropertyName = "TenTruyen";
            this.MaTruyen.HeaderText = "Truyện";
            this.MaTruyen.MinimumWidth = 6;
            this.MaTruyen.Name = "MaTruyen";
            this.MaTruyen.Width = 96;
            // 
            // SoLuongBan
            // 
            this.SoLuongBan.DataPropertyName = "SoLuongBan";
            this.SoLuongBan.HeaderText = "Số lượng";
            this.SoLuongBan.MinimumWidth = 6;
            this.SoLuongBan.Name = "SoLuongBan";
            this.SoLuongBan.Width = 115;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 106;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 131;
            // 
            // dtgHoaDonBan
            // 
            this.dtgHoaDonBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgHoaDonBan.BackgroundColor = System.Drawing.Color.White;
            this.dtgHoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHoaDonBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDonBan,
            this.NgayBan,
            this.TongTien,
            this.NhanVienBan,
            this.KhachHangThanhVien});
            this.dtgHoaDonBan.Location = new System.Drawing.Point(27, 296);
            this.dtgHoaDonBan.Name = "dtgHoaDonBan";
            this.dtgHoaDonBan.RowHeadersWidth = 51;
            this.dtgHoaDonBan.RowTemplate.Height = 24;
            this.dtgHoaDonBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHoaDonBan.Size = new System.Drawing.Size(445, 233);
            this.dtgHoaDonBan.TabIndex = 38;
            this.dtgHoaDonBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHoaDonBan_CellClick);
            this.dtgHoaDonBan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgHoaDonBan_CellFormatting);
            // 
            // MaHoaDonBan
            // 
            this.MaHoaDonBan.DataPropertyName = "MaHoaDonBan";
            this.MaHoaDonBan.HeaderText = "Mã HĐB";
            this.MaHoaDonBan.MinimumWidth = 6;
            this.MaHoaDonBan.Name = "MaHoaDonBan";
            this.MaHoaDonBan.Width = 109;
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày bán";
            this.NgayBan.MinimumWidth = 6;
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.Width = 121;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 119;
            // 
            // NhanVienBan
            // 
            this.NhanVienBan.DataPropertyName = "NhanVienBan";
            this.NhanVienBan.HeaderText = "Nhân viên bán";
            this.NhanVienBan.MinimumWidth = 6;
            this.NhanVienBan.Name = "NhanVienBan";
            this.NhanVienBan.Width = 163;
            // 
            // KhachHangThanhVien
            // 
            this.KhachHangThanhVien.DataPropertyName = "KhachHangThanhVien";
            this.KhachHangThanhVien.HeaderText = "Mã KHTV";
            this.KhachHangThanhVien.MinimumWidth = 6;
            this.KhachHangThanhVien.Name = "KhachHangThanhVien";
            this.KhachHangThanhVien.Width = 118;
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSua.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btSua.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btSua.Location = new System.Drawing.Point(189, 542);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(124, 47);
            this.btSua.TabIndex = 43;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Checked = true;
            this.dtpNgayBan.FillColor = System.Drawing.Color.White;
            this.dtpNgayBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayBan.Location = new System.Drawing.Point(183, 77);
            this.dtpNgayBan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(235, 36);
            this.dtpNgayBan.TabIndex = 122;
            this.dtpNgayBan.Value = new System.DateTime(2025, 4, 26, 23, 37, 49, 453);
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(993, 603);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoá đơn bán";
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbHoaDonNhap.ResumeLayout(false);
            this.gbHoaDonNhap.PerformLayout();
            this.gbChiTietHoaDonNhap.ResumeLayout(false);
            this.gbChiTietHoaDonNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietHoaDonBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDonBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btMoi;
        private System.Windows.Forms.GroupBox gbHoaDonNhap;
        private System.Windows.Forms.ComboBox cbbMaKHTV;
        private System.Windows.Forms.ComboBox cbbNhanVienBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaHoaDonBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbChiTietHoaDonNhap;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbThanhTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCTMaHoaDonBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGiaBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.DataGridView dtgChiTietHoaDonBan;
        private System.Windows.Forms.DataGridView dtgHoaDonBan;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.ComboBox cbbTruyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTMaHoaDonBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTruyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDonBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHangThanhVien;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayBan;
    }
}