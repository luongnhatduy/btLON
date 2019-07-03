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
    public partial class frm_kho_thuoc : Form
    {
        frm_kho_insert f;
        public frm_kho_thuoc(frm_kho_insert f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void userControl_thuoc1_Load(object sender, EventArgs e)
        {

        }

        private void txt_chon_Click(object sender, EventArgs e)
        {
            f.txt_mathuoc.Text = userControl_thuoc1.dg_thuoc.Rows[userControl_thuoc1.dg_thuoc.CurrentRow.Index].Cells[0].Value.ToString();
            f.txt_tenthuoc.Text = userControl_thuoc1.dg_thuoc.Rows[userControl_thuoc1.dg_thuoc.CurrentRow.Index].Cells[1].Value.ToString();
            this.Close();
        }
    }
}
