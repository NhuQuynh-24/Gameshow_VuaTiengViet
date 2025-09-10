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
        private List<bool> ketQuaTraLoi = new List<bool>();
        private string capDo;
        private int thoiGian = 30;
        private string de = "de.txt";
        private string trungbinh = "trungbinh.txt";
        private string kho = "kho.txt";
        private Random rnd = new Random();

        public FormChoi(string capDo)
        {
            InitializeComponent();
            this.capDo = capDo;
            this.FormClosing += FormChoi_FormClosing;
            TaiCauHoi();
            HienThiCauHoi();
        }

        private void FormChoi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TaiCauHoi()
        {
            try
            {
                string filePath = "";
                string projectPath = AppDomain.CurrentDomain.BaseDirectory;
                if (this.capDo == "1") filePath = Path.Combine(projectPath, de);
                if (this.capDo == "2") filePath = Path.Combine(projectPath, trungbinh);
                if (this.capDo == "3") filePath = Path.Combine(projectPath, kho);

                // Read all lines from the file
                var tatCaDong = File.ReadAllLines(filePath);

                // Parse all questions from the file
                var danhSach = tatCaDong.Select(PhanTichDong).ToList();

                // Lấy 10 câu hỏi ngẫu nhiên từ file (không cần lọc theo cấp độ nữa)
                dsCauHoi = danhSach.OrderBy(x => rnd.Next())
                                   .Take(10)
                                   .ToList();

                if (dsCauHoi.Count == 0)
                {
                    MessageBox.Show($"Không tìm thấy câu hỏi nào trong file. Vui lòng kiểm tra lại file dữ liệu.");
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
                DoKho = parts.Length > 6 ? parts[6].Trim() : capDo // Sử dụng capDo làm mặc định
            };
        }

        private void HienThiCauHoi()
        {
            if (chiSoHienTai >= dsCauHoi.Count)
            {
                // Kết thúc 10 câu, chuyển sang FormDiem
                FormDiem f = new FormDiem(diemSo, dsCauHoi.Count, capDo, ketQuaTraLoi);
                f.Show();
                this.Hide();
                return;
            }

            var q = dsCauHoi[chiSoHienTai];
            lblCauHoi.Text = $"Câu {chiSoHienTai + 1}: {q.NoiDung}";
            btnA.Text = "A. " + q.DapAn[0];
            btnB.Text = "B. " + q.DapAn[1];
            btnC.Text = "C. " + q.DapAn[2];
            btnD.Text = "D. " + q.DapAn[3];

            // Reset màu và enable các nút
            btnA.BackColor = btnB.BackColor = btnC.BackColor = btnD.BackColor = Color.LightYellow;
            btnA.Enabled = btnB.Enabled = btnC.Enabled = btnD.Enabled = true;
            lblKetQua.Text = "";

            thoiGian = 20;
            lblThoiGian.Text = $"Thời gian: {thoiGian}s";
            lblSoCauDung.Text = $"Số câu đúng: {diemSo}/{chiSoHienTai}";
            timer1.Start();
        }

        private void KiemTraDapAn(string luaChon)
        {
            timer1.Stop();
            var q = dsCauHoi[chiSoHienTai];
            bool dung = luaChon.Trim().Equals(q.DapAnDung.Trim(), StringComparison.OrdinalIgnoreCase);
            ketQuaTraLoi.Add(dung);
            if (dung) diemSo++;

            // Hiển thị đáp án đúng/sai và tô màu
            Button[] nut = { btnA, btnB, btnC, btnD };
            string[] ma = { "A", "B", "C", "D" };
            for (int i = 0; i < 4; i++)
            {
                nut[i].Enabled = false;
                if (ma[i] == q.DapAnDung.Trim().ToUpper())
                    nut[i].BackColor = Color.LightGreen;
                else if (ma[i] == luaChon.ToUpper())
                    nut[i].BackColor = Color.LightCoral;
            }
            if (dung)
            {
                lblKetQua.Text = "Chính xác!";
                lblKetQua.ForeColor = Color.Green;
            }
            else
            {
                lblKetQua.Text = $"Sai! Đáp án đúng là: {q.DapAnDung.ToUpper()}";
                lblKetQua.ForeColor = Color.Red;
            }
            lblSoCauDung.Text = $"Số câu đúng: {diemSo}/{chiSoHienTai + 1}";

            // Chuyển sang câu tiếp theo sau 1.2s
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 1200;
            t.Tick += (s, e) =>
            {
                t.Stop();
                chiSoHienTai++;
                HienThiCauHoi();
            };
            t.Start();
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
                // Trả lời sai do hết giờ
                KiemTraDapAn(""); // Không chọn đáp án nào
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