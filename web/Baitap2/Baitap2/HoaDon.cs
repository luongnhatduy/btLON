using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HoaDonBUS;
using HoaDonDA;
using SqlProvider;
using CTHoaDonDA;
using CTHoaDonBUS;
namespace Baitap2
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOADONDAL cmd = new HOADONDAL();
            hoadon data = new hoadon();
            data.mahd = txtma.Text;
            data.makh = cbmakh.Text;
            data.manv = cbmanv.Text;
            data.ngaylap = dtngay.Text;
            data.tongtien = txttt.Text;


            bool kt = cmd.hoadon_insert(data);
            if (kt == false)
            {
                MessageBox.Show("Loi");
            }
            else
            {
                MessageBox.Show("Them thành công");

            }
            Load_Data("select * from HOADON");
            ComboHD();
        }
        private void Load_Data(String sql)
        {
            Sqlprovider kn = new Sqlprovider();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, kn.conn);
            dap.Fill(ds);
            dgvhd.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOADONDAL cmd = new HOADONDAL();
            hoadon data = new hoadon();
            data.mahd = txtma.Text;
            data.makh = cbmakh.Text;
            data.manv = cbmanv.Text;
            data.ngaylap = dtngay.Text;
            data.tongtien = txttt.Text;


            bool kt = cmd.hoadon_update(data);
            if (kt == false)
            {
                MessageBox.Show("Loi");
            }
            else
            {
                MessageBox.Show("Sua thành công");

            }
            Load_Data("select * from HOADON");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HOADONDAL cmd = new HOADONDAL();
            hoadon data = new hoadon();
            data.mahd = txtma.Text;


            bool kt = cmd.hoadon_delete(data);
            if (kt == false)
            {
                MessageBox.Show("Loi");
            }
            else
            {
                MessageBox.Show("Xoa thành công");

            }
            Load_Data("select * from HOADON");
        }

        private void dgvhd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvhd.Rows[e.RowIndex];

                txtma.Text = row.Cells["MAHD"].Value.ToString();
                cbmakh.Text = row.Cells["MAKH"].Value.ToString();
                cbmanv.Text = row.Cells["MANV"].Value.ToString();
                dtngay.Text = row.Cells["NGAYLAP"].Value.ToString();
                txttt.Text = row.Cells["TONGTIEN"].Value.ToString();
            }
        }
        private void Load_Data1(String sql)
        {
            Sqlprovider kn = new Sqlprovider();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, kn.conn);
            dap.Fill(ds);
            dgvcthd.DataSource = ds.Tables[0];
        }
        private void button6_Click(object sender, EventArgs e)
        {
            CTHOADONDAL cmd = new CTHOADONDAL();
            cthoadon data = new cthoadon();
            data.mahd = cbmahd.Text;
            data.mahh = cbmahh.Text;
            data.dongia = txtgia.Text;
            data.soluong = txtsl.Text;
            data.thanhtien = txtthanhtien.Text;


            bool kt = cmd.cthoadon_insert(data);
            if (kt == false)
            {
                MessageBox.Show("Loi");
            }
            else
            {
                MessageBox.Show("Them thành công");

            }
            Load_Data1("select * from CTHOADON");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CTHOADONDAL cmd = new CTHOADONDAL();
            cthoadon data = new cthoadon();
            data.mahd = cbmahd.Text;
            data.mahh = cbmahh.Text;
            data.dongia = txtgia.Text;
            data.soluong = txtsl.Text;
            data.thanhtien = txtthanhtien.Text;


            bool kt = cmd.cthoadon_update(data);
            if (kt == false)
            {
                MessageBox.Show("Loi");
            }
            else
            {
                MessageBox.Show("Sua thành công");

            }
            Load_Data1("select * from CTHOADON");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CTHOADONDAL cmd = new CTHOADONDAL();
            cthoadon data = new cthoadon();
            data.mahd = cbmahd.Text;
            data.mahh = cbmahh.Text;           
            bool kt = cmd.cthoadon_delete(data);
            if (kt == false)
            {
                MessageBox.Show("Loi");
            }
            else
            {
                MessageBox.Show("Xoa thành công");

            }
            Load_Data1("select * from CTHOADON");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvcthd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvhd.Rows[e.RowIndex];

                cbmahd.Text = row.Cells["MAHD"].Value.ToString();
                cbmahh.Text = row.Cells["MAHH"].Value.ToString();
                txtgia.Text = row.Cells["DONGIA"].Value.ToString();
                txtsl.Text = row.Cells["SOLUONG"].Value.ToString();
                txtthanhtien.Text = row.Cells["THANHTIEN"].Value.ToString();
            }
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            Load_Data1("select * from CTHOADON");
            Load_Data("select * from HOADON");

            
           
            ComboNV();
            ComboHH();
            
            

            ComboKH();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int soluong = Convert.ToInt32(txtsl.Text);
            int gia = Convert.ToInt32(txtgia.Text);
            int kq = soluong * gia;
            txtthanhtien.Text = kq.ToString();
        }

        private void cbmahh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sqlprovider kn = new Sqlprovider();
            kn.conn.Open();
            SqlCommand cmd = new SqlCommand("select * from HANGHOA where MAHH='"+cbmahh.SelectedValue.ToString()+"'", kn.conn);
            SqlDataReader Reader = cmd.ExecuteReader();
            if(Reader.HasRows)
            {
                Reader.Read();
                txtgia.Text = Reader.GetInt32(6).ToString();
            }
        
            }
        public void ComboNV()
        {
            Sqlprovider kn = new Sqlprovider();
            SqlDataAdapter da= new SqlDataAdapter("select MANV from NHANVIEN where LOAINV='Loai1'", kn.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbmanv.DisplayMember = "MANV";//Word là tên trường bạn muốn hiển thị trong combobox
            cbmanv.ValueMember = "MANV";
            cbmanv.DataSource = dt;
        }
        public void ComboHH()
        {
            Sqlprovider kn = new Sqlprovider();
            SqlDataAdapter da = new SqlDataAdapter("select MAHH from HANGHOA", kn.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbmahh.DisplayMember = "MAHH";
            cbmahh.ValueMember = "MAHH";
            cbmahh.DataSource = dt;

        }
        public void ComboHD()
        {
            Sqlprovider kn = new Sqlprovider();
            SqlDataAdapter da = new SqlDataAdapter("select MAHD from HOADON", kn.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbmahd.DisplayMember = "MAHD";
            cbmahd.ValueMember = "MAHD";
            cbmahd.DataSource = dt;
        }

        public void ComboKH()
        {
            Sqlprovider kn = new Sqlprovider();
            SqlDataAdapter da = new SqlDataAdapter("select MAKH from KHACHHANG", kn.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbmakh.DisplayMember = "MAKH";
            cbmakh.ValueMember = "MAKH";
            cbmakh.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sqlprovider kn = new Sqlprovider();
            
            SqlCommand cmd = new SqlCommand("select SUM(THANHTIEN) from CTHOADON where MAHD='" +txtma.Text+ "'", kn.conn);
            kn.conn.Open();
            int n = (int)cmd.ExecuteScalar();
            kn.conn.Close();
            txttt.Text = n.ToString();

        }
    }
}
