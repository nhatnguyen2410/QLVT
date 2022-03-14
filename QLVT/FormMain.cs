using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT
{

    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }


        public void HienThiMenu()
        {
            MANV.Text = "Mã NV: " + Program.username;
            HOTEN.Text = "Họ tên nhân viên : " + Program.mHoten;
            NHOM.Text = "Nhóm: " + Program.mGroup;
            //Phân quyền bật sáng chức năng bằng visitable
            //Tiếp tục if trên Program.Group

            ribbonControl1.Visible=true;

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKho));
            if (frm != null) frm.Activate();
            else
            {
                frmKho fKho = new frmKho();
                fKho.MdiParent = this;
                fKho.Show();
            }
        }

        private void btnDX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            this.Close();
            FormDN fm = new FormDN();
            fm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Program.mGroup =="USER")
            {
                btnThemTK.Enabled = false;
            }
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                Form frm = this.CheckExists(typeof(frmNhanvien));
                if (frm != null) frm.Activate();
                else
                {
                    frmNhanvien fnv = new frmNhanvien();
                    fnv.MdiParent = this;
                    fnv.Show();
                }

            
        }

        private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmVatTu));
            if (frm != null) frm.Activate();
            else
            {
                frmVatTu fVatTu = new frmVatTu();
                fVatTu.MdiParent = this;
                fVatTu.Show();
            }

        }

        private void btnLapPhieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormLapPhieu));
            if (frm != null) frm.Activate();
            else
            {
                Program.formLapPhieu  = new FormLapPhieu();
                Program.formLapPhieu.MdiParent = this;
                Program.formLapPhieu.Show();
                Program.formLapPhieu.btnSwitch.Links[0].Caption = "Đặt Hàng";
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void BtnDSNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(Report.frmDSNV));
            if (form != null) form.Activate();
            else
            {
                Report.frmDSNV f = new Report.frmDSNV(1);
                f.LbChucNang.Text = "Danh Sách Nhân Viên";
                Program.frmChinh.Enabled = false;
                f.ShowDialog();


            }

        }

        private void BtnRPVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form form = this.CheckExists(typeof(Report.frmDSNV));
            if (form != null) form.Activate();
            else
            {
                Report.frmDSNV f = new Report.frmDSNV(2);
                f.LbChucNang.Location = new Point(109, 30);
                f.LbChucNang.ForeColor = Color.Yellow;
                f.LbChucNang.Text = "Danh Sách Vật Tư";
                Program.frmChinh.Enabled = false;
                f.ShowDialog();
            }
        }

        private void btnTHNhapXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(Report.frmTongHopNhapXuat));
            if (form != null) form.Activate();
            else
            {
                Report.frmTongHopNhapXuat f = new Report.frmTongHopNhapXuat();
                Program.frmChinh.Enabled = false;
                f.ShowDialog();
            }
        }

        private void btnDonChuaNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(Report.frmDSNV));
            if (form != null) form.Activate();
            else
            {
                Report.frmDSNV f = new Report.frmDSNV(3);
                f.LbChucNang.ForeColor = Color.Cyan;
                f.LbChucNang.Font=new Font("Times New Roman", 17, FontStyle.Bold);
                f.LbChucNang.Location = new Point(30, 33);
                f.LbChucNang.Text = "Danh Sách Đơn đặt hàng chưa có Phiếu Nhập";
                Program.frmChinh.Enabled = false;
                f.ShowDialog();
            }
        }

        private void btnChiTietNX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(Report.frmCTSL));
            if (form != null) form.Activate();
            else
            {
                Report.frmCTSL f = new Report.frmCTSL();
                Program.frmChinh.Enabled = false;
                f.ShowDialog();
            }
        }

        private void btnHĐNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(Report.frmHĐNV));
            if (form != null) form.Activate();
            else
            {
                Report.frmHĐNV f = new Report.frmHĐNV();
                Program.frmChinh.Enabled = false;
                f.ShowDialog();
            }
        }

        private void btnThemTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Form form = this.CheckExists(typeof(FormDK));
                if (form != null) form.Activate();
                else
                {
                    FormDK f = new FormDK();
                    Program.frmChinh.Enabled = false;
                    f.ShowDialog();


                }
            }
            catch(Exception ex)
            {

            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
