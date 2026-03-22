namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmDiemSo
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
            btnHuyBo = new Button();
            btnXacNhan = new Button();
            btnSuaDiem = new Button();
            numDiemThiThu = new NumericUpDown();
            label1 = new Label();
            label5 = new Label();
            txtHoVaTen = new TextBox();
            label4 = new Label();
            txtMaSo = new TextBox();
            label3 = new Label();
            cbbLopHoc = new ComboBox();
            label2 = new Label();
            cbbKhoaHoc = new ComboBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            MaSo = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DiemThiThu = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDiemThiThu).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXacNhan);
            groupBox1.Controls.Add(btnSuaDiem);
            groupBox1.Controls.Add(numDiemThiThu);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaSo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbbLopHoc);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbbKhoaHoc);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1169, 217);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hiển thị theo ";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(679, 165);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(113, 35);
            btnHuyBo.TabIndex = 20;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXacNhan
            // 
            btnXacNhan.Location = new Point(560, 165);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(113, 35);
            btnXacNhan.TabIndex = 19;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnSuaDiem
            // 
            btnSuaDiem.Location = new Point(441, 165);
            btnSuaDiem.Name = "btnSuaDiem";
            btnSuaDiem.Size = new Size(113, 35);
            btnSuaDiem.TabIndex = 18;
            btnSuaDiem.Text = "Sửa điểm";
            btnSuaDiem.UseVisualStyleBackColor = true;
            btnSuaDiem.Click += btnSuaDiem_Click;
            // 
            // numDiemThiThu
            // 
            numDiemThiThu.Location = new Point(642, 117);
            numDiemThiThu.Name = "numDiemThiThu";
            numDiemThiThu.Size = new Size(150, 27);
            numDiemThiThu.TabIndex = 16;
            numDiemThiThu.ValueChanged += numDiemThiThu_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(441, 124);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 14;
            label1.Text = "Điểm thi thử:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(441, 76);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 13;
            label5.Text = "Họ và tên: ";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(527, 74);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(265, 27);
            txtHoVaTen.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 28);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 11;
            label4.Text = "Mã số: ";
            // 
            // txtMaSo
            // 
            txtMaSo.Location = new Point(527, 26);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(265, 27);
            txtMaSo.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 77);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 9;
            label3.Text = "Lớp học: ";
            // 
            // cbbLopHoc
            // 
            cbbLopHoc.FormattingEnabled = true;
            cbbLopHoc.Location = new Point(95, 77);
            cbbLopHoc.Name = "cbbLopHoc";
            cbbLopHoc.Size = new Size(214, 28);
            cbbLopHoc.TabIndex = 8;
            cbbLopHoc.SelectedIndexChanged += cbbLopHoc_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 29);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 7;
            label2.Text = "Khóa học: ";
            // 
            // cbbKhoaHoc
            // 
            cbbKhoaHoc.FormattingEnabled = true;
            cbbKhoaHoc.Location = new Point(95, 29);
            cbbKhoaHoc.Name = "cbbKhoaHoc";
            cbbKhoaHoc.Size = new Size(214, 28);
            cbbKhoaHoc.TabIndex = 6;
            cbbKhoaHoc.SelectedIndexChanged += cbbKhoaHoc_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 217);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1169, 524);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách học viên của lớp";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaSo, HoVaTen, DiemThiThu });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1163, 498);
            dataGridView.TabIndex = 0;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // MaSo
            // 
            MaSo.DataPropertyName = "MaSo";
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
            // DiemThiThu
            // 
            DiemThiThu.DataPropertyName = "DiemThiThu";
            DiemThiThu.HeaderText = "Điểm thi thử";
            DiemThiThu.MinimumWidth = 6;
            DiemThiThu.Name = "DiemThiThu";
            // 
            // frmDiemSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 741);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDiemSo";
            Text = "frmDiemSo";
            Load += frmDiemSo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDiemThiThu).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Label label3;
        private ComboBox cbbLopHoc;
        private Label label2;
        private ComboBox cbbKhoaHoc;
        private Button btnXacNhan;
        private Button btnSuaDiem;
        private NumericUpDown numDiemThiThu;
        private Label label1;
        private Label label5;
        private TextBox txtHoVaTen;
        private Label label4;
        private TextBox txtMaSo;
        private Button btnHuyBo;
        private DataGridViewTextBoxColumn MaSo;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DiemThiThu;
    }
}