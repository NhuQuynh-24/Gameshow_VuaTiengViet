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
            CapNhatTrangThaiNut();
        }

        private void CapNhatTrangThaiNut()
        {
            btnTrungBinh.Enabled = DaHoanThanhDe;
            btnKho.Enabled = DaHoanThanhTrungBinh;
        }

        private void btnDe_Click(object sender, EventArgs e)
        {
            new FormChoi("Dễ").Show();
            this.Hide();
        }

        private void btnTrungBinh_Click(object sender, EventArgs e)
        {
            if (DaHoanThanhDe)
            {
                new FormChoi("Trung bình").Show();
                this.Hide();
            }
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            if (DaHoanThanhTrungBinh)
            {
                new FormChoi("Khó").Show();
                this.Hide();
            }
        }
    }
}