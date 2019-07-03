using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bus;
using dal;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadData()
        {
            BUSsinhvien bus_sv = new BUSsinhvien();
            DataTable dt = bus_sv.HienThiDS();
            dgvDuLieu.DataSource = dt;
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void xoatextbox()
        {
            txtDiaChi.Text = "";
            txtMaSV.Text = "";
            txtSoDT.Text = "";
            txtTenSV.Text = "";
            txtXoa.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTOSinhVien SV = new DTOSinhVien(txtMaSV.Text, txtTenSV.Text, txtDiaChi.Text, txtSoDT.Text);
            try
            {
                BUSsinhvien bus_sv = new BUSsinhvien();
                bus_sv.ThemSinhVien(SV);
                LoadData();
                xoatextbox();
                MessageBox.Show("thêm thành công");
            }
            catch
            {
                MessageBox.Show("thêm thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DTOSinhVien SV = new DTOSinhVien(txtMaSV.Text, txtTenSV.Text, txtDiaChi.Text, txtSoDT.Text);
            try
            {
                BUSsinhvien bus_sv = new BUSsinhvien();
                bus_sv.SuaSinhVien(SV);
                LoadData();
                xoatextbox();
                MessageBox.Show("sửa thành công");
            }
            catch
            {
                MessageBox.Show("sửa thành công");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BUSsinhvien bus_sv = new BUSsinhvien();
                bus_sv.XoaSinhVien(txtXoa.Text);
                LoadData();
                xoatextbox();
                MessageBox.Show("xóa thành công");
            }
            catch
            {
                MessageBox.Show("xóa thành công");
            }
        }

        private void dgvDuLieu_Click(object sender, EventArgs e)
        {
            int n = dgvDuLieu.CurrentRow.Index;
            txtMaSV.Text = dgvDuLieu.Rows[n].Cells[0].Value.ToString();
            txtTenSV.Text = dgvDuLieu.Rows[n].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvDuLieu.Rows[n].Cells[2].Value.ToString();
            txtSoDT.Text = dgvDuLieu.Rows[n].Cells[3].Value.ToString();
        }
    }
}
