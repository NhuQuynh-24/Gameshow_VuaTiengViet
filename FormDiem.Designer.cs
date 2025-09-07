namespace Gameshow_VuaTiengViet
{
    partial class FormDiem
    {
        private Label lblDiem;
        private Button btnChoiLai, btnThoat;

        private void InitializeComponent()
        {
            lblDiem = new Label();
            btnChoiLai = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblDiem
            // 
            lblDiem.Location = new Point(50, 30);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(300, 50);
            lblDiem.TabIndex = 0;
            lblDiem.Text = "Điểm số sẽ hiển thị ở đây";
            // 
            // btnChoiLai
            // 
            btnChoiLai.Location = new Point(50, 100);
            btnChoiLai.Name = "btnChoiLai";
            btnChoiLai.Size = new Size(75, 23);
            btnChoiLai.TabIndex = 1;
            btnChoiLai.Text = "Chơi lại";
            btnChoiLai.Click += btnChoiLai_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(180, 100);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // FormDiem
            // 
            ClientSize = new Size(400, 200);
            Controls.Add(lblDiem);
            Controls.Add(btnChoiLai);
            Controls.Add(btnThoat);
            Name = "FormDiem";
            Text = "Điểm - Vua Tiếng Việt";
            Load += FormDiem_Load;
            ResumeLayout(false);
        }
    }
}