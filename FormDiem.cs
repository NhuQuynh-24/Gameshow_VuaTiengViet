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
        private string _capDo;
        // Thêm biến để lưu điểm và tổng số câu hỏi
        private int _diem;
        private int _tong;
        public FormDiem(int diem, int tong, string capDo)
        {
            InitializeComponent();
            lblDiem.Text = $"Người chơi: {FormDangNhap.TenNguoiChoi}{Environment.NewLine}Điểm số: {diem}/{tong}";
            _capDo = capDo;
            // Lưu giá trị vào biến thành viên
            _diem = diem;
            _tong = tong;
        }

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            // Cập nhật trạng thái đã hoàn thành chỉ khi người chơi đạt điểm tối đa
            if (_capDo == "Dễ" && _diem == _tong)
            {
                FormCapDo.DaHoanThanhDe = true;
            }
            else if (_capDo == "Trung bình" && _diem == _tong)
            {
                FormCapDo.DaHoanThanhTrungBinh = true;
            }

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