namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmQuanLyHocPhi
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
            groupBox4 = new GroupBox();
            cbbKhoaHoc = new ComboBox();
            lblHocPhi = new Label();
            label2 = new Label();
            cbbLopHoc = new ComboBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            txtSoTien = new TextBox();
            label8 = new Label();
            chkTrangThai = new CheckBox();
            label7 = new Label();
            dtpNgayDong = new DateTimePicker();
            btnInHoaDon = new Button();
            btnXacNhan = new Button();
            btnSua = new Button();
            textBox2 = new TextBox();
            label6 = new Label();
            label4 = new Label();
            txtTenLop = new TextBox();
            label1 = new Label();
            txtHoVaTen = new TextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            TenLop = new DataGridViewTextBoxColumn();
            SoTienDaDong = new DataGridViewTextBoxColumn();
            NgayDong = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1820, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbbKhoaHoc);
            groupBox4.Controls.Add(lblHocPhi);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(cbbLopHoc);
            groupBox4.Controls.Add(label3);
            groupBox4.Dock = DockStyle.Left;
            groupBox4.Location = new Point(3, 23);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(335, 213);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Bộ lọc";
            // 
            // cbbKhoaHoc
            // 
            cbbKhoaHoc.FormattingEnabled = true;
            cbbKhoaHoc.Location = new Point(97, 26);
            cbbKhoaHoc.Name = "cbbKhoaHoc";
            cbbKhoaHoc.Size = new Size(214, 28);
            cbbKhoaHoc.TabIndex = 14;
            cbbKhoaHoc.SelectedIndexChanged += cbbKhoaHoc_SelectedIndexChanged;
            // 
            // lblHocPhi
            // 
            lblHocPhi.AutoSize = true;
            lblHocPhi.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHocPhi.Location = new Point(13, 137);
            lblHocPhi.Name = "lblHocPhi";
            lblHocPhi.Size = new Size(63, 20);
            lblHocPhi.TabIndex = 23;
            lblHocPhi.Text = "Học phí ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 26);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 15;
            label2.Text = "Khóa học: ";
            // 
            // cbbLopHoc
            // 
            cbbLopHoc.FormattingEnabled = true;
            cbbLopHoc.Location = new Point(97, 74);
            cbbLopHoc.Name = "cbbLopHoc";
            cbbLopHoc.Size = new Size(214, 28);
            cbbLopHoc.TabIndex = 16;
            cbbLopHoc.SelectedIndexChanged += cbbLopHoc_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 74);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 17;
            label3.Text = "Lớp học: ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSoTien);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(chkTrangThai);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(dtpNgayDong);
            groupBox3.Controls.Add(btnInHoaDon);
            groupBox3.Controls.Add(btnXacNhan);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtTenLop);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtHoVaTen);
            groupBox3.Controls.Add(label5);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Location = new Point(344, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1473, 213);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin học viên";
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(472, 19);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(251, 27);
            txtSoTien.TabIndex = 36;
            txtSoTien.TextChanged += txtSoTien_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 102);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 35;
            label8.Text = "Trạng thái:";
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Location = new Point(115, 102);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(110, 24);
            chkTrangThai.TabIndex = 34;
            chkTrangThai.Text = "Đã đóng đủ";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(372, 62);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 32;
            label7.Text = "Ngày đóng: ";
            // 
            // dtpNgayDong
            // 
            dtpNgayDong.CustomFormat = "dd/MM/yyyy";
            dtpNgayDong.Format = DateTimePickerFormat.Custom;
            dtpNgayDong.Location = new Point(472, 57);
            dtpNgayDong.Name = "dtpNgayDong";
            dtpNgayDong.Size = new Size(251, 27);
            dtpNgayDong.TabIndex = 31;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(613, 159);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(110, 29);
            btnInHoaDon.TabIndex = 30;
            btnInHoaDon.Text = "In biên lai";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(504, 159);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(94, 29);
            btnXacNhan.TabIndex = 29;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(394, 159);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 28;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(472, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(251, 27);
            textBox2.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(372, 93);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 27;
            label6.Text = "Ghi chú: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 26);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 25;
            label4.Text = "Đã đóng: ";
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(115, 59);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(251, 27);
            txtTenLop.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 62);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 23;
            label1.Text = "Học lớp: ";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(115, 26);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(251, 27);
            txtHoVaTen.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 28);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 21;
            label5.Text = "Họ và tên: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1820, 561);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách học phí";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, HoVaTen, TenLop, SoTienDaDong, NgayDong, GhiChu });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1814, 535);
            dataGridView.TabIndex = 0;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // TenLop
            // 
            TenLop.DataPropertyName = "TenLop";
            TenLop.HeaderText = "Tên lớp";
            TenLop.MinimumWidth = 6;
            TenLop.Name = "TenLop";
            // 
            // SoTienDaDong
            // 
            SoTienDaDong.DataPropertyName = "SoTienDaDong";
            SoTienDaDong.HeaderText = "Số tiền đã đóng";
            SoTienDaDong.MinimumWidth = 6;
            SoTienDaDong.Name = "SoTienDaDong";
            // 
            // NgayDong
            // 
            NgayDong.DataPropertyName = "NgayDong";
            NgayDong.HeaderText = "Ngày đóng";
            NgayDong.MinimumWidth = 6;
            NgayDong.Name = "NgayDong";
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            // 
            // frmQuanLyHocPhi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 800);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmQuanLyHocPhi";
            Text = "frmHocPhi";
            Load += frmHocPhi_Load;
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox txtHoVaTen;
        private Label label3;
        private ComboBox cbbLopHoc;
        private Label label2;
        private ComboBox cbbKhoaHoc;
        private GroupBox groupBox3;
        private TextBox txtTenLop;
        private Label label1;
        private Button btnSua;
        private TextBox textBox2;
        private Label label6;
        private Label label4;
        private Button btnXacNhan;
        private Button btnInHoaDon;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn TenLop;
        private DataGridViewTextBoxColumn SoTienDaDong;
        private DataGridViewTextBoxColumn NgayDong;
        private DataGridViewTextBoxColumn GhiChu;
        private Label label7;
        private DateTimePicker dtpNgayDong;
        private CheckBox chkTrangThai;
        private Label label8;
        private TextBox txtSoTien;
        private Label lblHocPhi;
        private GroupBox groupBox4;
    }
}