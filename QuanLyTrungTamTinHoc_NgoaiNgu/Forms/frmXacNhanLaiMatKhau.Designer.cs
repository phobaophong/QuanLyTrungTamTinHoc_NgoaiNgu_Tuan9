namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmXacNhanLaiMatKhau
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
            txtMatKhau = new TextBox();
            btnLuu = new Button();
            btnHuyBo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(401, 23);
            label1.TabIndex = 0;
            label1.Text = "Vui lòng nhập mật khẩu Quản trị viên để xác nhận:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(63, 39);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(301, 30);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(79, 98);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(127, 37);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Xác nhận";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(221, 98);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(127, 37);
            btnHuyBo.TabIndex = 3;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // frmXacNhanLaiMatKhau
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 147);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuu);
            Controls.Add(txtMatKhau);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmXacNhanLaiMatKhau";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Xác nhận lại mật khẩu ADMIN!!!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMatKhau;
        private Button btnLuu;
        private Button btnHuyBo;
    }
}