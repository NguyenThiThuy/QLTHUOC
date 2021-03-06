namespace QLTHUOC.GIAODIEN
{
    partial class CuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuaHang));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSCuaHang = new System.Windows.Forms.DataGridView();
            this.MaCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenCH = new System.Windows.Forms.TextBox();
            this.cbbNoCu = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbMaCH = new System.Windows.Forms.ComboBox();
            this.lblLoaiKH = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAddree = new System.Windows.Forms.Label();
            this.lbDT = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnsave = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCuaHang)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.SystemColors.ActiveBorder;
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSCuaHang);
            this.groupBox1.Location = new System.Drawing.Point(6, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 175);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Cửa Hàng";
            // 
            // dgvDSCuaHang
            // 
            this.dgvDSCuaHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCuaHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDSCuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCuaHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCH,
            this.TenCH,
            this.SoDT,
            this.DiaChi,
            this.Email,
            this.NoCu});
            this.dgvDSCuaHang.GridColor = System.Drawing.Color.LightSlateGray;
            this.dgvDSCuaHang.Location = new System.Drawing.Point(11, 19);
            this.dgvDSCuaHang.Name = "dgvDSCuaHang";
            this.dgvDSCuaHang.Size = new System.Drawing.Size(717, 150);
            this.dgvDSCuaHang.TabIndex = 0;
            // 
            // MaCH
            // 
            this.MaCH.DataPropertyName = "MaCH";
            this.MaCH.HeaderText = "Mã Cửa Hàng";
            this.MaCH.Name = "MaCH";
            // 
            // TenCH
            // 
            this.TenCH.DataPropertyName = "TenCH";
            this.TenCH.HeaderText = "Tên Cửa Hàng";
            this.TenCH.Name = "TenCH";
            // 
            // SoDT
            // 
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số Điện Thoại";
            this.SoDT.Name = "SoDT";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // NoCu
            // 
            this.NoCu.DataPropertyName = "NoCu";
            this.NoCu.HeaderText = "Nợ Cũ";
            this.NoCu.Name = "NoCu";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(454, 105);
            this.txtSDT.MaxLength = 20;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(220, 20);
            this.txtSDT.TabIndex = 35;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(454, 18);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(220, 20);
            this.txtDiaChi.TabIndex = 34;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(454, 61);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 20);
            this.txtEmail.TabIndex = 33;
            // 
            // txtTenCH
            // 
            this.txtTenCH.Location = new System.Drawing.Point(151, 61);
            this.txtTenCH.Name = "txtTenCH";
            this.txtTenCH.Size = new System.Drawing.Size(221, 20);
            this.txtTenCH.TabIndex = 36;
            // 
            // cbbNoCu
            // 
            this.cbbNoCu.FormattingEnabled = true;
            this.cbbNoCu.Location = new System.Drawing.Point(151, 105);
            this.cbbNoCu.Name = "cbbNoCu";
            this.cbbNoCu.Size = new System.Drawing.Size(221, 21);
            this.cbbNoCu.TabIndex = 32;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbMaCH);
            this.groupBox3.Controls.Add(this.txtTenCH);
            this.groupBox3.Controls.Add(this.txtSDT);
            this.groupBox3.Controls.Add(this.txtDiaChi);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.cbbNoCu);
            this.groupBox3.Controls.Add(this.lblLoaiKH);
            this.groupBox3.Controls.Add(this.lbEmail);
            this.groupBox3.Controls.Add(this.lbAddree);
            this.groupBox3.Controls.Add(this.lbDT);
            this.groupBox3.Controls.Add(this.lbTen);
            this.groupBox3.Controls.Add(this.lbMaKH);
            this.groupBox3.Location = new System.Drawing.Point(6, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(734, 142);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Chi Tiết";
            // 
            // cbbMaCH
            // 
            this.cbbMaCH.FormattingEnabled = true;
            this.cbbMaCH.Location = new System.Drawing.Point(151, 23);
            this.cbbMaCH.Name = "cbbMaCH";
            this.cbbMaCH.Size = new System.Drawing.Size(221, 21);
            this.cbbMaCH.TabIndex = 37;
            // 
            // lblLoaiKH
            // 
            this.lblLoaiKH.AutoSize = true;
            this.lblLoaiKH.Location = new System.Drawing.Point(48, 113);
            this.lblLoaiKH.Name = "lblLoaiKH";
            this.lblLoaiKH.Size = new System.Drawing.Size(43, 13);
            this.lblLoaiKH.TabIndex = 31;
            this.lblLoaiKH.Text = "Nợ Cũ: ";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(399, 67);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 30;
            this.lbEmail.Text = "Email:";
            // 
            // lbAddree
            // 
            this.lbAddree.AutoSize = true;
            this.lbAddree.Location = new System.Drawing.Point(399, 25);
            this.lbAddree.Name = "lbAddree";
            this.lbAddree.Size = new System.Drawing.Size(44, 13);
            this.lbAddree.TabIndex = 29;
            this.lbAddree.Text = "Địa Chỉ:";
            // 
            // lbDT
            // 
            this.lbDT.AutoSize = true;
            this.lbDT.Location = new System.Drawing.Point(399, 113);
            this.lbDT.Name = "lbDT";
            this.lbDT.Size = new System.Drawing.Size(32, 13);
            this.lbDT.TabIndex = 28;
            this.lbDT.Text = "SDT:";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(48, 68);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(80, 13);
            this.lbTen.TabIndex = 27;
            this.lbTen.Text = "Tên Cửa Hàng:";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Location = new System.Drawing.Point(48, 26);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(76, 13);
            this.lbMaKH.TabIndex = 26;
            this.lbMaKH.Text = "Mã Cửa Hàng:";
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerColorTint = System.Drawing.SystemColors.ActiveBorder;
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager2.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.btnsave);
            this.groupPanel3.Controls.Add(this.btnThoat);
            this.groupPanel3.Controls.Add(this.btnXoa);
            this.groupPanel3.Controls.Add(this.btnSua);
            this.groupPanel3.Controls.Add(this.btnThem);
            this.groupPanel3.Location = new System.Drawing.Point(17, 379);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(717, 74);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 76;
            this.groupPanel3.Text = "Chức Năng";
            // 
            // btnsave
            // 
            this.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsave.Image = global::QLTHUOC.Properties.Resources.Save;
            this.btnsave.Location = new System.Drawing.Point(279, 14);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(79, 30);
            this.btnsave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsave.TabIndex = 43;
            this.btnsave.Text = "Save";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Image = global::QLTHUOC.Properties.Resources.Exit;
            this.btnThoat.Location = new System.Drawing.Point(575, 14);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 30);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 41;
            this.btnThoat.Text = "Thoát";
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = global::QLTHUOC.Properties.Resources.Delete;
            this.btnXoa.Location = new System.Drawing.Point(409, 14);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Image = global::QLTHUOC.Properties.Resources.Notes;
            this.btnSua.Location = new System.Drawing.Point(163, 14);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 30);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Image = global::QLTHUOC.Properties.Resources.Create;
            this.btnThem.Location = new System.Drawing.Point(49, 14);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 30);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "Thêm";
            // 
            // CuaHang
            // 
            this.ClientSize = new System.Drawing.Size(834, 488);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CuaHang";
            this.Text = "Quản lí cửa hàng";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCuaHang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSCuaHang;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenCH;
        private System.Windows.Forms.ComboBox cbbNoCu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbMaCH;
        private System.Windows.Forms.Label lblLoaiKH;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbAddree;
        private System.Windows.Forms.Label lbDT;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbMaKH;
        private DevComponents.DotNetBar.StyleManager styleManager2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX btnsave;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoCu;
    }
}