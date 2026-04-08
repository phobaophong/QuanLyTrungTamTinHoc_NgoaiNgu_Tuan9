namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmThongTinCaNhan
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
            btnThoat = new Button();
            lblSetup = new Label();
            label1 = new Label();
            label8 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            txtDiaChi = new TextBox();
            label10 = new Label();
            txtSdt = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            picHinhAnh = new PictureBox();
            label6 = new Label();
            groupBox6 = new GroupBox();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            label5 = new Label();
            txtHoVaTen = new TextBox();
            label4 = new Label();
            txtMaSo = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(lblSetup);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtSdt);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaSo);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(607, 649);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cá nhân";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(12, 603);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(117, 40);
            btnThoat.TabIndex = 40;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblSetup
            // 
            lblSetup.AutoSize = true;
            lblSetup.Location = new Point(25, 389);
            lblSetup.Name = "lblSetup";
            lblSetup.Size = new Size(233, 23);
            lblSetup.TabIndex = 39;
            lblSetup.Text = "Thông tin tùy theo đối tượng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 152);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 38;
            label1.Text = "Giới tính:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 341);
            label8.Name = "label8";
            label8.Size = new Size(55, 23);
            label8.TabIndex = 37;
            label8.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(145, 338);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(440, 30);
            txtEmail.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 296);
            label9.Name = "label9";
            label9.Size = new Size(66, 23);
            label9.TabIndex = 35;
            label9.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(145, 293);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(440, 30);
            txtDiaChi.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 255);
            label10.Name = "label10";
            label10.Size = new Size(115, 23);
            label10.TabIndex = 33;
            label10.Text = "Số điện thoại:";
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(145, 248);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(220, 30);
            txtSdt.TabIndex = 32;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(145, 203);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(220, 30);
            dtpNgaySinh.TabIndex = 24;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(390, 39);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(195, 239);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinhAnh.TabIndex = 14;
            picHinhAnh.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 209);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 11;
            label6.Text = "Ngày sinh: ";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rdoNam);
            groupBox6.Controls.Add(rdoNu);
            groupBox6.Location = new Point(145, 130);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(220, 58);
            groupBox6.TabIndex = 9;
            groupBox6.TabStop = false;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(18, 22);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(68, 27);
            rdoNam.TabIndex = 7;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(125, 22);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(54, 27);
            rdoNu.TabIndex = 8;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 88);
            label5.Name = "label5";
            label5.Size = new Size(93, 23);
            label5.TabIndex = 6;
            label5.Text = "Họ và tên: ";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(145, 85);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(224, 30);
            txtHoVaTen.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 42);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 4;
            label4.Text = "Mã số: ";
            // 
            // txtMaSo
            // 
            txtMaSo.Location = new Point(145, 40);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(224, 30);
            txtMaSo.TabIndex = 3;
            // 
            // frmThongTinCaNhan
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 649);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmThongTinCaNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThongTinCaNhan";
            Load += frmThongTinCaNhan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label8;
        private TextBox txtEmail;
        private Label label9;
        private TextBox txtDiaChi;
        private Label label10;
        private TextBox txtSdt;
        private DateTimePicker dtpNgaySinh;
        private PictureBox picHinhAnh;
        private Label label6;
        private GroupBox groupBox6;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private Label label5;
        private TextBox txtHoVaTen;
        private Label label4;
        private TextBox txtMaSo;
        private Label label1;
        private Label lblSetup;
        private Button btnThoat;
    }
}