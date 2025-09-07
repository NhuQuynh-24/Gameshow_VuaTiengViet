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
            this.lblChon = new Label();
            this.btnDe = new Button();
            this.btnTrungBinh = new Button();
            this.btnKho = new Button();
            this.SuspendLayout();
            // 
            // lblChon
            // 
            this.lblChon.AutoSize = true;
            this.lblChon.Location = new System.Drawing.Point(120, 20);
            this.lblChon.Text = "Chọn cấp độ chơi:";
            // 
            // btnDe
            // 
            this.btnDe.Text = "Dễ";
            this.btnDe.Location = new System.Drawing.Point(50, 60);
            this.btnDe.Click += new EventHandler(this.btnDe_Click);
            // 
            // btnTrungBinh
            // 
            this.btnTrungBinh.Text = "Trung bình";
            this.btnTrungBinh.Location = new System.Drawing.Point(150, 60);
            this.btnTrungBinh.Click += new EventHandler(this.btnTrungBinh_Click);
            // 
            // btnKho
            // 
            this.btnKho.Text = "Khó";
            this.btnKho.Location = new System.Drawing.Point(280, 60);
            this.btnKho.Click += new EventHandler(this.btnKho_Click);
            // 
            // FormCapDo
            // 
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.lblChon);
            this.Controls.Add(this.btnDe);
            this.Controls.Add(this.btnTrungBinh);
            this.Controls.Add(this.btnKho);
            this.Text = "Cấp độ - Vua Tiếng Việt";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}