using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using Object;
namespace QuanLyNhaThuoc
{
    public partial class UserControl_thuoc : UserControl
    {
        public BUS_thuoc t = new BUS_thuoc();
        public DataTable tb = new DataTable();
        public string loaithuoc= "";
        public string button = "insert";
        public UserControl_thuoc()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            button = "insert";
            //loaithuoc = dg_thuoc.Rows[dg_thuoc.CurrentRow.Index].Cells[1].Value.ToString();
            frm_thuoc_insert f = new frm_thuoc_insert(this);
            f.ShowDialog();
        }

        private void UserControl_thuoc_Load(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {   
           
            tb = t.select();
            dg_thuoc.DataSource = tb;
            if (dg_thuoc.RowCount == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button = "update";
            frm_thuoc_insert f = new frm_thuoc_insert(this);
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {      
            thuoc t = new thuoc();
            t.Mathuoc = dg_thuoc.Rows[dg_thuoc.CurrentRow.Index].Cells[0].Value.ToString();
            this.t.delete(t);
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!txttimkiem.Equals("")) dg_thuoc.DataSource = t.search(txttimkiem.Text);
            else dg_thuoc.DataSource = t.select();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            (dg_thuoc.DataSource as DataTable).DefaultView.RowFilter =
            string.Format("[Tên thuốc] LIKE '{0}%' ", txttimkiem.Text);
        }
    }
}
