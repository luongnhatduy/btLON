using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLiSinhVien
{
    public partial class CHINH : Form
    {
        ///BOSinhVien bosinhvien = new BOSinhVien();

        public CHINH()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            DataTable dt = bosinhvien.HienThiDS();
            dgvDuLieu.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTOSinhVien SV = new DTOSinhVien(txtMaSV.Text, txtTenSV.Text, txtDiaChi.Text, txtSoDT.Text);
            try
            {
                bosinhvien.ThemSinhVien(SV);
                LoadData();
                xoatextbox();
                MessageBox.Show("thêm thành công");
            }
            catch
            {
                MessageBox.Show("thêm thành công"); 
            }
        }
        /*
        private void btnSua_Click(object sender, EventArgs e)
        {
           DTOSinhVien SV = new DTOSinhVien(txtMaSV.Text, txtTenSV.Text, txtDiaChi.Text, txtSoDT.Text);
            try
            {
                bosinhvien.SuaSinhVien(SV);
                LoadData();
                xoatextbox();
                MessageBox.Show("sửa thành công");
            }
            catch
            {
                MessageBox.Show("sửa thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                bosinhvien.XoaSinhVien(txtXoa.Text);
                LoadData();
                xoatextbox();
                MessageBox.Show("xóa thành công");
            }
            catch
            {
                MessageBox.Show("xóa thành công");
            }
        }

        private void dgvDuLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
}*/
}