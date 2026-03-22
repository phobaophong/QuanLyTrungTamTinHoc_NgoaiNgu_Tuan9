using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class QuanLyTrungTamContext : DbContext
    {
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<HocVien> HocVien { get; set; }
        public DbSet<GiangVien> GiangVien { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhoaHoc> KhoaHoc { get; set; }
        public DbSet<LopHoc> LopHoc { get; set; }
        public DbSet<PhongHoc> PhongHoc { get; set; }
        public DbSet<CaHoc> CaHoc { get; set; }
        public DbSet<LichHoc> LichHoc { get; set; }
        public DbSet<KetQua> KetQua { get; set; }
        public DbSet<HocPhi> HocPhi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLTTConnection"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Chống trùng tên đăng nhập
            modelBuilder.Entity<TaiKhoan>().HasIndex(tk => tk.TenDN).IsUnique();

            // Chống trùng lịch: 1 Phòng - 1 Ca - 1 Ngày
            modelBuilder.Entity<LichHoc>().HasIndex(lh => new { lh.PhongHocID, lh.CaHocID, lh.NgayHoc }).IsUnique();

            // Chống trùng lịch: 1 Giảng viên - 1 Ca - 1 Ngày
            modelBuilder.Entity<LichHoc>().HasIndex(lh => new { lh.GiangVienID, lh.CaHocID, lh.NgayHoc }).IsUnique();

            // Chống trùng lịch: 1 Lớp - 1 Ca - 1 Ngày
            modelBuilder.Entity<LichHoc>().HasIndex(lh => new { lh.LopHocID, lh.CaHocID, lh.NgayHoc }).IsUnique();

        }
    }
}
