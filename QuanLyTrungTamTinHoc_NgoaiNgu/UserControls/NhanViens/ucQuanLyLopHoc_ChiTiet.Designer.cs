namespace QuanLyTrungTamTinHoc_NgoaiNgu.UserControls.NhanViens
{
    partial class ucQuanLyLopHoc_ChiTiet
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
            groupBox1 = new GroupBox();
            btnDanhSachHocVien = new Button();
            cboTenKhoaHoc = new ComboBox();
            label5 = new Label();
            dtpNgayKetThuc = new DateTimePicker();
            dtpNgayBatDau = new DateTimePicker();
            ckbDaKetThuc = new CheckBox();
            ckbDangMo = new CheckBox();
            txtTenLopHoc = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlDanhSachHocVien = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnDanhSachHocVien);
            groupBox1.Controls.Add(cboTenKhoaHoc);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpNgayKetThuc);
            groupBox1.Controls.Add(dtpNgayBatDau);
            groupBox1.Controls.Add(ckbDaKetThuc);
            groupBox1.Controls.Add(ckbDangMo);
            groupBox1.Controls.Add(txtTenLopHoc);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(825, 256);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết lớp ";
            // 
            // btnDanhSachHocVien
            // 
            btnDanhSachHocVien.BackColor = Color.White;
            btnDanhSachHocVien.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDanhSachHocVien.ForeColor = Color.Black;
            btnDanhSachHocVien.Location = new Point(522, 179);
            btnDanhSachHocVien.Name = "btnDanhSachHocVien";
            btnDanhSachHocVien.Size = new Size(280, 54);
            btnDanhSachHocVien.TabIndex = 28;
            btnDanhSachHocVien.Text = "Danh sách học viên";
            btnDanhSachHocVien.UseVisualStyleBackColor = false;
            btnDanhSachHocVien.Click += btnDanhSachHocVien_Click;
            // 
            // cboTenKhoaHoc
            // 
            cboTenKhoaHoc.FormattingEnabled = true;
            cboTenKhoaHoc.Location = new Point(188, 202);
            cboTenKhoaHoc.Name = "cboTenKhoaHoc";
            cboTenKhoaHoc.Size = new Size(301, 31);
            cboTenKhoaHoc.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 204);
            label5.Name = "label5";
            label5.Size = new Size(155, 23);
            label5.TabIndex = 26;
            label5.Text = "Lớp thuộc khóa (*):";
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Location = new Point(188, 158);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(301, 30);
            dtpNgayKetThuc.TabIndex = 25;
            dtpNgayKetThuc.ValueChanged += dtpNgayKetThuc_ValueChanged;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Location = new Point(188, 114);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(301, 30);
            dtpNgayBatDau.TabIndex = 24;
            // 
            // ckbDaKetThuc
            // 
            ckbDaKetThuc.AutoSize = true;
            ckbDaKetThuc.Location = new Point(310, 73);
            ckbDaKetThuc.Name = "ckbDaKetThuc";
            ckbDaKetThuc.Size = new Size(120, 27);
            ckbDaKetThuc.TabIndex = 23;
            ckbDaKetThuc.Text = "Đã kết thúc";
            ckbDaKetThuc.UseVisualStyleBackColor = true;
            ckbDaKetThuc.CheckedChanged += ckbDaKetThuc_CheckedChanged;
            // 
            // ckbDangMo
            // 
            ckbDangMo.AutoSize = true;
            ckbDangMo.Location = new Point(188, 73);
            ckbDangMo.Name = "ckbDangMo";
            ckbDangMo.Size = new Size(103, 27);
            ckbDangMo.TabIndex = 22;
            ckbDangMo.Text = "Đang mở";
            ckbDangMo.UseVisualStyleBackColor = true;
            ckbDangMo.CheckedChanged += ckbDangMo_CheckedChanged;
            // 
            // txtTenLopHoc
            // 
            txtTenLopHoc.Location = new Point(188, 29);
            txtTenLopHoc.Name = "txtTenLopHoc";
            txtTenLopHoc.Size = new Size(301, 30);
            txtTenLopHoc.TabIndex = 21;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.Location = new Point(522, 29);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 54);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm Lớp";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.Location = new Point(522, 111);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 54);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.White;
            btnLuu.ForeColor = Color.Lime;
            btnLuu.Location = new Point(673, 29);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 54);
            btnLuu.TabIndex = 19;
            btnLuu.Text = "Xác nhận";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.White;
            btnHuyBo.Location = new Point(673, 112);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(129, 53);
            btnHuyBo.TabIndex = 20;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 161);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 3;
            label4.Text = "Ngày kết thúc (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 118);
            label3.Name = "label3";
            label3.Size = new Size(140, 23);
            label3.TabIndex = 2;
            label3.Text = "Ngày bắt đầu (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 75);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 1;
            label2.Text = "Trạng thái:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 32);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 0;
            label1.Text = "Tên lớp (*):";
            // 
            // pnlDanhSachHocVien
            // 
            pnlDanhSachHocVien.Dock = DockStyle.Fill;
            pnlDanhSachHocVien.Location = new Point(0, 256);
            pnlDanhSachHocVien.Name = "pnlDanhSachHocVien";
            pnlDanhSachHocVien.Size = new Size(825, 444);
            pnlDanhSachHocVien.TabIndex = 1;
            // 
            // ucQuanLyLopHoc_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlDanhSachHocVien);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ucQuanLyLopHoc_ChiTiet";
            Size = new Size(825, 700);
            Load += ucQuanLyLopHoc_ThemLop_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnThem;
        private Button btnSua;
        private Button btnLuu;
        private Button btnHuyBo;
        private Label label5;
        private DateTimePicker dtpNgayKetThuc;
        private DateTimePicker dtpNgayBatDau;
        private CheckBox ckbDaKetThuc;
        private CheckBox ckbDangMo;
        private TextBox txtTenLopHoc;
        private ComboBox cboTenKhoaHoc;
        private Button btnDanhSachHocVien;
        private Panel pnlDanhSachHocVien;
    }
}
