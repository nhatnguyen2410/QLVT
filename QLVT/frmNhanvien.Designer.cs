
namespace QLVT
{
    partial class frmNhanvien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode5 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode6 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode7 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode8 = new DevExpress.XtraGrid.GridLevelNode();
            this.barQL = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiLai = new DevExpress.XtraBars.BarButtonItem();
            this.btnCCN = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.dS = new QLVT.QLVT_DATHANGDataSet();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.grChiNhanh = new DevExpress.XtraEditors.GroupControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.BDSDH = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter();
            this.BDSPX = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.PhieuXuatTableAdapter();
            this.BDSPN = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.chiNhanhTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.ChiNhanhTableAdapter();
            this.khoTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter();
            this.cTPNTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTPNTableAdapter();
            this.cTDDHTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter();
            this.BDSCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.hOLabel = new System.Windows.Forms.Label();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.tENLabel = new System.Windows.Forms.Label();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.dIACHILabel = new System.Windows.Forms.Label();
            this.DateNV = new DevExpress.XtraEditors.DateEdit();
            this.nGAYSINHLabel = new System.Windows.Forms.Label();
            this.SpinLuong = new DevExpress.XtraEditors.SpinEdit();
            this.lUONGLabel = new System.Windows.Forms.Label();
            this.txtMACN = new DevExpress.XtraEditors.TextEdit();
            this.mACNLabel = new System.Windows.Forms.Label();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.trangThaiXoaCheckBox = new System.Windows.Forms.CheckBox();
            this.grTTNV = new DevExpress.XtraEditors.GroupControl();
            this.gcNV = new DevExpress.XtraGrid.GridControl();
            this.grNV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            mANVLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grChiNhanh)).BeginInit();
            this.grChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDSDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateNV.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTTNV)).BeginInit();
            this.grTTNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grNV)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(22, 53);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(39, 13);
            mANVLabel.TabIndex = 37;
            mANVLabel.Text = "MANV:";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(754, 131);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(83, 13);
            trangThaiXoaLabel.TabIndex = 38;
            trangThaiXoaLabel.Text = "Trang Thai Xoa:";
            // 
            // barQL
            // 
            this.barQL.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barQL.DockControls.Add(this.barDockControlTop);
            this.barQL.DockControls.Add(this.barDockControlBottom);
            this.barQL.DockControls.Add(this.barDockControlLeft);
            this.barQL.DockControls.Add(this.barDockControlRight);
            this.barQL.DockWindowTabFont = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barQL.Form = this;
            this.barQL.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnPhucHoi,
            this.btnTaiLai,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem2,
            this.btnCCN,
            this.btnThoat,
            this.btnHieuChinh});
            this.barQL.MainMenu = this.bar2;
            this.barQL.MaxItemId = 13;
            // 
            // bar1
            // 
            this.bar1.BarAppearance.Hovered.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bar1.BarAppearance.Hovered.BackColor2 = System.Drawing.Color.Turquoise;
            this.bar1.BarAppearance.Hovered.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.BarAppearance.Hovered.Options.UseBackColor = true;
            this.bar1.BarAppearance.Hovered.Options.UseFont = true;
            this.bar1.BarAppearance.Normal.BackColor = System.Drawing.Color.Transparent;
            this.bar1.BarAppearance.Normal.BackColor2 = System.Drawing.Color.Transparent;
            this.bar1.BarAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar1.BarAppearance.Normal.Options.UseBackColor = true;
            this.bar1.BarAppearance.Normal.Options.UseFont = true;
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTaiLai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCCN, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.Size = new System.Drawing.Size(0, 50);
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu Chỉnh";
            this.btnHieuChinh.Id = 12;
            this.btnHieuChinh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHieuChinh.ImageOptions.SvgImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 5;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Caption = "Tải lại";
            this.btnTaiLai.Id = 6;
            this.btnTaiLai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaiLai.ImageOptions.SvgImage")));
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiLai_ItemClick);
            // 
            // btnCCN
            // 
            this.btnCCN.Caption = "Chuyển Chi Nhánh";
            this.btnCCN.Id = 10;
            this.btnCCN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCCN.ImageOptions.SvgImage")));
            this.btnCCN.Name = "btnCCN";
            this.btnCCN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCCN_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 11;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(257, 164);
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Appearance.BackColor = System.Drawing.Color.White;
            this.barDockControlTop.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barDockControlTop.Appearance.Options.UseBackColor = true;
            this.barDockControlTop.Appearance.Options.UseFont = true;
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barQL;
            this.barDockControlTop.Size = new System.Drawing.Size(1199, 71);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 631);
            this.barDockControlBottom.Manager = this.barQL;
            this.barDockControlBottom.Size = new System.Drawing.Size(1199, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 71);
            this.barDockControlLeft.Manager = this.barQL;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 560);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1199, 71);
            this.barDockControlRight.Manager = this.barQL;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 560);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.ActAsDropDown = true;
            this.barButtonItem8.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem8.Caption = "Chuyển Chi Nhánh";
            this.barButtonItem8.Id = 7;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Thoát";
            this.barButtonItem9.Id = 8;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thoát";
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.EnforceConstraints = false;
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNV
            // 
            this.bdsNV.AllowNew = true;
            this.bdsNV.DataMember = "NhanVien";
            this.bdsNV.DataSource = this.dS;
            this.bdsNV.CurrentChanged += new System.EventHandler(this.bdsNV_CurrentChanged);
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // grChiNhanh
            // 
            this.grChiNhanh.AutoSize = true;
            this.grChiNhanh.Controls.Add(this.cmbChiNhanh);
            this.grChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.grChiNhanh.Location = new System.Drawing.Point(0, 71);
            this.grChiNhanh.Name = "grChiNhanh";
            this.grChiNhanh.Size = new System.Drawing.Size(1199, 87);
            this.grChiNhanh.TabIndex = 25;
            this.grChiNhanh.Text = "Chi Nhánh";
            this.grChiNhanh.Paint += new System.Windows.Forms.PaintEventHandler(this.grChiNhanh_Paint);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(152, 38);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(276, 21);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // BDSDH
            // 
            this.BDSDH.AllowNew = true;
            this.BDSDH.DataMember = "FK_DatHang_NhanVien";
            this.BDSDH.DataSource = this.bdsNV;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // BDSPX
            // 
            this.BDSPX.AllowNew = true;
            this.BDSPX.DataMember = "FK_PX_NhanVien";
            this.BDSPX.DataSource = this.bdsNV;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // BDSPN
            // 
            this.BDSPN.AllowNew = true;
            this.BDSPN.DataMember = "FK_PhieuNhap_NhanVien";
            this.BDSPN.DataSource = this.bdsNV;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // chiNhanhTableAdapter
            // 
            this.chiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // BDSCTDDH
            // 
            this.BDSCTDDH.AllowNew = true;
            this.BDSCTDDH.DataMember = "FK_CTDDH_DatHang";
            this.BDSCTDDH.DataSource = this.BDSDH;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(268, 49);
            this.txtHo.MenuManager = this.barQL;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(100, 20);
            this.txtHo.TabIndex = 32;
            // 
            // hOLabel
            // 
            this.hOLabel.AutoSize = true;
            this.hOLabel.Location = new System.Drawing.Point(236, 53);
            this.hOLabel.Name = "hOLabel";
            this.hOLabel.Size = new System.Drawing.Size(26, 13);
            this.hOLabel.TabIndex = 31;
            this.hOLabel.Text = "HO:";
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(573, 49);
            this.txtTen.MenuManager = this.barQL;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 33;
            // 
            // tENLabel
            // 
            this.tENLabel.AutoSize = true;
            this.tENLabel.Location = new System.Drawing.Point(501, 53);
            this.tENLabel.Name = "tENLabel";
            this.tENLabel.Size = new System.Drawing.Size(30, 13);
            this.tENLabel.TabIndex = 32;
            this.tENLabel.Text = "TEN:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(268, 127);
            this.txtDiaChi.MenuManager = this.barQL;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 20);
            this.txtDiaChi.TabIndex = 34;
            // 
            // dIACHILabel
            // 
            this.dIACHILabel.AutoSize = true;
            this.dIACHILabel.Location = new System.Drawing.Point(215, 131);
            this.dIACHILabel.Name = "dIACHILabel";
            this.dIACHILabel.Size = new System.Drawing.Size(47, 13);
            this.dIACHILabel.TabIndex = 33;
            this.dIACHILabel.Text = "DIACHI:";
            // 
            // DateNV
            // 
            this.DateNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "NGAYSINH", true));
            this.DateNV.EditValue = null;
            this.DateNV.Location = new System.Drawing.Point(843, 49);
            this.DateNV.MenuManager = this.barQL;
            this.DateNV.Name = "DateNV";
            this.DateNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateNV.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateNV.Size = new System.Drawing.Size(100, 20);
            this.DateNV.TabIndex = 35;
            // 
            // nGAYSINHLabel
            // 
            this.nGAYSINHLabel.AutoSize = true;
            this.nGAYSINHLabel.Location = new System.Drawing.Point(775, 53);
            this.nGAYSINHLabel.Name = "nGAYSINHLabel";
            this.nGAYSINHLabel.Size = new System.Drawing.Size(62, 13);
            this.nGAYSINHLabel.TabIndex = 34;
            this.nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // SpinLuong
            // 
            this.SpinLuong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "LUONG", true));
            this.SpinLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SpinLuong.Location = new System.Drawing.Point(573, 127);
            this.SpinLuong.MenuManager = this.barQL;
            this.SpinLuong.Name = "SpinLuong";
            this.SpinLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SpinLuong.Properties.DisplayFormat.FormatString = "n0";
            this.SpinLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SpinLuong.Properties.EditFormat.FormatString = "n0";
            this.SpinLuong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SpinLuong.Size = new System.Drawing.Size(100, 20);
            this.SpinLuong.TabIndex = 36;
            // 
            // lUONGLabel
            // 
            this.lUONGLabel.AutoSize = true;
            this.lUONGLabel.Location = new System.Drawing.Point(501, 131);
            this.lUONGLabel.Name = "lUONGLabel";
            this.lUONGLabel.Size = new System.Drawing.Size(45, 13);
            this.lUONGLabel.TabIndex = 35;
            this.lUONGLabel.Text = "LUONG:";
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MACN", true));
            this.txtMACN.Location = new System.Drawing.Point(68, 127);
            this.txtMACN.MenuManager = this.barQL;
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.Properties.ReadOnly = true;
            this.txtMACN.Size = new System.Drawing.Size(100, 20);
            this.txtMACN.TabIndex = 37;
            // 
            // mACNLabel
            // 
            this.mACNLabel.AutoSize = true;
            this.mACNLabel.Location = new System.Drawing.Point(22, 131);
            this.mACNLabel.Name = "mACNLabel";
            this.mACNLabel.Size = new System.Drawing.Size(40, 13);
            this.mACNLabel.TabIndex = 36;
            this.mACNLabel.Text = "MACN:";
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(67, 49);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(101, 21);
            this.txtMANV.TabIndex = 38;
            // 
            // trangThaiXoaCheckBox
            // 
            this.trangThaiXoaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsNV, "TrangThaiXoa", true));
            this.trangThaiXoaCheckBox.Location = new System.Drawing.Point(843, 127);
            this.trangThaiXoaCheckBox.Name = "trangThaiXoaCheckBox";
            this.trangThaiXoaCheckBox.Size = new System.Drawing.Size(14, 21);
            this.trangThaiXoaCheckBox.TabIndex = 39;
            this.trangThaiXoaCheckBox.UseVisualStyleBackColor = true;
            // 
            // grTTNV
            // 
            this.grTTNV.AlwaysScrollActiveControlIntoView = false;
            this.grTTNV.Controls.Add(trangThaiXoaLabel);
            this.grTTNV.Controls.Add(this.trangThaiXoaCheckBox);
            this.grTTNV.Controls.Add(mANVLabel);
            this.grTTNV.Controls.Add(this.txtMANV);
            this.grTTNV.Controls.Add(this.mACNLabel);
            this.grTTNV.Controls.Add(this.txtMACN);
            this.grTTNV.Controls.Add(this.lUONGLabel);
            this.grTTNV.Controls.Add(this.SpinLuong);
            this.grTTNV.Controls.Add(this.nGAYSINHLabel);
            this.grTTNV.Controls.Add(this.DateNV);
            this.grTTNV.Controls.Add(this.dIACHILabel);
            this.grTTNV.Controls.Add(this.txtDiaChi);
            this.grTTNV.Controls.Add(this.tENLabel);
            this.grTTNV.Controls.Add(this.txtTen);
            this.grTTNV.Controls.Add(this.hOLabel);
            this.grTTNV.Controls.Add(this.txtHo);
            this.grTTNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grTTNV.Location = new System.Drawing.Point(0, 424);
            this.grTTNV.Name = "grTTNV";
            this.grTTNV.Size = new System.Drawing.Size(1199, 207);
            this.grTTNV.TabIndex = 27;
            this.grTTNV.Text = "Thông Tin";
            this.grTTNV.Paint += new System.Windows.Forms.PaintEventHandler(this.grTTNV_Paint);
            // 
            // gcNV
            // 
            this.gcNV.DataSource = this.bdsNV;
            this.gcNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode2.RelationName = "FK_CTDDH_DatHang";
            gridLevelNode4.RelationName = "FK_CTPN_PhieuNhap";
            gridLevelNode3.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode4});
            gridLevelNode3.RelationName = "FK_PhieuNhap_DatHang";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2,
            gridLevelNode3});
            gridLevelNode1.RelationName = "FK_DatHang_NhanVien";
            gridLevelNode6.RelationName = "FK_CTPN_PhieuNhap";
            gridLevelNode5.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode6});
            gridLevelNode5.RelationName = "FK_PhieuNhap_NhanVien";
            gridLevelNode8.RelationName = "FK_CTPX_PX";
            gridLevelNode7.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode8});
            gridLevelNode7.RelationName = "FK_PX_NhanVien";
            this.gcNV.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode5,
            gridLevelNode7});
            this.gcNV.Location = new System.Drawing.Point(0, 158);
            this.gcNV.MainView = this.grNV;
            this.gcNV.Name = "gcNV";
            this.gcNV.Size = new System.Drawing.Size(1199, 266);
            this.gcNV.TabIndex = 32;
            this.gcNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grNV});
            // 
            // grNV
            // 
            this.grNV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa});
            this.grNV.DetailHeight = 300;
            this.grNV.GridControl = this.gcNV;
            this.grNV.Name = "grNV";
            this.grNV.OptionsBehavior.Editable = false;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            // 
            // colLUONG
            // 
            this.colLUONG.DisplayFormat.FormatString = "n0";
            this.colLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1199, 631);
            this.Controls.Add(this.gcNV);
            this.Controls.Add(this.grTTNV);
            this.Controls.Add(this.grChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MinimumSize = new System.Drawing.Size(866, 32);
            this.Name = "frmNhanvien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grChiNhanh)).EndInit();
            this.grChiNhanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BDSDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateNV.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTTNV)).EndInit();
            this.grTTNV.ResumeLayout(false);
            this.grTTNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barQL;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnTaiLai;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.BindingSource bdsNV;
        private QLVT_DATHANGDataSet dS;
        private QLVT_DATHANGDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl grChiNhanh;
        private DevExpress.XtraBars.BarButtonItem btnCCN;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource BDSDH;
        private QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource BDSPX;
        private QLVT_DATHANGDataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private System.Windows.Forms.BindingSource BDSPN;
        private QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private QLVT_DATHANGDataSetTableAdapters.ChiNhanhTableAdapter chiNhanhTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource BDSCTDDH;
        private DevExpress.XtraEditors.GroupControl grTTNV;
        private System.Windows.Forms.CheckBox trangThaiXoaCheckBox;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Label mACNLabel;
        private DevExpress.XtraEditors.TextEdit txtMACN;
        private System.Windows.Forms.Label lUONGLabel;
        private DevExpress.XtraEditors.SpinEdit SpinLuong;
        private System.Windows.Forms.Label nGAYSINHLabel;
        private DevExpress.XtraEditors.DateEdit DateNV;
        private System.Windows.Forms.Label dIACHILabel;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private System.Windows.Forms.Label tENLabel;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private System.Windows.Forms.Label hOLabel;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraGrid.GridControl gcNV;
        private DevExpress.XtraGrid.Views.Grid.GridView grNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
    }
}