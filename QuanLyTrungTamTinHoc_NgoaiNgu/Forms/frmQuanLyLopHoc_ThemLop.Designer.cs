namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmQuanLyLopHoc_ThemLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyLopHoc_ThemLop));
            groupBox1 = new GroupBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            numSiSo = new NumericUpDown();
            label5 = new Label();
            cbbKhoaHoc = new ComboBox();
            rdoDaDong = new RadioButton();
            rdoDangMo = new RadioButton();
            dtpNgayKetThuc = new DateTimePicker();
            dtpNgayBatDau = new DateTimePicker();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtTenLopHoc = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSiSo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(numSiSo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbbKhoaHoc);
            groupBox1.Controls.Add(rdoDaDong);
            groupBox1.Controls.Add(rdoDangMo);
            groupBox1.Controls.Add(dtpNgayKetThuc);
            groupBox1.Controls.Add(dtpNgayBatDau);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtTenLopHoc);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.2F);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 420);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin lớp học";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(12, 238);
            label6.Name = "label6";
            label6.Size = new Size(71, 23);
            label6.TabIndex = 37;
            label6.Text = "Sĩ số (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(12, 194);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 27;
            label4.Text = "Trạng thái (*):";
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
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 128, 0);
            btnThoat.Font = new Font("Segoe UI", 10.2F);
            btnThoat.Location = new Point(367, 343);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(129, 39);
            btnThoat.TabIndex = 44;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(224, 224, 224);
            btnHuyBo.Font = new Font("Segoe UI", 10.2F);
            btnHuyBo.Location = new Point(193, 343);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(129, 39);
            btnHuyBo.TabIndex = 43;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(0, 192, 0);
            btnLuu.Font = new Font("Segoe UI", 10.2F);
            btnLuu.ForeColor = Color.Black;
            btnLuu.Location = new Point(21, 343);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 39);
            btnLuu.TabIndex = 42;
            btnLuu.Text = "Xác nhận";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // numSiSo
            // 
            numSiSo.Location = new Point(178, 236);
            numSiSo.Name = "numSiSo";
            numSiSo.Size = new Size(102, 30);
            numSiSo.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(12, 285);
            label5.Name = "label5";
            label5.Size = new Size(108, 23);
            label5.TabIndex = 36;
            label5.Text = "Khóa học (*):";
            // 
            // cbbKhoaHoc
            // 
            cbbKhoaHoc.FormattingEnabled = true;
            cbbKhoaHoc.Location = new Point(178, 282);
            cbbKhoaHoc.Name = "cbbKhoaHoc";
            cbbKhoaHoc.Size = new Size(326, 31);
            cbbKhoaHoc.TabIndex = 35;
            cbbKhoaHoc.SelectedIndexChanged += cbbKhoaHoc_SelectedIndexChanged;
            // 
            // rdoDaDong
            // 
            rdoDaDong.AutoSize = true;
            rdoDaDong.Location = new Point(313, 192);
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
            rdoDangMo.Location = new Point(178, 192);
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
            dtpNgayKetThuc.Size = new Size(177, 30);
            dtpNgayKetThuc.TabIndex = 32;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            dtpNgayBatDau.Format = DateTimePickerFormat.Custom;
            dtpNgayBatDau.Location = new Point(178, 92);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(177, 30);
            dtpNgayBatDau.TabIndex = 31;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(1290, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(253, 165);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(2330, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 165);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // txtTenLopHoc
            // 
            txtTenLopHoc.Font = new Font("Segoe UI", 10.2F);
            txtTenLopHoc.Location = new Point(178, 46);
            txtTenLopHoc.Name = "txtTenLopHoc";
            txtTenLopHoc.Size = new Size(326, 30);
            txtTenLopHoc.TabIndex = 15;
            // 
            // frmQuanLyLopHoc_ThemLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 420);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmQuanLyLopHoc_ThemLop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuanLyLopHoc_ThemLop";
            Load += frmQuanLyLopHoc_ThemLop_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSiSo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdoDaDong;
        private RadioButton rdoDangMo;
        private DateTimePicker dtpNgayKetThuc;
        private DateTimePicker dtpNgayBatDau;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtTenLopHoc;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private ComboBox cbbKhoaHoc;
        private Label label6;
        private NumericUpDown numSiSo;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
    }
}