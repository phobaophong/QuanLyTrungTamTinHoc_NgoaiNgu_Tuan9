using QuanLyTrungTamTinHoc_NgoaiNgu.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmQuanLyLopHoc_ThemLop : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        int id;
        List<int> danhSachAutoImport = new List<int>();
        public frmQuanLyLopHoc_ThemLop(int idLop, List<int> dsImport = null)
        {
            InitializeComponent();

            id = idLop;

            danhSachAutoImport = dsImport;

            Models.Utils.GiaoDien.ApDungGiaoDien(this);
        }

        private void LoadKhoaHoc()
        {
            var kh = context.KhoaHoc.ToList();

            cbbKhoaHoc.DataSource = kh;
            cbbKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbbKhoaHoc.ValueMember = "ID";
        }
        private void TinhNgayKetThuc()
        {
            if (cbbKhoaHoc.SelectedValue != null && int.TryParse(cbbKhoaHoc.SelectedValue.ToString(), out int idKH))
            {
                var thoiLuong = context.KhoaHoc.Where(k => k.ID == idKH).Select(k => k.ThoiLuong).FirstOrDefault();
                if (thoiLuong > 0)
                {
                    int soTuan = (int)Math.Ceiling((double)thoiLuong / 3.0);
                    dtpNgayKetThuc.Value = dtpNgayBatDau.Value.AddDays(soTuan * 7);
                }
            }
        }
        private void frmQuanLyLopHoc_ThemLop_Load(object sender, EventArgs e)
        {
            LoadKhoaHoc();

            if (id == 0) // Trạng thái Thêm Mới
            {
                this.Text = "Thêm Lớp Học Mới";
                txtTenLopHoc.Clear();
                dtpNgayBatDau.Value = DateTime.Now;
                dtpNgayKetThuc.Enabled = false;

                rdoDangMo.Checked = true;
                rdoDaDong.Checked = false;

                numSiSo.Value = 1;
            }
            else
            {
                this.Text = "Cập Nhật Thông Tin Lớp Học";

                var lop = context.LopHoc.Find(id);

                if (lop != null)
                {
                    txtTenLopHoc.Text = lop.TenLopHoc;
                    numSiSo.Value = lop.SiSo;

                    if (lop.TrangThai == true)
                        rdoDangMo.Checked = true;
                    else
                        rdoDaDong.Checked = true;

                    dtpNgayBatDau.Value = lop.NgayBatDau;
                    dtpNgayKetThuc.Value = lop.NgayKetThuc;
                    dtpNgayKetThuc.Enabled = true;

                    cbbKhoaHoc.SelectedValue = lop.KhoaHocID;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin lớp học trong CSDL!");
                    this.Close();
                }

                TinhNgayKetThuc();
            }
        }

        private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhNgayKetThuc();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // check data
                if (string.IsNullOrWhiteSpace(txtTenLopHoc.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên lớp học!");
                    txtTenLopHoc.Focus();
                    return;
                }

                if (dtpNgayKetThuc.Value < dtpNgayBatDau.Value)
                {
                    MessageBox.Show("Ngày kết thúc phải >= ngày bắt đầu!");
                    return;
                }

                if (numSiSo.Value <= 0)
                {
                    MessageBox.Show("Sĩ số phải > 0!");
                    return;
                }

                if (!int.TryParse(cbbKhoaHoc.SelectedValue?.ToString(), out int idKhoaHoc))
                {
                    MessageBox.Show("Vui lòng chọn khóa học!");
                    return;
                }

                // Kiểm tra trùng tên (Bỏ qua chính nó nếu đang ở chế độ Sửa)
                bool exists = context.LopHoc.Any(l => l.TenLopHoc == txtTenLopHoc.Text.Trim() && l.ID != id);
                if (exists)
                {
                    MessageBox.Show("Tên lớp đã tồn tại!");
                    return;
                }

                var thoiLuong = context.KhoaHoc
                    .Where(k => k.ID == idKhoaHoc)
                    .Select(k => k.ThoiLuong)
                    .FirstOrDefault();

                int soTuan = (int)Math.Ceiling(thoiLuong / 3.0);
                DateTime ngayKetThucDuKien = dtpNgayBatDau.Value.AddDays(soTuan * 7);

                if (dtpNgayKetThuc.Value < ngayKetThucDuKien)
                {
                    MessageBox.Show(
                        $"Ngày kết thúc chưa hợp lý!\n" +
                        $"Khóa học {thoiLuong} buổi (~{soTuan} tuần).\n" +
                        $"Nên kết thúc sau: {ngayKetThucDuKien:dd/MM/yyyy}"
                    );
                    return;
                }

                if (id == 0) // thêm
                {
                    LopHoc lop = new LopHoc
                    {
                        TenLopHoc = txtTenLopHoc.Text.Trim(),
                        NgayBatDau = dtpNgayBatDau.Value,
                        NgayKetThuc = dtpNgayKetThuc.Value,
                        TrangThai = rdoDangMo.Checked,
                        KhoaHocID = idKhoaHoc,
                        SiSo = (int)numSiSo.Value
                    };

                    context.LopHoc.Add(lop);
                    context.SaveChanges(); // Lưu để lấy ID lớp mới tạo ra

                    if (danhSachAutoImport != null && danhSachAutoImport.Count > 0)
                    {
                        foreach (int idHV in danhSachAutoImport)
                        {
                            context.HocPhi.Add(new HocPhi
                            {
                                LopHocID = lop.ID,   // Mã lớp vừa tạo xong ở trên
                                HocVienID = idHV,    // Mã học viên bị rớt truyền qua từ Form Điểm Số
                                NgayDong = DateTime.Now
                            });
                        }

                        context.SaveChanges(); // Lưu danh sách học viên vào Database

                        MessageBox.Show($"Thêm lớp học thành công và đã tự động ghi danh {danhSachAutoImport.Count} học viên vào lớp này!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm lớp học thành công!");
                    }
                }
                else // sửa
                {
                    var lopEdit = context.LopHoc.Find(id);
                    if (lopEdit != null)
                    {
                        lopEdit.TenLopHoc = txtTenLopHoc.Text.Trim();
                        lopEdit.NgayBatDau = dtpNgayBatDau.Value;
                        lopEdit.NgayKetThuc = dtpNgayKetThuc.Value;
                        lopEdit.TrangThai = rdoDangMo.Checked;
                        lopEdit.KhoaHocID = idKhoaHoc;
                        lopEdit.SiSo = (int)numSiSo.Value;

                        context.SaveChanges();
                        MessageBox.Show("Cập nhật lớp học thành công!");
                    }
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình lưu: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmQuanLyLopHoc_ThemLop_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            TinhNgayKetThuc();
        }
    }
}