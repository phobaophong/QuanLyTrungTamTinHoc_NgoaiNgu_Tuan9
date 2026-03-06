namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1 = new Panel();
            btnQuanLyKhoaHoc = new Button();
            panel2 = new Panel();
            btnQuanLyLopHoc = new Button();
            panel3 = new Panel();
            button3 = new Button();
            panel4 = new Panel();
            button4 = new Button();
            pnlCha = new Panel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(981, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(hopePictureBox1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1102, 44);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Image = (Image)resources.GetObject("hopePictureBox1.Image");
            hopePictureBox1.Location = new Point(3, 3);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(39, 41);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 0;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(0, 44);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(262, 722);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnQuanLyKhoaHoc);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 72);
            panel1.TabIndex = 4;
            // 
            // btnQuanLyKhoaHoc
            // 
            btnQuanLyKhoaHoc.BackColor = Color.DodgerBlue;
            btnQuanLyKhoaHoc.ForeColor = Color.Black;
            btnQuanLyKhoaHoc.Location = new Point(0, 0);
            btnQuanLyKhoaHoc.Margin = new Padding(0);
            btnQuanLyKhoaHoc.Name = "btnQuanLyKhoaHoc";
            btnQuanLyKhoaHoc.Size = new Size(262, 72);
            btnQuanLyKhoaHoc.TabIndex = 3;
            btnQuanLyKhoaHoc.Text = "Quản Lý Khóa Học";
            btnQuanLyKhoaHoc.UseVisualStyleBackColor = false;
            btnQuanLyKhoaHoc.Click += btnQuanLyKhoaHoc_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnQuanLyLopHoc);
            panel2.Location = new Point(0, 72);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 72);
            panel2.TabIndex = 5;
            // 
            // btnQuanLyLopHoc
            // 
            btnQuanLyLopHoc.BackColor = Color.DodgerBlue;
            btnQuanLyLopHoc.Location = new Point(0, 0);
            btnQuanLyLopHoc.Margin = new Padding(0);
            btnQuanLyLopHoc.Name = "btnQuanLyLopHoc";
            btnQuanLyLopHoc.Size = new Size(262, 72);
            btnQuanLyLopHoc.TabIndex = 3;
            btnQuanLyLopHoc.Text = "Quản Lý Lớp Học";
            btnQuanLyLopHoc.UseVisualStyleBackColor = false;
            btnQuanLyLopHoc.Click += btnQuanLyLopHoc_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Location = new Point(0, 144);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(262, 72);
            panel3.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.Location = new Point(0, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(262, 72);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button4);
            panel4.Location = new Point(0, 216);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(262, 72);
            panel4.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.Location = new Point(0, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(262, 72);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // pnlCha
            // 
            pnlCha.Dock = DockStyle.Fill;
            pnlCha.Location = new Point(262, 44);
            pnlCha.Name = "pnlCha";
            pnlCha.Size = new Size(840, 722);
            pnlCha.TabIndex = 3;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 766);
            Controls.Add(pnlCha);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(nightControlBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnQuanLyKhoaHoc;
        private Panel panel1;
        private Panel panel2;
        private Button btnQuanLyLopHoc;
        private Panel panel3;
        private Button button3;
        private Panel panel4;
        private Button button4;
        private Panel pnlCha;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
    }
}