namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmQuanLyLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyLopHoc));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnHuyBo = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            btnChiTiet = new Button();
            rdoDaDong = new RadioButton();
            rdoDangMo = new RadioButton();
            dtpNgayKetThuc = new DateTimePicker();
            dtpNgayBatDau = new DateTimePicker();
            label4 = new Label();
            txtTenLopHoc = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            TenLopHoc = new DataGridViewTextBoxColumn();
            NgayBatDau = new DataGridViewTextBoxColumn();
            NgayKetThuc = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            SiSo = new DataGridViewTextBoxColumn();
            KhoaHocID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(2014, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 165);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.DodgerBlue;
            btnThoat.Font = new Font("Segoe UI", 10.2F);
            btnThoat.Location = new Point(659, 139);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(129, 39);
            btnThoat.TabIndex = 22;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.DodgerBlue;
            btnXoa.Font = new Font("Segoe UI", 10.2F);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(514, 139);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 39);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.DodgerBlue;
            btnHuyBo.Font = new Font("Segoe UI", 10.2F);
            btnHuyBo.Location = new Point(659, 90);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(129, 39);
            btnHuyBo.TabIndex = 21;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DodgerBlue;
            btnSua.Font = new Font("Segoe UI", 10.2F);
            btnSua.ForeColor = Color.Yellow;
            btnSua.Location = new Point(514, 90);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 39);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.DodgerBlue;
            btnThem.Font = new Font("Segoe UI", 10.2F);
            btnThem.Location = new Point(514, 41);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 39);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm Lớp";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(btnChiTiet);
            groupBox1.Controls.Add(rdoDaDong);
            groupBox1.Controls.Add(rdoDangMo);
            groupBox1.Controls.Add(dtpNgayKetThuc);
            groupBox1.Controls.Add(dtpNgayBatDau);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtTenLopHoc);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10.2F);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1239, 261);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin lớp học";
            // 
            // btnChiTiet
            // 
            btnChiTiet.BackColor = Color.DodgerBlue;
            btnChiTiet.Font = new Font("Segoe UI", 10.2F);
            btnChiTiet.Location = new Point(659, 41);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(129, 39);
            btnChiTiet.TabIndex = 35;
            btnChiTiet.Text = "Chi tiết";
            btnChiTiet.UseVisualStyleBackColor = false;
            // 
            // rdoDaDong
            // 
            rdoDaDong.AutoSize = true;
            rdoDaDong.Location = new Point(310, 196);
            rdoDaDong.Name = "rdoDaDong";
            rdoDaDong.Size = new Size(97, 27);
            rdoDaDong.TabIndex = 34;
            rdoDaDong.TabStop = true;
            rdoDaDong.Text = "Đã đóng";
            rdoDaDong.UseVisualStyleBackColor = true;
            // 
            // rdoDangMo
            // 
            rdoDangMo.AutoSize = true;
            rdoDangMo.Location = new Point(178, 196);
            rdoDangMo.Name = "rdoDangMo";
            rdoDangMo.Size = new Size(102, 27);
            rdoDangMo.TabIndex = 33;
            rdoDangMo.TabStop = true;
            rdoDangMo.Text = "Đang mở";
            rdoDangMo.UseVisualStyleBackColor = true;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            dtpNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dtpNgayKetThuc.Location = new Point(178, 141);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(303, 30);
            dtpNgayKetThuc.TabIndex = 32;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.Location = new Point(178, 92);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(303, 30);
            dtpNgayBatDau.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(12, 196);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 27;
            label4.Text = "Trạng thái (*):";
            // 
            // txtTenLopHoc
            // 
            txtTenLopHoc.Font = new Font("Segoe UI", 10.2F);
            txtTenLopHoc.Location = new Point(178, 46);
            txtTenLopHoc.Name = "txtTenLopHoc";
            txtTenLopHoc.Size = new Size(303, 30);
            txtTenLopHoc.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(143, 23);
            label3.TabIndex = 14;
            label3.Text = "Ngày kết thúc (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 12;
            label2.Text = "Ngày khai giảng (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 11;
            label1.Text = "Tên lớp (*):";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 261);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1239, 444);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách lớp học";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, TenLopHoc, NgayBatDau, NgayKetThuc, TrangThai, SiSo, KhoaHocID });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1233, 418);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colID.DefaultCellStyle = dataGridViewCellStyle1;
            colID.FillWeight = 25F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // TenLopHoc
            // 
            TenLopHoc.DataPropertyName = "TenLopHoc";
            TenLopHoc.FillWeight = 120F;
            TenLopHoc.HeaderText = "Tên lớp";
            TenLopHoc.MinimumWidth = 6;
            TenLopHoc.Name = "TenLopHoc";
            // 
            // NgayBatDau
            // 
            NgayBatDau.DataPropertyName = "NgayBatDau";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            NgayBatDau.DefaultCellStyle = dataGridViewCellStyle2;
            NgayBatDau.HeaderText = "Ngày khai giảng";
            NgayBatDau.MinimumWidth = 6;
            NgayBatDau.Name = "NgayBatDau";
            // 
            // NgayKetThuc
            // 
            NgayKetThuc.DataPropertyName = "NgayKetThuc";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            NgayKetThuc.DefaultCellStyle = dataGridViewCellStyle3;
            NgayKetThuc.HeaderText = "Ngày kết thúc";
            NgayKetThuc.MinimumWidth = 6;
            NgayKetThuc.Name = "NgayKetThuc";
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "TrangThai";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TrangThai.DefaultCellStyle = dataGridViewCellStyle4;
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            // 
            // SiSo
            // 
            SiSo.DataPropertyName = "SiSo";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SiSo.DefaultCellStyle = dataGridViewCellStyle5;
            SiSo.HeaderText = "Sĩ số";
            SiSo.MinimumWidth = 6;
            SiSo.Name = "SiSo";
            // 
            // KhoaHocID
            // 
            KhoaHocID.DataPropertyName = "KhoaHocID";
            KhoaHocID.HeaderText = "Khóa học";
            KhoaHocID.MinimumWidth = 6;
            KhoaHocID.Name = "KhoaHocID";
            // 
            // frmQuanLyLopHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 705);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmQuanLyLopHoc";
            Text = "Quản lý lớp học";
            Load += frmQuanLyLopHoc_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnHuyBo;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox1;
        private TextBox txtTenLopHoc;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DateTimePicker dtpNgayKetThuc;
        private DateTimePicker dtpNgayBatDau;
        private RadioButton rdoDangMo;
        private RadioButton rdoDaDong;
        private Button btnChiTiet;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn TenLopHoc;
        private DataGridViewTextBoxColumn NgayBatDau;
        private DataGridViewTextBoxColumn NgayKetThuc;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn SiSo;
        private DataGridViewTextBoxColumn KhoaHocID;
    }
}