namespace GUI_Graphical_User_Interface
{
    partial class frmDangNhap
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btThoat = new Guna.UI2.WinForms.Guna2Button();
            this.btDangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.tbMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btThoat);
            this.splitContainer1.Panel2.Controls.Add(this.btDangNhap);
            this.splitContainer1.Panel2.Controls.Add(this.tbMatKhau);
            this.splitContainer1.Panel2.Controls.Add(this.tbTaiKhoan);
            this.splitContainer1.Panel2.Controls.Add(this.labelWelcome);
            this.splitContainer1.Size = new System.Drawing.Size(484, 546);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI_Graphical_User_Interface.Properties.Resources.FormDangNhap;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btThoat
            // 
            this.btThoat.AutoRoundedCorners = true;
            this.btThoat.BorderRadius = 21;
            this.btThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btThoat.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btThoat.ForeColor = System.Drawing.Color.White;
            this.btThoat.IndicateFocus = true;
            this.btThoat.Location = new System.Drawing.Point(259, 229);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(139, 45);
            this.btThoat.TabIndex = 26;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btDangNhap
            // 
            this.btDangNhap.AutoRoundedCorners = true;
            this.btDangNhap.BorderRadius = 21;
            this.btDangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDangNhap.FocusedColor = System.Drawing.Color.White;
            this.btDangNhap.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btDangNhap.ForeColor = System.Drawing.Color.White;
            this.btDangNhap.IndicateFocus = true;
            this.btDangNhap.Location = new System.Drawing.Point(69, 229);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(139, 45);
            this.btDangNhap.TabIndex = 25;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.AutoRoundedCorners = true;
            this.tbMatKhau.BorderRadius = 18;
            this.tbMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMatKhau.DefaultText = "";
            this.tbMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMatKhau.IconLeft = global::GUI_Graphical_User_Interface.Properties.Resources.iconMatKhau;
            this.tbMatKhau.Location = new System.Drawing.Point(112, 155);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '*';
            this.tbMatKhau.PlaceholderText = "Nhập mật khẩu";
            this.tbMatKhau.SelectedText = "";
            this.tbMatKhau.Size = new System.Drawing.Size(258, 39);
            this.tbMatKhau.TabIndex = 24;
            this.tbMatKhau.TextChanged += new System.EventHandler(this.tbMatKhau_TextChanged);
            this.tbMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.tbMatKhau_Validating);
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.AutoRoundedCorners = true;
            this.tbTaiKhoan.BorderRadius = 18;
            this.tbTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTaiKhoan.DefaultText = "";
            this.tbTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTaiKhoan.IconLeft = global::GUI_Graphical_User_Interface.Properties.Resources.iconTaiKhoan;
            this.tbTaiKhoan.Location = new System.Drawing.Point(112, 87);
            this.tbTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTaiKhoan.MaxLength = 5;
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.PasswordChar = '\0';
            this.tbTaiKhoan.PlaceholderText = "Nhập tài khoản";
            this.tbTaiKhoan.SelectedText = "";
            this.tbTaiKhoan.Size = new System.Drawing.Size(258, 39);
            this.tbTaiKhoan.TabIndex = 23;
            this.tbTaiKhoan.TextChanged += new System.EventHandler(this.tbTaiKhoan_TextChanged);
            this.tbTaiKhoan.Validating += new System.ComponentModel.CancelEventHandler(this.tbTaiKhoan_Validating);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Jokerman", 16F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.Location = new System.Drawing.Point(186, 20);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(97, 39);
            this.labelWelcome.TabIndex = 22;
            this.labelWelcome.Text = "Login";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 546);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Guna.UI2.WinForms.Guna2Button btThoat;
        private Guna.UI2.WinForms.Guna2Button btDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox tbMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox tbTaiKhoan;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

