namespace GUI_Graphical_User_Interface
{
    partial class frmKhachHangThanhVien
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
            this.dtGKhachHang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btGiaHan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbSoDienThoai = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbMaKHTV = new System.Windows.Forms.TextBox();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.btMoi = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.MaKHTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenKHTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSDTheThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpHSDTheTV = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGKhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtGKhachHang);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.tbTimKiem);
            this.splitContainer1.Panel2.Controls.Add(this.btMoi);
            this.splitContainer1.Panel2.Controls.Add(this.btXoa);
            this.splitContainer1.Panel2.Controls.Add(this.btSua);
            this.splitContainer1.Panel2.Controls.Add(this.btThem);
            this.splitContainer1.Panel2.Controls.Add(this.btTimKiem);
            this.splitContainer1.Size = new System.Drawing.Size(993, 603);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 4;
            // 
            // dtGKhachHang
            // 
            this.dtGKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dtGKhachHang.Name = "dtGKhachHang";
            this.dtGKhachHang.RowHeadersWidth = 51;
            this.dtGKhachHang.RowTemplate.Height = 24;
            this.dtGKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGKhachHang.Size = new System.Drawing.Size(993, 287);
            this.dtGKhachHang.TabIndex = 0;
            this.dtGKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGThongTinKhachHang_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpHSDTheTV);
            this.panel1.Controls.Add(this.btGiaHan);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbDiaChi);
            this.panel1.Controls.Add(this.tbSoDienThoai);
            this.panel1.Controls.Add(this.tbHoTen);
            this.panel1.Controls.Add(this.tbMaKHTV);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 181);
            this.panel1.TabIndex = 32;
            // 
            // btGiaHan
            // 
            this.btGiaHan.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btGiaHan.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btGiaHan.Location = new System.Drawing.Point(740, 109);
            this.btGiaHan.Name = "btGiaHan";
            this.btGiaHan.Size = new System.Drawing.Size(86, 35);
            this.btGiaHan.TabIndex = 151;
            this.btGiaHan.Text = "Gia hạn";
            this.btGiaHan.UseVisualStyleBackColor = false;
            this.btGiaHan.Click += new System.EventHandler(this.btGiaHan_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(461, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 24);
            this.label6.TabIndex = 145;
            this.label6.Text = "HSD thẻ thành viên:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(567, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 148;
            this.label5.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(30, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 147;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(85, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 149;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(64, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 146;
            this.label1.Text = "Mã KHTV:";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDiaChi.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbDiaChi.Location = new System.Drawing.Point(658, 26);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(239, 32);
            this.tbDiaChi.TabIndex = 144;
            // 
            // tbSoDienThoai
            // 
            this.tbSoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSoDienThoai.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbSoDienThoai.Location = new System.Drawing.Point(173, 112);
            this.tbSoDienThoai.Name = "tbSoDienThoai";
            this.tbSoDienThoai.Size = new System.Drawing.Size(239, 32);
            this.tbSoDienThoai.TabIndex = 143;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHoTen.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbHoTen.Location = new System.Drawing.Point(173, 68);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(239, 32);
            this.tbHoTen.TabIndex = 142;
            // 
            // tbMaKHTV
            // 
            this.tbMaKHTV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMaKHTV.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbMaKHTV.Location = new System.Drawing.Point(173, 28);
            this.tbMaKHTV.Name = "tbMaKHTV";
            this.tbMaKHTV.Size = new System.Drawing.Size(239, 32);
            this.tbMaKHTV.TabIndex = 141;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTimKiem.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbTimKiem.Location = new System.Drawing.Point(744, 237);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(238, 32);
            this.tbTimKiem.TabIndex = 30;
            // 
            // btMoi
            // 
            this.btMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btMoi.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btMoi.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btMoi.Location = new System.Drawing.Point(18, 228);
            this.btMoi.Name = "btMoi";
            this.btMoi.Size = new System.Drawing.Size(119, 47);
            this.btMoi.TabIndex = 26;
            this.btMoi.Text = "Mới";
            this.btMoi.UseVisualStyleBackColor = false;
            this.btMoi.Click += new System.EventHandler(this.btMoi_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btXoa.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btXoa.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btXoa.Location = new System.Drawing.Point(458, 228);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(119, 47);
            this.btXoa.TabIndex = 29;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSua.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btSua.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btSua.Location = new System.Drawing.Point(309, 228);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(119, 47);
            this.btSua.TabIndex = 28;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btThem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btThem.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btThem.Location = new System.Drawing.Point(163, 228);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(119, 47);
            this.btThem.TabIndex = 27;
            this.btThem.Text = "Thêm ";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btTimKiem
            // 
            this.btTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btTimKiem.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btTimKiem.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btTimKiem.Location = new System.Drawing.Point(613, 228);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(119, 47);
            this.btTimKiem.TabIndex = 31;
            this.btTimKiem.Text = "Tìm kiếm ";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // MaKHTV
            // 
            this.MaKHTV.DataPropertyName = "MaKHTV";
            this.MaKHTV.HeaderText = "Mã KHTV";
            this.MaKHTV.MinimumWidth = 6;
            this.MaKHTV.Name = "MaKHTV";
            this.MaKHTV.Width = 125;
            // 
            // HoTenKHTV
            // 
            this.HoTenKHTV.DataPropertyName = "HoTenKHTV";
            this.HoTenKHTV.HeaderText = "Họ tên";
            this.HoTenKHTV.MinimumWidth = 6;
            this.HoTenKHTV.Name = "HoTenKHTV";
            this.HoTenKHTV.Width = 125;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // HSDTheThanhVien
            // 
            this.HSDTheThanhVien.DataPropertyName = "HSDTheThanhVien";
            this.HSDTheThanhVien.HeaderText = "HSD thẻ thành viên";
            this.HSDTheThanhVien.MinimumWidth = 6;
            this.HSDTheThanhVien.Name = "HSDTheThanhVien";
            this.HSDTheThanhVien.Width = 125;
            // 
            // dtpHSDTheTV
            // 
            this.dtpHSDTheTV.Checked = true;
            this.dtpHSDTheTV.FillColor = System.Drawing.Color.White;
            this.dtpHSDTheTV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpHSDTheTV.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpHSDTheTV.Location = new System.Drawing.Point(658, 68);
            this.dtpHSDTheTV.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHSDTheTV.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHSDTheTV.Name = "dtpHSDTheTV";
            this.dtpHSDTheTV.Size = new System.Drawing.Size(239, 36);
            this.dtpHSDTheTV.TabIndex = 152;
            this.dtpHSDTheTV.Value = new System.DateTime(2025, 4, 26, 23, 34, 36, 3);
            // 
            // frmKhachHangThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 603);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmKhachHangThanhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng thành viên";
            this.Load += new System.EventHandler(this.frmKhachHangThanhVien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGKhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKHTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenKHTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSDTheThanhVien;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button btMoi;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbSoDienThoai;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbMaKHTV;
        private System.Windows.Forms.Button btGiaHan;
        private System.Windows.Forms.DataGridView dtGKhachHang;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHSDTheTV;
    }
}