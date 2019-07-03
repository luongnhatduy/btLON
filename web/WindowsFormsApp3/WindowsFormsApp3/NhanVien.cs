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
using DAL;
namespace WindowsFormsApp3
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
   
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                buschucvu bus_nv = new buschucvu();
                dt = bus_nv.search(textBox11.Text);
                dataGridView2.DataSource = dt;
                MessageBox.Show("tìm kiếm thành công");
            }
            catch
            {
                MessageBox.Show("tìm kiếm không thành công");
            }
        }

       private void button7_Click(object sender, EventArgs e)
        {
            dtochucvu cv = new dtochucvu(textBox10.Text, textBox9.Text);
            try
            {
                buschucvu bus_cv = new buschucvu();
                bus_cv.update(cv);
                LoadData();
                MessageBox.Show("sửa thành công");
            }
            catch
            {
                MessageBox.Show("sửa không thành công");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dtochucvu cv = new dtochucvu(textBox8.Text,null);
            try
            {
                buschucvu bus_cv = new buschucvu();
                bus_cv.delete(cv);
                LoadData();
                MessageBox.Show("xóa thành công");
            }
            catch
            {
                MessageBox.Show("xóa không thành công");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dtochucvu cv = new dtochucvu(textBox10.Text, textBox9.Text);
            try
            {
                buschucvu bus_cv = new buschucvu();
                bus_cv.insert(cv);
                LoadData();
                MessageBox.Show("thêm thành công");
            }
            catch
            {
                MessageBox.Show("thêm không thành công");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            hethong A = new hethong();
            A.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            hethong A = new hethong();
            A.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            buschucvu bus_cv = new buschucvu();
            DataTable dt = bus_cv.select();
            dataGridView2.DataSource = dt;

        }
        public void LoadData1()
        {
            busnhanvien bus_nv = new busnhanvien();
            DataTable dt = bus_nv.select();
            dataGridView1.DataSource = dt;

        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData1();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtonhanvien nv = new dtonhanvien(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            try
            {
                busnhanvien bus_nv = new busnhanvien();
                bus_nv.insert(nv);
                LoadData1();
                MessageBox.Show("thêm thành công");
            }
            catch
            {
                MessageBox.Show("thêm không thành công");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtonhanvien nv = new dtonhanvien(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            try
            {
                busnhanvien bus_nv = new busnhanvien();
                bus_nv.update(nv);
                LoadData1();
                MessageBox.Show("sửa thành công");
            }
            catch
            {
                MessageBox.Show("sửa không thành công");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dtonhanvien nv = new dtonhanvien(textBox6.Text,null,null,null,null);
            try
            {
                busnhanvien bus_nv = new busnhanvien();
                bus_nv.delete(nv);
                LoadData1();
                MessageBox.Show("xóa thành công");
            }
            catch
            {
                MessageBox.Show("xóa không thành công");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            int n = dataGridView2.CurrentRow.Index;
            textBox10.Text = dataGridView2.Rows[n].Cells[0].Value.ToString();
            textBox9.Text = dataGridView2.Rows[n].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                busnhanvien bus_nv = new busnhanvien();
                dt = bus_nv.search(textBox7.Text);
                dataGridView1.DataSource = dt;
                MessageBox.Show("tìm kiếm thành công");
            }
            catch
            {
                MessageBox.Show("tìm kiếm không thành công");
            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;
            for (i = 1; i <= dataGridView1.ColumnCount; i++)
            {
                xlWorkSheet.Cells[1, i] =  dataGridView1.Columns[i - 1].HeaderText;
            }
            for (i = 0; i <  dataGridView1.RowCount; i++)
            {
                for (j = 0; j <  dataGridView1.ColumnCount; j++)
                {
                    DataGridViewCell cell =  dataGridView1[j, i];
                    xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                }
            }

            xlWorkBook.SaveAs("csharp.net-thongtinnhansu.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            //  releaseObject(xlWorkSheet);
            //   releaseObject(xlWorkBook);
            //   releaseObject(xlApp);

            MessageBox.Show("Excel file created , bạn lưu file tại Documents:\\csharp.net-thongtinnhanvien.xls");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
