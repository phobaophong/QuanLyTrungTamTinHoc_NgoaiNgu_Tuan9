namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuQuanLyKhoaHoc = new ToolStripMenuItem();
            mnuQuanLyLopHoc = new ToolStripMenuItem();
            mnuQuanLyHocVien = new ToolStripMenuItem();
            mnuQuanLyNhanSu = new ToolStripMenuItem();
            mnuQuanLyHocPhi = new ToolStripMenuItem();
            mnuQuanLyDiemSo = new ToolStripMenuItem();
            mnuQuanLyDoanhThu = new ToolStripMenuItem();
            mnuXemTKB = new ToolStripMenuItem();
            lịchHọcToolStripMenuItem = new ToolStripMenuItem();
            mnuHocPhi = new ToolStripMenuItem();
            mnuTraCuuDiemThiThu = new ToolStripMenuItem();
            mnuTraCuuTTCN = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 10.2F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuXemTKB, mnuHocPhi });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1184, 31);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, mnuThoat });
            mnuHeThong.Font = new Font("Segoe UI", 10.2F);
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(96, 27);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Font = new Font("Segoe UI", 10.2F);
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(224, 28);
            mnuDangNhap.Text = "Đăng nhập";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Font = new Font("Segoe UI", 10.2F);
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(224, 28);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Font = new Font("Segoe UI", 10.2F);
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(224, 28);
            mnuDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // mnuThoat
            // 
            mnuThoat.Font = new Font("Segoe UI", 10.2F);
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(224, 28);
            mnuThoat.Text = "Thoát";
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuQuanLyKhoaHoc, mnuQuanLyLopHoc, mnuQuanLyHocVien, mnuQuanLyNhanSu, mnuQuanLyHocPhi, mnuQuanLyDiemSo, mnuQuanLyDoanhThu });
            mnuQuanLy.Font = new Font("Segoe UI", 10.2F);
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(83, 27);
            mnuQuanLy.Text = "Quản lý";
            // 
            // mnuQuanLyKhoaHoc
            // 
            mnuQuanLyKhoaHoc.Font = new Font("Segoe UI", 10.2F);
            mnuQuanLyKhoaHoc.Name = "mnuQuanLyKhoaHoc";
            mnuQuanLyKhoaHoc.Size = new Size(238, 28);
            mnuQuanLyKhoaHoc.Text = "Quản lý khóa học";
            mnuQuanLyKhoaHoc.Click += mnuQuanLyKhoaHoc_Click;
            // 
            // mnuQuanLyLopHoc
            // 
            mnuQuanLyLopHoc.Font = new Font("Segoe UI", 10.2F);
            mnuQuanLyLopHoc.Name = "mnuQuanLyLopHoc";
            mnuQuanLyLopHoc.Size = new Size(238, 28);
            mnuQuanLyLopHoc.Text = "Quản lý lớp học";
            mnuQuanLyLopHoc.Click += mnuQuanLyLopHoc_Click;
            // 
            // mnuQuanLyHocVien
            // 
            mnuQuanLyHocVien.Name = "mnuQuanLyHocVien";
            mnuQuanLyHocVien.Size = new Size(238, 28);
            mnuQuanLyHocVien.Text = "Quản lý học viên";
            mnuQuanLyHocVien.Click += mnuQuanLySinhVien_Click;
            // 
            // mnuQuanLyNhanSu
            // 
            mnuQuanLyNhanSu.Name = "mnuQuanLyNhanSu";
            mnuQuanLyNhanSu.Size = new Size(238, 28);
            mnuQuanLyNhanSu.Text = "Quản lý nhân sự";
            mnuQuanLyNhanSu.Click += quảnLýNhânSựToolStripMenuItem_Click;
            // 
            // mnuQuanLyHocPhi
            // 
            mnuQuanLyHocPhi.Name = "mnuQuanLyHocPhi";
            mnuQuanLyHocPhi.Size = new Size(238, 28);
            mnuQuanLyHocPhi.Text = "Quan lý học phí";
            mnuQuanLyHocPhi.Click += mnuQuanLyHocPhi_Click;
            // 
            // mnuQuanLyDiemSo
            // 
            mnuQuanLyDiemSo.Name = "mnuQuanLyDiemSo";
            mnuQuanLyDiemSo.Size = new Size(238, 28);
            mnuQuanLyDiemSo.Text = "Quản lý điểm số";
            mnuQuanLyDiemSo.Click += mnuQuanLyDiemSo_Click;
            // 
            // mnuQuanLyDoanhThu
            // 
            mnuQuanLyDoanhThu.Name = "mnuQuanLyDoanhThu";
            mnuQuanLyDoanhThu.Size = new Size(238, 28);
            mnuQuanLyDoanhThu.Text = "Quản lý doanh thu";
            mnuQuanLyDoanhThu.Click += mnuQuanLyDoanhThu_Click;
            // 
            // mnuXemTKB
            // 
            mnuXemTKB.DropDownItems.AddRange(new ToolStripItem[] { lịchHọcToolStripMenuItem });
            mnuXemTKB.Name = "mnuXemTKB";
            mnuXemTKB.Size = new Size(137, 27);
            mnuXemTKB.Text = "Thời khóa biểu";
            // 
            // lịchHọcToolStripMenuItem
            // 
            lịchHọcToolStripMenuItem.Name = "lịchHọcToolStripMenuItem";
            lịchHọcToolStripMenuItem.Size = new Size(243, 28);
            lịchHọcToolStripMenuItem.Text = "Xem thời khóa biểu";
            lịchHọcToolStripMenuItem.Click += lịchHọcToolStripMenuItem_Click;
            // 
            // mnuHocPhi
            // 
            mnuHocPhi.DropDownItems.AddRange(new ToolStripItem[] { mnuTraCuuDiemThiThu, mnuTraCuuTTCN });
            mnuHocPhi.Name = "mnuHocPhi";
            mnuHocPhi.Size = new Size(80, 27);
            mnuHocPhi.Text = "Tra cứu";
            // 
            // mnuTraCuuDiemThiThu
            // 
            mnuTraCuuDiemThiThu.Name = "mnuTraCuuDiemThiThu";
            mnuTraCuuDiemThiThu.Size = new Size(234, 28);
            mnuTraCuuDiemThiThu.Text = "Điểm thi thử";
            mnuTraCuuDiemThiThu.Click += mnuTraCuuDiemThiThu_Click;
            // 
            // mnuTraCuuTTCN
            // 
            mnuTraCuuTTCN.Name = "mnuTraCuuTTCN";
            mnuTraCuuTTCN.Size = new Size(234, 28);
            mnuTraCuuTTCN.Text = "Thông tin cá nhân";
            mnuTraCuuTTCN.Click += mnuTraCuuTTCN_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, lblLienKet });
            statusStrip1.Location = new Point(0, 581);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1184, 26);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(125, 20);
            lblTrangThai.Text = "Chưa đăng nhập. ";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(963, 20);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(81, 20);
            lblLienKet.Text = "© 2026 FIT";
            lblLienKet.Click += lblLienKet_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 607);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý trung tâm tin học";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuQuanLyKhoaHoc;
        private ToolStripMenuItem mnuQuanLyLopHoc;
        private ToolStripMenuItem mnuQuanLyHocVien;
        private ToolStripMenuItem mnuXemTKB;
        private ToolStripMenuItem lịchHọcToolStripMenuItem;
        private ToolStripMenuItem mnuHocPhi;
        private ToolStripMenuItem mnuQuanLyNhanSu;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblLienKet;
        private ToolStripMenuItem mnuQuanLyHocPhi;
        private ToolStripMenuItem mnuQuanLyDiemSo;
        private ToolStripMenuItem mnuTraCuuDiemThiThu;
        private ToolStripMenuItem mnuTraCuuTTCN;
        private ToolStripMenuItem mnuQuanLyDoanhThu;
    }
}