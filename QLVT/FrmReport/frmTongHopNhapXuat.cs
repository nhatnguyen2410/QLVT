using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT.Report
{
    public partial class frmTongHopNhapXuat : DevExpress.XtraEditors.XtraForm
    {
        public frmTongHopNhapXuat()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmTongHopNhapXuat_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }




        private void frmTongHopNhapXuat_Load(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click_1(object sender, EventArgs e)
        {
            Xrpt_TongHopNhapXuat rp_TongHopNhapXuat = new Xrpt_TongHopNhapXuat(dateEdit1.DateTime, dateEdit2.DateTime);
            ReportPrintTool printTool_TonghopNhapXuat = new ReportPrintTool(rp_TongHopNhapXuat);
            printTool_TonghopNhapXuat.ShowPreviewDialog();
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            Xrpt_TongHopNhapXuat rp_TongHopNhapXuat = new Xrpt_TongHopNhapXuat(dateEdit1.DateTime, dateEdit2.DateTime);

            try
            {
                if (File.Exists(@"E:\ReportTongHopNhapXuat.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportTongHopNhapXuat.pdf tại ổ E đã có!\nBạn có muốn ghi đè?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        rp_TongHopNhapXuat.ExportToPdf(@"E:\ReportVattu.pdf");
                        MessageBox.Show("File ReportTongHopNhapXuat.pdf đã được ghi thành công tại ổ E",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    rp_TongHopNhapXuat.ExportToPdf(@"E:\ReportTongHopNhapXuat.pdf");
                    MessageBox.Show("File ReportVattu.pdf đã được ghi thành công tại ổ E",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportVattu.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}