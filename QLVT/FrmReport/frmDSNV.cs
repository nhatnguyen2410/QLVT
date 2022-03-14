using DevExpress.XtraEditors.UI;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using DevExpress.XtraReports.UI;

namespace QLVT.Report
{
    public partial class frmDSNV : DevExpress.XtraEditors.XtraForm
    {
        private int key;
        public frmDSNV(int key)
        {
            InitializeComponent();
            if (key == 2 || key == 3)
            {
                cmbChinhanh.Enabled = false;
                pictureBox1.Enabled = false;
                cmbChinhanh.Visible = false;
                pictureBox1.Visible = false;
            }
            else if (key == 1)
            {
                cmbChinhanh.DataSource = Program.bds_dspm;
                cmbChinhanh.DisplayMember = "TENCN";
                cmbChinhanh.ValueMember = "TENSERVER";
                if (Program.mGroup == "CONGTY")
                {
                    cmbChinhanh.Enabled = true;
                }
                else
                {
                    cmbChinhanh.Enabled = false;
                }
            }
            this.key = key;
        }

        private void frmDSNV_Load(object sender, EventArgs e)
        {

            cmbChinhanh.DataSource = Program.bds_dspm;
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
            if (Program.mGroup == "CONGTY")
            {
                cmbChinhanh.Enabled = true;
            }
            else
            {
                cmbChinhanh.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void frmDSNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.frmChinh.Enabled = true;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            switch (key)
            {
                case 1:
                    String macn = cmbChinhanh.GetItemText(cmbChinhanh.SelectedItem).ToString();
                    BaoCao.Xrpt_TTNhanVien rpt = new BaoCao.Xrpt_TTNhanVien();
                    rpt.lbChiNhanh.Text = macn;
                    ReportPrintTool print = new ReportPrintTool(rpt);
                    print.ShowPreviewDialog();
                    break;
                case 2:
                    Xrpt_DSVatTu report_Vattu = new Xrpt_DSVatTu();
                    ReportPrintTool printTool_Vattu = new ReportPrintTool(report_Vattu);
                    printTool_Vattu.ShowPreviewDialog();
                    break;
                case 3:
                    Xrpt_DDHChuaCoPhieuNhap report_DSkhongPN = new Xrpt_DDHChuaCoPhieuNhap();
                    ReportPrintTool printTool_DSkhongPN = new ReportPrintTool(report_DSkhongPN);
                    printTool_DSkhongPN.ShowPreviewDialog();
                    break;
            }
        }

        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChinhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbChinhanh.SelectedValue.ToString();
            if (cmbChinhanh.SelectedIndex != Program.mchiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);

            }
            else
            {

            }
        }

        private void frmDSNV_Load_1(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            switch (key)
            {
                case 1:
                    String macn = cmbChinhanh.GetItemText(cmbChinhanh.SelectedItem).ToString();
                    BaoCao.Xrpt_TTNhanVien report_NV = new BaoCao.Xrpt_TTNhanVien();
                    report_NV.lbChiNhanh.Text = macn;
                    try
                    {
                        if (File.Exists(@"E:\ReportTTNV.pdf"))
                        {
                            DialogResult dr = MessageBox.Show("File ReportTTNV.pdf tại ổ E đã có!\nBạn có muốn ghi đè?",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                report_NV.ExportToPdf(@"E:\ReportTTNV.pdf");
                                MessageBox.Show("File ReportTTNV.pdf đã được ghi thành công tại ổ E",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            report_NV.ExportToPdf(@"E:\ReportTTNV.pdf");
                            MessageBox.Show("File ReportTTNV.pdf đã được ghi thành công tại ổ E",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Vui lòng đóng file ReportTTNV.pdf",
                            "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        return;
                    }
                    break;

                case 2:
                    Xrpt_DSVatTu report_Vattu = new Xrpt_DSVatTu();

                    try
                    {
                        if (File.Exists(@"E:\ReportVattu.pdf"))
                        {
                            DialogResult dr = MessageBox.Show("File ReportVattu.pdf tại ổ E đã có!\nBạn có muốn ghi đè?",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                report_Vattu.ExportToPdf(@"E:\ReportVattu.pdf");
                                MessageBox.Show("File ReportVattu.pdf đã được ghi thành công tại ổ E",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            report_Vattu.ExportToPdf(@"E:\ReportVattu.pdf");
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
                    break;

                case 3:
                    Xrpt_DDHChuaCoPhieuNhap report_DH = new Xrpt_DDHChuaCoPhieuNhap();
                    try
                    {
                        if (File.Exists(@"E:\ReportDH.pdf"))
                        {
                            DialogResult dr = MessageBox.Show("File ReportDH.pdf tại ổ E đã có!\nBạn có muốn ghi đè?",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                report_DH.ExportToPdf(@"E:\ReportDH.pdf");
                                MessageBox.Show("File ReportDH.pdf đã được ghi thành công tại ổ E",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            report_DH.ExportToPdf(@"E:\ReportDH.pdf");
                            MessageBox.Show("File ReportDH.pdf đã được ghi thành công tại ổ E",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Vui lòng đóng file ReportDH.pdf",
                            "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        return;
                    }
                    break; 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}