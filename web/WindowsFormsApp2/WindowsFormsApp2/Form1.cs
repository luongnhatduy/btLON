using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        busdangnhap BUSTK = new busdangnhap();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string TAIKHOAN = txtTaiKhoan.Text;
            string MATKHAU = txtMatKhau.Text;
            int kp = BUSTK.Checklogin(TAIKHOAN, MATKHAU);
            if (kp == 0)
            {
                MessageBox.Show("ĐĂNG NHẬP THẤT BẠI");

            }
            else
            {
                MessageBox.Show("ĐĂNG NHẬP THANH CÔNG");
                this.Hide();
                Form2 A = new Form2();
                A.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
