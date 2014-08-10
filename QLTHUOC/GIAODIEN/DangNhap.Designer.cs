namespace QLTHUOC.GIAODIEN
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.lblTaikhoan = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbdangnhap = new System.Windows.Forms.GroupBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbdangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTaikhoan
            // 
            this.lblTaikhoan.AutoSize = true;
            this.lblTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTaikhoan.Location = new System.Drawing.Point(6, 40);
            this.lblTaikhoan.Name = "lblTaikhoan";
            this.lblTaikhoan.Size = new System.Drawing.Size(72, 16);
            this.lblTaikhoan.TabIndex = 1;
            this.lblTaikhoan.Text = "Tài Khoản:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(84, 81);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(190, 20);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(9, 134);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 0;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPass.Location = new System.Drawing.Point(6, 82);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(66, 16);
            this.lblPass.TabIndex = 6;
            this.lblPass.Text = "Mật Khẩu:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(84, 39);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(190, 20);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.Blue;
            this.lbl1.Location = new System.Drawing.Point(280, 42);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(17, 13);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "(*)";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.ForeColor = System.Drawing.Color.Blue;
            this.lbl2.Location = new System.Drawing.Point(280, 84);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(17, 13);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "(*)";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(199, 134);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // gbdangnhap
            // 
            this.gbdangnhap.Controls.Add(this.btnDangKy);
            this.gbdangnhap.Controls.Add(this.btnThoat);
            this.gbdangnhap.Controls.Add(this.lbl2);
            this.gbdangnhap.Controls.Add(this.lbl1);
            this.gbdangnhap.Controls.Add(this.txtTaiKhoan);
            this.gbdangnhap.Controls.Add(this.lblPass);
            this.gbdangnhap.Controls.Add(this.btnDangNhap);
            this.gbdangnhap.Controls.Add(this.txtMatKhau);
            this.gbdangnhap.Controls.Add(this.lblTaikhoan);
            this.gbdangnhap.Location = new System.Drawing.Point(12, 29);
            this.gbdangnhap.Name = "gbdangnhap";
            this.gbdangnhap.Size = new System.Drawing.Size(393, 172);
            this.gbdangnhap.TabIndex = 11;
            this.gbdangnhap.TabStop = false;
            this.gbdangnhap.Text = "Thông Tin Đăng Nhập";
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(103, 134);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 10;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLTHUOC.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(411, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 228);
            this.Controls.Add(this.gbdangnhap);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            this.gbdangnhap.ResumeLayout(false);
            this.gbdangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTaikhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbdangnhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDangKy;

    }
}