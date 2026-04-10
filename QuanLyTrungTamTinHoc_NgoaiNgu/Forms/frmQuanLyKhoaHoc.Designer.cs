namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmQuanLyKhoaHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKhoaHoc));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtHocPhi = new TextBox();
            txtThoiLuong = new TextBox();
            txtTenKhoaHoc = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            TenKhoaHoc = new DataGridViewTextBoxColumn();
            HocPhi = new DataGridViewTextBoxColumn();
            ThoiLuong = new DataGridViewTextBoxColumn();
            SoLopDangMo = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtHocPhi);
            groupBox1.Controls.Add(txtThoiLuong);
            groupBox1.Controls.Add(txtTenKhoaHoc);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10.2F);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1257, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khóa học";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(975, 29);
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
            // btnLuu
            // 
            btnLuu.BackColor = Color.DodgerBlue;
            btnLuu.Font = new Font("Segoe UI", 10.2F);
            btnLuu.ForeColor = Color.Black;
            btnLuu.Location = new Point(659, 41);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 39);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "Xác nhận";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
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
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtHocPhi
            // 
            txtHocPhi.Font = new Font("Segoe UI", 10.2F);
            txtHocPhi.Location = new Point(160, 95);
            txtHocPhi.Name = "txtHocPhi";
            txtHocPhi.Size = new Size(321, 30);
            txtHocPhi.TabIndex = 17;
            // 
            // txtThoiLuong
            // 
            txtThoiLuong.Font = new Font("Segoe UI", 10.2F);
            txtThoiLuong.Location = new Point(160, 144);
            txtThoiLuong.Name = "txtThoiLuong";
            txtThoiLuong.Size = new Size(321, 30);
            txtThoiLuong.TabIndex = 16;
            // 
            // txtTenKhoaHoc
            // 
            txtTenKhoaHoc.Font = new Font("Segoe UI", 10.2F);
            txtTenKhoaHoc.Location = new Point(160, 46);
            txtTenKhoaHoc.Name = "txtTenKhoaHoc";
            txtTenKhoaHoc.Size = new Size(321, 30);
            txtTenKhoaHoc.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 14;
            label3.Text = "Thời lượng (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 12;
            label2.Text = "Học phí (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 11;
            label1.Text = "Tên khóa học (*): ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 10.2F);
            groupBox2.Location = new Point(0, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1257, 522);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách các khóa học hiện tại";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, TenKhoaHoc, HocPhi, ThoiLuong, SoLopDangMo });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 26);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1251, 493);
            dataGridView.TabIndex = 0;
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
            // TenKhoaHoc
            // 
            TenKhoaHoc.DataPropertyName = "TenKhoaHoc";
            TenKhoaHoc.FillWeight = 150F;
            TenKhoaHoc.HeaderText = "Tên khóa học";
            TenKhoaHoc.MinimumWidth = 6;
            TenKhoaHoc.Name = "TenKhoaHoc";
            // 
            // HocPhi
            // 
            HocPhi.DataPropertyName = "HocPhi";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.Format = "N0";
            HocPhi.DefaultCellStyle = dataGridViewCellStyle2;
            HocPhi.HeaderText = "Học phí";
            HocPhi.MinimumWidth = 6;
            HocPhi.Name = "HocPhi";
            // 
            // ThoiLuong
            // 
            ThoiLuong.DataPropertyName = "ThoiLuong";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            ThoiLuong.DefaultCellStyle = dataGridViewCellStyle3;
            ThoiLuong.HeaderText = "Thời lượng";
            ThoiLuong.MinimumWidth = 6;
            ThoiLuong.Name = "ThoiLuong";
            // 
            // SoLopDangMo
            // 
            SoLopDangMo.DataPropertyName = "SoLopDangMo";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            SoLopDangMo.DefaultCellStyle = dataGridViewCellStyle4;
            SoLopDangMo.HeaderText = "Số lớp đang mở";
            SoLopDangMo.MinimumWidth = 6;
            SoLopDangMo.Name = "SoLopDangMo";
            // 
            // frmQuanLyKhoaHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 752);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmQuanLyKhoaHoc";
            Text = "Quản lý khóa học";
            WindowState = FormWindowState.Maximized;
            Load += frmQuanLyKhoaHoc_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtHocPhi;
        private TextBox txtThoiLuong;
        private TextBox txtTenKhoaHoc;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn TenKhoaHoc;
        private DataGridViewTextBoxColumn HocPhi;
        private DataGridViewTextBoxColumn ThoiLuong;
        private DataGridViewTextBoxColumn SoLopDangMo;
    }
}