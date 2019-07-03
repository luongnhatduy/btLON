using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bus1;
namespace QuanLiSinhVien
{
    public partial class DangNhap : Form
        
    {
        bus_nguoidung BUSTK = new bus_nguoidung();
        public DangNhap()
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
                CHINH A = new CHINH();
                A.Show();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txttdn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
