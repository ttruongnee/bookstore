namespace GUI_Graphical_User_Interface
{
    partial class truyennhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMaTruyen = new System.Windows.Forms.Label();
            this.lbTenTruyen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSLN = new System.Windows.Forms.TextBox();
            this.tbGiaNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btNhap = new System.Windows.Forms.Button();
            this.btTang = new System.Windows.Forms.Button();
            this.btGiam = new System.Windows.Forms.Button();
            this.ptrAnh = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Giá nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã truyện:";
            // 
            // lbMaTruyen
            // 
            this.lbMaTruyen.AutoSize = true;
            this.lbMaTruyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMaTruyen.Location = new System.Drawing.Point(89, 32);
            this.lbMaTruyen.Name = "lbMaTruyen";
            this.lbMaTruyen.Size = new System.Drawing.Size(91, 22);
            this.lbMaTruyen.TabIndex = 23;
            this.lbMaTruyen.Text = "MaTruyen";
            // 
            // lbTenTruyen
            // 
            this.lbTenTruyen.AutoSize = true;
            this.lbTenTruyen.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenTruyen.ForeColor = System.Drawing.Color.IndianRed;
            this.lbTenTruyen.Location = new System.Drawing.Point(8, -4);
            this.lbTenTruyen.Name = "lbTenTruyen";
            this.lbTenTruyen.Size = new System.Drawing.Size(139, 35);
            this.lbTenTruyen.TabIndex = 19;
            this.lbTenTruyen.Text = "Tên truyện";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSLN);
            this.groupBox1.Controls.Add(this.tbGiaNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbMaTruyen);
            this.groupBox1.Controls.Add(this.lbTenTruyen);
            this.groupBox1.Controls.Add(this.btNhap);
            this.groupBox1.Controls.Add(this.btTang);
            this.groupBox1.Controls.Add(this.btGiam);
            this.groupBox1.Location = new System.Drawing.Point(137, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // tbSLN
            // 
            this.tbSLN.Location = new System.Drawing.Point(129, 91);
            this.tbSLN.Name = "tbSLN";
            this.tbSLN.Size = new System.Drawing.Size(38, 22);
            this.tbSLN.TabIndex = 24;
            this.tbSLN.Text = "0";
            this.tbSLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSLN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSLN_KeyPress);
            this.tbSLN.Leave += new System.EventHandler(this.tbSLN_Leave);
            // 
            // tbGiaNhap
            // 
            this.tbGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbGiaNhap.Location = new System.Drawing.Point(86, 58);
            this.tbGiaNhap.Name = "tbGiaNhap";
            this.tbGiaNhap.Size = new System.Drawing.Size(83, 28);
            this.tbGiaNhap.TabIndex = 24;
            this.tbGiaNhap.Text = "0";
            this.tbGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGiaNhap_KeyPress);
            this.tbGiaNhap.Leave += new System.EventHandler(this.tbGiaNhap_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(170, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "VNĐ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Số lượng:";
            // 
            // btNhap
            // 
            this.btNhap.BackgroundImage = global::GUI_Graphical_User_Interface.Properties.Resources.GioHang;
            this.btNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNhap.Location = new System.Drawing.Point(326, 113);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(64, 44);
            this.btNhap.TabIndex = 18;
            this.btNhap.UseVisualStyleBackColor = true;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // btTang
            // 
            this.btTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTang.Location = new System.Drawing.Point(174, 91);
            this.btTang.Name = "btTang";
            this.btTang.Size = new System.Drawing.Size(40, 25);
            this.btTang.TabIndex = 15;
            this.btTang.Text = "+";
            this.btTang.UseVisualStyleBackColor = true;
            this.btTang.Click += new System.EventHandler(this.btTang_Click);
            // 
            // btGiam
            // 
            this.btGiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btGiam.Location = new System.Drawing.Point(85, 91);
            this.btGiam.Name = "btGiam";
            this.btGiam.Size = new System.Drawing.Size(40, 25);
            this.btGiam.TabIndex = 16;
            this.btGiam.Text = "-";
            this.btGiam.UseVisualStyleBackColor = true;
            this.btGiam.Click += new System.EventHandler(this.btGiam_Click);
            // 
            // ptrAnh
            // 
            this.ptrAnh.Location = new System.Drawing.Point(9, 20);
            this.ptrAnh.Name = "ptrAnh";
            this.ptrAnh.Size = new System.Drawing.Size(111, 145);
            this.ptrAnh.TabIndex = 2;
            this.ptrAnh.TabStop = false;
            // 
            // truyennhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ptrAnh);
            this.Name = "truyennhap";
            this.Size = new System.Drawing.Size(545, 178);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMaTruyen;
        private System.Windows.Forms.Label lbTenTruyen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSLN;
        private System.Windows.Forms.TextBox tbGiaNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.Button btTang;
        private System.Windows.Forms.Button btGiam;
        private System.Windows.Forms.PictureBox ptrAnh;
    }
}
