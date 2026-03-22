using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Json;
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
    public partial class frmDiemSo : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        BindingSource bsDiem = new BindingSource();
        int id;
        public frmDiemSo()
        {
            InitializeComponent();
        }

        private void frmDiemSo_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            btnXacNhan.Enabled = false;
            txtHoVaTen.Enabled = false;
            txtMaSo.Enabled = false;

            LoadCbbKhoaHoc();

        }
        public void LoadCbbKhoaHoc()
        {
            var kh = context.KhoaHoc.ToList();

            cbbKhoaHoc.DataSource = kh;
            cbbKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbbKhoaHoc.ValueMember = "ID"; ;
        }
        public void LoadCbbLopHoc(int id)
        {
            var lop = context.LopHoc.Where(x => x.KhoaHocID == id).ToList();

            cbbLopHoc.DataSource = lop;
            cbbLopHoc.DisplayMember = "TenLopHoc";
            cbbLopHoc.ValueMember = "ID";
        }

        private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhoaHoc.SelectedValue != null && cbbKhoaHoc.SelectedValue is int)
            {
                id = (int)cbbKhoaHoc.SelectedValue;
                LoadCbbLopHoc(id);
            }
        }

        private void cbbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLopHoc.SelectedValue != null && cbbLopHoc.SelectedValue is int)
            {
                id = (int)cbbLopHoc.SelectedValue;
                LoadDiemHocVien(id);
            }
        }

        public void LoadDiemHocVien(int idLop)
        {

            var dsHocVien = context.HocVien
                .Where(hv => hv.HocPhi.Any(hp => hp.LopHocID == idLop))
                .ToList();

            var dsKetQua = context.KetQua
                .Where(k => k.LopHocID == idLop)
                .ToList();

            var danhSachHienThi = dsHocVien.Select(hv => new HienThiDiem
            {
                ID = hv.ID,
                MaSo = hv.MaSo,
                HoVaTen = hv.HoVaTen,
                DiemThiThu = dsKetQua.FirstOrDefault(k => k.HocVienID == hv.ID)?.DiemThiThu
            }).ToList();

            bsDiem.DataSource = new BindingList<HienThiDiem>(danhSachHienThi);
            dataGridView.DataSource = bsDiem;

            if (dataGridView.Columns.Count > 0)
            {
                foreach (DataGridViewColumn col in dataGridView.Columns)
                {
                    if (col.Name == "DiemThiThu" || col.DataPropertyName == "DiemThiThu")
                        col.ReadOnly = false;
                    else
                        col.ReadOnly = true;
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            dataGridView.EndEdit();
            bsDiem.EndEdit();

            if (cbbLopHoc.SelectedValue is int idLop)
            {
                var dsHienThi = bsDiem.DataSource as BindingList<HienThiDiem>;
                if (dsHienThi == null) return;

                foreach (var item in dsHienThi)
                {
                    int idHV = item.ID;
                    float? diemSo = item.DiemThiThu;

                    var kq = context.KetQua.FirstOrDefault(k => k.LopHocID == idLop && k.HocVienID == idHV);

                    if (diemSo.HasValue) 
                    {
                        if (kq != null)
                        {
                            kq.DiemThiThu = diemSo.Value; 
                        }
                        else
                        {
                            context.KetQua.Add(new KetQua
                            {
                                LopHocID = idLop,
                                HocVienID = idHV,
                                DiemThiThu = diemSo.Value
                            });
                        }
                    }
                    else 
                    {
                        if (kq != null)
                        {
                            context.KetQua.Remove(kq); 
                        }
                    }
                }

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Lưu điểm thi thử thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnXacNhan.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmDiemSo_Load(sender, e);
        }

        private void btnSuaDiem_Click(object sender, EventArgs e)
        {
            btnXacNhan.Enabled = true;
        }

        private void numDiemThiThu_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                dataGridView.CurrentRow.Cells["DiemThiThu"].Value = (float)numDiemThiThu.Value;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView.CurrentRow;

                txtMaSo.Text = row.Cells["MaSo"].Value?.ToString();
                txtHoVaTen.Text = row.Cells["HoVaTen"].Value?.ToString();

                var diem = row.Cells["DiemThiThu"].Value;
                if (diem != null && decimal.TryParse(diem.ToString(), out decimal diemSo))
                {
                    numDiemThiThu.Value = diemSo; 
                }
                else
                {
                    numDiemThiThu.Value = 0; 
                }
            }
        }
    }
}
