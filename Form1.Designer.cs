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
            lblNhapTen.Location = new Point(30, 40);
            lblNhapTen.Name = "lblNhapTen";
            lblNhapTen.Size = new Size(148, 20);
            lblNhapTen.TabIndex = 0;
            lblNhapTen.Text = "Nhập tên người chơi:";
            // 
            // txtTenNguoiChoi
            // 
            txtTenNguoiChoi.Location = new Point(180, 37);
            txtTenNguoiChoi.Name = "txtTenNguoiChoi";
            txtTenNguoiChoi.Size = new Size(200, 27);
            txtTenNguoiChoi.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(180, 80);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(75, 23);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // FromDangNhap
            // 
            ClientSize = new Size(420, 150);
            Controls.Add(lblNhapTen);
            Controls.Add(txtTenNguoiChoi);
            Controls.Add(btnDangNhap);
            Name = "FromDangNhap";
            Text = "Đăng nhập - Vua Tiếng Việt";
            Load += FromDangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
