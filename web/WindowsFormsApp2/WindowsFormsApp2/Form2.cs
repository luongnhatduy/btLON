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

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        busMayTinh mt = new busMayTinh();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnMaMay_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        public void LoadData()
        {
            busMayTinh bus_mt = new busMayTinh();
            DataTable dt = bus_mt.HienThiDS();
            dgvDuLieu.DataSource = dt;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }
       

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            dtoMayTinh MT = new dtoMayTinh(txtMaMay.Text, txtTenMay.Text, txtCauHinh.Text, txtTinhTrang.Text, txtMaPhong.Text);
            try
            {
                busMayTinh bus_mt = new busMayTinh();
                bus_mt.ThemMayTinh(MT);
                LoadData();             
                MessageBox.Show("thêm thành công");
            }
            catch
            {
                MessageBox.Show("thêm thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dtoMayTinh MT = new dtoMayTinh(txtMaMay.Text, txtTenMay.Text, txtCauHinh.Text, txtTinhTrang.Text, txtMaPhong.Text);
            try
            {
                busMayTinh bus_mt = new busMayTinh();
                bus_mt.SuaMayTinh(MT);
                LoadData();
                MessageBox.Show("sửa thành công");
            }
            catch
            {
                MessageBox.Show("sửa thành công");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDuLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
