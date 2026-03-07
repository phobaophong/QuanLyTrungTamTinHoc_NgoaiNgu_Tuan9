namespace QuanLyTrungTamTinHoc_NgoaiNgu.UserControls.NhanViens
{
    partial class ucQuanLyLopHoc
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            button1 = new Button();
            btnThoiKhoaBieu = new Button();
            btnDanhSachHocVien = new Button();
            btnXuat = new Button();
            btnHienThiTatCa = new Button();
            cboTenKhoaHoc = new ComboBox();
            btnNhap = new Button();
            btnXoa = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLopHoc = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            ChiTiet = new DataGridViewLinkColumn();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnThoiKhoaBieu);
            groupBox1.Controls.Add(btnDanhSachHocVien);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnHienThiTatCa);
            groupBox1.Controls.Add(cboTenKhoaHoc);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(825, 124);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách lớp thuộc khóa";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(678, 65);
            button1.Name = "button1";
            button1.Size = new Size(129, 39);
            button1.TabIndex = 21;
            button1.Text = "Trang chủ";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnThoiKhoaBieu
            // 
            btnThoiKhoaBieu.BackColor = Color.White;
            btnThoiKhoaBieu.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoiKhoaBieu.Location = new Point(510, 65);
            btnThoiKhoaBieu.Name = "btnThoiKhoaBieu";
            btnThoiKhoaBieu.Size = new Size(129, 39);
            btnThoiKhoaBieu.TabIndex = 20;
            btnThoiKhoaBieu.Text = "Thời khóa biểu";
            btnThoiKhoaBieu.UseVisualStyleBackColor = false;
            // 
            // btnDanhSachHocVien
            // 
            btnDanhSachHocVien.BackColor = Color.White;
            btnDanhSachHocVien.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDanhSachHocVien.ForeColor = Color.Black;
            btnDanhSachHocVien.Location = new Point(342, 65);
            btnDanhSachHocVien.Name = "btnDanhSachHocVien";
            btnDanhSachHocVien.Size = new Size(129, 39);
            btnDanhSachHocVien.TabIndex = 16;
            btnDanhSachHocVien.Text = "Danh sách học viên";
            btnDanhSachHocVien.UseVisualStyleBackColor = false;
            btnDanhSachHocVien.Click += btnDanhSachHocVien_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.White;
            btnXuat.Location = new Point(678, 20);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(129, 39);
            btnXuat.TabIndex = 19;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = false;
            // 
            // btnHienThiTatCa
            // 
            btnHienThiTatCa.BackColor = Color.White;
            btnHienThiTatCa.Location = new Point(342, 20);
            btnHienThiTatCa.Name = "btnHienThiTatCa";
            btnHienThiTatCa.Size = new Size(129, 39);
            btnHienThiTatCa.TabIndex = 17;
            btnHienThiTatCa.Text = "Hiển thị tất cả";
            btnHienThiTatCa.UseVisualStyleBackColor = false;
            btnHienThiTatCa.Click += btnHienThiTatCa_Click;
            // 
            // cboTenKhoaHoc
            // 
            cboTenKhoaHoc.FormattingEnabled = true;
            cboTenKhoaHoc.Location = new Point(6, 26);
            cboTenKhoaHoc.Name = "cboTenKhoaHoc";
            cboTenKhoaHoc.Size = new Size(297, 28);
            cboTenKhoaHoc.TabIndex = 0;
            cboTenKhoaHoc.SelectedIndexChanged += cboTenKhoaHoc_SelectedIndexChanged;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.White;
            btnNhap.Location = new Point(510, 20);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(129, 39);
            btnNhap.TabIndex = 18;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(174, 26);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 39);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa Lớp";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.White;
            btnHuyBo.Location = new Point(678, 26);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(129, 39);
            btnHuyBo.TabIndex = 15;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.White;
            btnLuu.ForeColor = Color.Lime;
            btnLuu.Location = new Point(510, 26);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 39);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Xác nhận";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(342, 26);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 39);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.Location = new Point(6, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 39);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm Lớp";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 124);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(825, 487);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLopHoc, TrangThai, ChiTiet });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(819, 461);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 50F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // TenLopHoc
            // 
            TenLopHoc.DataPropertyName = "TenLopHoc";
            TenLopHoc.HeaderText = "Tên Lớp Học";
            TenLopHoc.MinimumWidth = 6;
            TenLopHoc.Name = "TenLopHoc";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng Thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            // 
            // ChiTiet
            // 
            ChiTiet.DataPropertyName = "ChiTiet";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ChiTiet.DefaultCellStyle = dataGridViewCellStyle1;
            ChiTiet.HeaderText = "Chi Tiết";
            ChiTiet.MinimumWidth = 6;
            ChiTiet.Name = "ChiTiet";
            ChiTiet.Resizable = DataGridViewTriState.True;
            ChiTiet.SortMode = DataGridViewColumnSortMode.Automatic;
            ChiTiet.Text = "Xem chi tiết";
            ChiTiet.UseColumnTextForLinkValue = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnLuu);
            groupBox3.Controls.Add(btnHuyBo);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 611);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(825, 89);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // ucQuanLyLopHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ucQuanLyLopHoc";
            Size = new Size(825, 700);
            Load += ucQuanLyLopHoc_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboTenKhoaHoc;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnHienThiTatCa;
        private Button btnXoa;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLopHoc;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewLinkColumn ChiTiet;
        private Button btnThoiKhoaBieu;
        private Button btnDanhSachHocVien;
        private Button button1;
    }
}
