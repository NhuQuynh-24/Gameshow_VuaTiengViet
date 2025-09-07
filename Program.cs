using System;
using System.Windows.Forms;

namespace Gameshow_VuaTiengViet
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Chạy form đăng nhập trước
            Application.Run(new FormDangNhap());
        }
    }
}
