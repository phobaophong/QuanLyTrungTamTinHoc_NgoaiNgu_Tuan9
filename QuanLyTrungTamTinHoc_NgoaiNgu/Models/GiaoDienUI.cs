using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Models.Utils
{
    public static class GiaoDien
    {
        // ===== MÀU CHỦ ĐẠO =====
        public static Color MauNenForm = Color.FromArgb(245, 246, 250);
        public static Color MauChuDao = Color.FromArgb(44, 62, 80);

        // ===== BUTTON THEO CHỨC NĂNG =====
        public static Color MauThem = Color.FromArgb(46, 204, 113);   // Thêm
        public static Color MauXoa = Color.FromArgb(231, 76, 60);     // Xóa
        public static Color MauSua = Color.FromArgb(241, 196, 15);    // Sửa
        public static Color MauLuu = Color.FromArgb(52, 152, 219);    // Lưu / Xác nhận

        public static Color MauXemChiTiet = Color.FromArgb(26, 188, 156); // Xem chi tiết
        public static Color MauLoc = Color.FromArgb(149, 165, 166);       // Lọc
        public static Color MauExcel = Color.FromArgb(39, 174, 96);       // Xuất Excel
        public static Color MauImport = Color.FromArgb(155, 89, 182);     // Import file

        // ===== ÁP DỤNG GIAO DIỆN =====
        public static void ApDungGiaoDien(Form frm)
        {
            frm.BackColor = MauNenForm;

            foreach (Control ctrl in frm.Controls)
            {
                TrangTriControl(ctrl);
            }
        }

        // ===== ĐỆ QUY TRANG TRÍ =====
        private static void TrangTriControl(Control ctrl)
        {
            foreach (Control child in ctrl.Controls)
            {
                TrangTriControl(child);
            }

            // ===== BUTTON =====
            if (ctrl is Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
                btn.Height = 38;
                btn.Padding = new Padding(5);

                string name = btn.Name.ToLower();

                if (name.Contains("them"))
                    SetButtonStyle(btn, MauThem);

                else if (name.Contains("xoa") || name.Contains("thoat"))
                    SetButtonStyle(btn, MauXoa);

                else if (name.Contains("sua") || name.Contains("doianh"))
                    SetButtonStyle(btn, MauSua);

                else if (name.Contains("luu")  || name.Contains("xacnhan") || name.Contains("loc") || 
                         name.Contains("tatca") || name.Contains("nghiep") || name.Contains("danghoc") ||
                         name.Contains("giangvien") || name.Contains("nhanvien") || name.Contains("timkiem")||
                         name.Contains("5diem") || name.Contains("taoloponthi"))
                    SetButtonStyle(btn, MauLuu);

                else if (name.Contains("huybo"))
                    SetButtonStyle(btn, Color.Gray);

                else if (name.Contains("chitiet") || name.Contains("xem"))
                    SetButtonStyle(btn, MauXemChiTiet);

                else if (name.Contains("loc") || name.Contains("filter"))
                    SetButtonStyle(btn, MauLoc);

                else if (name.Contains("excel") || name.Contains("xuat"))
                    SetButtonStyle(btn, MauExcel);

                else if (name.Contains("import") || name.Contains("file"))
                    SetButtonStyle(btn, MauImport);

                else
                    SetButtonStyle(btn, Color.Gray);
            }

            // ===== DATAGRID =====
            else if (ctrl is DataGridView dgv)
            {
                dgv.BackgroundColor = Color.White;
                dgv.BorderStyle = BorderStyle.None;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgv.RowHeadersVisible = false;

                dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(236, 240, 241);
                dgv.DefaultCellStyle.SelectionForeColor = MauChuDao;

                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = MauLuu;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                dgv.ColumnHeadersHeight = 40;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }

            // ===== LABEL =====
            else if (ctrl is Label lbl)
            {
                lbl.ForeColor = MauChuDao;
                lbl.Font = new Font("Segoe UI", 9.5F);
            }

            // ===== TEXTBOX =====
            else if (ctrl is TextBox txt)
            {
                txt.Font = new Font("Segoe UI", 10F);
                txt.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        // ===== STYLE BUTTON =====
        private static void SetButtonStyle(Button btn, Color baseColor)
        {
            Color hoverColor = ControlPaint.Light(baseColor);
            Color clickColor = ControlPaint.Dark(baseColor);
            Color disabledColor = Color.FromArgb(189, 195, 199);

            btn.BackColor = baseColor;

            // trạng thái enable/disable
            btn.EnabledChanged += (s, e) =>
            {
                if (btn.Enabled)
                {
                    btn.BackColor = baseColor;
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.BackColor = disabledColor;
                    btn.ForeColor = Color.White;
                }
            };

            // hover
            btn.MouseEnter += (s, e) =>
            {
                if (btn.Enabled) btn.BackColor = hoverColor;
            };

            btn.MouseLeave += (s, e) =>
            {
                if (btn.Enabled) btn.BackColor = baseColor;
            };

            // click
            btn.MouseDown += (s, e) =>
            {
                if (btn.Enabled) btn.BackColor = clickColor;
            };

            btn.MouseUp += (s, e) =>
            {
                if (btn.Enabled) btn.BackColor = hoverColor;
            };
        }
    }
}