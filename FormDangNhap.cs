namespace Gameshow_VuaTiengViet
{
    public partial class FormDangNhap : Form
    {
        public static string TenNguoiChoi = "";

        public FormDangNhap()
        {
            InitializeComponent();
            Load += FormDangNhap_Load;

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TenNguoiChoi = txtTenNguoiChoi.Text;
            if (string.IsNullOrWhiteSpace(TenNguoiChoi))
            {
                MessageBox.Show("Vui lòng nhập tên người chơi!");
                return;
            }
            FormCapDo f = new FormCapDo();
            f.Show();
            this.Hide();
        }

        private void FormDangNhap_Load(object sender, EventArgs e) { }

        
    }
}
