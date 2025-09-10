namespace Gameshow_VuaTiengViet
{
    partial class FormCapDo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Label lblChon;
        private Button btnDe, btnTrungBinh, btnKho;

    private void InitializeComponent()
        {
            lblChon = new Label();
            btnDe = new Button();
            btnTrungBinh = new Button();
            btnKho = new Button();
            SuspendLayout();
            // 
            // lblChon
            // 
            lblChon.AutoSize = false;
            lblChon.Location = new Point(0, 60);
            lblChon.Name = "lblChon";
            lblChon.Size = new Size(1350, 60);
            lblChon.TabIndex = 0;
            lblChon.Text = "CHỌN CẤP ĐỘ CHƠI";
            lblChon.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblChon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDe
            // 
            btnDe.Location = new Point(200, 250);
            btnDe.Name = "btnDe";
            btnDe.Size = new Size(300, 120);
            btnDe.TabIndex = 1;
            btnDe.Text = "Dễ";
            btnDe.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            btnDe.BackColor = Color.LightGreen;
            btnDe.Click += btnDe_Click;
            // 
            // btnTrungBinh
            // 
            btnTrungBinh.Location = new Point(525, 250);
            btnTrungBinh.Name = "btnTrungBinh";
            btnTrungBinh.Size = new Size(300, 120);
            btnTrungBinh.TabIndex = 2;
            btnTrungBinh.Text = "Trung bình";
            btnTrungBinh.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            btnTrungBinh.BackColor = Color.Khaki;
            btnTrungBinh.Click += btnTrungBinh_Click;
            // 
            // btnKho
            // 
            btnKho.Location = new Point(850, 250);
            btnKho.Name = "btnKho";
            btnKho.Size = new Size(300, 120);
            btnKho.TabIndex = 3;
            btnKho.Text = "Khó";
            btnKho.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            btnKho.BackColor = Color.LightCoral;
            btnKho.Click += btnKho_Click;
            // 
            // FormCapDo
            // 
            ClientSize = new Size(1350, 700);
            Controls.Add(lblChon);
            Controls.Add(btnDe);
            Controls.Add(btnTrungBinh);
            Controls.Add(btnKho);
            Name = "FormCapDo";
            Text = "Cấp độ - Vua Tiếng Việt";
            ResumeLayout(false);
        }
    }
}