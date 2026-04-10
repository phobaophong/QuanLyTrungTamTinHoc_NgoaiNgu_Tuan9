namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmThongKeDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            cboLopHoc = new ComboBox();
            cboKhoaHoc = new ComboBox();
            btnThoat = new Button();
            label2 = new Label();
            label1 = new Label();
            btnTatCa = new Button();
            btnLoc = new Button();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboLopHoc);
            groupBox1.Controls.Add(cboKhoaHoc);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnTatCa);
            groupBox1.Controls.Add(btnLoc);
            groupBox1.Controls.Add(dtpDenNgay);
            groupBox1.Controls.Add(dtpTuNgay);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1471, 89);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1148, 30);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 10;
            label4.Text = "Lớp học:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(833, 32);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 9;
            label3.Text = "Khóa học:";
            // 
            // cboLopHoc
            // 
            cboLopHoc.FormattingEnabled = true;
            cboLopHoc.Location = new Point(1229, 26);
            cboLopHoc.Name = "cboLopHoc";
            cboLopHoc.Size = new Size(214, 28);
            cboLopHoc.TabIndex = 8;
            cboLopHoc.SelectedIndexChanged += cboLopHoc_SelectedIndexChanged;
            // 
            // cboKhoaHoc
            // 
            cboKhoaHoc.FormattingEnabled = true;
            cboKhoaHoc.Location = new Point(924, 26);
            cboKhoaHoc.Name = "cboKhoaHoc";
            cboKhoaHoc.Size = new Size(218, 28);
            cboKhoaHoc.TabIndex = 7;
            cboKhoaHoc.SelectedIndexChanged += cboKhoaHoc_SelectedIndexChanged;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(713, 26);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 32);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 4;
            label1.Text = "Từ ngày:";
            // 
            // btnTatCa
            // 
            btnTatCa.Location = new Point(603, 26);
            btnTatCa.Name = "btnTatCa";
            btnTatCa.Size = new Size(94, 29);
            btnTatCa.TabIndex = 3;
            btnTatCa.Text = "Tất cả";
            btnTatCa.UseVisualStyleBackColor = true;
            btnTatCa.Click += btnTatCa_Click;
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(491, 26);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(94, 29);
            btnLoc.TabIndex = 2;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            btnLoc.Click += btnLoc_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(336, 28);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(129, 27);
            dtpDenNgay.TabIndex = 1;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(90, 28);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(129, 27);
            dtpTuNgay.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Location = new Point(0, 89);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1471, 572);
            reportViewer1.TabIndex = 1;
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 661);
            Controls.Add(reportViewer1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmThongKeDoanhThu";
            Text = "Thống kê doanh thu";
            Load += frmThongKeDoanhThu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnTatCa;
        private Button btnLoc;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Label label2;
        private Label label1;
        private Button btnThoat;
        private Label label3;
        private ComboBox cboLopHoc;
        private ComboBox cboKhoaHoc;
        private Label label4;
    }
}