using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Object;
using BUS;
namespace QuanLyNhaThuoc
{
    public partial class frm_nhanvien_insert : Form
    {
        UserControl_nhanvien f;
        BUS_nhanvien nv = new BUS_nhanvien();
        public frm_nhanvien_insert(UserControl_nhanvien f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            switch (f.button)
            {
                case "insert":
                    if (txt_mnv.Text != "")
                    {
                        if (!check(txt_mnv.Text))
                        {
                            nv.insert(data());
                            f.load();
                            this.Close();
                        }

                        else MessageBox.Show("Đã tồn tại mã nhân viên");
                    }
                    else
                    {
                        MessageBox.Show("Không để trống mã nhân viên");
                    }
                    break;
                case "update":
                    nv.update(data());
                    f.load();
                    this.Close();
                    break;
            }
        }
        bool check(string manv)
        {
            bool c = false;
            // true = tồn tại
            for (int i = 0; i < f.dg_nhanvien.RowCount; i++)
            {
                if (manv == f.dg_nhanvien.Rows[i].Cells[0].Value.ToString().Trim())
                {
                    c = true;
                    break;
                }
            }
            return c;
        }

        private nhanvien data()
        {
            nhanvien t = new nhanvien();
            t.Manv = txt_mnv.Text.ToString();
            t.Ten = txt_tennv.Text.ToString();
            t.Email = txt_email.Text.ToString();
            t.Sdt = txt_sdt.Text.ToString();
            t.Diachi = txt_diachi.Text.ToString();
            return t;
        }

        private void frm_nhanvien_insert_Load(object sender, EventArgs e)
        {
            switch (f.button)
            {
                case "insert":
                    txt_mnv.Enabled = true;

                    break;
                case "update":
                    txt_mnv.Enabled = false;
                    txt_mnv.Text = f.dg_nhanvien.Rows[f.dg_nhanvien.CurrentRow.Index].Cells[0].Value.ToString();
                    txt_tennv.Text = f.dg_nhanvien.Rows[f.dg_nhanvien.CurrentRow.Index].Cells[1].Value.ToString();
                    txt_email.Text = f.dg_nhanvien.Rows[f.dg_nhanvien.CurrentRow.Index].Cells[3].Value.ToString();
                    txt_sdt.Text = f.dg_nhanvien.Rows[f.dg_nhanvien.CurrentRow.Index].Cells[6].Value.ToString();
                    txt_diachi.Text = f.dg_nhanvien.Rows[f.dg_nhanvien.CurrentRow.Index].Cells[2].Value.ToString();

                    break;
            }
        }
    }
}
