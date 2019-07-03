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
    public partial class frm_nhacc_insert : Form
    {
        UserControl_kho f;
        BUS_nhaCC nhacc = new BUS_nhaCC();
        public frm_nhacc_insert(UserControl_kho f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            switch (f.button)
            {
                case "insert":

                    
                    if (check(txt_macc.Text.Trim()))
                    {
                        MessageBox.Show("Trùng mã nhà cc");
                    }
                    else
                    {
                        
                        nhacc.insert(getnhacc());
                        f.load();
                        this.Close();
                        

                    }
                    break;
                case "update":
                    nhacc.update(getnhacc());
                    f.load();
                    this.Close();
                    break;
            }
        }

        private nhaCC getnhacc()
        {
            nhaCC c = new nhaCC();
            c.MaNCC = txt_macc.Text;
            c.TenNCC = txt_tencc.Text;
            c.Diachi = txt_diachi.Text;
            c.Sodt = txt_sdt.Text;
            c.Email = txt_email.Text;
            return c;
        }
        private bool check(string manv)
        {
            bool c = false;
            // true = tồn tại
            for (int i = 0; i < f.dg_nhacc.RowCount; i++)
            {
                if (manv == f.dg_nhacc.Rows[i].Cells[0].Value.ToString().Trim())
                {
                    c = true;
                    break;
                }
            }
            return c;
        }

        private void frm_nhacc_insert_Load(object sender, EventArgs e)
        {
            switch (f.button)
            {
                case "insert":
                    txt_macc.Enabled = true;
                    break;
                case "update":
                    txt_macc.Enabled = false;
                    txt_macc.Text = f.dg_nhacc.Rows[f.dg_nhacc.CurrentRow.Index].Cells[0].Value.ToString();
                    txt_tencc.Text = f.dg_nhacc.Rows[f.dg_nhacc.CurrentRow.Index].Cells[1].Value.ToString();                   
                    txt_diachi.Text = f.dg_nhacc.Rows[f.dg_nhacc.CurrentRow.Index].Cells[2].Value.ToString();
                    txt_sdt.Text = f.dg_nhacc.Rows[f.dg_nhacc.CurrentRow.Index].Cells[3].Value.ToString();
                    txt_email.Text = f.dg_nhacc.Rows[f.dg_nhacc.CurrentRow.Index].Cells[4].Value.ToString();

                    break;
            }
        }
    }
}
