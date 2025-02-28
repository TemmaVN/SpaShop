using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaShop.Entity;

namespace SpaShop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (TenDangNhapTb.Text == "TemmaVN" && MatKhauTb.Text == "Khoitoc123")
            {
                QuanLi quanLi = new QuanLi();
                this.Hide();
                quanLi.ShowDialog();
                this.Show();
            }
            //else
            {
                MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ThoatBT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?",
                                          "Xác nhận thoát",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
