using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bus;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        busnguoidung BUSTK = new busnguoidung();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TAIKHOAN = txttk.Text;
            string MATKHAU = txtmk.Text;
            int kp = BUSTK.Checklogin(TAIKHOAN, MATKHAU);
            if (kp == 0)
            {
                MessageBox.Show("ĐĂNG NHẬP THẤT BẠI");

            }
            else
            {
                MessageBox.Show("ĐĂNG NHẬP thành công");
                this.Hide();
                Form2 A = new Form2();
                A.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}
