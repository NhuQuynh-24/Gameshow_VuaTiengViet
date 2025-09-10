using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Gameshow_VuaTiengViet
{
    partial class FormChoi
    {
        // QUAN TRỌNG: có container để Dispose()
        private IContainer components = null;

    private Label lblCauHoi, lblThoiGian, lblKetQua, lblSoCauDung;
    private Button btnA, btnB, btnC, btnD;
        // QUAN TRỌNG: dùng đúng Timer của WinForms
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

    private void InitializeComponent()
        {
            components = new Container();
            lblCauHoi = new Label();
            lblThoiGian = new Label();
            lblKetQua = new Label();
            lblSoCauDung = new Label();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblCauHoi
            lblCauHoi.Location = new Point(50, 30);
            lblCauHoi.Name = "lblCauHoi";
            lblCauHoi.Size = new Size(1250, 60);
            lblCauHoi.TabIndex = 0;
            lblCauHoi.Text = "Câu hỏi sẽ hiển thị ở đây";
            lblCauHoi.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblCauHoi.TextAlign = ContentAlignment.MiddleCenter;

            // lblSoCauDung
            lblSoCauDung.Location = new Point(50, 100);
            lblSoCauDung.Name = "lblSoCauDung";
            lblSoCauDung.Size = new Size(300, 35);
            lblSoCauDung.TabIndex = 6;
            lblSoCauDung.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            lblSoCauDung.TextAlign = ContentAlignment.MiddleLeft;

            // lblKetQua
            lblKetQua.Location = new Point(50, 600);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(1250, 40);
            lblKetQua.TabIndex = 7;
            lblKetQua.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblKetQua.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblThoiGian
            lblThoiGian.Location = new Point(1100, 100);
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(200, 35);
            lblThoiGian.TabIndex = 1;
            lblThoiGian.Text = "Thời gian: 20s";
            lblThoiGian.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblThoiGian.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnA
            // 
            btnA.Location = new Point(200, 200);
            btnA.Name = "btnA";
            btnA.Size = new Size(450, 80);
            btnA.TabIndex = 2;
            btnA.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnA.BackColor = Color.LightYellow;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(700, 200);
            btnB.Name = "btnB";
            btnB.Size = new Size(450, 80);
            btnB.TabIndex = 3;
            btnB.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnB.BackColor = Color.LightYellow;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(200, 350);
            btnC.Name = "btnC";
            btnC.Size = new Size(450, 80);
            btnC.TabIndex = 4;
            btnC.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnC.BackColor = Color.LightYellow;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(700, 350);
            btnD.Name = "btnD";
            btnD.Size = new Size(450, 80);
            btnD.TabIndex = 5;
            btnD.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnD.BackColor = Color.LightYellow;
            btnD.Click += btnD_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormChoi
            // 
            ClientSize = new Size(1350, 700);
            Controls.Add(lblCauHoi);
            Controls.Add(lblSoCauDung);
            Controls.Add(lblThoiGian);
            Controls.Add(btnA);
            Controls.Add(btnB);
            Controls.Add(btnC);
            Controls.Add(btnD);
            Controls.Add(lblKetQua);
            Name = "FormChoi";
            Text = "Chơi - Vua Tiếng Việt";
            Load += FormChoi_Load;
            ResumeLayout(false);
        }
    }
}