namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmTraCuuDiemThiThu
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
            btnTimKiem = new Button();
            lblHienThi = new Label();
            txtMaSo = new TextBox();
            label1 = new Label();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(lblHienThi);
            groupBox1.Controls.Add(txtMaSo);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1206, 889);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tra cứu";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(530, 55);
            btnTimKiem.Margin = new Padding(4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(159, 39);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // lblHienThi
            // 
            lblHienThi.AutoSize = true;
            lblHienThi.Location = new Point(33, 151);
            lblHienThi.Margin = new Padding(4, 0, 4, 0);
            lblHienThi.Name = "lblHienThi";
            lblHienThi.Size = new Size(80, 28);
            lblHienThi.TabIndex = 2;
            lblHienThi.Text = "Hiển thị";
            // 
            // txtMaSo
            // 
            txtMaSo.Location = new Point(235, 57);
            txtMaSo.Margin = new Padding(4);
            txtMaSo.Name = "txtMaSo";
            txtMaSo.Size = new Size(241, 34);
            txtMaSo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 61);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã số sinh viên: ";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(718, 55);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(159, 39);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmTraCuuDiemThiThu
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 889);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmTraCuuDiemThiThu";
            Text = "frmTraCuuDiemThiThu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblHienThi;
        private TextBox txtMaSo;
        private Label label1;
        private Button btnTimKiem;
        private Button btnThoat;
    }
}