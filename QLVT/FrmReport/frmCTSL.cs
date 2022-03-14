using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.IO;

namespace QLVT.Report
{
    public partial class frmCTSL : DevExpress.XtraEditors.XtraForm
    {
        public frmCTSL()
        {
            InitializeComponent();

            

        }

        private void frmCTSL_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            String[] Loai = CmbLoai.GetItemText(CmbLoai.SelectedItem).Split();
            String VaiTro = Program.mGroup.ToUpper();
            DateTime timeBD = Convert.ToDateTime(dateBD.EditValue);            
            DateTime timeKT = Convert.ToDateTime(dateKT.EditValue);
            Console.WriteLine(VaiTro);
            Console.WriteLine(timeBD);
            Console.WriteLine(timeKT);
            if (Loai[4].Trim().Equals("Nhập"))
            {
                BaoCao.Xrpt_ChiTietSL_TriGiaNhapXuat rpt = new BaoCao.Xrpt_ChiTietSL_TriGiaNhapXuat(VaiTro, "NHAP", timeBD, timeKT);
                rpt.lbTieuDe.Text = "BẢNG KÊ CHI TIẾT SỐ LƯỢNG-TRỊ GIÁ HÀNG " + Loai[4].ToUpper();
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }

            else
            {
                BaoCao.Xrpt_ChiTietSL_TriGiaNhapXuat rpt = new BaoCao.Xrpt_ChiTietSL_TriGiaNhapXuat(VaiTro, "XUAT", timeBD, timeKT);
                rpt.lbTieuDe.Text = "BẢNG KÊ CHI TIẾT SỐ LƯỢNG-TRỊ GIÁ HÀNG " + Loai[4].ToUpper();
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            } 
                
        }

        private void frmCTSL_Load(object sender, EventArgs e)
        {
            CmbLoai.Items.Add("Chi tiết SL-Trị Giá Nhập");
            CmbLoai.Items.Add("Chi tiết SL-Trị Giá Xuất");
            CmbLoai.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String[] Loai = CmbLoai.GetItemText(CmbLoai.SelectedItem).Split();
            String VaiTro = Program.mGroup.ToUpper();
            DateTime timeBD = Convert.ToDateTime(dateBD.EditValue);
            DateTime timeKT = Convert.ToDateTime(dateKT.EditValue);
            Console.WriteLine(VaiTro);
            Console.WriteLine(timeBD);
            Console.WriteLine(timeKT);
            if (Loai[4].Trim().Equals("Nhập"))
            {
                BaoCao.Xrpt_ChiTietSL_TriGiaNhapXuat rpt = new BaoCao.Xrpt_ChiTietSL_TriGiaNhapXuat(VaiTro, "NHAP", timeBD, timeKT);
                try
                {
                    if (File.Exists(@"E:\ReportChiTietSL_TriGiaNhapXuat.pdf"))
                    {
                        DialogResult dr = MessageBox.Show("File ReportChiTietSL_TriGiaNhapXuat.pdf tại ổ E đã có!\nBạn có muốn ghi đè?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            rpt.ExportToPdf(@"E:\ReportChiTietSL_TriGiaNhapXuat.pdf");
                            MessageBox.Show("File ReportChiTietSL_TriGiaNhapXuat.pdf đã được ghi thành công tại ổ E",
                    "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        rpt.ExportToPdf(@"E:\ReportChiTietSL_TriGiaNhapXuat.pdf");
                        MessageBox.Show("File ReportChiTietSL_TriGiaNhapXuat.pdf đã được ghi thành công tại ổ E",
                    "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Vui lòng đóng file ReportChiTietSL_TriGiaNhapXuat.pdf",
                        "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
            }

            else
            {
                BaoCao.Xrpt_ChiTietSL_TriGiaNhapXuat rpt = new BaoCao.Xrpt_ChiTietSL_TriGiaNhapXuat(VaiTro, "XUAT", timeBD, timeKT);
                try
                {
                    if (File.Exists(@"E:\ReportChiTietSL_TriGiaNhapXuat.pdf"))
                    {
                        DialogResult dr = MessageBox.Show("File ReportChiTietSL_TriGiaNhapXuat.pdf tại ổ E đã có!\nBạn có muốn ghi đè?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            rpt.ExportToPdf(@"E:\ReportChiTietSL_TriGiaNhapXuat.pdf");
                            MessageBox.Show("File ReportChiTietSL_TriGiaNhapXuat.pdf đã được ghi thành công tại ổ E",
                    "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        rpt.ExportToPdf(@"E:\ReportChiTietSL_TriGiaNhapXuat.pdf");
                        MessageBox.Show("File ReportChiTietSL_TriGiaNhapXuat.pdf đã được ghi thành công tại ổ E",
                    "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Vui lòng đóng file ReportChiTietSL_TriGiaNhapXuat.pdf",
                        "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
            }
          
         

        }
    }
}