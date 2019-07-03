using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyNhaThuoc
{
    public partial class frm_InHoaDon : Form
    {
        UserControl_banhang f;
  
        protected SqlConnection con = new SqlConnection(@"Data Source = (local); Initial Catalog = Quan ly nha thuoc c#; Integrated Security = True");
        public frm_InHoaDon(UserControl_banhang f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void frm_InHoaDon_Load(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select ctHoadon.mathuoc,tenthuoc,sum(soluong) as soluongthuoc,ctHoadon.dongia  from ctHoadon,thuoc where mahd = '"+f.txt_mahd.Text.Trim()+"' and ctHoadon.mathuoc = thuoc.mathuoc group by ctHoadon.mathuoc,ctHoadon.dongia,tenthuoc", con);
            da.Fill(hd,hd.Tables[0].TableName);
           // da.Fill(hd);
            //ReportDataSource rds = new ReportDataSource("khachHang", hd.Tables[0]);
            HoaDonBindingSource.DataSource = hd;
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("mahd", f.txt_mahd.Text));
            reportParameters.Add(new ReportParameter("tenkh", f.txt_tenkh.Text));
            reportParameters.Add(new ReportParameter("makh", f.txt_makhachhang.Text));
            reportParameters.Add(new ReportParameter("sdt", "3434"));
            reportParameters.Add(new ReportParameter("diachi", "Value"));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            con.Close();
            this.reportViewer1.RefreshReport();
        }
    }
}
