namespace QLTHUOC.GIAODIEN
{
    partial class PhieuXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuXuat));
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMaPX1 = new System.Windows.Forms.ComboBox();
            this.cbbMaCH = new System.Windows.Forms.ComboBox();
            this.grpChucNang = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblmathuoc = new System.Windows.Forms.Label();
            this.cbbMaThuoc = new System.Windows.Forms.ComboBox();
            this.lblmaphieuxuat = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbMaPN = new System.Windows.Forms.ComboBox();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDSPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnLamSach = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnNhap = new DevComponents.DotNetBar.ButtonX();
            this.btnThucHien = new DevComponents.DotNetBar.ButtonX();
            this.MaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpChucNang.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(314, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Mã Cửa Hàng:";
            // 
            // cbbMaPX1
            // 
            this.cbbMaPX1.FormattingEnabled = true;
            this.cbbMaPX1.Location = new System.Drawing.Point(122, 38);
            this.cbbMaPX1.Name = "cbbMaPX1";
            this.cbbMaPX1.Size = new System.Drawing.Size(153, 21);
            this.cbbMaPX1.TabIndex = 98;
            // 
            // cbbMaCH
            // 
            this.cbbMaCH.FormattingEnabled = true;
            this.cbbMaCH.Location = new System.Drawing.Point(398, 16);
            this.cbbMaCH.Name = "cbbMaCH";
            this.cbbMaCH.Size = new System.Drawing.Size(212, 21);
            this.cbbMaCH.TabIndex = 80;
            // 
            // grpChucNang
            // 
            this.grpChucNang.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpChucNang.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpChucNang.Controls.Add(this.btnThoat);
            this.grpChucNang.Controls.Add(this.btnLamSach);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnNhap);
            this.grpChucNang.Location = new System.Drawing.Point(12, 392);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(636, 79);
            // 
            // 
            // 
            this.grpChucNang.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpChucNang.Style.BackColorGradientAngle = 90;
            this.grpChucNang.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpChucNang.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpChucNang.Style.BorderBottomWidth = 1;
            this.grpChucNang.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpChucNang.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpChucNang.Style.BorderLeftWidth = 1;
            this.grpChucNang.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpChucNang.Style.BorderRightWidth = 1;
            this.grpChucNang.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpChucNang.Style.BorderTopWidth = 1;
            this.grpChucNang.Style.CornerDiameter = 4;
            this.grpChucNang.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpChucNang.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpChucNang.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpChucNang.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpChucNang.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpChucNang.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grpChucNang.TabIndex = 93;
            this.grpChucNang.Text = "Chức Năng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThucHien);
            this.groupBox3.Controls.Add(this.cbbMaPX1);
            this.groupBox3.Controls.Add(this.txtDVT);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtSoLuong);
            this.groupBox3.Controls.Add(this.lblmathuoc);
            this.groupBox3.Controls.Add(this.cbbMaThuoc);
            this.groupBox3.Controls.Add(this.lblmaphieuxuat);
            this.groupBox3.Controls.Add(this.lblsoluong);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(12, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(636, 150);
            this.groupBox3.TabIndex = 91;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Phiếu Xuất";
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(398, 88);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(212, 20);
            this.txtDVT.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(314, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "DVT: ";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(398, 41);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(212, 20);
            this.txtSoLuong.TabIndex = 93;
            // 
            // lblmathuoc
            // 
            this.lblmathuoc.AutoSize = true;
            this.lblmathuoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblmathuoc.Location = new System.Drawing.Point(18, 95);
            this.lblmathuoc.Name = "lblmathuoc";
            this.lblmathuoc.Size = new System.Drawing.Size(59, 13);
            this.lblmathuoc.TabIndex = 90;
            this.lblmathuoc.Text = "Mã Thuốc:";
            // 
            // cbbMaThuoc
            // 
            this.cbbMaThuoc.FormattingEnabled = true;
            this.cbbMaThuoc.Location = new System.Drawing.Point(122, 85);
            this.cbbMaThuoc.Name = "cbbMaThuoc";
            this.cbbMaThuoc.Size = new System.Drawing.Size(153, 21);
            this.cbbMaThuoc.TabIndex = 91;
            // 
            // lblmaphieuxuat
            // 
            this.lblmaphieuxuat.AutoSize = true;
            this.lblmaphieuxuat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblmaphieuxuat.Location = new System.Drawing.Point(18, 46);
            this.lblmaphieuxuat.Name = "lblmaphieuxuat";
            this.lblmaphieuxuat.Size = new System.Drawing.Size(83, 13);
            this.lblmaphieuxuat.TabIndex = 76;
            this.lblmaphieuxuat.Text = "Mã Phiếu Xuất: ";
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblsoluong.Location = new System.Drawing.Point(314, 46);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(56, 13);
            this.lblsoluong.TabIndex = 74;
            this.lblsoluong.Text = "Số Lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(18, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Mã Nhân Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbMaPN);
            this.groupBox2.Controls.Add(this.dtpNgayLapPhieu);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbbMaNhanVien);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbbMaCH);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 84);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu Xuất";
            // 
            // cbbMaPN
            // 
            this.cbbMaPN.FormattingEnabled = true;
            this.cbbMaPN.Location = new System.Drawing.Point(116, 19);
            this.cbbMaPN.Name = "cbbMaPN";
            this.cbbMaPN.Size = new System.Drawing.Size(160, 21);
            this.cbbMaPN.TabIndex = 100;
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(398, 48);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(212, 20);
            this.dtpNgayLapPhieu.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(314, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Ngày Lập Phiếu: ";
            // 
            // cbbMaNhanVien
            // 
            this.cbbMaNhanVien.FormattingEnabled = true;
            this.cbbMaNhanVien.Location = new System.Drawing.Point(116, 47);
            this.cbbMaNhanVien.Name = "cbbMaNhanVien";
            this.cbbMaNhanVien.Size = new System.Drawing.Size(160, 21);
            this.cbbMaNhanVien.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(18, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = "Mã Phiếu Xuất: ";
            // 
            // dgvDSPhieuNhap
            // 
            this.dgvDSPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSPhieuNhap.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDSPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuNhap,
            this.MaThuoc,
            this.SoLuong,
            this.DVT});
            this.dgvDSPhieuNhap.Location = new System.Drawing.Point(12, 279);
            this.dgvDSPhieuNhap.Name = "dgvDSPhieuNhap";
            this.dgvDSPhieuNhap.Size = new System.Drawing.Size(636, 100);
            this.dgvDSPhieuNhap.TabIndex = 90;
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Image = global::QLTHUOC.Properties.Resources.Exit1;
            this.btnThoat.Location = new System.Drawing.Point(488, 14);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            // 
            // btnLamSach
            // 
            this.btnLamSach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLamSach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLamSach.Image = global::QLTHUOC.Properties.Resources.New;
            this.btnLamSach.Location = new System.Drawing.Point(325, 14);
            this.btnLamSach.Name = "btnLamSach";
            this.btnLamSach.Size = new System.Drawing.Size(85, 23);
            this.btnLamSach.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLamSach.TabIndex = 2;
            this.btnLamSach.Text = "Làm Sạch";
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = global::QLTHUOC.Properties.Resources.Trash;
            this.btnXoa.Location = new System.Drawing.Point(173, 14);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 23);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            // 
            // btnNhap
            // 
            this.btnNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNhap.Image = global::QLTHUOC.Properties.Resources.Abort1;
            this.btnNhap.Location = new System.Drawing.Point(27, 14);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(91, 23);
            this.btnNhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập Kho";
            // 
            // btnThucHien
            // 
            this.btnThucHien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThucHien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThucHien.Image = global::QLTHUOC.Properties.Resources.Abort;
            this.btnThucHien.Location = new System.Drawing.Point(453, 115);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(123, 23);
            this.btnThucHien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThucHien.TabIndex = 99;
            this.btnThucHien.Text = "Thực Hiện";
            // 
            // MaPhieuNhap
            // 
            this.MaPhieuNhap.DataPropertyName = "MaPX";
            this.MaPhieuNhap.HeaderText = "Mã Phiếu Xuất";
            this.MaPhieuNhap.Name = "MaPhieuNhap";
            // 
            // MaThuoc
            // 
            this.MaThuoc.DataPropertyName = "MaThuoc";
            this.MaThuoc.HeaderText = "Mã Thuốc";
            this.MaThuoc.Name = "MaThuoc";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn Vị Tính";
            this.DVT.Name = "DVT";
            // 
            // PhieuXuat
            // 
            this.ClientSize = new System.Drawing.Size(684, 474);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvDSPhieuNhap);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhieuXuat";
            this.Text = "Quản Lí Phiếu Xuất";
            this.grpChucNang.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX btnThucHien;
        private System.Windows.Forms.ComboBox cbbMaPX1;
        private System.Windows.Forms.ComboBox cbbMaCH;
        private DevComponents.DotNetBar.Controls.GroupPanel grpChucNang;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnLamSach;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnNhap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblmathuoc;
        private System.Windows.Forms.ComboBox cbbMaThuoc;
        private System.Windows.Forms.Label lblmaphieuxuat;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbMaPN;
        private System.Windows.Forms.DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMaNhanVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDSPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
    }
}