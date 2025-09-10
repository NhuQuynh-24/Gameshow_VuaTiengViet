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
        // Thêm biến để lưu điểm, tổng số câu hỏi và kết quả từng câu
        private int _diem;
        private int _tong;
        private List<bool> _ketQua;
        public FormDiem(int diem, int tong, string capDo, List<bool> ketQua)
        {
            InitializeComponent();
            _capDo = capDo;
            _diem = diem;
            _tong = tong;
            _ketQua = ketQua;
            this.FormClosing += FormDiem_FormClosing;
            HienThiThongTin();
        }

        private void FormDiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HienThiThongTin()
        {
            string tenNguoiChoi = "Người chơi";
            try { tenNguoiChoi = FormDangNhap.TenNguoiChoi; } catch { }
            int diemMoKhoa = 0;
            string capTiep = "";
            string thongBao = "";
            string trangThai = "";
            Color colorTrangThai = Color.DarkBlue;
            if (_capDo == "1" || _capDo == "Dễ") { diemMoKhoa = 6; capTiep = "Trung bình"; }
            else if (_capDo == "2" || _capDo == "Trung bình") { diemMoKhoa = 7; capTiep = "Khó"; }
            else if (_capDo == "3" || _capDo == "Khó") { diemMoKhoa = 8; }

            lblDiem.Text = $"{tenNguoiChoi} - Điểm số: {_diem}/{_tong}";

            if ((_capDo == "1" || _capDo == "Dễ") && _diem >= diemMoKhoa)
            {
                trangThai = $"Bạn đã mở khóa cấp độ {capTiep}!";
                colorTrangThai = Color.Green;
            }
            else if ((_capDo == "2" || _capDo == "Trung bình") && _diem >= diemMoKhoa)
            {
                trangThai = $"Bạn đã mở khóa cấp độ {capTiep}!";
                colorTrangThai = Color.Green;
            }
            else if ((_capDo == "3" || _capDo == "Khó") && _diem >= diemMoKhoa)
            {
                trangThai = "Chúc mừng bạn là Vua Tiếng Việt!";
                colorTrangThai = Color.OrangeRed;
            }
            else
            {
                trangThai = "Bạn chưa đủ điểm để mở khóa cấp độ tiếp theo.";
                colorTrangThai = Color.Red;
            }
            lblTrangThai.Text = trangThai;
            lblTrangThai.ForeColor = colorTrangThai;
        }

        private void btnChoiLai_Click(object sender, EventArgs e)
        {
            // Cập nhật trạng thái mở khóa cấp độ dựa trên điểm đạt được
            if ((_capDo == "1" || _capDo == "Dễ") && _diem >= 6)
            {
                FormCapDo.DaHoanThanhDe = true;
            }
            if ((_capDo == "2" || _capDo == "Trung bình") && _diem >= 7)
            {
                FormCapDo.DaHoanThanhTrungBinh = true;
            }
            // Không cần cập nhật gì thêm cho cấp độ Khó
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