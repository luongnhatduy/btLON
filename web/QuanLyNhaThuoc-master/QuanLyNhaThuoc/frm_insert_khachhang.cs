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
using Object;
namespace QuanLyNhaThuoc
{
    public partial class frm_insert_khachhang : Form
    {
        UserControl_khachhang f;
        
        private BUS_khachHang khachhang = new BUS_khachHang();
        public frm_insert_khachhang(UserControl_khachhang f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void frm_insert_khachhang_Load(object sender, EventArgs e)
        {
            switch (f.button)
            {
                case "insert":
                    txt_mkh.Enabled = true;

                    break;
                case "update":
                    txt_mkh.Enabled = false;
                    txt_mkh.Text = f.dg_khachhang.Rows[f.dg_khachhang.CurrentRow.Index].Cells[0].Value.ToString();
                    break;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            switch (f.button)
            {
                case "insert":
                    if (txt_mkh.Text != "")
                    {
                        if (!check(txt_mkh.Text))
                        {   
                            
                            themdl();
                            f.load_donthuoc();
                        }
                            
                        else MessageBox.Show("Đã tồn tại mã khách hàng");
                    }
                    else
                    {
                        MessageBox.Show("Không để trống mã khách hàng");
                    }



                    break;
                case "update":

                    suadl();
                    f.load_donthuoc();
                    break;
            }



             void themdl()
            {
                khachHang t = new khachHang();
                t.MaKH = txt_mkh.Text.ToString();
                t.TenKH = txt_tenkh.Text.ToString();
                t.SoDT = txtsdt.Text.ToString();
                khachhang.insert(t);
                f.load();
                this.Close();
            }
            void suadl()
            {
                khachHang t = new khachHang();
                t.MaKH = txt_mkh.Text.ToString();
                t.TenKH = txt_tenkh.Text.ToString();
                t.SoDT = txtsdt.Text.ToString();
                khachhang.update(t);
                f.load();
                this.Close();
            }
             bool check(string manv)
            {
                bool c = false;
                // true = tồn tại
                DataGridView d;
                d = f.dg_khachhang;
               // MessageBox.Show(f.dg_khachhang.Rows[0].Cells[0].Value.ToString());
                for (int i = 0; i < d.RowCount; i++)
                {
                    if (manv == f.dg_khachhang.Rows[i].Cells[0].Value.ToString().Trim())
                    {
                        c = true;
                        break;
                    }
                }
                return c;
            }
        }
    }
}
