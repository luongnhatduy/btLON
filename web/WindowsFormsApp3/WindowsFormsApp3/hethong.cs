using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class hethong : Form
    {
        public hethong()
        {
            InitializeComponent();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVien A = new NhanVien();
            A.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SanPham A = new SanPham();
            A.Show();
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuNhap A = new PhieuNhap();
            A.Show();
        }
    }
}
