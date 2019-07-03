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
    public partial class frm_kho_insert : Form
    {
        BUS_loThuoc lothuoc = new BUS_loThuoc();
        BUS_ctLothuoc ctlo = new BUS_ctLothuoc();
        UserControl_kho f;
        public frm_kho_insert(UserControl_kho f)
        {
            InitializeComponent();
            this.f = f;
            load();
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (!check(txt_mathuoc.Text.Trim()))
            {
                if (txt_mathuoc.Text.Trim() == "") MessageBox.Show("Chưa có thuốc");
                else 
                this.dg_ctiet.Rows.Add(txt_mathuoc.Text, txt_tenthuoc.Text, txt_soluong.Value, txt_gia.Value, dateTimePicker1.Value.ToString("MM/dd/yyyy"), dateTimePicker1.Value.ToString("MM/dd/yyyy"));
            }
                
            else MessageBox.Show("Đã có thuốc này");
            
        }

        private bool check(string ma)
        {
            bool c = false;
            // true = tồn tại
            for (int i = 0; i < dg_ctiet.RowCount; i++)
            {
                if (ma == f.dg_nhacc.Rows[i].Cells[0].Value.ToString().Trim())
                {
                    return true;
                }
            }
            return c;
        }
        void load()
        {
            
        }

        private void frm_kho_insert_Shown(object sender, EventArgs e)
        {
            frm_trangchu f = (frm_trangchu)this.f.Parent.Parent;
            txt_mnv.Text = f.ff.nd.Manv;
            DateTime today = DateTime.Today;
            txt_date.Text = today.ToString("MM/dd/yyyy");
            comboBox1.DataSource = this.f.tb;
            comboBox1.DisplayMember = "Tên nhà cc";
            comboBox1.ValueMember = "Mã nhà cc";
        }

        private void txt_ok_Click(object sender, EventArgs e)
        {
            int kq = lothuoc.check(txt_solo.Text);
            if (kq != 0)
            {
               // MessageBox.Show(dateTimePicker1.Value.ToString("MM/dd/yyyy"));
                MessageBox.Show("Đã tồn tại lô");
            }
            else
            {
                if (txt_solo.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Không để trống");
                }
                else
                {
                    if(dg_ctiet.RowCount != 0)
                    {// 
                        lothuoc.insert(getLoThuoc());
                    
                        for(int i = 0;i < dg_ctiet.RowCount; i++)
                        {
                            ctlo.insert(getCTLoThuoc(i));
                        }
                        f.load_kho();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Chưa có thuốc");
                    }
                }

            }
        }

        private loThuoc getLoThuoc()
        {
            loThuoc l = new loThuoc();
            l.Solothuoc = txt_solo.Text;
            l.Ngaynhap = txt_date.Text;
            l.Mancc = comboBox1.SelectedValue.ToString();
            l.Manv = txt_mnv.Text;
            return l;
        }
        private ctLothuoc getCTLoThuoc(int i)
        {
            ctLothuoc l = new ctLothuoc();
            l.Solothuoc = txt_solo.Text;
            l.Mathuoc = dg_ctiet.Rows[i].Cells[0].Value.ToString().Trim();
            l.Soluong = dg_ctiet.Rows[i].Cells[2].Value.ToString().Trim();
            l.NgaySX = dg_ctiet.Rows[i].Cells[4].Value.ToString().Trim();
            l.HanSD = dg_ctiet.Rows[i].Cells[5].Value.ToString().Trim();
            l.Gianhap = dg_ctiet.Rows[i].Cells[3].Value.ToString().Trim();
            return l;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_kho_thuoc f = new frm_kho_thuoc(this);
            f.ShowDialog();
        }
    }
}
