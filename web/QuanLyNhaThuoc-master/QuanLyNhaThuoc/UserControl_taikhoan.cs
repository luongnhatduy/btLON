using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Object;
using BUS;
namespace QuanLyNhaThuoc
{
    public partial class UserControl_taikhoan : UserControl
    {
        public nguoiDung nd = new nguoiDung();
        private BUS_nguoidung nguoidung = new BUS_nguoidung();
        public UserControl_taikhoan()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UserControl_taikhoan_Load(object sender, EventArgs e)
        {
            

        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbox.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            } else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
            ((Form)this.TopLevelControl).Close();
            frm_trangchu f = (frm_trangchu)this.Parent.Parent;
            f.ff.Show();
            
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đổi mật khẩu thành công");
            checkbox.Checked = false;
           // frm_trangchu parentForm = (this.Parent as frm_trangchu);
            frm_trangchu f = (frm_trangchu)this.Parent.Parent;
            //MessageBox.Show(f.nd.Ten);
            string pass = txtpassword.Text;
            nguoidung.changePass(f.nd.Tendangnhap, pass);
            txtpassword.Text = pass;
        }

        private void lb_id_Click(object sender, EventArgs e)
        {

        }
    }
}
