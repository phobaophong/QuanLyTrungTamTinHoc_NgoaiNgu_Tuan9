using Microsoft.EntityFrameworkCore;
using QuanLyTrungTamTinHoc_NgoaiNgu.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmQuanLyDiemSo : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        BindingSource bsDiem = new BindingSource();
        int idLopHocDangChon = 0;
        bool isUpdating = false;
        int quyenHanDangNhap;
        public frmQuanLyDiemSo(int quyenHan)
        {
            InitializeComponent();

            quyenHanDangNhap = quyenHan;

            Models.Utils.GiaoDien.ApDungGiaoDien(this);
        }

        private void frmQuanLyDiemSo_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            btnLuu.Enabled = false;
            txtHoVaTen.Enabled = false;
            txtMaSo.Enabled = false;
            txtTenLop.Enabled = false;
            btnTaoLopOnThi.Visible = false;

            lblHoiYKien.Visible = false;

            LoadCbbKhoaHoc();
        }
        public void LoadCbbKhoaHoc()
        {
            context = new QuanLyTrungTamContext();
            var kh = context.KhoaHoc.ToList();

            if (kh.Count > 0)
            {
                cboKhoaHoc.DataSource = kh;
                cboKhoaHoc.DisplayMember = "TenKhoaHoc";
                cboKhoaHoc.ValueMember = "ID";
            }
            else
            {
                cboKhoaHoc.DataSource = null;
                cboKhoaHoc.Text = "Chưa có khóa học";
            }
        }

        public void LoadCbbLopHoc(int idKhoa)
        {
            var lop = context.LopHoc.Where(x => x.KhoaHocID == idKhoa).ToList();

            if (lop.Count > 0)
            {
                cboLopHoc.DataSource = lop;
                cboLopHoc.DisplayMember = "TenLopHoc";
                cboLopHoc.ValueMember = "ID";
            }
            else
            {
                cboLopHoc.DataSource = null;
                cboLopHoc.Text = "Chưa có lớp học";

                bsDiem.DataSource = null;
                dataGridView.DataSource = null;
            }
        }
        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoaHoc.SelectedValue != null && cboKhoaHoc.SelectedValue is int id)
            {
                LoadCbbLopHoc(id);
            }
        }

        private void cboLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLopHoc.SelectedValue != null && cboLopHoc.SelectedValue is int id)
            {
                idLopHocDangChon = id;
                LoadData(id, null);
            }
        }
        public void LoadData(int idLop, float? locDiemThat)
        {
            var dsHocVien = context.HocVien
                .Where(hv => hv.HocPhi.Any(hp => hp.LopHocID == idLop))
                .ToList();

            var dsKetQua = context.KetQua
                .Where(k => k.LopHocID == idLop)
                .ToList();

            var lopHoc = context.LopHoc.Find(idLop);
            string tenLop = lopHoc != null ? lopHoc.TenLopHoc : "";

            var danhSachHienThi = dsHocVien.Select(hv =>
            {
                var kq = dsKetQua.FirstOrDefault(k => k.HocVienID == hv.ID);
                return new DanhSachDiemSo_ChiTiet
                {
                    ID = kq != null ? kq.ID : 0,
                    HocVienID = hv.ID,
                    MaSo = hv.MaSo,
                    HoVaTen = hv.HoVaTen,
                    LopHocID = idLop,
                    TenLop = tenLop,
                    DiemThiThu = kq?.DiemThiThu,
                    DiemThiThat = kq?.DiemThiThat
                };
            }).AsEnumerable();

            if (locDiemThat != null)
            {
                if (locDiemThat >= 5.0f)
                    danhSachHienThi = danhSachHienThi.Where(x => x.DiemThiThat >= 5.0f);
                else
                    danhSachHienThi = danhSachHienThi.Where(x => x.DiemThiThat.HasValue && x.DiemThiThat < 5.0f);
            }

            bsDiem.DataSource = new BindingList<DanhSachDiemSo_ChiTiet>(danhSachHienThi.ToList());
            dataGridView.DataSource = bsDiem;

            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                if (col.Name == "DiemThiThu" || col.Name == "DiemThiThat")
                    col.ReadOnly = false;
                else
                    col.ReadOnly = true;
            }

            btnTaoLopOnThi.Visible = (locDiemThat != null && locDiemThat < 5.0f && (quyenHanDangNhap == 1 || quyenHanDangNhap == 4));
        
        }

        private void numDiemThiThu_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && btnLuu.Enabled && !isUpdating)
                dataGridView.CurrentRow.Cells["DiemThiThu"].Value = (float)numDiemThiThu.Value;
        }


        private void numDiemThiThat_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && btnLuu.Enabled && !isUpdating)
            {
                dataGridView.CurrentRow.Cells["DiemThiThat"].Value = (float)numDiemThiThat.Value;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            var row = dataGridView.CurrentRow.DataBoundItem as DanhSachDiemSo_ChiTiet;
            if (row != null)
            {
                isUpdating = true;
                txtMaSo.Text = row.MaSo;
                txtHoVaTen.Text = row.HoVaTen;
                txtTenLop.Text = row.TenLop;

                numDiemThiThu.Value = row.DiemThiThu.HasValue ? (decimal)row.DiemThiThu.Value : 0m;
                numDiemThiThat.Value = row.DiemThiThat.HasValue ? (decimal)row.DiemThiThat.Value : 0m;

                isUpdating = false;
            }
        }

        private void btnDsTren5Diem_Click(object sender, EventArgs e)
        {
            if (idLopHocDangChon != 0) LoadData(idLopHocDangChon, 5.0f);
        }

        private void btnDsDuoi5Diem_Click(object sender, EventArgs e)
        {
            if (idLopHocDangChon != 0) LoadData(idLopHocDangChon, 4.9f);

            lblHoiYKien.Visible = true;
        }

        private void btnTaoLopOnThi_Click(object sender, EventArgs e)
        {
            List<int> dsIdHocVienRot = new List<int>();
            var dsHienThi = bsDiem.DataSource as BindingList<DanhSachDiemSo_ChiTiet>;

            if (dsHienThi != null)
            {
                foreach (var item in dsHienThi)
                {
                    dsIdHocVienRot.Add(item.HocVienID);
                }
            }

            using (frmQuanLyLopHoc_ThemLop frmThemLop = new frmQuanLyLopHoc_ThemLop(0, dsIdHocVienRot))
            {
                frmThemLop.Text = "Tạo Lớp Ôn Tập Thi Lại";
                frmThemLop.ShowDialog();
            }

            lblHoiYKien.Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dataGridView.EndEdit();
            bsDiem.EndEdit();

            var dsHienThi = bsDiem.DataSource as BindingList<DanhSachDiemSo_ChiTiet>;
            if (dsHienThi == null || idLopHocDangChon == 0) return;

            foreach (var item in dsHienThi)
            {
                if ((item.DiemThiThu.HasValue && (item.DiemThiThu < 0 || item.DiemThiThu > 10)) ||
                    (item.DiemThiThat.HasValue && (item.DiemThiThat < 0 || item.DiemThiThat > 10)))
                {
                    MessageBox.Show($"Điểm của học viên [{item.MaSo} - {item.HoVaTen}] không hợp lệ!\n\nĐiểm số phải nằm trong khoảng từ 0 đến 10. Vui lòng kiểm tra lại.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            foreach (var item in dsHienThi)
            {
                int idHV = item.HocVienID;
                int idLop = item.LopHocID;
                float? diemThiThu = item.DiemThiThu;
                float? diemThiThat = item.DiemThiThat;

                var kq = context.KetQua.FirstOrDefault(k => k.LopHocID == idLop && k.HocVienID == idHV);

                if (kq == null)
                {
                    if (diemThiThu.HasValue || diemThiThat.HasValue)
                    {
                        context.KetQua.Add(new KetQua
                        {
                            LopHocID = idLop,
                            HocVienID = idHV,
                            DiemThiThu = diemThiThu,
                            DiemThiThat = diemThiThat
                        });
                    }
                }
                else
                {
                    kq.DiemThiThu = diemThiThu;
                    kq.DiemThiThat = diemThiThat;

                    if (!kq.DiemThiThu.HasValue && !kq.DiemThiThat.HasValue)
                    {
                        context.KetQua.Remove(kq);
                    }
                }

                var hv = context.HocVien.Find(idHV);
                if (hv != null)
                {
                    if (diemThiThat.HasValue && diemThiThat.Value >= 5.0f)
                    {
                        hv.TrangThai = 3; // 3 = Đã tốt nghiệp
                    }
                    else
                    {
                        hv.TrangThai = 1; // 1 = Đang học
                    }
                }
            }

            try
            {
                context.SaveChanges();
                MessageBox.Show("Lưu điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLuu.Enabled = false;

                LoadData(idLopHocDangChon, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            if (idLopHocDangChon != 0)
                LoadData(idLopHocDangChon, null);

            btnLuu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            if (idLopHocDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn một lớp học bên bảng Bộ lọc trước khi nhập điểm từ Excel!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Nhập bảng điểm từ Excel";
            openDialog.Filter = "Tập tin Excel *.xlsx|*.xlsx";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int demThanhCong = 0;

                    using (XLWorkbook wb = new XLWorkbook(openDialog.FileName))
                    {
                        IXLWorksheet ws = wb.Worksheet(1);
                        bool isHeader = true;

                        foreach (IXLRow dong in ws.RowsUsed())
                        {
                            if (isHeader)
                            {
                                isHeader = false; 
                                continue;
                            }


                            string maSo = dong.Cell(1).Value.ToString().Trim();
                            string strDiemThu = dong.Cell(4).Value.ToString().Trim();
                            string strDiemThat = dong.Cell(5).Value.ToString().Trim();

                            if (string.IsNullOrEmpty(maSo)) continue;

                            var hocVien = context.HocVien.FirstOrDefault(hv => hv.MaSo == maSo);
                            if (hocVien == null) continue; 

                            float? diemThu = null;
                            float? diemThat = null;
                            if (float.TryParse(strDiemThu, out float dt)) diemThu = dt;
                            if (float.TryParse(strDiemThat, out float dth)) diemThat = dth;

                            if (diemThu == null && diemThat == null) continue;

                            if ((diemThu < 0 || diemThu > 10) || (diemThat < 0 || diemThat > 10))
                            {
                                MessageBox.Show($"Phát hiện điểm không hợp lệ (ngoài khoảng 0-10) tại học viên mã {maSo} trong file Excel.\n\nQuá trình nhập dữ liệu đã bị dừng lại để đảm bảo an toàn.", "Lỗi dữ liệu Excel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return; 
                            }

                            var kq = context.KetQua.FirstOrDefault(k => k.LopHocID == idLopHocDangChon && k.HocVienID == hocVien.ID);

                            if (kq == null)
                            {
                                context.KetQua.Add(new KetQua
                                {
                                    LopHocID = idLopHocDangChon,
                                    HocVienID = hocVien.ID,
                                    DiemThiThu = diemThu,
                                    DiemThiThat = diemThat
                                });
                            }
                            else
                            {
                                kq.DiemThiThu = diemThu;
                                kq.DiemThiThat = diemThat;
                            }

                            if (diemThat.HasValue && diemThat.Value >= 5.0f)
                            {
                                hocVien.TrangThai = 3; // Đã tốt nghiệp
                            }
                            else
                            {
                                hocVien.TrangThai = 1; // Đang học
                            }

                            demThanhCong++;
                        }
                    }

                    context.SaveChanges();

                    MessageBox.Show($"Đã cập nhật/thêm mới thành công điểm cho {demThanhCong} học viên!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData(idLopHocDangChon, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi đọc/ghi file Excel: " + ex.Message, "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (idLopHocDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn một lớp học để xuất danh sách điểm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenLop = cboLopHoc.Text.Trim();
            // Lọc ký tự đặc biệt để làm tên file
            foreach (char c in System.IO.Path.GetInvalidFileNameChars())
            {
                tenLop = tenLop.Replace(c.ToString(), "_");
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Xuất bảng điểm ra Excel";
            saveDialog.Filter = "Tập tin Excel *.xlsx|*.xlsx";
            saveDialog.FileName = $"BangDiem_{tenLop}_{DateTime.Now.ToString("dd_MM_yyyy")}.xlsx";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable dtDiem = new DataTable();
                    dtDiem.Columns.Add("Mã số", typeof(string));
                    dtDiem.Columns.Add("Họ và tên", typeof(string));
                    dtDiem.Columns.Add("Tên lớp", typeof(string));
                    dtDiem.Columns.Add("Điểm thi thử", typeof(string));
                    dtDiem.Columns.Add("Điểm thi thật", typeof(string));

                    var dsHienThi = bsDiem.DataSource as BindingList<DanhSachDiemSo_ChiTiet>;
                    if (dsHienThi != null)
                    {
                        foreach (var item in dsHienThi)
                        {
                            dtDiem.Rows.Add(
                                item.MaSo,
                                item.HoVaTen,
                                item.TenLop,
                                item.DiemThiThu.HasValue ? item.DiemThiThu.ToString() : "",
                                item.DiemThiThat.HasValue ? item.DiemThiThat.ToString() : ""
                            );
                        }
                    }

                    using (XLWorkbook excelWorkbook = new XLWorkbook())
                    {
                        var excelSheet = excelWorkbook.Worksheets.Add(dtDiem, "BangDiem");
                        excelSheet.Columns().AdjustToContents();
                        excelWorkbook.SaveAs(saveDialog.FileName);

                        MessageBox.Show($"Đã xuất bảng điểm lớp {tenLop} ra file Excel thành công.\nBạn có thể dùng file này để nhập điểm và Import ngược lại vào phần mềm.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
