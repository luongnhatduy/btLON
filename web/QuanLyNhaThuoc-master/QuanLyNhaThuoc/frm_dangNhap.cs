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
using Object;

namespace QuanLyNhaThuoc
{
    public partial class frm_dangNhap : Form
    {
        private BUS_nhanvien nv = new BUS_nhanvien();
        public nguoiDung nd = new nguoiDung();
        private BUS_nguoidung data = new BUS_nguoidung();
        
        public frm_dangNhap()
        {
            InitializeComponent();
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kq = nv.dangNhap(txtid.Text, txtpassword.Text);
            if (kq == 0)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
            else
            {
                // thuoc f = new thuoc();
              
                //nd.quyen = 
                frm_trangchu f = new frm_trangchu(this);
                nd = data.getData(txtid.Text);
                nd.Matkhau = txtpassword.Text;
                this.Hide();
                f.ShowDialog();
                
            }
           
        }

        private void txtid_Enter(object sender, EventArgs e)
        {   
            if (txtid.Text == "Tên đăng nhập")
            txtid.Text = "";
        }

        private void txtid_Leave(object sender, EventArgs e)
        {
            if (txtid.Text == "")
                txtid.Text = "Tên đăng nhập";
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Mật khẩu")
            {
                txtpassword.Text = "";
                txtpassword.UseSystemPasswordChar = false;
            } 
                
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                 txtpassword.Text = "Mật khẩu";
                txtpassword.UseSystemPasswordChar = true;
            }
               
        }

        private void frm_dangNhap_Load(object sender, EventArgs e)
        {
            
        }
    }
}
