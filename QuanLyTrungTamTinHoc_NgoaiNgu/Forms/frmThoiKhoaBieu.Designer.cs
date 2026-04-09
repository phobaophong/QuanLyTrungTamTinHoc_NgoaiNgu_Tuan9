namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmThoiKhoaBieu
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
            cbbKhoaHoc = new ComboBox();
            label2 = new Label();
            cbbLopHoc = new ComboBox();
            label3 = new Label();
            cbbTuan = new ComboBox();
            groupBox4 = new GroupBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnXacNhan = new Button();
            btnTaoTKB = new Button();
            grbTaoTKB = new GroupBox();
            rdoLocTiengAnh = new RadioButton();
            rdoLocTinHoc = new RadioButton();
            chk357 = new CheckBox();
            chk246 = new CheckBox();
            label5 = new Label();
            cbbGiangVien = new ComboBox();
            label4 = new Label();
            cbbCaHoc = new ComboBox();
            label1 = new Label();
            cbbPhongHoc = new ComboBox();
            groupBox1 = new GroupBox();
            dataGridView = new DataGridView();
            colCa = new DataGridViewTextBoxColumn();
            colThu2 = new DataGridViewTextBoxColumn();
            colThu3 = new DataGridViewTextBoxColumn();
            colThu4 = new DataGridViewTextBoxColumn();
            colThu5 = new DataGridViewTextBoxColumn();
            colThu6 = new DataGridViewTextBoxColumn();
            colThu7 = new DataGridViewTextBoxColumn();
            colChuNhat = new DataGridViewTextBoxColumn();
            groupBox4.SuspendLayout();
            grbTaoTKB.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // cbbKhoaHoc
            // 
            cbbKhoaHoc.FormattingEnabled = true;
            cbbKhoaHoc.Location = new Point(114, 36);
            cbbKhoaHoc.Name = "cbbKhoaHoc";
            cbbKhoaHoc.Size = new Size(231, 28);
            cbbKhoaHoc.TabIndex = 0;
            cbbKhoaHoc.SelectedIndexChanged += cbbKhoaHoc_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 39);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "Khóa học: ";
            // 
            // cbbLopHoc
            // 
            cbbLopHoc.FormattingEnabled = true;
            cbbLopHoc.Location = new Point(114, 84);
            cbbLopHoc.Name = "cbbLopHoc";
            cbbLopHoc.Size = new Size(231, 28);
            cbbLopHoc.TabIndex = 4;
            cbbLopHoc.SelectedIndexChanged += cbbLopHoc_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 87);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Lớp học: ";
            // 
            // cbbTuan
            // 
            cbbTuan.FormattingEnabled = true;
            cbbTuan.Location = new Point(17, 135);
            cbbTuan.Name = "cbbTuan";
            cbbTuan.Size = new Size(328, 28);
            cbbTuan.TabIndex = 6;
            cbbTuan.SelectedIndexChanged += cbbTuan_SelectedIndexChanged_1;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(btnThoat);
            groupBox4.Controls.Add(btnHuyBo);
            groupBox4.Controls.Add(btnXacNhan);
            groupBox4.Controls.Add(btnTaoTKB);
            groupBox4.Controls.Add(grbTaoTKB);
            groupBox4.Controls.Add(cbbTuan);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(cbbLopHoc);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(cbbKhoaHoc);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1167, 225);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thời khóa biểu";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(351, 168);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(125, 37);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(351, 125);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(125, 37);
            btnHuyBo.TabIndex = 11;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(351, 82);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(125, 37);
            btnXacNhan.TabIndex = 10;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click_1;
            // 
            // btnTaoTKB
            // 
            btnTaoTKB.Location = new Point(351, 35);
            btnTaoTKB.Name = "btnTaoTKB";
            btnTaoTKB.Size = new Size(125, 37);
            btnTaoTKB.TabIndex = 9;
            btnTaoTKB.Text = "Tạo TKB";
            btnTaoTKB.UseVisualStyleBackColor = true;
            btnTaoTKB.Click += btnTaoTKB_Click;
            // 
            // grbTaoTKB
            // 
            grbTaoTKB.Controls.Add(rdoLocTiengAnh);
            grbTaoTKB.Controls.Add(rdoLocTinHoc);
            grbTaoTKB.Controls.Add(chk357);
            grbTaoTKB.Controls.Add(chk246);
            grbTaoTKB.Controls.Add(label5);
            grbTaoTKB.Controls.Add(cbbGiangVien);
            grbTaoTKB.Controls.Add(label4);
            grbTaoTKB.Controls.Add(cbbCaHoc);
            grbTaoTKB.Controls.Add(label1);
            grbTaoTKB.Controls.Add(cbbPhongHoc);
            grbTaoTKB.Location = new Point(499, 26);
            grbTaoTKB.Name = "grbTaoTKB";
            grbTaoTKB.Size = new Size(641, 179);
            grbTaoTKB.TabIndex = 8;
            grbTaoTKB.TabStop = false;
            grbTaoTKB.Text = "Tạo thời khóa biểu";
            // 
            // rdoLocTiengAnh
            // 
            rdoLocTiengAnh.AutoSize = true;
            rdoLocTiengAnh.Location = new Point(511, 27);
            rdoLocTiengAnh.Name = "rdoLocTiengAnh";
            rdoLocTiengAnh.Size = new Size(97, 24);
            rdoLocTiengAnh.TabIndex = 13;
            rdoLocTiengAnh.TabStop = true;
            rdoLocTiengAnh.Text = "Tiếng Anh";
            rdoLocTiengAnh.UseVisualStyleBackColor = true;
            rdoLocTiengAnh.CheckedChanged += rdoLocTiengAnh_CheckedChanged;
            // 
            // rdoLocTinHoc
            // 
            rdoLocTinHoc.AutoSize = true;
            rdoLocTinHoc.Location = new Point(427, 27);
            rdoLocTinHoc.Name = "rdoLocTinHoc";
            rdoLocTinHoc.Size = new Size(78, 24);
            rdoLocTinHoc.TabIndex = 12;
            rdoLocTinHoc.TabStop = true;
            rdoLocTinHoc.Text = "Tin học";
            rdoLocTinHoc.UseVisualStyleBackColor = true;
            rdoLocTinHoc.CheckedChanged += rdoLocTinHoc_CheckedChanged;
            // 
            // chk357
            // 
            chk357.AutoSize = true;
            chk357.Location = new Point(13, 136);
            chk357.Name = "chk357";
            chk357.Size = new Size(112, 24);
            chk357.TabIndex = 11;
            chk357.Text = "Thứ 3 - 5 - 7";
            chk357.UseVisualStyleBackColor = true;
            // 
            // chk246
            // 
            chk246.AutoSize = true;
            chk246.Location = new Point(13, 106);
            chk246.Name = "chk246";
            chk246.Size = new Size(112, 24);
            chk246.TabIndex = 10;
            chk246.Text = "Thứ 2 - 4 - 6";
            chk246.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(330, 29);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 9;
            label5.Text = "Giảng viên:";
            // 
            // cbbGiangVien
            // 
            cbbGiangVien.FormattingEnabled = true;
            cbbGiangVien.Location = new Point(330, 65);
            cbbGiangVien.Name = "cbbGiangVien";
            cbbGiangVien.Size = new Size(278, 28);
            cbbGiangVien.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 69);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 7;
            label4.Text = "Ca học:";
            // 
            // cbbCaHoc
            // 
            cbbCaHoc.FormattingEnabled = true;
            cbbCaHoc.Location = new Point(110, 64);
            cbbCaHoc.Name = "cbbCaHoc";
            cbbCaHoc.Size = new Size(214, 28);
            cbbCaHoc.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 29);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 5;
            label1.Text = "Phòng học:";
            // 
            // cbbPhongHoc
            // 
            cbbPhongHoc.FormattingEnabled = true;
            cbbPhongHoc.Location = new Point(110, 26);
            cbbPhongHoc.Name = "cbbPhongHoc";
            cbbPhongHoc.Size = new Size(214, 28);
            cbbPhongHoc.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 225);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1167, 513);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colCa, colThu2, colThu3, colThu4, colThu5, colThu6, colThu7, colChuNhat });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.Size = new Size(1161, 487);
            dataGridView.TabIndex = 0;
            // 
            // colCa
            // 
            colCa.HeaderText = "Ca học";
            colCa.MinimumWidth = 6;
            colCa.Name = "colCa";
            // 
            // colThu2
            // 
            colThu2.HeaderText = "Thứ 2";
            colThu2.MinimumWidth = 6;
            colThu2.Name = "colThu2";
            // 
            // colThu3
            // 
            colThu3.HeaderText = "Thứ 3";
            colThu3.MinimumWidth = 6;
            colThu3.Name = "colThu3";
            // 
            // colThu4
            // 
            colThu4.HeaderText = "Thứ 4";
            colThu4.MinimumWidth = 6;
            colThu4.Name = "colThu4";
            // 
            // colThu5
            // 
            colThu5.HeaderText = "Thứ 5";
            colThu5.MinimumWidth = 6;
            colThu5.Name = "colThu5";
            // 
            // colThu6
            // 
            colThu6.HeaderText = "Thứ 6";
            colThu6.MinimumWidth = 6;
            colThu6.Name = "colThu6";
            // 
            // colThu7
            // 
            colThu7.HeaderText = "Thứ 7";
            colThu7.MinimumWidth = 6;
            colThu7.Name = "colThu7";
            // 
            // colChuNhat
            // 
            colChuNhat.HeaderText = "Chủ nhật";
            colChuNhat.MinimumWidth = 6;
            colChuNhat.Name = "colChuNhat";
            // 
            // frmThoiKhoaBieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 738);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmThoiKhoaBieu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThoiKhoaBieu";
            Load += frmThoiKhoaBieu_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            grbTaoTKB.ResumeLayout(false);
            grbTaoTKB.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbbKhoaHoc;
        private Label label2;
        private ComboBox cbbLopHoc;
        private Label label3;
        private ComboBox cbbTuan;
        private GroupBox groupBox4;
        private GroupBox groupBox1;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn colCa;
        private DataGridViewTextBoxColumn colThu2;
        private DataGridViewTextBoxColumn colThu3;
        private DataGridViewTextBoxColumn colThu4;
        private DataGridViewTextBoxColumn colThu5;
        private DataGridViewTextBoxColumn colThu6;
        private DataGridViewTextBoxColumn colThu7;
        private DataGridViewTextBoxColumn colChuNhat;
        private GroupBox grbTaoTKB;
        private Label label5;
        private ComboBox cbbGiangVien;
        private Label label4;
        private ComboBox cbbCaHoc;
        private Label label1;
        private ComboBox cbbPhongHoc;
        private Button btnTaoTKB;
        private Button btnXacNhan;
        private Button btnHuyBo;
        private CheckBox chk357;
        private CheckBox chk246;
        private Button btnThoat;
        private RadioButton rdoLocTiengAnh;
        private RadioButton rdoLocTinHoc;
    }
}