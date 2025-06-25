namespace GUI_Graphical_User_Interface
{
    partial class frmHoaDonNhap
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
            this.btSua = new System.Windows.Forms.Button();
            this.btMoi = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.dtgChiTietHDN = new System.Windows.Forms.DataGridView();
            this.CTMaHoaDonNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTruyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbChiTietHoaDonNhap = new System.Windows.Forms.GroupBox();
            this.cbbTruyen = new System.Windows.Forms.ComboBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbThanhTien = new System.Windows.Forms.TextBox();
            this.tbCTMaHoaDonNhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbGiaNhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.MaHoaDonNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbHoaDonNhap = new System.Windows.Forms.GroupBox();
            this.cbbNhanVienNhap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaHoaDonNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietHDN)).BeginInit();
            this.gbChiTietHoaDonNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDonNhap)).BeginInit();
            this.gbHoaDonNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btMoi);
            this.panel1.Controls.Add(this.tbTimKiem);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btTimKiem);
            this.panel1.Controls.Add(this.dtgChiTietHDN);
            this.panel1.Controls.Add(this.gbChiTietHoaDonNhap);
            this.panel1.Controls.Add(this.dtgHoaDonNhap);
            this.panel1.Controls.Add(this.gbHoaDonNhap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 603);
            this.panel1.TabIndex = 0;
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSua.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btSua.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btSua.Location = new System.Drawing.Point(189, 542);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(124, 47);
            this.btSua.TabIndex = 25;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btMoi
            // 
            this.btMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btMoi.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btMoi.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btMoi.Location = new System.Drawing.Point(27, 542);
            this.btMoi.Name = "btMoi";
            this.btMoi.Size = new System.Drawing.Size(124, 47);
            this.btMoi.TabIndex = 24;
            this.btMoi.Text = "Mới";
            this.btMoi.UseVisualStyleBackColor = false;
            this.btMoi.Click += new System.EventHandler(this.btMoi_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTimKiem.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbTimKiem.Location = new System.Drawing.Point(653, 549);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(313, 32);
            this.tbTimKiem.TabIndex = 22;
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btXoa.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btXoa.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btXoa.Location = new System.Drawing.Point(353, 542);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(124, 47);
            this.btXoa.TabIndex = 21;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btTimKiem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btTimKiem.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btTimKiem.Location = new System.Drawing.Point(521, 541);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(124, 47);
            this.btTimKiem.TabIndex = 23;
            this.btTimKiem.Text = "Tìm kiếm ";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // dtgChiTietHDN
            // 
            this.dtgChiTietHDN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgChiTietHDN.BackgroundColor = System.Drawing.Color.White;
            this.dtgChiTietHDN.ColumnHeadersHeight = 32;
            this.dtgChiTietHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CTMaHoaDonNhap,
            this.TenTruyen,
            this.SoLuongNhap,
            this.GiaNhap,
            this.ThanhTien});
            this.dtgChiTietHDN.Location = new System.Drawing.Point(521, 266);
            this.dtgChiTietHDN.Name = "dtgChiTietHDN";
            this.dtgChiTietHDN.RowHeadersWidth = 51;
            this.dtgChiTietHDN.RowTemplate.Height = 24;
            this.dtgChiTietHDN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgChiTietHDN.Size = new System.Drawing.Size(445, 263);
            this.dtgChiTietHDN.TabIndex = 19;
            this.dtgChiTietHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgChiTietHoaDonNhap_CellClick);
            this.dtgChiTietHDN.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgChiTietHDN_CellFormatting);
            // 
            // CTMaHoaDonNhap
            // 
            this.CTMaHoaDonNhap.DataPropertyName = "MaHoaDonNhap";
            this.CTMaHoaDonNhap.HeaderText = "Mã HĐN";
            this.CTMaHoaDonNhap.MinimumWidth = 6;
            this.CTMaHoaDonNhap.Name = "CTMaHoaDonNhap";
            this.CTMaHoaDonNhap.Width = 111;
            // 
            // TenTruyen
            // 
            this.TenTruyen.DataPropertyName = "TenTruyen";
            this.TenTruyen.HeaderText = "Tên truyện";
            this.TenTruyen.MinimumWidth = 6;
            this.TenTruyen.Name = "TenTruyen";
            this.TenTruyen.Width = 128;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "Số lượng";
            this.SoLuongNhap.MinimumWidth = 6;
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.Width = 115;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá nhập";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Width = 117;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 131;
            // 
            // gbChiTietHoaDonNhap
            // 
            this.gbChiTietHoaDonNhap.Controls.Add(this.cbbTruyen);
            this.gbChiTietHoaDonNhap.Controls.Add(this.nudSoLuong);
            this.gbChiTietHoaDonNhap.Controls.Add(this.label1);
            this.gbChiTietHoaDonNhap.Controls.Add(this.label9);
            this.gbChiTietHoaDonNhap.Controls.Add(this.label6);
            this.gbChiTietHoaDonNhap.Controls.Add(this.tbThanhTien);
            this.gbChiTietHoaDonNhap.Controls.Add(this.tbCTMaHoaDonNhap);
            this.gbChiTietHoaDonNhap.Controls.Add(this.label7);
            this.gbChiTietHoaDonNhap.Controls.Add(this.tbGiaNhap);
            this.gbChiTietHoaDonNhap.Controls.Add(this.label8);
            this.gbChiTietHoaDonNhap.Location = new System.Drawing.Point(521, 14);
            this.gbChiTietHoaDonNhap.Margin = new System.Windows.Forms.Padding(4);
            this.gbChiTietHoaDonNhap.Name = "gbChiTietHoaDonNhap";
            this.gbChiTietHoaDonNhap.Padding = new System.Windows.Forms.Padding(4);
            this.gbChiTietHoaDonNhap.Size = new System.Drawing.Size(445, 234);
            this.gbChiTietHoaDonNhap.TabIndex = 17;
            this.gbChiTietHoaDonNhap.TabStop = false;
            this.gbChiTietHoaDonNhap.Text = "Chi tiết hoá đơn nhập";
            // 
            // cbbTruyen
            // 
            this.cbbTruyen.FormattingEnabled = true;
            this.cbbTruyen.Location = new System.Drawing.Point(114, 79);
            this.cbbTruyen.Name = "cbbTruyen";
            this.cbbTruyen.Size = new System.Drawing.Size(305, 32);
            this.cbbTruyen.TabIndex = 122;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(339, 124);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(80, 32);
            this.nudSoLuong.TabIndex = 127;
            this.nudSoLuong.ValueChanged += new System.EventHandler(this.nudSoLuong_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(38, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 123;
            this.label1.Text = "Truyện:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(7, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 121;
            this.label9.Text = "Thành tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(7, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 24);
            this.label6.TabIndex = 121;
            this.label6.Text = "Mã hoá đơn nhập:";
            // 
            // tbThanhTien
            // 
            this.tbThanhTien.Enabled = false;
            this.tbThanhTien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.tbThanhTien.Location = new System.Drawing.Point(114, 171);
            this.tbThanhTien.Name = "tbThanhTien";
            this.tbThanhTien.Size = new System.Drawing.Size(307, 32);
            this.tbThanhTien.TabIndex = 122;
            // 
            // tbCTMaHoaDonNhap
            // 
            this.tbCTMaHoaDonNhap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.tbCTMaHoaDonNhap.Location = new System.Drawing.Point(172, 37);
            this.tbCTMaHoaDonNhap.Name = "tbCTMaHoaDonNhap";
            this.tbCTMaHoaDonNhap.Size = new System.Drawing.Size(249, 32);
            this.tbCTMaHoaDonNhap.TabIndex = 122;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(301, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 24);
            this.label7.TabIndex = 124;
            this.label7.Text = "SL:";
            // 
            // tbGiaNhap
            // 
            this.tbGiaNhap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.tbGiaNhap.Location = new System.Drawing.Point(114, 124);
            this.tbGiaNhap.Name = "tbGiaNhap";
            this.tbGiaNhap.Size = new System.Drawing.Size(177, 32);
            this.tbGiaNhap.TabIndex = 126;
            this.tbGiaNhap.TextChanged += new System.EventHandler(this.tbGiaNhap_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(20, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 125;
            this.label8.Text = "Giá nhập:";
            // 
            // dtgHoaDonNhap
            // 
            this.dtgHoaDonNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgHoaDonNhap.BackgroundColor = System.Drawing.Color.White;
            this.dtgHoaDonNhap.ColumnHeadersHeight = 32;
            this.dtgHoaDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDonNhap,
            this.NgayNhap,
            this.TongTien,
            this.NhanVienNhap});
            this.dtgHoaDonNhap.Location = new System.Drawing.Point(27, 266);
            this.dtgHoaDonNhap.Name = "dtgHoaDonNhap";
            this.dtgHoaDonNhap.RowHeadersWidth = 51;
            this.dtgHoaDonNhap.RowTemplate.Height = 24;
            this.dtgHoaDonNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHoaDonNhap.Size = new System.Drawing.Size(445, 263);
            this.dtgHoaDonNhap.TabIndex = 20;
            this.dtgHoaDonNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHoaDonNhap_CellClick);
            this.dtgHoaDonNhap.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgHoaDonNhap_CellFormatting);
            // 
            // MaHoaDonNhap
            // 
            this.MaHoaDonNhap.DataPropertyName = "MaHoaDonNhap";
            this.MaHoaDonNhap.HeaderText = "Mã HĐN";
            this.MaHoaDonNhap.MinimumWidth = 6;
            this.MaHoaDonNhap.Name = "MaHoaDonNhap";
            this.MaHoaDonNhap.Width = 111;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Width = 132;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 119;
            // 
            // NhanVienNhap
            // 
            this.NhanVienNhap.DataPropertyName = "NhanVienNhap";
            this.NhanVienNhap.HeaderText = "Nhân viên nhập";
            this.NhanVienNhap.MinimumWidth = 6;
            this.NhanVienNhap.Name = "NhanVienNhap";
            this.NhanVienNhap.Width = 174;
            // 
            // gbHoaDonNhap
            // 
            this.gbHoaDonNhap.Controls.Add(this.dtpNgayNhap);
            this.gbHoaDonNhap.Controls.Add(this.cbbNhanVienNhap);
            this.gbHoaDonNhap.Controls.Add(this.label5);
            this.gbHoaDonNhap.Controls.Add(this.label2);
            this.gbHoaDonNhap.Controls.Add(this.tbMaHoaDonNhap);
            this.gbHoaDonNhap.Controls.Add(this.label4);
            this.gbHoaDonNhap.Controls.Add(this.tbTongTien);
            this.gbHoaDonNhap.Controls.Add(this.label3);
            this.gbHoaDonNhap.Location = new System.Drawing.Point(27, 14);
            this.gbHoaDonNhap.Margin = new System.Windows.Forms.Padding(4);
            this.gbHoaDonNhap.Name = "gbHoaDonNhap";
            this.gbHoaDonNhap.Padding = new System.Windows.Forms.Padding(4);
            this.gbHoaDonNhap.Size = new System.Drawing.Size(445, 234);
            this.gbHoaDonNhap.TabIndex = 18;
            this.gbHoaDonNhap.TabStop = false;
            this.gbHoaDonNhap.Text = "Hoá đơn nhập";
            // 
            // cbbNhanVienNhap
            // 
            this.cbbNhanVienNhap.FormattingEnabled = true;
            this.cbbNhanVienNhap.Location = new System.Drawing.Point(183, 171);
            this.cbbNhanVienNhap.Name = "cbbNhanVienNhap";
            this.cbbNhanVienNhap.Size = new System.Drawing.Size(235, 32);
            this.cbbNhanVienNhap.TabIndex = 122;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(64, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 115;
            this.label5.Text = "Ngày nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 113;
            this.label2.Text = "Mã hoá đơn nhập:";
            // 
            // tbMaHoaDonNhap
            // 
            this.tbMaHoaDonNhap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.tbMaHoaDonNhap.Location = new System.Drawing.Point(183, 37);
            this.tbMaHoaDonNhap.Name = "tbMaHoaDonNhap";
            this.tbMaHoaDonNhap.Size = new System.Drawing.Size(235, 32);
            this.tbMaHoaDonNhap.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(77, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 116;
            this.label4.Text = "Tổng tiền:";
            // 
            // tbTongTien
            // 
            this.tbTongTien.Enabled = false;
            this.tbTongTien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.tbTongTien.Location = new System.Drawing.Point(183, 124);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(235, 32);
            this.tbTongTien.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(24, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 117;
            this.label3.Text = "Nhân viên nhập:";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Checked = true;
            this.dtpNgayNhap.FillColor = System.Drawing.Color.White;
            this.dtpNgayNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayNhap.Location = new System.Drawing.Point(183, 79);
            this.dtpNgayNhap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayNhap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(235, 36);
            this.dtpNgayNhap.TabIndex = 123;
            this.dtpNgayNhap.Value = new System.DateTime(2025, 4, 26, 23, 38, 17, 165);
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(993, 603);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoá đơn nhập";
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgChiTietHDN)).EndInit();
            this.gbChiTietHoaDonNhap.ResumeLayout(false);
            this.gbChiTietHoaDonNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDonNhap)).EndInit();
            this.gbHoaDonNhap.ResumeLayout(false);
            this.gbHoaDonNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btMoi;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.DataGridView dtgChiTietHDN;
        private System.Windows.Forms.GroupBox gbChiTietHoaDonNhap;
        private System.Windows.Forms.ComboBox cbbTruyen;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbThanhTien;
        private System.Windows.Forms.TextBox tbCTMaHoaDonNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbGiaNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgHoaDonNhap;
        private System.Windows.Forms.GroupBox gbHoaDonNhap;
        private System.Windows.Forms.ComboBox cbbNhanVienNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaHoaDonNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTMaHoaDonNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTruyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDonNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienNhap;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayNhap;
    }
}