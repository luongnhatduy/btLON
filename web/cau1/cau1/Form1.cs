using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Double.Parse(txta.Text);
            b = Double.Parse(txtb.Text);
            c = Double.Parse(txtc.Text);

            double d, x1, x2;
            d = b * b - 4 * a * c;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0) txtKetQua.Text = " Phuong trinh vo so nghiem  ";
                    else txtKetQua.Text = " Phuong trinh vo nghiem  ";
                }
                else
                {
                    x1 = -c/b;
                    txtKetQua.Text = "Nghiem duy nhat cua phuong trinh la x= " + x1;
                }
            }
            else
            {
               
                if (d < 0) txtKetQua.Text = " Phuong trinh vo nghiem  ";
                if (d == 0)
                {
                    x1 = -b / (2 * a);
                    txtKetQua.Text = "phuong trinh co nghiem kep la x= " + x1;
                }
                if (d > 0)
                {
                    txtKetQua.Text = "Phuong trinh co hai nghiem thuc phan biet ";

                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    txtKetQua.Text += "Nghiem thu nhat: x1 =" + x1;

                    txtKetQua.Text += "    Nghiem thu nhat: x2 =" + x2;
                }
            }
        }
    }
}
