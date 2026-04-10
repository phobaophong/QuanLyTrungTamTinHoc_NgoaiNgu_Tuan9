namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmQuanLyDiemSo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            groupBox5 = new GroupBox();
            btnTaoLopOnThi = new Button();
            lblHoiYKien = new Label();
            btnDsDuoi5Diem = new Button();
            btnDsTren5Diem = new Button();
            groupBox4 = new GroupBox();
            btnXuatExcel = new Button();
            btnNhapExcel = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            numDiemThiThat = new NumericUpDown();
            numDiemThiThu = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            txtTenLop = new TextBox();
            txtHoVaTen = new TextBox();
            txtMaSo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            btnThoat = new Button();
            label2 = new Label();
            label1 = new Label();
            cboLopHoc = new ComboBox();
            cboKhoaHoc = new ComboBox();
            groupBox3 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            MaSo = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            TenLop = new DataGridViewTextBoxColumn();
            DiemThiThu = new DataGridViewTextBoxColumn();
            DiemThiThat = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDiemThiThat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiemThiThu).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1407, 195);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnTaoLopOnThi);
            groupBox5.Controls.Add(lblHoiYKien);
            groupBox5.Controls.Add(btnDsDuoi5Diem);
            groupBox5.Controls.Add(btnDsTren5Diem);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(1128, 23);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(276, 169);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Lựa chọn tạo lớp ôn thi theo điểm thi thật ";
            // 
            // btnTaoLopOnThi
            // 
            btnTaoLopOnThi.Location = new Point(23, 105);
            btnTaoLopOnThi.Name = "btnTaoLopOnThi";
            btnTaoLopOnThi.Size = new Size(111, 29);
            btnTaoLopOnThi.TabIndex = 16;
            btnTaoLopOnThi.Text = "Tạo lớp ôn thi";
            btnTaoLopOnThi.UseVisualStyleBackColor = true;
            btnTaoLopOnThi.Click += btnTaoLopOnThi_Click;
            // 
            // lblHoiYKien
            // 
            lblHoiYKien.AutoSize = true;
            lblHoiYKien.Location = new Point(140, 109);
            lblHoiYKien.Name = "lblHoiYKien";
            lblHoiYKien.Size = new Size(174, 40);
            lblHoiYKien.TabIndex = 15;
            lblHoiYKien.Text = "(*) Tạo lớp ôn thi lại cho \r\n     các sinh viên trong ds";
            // 
            // btnDsDuoi5Diem
            // 
            btnDsDuoi5Diem.Location = new Point(23, 66);
            btnDsDuoi5Diem.Name = "btnDsDuoi5Diem";
            btnDsDuoi5Diem.Size = new Size(111, 29);
            btnDsDuoi5Diem.TabIndex = 14;
            btnDsDuoi5Diem.Text = "Dưới 5 điểm";
            btnDsDuoi5Diem.UseVisualStyleBackColor = true;
            btnDsDuoi5Diem.Click += btnDsDuoi5Diem_Click;
            // 
            // btnDsTren5Diem
            // 
            btnDsTren5Diem.Location = new Point(23, 26);
            btnDsTren5Diem.Name = "btnDsTren5Diem";
            btnDsTren5Diem.Size = new Size(111, 29);
            btnDsTren5Diem.TabIndex = 13;
            btnDsTren5Diem.Text = "Trên 5 điểm";
            btnDsTren5Diem.UseVisualStyleBackColor = true;
            btnDsTren5Diem.Click += btnDsTren5Diem_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnXuatExcel);
            groupBox4.Controls.Add(btnNhapExcel);
            groupBox4.Controls.Add(btnHuyBo);
            groupBox4.Controls.Add(btnLuu);
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(numDiemThiThat);
            groupBox4.Controls.Add(numDiemThiThu);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(txtTenLop);
            groupBox4.Controls.Add(txtHoVaTen);
            groupBox4.Controls.Add(txtMaSo);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Dock = DockStyle.Left;
            groupBox4.Location = new Point(391, 23);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(737, 169);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin học viên và điểm số";
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(591, 64);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(140, 29);
            btnXuatExcel.TabIndex = 16;
            btnXuatExcel.Text = "Xuất Excel...";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnNhapExcel
            // 
            btnNhapExcel.Location = new Point(591, 24);
            btnNhapExcel.Name = "btnNhapExcel";
            btnNhapExcel.Size = new Size(140, 29);
            btnNhapExcel.TabIndex = 15;
            btnNhapExcel.Text = "Nhập Excel...";
            btnNhapExcel.UseVisualStyleBackColor = true;
            btnNhapExcel.Click += btnNhapExcel_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(591, 105);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(140, 29);
            btnHuyBo.TabIndex = 14;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(470, 105);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(106, 29);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Xác nhận";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(349, 105);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(106, 29);
            btnSua.TabIndex = 12;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // numDiemThiThat
            // 
            numDiemThiThat.Location = new Point(470, 68);
            numDiemThiThat.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numDiemThiThat.Name = "numDiemThiThat";
            numDiemThiThat.Size = new Size(106, 27);
            numDiemThiThat.TabIndex = 11;
            numDiemThiThat.ValueChanged += numDiemThiThat_ValueChanged;
            // 
            // numDiemThiThu
            // 
            numDiemThiThu.Location = new Point(470, 26);
            numDiemThiThu.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numDiemThiThu.Name = "numDiemThiThu";
            numDiemThiThu.Size = new Size(106, 27);
            numDiemThiThu.TabIndex = 10;
            numDiemThiThu.ValueChanged += numDiemThiThu_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(349, 68);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 9;
            label7.Text = "Điểm thi thật:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(348, 29);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 8;
            label6.Text = "Điểm thi thử:";
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(102, 105);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(228, 27);
            txtTenLop.TabIndex = 7;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(102, 63);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(228, 27);
            txtHoVaTen.TabIndex = 6;
            // 
            // txtMaSo
            // 
            txtMaSo.Location = new Point(102, 26);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(228, 27);
            txtMaSo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 104);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 4;
            label5.Text = "Lớp:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 66);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 3;
            label4.Text = "Họ và tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 29);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã số:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cboLopHoc);
            groupBox2.Controls.Add(cboKhoaHoc);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(3, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 169);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bộ lọc";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(6, 120);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(106, 29);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 66);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 3;
            label2.Text = "Lớp học:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 29);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Khóa học:";
            // 
            // cboLopHoc
            // 
            cboLopHoc.FormattingEnabled = true;
            cboLopHoc.Location = new Point(89, 63);
            cboLopHoc.Name = "cboLopHoc";
            cboLopHoc.Size = new Size(255, 28);
            cboLopHoc.TabIndex = 2;
            cboLopHoc.SelectedIndexChanged += cboLopHoc_SelectedIndexChanged;
            // 
            // cboKhoaHoc
            // 
            cboKhoaHoc.FormattingEnabled = true;
            cboKhoaHoc.Location = new Point(89, 26);
            cboKhoaHoc.Name = "cboKhoaHoc";
            cboKhoaHoc.Size = new Size(255, 28);
            cboKhoaHoc.TabIndex = 0;
            cboKhoaHoc.SelectedIndexChanged += cboKhoaHoc_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 195);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1407, 519);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách học viên";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, MaSo, HoVaTen, TenLop, DiemThiThu, DiemThiThat });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1401, 493);
            dataGridView.TabIndex = 0;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ID.DefaultCellStyle = dataGridViewCellStyle1;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // MaSo
            // 
            MaSo.DataPropertyName = "MaSo";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            MaSo.DefaultCellStyle = dataGridViewCellStyle2;
            MaSo.HeaderText = "Mã số";
            MaSo.MinimumWidth = 6;
            MaSo.Name = "MaSo";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            HoVaTen.DefaultCellStyle = dataGridViewCellStyle3;
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // TenLop
            // 
            TenLop.DataPropertyName = "TenLop";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            TenLop.DefaultCellStyle = dataGridViewCellStyle4;
            TenLop.HeaderText = "Tên lớp";
            TenLop.MinimumWidth = 6;
            TenLop.Name = "TenLop";
            // 
            // DiemThiThu
            // 
            DiemThiThu.DataPropertyName = "DiemThiThu";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DiemThiThu.DefaultCellStyle = dataGridViewCellStyle5;
            DiemThiThu.HeaderText = "Điểm thi thử";
            DiemThiThu.MinimumWidth = 6;
            DiemThiThu.Name = "DiemThiThu";
            // 
            // DiemThiThat
            // 
            DiemThiThat.DataPropertyName = "DiemThiThat";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DiemThiThat.DefaultCellStyle = dataGridViewCellStyle6;
            DiemThiThat.HeaderText = "Điểm thi thật";
            DiemThiThat.MinimumWidth = 6;
            DiemThiThat.Name = "DiemThiThat";
            // 
            // frmQuanLyDiemSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 714);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmQuanLyDiemSo";
            Text = "Quản lý điểm số";
            Load += frmQuanLyDiemSo_Load;
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDiemThiThat).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiemThiThu).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox cboKhoaHoc;
        private Label label2;
        private ComboBox cboLopHoc;
        private GroupBox groupBox3;
        private DataGridView dataGridView;
        private GroupBox groupBox4;
        private Label label3;
        private TextBox txtTenLop;
        private TextBox txtHoVaTen;
        private TextBox txtMaSo;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private GroupBox groupBox5;
        private Button btnLuu;
        private Button btnSua;
        private NumericUpDown numDiemThiThat;
        private NumericUpDown numDiemThiThu;
        private Button btnDsDuoi5Diem;
        private Button btnDsTren5Diem;
        private Button btnTaoLopOnThi;
        private Button btnHuyBo;
        private Button btnThoat;
        private Label lblHoiYKien;
        private Button btnXuatExcel;
        private Button btnNhapExcel;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MaSo;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn TenLop;
        private DataGridViewTextBoxColumn DiemThiThu;
        private DataGridViewTextBoxColumn DiemThiThat;
    }
}