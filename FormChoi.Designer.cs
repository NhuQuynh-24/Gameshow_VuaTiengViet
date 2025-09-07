using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Gameshow_VuaTiengViet
{
    partial class FormChoi
    {
        // QUAN TRỌNG: có container để Dispose()
        private IContainer components = null;

        private Label lblCauHoi, lblThoiGian;
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
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblCauHoi
            // 
            lblCauHoi.Location = new Point(20, 20);
            lblCauHoi.Name = "lblCauHoi";
            lblCauHoi.Size = new Size(500, 40);
            lblCauHoi.TabIndex = 0;
            lblCauHoi.Text = "Câu hỏi sẽ hiển thị ở đây";
            // 
            // lblThoiGian
            // 
            lblThoiGian.Location = new Point(400, 300);
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(100, 23);
            lblThoiGian.TabIndex = 1;
            lblThoiGian.Text = "Thời gian: 20s";
            // 
            // btnA
            // 
            btnA.Location = new Point(50, 80);
            btnA.Name = "btnA";
            btnA.Size = new Size(200, 40);
            btnA.TabIndex = 2;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(300, 80);
            btnB.Name = "btnB";
            btnB.Size = new Size(200, 40);
            btnB.TabIndex = 3;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(50, 150);
            btnC.Name = "btnC";
            btnC.Size = new Size(200, 40);
            btnC.TabIndex = 4;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(300, 150);
            btnD.Name = "btnD";
            btnD.Size = new Size(200, 40);
            btnD.TabIndex = 5;
            btnD.Click += btnD_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormChoi
            // 
            ClientSize = new Size(550, 350);
            Controls.Add(lblCauHoi);
            Controls.Add(lblThoiGian);
            Controls.Add(btnA);
            Controls.Add(btnB);
            Controls.Add(btnC);
            Controls.Add(btnD);
            Name = "FormChoi";
            Text = "Chơi - Vua Tiếng Việt";
            Load += FormChoi_Load;
            ResumeLayout(false);
        }
    }
}
