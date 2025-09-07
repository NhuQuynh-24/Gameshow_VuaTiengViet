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
            try
            {
                var tatCaDong = File.ReadAllLines("CauHoi_DinhDang.txt");
                var danhSach = tatCaDong.Select(PhanTichDong).ToList();

                // Lọc theo cấp độ và lấy 10 câu hỏi ngẫu nhiên
                dsCauHoi = danhSach.Where(q => q.DoKho.Equals(capDo, StringComparison.OrdinalIgnoreCase))
                                   .OrderBy(x => rnd.Next())
                                   .Take(10)
                                   .ToList();

                if (dsCauHoi.Count == 0)
                {
                    MessageBox.Show($"Không tìm thấy câu hỏi nào cho cấp độ {capDo}. Vui lòng chọn cấp độ khác.");
                    FormCapDo f = new FormCapDo();
                    f.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải câu hỏi: {ex.Message}");
                FormCapDo f = new FormCapDo();
                f.Show();
                this.Hide();
            }
        }

        private CauHoi PhanTichDong(string dong)
        {
            var parts = dong.Split('|');
            return new CauHoi
            {
                NoiDung = parts[0].Trim(),
                DapAn = new string[] { parts[1].Trim(), parts[2].Trim(), parts[3].Trim(), parts[4].Trim() },
                DapAnDung = parts[5].Trim(),
                DoKho = parts.Length > 6 ? parts[6].Trim() : "Dễ"
            };
        }

        private void HienThiCauHoi()
        {
            if (chiSoHienTai >= dsCauHoi.Count)
            {
                FormDiem f = new FormDiem(diemSo, dsCauHoi.Count, capDo);
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
            timer1.Stop();
            var q = dsCauHoi[chiSoHienTai];

            // So sánh có Trim() và bỏ qua hoa/thường
            if (luaChon.Trim().Equals(q.DapAnDung.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                diemSo++;
                chiSoHienTai++;
                HienThiCauHoi();
            }
            else
            {
                FormDiem f = new FormDiem(diemSo, dsCauHoi.Count, capDo);
                f.Show();
                this.Hide();
            }
        }

        private void btnA_Click(object sender, EventArgs e) => KiemTraDapAn("A");
        private void btnB_Click(object sender, EventArgs e) => KiemTraDapAn("B");
        private void btnC_Click(object sender, EventArgs e) => KiemTraDapAn("C");
        private void btnD_Click(object sender, EventArgs e) => KiemTraDapAn("D");

        private void timer1_Tick(object sender, EventArgs e)
        {
            thoiGian--;
            lblThoiGian.Text = $"Thời gian: {thoiGian}s";
            if (thoiGian < 0)
            {
                timer1.Stop();
                FormDiem f = new FormDiem(diemSo, dsCauHoi.Count, capDo);
                f.Show();
                this.Hide();
            }
        }

        private void FormChoi_Load(object sender, EventArgs e) { }
    }

    public class CauHoi
    {
        public string NoiDung { get; set; }
        public string[] DapAn { get; set; }
        public string DapAnDung { get; set; }
        public string DoKho { get; set; }
    }
}
