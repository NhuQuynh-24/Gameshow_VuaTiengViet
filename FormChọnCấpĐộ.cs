using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gameshow_VuaTiengViet
{
    public partial class FormCapDo : Form
    {
        // Thêm hai biến static này để lưu trạng thái hoàn thành
        public static bool DaHoanThanhDe = false;
        public static bool DaHoanThanhTrungBinh = false;

        public FormCapDo()
        {
            InitializeComponent();
            this.FormClosing += FormCapDo_FormClosing;
            CapNhatTrangThaiNut();
        }

        private void FormCapDo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CapNhatTrangThaiNut()
        {
            btnDe.Enabled = true;
            btnTrungBinh.Enabled = DaHoanThanhDe;
            btnKho.Enabled = DaHoanThanhTrungBinh;
        }

        private void btnDe_Click(object sender, EventArgs e)
        {
            new FormChoi("1").Show();
            this.Hide();
        }

        private void btnTrungBinh_Click(object sender, EventArgs e)
        {
            if (DaHoanThanhDe)
            {
                new FormChoi("2").Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn cần hoàn thành cấp độ Dễ với đủ điểm để mở khóa cấp độ này.");
            }
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            if (DaHoanThanhTrungBinh)
            {
                new FormChoi("3").Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bạn cần hoàn thành cấp độ Trung bình với đủ điểm để mở khóa cấp độ này.");
            }
        }
    }
}