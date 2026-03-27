using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QuanLyTrungTamTinHoc_NgoaiNgu.Data;
using QuanLyTrungTamTinHoc_NgoaiNgu.Reports; // Khai báo thư mục chứa DataSet của bạn
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmInBienLaiHocPhi : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        // Giữ lại biến DataSet1 của bạn
        DataSet1.HoaDonHocPhiDataTable hoadon = new DataSet1.HoaDonHocPhiDataTable();

        int id; // Mã phiếu thu 

        public frmInBienLaiHocPhi(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }

        private void frmInBienLaiHocPhi_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy dữ liệu từ Database
                var phieuThu = context.HocPhi
                    .Include(hp => hp.HocVien)
                    .Include(hp => hp.LopHoc)
                    .FirstOrDefault(hp => hp.ID == id);

                if (phieuThu != null)
                {
                    // 2. KHAI BÁO ĐƯỜNG DẪN CỰC GỌN (Nhờ bạn đã set Copy if newer)
                    reportViewer1.LocalReport.ReportPath = @"Reports\rptInBienLaiHocPhi.rdlc";

                    // 3. Truyền 6 Parameters
                    ReportParameter[] parameters = new ReportParameter[]
                    {
                        new ReportParameter("ngayLap", $"Ngày {DateTime.Now.Day:D2} tháng {DateTime.Now.Month:D2} năm {DateTime.Now.Year}"),
                        new ReportParameter("hoVaTenHocVien", phieuThu.HocVien.HoVaTen),
                        new ReportParameter("tenLop", phieuThu.LopHoc.TenLopHoc),
                        new ReportParameter("diaChi", phieuThu.HocVien.DiaChi ?? ""),
                        new ReportParameter("soTienDong", phieuThu.SoTienDaDong.ToString("N0") + " VNĐ"),
                        new ReportParameter("hinhThucDong", "Tiền mặt")
                    };
                    reportViewer1.LocalReport.SetParameters(parameters);

                    // 4. VÌ BẠN ĐÃ THÊM DataSet1 VÀO GIAO DIỆN RDLC NÊN PHẢI BƠM DỮ LIỆU CHO NÓ
                    hoadon.Clear();
                    hoadon.Rows.Add(
                        phieuThu.ID,
                        phieuThu.HocVienID,
                        phieuThu.HocVien.HoVaTen,
                        phieuThu.LopHocID,
                        phieuThu.LopHoc.TenLopHoc,
                        phieuThu.SoTienDaDong.ToString(),
                        phieuThu.NgayDong
                    );

                    ReportDataSource rds = new ReportDataSource("DataSet1", (DataTable)hoadon);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);

                    // 5. Làm mới và hiển thị bản in
                    reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin biên lai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Bẫy lỗi sâu
                string thongBaoLoi = "Lỗi bề nổi: " + ex.Message;
                if (ex.InnerException != null)
                {
                    thongBaoLoi += "\n\n🔥 NGUYÊN NHÂN GỐC:\n" + ex.InnerException.Message;
                }
                MessageBox.Show(thongBaoLoi, "Gỡ lỗi ReportViewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}