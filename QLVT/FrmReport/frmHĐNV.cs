using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.Report
{
    public partial class frmHĐNV : DevExpress.XtraEditors.XtraForm
    {
        public frmHĐNV()
        {
            InitializeComponent();
        }

        

        private void frmHĐNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }

        private void frmHĐNV_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.V_DSNV_TK' table. You can move, or remove it, as needed.
            qLVT_DATHANGDataSet.EnforceConstraints = false;
            this.v_DSNV_TKTableAdapter.Connection.ConnectionString = Program.constr;
            this.v_DSNV_TKTableAdapter.Fill(this.qLVT_DATHANGDataSet.V_DSNV_TK);

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            

            int manv = Int32.Parse(cbbMANV.GetItemText(cbbMANV.SelectedItem));
           
            DateTime timeBD = Convert.ToDateTime(TimeBDNV.EditValue);
            DateTime timeKT = Convert.ToDateTime(TimeKTNV.EditValue);
            String loai = "";
            if(radioPN.Checked==true)
            {
                loai = "NHAP";
            }
            else if (radioPX.Checked == true)
            {
                loai = "XUAT";
            }
            BaoCao.XrptHoatDongNV rpt = new BaoCao.XrptHoatDongNV(manv, timeBD, timeKT,loai);
                if(loai.Equals("NHAP"))
            {
                rpt.lbHOATDONG.Text = "BẢNG KÊ CHỨNG TỪ PHIẾU NHẬP ";
            }
            else
            {
                rpt.lbHOATDONG.Text = "BẢNG KÊ CHỨNG TỪ PHIẾU XUẤT " ;
            }
            Program.conn = new SqlConnection(Program.constr);
            Program.conn.Open();
            SqlCommand cmd = new SqlCommand("SP_TTNHANVIEN", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MANV", manv));
            SqlDataReader myReader = null;
            try
            {
                myReader = cmd.ExecuteReader();
                while(myReader.Read())
                {
                    rpt.lbMANV.Text = myReader["MANV"].ToString();
                    rpt.lbHoten.Text = myReader["HOTEN"].ToString();
                    rpt.lbCN.Text = myReader["MACN"].ToString();
                    rpt.lbDiaChi.Text = myReader["DIACHI"].ToString();
                    rpt.lbLuong.Text = myReader["LUONG"].ToString()+" VNĐ";
                    string chuoiNgay = myReader["NGAYSINH"].ToString();
                    String[] ngaycat = chuoiNgay.Split(' ');
                    rpt.lbNS.Text =ngaycat[0];
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Đọc và lấy result
            ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int manv = Int32.Parse(cbbMANV.GetItemText(cbbMANV.SelectedItem));

            DateTime timeBD = Convert.ToDateTime(TimeBDNV.EditValue);
            DateTime timeKT = Convert.ToDateTime(TimeKTNV.EditValue);
            String loai = "";
            if (radioPN.Checked == true)
            {
                loai = "NHAP";
            }
            else if (radioPX.Checked == true)
            {
                loai = "XUAT";
            }
            BaoCao.XrptHoatDongNV rpt = new BaoCao.XrptHoatDongNV(manv, timeBD, timeKT, loai);
            if (loai.Equals("NHAP"))
            {
                rpt.lbHOATDONG.Text = "BẢNG KÊ CHỨNG TỪ PHIẾU NHẬP ";
            }
            else
            {
                rpt.lbHOATDONG.Text = "BẢNG KÊ CHỨNG TỪ PHIẾU XUẤT ";
            }
            Program.conn = new SqlConnection(Program.constr);
            Program.conn.Open();
            SqlCommand cmd = new SqlCommand("SP_TTNHANVIEN", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MANV", manv));
            SqlDataReader myReader = null;
            try
            {
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    rpt.lbMANV.Text = myReader["MANV"].ToString();
                    rpt.lbHoten.Text = myReader["HOTEN"].ToString();
                    rpt.lbCN.Text = myReader["MACN"].ToString();
                    rpt.lbDiaChi.Text = myReader["DIACHI"].ToString();
                    rpt.lbLuong.Text = myReader["LUONG"].ToString();
                    rpt.lbNS.Text = myReader["NGAYSINH"].ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                if (File.Exists(@"E:\ReportHDNV.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportHDNV.pdf tại ổ E đã có!\nBạn có muốn ghi đè?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        rpt.ExportToPdf(@"E:\ReportHDNV.pdf");
                        MessageBox.Show("File ReportHDNV.pdf đã được ghi thành công tại ổ E",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    rpt.ExportToPdf(@"E:\ReportHDNV.pdf");
                    MessageBox.Show("File ReportHDNV.pdf đã được ghi thành công tại ổ E",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportHDNV.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}