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
        public FormCapDo()
        {
            InitializeComponent();
        }

        private void btnDe_Click(object sender, EventArgs e)
        {
            new FormChoi("Dễ").Show(); this.Hide();
        }
        private void btnTrungBinh_Click(object sender, EventArgs e)
        {
            new FormChoi("Trung bình").Show(); this.Hide();
        }
        private void btnKho_Click(object sender, EventArgs e)
        {
            new FormChoi("Khó").Show(); this.Hide();
        }
    }
}
