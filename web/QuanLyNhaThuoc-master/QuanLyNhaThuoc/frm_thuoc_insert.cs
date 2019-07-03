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
    public partial class frm_thuoc_insert : Form
    {
        UserControl_thuoc f;
        private string thuocdacbiet="0";
        private BUS_thuoc thuoc = new BUS_thuoc();
        public frm_thuoc_insert(UserControl_thuoc ff)
        {
            InitializeComponent();
            f = ff;
            // cb_loaithuoc.DataSource = ff.tb;
            //  cb_loaithuoc.DisplayMember = "Tên thuốc";
            // cb_loaithuoc.ValueMember = "Tên thuốc";
            // cb_loaithuoc.SelectedIndex = cb_loaithuoc.FindStringExact(ff.loaithuoc);
            //  MessageBox.Show(ff.loaithuoc);
            cb_hsd.Items.Add("Năm");
            cb_hsd.Items.Add("Tháng");
            cb_hsd.SelectedIndex = cb_hsd.FindStringExact("Năm");
            cb_donvitinh.Items.Add("Lọ");
            cb_donvitinh.Items.Add("Viên");
            cb_donvitinh.Items.Add("Vỉ");
            cb_donvitinh.SelectedIndex = cb_donvitinh.FindStringExact("Viên");
        }

        private void frm_thuoc_insert_Load(object sender, EventArgs e)
        {
            //  cb_loaithuoc.Text = " xsx";

            //  MessageBox.Show(f.dg_thuoc.RowCount.ToString());
            switch (f.button)
            {
                case "insert":
                    txt_mathuoc.Enabled = true;
                    break;
                case "update":
                    string hsd = f.dg_thuoc.Rows[f.dg_thuoc.CurrentRow.Index].Cells[5].Value.ToString();
                    string[] words = hsd.Split(' ');
                    cb_hsd.SelectedIndex = cb_hsd.FindStringExact(words[1]);
                    txt_hsd.Value = Int32.Parse(words[0]);
                    
                    txt_mathuoc.Enabled = false;
                    txt_mathuoc.Text = f.dg_thuoc.Rows[f.dg_thuoc.CurrentRow.Index].Cells[0].Value.ToString();
                    txt_tenthuoc.Text = f.dg_thuoc.Rows[f.dg_thuoc.CurrentRow.Index].Cells[1].Value.ToString();
                    txt_loaithuoc.Text = f.dg_thuoc.Rows[f.dg_thuoc.CurrentRow.Index].Cells[2].Value.ToString();
                    txt_congdung.Text = f.dg_thuoc.Rows[f.dg_thuoc.CurrentRow.Index].Cells[4].Value.ToString();
                   // txt_hsd.Text = f.dg_thuoc.Rows[f.dg_thuoc.CurrentRow.Index].Cells[5].Value.ToString();
                    if (f.dg_thuoc.Rows[f.dg_thuoc.CurrentRow.Index].Cells[3].Value.ToString().Equals("Có"))
                        checkBox1.Checked = true;
                    else checkBox1.Checked = false;
                    txt_tacdungphu.Text = f.dg_thuoc.Rows[f.dg_thuoc.CurrentRow.Index].Cells[6].Value.ToString();
                    txt_chongchidinh.Text = f.dg_thuoc.Rows[f.dg_thuoc.CurrentRow.Index].Cells[7].Value.ToString();
                    txt_dongia.Text = f.dg_thuoc.Rows[f.dg_thuoc.CurrentRow.Index].Cells[8].Value.ToString();
                   
                    cb_donvitinh.SelectedIndex = cb_donvitinh.FindStringExact(f.dg_thuoc.Rows[f.dg_thuoc.CurrentRow.Index].Cells[9].Value.ToString());
                    txt_ghichu.Text = f.dg_thuoc.Rows[f.dg_thuoc.CurrentRow.Index].Cells[10].Value.ToString();
                    break;
            }

        }

        private void cb_loaithuoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {   
            switch (f.button){
                case "insert":
                    if(txt_mathuoc.Text != "") {
                        if (!check(txt_mathuoc.Text))
                            themdl();
                        else MessageBox.Show("Đã tồn tại mã thuốc");
                    }
                    else
                    {
                        MessageBox.Show("Không để trống mã thuốc");
                    }
                    
                   
                    
                    break;
                case "update":
                    
                        suadl();
                    
                    break;
            }
           
        }

        private void themdl()
        {
            thuoc t = new thuoc();
            t.Mathuoc = txt_mathuoc.Text.ToString();
            t.Tenthuoc = txt_tenthuoc.Text.ToString();
            t.Loaithuoc = txt_loaithuoc.Text.ToString();
            t.Congdung = txt_congdung.Text.ToString();
            t.Tacdungphu = txt_tacdungphu.Text.ToString();
            t.Chongchidinh = txt_chongchidinh.Text.ToString();
            t.Ghichu = txt_ghichu.Text.ToString();
            t.Dongia = txt_dongia.Text.ToString();
            t.Donvitinh = cb_donvitinh.Text.ToString();
            t.Thuocdacbiet = thuocdacbiet;
            t.HanSD = txt_hsd.Value.ToString() + " " + cb_hsd.Text.ToString();
            thuoc.insert(t);
            f.load();
            this.Close();
        }
        private void suadl()
        {
            thuoc t = new thuoc();
            t.Mathuoc = txt_mathuoc.Text.ToString();
            t.Tenthuoc = txt_tenthuoc.Text.ToString();
            t.Loaithuoc = txt_loaithuoc.Text.ToString();
            t.Congdung = txt_congdung.Text.ToString();
            t.Tacdungphu = txt_tacdungphu.Text.ToString();
            t.Chongchidinh = txt_chongchidinh.Text.ToString();
            t.Ghichu = txt_ghichu.Text.ToString();
            t.Dongia = txt_dongia.Text.ToString();
            t.Donvitinh = cb_donvitinh.Text.ToString();
            t.Thuocdacbiet = thuocdacbiet;
            t.HanSD = txt_hsd.Value.ToString() + " " + cb_hsd.Text.ToString();
            thuoc.update(t);
            f.load();
            this.Close();
        }
        private void cb_hsd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) thuocdacbiet = "1";
            else thuocdacbiet = "0";
        }
        public bool check(string mathuoc)
        {
            bool c = false;
            // true = tồn tại
            DataGridView d;
            d = f.dg_thuoc;
            for(int i = 0;i < d.RowCount; i++)
            {
                if (mathuoc == d.Rows[i].Cells[0].Value.ToString())
                {
                    c = true;
                    break;
                }
               
            }

            return c;
        }

        
    }
}
