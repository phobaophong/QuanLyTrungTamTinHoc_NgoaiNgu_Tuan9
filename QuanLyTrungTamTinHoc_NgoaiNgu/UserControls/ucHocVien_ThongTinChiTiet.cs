using QuanLyTrungTamTinHoc_NgoaiNgu.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.UserControls
{
    public partial class ucHocVien_ThongTinChiTiet : UserControl
    {
        QLTTDbContext db = new QLTTDbContext();
        HocVien hv;
        public ucHocVien_ThongTinChiTiet()
        {
            InitializeComponent();
            //LoadData();
        }
        public void LoadData()
        {
            int id = UserSession.TaiKhoanID;
            hv = db.HocVien.Include(h => h.LopHoc).ThenInclude(l => l.KhoaHoc).FirstOrDefault(h => h.TaiKhoanID == id);
            if (hv != null)
            {
                //Gán hình
                if (hv.HinhAnhHV != null)
                {
                    picAvatar.Image = Image.FromFile(hv.HinhAnhHV);
                }
                else
                {
                    if (hv.GioiTinh == "Nam")
                    {
                        picAvatar.Image = Properties.Resources.nam_avatar;
                    }
                    else
                    {
                        picAvatar.Image = Properties.Resources.nu_avatar;
                    }
                }
                //Họ tên, mã số học viên 

                txtHoTen.Text = hv.HoTenHV;
                txtMaHV.Text =  hv.MaHV;
                //Ngày sinh
                if (hv.NgaySinh != null)
                {
                    txtNgaySinh.Text = hv.NgaySinh.Value.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtNgaySinh.Text = "Chưa cập nhật!";
                }
                //Số điện thoại
                if (hv.Sdt != null)
                {
                    txtSdt.Text = hv.Sdt;
                }
                else
                {
                    txtSdt.Text = "Chưa cập nhật!";
                }
                //Giới tính, địa chỉ, email
                if (hv.GioiTinh != null)
                {
                    txtGioiTinh.Text =  hv.GioiTinh;
                }
                else
                {
                    txtGioiTinh.Text = "Chưa cập nhật!";
                }
                //Địa chỉ
                if (hv.DiaChi != null)
                {
                    txtDiaChi.Text = hv.DiaChi;
                }
                else
                {
                    txtDiaChi.Text = "Chưa cập nhật!";
                }
                //Email
                if (hv.EmailHV != null)
                {
                    txtEmail.Text = hv.EmailHV;
                }
                else
                {
                    txtEmail.Text = "Chưa cập nhật!";
                }
                //Lớp học + khóa học
                if (hv.LopHoc != null && hv.LopHoc.KhoaHoc != null)
                {
                    txtLopHoc.Text = hv.LopHoc.TenLop;
                    txtKhoaHoc.Text = hv.LopHoc.KhoaHoc.TenKH;

                }
                else
                {
                    txtLopHoc.Text = "Chưa cập nhật!";
                    txtKhoaHoc.Text = "Chưa cập nhật!";              
                }

            }
        }
        private void ucThongTin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        
    }
}
