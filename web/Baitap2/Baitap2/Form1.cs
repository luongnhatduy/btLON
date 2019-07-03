using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhanVienDAL;
using NhanVien;
namespace Baitap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVienSer cmd = new NhanVienSer();
            bool kt = cmd.nguoidung_CheckLogin(txttdn.Text, txtmk.Text);
            if (kt == false)
            {
                MessageBox.Show("Sai tài khoản/mật khẩu");
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công");
                main m = new main();
                m.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
