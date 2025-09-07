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
            lblNhapTen.AutoSize = true;
            lblNhapTen.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhapTen.Location = new Point(132, 109);
            lblNhapTen.Name = "lblNhapTen";
            lblNhapTen.Size = new Size(212, 27);
            lblNhapTen.TabIndex = 0;
            lblNhapTen.Text = "Nhập tên người chơi:";
            lblNhapTen.Click += lblNhapTen_Click;
            // 
            // txtTenNguoiChoi
            // 
            txtTenNguoiChoi.Anchor = AnchorStyles.None;
            txtTenNguoiChoi.Location = new Point(365, 88);
            txtTenNguoiChoi.Multiline = true;
            txtTenNguoiChoi.Name = "txtTenNguoiChoi";
            txtTenNguoiChoi.Size = new Size(260, 67);
            txtTenNguoiChoi.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(414, 212);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(140, 63);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // FormDangNhap
            // 
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1075, 428);
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
