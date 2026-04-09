namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmDoiMatKhau
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMatKhauCu = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtXacNhan = new TextBox();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            chkHienThiMatKhau = new CheckBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 81);
            label1.Name = "label1";
            label1.Size = new Size(109, 23);
            label1.TabIndex = 0;
            label1.Text = "Mật khẩu cũ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 134);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 187);
            label3.Name = "label3";
            label3.Size = new Size(162, 23);
            label3.TabIndex = 2;
            label3.Text = "Xác nhận mật khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(152, 9);
            label4.Name = "label4";
            label4.Size = new Size(305, 41);
            label4.TabIndex = 3;
            label4.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // txtMatKhauCu
            // 
            txtMatKhauCu.Location = new Point(272, 78);
            txtMatKhauCu.Name = "txtMatKhauCu";
            txtMatKhauCu.Size = new Size(263, 30);
            txtMatKhauCu.TabIndex = 4;
            txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(272, 131);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(263, 30);
            txtMatKhauMoi.TabIndex = 5;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtXacNhan
            // 
            txtXacNhan.Location = new Point(272, 184);
            txtXacNhan.Name = "txtXacNhan";
            txtXacNhan.Size = new Size(263, 30);
            txtXacNhan.TabIndex = 6;
            txtXacNhan.UseSystemPasswordChar = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(78, 289);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(139, 41);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Xác nhận";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(240, 289);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(139, 41);
            btnHuyBo.TabIndex = 8;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(402, 289);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(139, 41);
            btnThoat.TabIndex = 9;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // chkHienThiMatKhau
            // 
            chkHienThiMatKhau.AutoSize = true;
            chkHienThiMatKhau.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkHienThiMatKhau.Location = new Point(517, 233);
            chkHienThiMatKhau.Name = "chkHienThiMatKhau";
            chkHienThiMatKhau.Size = new Size(18, 17);
            chkHienThiMatKhau.TabIndex = 10;
            chkHienThiMatKhau.UseVisualStyleBackColor = true;
            chkHienThiMatKhau.CheckedChanged += chkHienThiMatKhau_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(364, 230);
            label5.Name = "label5";
            label5.Size = new Size(147, 23);
            label5.TabIndex = 11;
            label5.Text = "Hiển thị mật khẩu";
            // 
            // frmDoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 356);
            Controls.Add(label5);
            Controls.Add(chkHienThiMatKhau);
            Controls.Add(btnThoat);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuu);
            Controls.Add(txtXacNhan);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtMatKhauCu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmDoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thay đổi mật khẩu";
            Load += frmDoiMatKhau_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMatKhauCu;
        private TextBox txtMatKhauMoi;
        private TextBox txtXacNhan;
        private Button btnLuu;
        private Button btnHuyBo;
        private Button btnThoat;
        private CheckBox chkHienThiMatKhau;
        private Label label5;
    }
}