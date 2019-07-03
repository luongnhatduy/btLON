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
    public partial class UserControl_kho : UserControl
    {
        public string button = "";
        private BUS_nhaCC nhacc = new BUS_nhaCC();
        private BUS_loThuoc lothuoc = new BUS_loThuoc();
        public DataTable tb = new DataTable();
        public DataTable tb_lothuoc = new DataTable();
        
        public UserControl_kho()
        {
            InitializeComponent();
            load();
            load_kho();
            load_cb();
            
        }
        public void load_cb()
        {
            comboBox1.Items.Add("Thuốc");
            comboBox1.Items.Add("Lô");
            comboBox1.SelectedItem = "Thuốc";
        }
            public void load()
        {
            tb = nhacc.select();
            dg_nhacc.DataSource = tb;
            if (dg_nhacc.RowCount == 0)
            {
                
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;

            }
            else
            {
                
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
            }


        }

        public void load_kho()
        {
            comboBox1.SelectedItem = "Thuốc";
            tb_lothuoc = lothuoc.select();
            dg_kho.DataSource = tb_lothuoc;
            if (dg_kho.RowCount == 0)
            {

                
                btn_xoakho.Enabled = false;

            }
            else
            {

          
                btn_xoakho.Enabled = true;
            }

        }

        public void load_kho2()
        {
            tb_lothuoc = lothuoc.select2();
            dg_kho.DataSource = tb_lothuoc;
            if (dg_kho.RowCount == 0)
            {

       
                btn_xoakho.Enabled = false;

            }
            else
            {

              
                btn_xoakho.Enabled = true;
            }

        }



        private void btn_them_Click(object sender, EventArgs e)
        {
            button = "insert";
            frm_nhacc_insert f = new frm_nhacc_insert(this);
            f.ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            button = "update";
            frm_nhacc_insert f = new frm_nhacc_insert(this);
            f.ShowDialog();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
            nhaCC n = new nhaCC();
            n.MaNCC = dg_nhacc.Rows[dg_nhacc.CurrentRow.Index].Cells[0].Value.ToString();
            int kq = nhacc.check(n.MaNCC);
            if (kq == 0)
            {
                nhacc.delete(n);
                load();
            }
            else
            {
                MessageBox.Show("Không thể xóa vì còn dữ liệu");
            }
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Thuốc")
            {
                load_kho();
            }
            else
            {
                load_kho2();
            }
        }

        private void btn_xoakho_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa toàn bộ lô thuốc này?", "Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                loThuoc l = new loThuoc();
                l.Solothuoc = dg_kho.Rows[dg_kho.CurrentRow.Index].Cells[0].Value.ToString();
                lothuoc.delete(l);

                if (comboBox1.Text == "Thuốc")
                {
                    load_kho();
                }
                else
                {
                    load_kho2();
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void UserControl_kho_Load(object sender, EventArgs e)
        {
         
        }

        private void btn_themkho_Click(object sender, EventArgs e)
        {
            frm_kho_insert f = new frm_kho_insert(this);
            f.ShowDialog();
        }
    }
}
