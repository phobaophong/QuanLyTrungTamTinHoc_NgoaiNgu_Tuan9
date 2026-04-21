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

        int quyenHanDangNhap;
        int idNguoiDung;

        public frmThoiKhoaBieu(int quyenHan, int idDangNhap)
        {
            InitializeComponent();

            quyenHanDangNhap = quyenHan;
            idNguoiDung = idDangNhap;

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

            btnTaoTKB.Visible = false;
            grbTaoTKB.Visible = false;
            btnXacNhan.Enabled = false;

            if (quyenHanDangNhap == 2 || quyenHanDangNhap == 3)
            {
                btnTaoTKB.Visible = false;
                btnXacNhan.Visible = false;
                btnHuyBo.Visible = false;
            }

            if (quyenHanDangNhap == 3)
            {
                cbbKhoaHoc.Enabled = false;
                cbbLopHoc.Enabled = false;

                if (cbbLopHoc.SelectedValue is int idLop && cbbTuan.SelectedItem is ItemTuan tuan)
                {
                    LoadData(tuan.TuNgay, tuan.DenNgay, idLop);
                }
            }
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
                .Include(l => l.GiangVien)
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
                ngayChay = ngayChay.AddDays(-1);

            int count = 1;

            while (ngayChay <= lop.NgayKetThuc)
            {
                dsTuan.Add(new ItemTuan
                {
                    SoTuan = count++,
                    TuNgay = ngayChay,
                    DenNgay = ngayChay.AddDays(6)
                });

                ngayChay = ngayChay.AddDays(7);
            }

            // Đảo ngược thứ tự DataSource xuống dưới cùng để tránh lỗi mất hiển thị
            cbbTuan.DisplayMember = "TenHienThi";
            cbbTuan.DataSource = dsTuan;

            if (dsTuan.Count > 0)
                cbbTuan.SelectedIndex = 0;
        }

        private void LoadCbbKhoaHoc()
        {
            context = new QuanLyTrungTamContext();
            var khQuery = context.KhoaHoc.AsQueryable();

            if (quyenHanDangNhap == 3) // Kiểm tra xem học viên học khóa nào
            {
                var dsKhoaHocCuaHocVien = context.HocPhi
                    .Where(hp => hp.HocVienID == idNguoiDung && hp.LopHoc.TrangThai == true)
                    .Select(hp => hp.LopHoc.KhoaHocID)
                    .Distinct()
                    .ToList();

                khQuery = khQuery.Where(k => dsKhoaHocCuaHocVien.Contains(k.ID));
            }

            var list = khQuery.ToList();

            // Đảo ngược thứ tự DataSource xuống dưới cùng
            cbbKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbbKhoaHoc.ValueMember = "ID";
            cbbKhoaHoc.DataSource = list;

            if (list.Count > 0)
                cbbKhoaHoc.SelectedIndex = 0;
        }

        private void LoadCbbLopHoc(int idKhoa)
        {
            var lopQuery = context.LopHoc.Where(x => x.KhoaHocID == idKhoa).AsQueryable();

            if (quyenHanDangNhap == 3) // Lọc lớp của học viên
            {
                var dsLop = context.HocPhi
                    .Where(hp => hp.HocVienID == idNguoiDung)
                    .Select(hp => hp.LopHocID)
                    .ToList();

                lopQuery = lopQuery.Where(l => dsLop.Contains(l.ID) && l.TrangThai == true);
            }

            var list = lopQuery.ToList();

            // Đảo ngược thứ tự DataSource xuống dưới cùng
            cbbLopHoc.DisplayMember = "TenLopHoc";
            cbbLopHoc.ValueMember = "ID";
            cbbLopHoc.DataSource = list;

            if (list.Count > 0)
                cbbLopHoc.SelectedIndex = 0;
        }

        private void LoadCbbPhongHoc()
        {
            cbbPhongHoc.DisplayMember = "TenPhong";
            cbbPhongHoc.ValueMember = "ID";
            cbbPhongHoc.DataSource = context.PhongHoc.ToList();
        }

        private void LoadCbbCaHoc()
        {
            var dsCaHoc = context.CaHoc.ToList()
                .Select(c => new
                {
                    ID = c.ID,
                    HienThi = $"{c.GioBatDau:hh\\:mm} - {c.GioKetThuc:hh\\:mm}"
                }).ToList();

            cbbCaHoc.DisplayMember = "HienThi";
            cbbCaHoc.ValueMember = "ID";
            cbbCaHoc.DataSource = dsCaHoc;
        }

        private void LoadCbbGiangVien(string boPhan)
        {
            context = new QuanLyTrungTamContext();

            var listGV = context.GiangVien
                                .Where(g => g.BoPhan == boPhan)
                                .ToList();

            cbbGiangVien.DisplayMember = "HoVaTen";
            cbbGiangVien.ValueMember = "ID";
            cbbGiangVien.DataSource = listGV;
            cbbGiangVien.SelectedIndex = -1;
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
                context = new QuanLyTrungTamContext();
                bool daCoLich = context.LichHoc.Any(l => l.LopHocID == idLop);

                // Khóa bảo vệ kép: Chỉ Admin/Nhân viên mới thấy nút Tạo, và Lớp đó chưa có lịch
                btnTaoTKB.Visible = (quyenHanDangNhap == 1 || quyenHanDangNhap == 4) && !daCoLich;

                grbTaoTKB.Visible = false;

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

            // Auto check RadioButton
            if (rdoLocTiengAnh.Checked)
            {
                LoadCbbGiangVien("Tiếng Anh");
            }
            else
            {
                rdoLocTinHoc.Checked = true;
                LoadCbbGiangVien("Tin học");
            }
            LoadCbbPhongHoc();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmThoiKhoaBieu_Load(sender, e);
        }

        public void TaoLich(List<DayOfWeek> dsThuChon)
        {
            if (cbbLopHoc.SelectedValue == null)
            {
                MessageBox.Show("Hệ thống chưa tải xong Lớp học. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbCaHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Ca học để xếp lịch!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbCaHoc.Focus();
                return;
            }
            if (cbbPhongHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Phòng học trước khi tạo lịch!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbPhongHoc.Focus();
                return;
            }
            if (cbbGiangVien.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Giảng viên phụ trách lớp này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbGiangVien.Focus();
                return;
            }

            try
            {
                int idLop = (int)cbbLopHoc.SelectedValue;
                var lop = context.LopHoc
                    .Include(l => l.KhoaHoc)
                    .FirstOrDefault(l => l.ID == idLop);

                if (lop == null || lop.KhoaHoc == null) return;

                int tongSoBuoi = lop.KhoaHoc.ThoiLuong;
                DateTime ngayChay = lop.NgayBatDau.Date;

                int idCa = (int)cbbCaHoc.SelectedValue;
                int idPhong = (int)cbbPhongHoc.SelectedValue;
                int idGiangVien = (int)cbbGiangVien.SelectedValue;

                List<LichHoc> danhSachDuKien = new List<LichHoc>();
                List<string> thongBaoLoi = new List<string>();
                int soBuoiDaKiemTra = 0;

                while (soBuoiDaKiemTra < tongSoBuoi)
                {
                    if (dsThuChon.Contains(ngayChay.DayOfWeek))
                    {
                        bool biTrungLich = context.LichHoc.Any(l =>
                            l.NgayHoc.Date == ngayChay.Date &&
                            l.CaHocID == idCa &&
                            (l.PhongHocID == idPhong || l.GiangVienID == idGiangVien || l.LopHocID == idLop));

                        if (biTrungLich)
                        {
                            thongBaoLoi.Add($"- Ngày {ngayChay:dd/MM/yyyy}: Kẹt Phòng hoặc Giảng viên");
                        }
                        else
                        {
                            danhSachDuKien.Add(new LichHoc
                            {
                                LopHocID = idLop,
                                CaHocID = idCa,
                                PhongHocID = idPhong,
                                GiangVienID = idGiangVien,
                                NgayHoc = ngayChay
                            });
                        }

                        soBuoiDaKiemTra++;
                    }
                    ngayChay = ngayChay.AddDays(1);
                }

                if (thongBaoLoi.Count > 0)
                {
                    string msg = "Tạo lịch THẤT BẠI!\nPhát hiện xung đột tài nguyên trong khoảng thời gian dự kiến.\nVui lòng chọn Ca học, Phòng học hoặc Giảng viên khác.\n\nChi tiết các ngày bị trùng:\n" + string.Join("\n", thongBaoLoi);
                    MessageBox.Show(msg, "Trùng lịch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    context.LichHoc.AddRange(danhSachDuKien);
                    context.SaveChanges();

                    btnTaoTKB.Visible = false;
                    grbTaoTKB.Visible = false;

                    MessageBox.Show($"Đã tạo thành công toàn bộ {tongSoBuoi} buổi học!\nLịch bắt đầu từ {lop.NgayBatDau:dd/MM/yyyy} đến {danhSachDuKien.Last().NgayHoc:dd/MM/yyyy}.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (cbbTuan.SelectedItem is ItemTuan tuan)
                        LoadData(tuan.TuNgay, tuan.DenNgay, idLop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình xếp lịch: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void rdoLocTinHoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLocTinHoc.Checked)
            {
                LoadCbbGiangVien("Tin học");
            }
        }

        private void rdoLocTiengAnh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLocTiengAnh.Checked)
            {
                LoadCbbGiangVien("Tiếng Anh");
            }
        }
    }
}