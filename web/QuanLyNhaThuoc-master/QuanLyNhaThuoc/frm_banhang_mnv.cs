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
    public partial class frm_banhang_mnv : Form
    {
        UserControl_banhang f;
        public frm_banhang_mnv(UserControl_banhang f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            getData();
            this.Close();
        }
        public void getData()
        {

            f.txt_makhachhang.Text = userControl_khachhang1.dg_khachhang.Rows[userControl_khachhang1.dg_khachhang.CurrentRow.Index].Cells[0].Value.ToString();
            f.txt_tenkh.Text = userControl_khachhang1.dg_khachhang.Rows[userControl_khachhang1.dg_khachhang.CurrentRow.Index].Cells[1].Value.ToString();
        }
    }
}
