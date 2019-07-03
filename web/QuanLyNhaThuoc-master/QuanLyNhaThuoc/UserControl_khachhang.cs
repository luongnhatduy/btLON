using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Object;
namespace QuanLyNhaThuoc
{
    public partial class UserControl_khachhang : UserControl

    {
        public BUS_khachHang t = new BUS_khachHang();
        public BUS_donthuoc donthuoc = new BUS_donthuoc();
        public DataTable tb = new DataTable();
        
        public string button = "insert";
        public UserControl_khachhang()
        {
            InitializeComponent();
            load();
            //
           // DataGridViewImageColumn c = new DataGridViewImageColumn();
          //  c.Name = "Ảnh đơn thuốc";
            
           // dg_khachhang.Columns.Insert(3, c);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            button = "insert";
            //loaithuoc = dg_thuoc.Rows[dg_thuoc.CurrentRow.Index].Cells[1].Value.ToString();
           // MessageBox.Show(dg_khachhang.Rows[dg_khachhang.CurrentRow.Index].Cells[0].Value.ToString());
            
            frm_insert_khachhang f = new frm_insert_khachhang(this);
            
            f.ShowDialog();
        }
        public void load()
        {

            tb = t.select();
            dg_khachhang.DataSource = tb;
            if (dg_khachhang.RowCount == 0)
            {
                button4.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                btn_xoa.Enabled = false;
                button5.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button4.Enabled = true;
                btn_xoa.Enabled = true;
                button5.Enabled = true;
            }
            
        }
        public void load_donthuoc()
        {
            if(dg_donthuoc.RowCount == 0)
            {
                btn_xoa.Enabled = true;
                button5.Enabled = true;
            }
            else
            {
                btn_xoa.Enabled = false;
                button5.Enabled = false;
            }
            dg_donthuoc.DataSource = donthuoc.select(dg_khachhang.Rows[dg_khachhang.CurrentRow.Index].Cells[0].Value.ToString());

        }


        private void UserControl_khachhang_Load(object sender, EventArgs e)
        {
            load_donthuoc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button = "update";
            //loaithuoc = dg_thuoc.Rows[dg_thuoc.CurrentRow.Index].Cells[1].Value.ToString();
            frm_insert_khachhang f = new frm_insert_khachhang(this);
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_themdon f = new frm_themdon(this);
            f.ShowDialog();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            donthuoc d = new donthuoc();
            d.Madon = dg_donthuoc.Rows[dg_donthuoc.CurrentRow.Index].Cells[0].Value.ToString();
            donthuoc.delete(d);
            load_donthuoc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            khachHang k = new khachHang();
            k.MaKH = dg_khachhang.Rows[dg_khachhang.CurrentRow.Index].Cells[0].Value.ToString();
            if (dg_donthuoc.RowCount == 0)
            {
                t.delete(k);
                load();
            }
            else MessageBox.Show("Không thể xóa");
        }

        private void dg_khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dg_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            load_donthuoc();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {   

            string pathh = dg_donthuoc.Rows[dg_donthuoc.CurrentRow.Index].Cells[4].Value.ToString();
            frm_xemanh f = new frm_xemanh(pathh);
            f.ShowDialog();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            (dg_khachhang.DataSource as DataTable).DefaultView.RowFilter =
            string.Format("[Tên khách hàng] LIKE '{0}%' ", txttimkiem.Text);
        }
    }
}
