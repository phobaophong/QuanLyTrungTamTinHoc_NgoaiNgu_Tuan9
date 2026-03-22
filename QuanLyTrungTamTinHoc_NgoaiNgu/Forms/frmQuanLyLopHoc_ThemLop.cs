using QuanLyTrungTamTinHoc_NgoaiNgu.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmQuanLyLopHoc_ThemLop : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();

        public frmQuanLyLopHoc_ThemLop()
        {
            InitializeComponent();
        }

        private void LoadKhoaHoc()
        {
            var kh = context.KhoaHoc.ToList();

            cbbKhoaHoc.DataSource = kh;
            cbbKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbbKhoaHoc.ValueMember = "ID";
        }

        private void frmQuanLyLopHoc_ThemLop_Load(object sender, EventArgs e)
        {
            LoadKhoaHoc();

            txtTenLopHoc.Clear();
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            dtpNgayKetThuc.Enabled = false;

            rdoDangMo.Checked = true;
            rdoDaDong.Checked = false;

            numSiSo.Value = 1;

            txtTenLopHoc.Focus();
        }

        private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhoaHoc.SelectedValue != null &&
                int.TryParse(cbbKhoaHoc.SelectedValue.ToString(), out int idKH))
            {
                var thoiLuong = context.KhoaHoc
                    .Where(k => k.ID == idKH)
                    .Select(k => k.ThoiLuong)
                    .FirstOrDefault();

                if (thoiLuong > 0)
                {
                    int soTuan = (int)Math.Ceiling(thoiLuong / 3.0);
                    dtpNgayKetThuc.Value = dtpNgayBatDau.Value.AddDays(soTuan * 7);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
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

                bool exists = context.LopHoc
                    .Any(l => l.TenLopHoc == txtTenLopHoc.Text);

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
                context.SaveChanges();

                MessageBox.Show("Thêm lớp học thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
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
    }
}