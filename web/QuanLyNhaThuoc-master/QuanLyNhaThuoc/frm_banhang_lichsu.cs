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
namespace QuanLyNhaThuoc
{
    public partial class frm_banhang_lichsu : Form
    {
        UserControl_banhang f;
        BUS_hoaDon hd = new BUS_hoaDon();
        BUS_ctHoadon cthd = new BUS_ctHoadon();
        public frm_banhang_lichsu(UserControl_banhang f)
        {
            InitializeComponent();
            this.f = f;
            load_hoadon();
            //load_cthoadon();
        }

        private void load_hoadon()
        {
            dg_hoadon.DataSource = hd.select();
            if (dg_hoadon.RowCount != 0)
                dg_cthoadon.DataSource = cthd.select(dg_hoadon.Rows[0].Cells[0].Value.ToString());
        }
        private void load_cthoadon()
        {   
            if(dg_hoadon.RowCount != 0)
            dg_cthoadon.DataSource = cthd.select(dg_hoadon.Rows[dg_hoadon.CurrentRow.Index].Cells[0].Value.ToString());
            
        }

        private void frm_banhang_lichsu_Load(object sender, EventArgs e)
        {

        }

        private void dg_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            (dg_hoadon.DataSource as DataTable).DefaultView.RowFilter =
            string.Format("[Mã hóa đơn] LIKE '{0}%' ", txttimkiem.Text);
            if (dg_hoadon.RowCount != 0) load_cthoadon();
        }

        private void dg_cthoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            load_cthoadon();
        }
    }
}
