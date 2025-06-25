namespace GUI_Graphical_User_Interface
{
    partial class frmNhapHang
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
            this.btMoi = new System.Windows.Forms.Button();
            this.btThemHoaDon = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbNVNhap = new System.Windows.Forms.ComboBox();
            this.tbMaHDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flpTruyen = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgTruyenNhap = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTruyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgayNhap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTruyenNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btMoi
            // 
            this.btMoi.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btMoi.Location = new System.Drawing.Point(77, 255);
            this.btMoi.Name = "btMoi";
            this.btMoi.Size = new System.Drawing.Size(117, 37);
            this.btMoi.TabIndex = 124;
            this.btMoi.Text = "Làm mới";
            this.btMoi.UseVisualStyleBackColor = false;
            this.btMoi.Click += new System.EventHandler(this.btMoi_Click);
            // 
            // btThemHoaDon
            // 
            this.btThemHoaDon.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btThemHoaDon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThemHoaDon.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btThemHoaDon.Location = new System.Drawing.Point(13, 519);
            this.btThemHoaDon.Name = "btThemHoaDon";
            this.btThemHoaDon.Size = new System.Drawing.Size(255, 56);
            this.btThemHoaDon.TabIndex = 115;
            this.btThemHoaDon.Text = "Thêm hoá đơn";
            this.btThemHoaDon.UseVisualStyleBackColor = false;
            this.btThemHoaDon.Click += new System.EventHandler(this.btThemHoaDon_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 118;
            this.label9.Text = "VNĐ";
            // 
            // lbTongTien
            // 
            this.lbTongTien.Location = new System.Drawing.Point(13, 476);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTongTien.Size = new System.Drawing.Size(197, 25);
            this.lbTongTien.TabIndex = 117;
            this.lbTongTien.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(8, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 28);
            this.label4.TabIndex = 116;
            this.label4.Text = "Tổng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 104;
            this.label2.Text = "Mã hoá đơn nhập:";
            // 
            // cbbNVNhap
            // 
            this.cbbNVNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNVNhap.FormattingEnabled = true;
            this.cbbNVNhap.Location = new System.Drawing.Point(8, 204);
            this.cbbNVNhap.Name = "cbbNVNhap";
            this.cbbNVNhap.Size = new System.Drawing.Size(261, 32);
            this.cbbNVNhap.TabIndex = 123;
            // 
            // tbMaHDN
            // 
            this.tbMaHDN.Enabled = false;
            this.tbMaHDN.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tbMaHDN.Location = new System.Drawing.Point(9, 42);
            this.tbMaHDN.Name = "tbMaHDN";
            this.tbMaHDN.Size = new System.Drawing.Size(261, 32);
            this.tbMaHDN.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(14, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 24);
            this.label3.TabIndex = 109;
            this.label3.Text = "Nhân viên nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(15, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 107;
            this.label5.Text = "Ngày nhập:";
            // 
            // flpTruyen
            // 
            this.flpTruyen.AutoScroll = true;
            this.flpTruyen.BackColor = System.Drawing.Color.FloralWhite;
            this.flpTruyen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTruyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTruyen.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.flpTruyen.Location = new System.Drawing.Point(0, 0);
            this.flpTruyen.Name = "flpTruyen";
            this.flpTruyen.Size = new System.Drawing.Size(737, 350);
            this.flpTruyen.TabIndex = 107;
            // 
            // dtgTruyenNhap
            // 
            this.dtgTruyenNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgTruyenNhap.BackgroundColor = System.Drawing.Color.White;
            this.dtgTruyenNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTruyenNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.MaTruyen,
            this.SoLuong,
            this.Gia,
            this.ThanhTien});
            this.dtgTruyenNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgTruyenNhap.Location = new System.Drawing.Point(0, 0);
            this.dtgTruyenNhap.Name = "dtgTruyenNhap";
            this.dtgTruyenNhap.RowHeadersWidth = 51;
            this.dtgTruyenNhap.RowTemplate.Height = 24;
            this.dtgTruyenNhap.Size = new System.Drawing.Size(737, 249);
            this.dtgTruyenNhap.TabIndex = 0;
            this.dtgTruyenNhap.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgTruyenNhap_CellFormatting);
            this.dtgTruyenNhap.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgTruyenNhap_RowsAdded);
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHoaDon";
            this.MaHoaDon.HeaderText = "Mã HĐN";
            this.MaHoaDon.MinimumWidth = 6;
            this.MaHoaDon.Name = "MaHoaDon";
            // 
            // MaTruyen
            // 
            this.MaTruyen.DataPropertyName = "MaTruyen";
            this.MaTruyen.HeaderText = "Mã Truyện";
            this.MaTruyen.MinimumWidth = 6;
            this.MaTruyen.Name = "MaTruyen";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng nhập";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá nhập";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.FloralWhite;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.splitContainer2.Panel1.CausesValidation = false;
            this.splitContainer2.Panel1.Controls.Add(this.dtgTruyenNhap);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.splitContainer2.Panel2.Controls.Add(this.flpTruyen);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(737, 603);
            this.splitContainer2.SplitterDistance = 249;
            this.splitContainer2.SplitterIncrement = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FloralWhite;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FloralWhite;
            this.splitContainer1.Panel2.Controls.Add(this.dtpNgayNhap);
            this.splitContainer1.Panel2.Controls.Add(this.btMoi);
            this.splitContainer1.Panel2.Controls.Add(this.btThemHoaDon);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.lbTongTien);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.cbbNVNhap);
            this.splitContainer1.Panel2.Controls.Add(this.tbMaHDN);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(1022, 603);
            this.splitContainer1.SplitterDistance = 737;
            this.splitContainer1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(737, 603);
            this.panel1.TabIndex = 0;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Checked = true;
            this.dtpNgayNhap.FillColor = System.Drawing.Color.White;
            this.dtpNgayNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayNhap.Location = new System.Drawing.Point(19, 122);
            this.dtpNgayNhap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayNhap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(245, 36);
            this.dtpNgayNhap.TabIndex = 125;
            this.dtpNgayNhap.Value = new System.DateTime(2025, 4, 26, 23, 41, 52, 894);
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1022, 603);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTruyenNhap)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMoi;
        private System.Windows.Forms.Button btThemHoaDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbNVNhap;
        private System.Windows.Forms.TextBox tbMaHDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flpTruyen;
        private System.Windows.Forms.DataGridView dtgTruyenNhap;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTruyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayNhap;
    }
}