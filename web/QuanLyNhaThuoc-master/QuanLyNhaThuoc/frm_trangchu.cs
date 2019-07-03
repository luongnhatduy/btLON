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
namespace QuanLyNhaThuoc
{
    public partial class frm_trangchu : Form
    {
        public frm_dangNhap ff;
        public nguoiDung nd = new nguoiDung();
        public string test = "sss";
        public frm_trangchu(frm_dangNhap f)
        {
            InitializeComponent();
            ff = f;
            // userControl_taikhoan1.ParentForm = this;
          
        }

        private void userControl_thuoc1_Load(object sender, EventArgs e)
        {
            userControl_thuoc1.btn_them.Enabled = false;
        }

        private void frm_trangchu_Load(object sender, EventArgs e)
        {
            panel_side.Height = btn_thuoc.Height;
            panel_side.Top = btn_thuoc.Top;
            userControl_thuoc1.BringToFront();
            label2.Text = ff.nd.Ten;
            
            //userControl_taikhoan1.nd = ff.nd;
            nd = ff.nd;
            userControl_taikhoan1.lb_id.Text = ff.nd.Tendangnhap;
            userControl_taikhoan1.lb_quyentruycap.Text = ff.nd.Quyen;
            userControl_taikhoan1.txtpassword.Text = "" + ff.nd.Matkhau;
            userControl_banhang1.txt_mnv.Text = ff.nd.Manv;
            //  -------------------------------------------
            /*  
            List<khachHang> l = new List<khachHang>();
            khachHang k = new khachHang();
            khachHang k2 = new khachHang();
            k.TenKH = "1";
            k.MaKH = "mot";
            l.Add(k);
            k2.TenKH = "2";
            k2.MaKH = "hai";
            l.Add(k2);
            comboBox1.DataSource = l;
            comboBox1.DisplayMember = "Makh"; // Tên thuộc tính hiển thị
            comboBox1.ValueMember = "TenKH"; // Giá trị mà nó nhận ví dụ chọn tên khách hàng trả về mã khách hàng
            MessageBox.Show(comboBox1.SelectedValue.ToString());  // Lấy giá trị
            //  -------------------------------------------
             */
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát?", "", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                this.Close();
                ff.Close();
            }
            
        }

        private void btn_thuoc_Click(object sender, EventArgs e)
        {
            panel_side.Height = btn_thuoc.Height;
            panel_side.Top = btn_thuoc.Top;
            userControl_thuoc1.BringToFront();
           // MessageBox.Show("s");
            
        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {   //quyen = 1 2 3 -> ql banhhang kho
            
            if (nd.Quyen.Trim() == "1" || nd.Quyen.Trim() == "2")
            {
                panel_side.Height = btn_banhang.Height;
                userControl_banhang1.BringToFront();
                panel_side.Top = btn_banhang.Top;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền vào đây");
            }
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            panel_side.Height = btn_taikhoan.Height;
            userControl_taikhoan1.BringToFront();
            panel_side.Top = btn_taikhoan.Top;
        }

        private void lb_name_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_kho_Click(object sender, EventArgs e)
        {
            if (nd.Quyen.Trim() == "1" || nd.Quyen.Trim() == "3")
            {
                panel_side.Height = btn_kho.Height;
                userControl_kho1.BringToFront();
                panel_side.Top = btn_kho.Top;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền vào đây");
            }

        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            if (nd.Quyen.Trim() == "1" )
            {
                panel_side.Height = btn_nhanvien.Height;
                userControl_nhanvien1.BringToFront();
                panel_side.Top = btn_nhanvien.Top;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền vào đây");
            }
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            panel_side.Height = btn_khachhang.Height;
            userControl_khachhang1.BringToFront();
            panel_side.Top = btn_khachhang.Top;
        }

        private void frm_trangchu_Shown(object sender, EventArgs e)
        {

        }
    }
}
