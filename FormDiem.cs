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
    public partial class FormDiem : Form
    {
        public FormDiem(int diem, int tong)
        {
            InitializeComponent();
            lblDiem.Text = $"Người chơi: {FormDangNhap.TenNguoiChoi}{Environment.NewLine}Điểm số: {diem}/{tong}";
        }

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            FormCapDo f = new FormCapDo();
            f.Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDiem_Load(object sender, EventArgs e)
        {

        }
    }
}
