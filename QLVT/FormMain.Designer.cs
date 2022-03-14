
namespace QLVT
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnLapPhieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnDX = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRPNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRPVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnCTNhapXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonChuaNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnHĐNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHNhapXuat = new DevExpress.XtraBars.BarButtonItem();
            this.rbDanhSach = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnNhanVien,
            this.btnVatTu,
            this.btnKho,
            this.btnLapPhieu,
            this.btnThemTK,
            this.btnDX,
            this.barButtonItem1,
            this.BtnRPNhanVien,
            this.BtnRPVatTu,
            this.btnCTNhapXuat,
            this.barButtonItem5,
            this.btnDonChuaNhap,
            this.btnHĐNV,
            this.btnTHNhapXuat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbDanhSach,
            this.rbBaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(758, 158);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân Viên";
            this.btnNhanVien.Id = 1;
            this.btnNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.LargeImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnVatTu
            // 
            this.btnVatTu.Caption = "Vật Tư";
            this.btnVatTu.Id = 2;
            this.btnVatTu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnVatTu.ImageOptions.SvgImage")));
            this.btnVatTu.Name = "btnVatTu";
            this.btnVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVatTu_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Kho";
            this.btnKho.Id = 3;
            this.btnKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKho.ImageOptions.Image")));
            this.btnKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKho.ImageOptions.LargeImage")));
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Caption = "Lập Phiếu";
            this.btnLapPhieu.Id = 4;
            this.btnLapPhieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLapPhieu.ImageOptions.Image")));
            this.btnLapPhieu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLapPhieu.ImageOptions.LargeImage")));
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLapPhieu_ItemClick);
            // 
            // btnThemTK
            // 
            this.btnThemTK.Caption = "Thêm Tài Khoản";
            this.btnThemTK.Id = 5;
            this.btnThemTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTK.ImageOptions.Image")));
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnThemTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemTK_ItemClick);
            // 
            // btnDX
            // 
            this.btnDX.Caption = "Đăng Xuất";
            this.btnDX.Id = 6;
            this.btnDX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDX.ImageOptions.Image")));
            this.btnDX.Name = "btnDX";
            this.btnDX.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDX_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.ActAsDropDown = true;
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.Image = global::QLVT.Properties.Resources.he_thong;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // BtnRPNhanVien
            // 
            this.BtnRPNhanVien.Caption = "Danh sách nhân viên";
            this.BtnRPNhanVien.Id = 8;
            this.BtnRPNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnRPNhanVien.ImageOptions.SvgImage")));
            this.BtnRPNhanVien.Name = "BtnRPNhanVien";
            this.BtnRPNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDSNhanVien_ItemClick);
            // 
            // BtnRPVatTu
            // 
            this.BtnRPVatTu.Caption = "Danh sách vật tư";
            this.BtnRPVatTu.Id = 9;
            this.BtnRPVatTu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnRPVatTu.ImageOptions.SvgImage")));
            this.BtnRPVatTu.Name = "BtnRPVatTu";
            this.BtnRPVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnRPVatTu_ItemClick);
            // 
            // btnCTNhapXuat
            // 
            this.btnCTNhapXuat.Caption = "Chi tiết SL Nhập Xuất";
            this.btnCTNhapXuat.Id = 10;
            this.btnCTNhapXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCTNhapXuat.ImageOptions.SvgImage")));
            this.btnCTNhapXuat.Name = "btnCTNhapXuat";
            this.btnCTNhapXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChiTietNX_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 11;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnDonChuaNhap
            // 
            this.btnDonChuaNhap.Caption = "Đơn ĐH chưa có phiếu Nhập";
            this.btnDonChuaNhap.Id = 12;
            this.btnDonChuaNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDonChuaNhap.ImageOptions.SvgImage")));
            this.btnDonChuaNhap.Name = "btnDonChuaNhap";
            this.btnDonChuaNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDonChuaNhap_ItemClick);
            // 
            // btnHĐNV
            // 
            this.btnHĐNV.Caption = "Hoạt động nhân viên";
            this.btnHĐNV.Id = 13;
            this.btnHĐNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHĐNV.ImageOptions.SvgImage")));
            this.btnHĐNV.Name = "btnHĐNV";
            this.btnHĐNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHĐNV_ItemClick);
            // 
            // btnTHNhapXuat
            // 
            this.btnTHNhapXuat.Caption = "Tổng hợp Nhập Xuất";
            this.btnTHNhapXuat.Id = 14;
            this.btnTHNhapXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHNhapXuat.ImageOptions.SvgImage")));
            this.btnTHNhapXuat.Name = "btnTHNhapXuat";
            this.btnTHNhapXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHNhapXuat_ItemClick);
            // 
            // rbDanhSach
            // 
            this.rbDanhSach.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.rbDanhSach.Name = "rbDanhSach";
            this.rbDanhSach.Text = "Danh Sách";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup1.ImageOptions.SvgImage")));
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnVatTu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKho);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLapPhieu);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnThemTK);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDX);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // rbBaoCao
            // 
            this.rbBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbBaoCao.Name = "rbBaoCao";
            this.rbBaoCao.Text = "Báo Cáo";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnRPNhanVien);
            this.ribbonPageGroup3.ItemLinks.Add(this.BtnRPVatTu);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCTNhapXuat);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDonChuaNhap);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHĐNV);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTHNhapXuat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            toolTipTitleItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Danh sách nhân viên";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.ribbonPageGroup3.SuperTip = superToolTip1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(758, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(42, 17);
            this.MANV.Text = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(45, 17);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(45, 17);
            this.NHOM.Text = "NHOM";
            this.NHOM.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 484);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLVT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbDanhSach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnVatTu;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.BarButtonItem btnLapPhieu;
        private DevExpress.XtraBars.BarButtonItem btnThemTK;
        private DevExpress.XtraBars.BarButtonItem btnDX;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem BtnRPNhanVien;
        private DevExpress.XtraBars.BarButtonItem BtnRPVatTu;
        private DevExpress.XtraBars.BarButtonItem btnCTNhapXuat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnDonChuaNhap;
        private DevExpress.XtraBars.BarButtonItem btnHĐNV;
        private DevExpress.XtraBars.BarButtonItem btnTHNhapXuat;
    }
}

