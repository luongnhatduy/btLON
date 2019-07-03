using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlProvider;

using System.Data.SqlClient;
using NhaCungCapDA;
namespace Baitap2
{
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NHACUNGCAPDAL cmd = new NHACUNGCAPDAL();
            nhacungcap data = new nhacungcap();
            data.mancc = txtma.Text;
            data.tenncc = txtten.Text;
            data.diachi = txtdiachi.Text;
            data.dienthoai = txtsdt.Text;
            

            bool kt = cmd.nhacungcap_insert(data);
            if (kt == false)
            {
                MessageBox.Show("Loi");
            }
            else
            {
                MessageBox.Show("Them thành công");

            }
            Load_Data("select * from NHACUNGCAP");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NHACUNGCAPDAL cmd = new NHACUNGCAPDAL();
            nhacungcap data = new nhacungcap();
            data.mancc = txtma.Text;
            data.tenncc = txtten.Text;
            data.diachi = txtdiachi.Text;
            data.dienthoai = txtsdt.Text;


            bool kt = cmd.nhacungcap_update(data);
            if (kt == false)
            {
                MessageBox.Show("Loi");
            }
            else
            {
                MessageBox.Show("Sửa thành công");

            }
            Load_Data("select * from NHACUNGCAP");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NHACUNGCAPDAL cmd = new NHACUNGCAPDAL();
            nhacungcap data = new nhacungcap();
            data.mancc = txtma.Text;
            data.tenncc = txtten.Text;
            data.diachi = txtdiachi.Text;
            data.dienthoai = txtsdt.Text;


            bool kt = cmd.nhacungcap_delete(data);
            if (kt == false)
            {
                MessageBox.Show("Loi");
            }
            else
            {
                MessageBox.Show("Xóa thành công");

            }
            Load_Data("select * from NHACUNGCAP");
        }
        private void Load_Data(String sql)
        {
            Sqlprovider kn = new Sqlprovider();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, kn.conn);
            dap.Fill(ds);
            dgvncc.DataSource = ds.Tables[0];
        }

        private void dgvncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvncc.Rows[e.RowIndex];

                txtma.Text = row.Cells["MANCC"].Value.ToString();
                txtten.Text = row.Cells["TENNCC"].Value.ToString();
                txtdiachi.Text = row.Cells["DIACHI"].Value.ToString();
                txtsdt.Text = row.Cells["DIENTHOAI"].Value.ToString();
                
            }
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            Load_Data("select * from NHACUNGCAP");
        }
    }
}
