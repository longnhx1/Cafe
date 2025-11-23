using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.GUI
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Text;

            // Kiểm tra demo
            if (user == "admin" && pass == "123456")
            {
                // Hiển thị thông báo đẹp của Guna (nếu có dùng Guna2MessageDialog)
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");

                // Mở Form chính
                MainForm f = new MainForm();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }
    }
}
