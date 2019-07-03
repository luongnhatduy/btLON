using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;
namespace WindowsFormsApp3
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPham A = new SanPham();
            A.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            hethong A = new hethong();
            A.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPham A = new SanPham();
            A.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            SanPham A = new SanPham();
            A.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            hethong A = new hethong();
            A.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            bushoadon bus_mt = new bushoadon();
            DataTable dt = bus_mt.select();
            dataGridView1.DataSource = dt;

        }
        public void LoadData1()
        {
            buskhachhang bus_cv = new buskhachhang();
            DataTable dt = bus_cv.select();
            dataGridView4.DataSource = dt;

        }
        public void LoadData2()
        {
            buscthoadon bus_cv = new buscthoadon();
            DataTable dt = bus_cv.select();
            dataGridView3.DataSource = dt;

        }
        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData1();
            LoadData2();
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dtohoadon MT = new dtohoadon(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            try
            {
                bushoadon bus_mt = new bushoadon();
                bus_mt.insert(MT);
                LoadData();
                MessageBox.Show("thêm thành công");
            }
            catch
            {
                MessageBox.Show("thêm không thành công");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dtohoadon MT = new dtohoadon(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            try
            {
                bushoadon bus_mt = new bushoadon();
                bus_mt.update(MT);
                LoadData();
                MessageBox.Show("sửa thành công");
            }
            catch
            {
                MessageBox.Show("sửa không thành công");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dtohoadon MT = new dtohoadon(textBox7.Text,null, null, null, null, null);
            try
            {
                bushoadon bus_mt = new bushoadon();
                bus_mt.delete(MT);
                LoadData();
                MessageBox.Show("xóa thành công");
            }
            catch
            {
                MessageBox.Show("xóa không thành công");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                bushoadon bus_nv = new bushoadon();
                dt = bus_nv.search(textBox16.Text);
                dataGridView1.DataSource = dt;
                MessageBox.Show("tìm kiếm thành công");
            }
            catch
            {
                MessageBox.Show("tìm kiếm không thành công");
            }
        }

        private void dataGridView4_Click(object sender, EventArgs e)
        {
            int n = dataGridView4.CurrentRow.Index;
            textBox15.Text = dataGridView4.Rows[n].Cells[0].Value.ToString();
            textBox14.Text = dataGridView4.Rows[n].Cells[1].Value.ToString();
            textBox13.Text = dataGridView4.Rows[n].Cells[2].Value.ToString();
            textBox12.Text = dataGridView4.Rows[n].Cells[3].Value.ToString();
            textBox9.Text = dataGridView4.Rows[n].Cells[4].Value.ToString();
          
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dtokhachhang nv = new dtokhachhang(textBox15.Text, textBox14.Text, textBox13.Text, textBox12.Text, textBox9.Text);
            try
            {
                buskhachhang bus_nv = new buskhachhang();
                bus_nv.insert(nv);
                LoadData1();
                MessageBox.Show("thêm thành công");
            }
            catch
            {
                MessageBox.Show("thêm không thành công");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dtokhachhang nv = new dtokhachhang(textBox15.Text, textBox14.Text, textBox13.Text, textBox12.Text, textBox9.Text);
            try
            {
                buskhachhang bus_nv = new buskhachhang();
                bus_nv.update(nv);
                LoadData1();
                MessageBox.Show("sửa thành công");
            }
            catch
            {
                MessageBox.Show("sửa không thành công");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dtokhachhang nv = new dtokhachhang(textBox17.Text, null , null, null, null);
            try
            {
                buskhachhang bus_nv = new buskhachhang();
                bus_nv.delete(nv);
                LoadData1();
                MessageBox.Show("xóa thành công");
            }
            catch
            {
                MessageBox.Show("xóa không thành công");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                buskhachhang bus_nv = new buskhachhang();
                dt = bus_nv.search(textBox18.Text);
                dataGridView4.DataSource = dt;
                MessageBox.Show("tìm kiếm thành công");
            }
            catch
            {
                MessageBox.Show("tìm kiếm không thành công");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dtocthoadon nv = new dtocthoadon(textBox11.Text, textBox10.Text, textBox8.Text);
            try
            {
                buscthoadon bus_nv = new buscthoadon();
                bus_nv.update(nv);
                LoadData2();
                MessageBox.Show("sửa thành công");
            }
            catch
            {
                MessageBox.Show("sửa không thành công");
            }
        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
            int n = dataGridView3.CurrentRow.Index;
            textBox11.Text = dataGridView3.Rows[n].Cells[0].Value.ToString();
            textBox10.Text = dataGridView3.Rows[n].Cells[1].Value.ToString();
            textBox8.Text = dataGridView3.Rows[n].Cells[2].Value.ToString();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
