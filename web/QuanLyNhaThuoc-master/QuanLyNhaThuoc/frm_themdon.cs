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
    public partial class frm_themdon : Form
    {
        string file_img = "";
        BUS_donthuoc donthuoc = new BUS_donthuoc();
        UserControl_khachhang f = new UserControl_khachhang();
        public frm_themdon(UserControl_khachhang form)
        {
            InitializeComponent();
            f = form;
        }

        private void btn_anh_Click(object sender, EventArgs e)
        {
           // openFileDialog1.ShowDialog();
          //  openFileDialog1.Filter = "bmp files (*.bmp)|*.bmp";
            
            
   
           // if (string.IsNullOrEmpty(file) || file.Equals("openFileDialog1")) return;
            //Image img = Image.FromFile(file);
           // pictureBox1.Image = img;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                //dlg.Filter = "bmp files (*.bmp)|*.bmp";
                dlg.Filter = "Image files|*.png;*.jpg;*.bmp;*.gif;*.tif";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    
                    file_img = dlg.FileName;
                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    Image img = Image.FromFile(file_img);
                    pictureBox1.Image = img;
                    
                }
            }

            
        }

        bool check(string madon)
        {
            bool c = false;
            // true = tồn tại

           

            for (int i = 0; i < f.dg_donthuoc.RowCount; i++)
            {
                string s = f.dg_donthuoc.Rows[i].Cells[0].Value.ToString().Trim();
                if (madon.Equals(s))
                {
                   
                    return true;
                }
            }
            return c;
        }

        void themdl()
        {
            donthuoc t = new donthuoc();
            t.Madon = txt_madon.Text.ToString();
            t.Tendon = txt_tendon.Text;
            t.MaKH = f.dg_khachhang.Rows[f.dg_khachhang.CurrentRow.Index].Cells[0].Value.ToString();
            string[] date = DateTime.Now.ToString().Split(' ');
            t.Ngay = date[0];
            t.Ghichu = txt_ghichu.Text;
            t.Anh = file_img;

            donthuoc.insert(t);
            f.load_donthuoc();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (file_img.Equals("") || txt_madon.Equals(""))
            {
                MessageBox.Show("Không để trống mã đơn/Ảnh");
            }
            else
            {   
                if (!check(txt_madon.Text))
                {
                    themdl();
                    f.load_donthuoc();
                    f.load();
                }
                else MessageBox.Show("Trùng mã đơn");

            }
        }
    }
}
