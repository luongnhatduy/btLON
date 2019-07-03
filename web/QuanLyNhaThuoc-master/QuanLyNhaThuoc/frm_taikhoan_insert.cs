using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Object;
using BUS;
namespace QuanLyNhaThuoc
{
    public partial class frm_taikhoan_insert : Form
    {
        UserControl_nhanvien f;
        BUS_nhanvien nv = new BUS_nhanvien();
        public frm_taikhoan_insert(UserControl_nhanvien f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void txtid_Leave(object sender, EventArgs e)
        {
            if (txtid.Text == "")
                txtid.Text = "Tên đăng nhập";
        }

        private void txtid_Enter(object sender, EventArgs e)
        {
            if (txtid.Text == "Tên đăng nhập")
                txtid.Text = "";
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Mật khẩu";
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Mật khẩu")
            {
                txtpassword.Text = "";
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void frm_taikhoan_insert_Load(object sender, EventArgs e)
        {
            // comboBox1.DataSource = f.tb;
            //comboBox1.DisplayMember = f.dg_nhanvien.Columns[5].Name;
            comboBox1.Items.Add("Quản lí");
            comboBox1.Items.Add("Bán hàng");
            comboBox1.Items.Add("Kho");
            comboBox1.SelectedIndex = comboBox1.FindStringExact("Bán hàng");
            switch (f.button)
            {
                case "insert":
                    txtid.Enabled = true;
                    txtpassword.Enabled = true;


                    break;
                case "update":
                    txtid.Enabled = false;
                    txtpassword.Enabled = false;
                    txtid.Text = f.dg_nhanvien.Rows[f.dg_nhanvien.CurrentRow.Index].Cells[4].Value.ToString();
            
                    txtpassword.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string quyen = "";
            switch (comboBox1.Text)
            {
                case "Quản lí":
                    quyen = "1";
                    break;
                case "Bán hàng":
                    quyen = "2";
                    break;
                case "Kho":
                    quyen = "3";
                    break;
            }

            switch (f.button)
            {
                case "insert":
                    
                    int kq = nv.check_id(txtid.Text.ToString().Trim());
                    if (kq != 0)
                    {
                        MessageBox.Show("Trùng tên đăng nhập");
                    }
                    else
                    {
                        if (txtpassword.Text.Trim().Equals("")) MessageBox.Show("Không để trống mật khẩu");
                        else
                        {
                            nv.taotaikhoan(txtid.Text, txtpassword.Text, f.dg_nhanvien.Rows[f.dg_nhanvien.CurrentRow.Index].Cells[0].Value.ToString(), quyen);
                            f.load();
                            this.Close();
                        }
                        
                    }
                    break;
                case "update":
                    txtid.Enabled = false;
                    txtpassword.Enabled = false;
                    txtpassword.UseSystemPasswordChar = true;
                    nv.capquyentaikhoan(txtid.Text, quyen);
                    f.load();
                    this.Close();
                    break;
            }
           
        }
    }
}
