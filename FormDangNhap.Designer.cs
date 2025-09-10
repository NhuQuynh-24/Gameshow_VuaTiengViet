namespace Gameshow_VuaTiengViet
{
    partial class FormDangNhap
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblNhapTen;
        private TextBox txtTenNguoiChoi;
        private Button btnDangNhap;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

    private void InitializeComponent()
        {
            lblNhapTen = new Label();
            txtTenNguoiChoi = new TextBox();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // lblNhapTen
            // 
            lblNhapTen.AutoSize = false;
            lblNhapTen.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhapTen.Location = new Point(0, 120);
            lblNhapTen.Name = "lblNhapTen";
            lblNhapTen.Size = new Size(1350, 60);
            lblNhapTen.TabIndex = 0;
            lblNhapTen.Text = "NHẬP TÊN NGƯỜI CHƠI";
            lblNhapTen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTenNguoiChoi
            // 
            txtTenNguoiChoi.Anchor = AnchorStyles.None;
            txtTenNguoiChoi.Location = new Point(425, 230);
            txtTenNguoiChoi.Multiline = false;
            txtTenNguoiChoi.Name = "txtTenNguoiChoi";
            txtTenNguoiChoi.Size = new Size(500, 60);
            txtTenNguoiChoi.TabIndex = 1;
            txtTenNguoiChoi.Font = new Font("Segoe UI", 22F, FontStyle.Regular);
            txtTenNguoiChoi.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(575, 350);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(200, 80);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.BackColor = Color.LightSkyBlue;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // FormDangNhap
            // 
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1350, 700);
            Controls.Add(lblNhapTen);
            Controls.Add(txtTenNguoiChoi);
            Controls.Add(btnDangNhap);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập - Vua Tiếng Việt";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
