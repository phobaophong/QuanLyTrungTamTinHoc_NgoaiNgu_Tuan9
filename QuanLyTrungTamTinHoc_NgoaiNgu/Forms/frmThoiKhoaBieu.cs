    using Microsoft.EntityFrameworkCore;
    using QuanLyTrungTamTinHoc_NgoaiNgu.Data;
    using QuanLyTrungTamTinHoc_NgoaiNgu.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmThoiKhoaBieu : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();

        public frmThoiKhoaBieu()
        {
            InitializeComponent();

            Models.Utils.GiaoDien.ApDungGiaoDien(this);
        }

        private void frmThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Rows.Clear();

            for (int i = 1; i <= 4; i++)
            {
                int rowIndex = dataGridView.Rows.Add();
                dataGridView.Rows[rowIndex].Cells["colCa"].Value = "Ca " + i;
                dataGridView.Rows[rowIndex].Height = 90;
            }

            LoadCbbKhoaHoc();

            grbTaoTKB.Visible = false;
            btnXacNhan.Enabled = false;

        }
        public void LoadData(DateTime tuNgay, DateTime denNgay, int idLop)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < dataGridView.Columns.Count; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = "";
                    dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }

            DateTime start = tuNgay.Date;
            DateTime end = denNgay.Date.AddDays(1).AddTicks(-1);

            var dsLichHoc = context.LichHoc
                .Include(l => l.PhongHoc)
                .Include(l => l.GiangVien) // Nếu muốn hiện tên GV
                .Where(l => l.LopHocID == idLop
                         && l.NgayHoc >= start
                         && l.NgayHoc <= end)
                .ToList();


            foreach (var lich in dsLichHoc)
            {
                string tenCot = "";
                switch (lich.NgayHoc.DayOfWeek)
                {
                    case DayOfWeek.Monday: tenCot = "colThu2"; break;
                    case DayOfWeek.Tuesday: tenCot = "colThu3"; break;
                    case DayOfWeek.Wednesday: tenCot = "colThu4"; break;
                    case DayOfWeek.Thursday: tenCot = "colThu5"; break;
                    case DayOfWeek.Friday: tenCot = "colThu6"; break;
                    case DayOfWeek.Saturday: tenCot = "colThu7"; break;
                    case DayOfWeek.Sunday: tenCot = "colChuNhat"; break;
                }



                int indexDong = lich.CaHocID - 1;

                if (indexDong >= 0 && indexDong < 4 && !string.IsNullOrEmpty(tenCot))
                {

                    if (dataGridView.Columns.Contains(tenCot))
                    {
                        var cell = dataGridView.Rows[indexDong].Cells[tenCot];

                        cell.Value = $"Phòng: {lich.PhongHoc?.TenPhong}{Environment.NewLine}GV: {lich.GiangVien?.HoVaTen}";

                        cell.Style.BackColor = Color.FromArgb(0, 120, 215);
                        cell.Style.ForeColor = Color.White;
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
            }

            dataGridView.ClearSelection();
        }

        private void LoadTuan(int idLop)
        {
            var lop = context.LopHoc.Find(idLop);
            if (lop == null || lop.NgayBatDau == null || lop.NgayKetThuc == null) return;

            List<ItemTuan> dsTuan = new List<ItemTuan>();
            DateTime ngayChay = lop.NgayBatDau;

            while (ngayChay.DayOfWeek != DayOfWeek.Monday)
            {
                ngayChay = ngayChay.AddDays(-1);
            }

            int countTuan = 1;
            while (ngayChay <= lop.NgayKetThuc)
            {
                dsTuan.Add(new ItemTuan
                {
                    SoTuan = countTuan++,
                    TuNgay = ngayChay,
                    DenNgay = ngayChay.AddDays(6)
                });
                ngayChay = ngayChay.AddDays(7);
            }

            cbbTuan.DataSource = dsTuan;
            cbbTuan.DisplayMember = "TenHienThi";
        }

        private void LoadCbbKhoaHoc()
        {
            var kh = context.KhoaHoc.ToList();
            cbbKhoaHoc.DataSource = kh;
            cbbKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbbKhoaHoc.ValueMember = "ID";
        }

        private void LoadCbbLopHoc(int idKhoa)
        {
            var lop = context.LopHoc.Where(x => x.KhoaHocID == idKhoa).ToList();
            cbbLopHoc.DataSource = lop;
            cbbLopHoc.DisplayMember = "TenLopHoc";
            cbbLopHoc.ValueMember = "ID";
        }

        private void LoadCbbPhongHoc()
        {
            cbbPhongHoc.DataSource = context.PhongHoc.ToList();
            cbbPhongHoc.DisplayMember = "TenPhong";
            cbbPhongHoc.ValueMember = "ID";
        }

        private void LoadCbbCaHoc()
        {
            var dsCaHoc = context.CaHoc.ToList()
                .Select(c => new
                {
                    ID = c.ID,
                    HienThi = $"{c.GioBatDau:hh\\:mm} - {c.GioKetThuc:hh\\:mm}"
                }).ToList();

            cbbCaHoc.DataSource = dsCaHoc;
            cbbCaHoc.DisplayMember = "HienThi";
            cbbCaHoc.ValueMember = "ID";
        }

        private void LoadCbbGiangVien()
        {
            cbbGiangVien.DataSource = context.GiangVien.ToList();
            cbbGiangVien.DisplayMember = "HoVaTen";
            cbbGiangVien.ValueMember = "ID";
        }



        private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhoaHoc.SelectedValue is int idKhoa)
            {
                LoadCbbLopHoc(idKhoa);
            }
        }

        private void cbbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLopHoc.SelectedValue is int idLop)
            {
                LoadTuan(idLop);

                if (cbbTuan.SelectedItem is ItemTuan tuan)
                {
                    LoadData(tuan.TuNgay, tuan.DenNgay, idLop);
                }
            }

        }

        private void btnTaoTKB_Click(object sender, EventArgs e)
        {
            grbTaoTKB.Visible = true;
            btnXacNhan.Enabled = true;
            LoadCbbCaHoc();
            LoadCbbGiangVien();
            LoadCbbPhongHoc();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmThoiKhoaBieu_Load(sender, e);
        }


        public void TaoLich(List<DayOfWeek> dsThuChon)
        {
            try
            {
                int idLop = (int)cbbLopHoc.SelectedValue;
                var lop = context.LopHoc
                    .Include(l => l.KhoaHoc)
                    .FirstOrDefault(l => l.ID == idLop);

                if (lop == null || lop.KhoaHoc == null) return;

                int tongSoBuoi = lop.KhoaHoc.ThoiLuong;
                int soBuoiDaXep = 0;
                DateTime ngayChay = lop.NgayBatDau.Date;

                int idCa = (int)cbbCaHoc.SelectedValue;
                int idPhong = (int)cbbPhongHoc.SelectedValue;
                int idGiangVien = (int)cbbGiangVien.SelectedValue;
                List<string> thongBaoLoi = new List<string>();

                while (soBuoiDaXep < tongSoBuoi)
                {
                    if (dsThuChon.Contains(ngayChay.DayOfWeek))
                    {
                        // Kiểm tra trùng lịch trước khi Add
                        bool biTrungLich = context.LichHoc.Any(l =>
                            l.NgayHoc.Date == ngayChay.Date &&
                            l.CaHocID == idCa &&
                            (l.PhongHocID == idPhong || l.GiangVienID == idGiangVien || l.LopHocID == idLop));

                        if (!biTrungLich)
                        {
                            context.LichHoc.Add(new LichHoc
                            {
                                LopHocID = idLop,
                                CaHocID = idCa,
                                PhongHocID = idPhong,
                                GiangVienID = idGiangVien,
                                NgayHoc = ngayChay
                            });
                            soBuoiDaXep++;
                        }
                        else
                        {
                            thongBaoLoi.Add($"- Ngày {ngayChay:dd/MM/yyyy}: Trùng Phòng/GV/Lớp");
                        }
                    }
                    ngayChay = ngayChay.AddDays(1);
                    if (ngayChay > lop.NgayBatDau.AddYears(1)) break; // Tránh lặp vô hạn
                }

                if (soBuoiDaXep > 0) context.SaveChanges(); // Lưu vào DB

                // Thông báo kết quả
                string msg = $"Đã tạo xong {soBuoiDaXep}/{tongSoBuoi} buổi học!";
                if (thongBaoLoi.Count > 0)
                    MessageBox.Show(msg + "\n\nKhông thể xếp lịch các ngày sau:\n" + string.Join("\n", thongBaoLoi), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(msg, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Load lại Grid
                if (cbbTuan.SelectedItem is ItemTuan tuan)
                    LoadData(tuan.TuNgay, tuan.DenNgay, idLop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {
            List<DayOfWeek> dsThuChon = new List<DayOfWeek>();

            if (chk246.Checked)
            {
                dsThuChon.Add(DayOfWeek.Monday);
                dsThuChon.Add(DayOfWeek.Wednesday);
                dsThuChon.Add(DayOfWeek.Friday);
            }

            if (chk357.Checked)
            {
                dsThuChon.Add(DayOfWeek.Tuesday);
                dsThuChon.Add(DayOfWeek.Thursday);
                dsThuChon.Add(DayOfWeek.Saturday);
            }

            if (dsThuChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một lịch học (2-4-6 hoặc 3-5-7)!");
                return;
            }

            TaoLich(dsThuChon);
        }

        private void cbbTuan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbbTuan.SelectedItem is ItemTuan tuan && cbbLopHoc.SelectedValue is int idLop)
            {
                LoadData(tuan.TuNgay, tuan.DenNgay, idLop);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
