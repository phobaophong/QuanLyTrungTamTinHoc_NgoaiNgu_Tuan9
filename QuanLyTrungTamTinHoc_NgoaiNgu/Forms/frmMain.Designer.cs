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
            mnuQuanLySinhVien = new ToolStripMenuItem();
            mnuXemTKB = new ToolStripMenuItem();
            lịchHọcToolStripMenuItem = new ToolStripMenuItem();
            lịchDạyToolStripMenuItem = new ToolStripMenuItem();
            mnuXemLichThi = new ToolStripMenuItem();
            mnuXemDiem = new ToolStripMenuItem();
            mnuHocPhi = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10.2F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, mnuXemTKB, mnuXemLichThi, mnuXemDiem, mnuHocPhi });
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
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Font = new Font("Segoe UI", 10.2F);
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(224, 28);
            mnuDangXuat.Text = "Đăng xuất";
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
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuQuanLyKhoaHoc, mnuQuanLyLopHoc, mnuQuanLySinhVien });
            mnuQuanLy.Font = new Font("Segoe UI", 10.2F);
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(86, 27);
            mnuQuanLy.Text = "Quản Lý";
            // 
            // mnuQuanLyKhoaHoc
            // 
            mnuQuanLyKhoaHoc.Font = new Font("Segoe UI", 10.2F);
            mnuQuanLyKhoaHoc.Name = "mnuQuanLyKhoaHoc";
            mnuQuanLyKhoaHoc.Size = new Size(228, 28);
            mnuQuanLyKhoaHoc.Text = "Quản lý khóa học";
            mnuQuanLyKhoaHoc.Click += mnuQuanLyKhoaHoc_Click;
            // 
            // mnuQuanLyLopHoc
            // 
            mnuQuanLyLopHoc.Font = new Font("Segoe UI", 10.2F);
            mnuQuanLyLopHoc.Name = "mnuQuanLyLopHoc";
            mnuQuanLyLopHoc.Size = new Size(228, 28);
            mnuQuanLyLopHoc.Text = "Quản lý lớp học";
            // 
            // mnuQuanLySinhVien
            // 
            mnuQuanLySinhVien.Name = "mnuQuanLySinhVien";
            mnuQuanLySinhVien.Size = new Size(228, 28);
            mnuQuanLySinhVien.Text = "Quản lý sinh viên";
            // 
            // mnuXemTKB
            // 
            mnuXemTKB.DropDownItems.AddRange(new ToolStripItem[] { lịchHọcToolStripMenuItem, lịchDạyToolStripMenuItem });
            mnuXemTKB.Name = "mnuXemTKB";
            mnuXemTKB.Size = new Size(92, 27);
            mnuXemTKB.Text = "Xem TKB";
            // 
            // lịchHọcToolStripMenuItem
            // 
            lịchHọcToolStripMenuItem.Name = "lịchHọcToolStripMenuItem";
            lịchHọcToolStripMenuItem.Size = new Size(224, 28);
            lịchHọcToolStripMenuItem.Text = "Lịch học";
            // 
            // lịchDạyToolStripMenuItem
            // 
            lịchDạyToolStripMenuItem.Name = "lịchDạyToolStripMenuItem";
            lịchDạyToolStripMenuItem.Size = new Size(224, 28);
            lịchDạyToolStripMenuItem.Text = "Lịch dạy";
            // 
            // mnuXemLichThi
            // 
            mnuXemLichThi.Name = "mnuXemLichThi";
            mnuXemLichThi.Size = new Size(114, 27);
            mnuXemLichThi.Text = "Xem lịch thi";
            // 
            // mnuXemDiem
            // 
            mnuXemDiem.Name = "mnuXemDiem";
            mnuXemDiem.Size = new Size(101, 27);
            mnuXemDiem.Text = "Xem điểm";
            // 
            // mnuHocPhi
            // 
            mnuHocPhi.Name = "mnuHocPhi";
            mnuHocPhi.Size = new Size(83, 27);
            mnuHocPhi.Text = "Học phí";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 607);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý trung tâm tin học";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private ToolStripMenuItem mnuQuanLySinhVien;
        private ToolStripMenuItem mnuXemTKB;
        private ToolStripMenuItem lịchHọcToolStripMenuItem;
        private ToolStripMenuItem lịchDạyToolStripMenuItem;
        private ToolStripMenuItem mnuXemLichThi;
        private ToolStripMenuItem mnuHocPhi;
        private ToolStripMenuItem mnuXemDiem;
    }
}