namespace Gameshow_VuaTiengViet
{
    partial class FormDiem
    {
        private Label lblDiem;
        private Label lblTrangThai;
        private Button btnChoiLai, btnThoat;

        private void InitializeComponent()
        {
            lblDiem = new Label();
            lblTrangThai = new Label();
            btnChoiLai = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblDiem
            // 
            lblDiem.Location = new Point(100, 60);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(1150, 60);
            lblDiem.TabIndex = 0;
            lblDiem.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblDiem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Location = new Point(100, 150);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(1150, 50);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Font = new Font("Segoe UI", 20F, FontStyle.Italic);
            lblTrangThai.TextAlign = ContentAlignment.MiddleCenter;
            lblTrangThai.ForeColor = Color.DarkBlue;
            // 
            // btnChoiLai
            // 
            btnChoiLai.Location = new Point(400, 350);
            btnChoiLai.Name = "btnChoiLai";
            btnChoiLai.Size = new Size(250, 60);
            btnChoiLai.TabIndex = 1;
            btnChoiLai.Text = "Chơi lại";
            btnChoiLai.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnChoiLai.BackColor = Color.LightGreen;
            btnChoiLai.Click += btnChoiLai_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(700, 350);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(250, 60);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnThoat.BackColor = Color.LightCoral;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormDiem
            // 
            ClientSize = new Size(1350, 700);
            Controls.Add(lblDiem);
            Controls.Add(lblTrangThai);
            Controls.Add(btnChoiLai);
            Controls.Add(btnThoat);
            Name = "FormDiem";
            Text = "Điểm - Vua Tiếng Việt";
            Load += FormDiem_Load;
            ResumeLayout(false);
        }
    }
}