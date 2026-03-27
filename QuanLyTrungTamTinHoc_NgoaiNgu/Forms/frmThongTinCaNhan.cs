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

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmThongTinCaNhan : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        int idDuLieu;
        int loai;
        string folderAnh = @"D:\Project\ĐỒ ÁN - Lập trình quản lý\HinhNen\";


        public frmThongTinCaNhan(int idTruyenVao, int loaiTruyenVao)
        {
            InitializeComponent();
            idDuLieu = idTruyenVao;
            loai = loaiTruyenVao;

            Models.Utils.GiaoDien.ApDungGiaoDien(this);
        }

        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            KhoaGiaoDien();
            switch (loai)
            {
                case 1: // nhân viên
                    var nv = context.NhanVien.Find(idDuLieu);
                    if (nv != null)
                    {
                        this.Text = "Thông tin cá nhân - Nhân viên";
                        txtMaSo.Text = nv.MaSo;
                        txtHoVaTen.Text = nv.HoVaTen;
                        txtSdt.Text = nv.Sdt;
                        dtpNgaySinh.Value = nv.NgaySinh;
                        txtDiaChi.Text = nv.DiaChi;
                        txtEmail.Text = nv.Email;
                        if (nv.GioiTinh == true) rdoNam.Checked = true; else rdoNu.Checked = true;


                        LoadHinhAnh(nv.HinhAnh, nv.GioiTinh);

                    }
                    break;

                case 2: // giảng viên
                    var gv = context.GiangVien.Find(idDuLieu);
                    if (gv != null)
                    {
                        this.Text = "Thông tin cá nhân - Giảng viên";
                        txtMaSo.Text = gv.MaSo;
                        txtHoVaTen.Text = gv.HoVaTen;
                        txtSdt.Text = gv.Sdt;
                        dtpNgaySinh.Value = gv.NgaySinh;
                        txtDiaChi.Text = gv.DiaChi;
                        txtEmail.Text = gv.Email;
                        if (gv.GioiTinh == true) rdoNam.Checked = true; else rdoNu.Checked = true;

                        LoadHinhAnh(gv.HinhAnh, gv.GioiTinh);

                    }
                    break;

                case 3: // học viên
                    var hv = context.HocVien.Find(idDuLieu);
                    if (hv != null)
                    {
                        this.Text = "Thông tin cá nhân - Học viên";
                        txtMaSo.Text = hv.MaSo;
                        txtHoVaTen.Text = hv.HoVaTen;
                        dtpNgaySinh.Value = hv.NgaySinh;
                        txtSdt.Text = hv.Sdt;
                        txtDiaChi.Text = hv.DiaChi;
                        txtEmail.Text = hv.Email;
                        if (hv.GioiTinh == true) rdoNam.Checked = true; else rdoNu.Checked = true;

                        LoadHinhAnh(hv.HinhAnh, hv.GioiTinh);
                    }

                    var chiTietGhiDanh = context.HocPhi
                            .Include(x => x.LopHoc)
                                .ThenInclude(l => l.KhoaHoc)
                            .FirstOrDefault(x => x.HocVienID == idDuLieu);
                    if (chiTietGhiDanh != null && chiTietGhiDanh.LopHoc != null)
                    {
                        string tenLop = chiTietGhiDanh.LopHoc.TenLopHoc;

                        string tenKhoa = chiTietGhiDanh.LopHoc.KhoaHoc != null
                                         ? chiTietGhiDanh.LopHoc.KhoaHoc.TenKhoaHoc
                                         : "Chưa cập nhật";

                        // lấy học phí
                        int tongHocPhi = chiTietGhiDanh.LopHoc.KhoaHoc != null ? chiTietGhiDanh.LopHoc.KhoaHoc.HocPhi : 0;

                        // số tiền đã đóng
                        decimal daDong = chiTietGhiDanh.SoTienDaDong;

                        // trạng thái học phí
                        string trangThai = chiTietGhiDanh.TrangThai
                                           ? "Đã hoàn thành"
                                           : $"Còn nợ: {(tongHocPhi - daDong).ToString("N0")} VNĐ";

                        lblSetup.Text = $"Khóa: {tenKhoa}  |  Lớp: {tenLop}  \n" +
                                        $"Học phí: {tongHocPhi.ToString("N0")} VNĐ  \n" +
                                        $"Đã nộp: {daDong.ToString("N0")} ({trangThai})";
                    }
                    else
                    {
                        lblSetup.Text = "Học viên này chưa được xếp vào lớp học nào.";
                    }
                    break;
            }
        }
        private void LoadHinhAnh(string tenFileAnh, bool gioiTinh)
        {
            if (picHinhAnh.Image != null)
            {
                picHinhAnh.Image.Dispose();
                picHinhAnh.Image = null;
            }

            if (!string.IsNullOrEmpty(tenFileAnh))
            {
                string fullPath = System.IO.Path.Combine(folderAnh, tenFileAnh);
                if (System.IO.File.Exists(fullPath))
                {
                    try
                    {
                        using (var stream = new System.IO.FileStream(fullPath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                        {
                            picHinhAnh.Image = Image.FromStream(stream);
                        }
                        return;
                    }
                    catch { }
                }
            }

            if (gioiTinh == true)
            {
                picHinhAnh.Image = Properties.Resources.nam_avatar;
            }
            else
            {
                picHinhAnh.Image = Properties.Resources.nu_avatar;
            }
        }
        private void KhoaGiaoDien()
        {
            txtMaSo.ReadOnly = true;
            txtHoVaTen.ReadOnly = true;
            txtSdt.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtEmail.ReadOnly = true;
            dtpNgaySinh.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
