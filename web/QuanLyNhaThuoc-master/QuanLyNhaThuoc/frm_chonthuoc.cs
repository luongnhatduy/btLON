using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Object;

namespace QuanLyNhaThuoc
{
    public partial class frm_chonthuoc : Form
    {
        UserControl_banhang f;
        private BUS_loThuoc lothuoc = new BUS_loThuoc();
        public frm_chonthuoc(UserControl_banhang f)
        {
            InitializeComponent();
            this.f = f;
            load_kho();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            getData();
            this.Close();
      
        }

        private void frm_chonthuoc_Load(object sender, EventArgs e)
        {

        }
        public void load_kho()
        {
           
            dg_kho.DataSource = lothuoc.select_banra();

        }

        public void getData()
        {

            f.txt_mathuoc.Text = dg_kho.Rows[dg_kho.CurrentRow.Index].Cells[1].Value.ToString();
            f.txt_solo.Text = dg_kho.Rows[dg_kho.CurrentRow.Index].Cells[0].Value.ToString();
            f.txt_tenthuoc.Text = dg_kho.Rows[dg_kho.CurrentRow.Index].Cells[2].Value.ToString();
            f.txt_soluong.Maximum = Int32.Parse(dg_kho.Rows[dg_kho.CurrentRow.Index].Cells[3].Value.ToString());
            f.txt_dongia.Text = dg_kho.Rows[dg_kho.CurrentRow.Index].Cells[9].Value.ToString();
            string[] date = dg_kho.Rows[dg_kho.CurrentRow.Index].Cells[4].Value.ToString().Split(' ');
            string[] date2 = dg_kho.Rows[dg_kho.CurrentRow.Index].Cells[5].Value.ToString().Split(' ');
            // MessageBox.Show(date[0]);
            f.dateTimePicker_nsx.Value = DateTime.Parse(date[0]);
            f.dateTimePicker_hsd.Value = DateTime.Parse(date2[0]);

        }

        private void dg_kho_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            getData();
            this.Close();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            (dg_kho.DataSource as DataTable).DefaultView.RowFilter =
            string.Format("[Tên thuốc] LIKE '{0}%' ", txttimkiem.Text);
        }
    }
}
