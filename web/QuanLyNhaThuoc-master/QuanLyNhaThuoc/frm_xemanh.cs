using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaThuoc
{
    public partial class frm_xemanh : Form
    {
        public frm_xemanh(string path)
        {
            InitializeComponent();
            Image img = Image.FromFile(path);
            //
            pictureBox1.Image = img;
          //  this.Size = pictureBox1.Size;
            this.Size = new System.Drawing.Size(img.Width+25, img.Height+40);
        }

        private void frm_xemanh_Load(object sender, EventArgs e)
        {
                    }
    }
}
