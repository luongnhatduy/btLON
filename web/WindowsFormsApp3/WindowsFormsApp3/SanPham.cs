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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon A = new HoaDon();
            A.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            hethong A = new hethong();
            A.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            hethong A = new hethong();
            A.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            hethong A = new hethong();
            A.Show();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
            hethong A = new hethong();
            A.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.Hide();
            hethong A = new hethong();
            A.Show();
        }

        public void LoadData()
        {
            bussanpham bus_mt = new bussanpham();
            DataTable dt = bus_mt.select();
            dataGridView2.DataSource = dt;

        }
        public void LoadData1()
        {
            bussanphamtang bus_mt = new bussanphamtang();
            DataTable dt = bus_mt.select();
            dataGridView3.DataSource = dt;

        }
        public void LoadData2()
        {
            busdanhmuc bus_mt = new busdanhmuc();
            DataTable dt = bus_mt.select();
            dataGridView4.DataSource = dt;

        }
        public void LoadData3()
        {
            bushangsx bus_mt = new bushangsx();
            DataTable dt = bus_mt.select();
            dataGridView5.DataSource = dt;

        }
        public void LoadData4()
        {
            busbaohanh bus_mt = new busbaohanh();
            DataTable dt = bus_mt.select();
            dataGridView1.DataSource = dt;

        }
        private void SanPham_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData1();
            LoadData2();
            LoadData3();
            LoadData4();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtosanpham MT = new dtosanpham(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            try
            {
                bussanpham bus_mt = new bussanpham();
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
            dtosanpham MT = new dtosanpham(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            try
            {
                bussanpham bus_mt = new bussanpham();
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
            if (textBox18.Text == "")
            {
                MessageBox.Show("mời nhập mã");
            }
            else
            {
                dtosanpham MT = new dtosanpham(textBox18.Text, null, null, null, null, null);
                try
                {
                    bussanpham bus_mt = new bussanpham();
                    bus_mt.delete(MT);
                    LoadData();
                    MessageBox.Show("xóa thành công");
                }
                catch
                {
                    MessageBox.Show("xóa không thành công");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon A = new HoaDon();
            A.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dtosanphamtang MT = new dtosanphamtang(textBox9.Text, textBox8.Text, textBox7.Text);
            try
            {
                bussanphamtang bus_mt = new bussanphamtang();
                bus_mt.insert(MT);
                LoadData1();
                MessageBox.Show("thêm thành công");
            }
            catch
            {
                MessageBox.Show("thêm không thành công");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dtosanphamtang MT = new dtosanphamtang(textBox9.Text, textBox8.Text, textBox7.Text);
            try
            {
                bussanphamtang bus_mt = new bussanphamtang();
                bus_mt.update(MT);
                LoadData1();
                MessageBox.Show("sửa thành công");
            }
            catch
            {
                MessageBox.Show("sửa không thành công");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dtosanphamtang MT = new dtosanphamtang(textBox19.Text, null, null);
            try
            {
                bussanphamtang bus_mt = new bussanphamtang();
                bus_mt.delete(MT);
                LoadData1();
                MessageBox.Show("xóa thành công");
            }
            catch
            {
                MessageBox.Show("xóa không thành công");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            dtodanhmuc MT = new dtodanhmuc(textBox11.Text, textBox10.Text);
            try
            {
                busdanhmuc bus_mt = new busdanhmuc();
                bus_mt.insert(MT);
                LoadData2();
                MessageBox.Show("thêm thành công");
            }
            catch
            {
                MessageBox.Show("thêm không thành công");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dtodanhmuc MT = new dtodanhmuc(textBox11.Text, textBox10.Text);
            try
            {
                busdanhmuc bus_mt = new busdanhmuc();
                bus_mt.update(MT);
                LoadData2();
                MessageBox.Show("sửa thành công");
            }
            catch
            {
                MessageBox.Show("sửa không thành công");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dtodanhmuc MT = new dtodanhmuc(textBox20.Text, null);
            try
            {
                busdanhmuc bus_mt = new busdanhmuc();
                bus_mt.delete(MT);
                LoadData2();
                MessageBox.Show("xóa thành công");
            }
            catch
            {
                MessageBox.Show("xóa không thành công");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            dtohangsx MT = new dtohangsx(textBox13.Text, textBox12.Text);
            try
            {
                bushangsx bus_mt = new bushangsx();
                bus_mt.insert(MT);
                LoadData3();
                MessageBox.Show("thêm thành công");
            }
            catch
            {
                MessageBox.Show("thêm không thành công");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            dtohangsx MT = new dtohangsx(textBox13.Text, textBox12.Text);
            try
            {
                bushangsx bus_mt = new bushangsx();
                bus_mt.update(MT);
                LoadData3();
                MessageBox.Show("sửa thành công");
            }
            catch
            {
                MessageBox.Show("sửa không thành công");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            dtohangsx MT = new dtohangsx(textBox21.Text, null);
            try
            {
                bushangsx bus_mt = new bushangsx();
                bus_mt.delete(MT);
                LoadData3();
                MessageBox.Show("xóa thành công");
            }
            catch
            {
                MessageBox.Show("xóa không thành công");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            dtobaohanh MT = new dtobaohanh(textBox17.Text, textBox16.Text, textBox15.Text, textBox14.Text);
            try
            {
                busbaohanh bus_mt = new busbaohanh();
                bus_mt.insert(MT);
                LoadData4();
                MessageBox.Show("thêm thành công");
            }
            catch
            {
                MessageBox.Show("thêm không thành công");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            dtobaohanh MT = new dtobaohanh(textBox17.Text, textBox16.Text, textBox15.Text, textBox14.Text);
            try
            {
                busbaohanh bus_mt = new busbaohanh();
                bus_mt.update(MT);
                LoadData4();
                MessageBox.Show("sửa thành công");
            }
            catch
            {
                MessageBox.Show("thêm không thành công");
            }

        }

        private void button25_Click(object sender, EventArgs e)
        {
            dtobaohanh MT = new dtobaohanh(textBox22.Text,null, null, null);
            try
            {
                busbaohanh bus_mt = new busbaohanh();
                bus_mt.delete(MT);
                LoadData4();
                MessageBox.Show("xóa thành công");
            }
            catch
            {
                MessageBox.Show("xóa không thành công");
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.CurrentRow.Index;
            textBox17.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            textBox16.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textBox15.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            textBox14.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
           
        }

        private void dataGridView5_Click(object sender, EventArgs e)
        {
            int n = dataGridView5.CurrentRow.Index;
            textBox13.Text = dataGridView5.Rows[n].Cells[0].Value.ToString();
            textBox12.Text = dataGridView5.Rows[n].Cells[1].Value.ToString();
        
        }

        private void dataGridView4_Click(object sender, EventArgs e)
        {
            int n = dataGridView4.CurrentRow.Index;
            textBox11.Text = dataGridView4.Rows[n].Cells[0].Value.ToString();
            textBox10.Text = dataGridView4.Rows[n].Cells[1].Value.ToString();
           
        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
            int n = dataGridView3.CurrentRow.Index;
            textBox9.Text = dataGridView3.Rows[n].Cells[0].Value.ToString();
            textBox8.Text = dataGridView3.Rows[n].Cells[1].Value.ToString();
            textBox7.Text = dataGridView3.Rows[n].Cells[2].Value.ToString();
           
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            int n = dataGridView2.CurrentRow.Index;
            textBox1.Text = dataGridView2.Rows[n].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.Rows[n].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.Rows[n].Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.Rows[n].Cells[3].Value.ToString();
            textBox5.Text = dataGridView2.Rows[n].Cells[4].Value.ToString();
            textBox6.Text = dataGridView2.Rows[n].Cells[5].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                bussanpham bus_nv = new bussanpham();
                dt = bus_nv.search(textBox23.Text);
                dataGridView2.DataSource = dt;
                MessageBox.Show("tìm kiếm thành công");
            }
            catch
            {
                MessageBox.Show("tìm kiếm không thành công");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                bussanphamtang bus_nv = new bussanphamtang();
                dt = bus_nv.search(textBox24.Text);
                dataGridView3.DataSource = dt;
                MessageBox.Show("tìm kiếm thành công");
            }
            catch
            {
                MessageBox.Show("tìm kiếm không thành công");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                busdanhmuc bus_nv = new busdanhmuc();
                dt = bus_nv.search(textBox25.Text);
                dataGridView4.DataSource = dt;
                MessageBox.Show("tìm kiếm thành công");
            }
            catch
            {
                MessageBox.Show("tìm kiếm không thành công");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                bushangsx bus_nv = new bushangsx();
                dt = bus_nv.search(textBox26.Text);
                dataGridView5.DataSource = dt;
                MessageBox.Show("tìm kiếm thành công");
            }
            catch
            {
                MessageBox.Show("tìm kiếm không thành công");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                busbaohanh bus_nv = new busbaohanh();
                dt = bus_nv.search(textBox27.Text);
                dataGridView1.DataSource = dt;
                MessageBox.Show("tìm kiếm thành công");
            }
            catch
            {
                MessageBox.Show("tìm kiếm không thành công");
            }
        }
    }
}
