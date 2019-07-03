using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Object;
namespace QuanLyNhaThuoc
{
    public partial class UserControl_nhanvien : UserControl
    {
        public string button = "";
        private BUS_nhanvien data_nv = new BUS_nhanvien();
        public DataTable tb = new DataTable();
        public UserControl_nhanvien()
        {
            InitializeComponent();
        }

        private void UserControl_nhanvien_Load(object sender, EventArgs e)
        {
            load();

        }
        public void load()
        {
            tb = data_nv.select();
            dg_nhanvien.DataSource = tb;
            if(dg_nhanvien.RowCount == 0)
            {
                btn_quyen.Enabled = false;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;

            }
            else
            {
                btn_quyen.Enabled = true;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
            }

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            button = "insert";
            frm_nhanvien_insert f = new frm_nhanvien_insert(this);
            f.ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            button = "update";
            frm_nhanvien_insert f = new frm_nhanvien_insert(this);
            f.ShowDialog();
        }

        private void btn_quyen_Click(object sender, EventArgs e)
        {   
            if(dg_nhanvien.Rows[dg_nhanvien.CurrentRow.Index].Cells[4].Value.ToString().Trim().Equals("Không có"))
            {
                DialogResult dialogResult = MessageBox.Show("Nhân viên này chưa có tài khoản, bạn có muốn tạo mới?", "Cấp quyền", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    button = "insert";
                    frm_taikhoan_insert f = new frm_taikhoan_insert(this);
                    f.ShowDialog();
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }
            else
            {
                button = "update";
                frm_taikhoan_insert f = new frm_taikhoan_insert(this);
                f.ShowDialog();
            }
           
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            nhanvien n = new nhanvien();
            n.Manv = dg_nhanvien.Rows[dg_nhanvien.CurrentRow.Index].Cells[0].Value.ToString().Trim();
            int kq = data_nv.check(n.Manv);
            if (kq == 0)
            {
                if (dg_nhanvien.Rows[dg_nhanvien.CurrentRow.Index].Cells[4].Value.ToString().Trim().Equals("Không có")) n.Manv = "#";
                else n.Taikhoan = dg_nhanvien.Rows[dg_nhanvien.CurrentRow.Index].Cells[4].Value.ToString().Trim();
                data_nv.delete(n);
                load();
            }
            else
            {
                MessageBox.Show("Không thể xóa vì còn dữ liệu");
            }
           
            
        }
    }
}
