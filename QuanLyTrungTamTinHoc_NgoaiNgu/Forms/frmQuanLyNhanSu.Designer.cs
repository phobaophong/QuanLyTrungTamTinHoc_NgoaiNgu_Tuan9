namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmQuanLyNhanSu
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtBoPhan = new TextBox();
            btnHuyBo = new Button();
            btnXacNhan = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            groupBox6 = new GroupBox();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            label8 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            txtDiaChi = new TextBox();
            label10 = new Label();
            txtSdt = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            txtHoVaTen = new TextBox();
            label4 = new Label();
            txtMaSo = new TextBox();
            grbDataGrid = new GroupBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            MaSo = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            Sdt = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            BoPhan = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            XemChiTiet = new DataGridViewLinkColumn();
            groupBox2 = new GroupBox();
            btnNhanVien = new Button();
            btnGiangVien = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            groupBox6.SuspendLayout();
            grbDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtBoPhan);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXacNhan);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtSdt);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaSo);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1327, 284);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(104, 180);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 53;
            label1.Text = "Bộ phận:";
            // 
            // txtBoPhan
            // 
            txtBoPhan.Anchor = AnchorStyles.None;
            txtBoPhan.Location = new Point(201, 177);
            txtBoPhan.Name = "txtBoPhan";
            txtBoPhan.Size = new Size(132, 27);
            txtBoPhan.TabIndex = 52;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.None;
            btnHuyBo.Location = new Point(792, 230);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(101, 34);
            btnHuyBo.TabIndex = 51;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Anchor = AnchorStyles.None;
            btnXacNhan.Location = new Point(646, 230);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(101, 34);
            btnXacNhan.TabIndex = 50;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.Location = new Point(354, 230);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(101, 34);
            btnXoa.TabIndex = 49;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.Location = new Point(500, 230);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(101, 34);
            btnSua.TabIndex = 48;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.Location = new Point(104, 230);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(205, 34);
            btnThem.TabIndex = 47;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Anchor = AnchorStyles.None;
            btnDoiAnh.Location = new Point(1084, 230);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(101, 34);
            btnDoiAnh.TabIndex = 46;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Anchor = AnchorStyles.None;
            picHinhAnh.Location = new Point(1064, 14);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(160, 195);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinhAnh.TabIndex = 45;
            picHinhAnh.TabStop = false;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.None;
            groupBox6.Controls.Add(rdoNu);
            groupBox6.Controls.Add(rdoNam);
            groupBox6.Location = new Point(343, 114);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(216, 59);
            groupBox6.TabIndex = 44;
            groupBox6.TabStop = false;
            groupBox6.Text = "Giới tính";
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(132, 26);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 8;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(42, 26);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 7;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(579, 133);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 43;
            label8.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(698, 131);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(335, 27);
            txtEmail.TabIndex = 42;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(579, 82);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 41;
            label9.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.None;
            txtDiaChi.Location = new Point(699, 82);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(335, 27);
            txtDiaChi.TabIndex = 40;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(578, 34);
            label10.Name = "label10";
            label10.Size = new Size(100, 20);
            label10.TabIndex = 39;
            label10.Text = "Số điện thoại:";
            // 
            // txtSdt
            // 
            txtSdt.Anchor = AnchorStyles.None;
            txtSdt.Location = new Point(699, 32);
            txtSdt.MaxLength = 10;
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(334, 27);
            txtSdt.TabIndex = 38;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Anchor = AnchorStyles.None;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(201, 133);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(132, 27);
            dtpNgaySinh.TabIndex = 30;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(103, 134);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 29;
            label6.Text = "Ngày sinh: ";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(104, 83);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 28;
            label5.Text = "Họ và tên: ";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Anchor = AnchorStyles.None;
            txtHoVaTen.Location = new Point(202, 81);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(357, 27);
            txtHoVaTen.TabIndex = 27;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(104, 35);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 26;
            label4.Text = "Mã số: ";
            // 
            // txtMaSo
            // 
            txtMaSo.Anchor = AnchorStyles.None;
            txtMaSo.Location = new Point(202, 33);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(357, 27);
            txtMaSo.TabIndex = 25;
            // 
            // grbDataGrid
            // 
            grbDataGrid.BackColor = Color.White;
            grbDataGrid.Controls.Add(dataGridView);
            grbDataGrid.Dock = DockStyle.Fill;
            grbDataGrid.Location = new Point(0, 284);
            grbDataGrid.Name = "grbDataGrid";
            grbDataGrid.Size = new Size(1327, 522);
            grbDataGrid.TabIndex = 4;
            grbDataGrid.TabStop = false;
            grbDataGrid.Text = "Danh sách ";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, MaSo, HoVaTen, NgaySinh, GioiTinh, Sdt, DiaChi, Email, BoPhan, HinhAnh, XemChiTiet });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1321, 496);
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
            // BoPhan
            // 
            BoPhan.DataPropertyName = "BoPhan";
            BoPhan.HeaderText = "Bộ Phận";
            BoPhan.MinimumWidth = 6;
            BoPhan.Name = "BoPhan";
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
            XemChiTiet.HeaderText = "Xem chi tiết";
            XemChiTiet.MinimumWidth = 6;
            XemChiTiet.Name = "XemChiTiet";
            XemChiTiet.Resizable = DataGridViewTriState.True;
            XemChiTiet.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnNhanVien);
            groupBox2.Controls.Add(btnGiangVien);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 712);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1327, 94);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hiển thị danh sách";
            // 
            // btnNhanVien
            // 
            btnNhanVien.Anchor = AnchorStyles.None;
            btnNhanVien.Location = new Point(709, 17);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(200, 53);
            btnNhanVien.TabIndex = 1;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnGiangVien
            // 
            btnGiangVien.Anchor = AnchorStyles.None;
            btnGiangVien.Location = new Point(418, 17);
            btnGiangVien.Name = "btnGiangVien";
            btnGiangVien.Size = new Size(200, 53);
            btnGiangVien.TabIndex = 0;
            btnGiangVien.Text = "Giảng viên";
            btnGiangVien.UseVisualStyleBackColor = true;
            btnGiangVien.Click += btnGiangVien_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.Location = new Point(938, 230);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(101, 34);
            btnThoat.TabIndex = 54;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmQuanLyNhanSu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 806);
            Controls.Add(groupBox2);
            Controls.Add(grbDataGrid);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmQuanLyNhanSu";
            Text = "frmQuanLyNhanSu";
            Load += frmQuanLyNhanSu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            grbDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox grbDataGrid;
        private DataGridView dataGridView;
        private DateTimePicker dtpNgaySinh;
        private Label label6;
        private Label label5;
        private TextBox txtHoVaTen;
        private Label label4;
        private TextBox txtMaSo;
        private Label label8;
        private TextBox txtEmail;
        private Label label9;
        private TextBox txtDiaChi;
        private Label label10;
        private TextBox txtSdt;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private GroupBox groupBox6;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private Button btnHuyBo;
        private Button btnXacNhan;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox2;
        private Button btnNhanVien;
        private Button btnGiangVien;
        private Label label1;
        private TextBox txtBoPhan;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn MaSo;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn Sdt;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn BoPhan;
        private DataGridViewImageColumn HinhAnh;
        private DataGridViewLinkColumn XemChiTiet;
        private Button btnThoat;
    }
}