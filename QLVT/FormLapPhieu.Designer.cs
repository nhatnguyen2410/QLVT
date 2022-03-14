namespace QLVT
{
    partial class FormLapPhieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLapPhieu));
            this.mAKHOLabel = new System.Windows.Forms.Label();
            this.nhaCCLabel = new System.Windows.Forms.Label();
            this.masoDDHLabel = new System.Windows.Forms.Label();
            this.mAPXLabel = new System.Windows.Forms.Label();
            this.hOTENKHLabel = new System.Windows.Forms.Label();
            this.mAKHOLabel1 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnSwitch = new DevExpress.XtraBars.BarSubItem();
            this.btnDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label_ChiNhanh = new System.Windows.Forms.Label();
            this.comboBox_ChiNhanh = new System.Windows.Forms.ComboBox();
            this.dS = new QLVT.QLVT_DATHANGDataSet();
            this.bdsDH = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.fKCTDDHDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.PhieuXuatTableAdapter();
            this.gridPX = new DevExpress.XtraGrid.GridControl();
            this.gvPX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.fKPhieuNhapDatHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.fKCTPNPhieuNhapBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.cTPNTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTPNTableAdapter();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.fKCTPXPXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTPXTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTPXTableAdapter();
            this.gcDDH = new DevExpress.XtraEditors.GroupControl();
            this.gridCTDDH = new DevExpress.XtraGrid.GridControl();
            this.gvCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbInfoDDH = new System.Windows.Forms.GroupBox();
            this.btnGridKho = new System.Windows.Forms.Button();
            this.txtMaKho_DH = new System.Windows.Forms.TextBox();
            this.txtNhaCC = new System.Windows.Forms.TextBox();
            this.txtMaDDH = new System.Windows.Forms.TextBox();
            this.gcPX = new DevExpress.XtraEditors.GroupControl();
            this.gridCTPX = new DevExpress.XtraGrid.GridControl();
            this.gvCTPX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbInfoPX = new System.Windows.Forms.GroupBox();
            this.txtMaKho_PX = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaPX = new System.Windows.Forms.TextBox();
            this.btnGridKho2 = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmsCTDDH = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miThemCTDDH = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCTPX = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miThemCTPX = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPN = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miThemPN = new System.Windows.Forms.ToolStripMenuItem();
            this.miXoaPN = new System.Windows.Forms.ToolStripMenuItem();
            this.miGhiPN = new System.Windows.Forms.ToolStripMenuItem();
            this.miThemCTPN = new System.Windows.Forms.ToolStripMenuItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.cmsChecked = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bạnKhôngPhảiNgườiLậpPhiếuNàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fKCTPNPhieuNhapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.NhanVienTableAdapter();
            this.qlvT_DATHANGDataSet1 = new QLVT.QLVT_DATHANGDataSet();
            this.gridCTPN = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPN = new DevExpress.XtraGrid.GridControl();
            this.gvPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPN = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridDDH = new DevExpress.XtraGrid.GridControl();
            this.gvDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTDDHDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhieuNhapDatHangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPNPhieuNhapBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPXPXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).BeginInit();
            this.gcDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).BeginInit();
            this.gbInfoDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPX)).BeginInit();
            this.gcPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPX)).BeginInit();
            this.gbInfoPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.cmsCTDDH.SuspendLayout();
            this.cmsCTPX.SuspendLayout();
            this.cmsPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.cmsChecked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPNPhieuNhapBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvT_DATHANGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPN)).BeginInit();
            this.gcPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHOLabel
            // 
            this.mAKHOLabel.AutoSize = true;
            this.mAKHOLabel.Location = new System.Drawing.Point(102, 149);
            this.mAKHOLabel.Name = "mAKHOLabel";
            this.mAKHOLabel.Size = new System.Drawing.Size(57, 14);
            this.mAKHOLabel.TabIndex = 11;
            this.mAKHOLabel.Text = "Mã Kho:";
            // 
            // nhaCCLabel
            // 
            this.nhaCCLabel.AutoSize = true;
            this.nhaCCLabel.Location = new System.Drawing.Point(102, 100);
            this.nhaCCLabel.Name = "nhaCCLabel";
            this.nhaCCLabel.Size = new System.Drawing.Size(54, 14);
            this.nhaCCLabel.TabIndex = 9;
            this.nhaCCLabel.Text = "Nhà CC:";
            // 
            // masoDDHLabel
            // 
            this.masoDDHLabel.AutoSize = true;
            this.masoDDHLabel.Location = new System.Drawing.Point(102, 50);
            this.masoDDHLabel.Name = "masoDDHLabel";
            this.masoDDHLabel.Size = new System.Drawing.Size(60, 14);
            this.masoDDHLabel.TabIndex = 7;
            this.masoDDHLabel.Text = "Mã DDH:";
            // 
            // mAPXLabel
            // 
            this.mAPXLabel.AutoSize = true;
            this.mAPXLabel.Location = new System.Drawing.Point(102, 46);
            this.mAPXLabel.Name = "mAPXLabel";
            this.mAPXLabel.Size = new System.Drawing.Size(49, 14);
            this.mAPXLabel.TabIndex = 13;
            this.mAPXLabel.Text = "Mã PX:";
            // 
            // hOTENKHLabel
            // 
            this.hOTENKHLabel.AutoSize = true;
            this.hOTENKHLabel.Location = new System.Drawing.Point(102, 101);
            this.hOTENKHLabel.Name = "hOTENKHLabel";
            this.hOTENKHLabel.Size = new System.Drawing.Size(54, 14);
            this.hOTENKHLabel.TabIndex = 14;
            this.hOTENKHLabel.Text = "Tên KH:";
            // 
            // mAKHOLabel1
            // 
            this.mAKHOLabel1.AutoSize = true;
            this.mAKHOLabel1.Location = new System.Drawing.Point(102, 153);
            this.mAKHOLabel1.Name = "mAKHOLabel1";
            this.mAKHOLabel1.Size = new System.Drawing.Size(57, 14);
            this.mAKHOLabel1.TabIndex = 15;
            this.mAKHOLabel1.Text = "Mã Kho:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnGhi,
            this.btnXoa,
            this.btnReload,
            this.btnSwitch,
            this.btnDDH,
            this.btnPN,
            this.btnPX,
            this.btnThoat,
            this.btnUndo});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Hovered.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bar2.BarAppearance.Hovered.BackColor2 = System.Drawing.Color.Turquoise;
            this.bar2.BarAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Hovered.Options.UseBackColor = true;
            this.bar2.BarAppearance.Hovered.Options.UseFont = true;
            this.bar2.BarAppearance.Normal.BackColor = System.Drawing.Color.Transparent;
            this.bar2.BarAppearance.Normal.BackColor2 = System.Drawing.Color.Transparent;
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Normal.Options.UseBackColor = true;
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSwitch, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(0, 50);
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnGhi_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Id = 10;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnReload_ItemClick);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Caption = "Lập phiếu";
            this.btnSwitch.Id = 5;
            this.btnSwitch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitch.ImageOptions.Image")));
            this.btnSwitch.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSwitch.ImageOptions.LargeImage")));
            this.btnSwitch.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.btnSwitch.Name = "btnSwitch";
            // 
            // btnDDH
            // 
            this.btnDDH.Caption = "Đặt Hàng";
            this.btnDDH.Id = 6;
            this.btnDDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDDH.ImageOptions.Image")));
            this.btnDDH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDDH.ImageOptions.LargeImage")));
            this.btnDDH.Name = "btnDDH";
            this.btnDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDDH_ItemClick);
            // 
            // btnPN
            // 
            this.btnPN.Caption = "Phiếu Nhập";
            this.btnPN.Id = 7;
            this.btnPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPN.ImageOptions.Image")));
            this.btnPN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPN.ImageOptions.LargeImage")));
            this.btnPN.Name = "btnPN";
            this.btnPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPN_ItemClick);
            // 
            // btnPX
            // 
            this.btnPX.Caption = "Phiếu Xuất";
            this.btnPX.Id = 8;
            this.btnPX.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPX.ImageOptions.Image")));
            this.btnPX.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPX.ImageOptions.LargeImage")));
            this.btnPX.Name = "btnPX";
            this.btnPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnPX_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 9;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1243, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 729);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1243, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 679);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1243, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 679);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label_ChiNhanh);
            this.groupControl1.Controls.Add(this.comboBox_ChiNhanh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 50);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1243, 65);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Chi Nhánh";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // label_ChiNhanh
            // 
            this.label_ChiNhanh.AutoSize = true;
            this.label_ChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChiNhanh.Location = new System.Drawing.Point(128, 36);
            this.label_ChiNhanh.Name = "label_ChiNhanh";
            this.label_ChiNhanh.Size = new System.Drawing.Size(66, 13);
            this.label_ChiNhanh.TabIndex = 1;
            this.label_ChiNhanh.Text = "Chi Nhánh";
            this.label_ChiNhanh.Click += new System.EventHandler(this.label_ChiNhanh_Click);
            // 
            // comboBox_ChiNhanh
            // 
            this.comboBox_ChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ChiNhanh.FormattingEnabled = true;
            this.comboBox_ChiNhanh.Location = new System.Drawing.Point(258, 34);
            this.comboBox_ChiNhanh.Name = "comboBox_ChiNhanh";
            this.comboBox_ChiNhanh.Size = new System.Drawing.Size(269, 21);
            this.comboBox_ChiNhanh.TabIndex = 0;
            this.comboBox_ChiNhanh.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ChiNhanh_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDH
            // 
            this.bdsDH.DataMember = "DatHang";
            this.bdsDH.DataSource = this.dS;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataSource = this.fKCTDDHDatHangBindingSource;
            // 
            // fKCTDDHDatHangBindingSource
            // 
            this.fKCTDDHDatHangBindingSource.DataMember = "FK_CTDDH_DatHang";
            this.fKCTDDHDatHangBindingSource.DataSource = this.bdsDH;
            // 
            // bdsPX
            // 
            this.bdsPX.DataMember = "PhieuXuat";
            this.bdsPX.DataSource = this.dS;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // gridPX
            // 
            this.gridPX.DataSource = this.bdsPX;
            this.gridPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPX.Location = new System.Drawing.Point(0, 115);
            this.gridPX.MainView = this.gvPX;
            this.gridPX.MenuManager = this.barManager1;
            this.gridPX.Name = "gridPX";
            this.gridPX.Size = new System.Drawing.Size(1243, 614);
            this.gridPX.TabIndex = 11;
            this.gridPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPX});
            this.gridPX.Visible = false;
            // 
            // gvPX
            // 
            this.gvPX.Appearance.HeaderPanel.BackColor = System.Drawing.Color.LightGreen;
            this.gvPX.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.LightGreen;
            this.gvPX.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPX.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY1,
            this.colHOTENKH,
            this.colMANV1,
            this.colMAKHO1});
            this.gvPX.GridControl = this.gridPX;
            this.gvPX.Name = "gvPX";
            this.gvPX.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gvPX.OptionsBehavior.Editable = false;
            this.gvPX.OptionsDetail.EnableMasterViewMode = false;
            this.gvPX.OptionsView.ShowGroupPanel = false;
            this.gvPX.OptionsView.ShowViewCaption = true;
            this.gvPX.ViewCaption = "Phiếu Xuất";
            // 
            // colMAPX
            // 
            this.colMAPX.Caption = "Mã PX";
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.MinWidth = 23;
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            this.colMAPX.Width = 213;
            // 
            // colNGAY1
            // 
            this.colNGAY1.Caption = "Ngày";
            this.colNGAY1.FieldName = "NGAY";
            this.colNGAY1.MinWidth = 23;
            this.colNGAY1.Name = "colNGAY1";
            this.colNGAY1.Visible = true;
            this.colNGAY1.VisibleIndex = 1;
            this.colNGAY1.Width = 223;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.Caption = "Họ tên khách hàng";
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.MinWidth = 23;
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            this.colHOTENKH.Width = 297;
            // 
            // colMANV1
            // 
            this.colMANV1.Caption = "Mã NV";
            this.colMANV1.FieldName = "MANV";
            this.colMANV1.MinWidth = 23;
            this.colMANV1.Name = "colMANV1";
            this.colMANV1.Visible = true;
            this.colMANV1.VisibleIndex = 3;
            this.colMANV1.Width = 171;
            // 
            // colMAKHO1
            // 
            this.colMAKHO1.Caption = "Mã kho";
            this.colMAKHO1.FieldName = "MAKHO";
            this.colMAKHO1.MinWidth = 23;
            this.colMAKHO1.Name = "colMAKHO1";
            this.colMAKHO1.Visible = true;
            this.colMAKHO1.VisibleIndex = 4;
            this.colMAKHO1.Width = 175;
            // 
            // bdsPN
            // 
            this.bdsPN.DataSource = this.fKPhieuNhapDatHangBindingSource1;
            // 
            // fKPhieuNhapDatHangBindingSource1
            // 
            this.fKPhieuNhapDatHangBindingSource1.DataMember = "FK_PhieuNhap_DatHang";
            this.fKPhieuNhapDatHangBindingSource1.DataSource = this.bdsDH;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataSource = this.fKCTPNPhieuNhapBindingSource5;
            // 
            // fKCTPNPhieuNhapBindingSource5
            // 
            this.fKCTPNPhieuNhapBindingSource5.DataMember = "FK_CTPN_PhieuNhap";
            this.fKCTPNPhieuNhapBindingSource5.DataSource = this.fKPhieuNhapDatHangBindingSource1;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataSource = this.fKCTPXPXBindingSource;
            // 
            // fKCTPXPXBindingSource
            // 
            this.fKCTPXPXBindingSource.DataMember = "FK_CTPX_PX";
            this.fKCTPXPXBindingSource.DataSource = this.bdsPX;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // gcDDH
            // 
            this.gcDDH.Controls.Add(this.gridCTDDH);
            this.gcDDH.Controls.Add(this.gbInfoDDH);
            this.gcDDH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcDDH.Location = new System.Drawing.Point(0, 506);
            this.gcDDH.Name = "gcDDH";
            this.gcDDH.Size = new System.Drawing.Size(1243, 223);
            this.gcDDH.TabIndex = 23;
            this.gcDDH.Text = "Đặt Hàng";
            // 
            // gridCTDDH
            // 
            this.gridCTDDH.DataSource = this.bdsCTDDH;
            this.gridCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCTDDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCTDDH.Location = new System.Drawing.Point(637, 23);
            this.gridCTDDH.MainView = this.gvCTDDH;
            this.gridCTDDH.MenuManager = this.barManager1;
            this.gridCTDDH.Name = "gridCTDDH";
            this.gridCTDDH.Size = new System.Drawing.Size(604, 198);
            this.gridCTDDH.TabIndex = 1;
            this.gridCTDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTDDH});
            this.gridCTDDH.MouseHover += new System.EventHandler(this.GridCTDDH_MouseHover);
            // 
            // gvCTDDH
            // 
            this.gvCTDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTDDH.GridControl = this.gridCTDDH;
            this.gvCTDDH.Name = "gvCTDDH";
            this.gvCTDDH.OptionsBehavior.Editable = false;
            this.gvCTDDH.OptionsView.ShowGroupPanel = false;
            this.gvCTDDH.OptionsView.ShowViewCaption = true;
            this.gvCTDDH.ViewCaption = "Chi Tiết Đơn Đặt Hàng";
            this.gvCTDDH.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.GvCTDDH_PopupMenuShowing);
            // 
            // colMasoDDH1
            // 
            this.colMasoDDH1.Caption = "Mã DDH";
            this.colMasoDDH1.FieldName = "MasoDDH";
            this.colMasoDDH1.MinWidth = 23;
            this.colMasoDDH1.Name = "colMasoDDH1";
            this.colMasoDDH1.Visible = true;
            this.colMasoDDH1.VisibleIndex = 0;
            this.colMasoDDH1.Width = 87;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã VT";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 23;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 87;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 23;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 87;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.DisplayFormat.FormatString = "VND {0:n2}";
            this.colDONGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 23;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 87;
            // 
            // gbInfoDDH
            // 
            this.gbInfoDDH.Controls.Add(this.btnGridKho);
            this.gbInfoDDH.Controls.Add(this.mAKHOLabel);
            this.gbInfoDDH.Controls.Add(this.txtMaKho_DH);
            this.gbInfoDDH.Controls.Add(this.nhaCCLabel);
            this.gbInfoDDH.Controls.Add(this.txtNhaCC);
            this.gbInfoDDH.Controls.Add(this.masoDDHLabel);
            this.gbInfoDDH.Controls.Add(this.txtMaDDH);
            this.gbInfoDDH.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbInfoDDH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoDDH.Location = new System.Drawing.Point(2, 23);
            this.gbInfoDDH.Name = "gbInfoDDH";
            this.gbInfoDDH.Size = new System.Drawing.Size(635, 198);
            this.gbInfoDDH.TabIndex = 0;
            this.gbInfoDDH.TabStop = false;
            this.gbInfoDDH.Text = "Thông Tin";
            // 
            // btnGridKho
            // 
            this.btnGridKho.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGridKho.Location = new System.Drawing.Point(389, 141);
            this.btnGridKho.Name = "btnGridKho";
            this.btnGridKho.Size = new System.Drawing.Size(53, 26);
            this.btnGridKho.TabIndex = 13;
            this.btnGridKho.Text = "chọn";
            this.btnGridKho.UseVisualStyleBackColor = true;
            this.btnGridKho.Click += new System.EventHandler(this.BtnGridKho_Click);
            // 
            // txtMaKho_DH
            // 
            this.txtMaKho_DH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDH, "MAKHO", true));
            this.txtMaKho_DH.Location = new System.Drawing.Point(204, 141);
            this.txtMaKho_DH.Name = "txtMaKho_DH";
            this.txtMaKho_DH.ReadOnly = true;
            this.txtMaKho_DH.Size = new System.Drawing.Size(164, 22);
            this.txtMaKho_DH.TabIndex = 12;
            this.txtMaKho_DH.Validating += new System.ComponentModel.CancelEventHandler(this.TxtMaKho_DH_Validating);
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDH, "NhaCC", true));
            this.txtNhaCC.Location = new System.Drawing.Point(204, 92);
            this.txtNhaCC.MaxLength = 100;
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.Size = new System.Drawing.Size(164, 22);
            this.txtNhaCC.TabIndex = 10;
            this.txtNhaCC.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNhaCC_Validating);
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDH, "MasoDDH", true));
            this.txtMaDDH.Location = new System.Drawing.Point(204, 42);
            this.txtMaDDH.MaxLength = 8;
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.Size = new System.Drawing.Size(164, 22);
            this.txtMaDDH.TabIndex = 8;
            this.txtMaDDH.Validating += new System.ComponentModel.CancelEventHandler(this.TxtMaDDH_Validating);
            // 
            // gcPX
            // 
            this.gcPX.Controls.Add(this.gridCTPX);
            this.gcPX.Controls.Add(this.gbInfoPX);
            this.gcPX.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcPX.Location = new System.Drawing.Point(0, 388);
            this.gcPX.Name = "gcPX";
            this.gcPX.Size = new System.Drawing.Size(1243, 118);
            this.gcPX.TabIndex = 31;
            this.gcPX.Text = "Phiếu Xuất";
            this.gcPX.Visible = false;
            // 
            // gridCTPX
            // 
            this.gridCTPX.DataSource = this.bdsCTPX;
            this.gridCTPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCTPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCTPX.Location = new System.Drawing.Point(578, 23);
            this.gridCTPX.MainView = this.gvCTPX;
            this.gridCTPX.MenuManager = this.barManager1;
            this.gridCTPX.Name = "gridCTPX";
            this.gridCTPX.Size = new System.Drawing.Size(663, 93);
            this.gridCTPX.TabIndex = 1;
            this.gridCTPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPX});
            this.gridCTPX.MouseHover += new System.EventHandler(this.GridCTPX_MouseHover);
            // 
            // gvCTPX
            // 
            this.gvCTPX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX1,
            this.colMAVT2,
            this.colSOLUONG2,
            this.colDONGIA2});
            this.gvCTPX.GridControl = this.gridCTPX;
            this.gvCTPX.Name = "gvCTPX";
            this.gvCTPX.OptionsBehavior.Editable = false;
            this.gvCTPX.OptionsView.ShowGroupPanel = false;
            this.gvCTPX.OptionsView.ShowViewCaption = true;
            this.gvCTPX.ViewCaption = "Chi Tiết Phiếu Xuất";
            // 
            // colMAPX1
            // 
            this.colMAPX1.Caption = "Mã PX";
            this.colMAPX1.FieldName = "MAPX";
            this.colMAPX1.MinWidth = 23;
            this.colMAPX1.Name = "colMAPX1";
            this.colMAPX1.Visible = true;
            this.colMAPX1.VisibleIndex = 0;
            this.colMAPX1.Width = 87;
            // 
            // colMAVT2
            // 
            this.colMAVT2.Caption = "Mã VT";
            this.colMAVT2.FieldName = "MAVT";
            this.colMAVT2.MinWidth = 23;
            this.colMAVT2.Name = "colMAVT2";
            this.colMAVT2.Visible = true;
            this.colMAVT2.VisibleIndex = 1;
            this.colMAVT2.Width = 87;
            // 
            // colSOLUONG2
            // 
            this.colSOLUONG2.Caption = "Số lượng";
            this.colSOLUONG2.FieldName = "SOLUONG";
            this.colSOLUONG2.MinWidth = 23;
            this.colSOLUONG2.Name = "colSOLUONG2";
            this.colSOLUONG2.Visible = true;
            this.colSOLUONG2.VisibleIndex = 2;
            this.colSOLUONG2.Width = 87;
            // 
            // colDONGIA2
            // 
            this.colDONGIA2.Caption = "Đơn giá";
            this.colDONGIA2.DisplayFormat.FormatString = "VND {0:n2}";
            this.colDONGIA2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDONGIA2.FieldName = "DONGIA";
            this.colDONGIA2.MinWidth = 23;
            this.colDONGIA2.Name = "colDONGIA2";
            this.colDONGIA2.Visible = true;
            this.colDONGIA2.VisibleIndex = 3;
            this.colDONGIA2.Width = 87;
            // 
            // gbInfoPX
            // 
            this.gbInfoPX.Controls.Add(this.mAKHOLabel1);
            this.gbInfoPX.Controls.Add(this.txtMaKho_PX);
            this.gbInfoPX.Controls.Add(this.hOTENKHLabel);
            this.gbInfoPX.Controls.Add(this.txtTenKH);
            this.gbInfoPX.Controls.Add(this.mAPXLabel);
            this.gbInfoPX.Controls.Add(this.txtMaPX);
            this.gbInfoPX.Controls.Add(this.btnGridKho2);
            this.gbInfoPX.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbInfoPX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfoPX.Location = new System.Drawing.Point(2, 23);
            this.gbInfoPX.Name = "gbInfoPX";
            this.gbInfoPX.Size = new System.Drawing.Size(576, 93);
            this.gbInfoPX.TabIndex = 0;
            this.gbInfoPX.TabStop = false;
            this.gbInfoPX.Text = "Thông Tin";
            // 
            // txtMaKho_PX
            // 
            this.txtMaKho_PX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MAKHO", true));
            this.txtMaKho_PX.Location = new System.Drawing.Point(204, 145);
            this.txtMaKho_PX.Name = "txtMaKho_PX";
            this.txtMaKho_PX.ReadOnly = true;
            this.txtMaKho_PX.Size = new System.Drawing.Size(166, 22);
            this.txtMaKho_PX.TabIndex = 16;
            this.txtMaKho_PX.Validating += new System.ComponentModel.CancelEventHandler(this.TxtMaKho_PX_Validating);
            // 
            // txtTenKH
            // 
            this.txtTenKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "HOTENKH", true));
            this.txtTenKH.Location = new System.Drawing.Point(204, 93);
            this.txtTenKH.MaxLength = 100;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(166, 22);
            this.txtTenKH.TabIndex = 15;
            this.txtTenKH.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTenKH_Validating);
            // 
            // txtMaPX
            // 
            this.txtMaPX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MAPX", true));
            this.txtMaPX.Location = new System.Drawing.Point(204, 38);
            this.txtMaPX.MaxLength = 8;
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Size = new System.Drawing.Size(167, 22);
            this.txtMaPX.TabIndex = 14;
            this.txtMaPX.Validating += new System.ComponentModel.CancelEventHandler(this.TxtMaPX_Validating);
            // 
            // btnGridKho2
            // 
            this.btnGridKho2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGridKho2.Location = new System.Drawing.Point(389, 145);
            this.btnGridKho2.Name = "btnGridKho2";
            this.btnGridKho2.Size = new System.Drawing.Size(53, 26);
            this.btnGridKho2.TabIndex = 13;
            this.btnGridKho2.Text = "chọn";
            this.btnGridKho2.UseVisualStyleBackColor = true;
            this.btnGridKho2.Click += new System.EventHandler(this.BtnGridKho2_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cmsCTDDH
            // 
            this.cmsCTDDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsCTDDH.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCTDDH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miThemCTDDH});
            this.cmsCTDDH.Name = "cmsCTDDH";
            this.cmsCTDDH.Size = new System.Drawing.Size(214, 30);
            // 
            // miThemCTDDH
            // 
            this.miThemCTDDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miThemCTDDH.Image = global::QLVT.Properties.Resources.add_phieu_nhap;
            this.miThemCTDDH.Name = "miThemCTDDH";
            this.miThemCTDDH.Size = new System.Drawing.Size(213, 26);
            this.miThemCTDDH.Text = "Thêm chi tiết đơn ĐH";
            this.miThemCTDDH.Click += new System.EventHandler(this.MiThemCTDDH_Click);
            // 
            // cmsCTPX
            // 
            this.cmsCTPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsCTPX.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCTPX.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miThemCTPX});
            this.cmsCTPX.Name = "cmsCTPX";
            this.cmsCTPX.Size = new System.Drawing.Size(233, 30);
            // 
            // miThemCTPX
            // 
            this.miThemCTPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miThemCTPX.Image = global::QLVT.Properties.Resources.add_phieu_nhap;
            this.miThemCTPX.Name = "miThemCTPX";
            this.miThemCTPX.Size = new System.Drawing.Size(232, 26);
            this.miThemCTPX.Text = "Thêm chi tiết phiếu xuất";
            this.miThemCTPX.Click += new System.EventHandler(this.MiThemCTPX_Click);
            // 
            // cmsPN
            // 
            this.cmsPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.cmsPN.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miThemPN,
            this.miXoaPN,
            this.miGhiPN,
            this.miThemCTPN});
            this.cmsPN.Name = "cmsPN";
            this.cmsPN.Size = new System.Drawing.Size(238, 108);
            // 
            // miThemPN
            // 
            this.miThemPN.Image = global::QLVT.Properties.Resources.add_phieu_nhap_1;
            this.miThemPN.Name = "miThemPN";
            this.miThemPN.Size = new System.Drawing.Size(237, 26);
            this.miThemPN.Text = "Thêm phiếu nhập";
            this.miThemPN.Click += new System.EventHandler(this.MiThemPN_Click);
            // 
            // miXoaPN
            // 
            this.miXoaPN.Enabled = false;
            this.miXoaPN.Image = global::QLVT.Properties.Resources.delete_1;
            this.miXoaPN.Name = "miXoaPN";
            this.miXoaPN.Size = new System.Drawing.Size(237, 26);
            this.miXoaPN.Text = "Xóa phiếu nhập";
            this.miXoaPN.Click += new System.EventHandler(this.MiXoaPN_Click);
            // 
            // miGhiPN
            // 
            this.miGhiPN.Enabled = false;
            this.miGhiPN.Image = global::QLVT.Properties.Resources.save;
            this.miGhiPN.Name = "miGhiPN";
            this.miGhiPN.Size = new System.Drawing.Size(237, 26);
            this.miGhiPN.Text = "Ghi vào database";
            this.miGhiPN.Click += new System.EventHandler(this.MiGhiPN_Click);
            // 
            // miThemCTPN
            // 
            this.miThemCTPN.Image = global::QLVT.Properties.Resources.add_phieu_nhap;
            this.miThemCTPN.Name = "miThemCTPN";
            this.miThemCTPN.Size = new System.Drawing.Size(237, 26);
            this.miThemCTPN.Text = "Thêm chi tiết phiếu nhập";
            this.miThemCTPN.Click += new System.EventHandler(this.MiThemCTPN_Click);
            // 
            // cmsChecked
            // 
            this.cmsChecked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsChecked.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsChecked.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bạnKhôngPhảiNgườiLậpPhiếuNàyToolStripMenuItem});
            this.cmsChecked.Name = "cmsChecked";
            this.cmsChecked.Size = new System.Drawing.Size(347, 30);
            // 
            // bạnKhôngPhảiNgườiLậpPhiếuNàyToolStripMenuItem
            // 
            this.bạnKhôngPhảiNgườiLậpPhiếuNàyToolStripMenuItem.Enabled = false;
            this.bạnKhôngPhảiNgườiLậpPhiếuNàyToolStripMenuItem.Image = global::QLVT.Properties.Resources.delete_2;
            this.bạnKhôngPhảiNgườiLậpPhiếuNàyToolStripMenuItem.Name = "bạnKhôngPhảiNgườiLậpPhiếuNàyToolStripMenuItem";
            this.bạnKhôngPhảiNgườiLậpPhiếuNàyToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.bạnKhôngPhảiNgườiLậpPhiếuNàyToolStripMenuItem.Text = "Bạn không phải người lập phiếu này.";
            // 
            // fKCTPNPhieuNhapBindingSource1
            // 
            this.fKCTPNPhieuNhapBindingSource1.DataSource = this.bdsPN;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // qlvT_DATHANGDataSet1
            // 
            this.qlvT_DATHANGDataSet1.DataSetName = "QLVT_DATHANGDataSet";
            this.qlvT_DATHANGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridCTPN
            // 
            this.gridCTPN.DataSource = this.bdsCTPN;
            this.gridCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCTPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridCTPN.Location = new System.Drawing.Point(0, 0);
            this.gridCTPN.MainView = this.gridView5;
            this.gridCTPN.MenuManager = this.barManager1;
            this.gridCTPN.Name = "gridCTPN";
            this.gridCTPN.Size = new System.Drawing.Size(610, 177);
            this.gridCTPN.TabIndex = 2;
            this.gridCTPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN1,
            this.colMAVT1,
            this.colSOLUONG1,
            this.colDONGIA1});
            this.gridView5.GridControl = this.gridCTPN;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.OptionsView.ShowViewCaption = true;
            this.gridView5.ViewCaption = "Chi Tiết Phiếu Nhập";
            // 
            // colMAPN1
            // 
            this.colMAPN1.Caption = "Mã PN";
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.MinWidth = 23;
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.OptionsColumn.AllowEdit = false;
            this.colMAPN1.Visible = true;
            this.colMAPN1.VisibleIndex = 0;
            this.colMAPN1.Width = 87;
            // 
            // colMAVT1
            // 
            this.colMAVT1.Caption = "Mã VT";
            this.colMAVT1.FieldName = "MAVT";
            this.colMAVT1.MinWidth = 23;
            this.colMAVT1.Name = "colMAVT1";
            this.colMAVT1.Visible = true;
            this.colMAVT1.VisibleIndex = 1;
            this.colMAVT1.Width = 87;
            // 
            // colSOLUONG1
            // 
            this.colSOLUONG1.Caption = "Số lượng";
            this.colSOLUONG1.FieldName = "SOLUONG";
            this.colSOLUONG1.MinWidth = 23;
            this.colSOLUONG1.Name = "colSOLUONG1";
            this.colSOLUONG1.Visible = true;
            this.colSOLUONG1.VisibleIndex = 2;
            this.colSOLUONG1.Width = 87;
            // 
            // colDONGIA1
            // 
            this.colDONGIA1.Caption = "Đơn giá";
            this.colDONGIA1.DisplayFormat.FormatString = "VND {0:n2}";
            this.colDONGIA1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDONGIA1.FieldName = "DONGIA";
            this.colDONGIA1.MinWidth = 23;
            this.colDONGIA1.Name = "colDONGIA1";
            this.colDONGIA1.Visible = true;
            this.colDONGIA1.VisibleIndex = 3;
            this.colDONGIA1.Width = 87;
            // 
            // gridPN
            // 
            this.gridPN.DataSource = this.bdsPN;
            this.gridPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPN.EmbeddedNavigator.Appearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.gridPN.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPN.EmbeddedNavigator.Appearance.Options.UseBorderColor = true;
            this.gridPN.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridPN.Location = new System.Drawing.Point(0, 0);
            this.gridPN.MainView = this.gvPN;
            this.gridPN.MenuManager = this.barManager1;
            this.gridPN.Name = "gridPN";
            this.gridPN.Size = new System.Drawing.Size(625, 177);
            this.gridPN.TabIndex = 1;
            this.gridPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPN});
            this.gridPN.MouseHover += new System.EventHandler(this.GridPN_MouseHover);
            // 
            // gvPN
            // 
            this.gvPN.Appearance.HeaderPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.gvPN.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.SeaGreen;
            this.gvPN.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPN.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPN.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPN.Appearance.VertLine.Options.UseBorderColor = true;
            this.gvPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY2,
            this.colMasoDDH2,
            this.colMANV2,
            this.colMAKHO2});
            this.gvPN.GridControl = this.gridPN;
            this.gvPN.Name = "gvPN";
            this.gvPN.OptionsView.ShowGroupPanel = false;
            this.gvPN.OptionsView.ShowViewCaption = true;
            this.gvPN.ViewCaption = "Phiếu Nhập Của Đơn Hàng";
            // 
            // colMAPN
            // 
            this.colMAPN.Caption = "Mã PN";
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 23;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 87;
            // 
            // colNGAY2
            // 
            this.colNGAY2.Caption = "Ngày";
            this.colNGAY2.FieldName = "NGAY";
            this.colNGAY2.MinWidth = 23;
            this.colNGAY2.Name = "colNGAY2";
            this.colNGAY2.OptionsColumn.AllowEdit = false;
            this.colNGAY2.Visible = true;
            this.colNGAY2.VisibleIndex = 1;
            this.colNGAY2.Width = 87;
            // 
            // colMasoDDH2
            // 
            this.colMasoDDH2.Caption = "Mã DDH";
            this.colMasoDDH2.FieldName = "MasoDDH";
            this.colMasoDDH2.MinWidth = 23;
            this.colMasoDDH2.Name = "colMasoDDH2";
            this.colMasoDDH2.OptionsColumn.AllowEdit = false;
            this.colMasoDDH2.Visible = true;
            this.colMasoDDH2.VisibleIndex = 2;
            this.colMasoDDH2.Width = 87;
            // 
            // colMANV2
            // 
            this.colMANV2.Caption = "Mã NV";
            this.colMANV2.FieldName = "MANV";
            this.colMANV2.MinWidth = 23;
            this.colMANV2.Name = "colMANV2";
            this.colMANV2.OptionsColumn.AllowEdit = false;
            this.colMANV2.Visible = true;
            this.colMANV2.VisibleIndex = 3;
            this.colMANV2.Width = 87;
            // 
            // colMAKHO2
            // 
            this.colMAKHO2.Caption = "Mã Kho";
            this.colMAKHO2.FieldName = "MAKHO";
            this.colMAKHO2.MinWidth = 23;
            this.colMAKHO2.Name = "colMAKHO2";
            this.colMAKHO2.OptionsColumn.AllowEdit = false;
            this.colMAKHO2.Visible = true;
            this.colMAKHO2.VisibleIndex = 4;
            this.colMAKHO2.Width = 87;
            // 
            // gcPN
            // 
            this.gcPN.Controls.Add(this.splitContainer1);
            this.gcPN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcPN.Location = new System.Drawing.Point(0, 186);
            this.gcPN.Name = "gcPN";
            this.gcPN.Size = new System.Drawing.Size(1243, 202);
            this.gcPN.TabIndex = 43;
            this.gcPN.Text = "Phiếu Nhập";
            this.gcPN.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 23);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridPN);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridCTPN);
            this.splitContainer1.Size = new System.Drawing.Size(1239, 177);
            this.splitContainer1.SplitterDistance = 625;
            this.splitContainer1.TabIndex = 2;
            // 
            // gridDDH
            // 
            this.gridDDH.DataSource = this.bdsDH;
            this.gridDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDDH.Location = new System.Drawing.Point(0, 115);
            this.gridDDH.MainView = this.gvDDH;
            this.gridDDH.MenuManager = this.barManager1;
            this.gridDDH.Name = "gridDDH";
            this.gridDDH.Size = new System.Drawing.Size(1243, 71);
            this.gridDDH.TabIndex = 45;
            this.gridDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDDH});
            // 
            // gvDDH
            // 
            this.gvDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
            this.gvDDH.GridControl = this.gridDDH;
            this.gvDDH.Name = "gvDDH";
            this.gvDDH.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gvDDH.OptionsBehavior.Editable = false;
            this.gvDDH.OptionsDetail.EnableMasterViewMode = false;
            this.gvDDH.OptionsView.ShowGroupPanel = false;
            this.gvDDH.OptionsView.ShowViewCaption = true;
            this.gvDDH.ViewCaption = "Đơn Đặt Hàng";
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã DDH";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 23;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 183;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 23;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 183;
            // 
            // colNhaCC
            // 
            this.colNhaCC.Caption = "Nhà cung cấp";
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 23;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 190;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã NV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 23;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 163;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 23;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 184;
            // 
            // FormLapPhieu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1243, 749);
            this.Controls.Add(this.gridDDH);
            this.Controls.Add(this.gcPN);
            this.Controls.Add(this.gcPX);
            this.Controls.Add(this.gcDDH);
            this.Controls.Add(this.gridPX);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormLapPhieu";
            this.Text = "Lập Phiếu";
            this.Load += new System.EventHandler(this.FormLapPhieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTDDHDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhieuNhapDatHangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPNPhieuNhapBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPXPXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).EndInit();
            this.gcDDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).EndInit();
            this.gbInfoDDH.ResumeLayout(false);
            this.gbInfoDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPX)).EndInit();
            this.gcPX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPX)).EndInit();
            this.gbInfoPX.ResumeLayout(false);
            this.gbInfoPX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.cmsCTDDH.ResumeLayout(false);
            this.cmsCTPX.ResumeLayout(false);
            this.cmsPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.cmsChecked.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPNPhieuNhapBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlvT_DATHANGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPN)).EndInit();
            this.gcPN.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnDDH;
        private DevExpress.XtraBars.BarButtonItem btnPN;
        private DevExpress.XtraBars.BarButtonItem btnPX;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label_ChiNhanh;
        private System.Windows.Forms.ComboBox comboBox_ChiNhanh;
        private System.Windows.Forms.BindingSource bdsDH;
        private QLVT_DATHANGDataSet dS;
        private QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private System.Windows.Forms.BindingSource bdsPX;
        private QLVT_DATHANGDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DevExpress.XtraGrid.GridControl gridPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPX;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY1;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO1;
        private System.Windows.Forms.BindingSource bdsPN;
        private QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private QLVT_DATHANGDataSetTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private QLVT_DATHANGDataSetTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private DevExpress.XtraEditors.GroupControl gcDDH;
        private DevExpress.XtraGrid.GridControl gridCTDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.GroupBox gbInfoDDH;
        private System.Windows.Forms.Button btnGridKho;
        private System.Windows.Forms.TextBox txtNhaCC;
        private System.Windows.Forms.TextBox txtMaDDH;
        private DevExpress.XtraEditors.GroupControl gcPX;
        private System.Windows.Forms.GroupBox gbInfoPX;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaPX;
        private System.Windows.Forms.Button btnGridKho2;
        private DevExpress.XtraGrid.GridControl gridCTPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPX;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT2;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG2;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA2;
        public System.Windows.Forms.TextBox txtMaKho_DH;
        public DevExpress.XtraBars.BarSubItem btnSwitch;
        public System.Windows.Forms.TextBox txtMaKho_PX;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ContextMenuStrip cmsCTDDH;
        private System.Windows.Forms.ToolStripMenuItem miThemCTDDH;
        private System.Windows.Forms.ContextMenuStrip cmsCTPX;
        private System.Windows.Forms.ToolStripMenuItem miThemCTPX;
        private System.Windows.Forms.ContextMenuStrip cmsPN;
        private System.Windows.Forms.ToolStripMenuItem miThemPN;
        private System.Windows.Forms.ToolStripMenuItem miXoaPN;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.ToolStripMenuItem miGhiPN;
        private System.Windows.Forms.ContextMenuStrip cmsChecked;
        private System.Windows.Forms.ToolStripMenuItem bạnKhôngPhảiNgườiLậpPhiếuNàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miThemCTPN;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private System.Windows.Forms.BindingSource fKCTDDHDatHangBindingSource;
        private System.Windows.Forms.BindingSource fKCTPXPXBindingSource;
        private System.Windows.Forms.BindingSource fKCTPNPhieuNhapBindingSource1;
        private System.Windows.Forms.BindingSource fKPhieuNhapDatHangBindingSource1;
        private System.Windows.Forms.BindingSource fKCTPNPhieuNhapBindingSource5;
        private System.Windows.Forms.Label mAKHOLabel;
        private System.Windows.Forms.Label nhaCCLabel;
        private System.Windows.Forms.Label masoDDHLabel;
        private System.Windows.Forms.Label mAPXLabel;
        private System.Windows.Forms.Label hOTENKHLabel;
        private System.Windows.Forms.Label mAKHOLabel1;
        private QLVT_DATHANGDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QLVT_DATHANGDataSet qlvT_DATHANGDataSet1;
        private DevExpress.XtraEditors.GroupControl gcPN;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY2;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH2;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO2;
        private DevExpress.XtraGrid.GridControl gridCTPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG1;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA1;
        private DevExpress.XtraGrid.GridControl gridDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
    }
}