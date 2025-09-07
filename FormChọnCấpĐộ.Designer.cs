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
            lblChon.AutoSize = true;
            lblChon.Location = new Point(120, 20);
            lblChon.Name = "lblChon";
            lblChon.Size = new Size(128, 20);
            lblChon.TabIndex = 0;
            lblChon.Text = "Chọn cấp độ chơi:";
            // 
            // btnDe
            // 
            btnDe.Location = new Point(50, 60);
            btnDe.Name = "btnDe";
            btnDe.Size = new Size(75, 23);
            btnDe.TabIndex = 1;
            btnDe.Text = "Dễ";
            btnDe.Click += btnDe_Click;
            // 
            // btnTrungBinh
            // 
            btnTrungBinh.Location = new Point(150, 60);
            btnTrungBinh.Name = "btnTrungBinh";
            btnTrungBinh.Size = new Size(75, 23);
            btnTrungBinh.TabIndex = 2;
            btnTrungBinh.Text = "Trung bình";
            btnTrungBinh.Click += btnTrungBinh_Click;
            // 
            // btnKho
            // 
            btnKho.Location = new Point(280, 60);
            btnKho.Name = "btnKho";
            btnKho.Size = new Size(75, 23);
            btnKho.TabIndex = 3;
            btnKho.Text = "Khó";
            btnKho.Click += btnKho_Click;
            // 
            // FormCapDo
            // 
            ClientSize = new Size(400, 150);
            Controls.Add(lblChon);
            Controls.Add(btnDe);
            Controls.Add(btnTrungBinh);
            Controls.Add(btnKho);
            Name = "FormCapDo";
            Text = "Cấp độ - Vua Tiếng Việt";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}