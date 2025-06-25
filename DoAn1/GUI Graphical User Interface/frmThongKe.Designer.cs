namespace GUI_Graphical_User_Interface
{
    partial class frmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.TabControlThongKe = new System.Windows.Forms.TabControl();
            this.tabPageTruyen = new System.Windows.Forms.TabPage();
            this.rvTop5Truyen = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPageNhanVien = new System.Windows.Forms.TabPage();
            this.rVTop5NV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPageKhachHang = new System.Windows.Forms.TabPage();
            this.rVTop5KH = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TabPageDoanhThu = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpNgayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpNgayKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TabControlThongKe.SuspendLayout();
            this.tabPageTruyen.SuspendLayout();
            this.tabPageNhanVien.SuspendLayout();
            this.tabPageKhachHang.SuspendLayout();
            this.TabPageDoanhThu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlThongKe
            // 
            this.TabControlThongKe.Controls.Add(this.tabPageTruyen);
            this.TabControlThongKe.Controls.Add(this.tabPageNhanVien);
            this.TabControlThongKe.Controls.Add(this.tabPageKhachHang);
            this.TabControlThongKe.Controls.Add(this.TabPageDoanhThu);
            this.TabControlThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlThongKe.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TabControlThongKe.Location = new System.Drawing.Point(0, 0);
            this.TabControlThongKe.Name = "TabControlThongKe";
            this.TabControlThongKe.SelectedIndex = 0;
            this.TabControlThongKe.Size = new System.Drawing.Size(993, 603);
            this.TabControlThongKe.TabIndex = 0;
            // 
            // tabPageTruyen
            // 
            this.tabPageTruyen.Controls.Add(this.rvTop5Truyen);
            this.tabPageTruyen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPageTruyen.Location = new System.Drawing.Point(4, 27);
            this.tabPageTruyen.Name = "tabPageTruyen";
            this.tabPageTruyen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTruyen.Size = new System.Drawing.Size(985, 572);
            this.tabPageTruyen.TabIndex = 0;
            this.tabPageTruyen.Text = "Top 5 truyện";
            this.tabPageTruyen.UseVisualStyleBackColor = true;
            // 
            // rvTop5Truyen
            // 
            this.rvTop5Truyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvTop5Truyen.LocalReport.ReportEmbeddedResource = "GUI_Graphical_User_Interface.rpTop5Truyen.rdlc";
            this.rvTop5Truyen.Location = new System.Drawing.Point(3, 3);
            this.rvTop5Truyen.Name = "rvTop5Truyen";
            this.rvTop5Truyen.ServerReport.BearerToken = null;
            this.rvTop5Truyen.Size = new System.Drawing.Size(979, 566);
            this.rvTop5Truyen.TabIndex = 3;
            // 
            // tabPageNhanVien
            // 
            this.tabPageNhanVien.Controls.Add(this.rVTop5NV);
            this.tabPageNhanVien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPageNhanVien.Location = new System.Drawing.Point(4, 27);
            this.tabPageNhanVien.Name = "tabPageNhanVien";
            this.tabPageNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNhanVien.Size = new System.Drawing.Size(985, 572);
            this.tabPageNhanVien.TabIndex = 1;
            this.tabPageNhanVien.Text = "Top 5 nhân viên";
            this.tabPageNhanVien.UseVisualStyleBackColor = true;
            // 
            // rVTop5NV
            // 
            this.rVTop5NV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rVTop5NV.LocalReport.ReportEmbeddedResource = "GUI_Graphical_User_Interface.rpTop5NV.rdlc";
            this.rVTop5NV.Location = new System.Drawing.Point(3, 3);
            this.rVTop5NV.Name = "rVTop5NV";
            this.rVTop5NV.ServerReport.BearerToken = null;
            this.rVTop5NV.Size = new System.Drawing.Size(979, 566);
            this.rVTop5NV.TabIndex = 0;
            // 
            // tabPageKhachHang
            // 
            this.tabPageKhachHang.Controls.Add(this.rVTop5KH);
            this.tabPageKhachHang.Location = new System.Drawing.Point(4, 27);
            this.tabPageKhachHang.Name = "tabPageKhachHang";
            this.tabPageKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKhachHang.Size = new System.Drawing.Size(985, 572);
            this.tabPageKhachHang.TabIndex = 2;
            this.tabPageKhachHang.Text = "Top 5 khách hàng";
            this.tabPageKhachHang.UseVisualStyleBackColor = true;
            // 
            // rVTop5KH
            // 
            this.rVTop5KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rVTop5KH.Location = new System.Drawing.Point(3, 3);
            this.rVTop5KH.Name = "rVTop5KH";
            this.rVTop5KH.ServerReport.BearerToken = null;
            this.rVTop5KH.Size = new System.Drawing.Size(979, 566);
            this.rVTop5KH.TabIndex = 0;
            // 
            // TabPageDoanhThu
            // 
            this.TabPageDoanhThu.BackColor = System.Drawing.Color.White;
            this.TabPageDoanhThu.Controls.Add(this.panel1);
            this.TabPageDoanhThu.Controls.Add(this.chartDoanhThu);
            this.TabPageDoanhThu.Location = new System.Drawing.Point(4, 27);
            this.TabPageDoanhThu.Name = "TabPageDoanhThu";
            this.TabPageDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDoanhThu.Size = new System.Drawing.Size(985, 572);
            this.TabPageDoanhThu.TabIndex = 3;
            this.TabPageDoanhThu.Text = "Doanh thu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNgayKetThuc);
            this.panel1.Controls.Add(this.dtpNgayBatDau);
            this.panel1.Controls.Add(this.btThongKe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 144);
            this.panel1.TabIndex = 1;
            // 
            // btThongKe
            // 
            this.btThongKe.BorderRadius = 15;
            this.btThongKe.BorderThickness = 1;
            this.btThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btThongKe.FillColor = System.Drawing.Color.White;
            this.btThongKe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThongKe.ForeColor = System.Drawing.Color.Black;
            this.btThongKe.Location = new System.Drawing.Point(418, 83);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(162, 42);
            this.btThongKe.TabIndex = 8;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(502, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày kết thúc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(130, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ngày bắt đầu:";
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(3, 156);
            this.chartDoanhThu.Name = "chartDoanhThu";
            this.chartDoanhThu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(974, 413);
            this.chartDoanhThu.TabIndex = 0;
            this.chartDoanhThu.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.Name = "Title1";
            title1.Text = "Doanh thu";
            this.chartDoanhThu.Titles.Add(title1);
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Checked = true;
            this.dtpNgayBatDau.FillColor = System.Drawing.Color.White;
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(261, 20);
            this.dtpNgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(217, 36);
            this.dtpNgayBatDau.TabIndex = 9;
            this.dtpNgayBatDau.Value = new System.DateTime(2025, 4, 26, 23, 40, 5, 495);
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Checked = true;
            this.dtpNgayKetThuc.FillColor = System.Drawing.Color.White;
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(635, 20);
            this.dtpNgayKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(217, 36);
            this.dtpNgayKetThuc.TabIndex = 10;
            this.dtpNgayKetThuc.Value = new System.DateTime(2025, 4, 26, 23, 40, 5, 495);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 603);
            this.Controls.Add(this.TabControlThongKe);
            this.Name = "frmThongKe";
            this.Text = "frmBaoCao";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.TabControlThongKe.ResumeLayout(false);
            this.tabPageTruyen.ResumeLayout(false);
            this.tabPageNhanVien.ResumeLayout(false);
            this.tabPageKhachHang.ResumeLayout(false);
            this.TabPageDoanhThu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlThongKe;
        private System.Windows.Forms.TabPage tabPageTruyen;
        private Microsoft.Reporting.WinForms.ReportViewer rvTop5Truyen;
        private System.Windows.Forms.TabPage tabPageNhanVien;
        private System.Windows.Forms.TabPage tabPageKhachHang;
        private System.Windows.Forms.TabPage TabPageDoanhThu;
        private Microsoft.Reporting.WinForms.ReportViewer rVTop5NV;
        private Microsoft.Reporting.WinForms.ReportViewer rVTop5KH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btThongKe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayKetThuc;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayBatDau;
    }
}