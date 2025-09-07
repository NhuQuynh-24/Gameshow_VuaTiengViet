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
            this.components = new System.ComponentModel.Container();   // <- thêm dòng này
            this.lblCauHoi = new Label();
            this.lblThoiGian = new Label();
            this.btnA = new Button();
            this.btnB = new Button();
            this.btnC = new Button();
            this.btnD = new Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);  // <- và dòng này

            this.SuspendLayout();
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.Location = new System.Drawing.Point(20, 20);
            this.lblCauHoi.Size = new System.Drawing.Size(500, 40);
            this.lblCauHoi.Text = "Câu hỏi sẽ hiển thị ở đây";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.Location = new System.Drawing.Point(400, 300);
            this.lblThoiGian.Text = "Thời gian: 20s";
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(50, 80);
            this.btnA.Size = new System.Drawing.Size(200, 40);
            this.btnA.Click += new EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(300, 80);
            this.btnB.Size = new System.Drawing.Size(200, 40);
            this.btnB.Click += new EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(50, 150);
            this.btnC.Size = new System.Drawing.Size(200, 40);
            this.btnC.Click += new EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(300, 150);
            this.btnD.Size = new System.Drawing.Size(200, 40);
            this.btnD.Click += new EventHandler(this.btnD_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000; // 1 giây
            this.timer1.Tick += new EventHandler(this.timer1_Tick);
            // 
            // FormChoi
            // 
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.lblCauHoi);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnD);
            this.Text = "Chơi - Vua Tiếng Việt";
            this.ResumeLayout(false);
        }
    }
}
