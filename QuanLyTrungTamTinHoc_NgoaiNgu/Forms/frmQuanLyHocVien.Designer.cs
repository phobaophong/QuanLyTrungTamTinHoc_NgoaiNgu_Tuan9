namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmQuanLyHocVien
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
            btnDangHoc = new Button();
            btnBaoLuu = new Button();
            btnDaTotNghiep = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            txtMaSoTimKiem = new TextBox();
            btnXacNhanTimKiem = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox4 = new GroupBox();
            btnXacNhanBoLoc = new Button();
            label3 = new Label();
            cbbLopHoc = new ComboBox();
            label2 = new Label();
            cbbKhoaHoc = new ComboBox();
            groupBox1 = new GroupBox();
            btnXuatExcel = new Button();
            btnNhapExcel = new Button();
            label8 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            txtDiaChi = new TextBox();
            label10 = new Label();
            txtSdt = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            btnHuyBo = new Button();
            btnXacNhan = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnDoiAnh = new Button();
            cbbTrangThai = new ComboBox();
            picHinhAnh = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            groupBox6 = new GroupBox();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            label5 = new Label();
            txtHoVaTen = new TextBox();
            label4 = new Label();
            txtMaSo = new TextBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            MaSo = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            Sdt = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            grbDataGrid = new GroupBox();
            btnThoat = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            grbDataGrid.SuspendLayout();
            SuspendLayout();
            // 
            // btnDangHoc
            // 
            btnDangHoc.Dock = DockStyle.Top;
            btnDangHoc.Location = new Point(3, 124);
            btnDangHoc.Name = "btnDangHoc";
            btnDangHoc.Size = new Size(337, 49);
            btnDangHoc.TabIndex = 0;
            btnDangHoc.Text = "Sinh viên đang học  ";
            btnDangHoc.UseVisualStyleBackColor = true;
            btnDangHoc.Click += btnDangHoc_Click;
            // 
            // btnBaoLuu
            // 
            btnBaoLuu.Dock = DockStyle.Top;
            btnBaoLuu.Location = new Point(3, 26);
            btnBaoLuu.Name = "btnBaoLuu";
            btnBaoLuu.Size = new Size(337, 49);
            btnBaoLuu.TabIndex = 1;
            btnBaoLuu.Text = "Sinh viên bảo lưu ";
            btnBaoLuu.UseVisualStyleBackColor = true;
            btnBaoLuu.Click += btnBaoLuu_Click;
            // 
            // btnDaTotNghiep
            // 
            btnDaTotNghiep.Dock = DockStyle.Top;
            btnDaTotNghiep.Location = new Point(3, 75);
            btnDaTotNghiep.Name = "btnDaTotNghiep";
            btnDaTotNghiep.Size = new Size(337, 49);
            btnDaTotNghiep.TabIndex = 2;
            btnDaTotNghiep.Text = "Sinh viên đã tốt nghiệp";
            btnDaTotNghiep.UseVisualStyleBackColor = true;
            btnDaTotNghiep.Click += btnDaTotNghiep_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnDangHoc);
            groupBox2.Controls.Add(btnDaTotNghiep);
            groupBox2.Controls.Add(btnBaoLuu);
            groupBox2.Location = new Point(3, 402);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(343, 185);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtMaSoTimKiem);
            groupBox3.Controls.Add(btnXacNhanTimKiem);
            groupBox3.Location = new Point(3, 211);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(343, 185);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tìm kiếm theo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 46);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 2;
            label1.Text = "Mã số: ";
            // 
            // txtMaSoTimKiem
            // 
            txtMaSoTimKiem.Location = new Point(114, 46);
            txtMaSoTimKiem.Name = "txtMaSoTimKiem";
            txtMaSoTimKiem.Size = new Size(214, 30);
            txtMaSoTimKiem.TabIndex = 1;
            // 
            // btnXacNhanTimKiem
            // 
            btnXacNhanTimKiem.Location = new Point(137, 95);
            btnXacNhanTimKiem.Name = "btnXacNhanTimKiem";
            btnXacNhanTimKiem.Size = new Size(155, 49);
            btnXacNhanTimKiem.TabIndex = 0;
            btnXacNhanTimKiem.Text = "Xác nhận";
            btnXacNhanTimKiem.UseVisualStyleBackColor = true;
            btnXacNhanTimKiem.Click += btnXacNhanTimKiem_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(355, 836);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(btnXacNhanBoLoc);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(cbbLopHoc);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(cbbKhoaHoc);
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(343, 202);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Bộ lọc";
            // 
            // btnXacNhanBoLoc
            // 
            btnXacNhanBoLoc.Location = new Point(137, 124);
            btnXacNhanBoLoc.Name = "btnXacNhanBoLoc";
            btnXacNhanBoLoc.Size = new Size(155, 49);
            btnXacNhanBoLoc.TabIndex = 3;
            btnXacNhanBoLoc.Text = "Xác nhận";
            btnXacNhanBoLoc.UseVisualStyleBackColor = true;
            btnXacNhanBoLoc.Click += btnXacNhanBoLoc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 87);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 5;
            label3.Text = "Lớp học: ";
            // 
            // cbbLopHoc
            // 
            cbbLopHoc.FormattingEnabled = true;
            cbbLopHoc.Location = new Point(114, 84);
            cbbLopHoc.Name = "cbbLopHoc";
            cbbLopHoc.Size = new Size(214, 31);
            cbbLopHoc.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 39);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 3;
            label2.Text = "Khóa học: ";
            // 
            // cbbKhoaHoc
            // 
            cbbKhoaHoc.FormattingEnabled = true;
            cbbKhoaHoc.Location = new Point(114, 36);
            cbbKhoaHoc.Name = "cbbKhoaHoc";
            cbbKhoaHoc.Size = new Size(214, 31);
            cbbKhoaHoc.TabIndex = 0;
            cbbKhoaHoc.SelectedIndexChanged += cbbKhoaHoc_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXuatExcel);
            groupBox1.Controls.Add(btnNhapExcel);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtSdt);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXacNhan);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(cbbTrangThai);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaSo);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(355, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1475, 248);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin học viên";
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(885, 195);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(133, 34);
            btnXuatExcel.TabIndex = 39;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnNhapExcel
            // 
            btnNhapExcel.Location = new Point(733, 195);
            btnNhapExcel.Name = "btnNhapExcel";
            btnNhapExcel.Size = new Size(133, 34);
            btnNhapExcel.TabIndex = 38;
            btnNhapExcel.Text = "Nhập Excel";
            btnNhapExcel.UseVisualStyleBackColor = true;
            btnNhapExcel.Click += btnNhapExcel_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(527, 135);
            label8.Name = "label8";
            label8.Size = new Size(55, 23);
            label8.TabIndex = 37;
            label8.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(647, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(335, 30);
            txtEmail.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(527, 90);
            label9.Name = "label9";
            label9.Size = new Size(66, 23);
            label9.TabIndex = 35;
            label9.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(647, 90);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(335, 30);
            txtDiaChi.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(526, 42);
            label10.Name = "label10";
            label10.Size = new Size(115, 23);
            label10.TabIndex = 33;
            label10.Text = "Số điện thoại:";
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(647, 40);
            txtSdt.MaxLength = 10;
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(334, 30);
            txtSdt.TabIndex = 32;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(122, 134);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(357, 30);
            dtpNgaySinh.TabIndex = 24;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(496, 195);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(101, 34);
            btnHuyBo.TabIndex = 21;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(378, 195);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(101, 34);
            btnXacNhan.TabIndex = 20;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(142, 195);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(101, 34);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(260, 195);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(101, 34);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += Sua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(24, 195);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(101, 34);
            btnThem.TabIndex = 17;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(1372, 195);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(101, 34);
            btnDoiAnh.TabIndex = 16;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // cbbTrangThai
            // 
            cbbTrangThai.FormattingEnabled = true;
            cbbTrangThai.Location = new Point(1128, 39);
            cbbTrangThai.Name = "cbbTrangThai";
            cbbTrangThai.Size = new Size(151, 31);
            cbbTrangThai.TabIndex = 15;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(1343, 17);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(160, 159);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinhAnh.TabIndex = 14;
            picHinhAnh.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1026, 42);
            label7.Name = "label7";
            label7.Size = new Size(96, 23);
            label7.TabIndex = 13;
            label7.Text = "Trạng thái: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 135);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 11;
            label6.Text = "Ngày sinh: ";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rdoNam);
            groupBox6.Controls.Add(rdoNu);
            groupBox6.Location = new Point(1026, 93);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(253, 72);
            groupBox6.TabIndex = 9;
            groupBox6.TabStop = false;
            groupBox6.Text = "Giới tính";
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(42, 37);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(68, 27);
            rdoNam.TabIndex = 7;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(169, 37);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(54, 27);
            rdoNu.TabIndex = 8;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 90);
            label5.Name = "label5";
            label5.Size = new Size(93, 23);
            label5.TabIndex = 6;
            label5.Text = "Họ và tên: ";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(122, 88);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(357, 30);
            txtHoVaTen.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 42);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 4;
            label4.Text = "Mã số: ";
            // 
            // txtMaSo
            // 
            txtMaSo.Location = new Point(122, 40);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(357, 30);
            txtMaSo.TabIndex = 3;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, MaSo, HoVaTen, NgaySinh, GioiTinh, Sdt, DiaChi, Email, TrangThai, HinhAnh, XemChiTiet });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 26);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1469, 559);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 30F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // MaSo
            // 
            MaSo.DataPropertyName = "MaSo";
            MaSo.FillWeight = 50F;
            MaSo.HeaderText = "Mã số";
            MaSo.MinimumWidth = 6;
            MaSo.Name = "MaSo";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.FillWeight = 50F;
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            // 
            // Sdt
            // 
            Sdt.DataPropertyName = "Sdt";
            Sdt.HeaderText = "Số điện thoại";
            Sdt.MinimumWidth = 6;
            Sdt.Name = "Sdt";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            // 
            // HinhAnh
            // 
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // XemChiTiet
            // 
            XemChiTiet.DataPropertyName = "XemChiTiet";
            XemChiTiet.FillWeight = 70F;
            XemChiTiet.HeaderText = "Xem chi tiết";
            XemChiTiet.MinimumWidth = 6;
            XemChiTiet.Name = "XemChiTiet";
            XemChiTiet.Resizable = DataGridViewTriState.True;
            XemChiTiet.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // grbDataGrid
            // 
            grbDataGrid.BackColor = Color.White;
            grbDataGrid.Controls.Add(dataGridView);
            grbDataGrid.Dock = DockStyle.Fill;
            grbDataGrid.Location = new Point(355, 248);
            grbDataGrid.Name = "grbDataGrid";
            grbDataGrid.Size = new Size(1475, 588);
            grbDataGrid.TabIndex = 3;
            grbDataGrid.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(614, 195);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(101, 34);
            btnThoat.TabIndex = 40;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmQuanLyHocVien
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1830, 836);
            Controls.Add(grbDataGrid);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmQuanLyHocVien";
            Text = "frmQuanLySinhVien";
            WindowState = FormWindowState.Maximized;
            Load += frmQuanLySinhVien_Load;
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            grbDataGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnBaoLuu;
        private Button btnDangHoc;
        private GroupBox groupBox3;
        private Button btnXacNhanTimKiem;
        private GroupBox groupBox2;
        private Button btnDaTotNghiep;
        private Label label1;
        private TextBox txtMaSoTimKiem;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox4;
        private Button btnXacNhanBoLoc;
        private Label label3;
        private ComboBox cbbLopHoc;
        private Label label2;
        private ComboBox cbbKhoaHoc;
        private GroupBox groupBox1;
        private DataGridView dataGridView;
        private GroupBox grbDataGrid;
        private Label label4;
        private TextBox txtMaSo;
        private GroupBox groupBox6;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private Label label5;
        private TextBox txtHoVaTen;
        private PictureBox picHinhAnh;
        private Label label7;
        private Label label6;
        private ComboBox cbbTrangThai;
        private Button btnDoiAnh;
        private Button btnSua;
        private Button btnThem;
        private Button btnHuyBo;
        private Button btnXacNhan;
        private Button btnXoa;
        private DateTimePicker dtpNgaySinh;
        private Label label8;
        private TextBox txtEmail;
        private Label label9;
        private TextBox txtDiaChi;
        private Label label10;
        private TextBox txtSdt;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn MaSo;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn Sdt;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewImageColumn HinhAnh;
        private DataGridViewLinkColumn XemChiTiet;
        private Button btnXuatExcel;
        private Button btnNhapExcel;
        private Button btnThoat;
    }
}