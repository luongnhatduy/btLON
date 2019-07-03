using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HangHoaDA;
using System.Data.SqlClient;
using SqlProvider;
namespace Baitap2
{
    public partial class HangHoa : Form
    {
        public HangHoa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HANGHOADAL cmd = new HANGHOADAL();
            hanghoa data = new hanghoa();
            data.mahh = txtma.Text;
            data.tenhh = txtten.Text;
            data.dvt = cbdvt.Text;
            data.loaihh = cbloai.Text;
            data.soluong = txtsoluong.Text;
            data.soluonggiam = txtsoluonggiam.Text;
            data.gia = txtgia.Text;
            


            bool kt = cmd.hanghoa_insert(data);
            if (kt == false)
            {
                MessageBox.Show("Loi");
            }
            else
            {
                MessageBox.Show("Them thành công");

            }
            Load_Data("select * from HANGHOA");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HANGHOADAL cmd = new HANGHOADAL();
            hanghoa data = new hanghoa();
            data.mahh = txtma.Text;
            data.tenhh = txtten.Text;
            data.dvt = cbdvt.Text;
            data.loaihh = cbloai.Text;
            data.soluong = txtsoluong.Text;
            data.soluonggiam = txtsoluonggiam.Text;
            data.gia = txtgia.Text;



            bool kt = cmd.hanghoa_update(data);
            if (kt == false)
            {
                MessageBox.Show("Loi");
            }
            else
            {
                MessageBox.Show("Sửa thành công");

            }
            Load_Data("select * from HANGHOA");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HANGHOADAL cmd = new HANGHOADAL();
            hanghoa data = new hanghoa();
            data.mahh = txtma.Text;
            
            bool kt = cmd.hanghoa_delete(data);
            if (kt == false)
            {
                MessageBox.Show("Loi");
            }
            else
            {
                MessageBox.Show("Xóa thành công");

            }
            Load_Data("select * from HANGHOA");
        }

        private void Load_Data(String sql)
        {
            Sqlprovider kn = new Sqlprovider();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, kn.conn);
            dap.Fill(ds);
            dgvhh.DataSource = ds.Tables[0];
        }

        private void dgvhh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvhh.Rows[e.RowIndex];

                txtma.Text = row.Cells["MAHH"].Value.ToString();
                txtten.Text = row.Cells["TENHH"].Value.ToString();
                cbdvt.Text = row.Cells["DVT"].Value.ToString();
                cbloai.Text = row.Cells["LOAIHH"].Value.ToString();
                txtsoluong.Text = row.Cells["SOLUONG"].Value.ToString();
                txtsoluonggiam.Text = row.Cells["SOLUONGGIAM"].Value.ToString();
                txtgia.Text = row.Cells["GIA"].Value.ToString();

            }
        }

        private void HangHoa_Load(object sender, EventArgs e)
        {
            Load_Data("select * from HANGHOA");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Load_Data("select * from HANGHOA where TENHH='"+txttkten.Text+"'");
        }

        
        

        private void button6_Click(object sender, EventArgs e)
        {
            Load_Data("select * from HANGHOA where LOAIHH='"+comboBox1.Text+"'");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sqlprovider kn = new Sqlprovider();

            SqlCommand cmd = new SqlCommand("select SUM(SOLUONG) from CTHOADON where MAHH='" + txtma.Text + "'", kn.conn);
            kn.conn.Open();
            int n = (int)cmd.ExecuteScalar();
            kn.conn.Close();
            txtsoluonggiam.Text = n.ToString();
        }
    }
}
