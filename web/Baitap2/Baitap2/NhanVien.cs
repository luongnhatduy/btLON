using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhanVienDAL;
using NhanVien;
using System.Data.SqlClient;
using SqlProvider;
namespace Baitap2
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NHANVIENDAL cmd = new NHANVIENDAL();
            nhanvien data = new nhanvien();
            data.manv = txtmanv.Text;
            data.tennv = txttennv.Text;
            data.honv = txtho.Text;
            data.diachi = txtdiachi.Text;
            data.ngaysinh = dtngaysinh.Text;
            data.gioitinh = cbgioitinh.Text;
            data.dienthoai = txtsdt.Text;
            data.taikhoan = txttdn.Text;
            data.matkhau = txtmk.Text;
            data.loainv = cbloainv.Text;

            bool kt = cmd.nhanvien_insert(data);
            if (kt == false)
            {
                MessageBox.Show("Loi");
            }
            else
            {
                MessageBox.Show("Them thành công");
                
            }
            Load_Data("select * from NHANVIEN");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NHANVIENDAL cmd = new NHANVIENDAL();
            nhanvien data = new nhanvien();
            data.manv = txtmanv.Text;
            data.tennv = txttennv.Text;
            data.honv = txtho.Text;
            data.diachi = txtdiachi.Text;
            data.ngaysinh = dtngaysinh.Text;
            data.gioitinh = cbgioitinh.Text;
            data.dienthoai = txtsdt.Text;
            data.taikhoan = txttdn.Text;
            data.matkhau = txtmk.Text;
            data.loainv = cbloainv.Text;

            bool kt = cmd.nhanvien_update(data);
            if (kt == false)
            {
                MessageBox.Show("Loi");
            }
            else
            {
                MessageBox.Show("Sửa thành công");

            }
            Load_Data("select * from NHANVIEN");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NHANVIENDAL cmd = new NHANVIENDAL();
            nhanvien data = new nhanvien();
            data.manv = txtmanv.Text;
            data.tennv = txttennv.Text;
            data.diachi = txtdiachi.Text;
            data.ngaysinh = dtngaysinh.Text;
            data.gioitinh = cbgioitinh.Text;
            data.dienthoai = txtsdt.Text;
            data.taikhoan = txttdn.Text;
            data.matkhau = txtmk.Text;
            data.loainv = cbloainv.Text;

            bool kt = cmd.nhanvien_delete(data);
            if (kt == false)
            {
                MessageBox.Show("Loi");
            }
            else
            {
                MessageBox.Show("Xóa thành công");

            }
            Load_Data("select * from NHANVIEN");
        }
        private void Load_Data(String sql)
        {
            Sqlprovider kn = new Sqlprovider();
            DataSet ds = new DataSet();           
            SqlDataAdapter dap = new SqlDataAdapter(sql, kn.conn);
            dap.Fill(ds);
            dgvnhanvien.DataSource = ds.Tables[0];
        }

        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvnhanvien.Rows[e.RowIndex];

                txtmanv.Text= row.Cells["MANV"].Value.ToString();
                txttennv.Text = row.Cells["TEN"].Value.ToString();
                txtho.Text = row.Cells["HO"].Value.ToString();
                txtdiachi.Text = row.Cells["DIACHI"].Value.ToString();
                dtngaysinh.Text = row.Cells["NGAYSINH"].Value.ToString();
                cbgioitinh.Text = row.Cells["GIOITINH"].Value.ToString();
                txtsdt.Text = row.Cells["DIENTHOAI"].Value.ToString();
                txttdn.Text = row.Cells["USERNAME"].Value.ToString();
                txtmk.Text = row.Cells["PASSWORDS"].Value.ToString();
                cbloainv.Text = row.Cells["LOAINV"].Value.ToString();
            }
        }
        
        private void NhanVien_Load(object sender, EventArgs e)
        {
            Load_Data("select * from NHANVIEN");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Load_Data("select * from NHANVIEN where TEN='"+ this.txttkten.Text +"'");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Load_Data("select * from NHANVIEN");
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            Load_Data("select * from NHANVIEN where HO='" + this.txttkho.Text + "'");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Load_Data("select * from NHANVIEN where LOAINV='"+cbtkloainv.Text+"'");
        }
    }
}
