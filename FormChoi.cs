using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gameshow_VuaTiengViet
{
    public partial class FormChoi : Form
    {
        private List<CauHoi> dsCauHoi;
        private int chiSoHienTai = 0;
        private int diemSo = 0;
        private string capDo;
        private int thoiGian = 20;
        private Random rnd = new Random();

        public FormChoi(string capDo)
        {
            InitializeComponent();
            this.capDo = capDo;
            TaiCauHoi();
            HienThiCauHoi();
        }

        private void TaiCauHoi()
        {
            var tatCaDong = File.ReadAllLines("CauHoi_DinhDang.txt");

            // Phân tích toàn bộ câu hỏi từ file
            var danhSach = tatCaDong.Select(PhanTichDong).ToList();

            // Lọc theo cấp độ (dùng cột độ khó ở cuối dòng file)
            danhSach = danhSach.Where(q => q.DoKho.Equals(capDo, StringComparison.OrdinalIgnoreCase)).ToList();

            // Random lấy 10 câu không trùng
            dsCauHoi = danhSach.OrderBy(x => rnd.Next()).Take(10).ToList();
        }

        private CauHoi PhanTichDong(string dong)
        {
            var parts = dong.Split('|');
            return new CauHoi
            {
                NoiDung = parts[0],
                DapAn = new string[] { parts[1], parts[2], parts[3], parts[4] },
                DapAnDung = parts[5],
                DoKho = parts.Length > 6 ? parts[6] : "Dễ"  // nếu thiếu cột thì mặc định là Dễ
            };
        }

        private void HienThiCauHoi()
        {
            if (chiSoHienTai >= dsCauHoi.Count)
            {
                FormDiem f = new FormDiem(diemSo, dsCauHoi.Count);
                f.Show();
                this.Hide();
                return;
            }

            var q = dsCauHoi[chiSoHienTai];
            lblCauHoi.Text = q.NoiDung;
            btnA.Text = "A. " + q.DapAn[0];
            btnB.Text = "B. " + q.DapAn[1];
            btnC.Text = "C. " + q.DapAn[2];
            btnD.Text = "D. " + q.DapAn[3];

            thoiGian = 20;
            lblThoiGian.Text = $"Thời gian: {thoiGian}s";
            timer1.Start();
        }

        private void KiemTraDapAn(string luaChon)
        {
            var q = dsCauHoi[chiSoHienTai];
            if (luaChon == q.DapAnDung) diemSo++;
            chiSoHienTai++;
            HienThiCauHoi();
        }

        private void btnA_Click(object sender, EventArgs e) => KiemTraDapAn("A");
        private void btnB_Click(object sender, EventArgs e) => KiemTraDapAn("B");
        private void btnC_Click(object sender, EventArgs e) => KiemTraDapAn("C");
        private void btnD_Click(object sender, EventArgs e) => KiemTraDapAn("D");

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = $"Thời gian: {thoiGian--}s";
            if (thoiGian < 0)
            {
                chiSoHienTai++;
                HienThiCauHoi();
            }
        }

        private void FormChoi_Load(object sender, EventArgs e)
        {

        }
    }

    public class CauHoi
    {
        public string NoiDung { get; set; }
        public string[] DapAn { get; set; }
        public string DapAnDung { get; set; }
        public string DoKho { get; set; }   // thêm độ khó
    }
}
