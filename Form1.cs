namespace Gameshow_VuaTiengViet
{
    public partial class FormDangNhap : Form
    {
        public static string TenNguoiChoi = "";

        public FormDangNhap()
        {
            InitializeComponent();
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

        private void FromDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
