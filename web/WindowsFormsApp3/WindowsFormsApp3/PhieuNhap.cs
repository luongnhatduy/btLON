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
using DAL;

namespace WindowsFormsApp3
{
    public partial class PhieuNhap : Form
    {
        public PhieuNhap()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            hethong A = new hethong();
            A.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            hethong A = new hethong();
            A.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            hethong A = new hethong();
            A.Show();
        }
        public void LoadData()
        {
            busphieunhap bus_mt = new busphieunhap();
            DataTable dt = bus_mt.select();
            dataGridView2.DataSource = dt;

        }
        public void LoadData1()
        {
            busctphieunhap bus_mt = new busctphieunhap();
            DataTable dt = bus_mt.select();
            dataGridView1.DataSource = dt;

        }
        public void LoadData2()
        {
            busnhacc bus_mt = new busnhacc();
            DataTable dt = bus_mt.select();
            dataGridView3.DataSource = dt;

        }
        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData1();
            LoadData2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtophieunhap MT = new dtophieunhap(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            try
            {
                busphieunhap bus_mt = new busphieunhap();
                bus_mt.insert(MT);
                LoadData();
                MessageBox.Show("thêm thành công");
            }
            catch
            {
                MessageBox.Show("thêm không thành công");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtophieunhap MT = new dtophieunhap(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            try
            {
                busphieunhap bus_mt = new busphieunhap();
                bus_mt.update(MT);
                LoadData();
                MessageBox.Show("sửa thành công");
            }
            catch
            {
                MessageBox.Show("sửa không thành công");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtophieunhap MT = new dtophieunhap(textBox13.Text, null,null,null);
            try
            {
                busphieunhap bus_mt = new busphieunhap();
                bus_mt.delete(MT);
                LoadData();
                MessageBox.Show("xóa thành công");
            }
            catch
            {
                MessageBox.Show("xóa không thành công");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dtoctphieunhap MT = new dtoctphieunhap(textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text);
            try
            {
                busctphieunhap bus_mt = new busctphieunhap();
                bus_mt.insert(MT);
                LoadData1();
                MessageBox.Show("thêm thành công");
            }
            catch
            {
                MessageBox.Show("thêm không thành công");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dtoctphieunhap MT = new dtoctphieunhap(textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text);
            try
            {
                busctphieunhap bus_mt = new busctphieunhap();
                bus_mt.update(MT);
                LoadData1();
                MessageBox.Show("sửa thành công");
            }
            catch
            {
                MessageBox.Show("sửa không thành công");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dtoctphieunhap MT = new dtoctphieunhap(textBox14.Text, null, null, null);
            try
            {
                busctphieunhap bus_mt = new busctphieunhap();
                bus_mt.delete(MT);
                LoadData1();
                MessageBox.Show("xóa thành công");
            }
            catch
            {
                MessageBox.Show("xóa không thành công");
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            int n = dataGridView2.CurrentRow.Index;
            textBox1.Text = dataGridView2.Rows[n].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.Rows[n].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.Rows[n].Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.Rows[n].Cells[3].Value.ToString();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.CurrentRow.Index;
            textBox8.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            textBox7.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
          
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dtonhacc MT = new dtonhacc(textBox12.Text, textBox11.Text, textBox10.Text, textBox9.Text);
            try
            {
                busnhacc bus_mt = new busnhacc();
                bus_mt.insert(MT);
                LoadData2();
                MessageBox.Show("thêm thành công");
            }
            catch
            {
                MessageBox.Show("thêm không thành công");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dtonhacc MT = new dtonhacc(textBox12.Text, textBox11.Text, textBox10.Text, textBox9.Text);
            try
            {
                busnhacc bus_mt = new busnhacc();
                bus_mt.update(MT);
                LoadData2();
                MessageBox.Show("sửa thành công");
            }
            catch
            {
                MessageBox.Show("sửa không thành công");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dtonhacc MT = new dtonhacc(textBox17.Text, null, null, null);
            try
            {
                busnhacc bus_mt = new busnhacc();
                bus_mt.delete(MT);
                LoadData2();
                MessageBox.Show("xóa thành công");
            }
            catch
            {
                MessageBox.Show("xóa không thành công");
            }
        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
            int n = dataGridView3.CurrentRow.Index;
            textBox12.Text = dataGridView3.Rows[n].Cells[0].Value.ToString();
            textBox11.Text = dataGridView3.Rows[n].Cells[1].Value.ToString();
            textBox10.Text = dataGridView3.Rows[n].Cells[2].Value.ToString();
            textBox9.Text  = dataGridView3.Rows[n].Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                busphieunhap bus_nv = new busphieunhap();
                dt = bus_nv.search(textBox15.Text);
                dataGridView2.DataSource = dt;
                MessageBox.Show("tìm kiếm thành công");
            }
            catch
            {
                MessageBox.Show("tìm kiếm không thành công");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
                DataTable dt = new DataTable();
                busctphieunhap bus_nv = new busctphieunhap();
                dt = bus_nv.search(textBox16.Text);
                dataGridView1.DataSource = dt;
                MessageBox.Show("tìm kiếm thành công");
          
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                busnhacc bus_nv = new busnhacc();
                dt = bus_nv.search(textBox18.Text);
                dataGridView3.DataSource = dt;
                MessageBox.Show("tìm kiếm thành công");
            }
            catch
            {
                MessageBox.Show("tìm kiếm không thành công");
            }
        }
    }
}
