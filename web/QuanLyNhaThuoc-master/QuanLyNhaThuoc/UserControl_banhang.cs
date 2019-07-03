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
    public partial class UserControl_banhang : UserControl
    {
        public int soluongMax=0;
        int tongtien = 0;
        BUS_hoaDon hoadon = new BUS_hoaDon();
        BUS_ctHoadon cthoadon = new BUS_ctHoadon();
        BUS_ctLothuoc lothuoc = new BUS_ctLothuoc();
        public UserControl_banhang()
        {
            InitializeComponent();
            txt_tien.Text = tongtien.ToString();
        }

       

        private void btn_thuoc_Click(object sender, EventArgs e)
        {
            frm_chonthuoc f = new frm_chonthuoc(this);
            f.ShowDialog();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_mathuoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chưa chọn thuốc");
                btn_thuoc.Focus();

            }
            else
            {
                if(Int32.Parse(txt_soluong.Value.ToString()) == 0)
                {
                    MessageBox.Show("Chọn số lượng");
                }
                else
                {
                    if (!check(txt_mathuoc.Text,txt_solo.Text))
                    {
                        this.dg_ctiet.Rows.Add(txt_mathuoc.Text, txt_tenthuoc.Text, txt_soluong.Value, txt_dongia.Text, dateTimePicker_nsx.Value.ToString("MM/dd/yyyy"), dateTimePicker_hsd.Value.ToString("MM/dd/yyyy"), txt_solo.Text);
                        int dongia = Int32.Parse(txt_dongia.Text);
                        tongtien += dongia * (int)txt_soluong.Value;
                        txt_tien.Text = tongtien.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại mặt hàng này ");
                    }
                }

            }
        }
        private bool check(string ma,string solo)
        {
            bool c = false;
            // true = tồn tại
            for (int i = 0; i < dg_ctiet.RowCount; i++)
            {
                if (ma == dg_ctiet.Rows[i].Cells[0].Value.ToString().Trim() && solo == dg_ctiet.Rows[i].Cells[6].Value.ToString().Trim())
                {
                    return true;
                }
            }
            return c;
        }
        private void UserControl_banhang_Load(object sender, EventArgs e)
        {
            //  txt_soluong.Maximum = soluongMax;
            txt_date.Text = DateTime.Today.ToString("MM/dd/yyyy");


        }

        private void txt_soluong_ValueChanged(object sender, EventArgs e)
        {   
          
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_mahd.Text.Trim().Equals("") || txt_makhachhang.Text.Trim().Equals("")) 
            {
                MessageBox.Show("Không để trống ");
            }
            else
            {   
                if(dg_ctiet.RowCount == 0)
                {
                    MessageBox.Show("Chưa có thuốc");
                }
                else
                {
                  
                    if (checkHoaDon())
                    {
                        MessageBox.Show("Đã tồn tại mã hóa đơn");
                        txt_mahd.Focus();
                    }
                    else
                    { // do smt
                      insertHoaDon();
                      insertChiTietHoaDon();
                      btn_hoadon.Enabled = true;
                      MessageBox.Show("Thêm thành công");
                    }
                }
                
            }
            
        }
        private void insertHoaDon()
        {
            hoaDon hd = new hoaDon();
            hd.MaHD = txt_mahd.Text;
            hd.MaKH = txt_makhachhang.Text;
            hd.MaNV = txt_mnv.Text;
            hd.Tongtien = txt_tien.Text;
            hd.Ngaynhap = txt_date.Text;
            hoadon.insert(hd);
        }
        private void insertChiTietHoaDon()
        {
            for(int i = 0;i < dg_ctiet.RowCount; i++)
            {
                cthoadon.insert(getChiTietHoaDon(i));
                lothuoc.update(getLothuocupdate(i));
            }
        }
        private ctHoadon getChiTietHoaDon(int i)
        {
            ctHoadon hd = new ctHoadon();
            hd.MaHD = txt_mahd.Text;
            hd.Solothuoc = dg_ctiet.Rows[i].Cells[6].Value.ToString().Trim();
            hd.Soluong = dg_ctiet.Rows[i].Cells[2].Value.ToString().Trim();
            hd.Dongia = dg_ctiet.Rows[i].Cells[3].Value.ToString().Trim();
            hd.Mathuoc = dg_ctiet.Rows[i].Cells[0].Value.ToString().Trim();
            return hd;
        }
        private ctLothuoc getLothuocupdate(int i)
        {
            ctLothuoc c = new ctLothuoc();
            c.Mathuoc = dg_ctiet.Rows[i].Cells[0].Value.ToString().Trim();
            c.Soluong = dg_ctiet.Rows[i].Cells[2].Value.ToString().Trim();
            c.Solothuoc = dg_ctiet.Rows[i].Cells[6].Value.ToString().Trim();
            
            return c;
        }
        private bool checkHoaDon()
        {
            bool check = false;// false = không tồn tại
            if(hoadon.checkhoadon(txt_mahd.Text.Trim()) != 0)
            {
                return true;
            }

            return check;
        }


        private void btn_mkh_Click(object sender, EventArgs e)
        {
            frm_banhang_mnv f = new frm_banhang_mnv(this);
            f.ShowDialog();
        }

        private void btn_lichsu_Click(object sender, EventArgs e)
        {
            frm_banhang_lichsu f = new frm_banhang_lichsu(this);
            f.ShowDialog();
            
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_InHoaDon f = new frm_InHoaDon(this);
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dg_ctiet.Rows.Clear();
            txt_mahd.Text = "";
            btn_hoadon.Enabled = false;
        }
    }
}
