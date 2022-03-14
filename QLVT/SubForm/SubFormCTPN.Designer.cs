namespace QLVT.SubForm
{
    partial class SubFormCTPN
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
            this.mAPNLabel = new System.Windows.Forms.Label();
            this.mAVTLabel = new System.Windows.Forms.Label();
            this.sOLUONGLabel = new System.Windows.Forms.Label();
            this.dONGIALabel = new System.Windows.Forms.Label();
            this.dS = new QLVT.QLVT_DATHANGDataSet();
            this.bdsDH = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter();
            this.cTPNTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTPNTableAdapter();
            this.phieuNhapTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter();
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.fKPhieuNhapDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.fKCTDDHDatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTDDHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGhi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numDG = new System.Windows.Forms.NumericUpDown();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.fKCTPNPhieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhieuNhapDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTDDHDatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPNPhieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            this.mAPNLabel.AutoSize = true;
            this.mAPNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAPNLabel.Location = new System.Drawing.Point(40, 43);
            this.mAPNLabel.Name = "mAPNLabel";
            this.mAPNLabel.Size = new System.Drawing.Size(54, 15);
            this.mAPNLabel.TabIndex = 0;
            this.mAPNLabel.Text = "Mã PN:";
            // 
            // mAVTLabel
            // 
            this.mAVTLabel.AutoSize = true;
            this.mAVTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAVTLabel.Location = new System.Drawing.Point(39, 77);
            this.mAVTLabel.Name = "mAVTLabel";
            this.mAVTLabel.Size = new System.Drawing.Size(51, 15);
            this.mAVTLabel.TabIndex = 2;
            this.mAVTLabel.Text = "Mã VT:";
            // 
            // sOLUONGLabel
            // 
            this.sOLUONGLabel.AutoSize = true;
            this.sOLUONGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sOLUONGLabel.Location = new System.Drawing.Point(37, 109);
            this.sOLUONGLabel.Name = "sOLUONGLabel";
            this.sOLUONGLabel.Size = new System.Drawing.Size(68, 15);
            this.sOLUONGLabel.TabIndex = 4;
            this.sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            this.dONGIALabel.AutoSize = true;
            this.dONGIALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dONGIALabel.Location = new System.Drawing.Point(37, 141);
            this.dONGIALabel.Name = "dONGIALabel";
            this.dONGIALabel.Size = new System.Drawing.Size(61, 15);
            this.dONGIALabel.TabIndex = 6;
            this.dONGIALabel.Text = "Đơn giá:";
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
            this.tableAdapterManager.CTPNTableAdapter = this.cTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // bdsPN
            // 
            this.bdsPN.DataSource = this.fKPhieuNhapDatHangBindingSource;
            // 
            // fKPhieuNhapDatHangBindingSource
            // 
            this.fKPhieuNhapDatHangBindingSource.DataMember = "FK_PhieuNhap_DatHang";
            this.fKPhieuNhapDatHangBindingSource.DataSource = this.bdsDH;
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
            // cTDDHGridControl
            // 
            this.cTDDHGridControl.DataSource = this.bdsCTDDH;
            this.cTDDHGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.cTDDHGridControl.Location = new System.Drawing.Point(364, 0);
            this.cTDDHGridControl.MainView = this.gvCTDDH;
            this.cTDDHGridControl.Name = "cTDDHGridControl";
            this.cTDDHGridControl.Size = new System.Drawing.Size(405, 238);
            this.cTDDHGridControl.TabIndex = 0;
            this.cTDDHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTDDH});
            // 
            // gvCTDDH
            // 
            this.gvCTDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTDDH.GridControl = this.cTDDHGridControl;
            this.gvCTDDH.Name = "gvCTDDH";
            this.gvCTDDH.OptionsBehavior.Editable = false;
            this.gvCTDDH.OptionsView.ShowGroupPanel = false;
            this.gvCTDDH.OptionsView.ShowViewCaption = true;
            this.gvCTDDH.ViewCaption = "Chi Tiết Đơn Đặt Hàng";
            this.gvCTDDH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GvCTDDH_RowClick);
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.AppearanceCell.Options.UseTextOptions = true;
            this.colMasoDDH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMasoDDH.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMasoDDH.AppearanceHeader.Options.UseTextOptions = true;
            this.colMasoDDH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMasoDDH.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMasoDDH.Caption = "Mã đơn DH";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 95;
            // 
            // colMAVT
            // 
            this.colMAVT.AppearanceCell.Options.UseTextOptions = true;
            this.colMAVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAVT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMAVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAVT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 95;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.AppearanceCell.Options.UseTextOptions = true;
            this.colSOLUONG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOLUONG.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSOLUONG.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOLUONG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOLUONG.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 84;
            // 
            // colDONGIA
            // 
            this.colDONGIA.AppearanceHeader.Options.UseTextOptions = true;
            this.colDONGIA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.DisplayFormat.FormatString = "VND {0:n2}";
            this.colDONGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 106;
            // 
            // btnGhi
            // 
            this.btnGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Location = new System.Drawing.Point(234, 200);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(67, 23);
            this.btnGhi.TabIndex = 13;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.BtnGhi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dONGIALabel);
            this.groupBox1.Controls.Add(this.numDG);
            this.groupBox1.Controls.Add(this.sOLUONGLabel);
            this.groupBox1.Controls.Add(this.numSL);
            this.groupBox1.Controls.Add(this.mAVTLabel);
            this.groupBox1.Controls.Add(this.txtMaVT);
            this.groupBox1.Controls.Add(this.mAPNLabel);
            this.groupBox1.Controls.Add(this.txtMaPN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 175);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numDG
            // 
            this.numDG.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsCTPN, "DONGIA", true));
            this.numDG.DecimalPlaces = 2;
            this.numDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDG.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDG.Location = new System.Drawing.Point(104, 138);
            this.numDG.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numDG.Name = "numDG";
            this.numDG.Size = new System.Drawing.Size(174, 20);
            this.numDG.TabIndex = 7;
            this.numDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDG.ThousandsSeparator = true;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataSource = this.fKCTPNPhieuNhapBindingSource;
            // 
            // fKCTPNPhieuNhapBindingSource
            // 
            this.fKCTPNPhieuNhapBindingSource.DataMember = "FK_CTPN_PhieuNhap";
            this.fKCTPNPhieuNhapBindingSource.DataSource = this.fKPhieuNhapDatHangBindingSource;
            // 
            // numSL
            // 
            this.numSL.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsCTPN, "SOLUONG", true));
            this.numSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSL.Location = new System.Drawing.Point(104, 106);
            this.numSL.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(174, 20);
            this.numSL.TabIndex = 5;
            this.numSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSL.ThousandsSeparator = true;
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPN, "MAVT", true));
            this.txtMaVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVT.Location = new System.Drawing.Point(104, 72);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.ReadOnly = true;
            this.txtMaVT.Size = new System.Drawing.Size(174, 20);
            this.txtMaVT.TabIndex = 3;
            // 
            // txtMaPN
            // 
            this.txtMaPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPN, "MAPN", true));
            this.txtMaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Location = new System.Drawing.Point(104, 40);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.ReadOnly = true;
            this.txtMaPN.Size = new System.Drawing.Size(174, 20);
            this.txtMaPN.TabIndex = 1;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // SubFormCTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 238);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cTDDHGridControl);
            this.Name = "SubFormCTPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Chi Tiết Phiếu Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormCTPN_FormClosing);
            this.Load += new System.EventHandler(this.SubFormCTPN_Load);
            this.Shown += new System.EventHandler(this.SubFormCTPN_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhieuNhapDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTDDHDatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCTPNPhieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLVT_DATHANGDataSet dS;
        private System.Windows.Forms.BindingSource bdsDH;
        private QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private QLVT_DATHANGDataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdsPN;
        private QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DevExpress.XtraGrid.GridControl cTDDHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTDDH;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private QLVT_DATHANGDataSetTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private System.Windows.Forms.NumericUpDown numDG;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.BindingSource fKCTDDHDatHangBindingSource;
        private System.Windows.Forms.BindingSource fKPhieuNhapDatHangBindingSource;
        private System.Windows.Forms.BindingSource fKCTPNPhieuNhapBindingSource;
        private System.Windows.Forms.Label mAPNLabel;
        private System.Windows.Forms.Label mAVTLabel;
        private System.Windows.Forms.Label sOLUONGLabel;
        private System.Windows.Forms.Label dONGIALabel;
    }
}