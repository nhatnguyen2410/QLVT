namespace QLVT.SubForm
{
    partial class SubFormCTDDH
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
            this.dONGIALabel = new System.Windows.Forms.Label();
            this.sOLUONGLabel = new System.Windows.Forms.Label();
            this.mAVTLabel = new System.Windows.Forms.Label();
            this.masoDDHLabel = new System.Windows.Forms.Label();
            this.dS = new QLVT.QLVT_DATHANGDataSet();
            this.bdsVT = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.vattuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvVT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDH = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter();
            this.cTDDHTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numDG = new System.Windows.Forms.NumericUpDown();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.txtMaDDH = new System.Windows.Forms.TextBox();
            this.btnGhi = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dONGIALabel
            // 
            this.dONGIALabel.AutoSize = true;
            this.dONGIALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dONGIALabel.Location = new System.Drawing.Point(23, 173);
            this.dONGIALabel.Name = "dONGIALabel";
            this.dONGIALabel.Size = new System.Drawing.Size(79, 20);
            this.dONGIALabel.TabIndex = 15;
            this.dONGIALabel.Text = "Đơn giá:";
            // 
            // sOLUONGLabel
            // 
            this.sOLUONGLabel.AutoSize = true;
            this.sOLUONGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sOLUONGLabel.Location = new System.Drawing.Point(23, 129);
            this.sOLUONGLabel.Name = "sOLUONGLabel";
            this.sOLUONGLabel.Size = new System.Drawing.Size(88, 20);
            this.sOLUONGLabel.TabIndex = 13;
            this.sOLUONGLabel.Text = "Số lượng:";
            // 
            // mAVTLabel
            // 
            this.mAVTLabel.AutoSize = true;
            this.mAVTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAVTLabel.Location = new System.Drawing.Point(23, 88);
            this.mAVTLabel.Name = "mAVTLabel";
            this.mAVTLabel.Size = new System.Drawing.Size(69, 20);
            this.mAVTLabel.TabIndex = 11;
            this.mAVTLabel.Text = "Mã VT:";
            // 
            // masoDDHLabel
            // 
            this.masoDDHLabel.AutoSize = true;
            this.masoDDHLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masoDDHLabel.Location = new System.Drawing.Point(23, 43);
            this.masoDDHLabel.Name = "masoDDHLabel";
            this.masoDDHLabel.Size = new System.Drawing.Size(88, 20);
            this.masoDDHLabel.TabIndex = 9;
            this.masoDDHLabel.Text = "Mã DDH:";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsVT
            // 
            this.bdsVT.DataMember = "Vattu";
            this.bdsVT.DataSource = this.dS;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // vattuGridControl
            // 
            this.vattuGridControl.DataSource = this.bdsVT;
            this.vattuGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.vattuGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vattuGridControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vattuGridControl.Location = new System.Drawing.Point(437, 0);
            this.vattuGridControl.MainView = this.gvVT;
            this.vattuGridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vattuGridControl.Name = "vattuGridControl";
            this.vattuGridControl.Size = new System.Drawing.Size(476, 302);
            this.vattuGridControl.TabIndex = 1;
            this.vattuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVT});
            // 
            // gvVT
            // 
            this.gvVT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gvVT.DetailHeight = 431;
            this.gvVT.GridControl = this.vattuGridControl;
            this.gvVT.Name = "gvVT";
            this.gvVT.OptionsBehavior.Editable = false;
            this.gvVT.OptionsView.ShowGroupPanel = false;
            this.gvVT.OptionsView.ShowViewCaption = true;
            this.gvVT.ViewCaption = "Vật Tư";
            this.gvVT.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GvVT_RowClick);
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 23;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 94;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên vật tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 23;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 182;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn vị tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 23;
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 84;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.Caption = "Số lượng tồn";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.MinWidth = 23;
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            this.colSOLUONGTON.Width = 86;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_DatHang";
            this.bdsCTDDH.DataSource = this.bdsDH;
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
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dONGIALabel);
            this.groupBox1.Controls.Add(this.numDG);
            this.groupBox1.Controls.Add(this.sOLUONGLabel);
            this.groupBox1.Controls.Add(this.numSL);
            this.groupBox1.Controls.Add(this.mAVTLabel);
            this.groupBox1.Controls.Add(this.txtMaVT);
            this.groupBox1.Controls.Add(this.masoDDHLabel);
            this.groupBox1.Controls.Add(this.txtMaDDH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(378, 224);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // numDG
            // 
            this.numDG.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsCTDDH, "DONGIA", true));
            this.numDG.DecimalPlaces = 2;
            this.numDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDG.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDG.Location = new System.Drawing.Point(126, 172);
            this.numDG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numDG.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numDG.Name = "numDG";
            this.numDG.Size = new System.Drawing.Size(211, 24);
            this.numDG.TabIndex = 16;
            this.numDG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDG.ThousandsSeparator = true;
            this.numDG.Validating += new System.ComponentModel.CancelEventHandler(this.NumDG_Validating);
            // 
            // numSL
            // 
            this.numSL.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsCTDDH, "SOLUONG", true));
            this.numSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSL.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numSL.Location = new System.Drawing.Point(126, 128);
            this.numSL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSL.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(211, 24);
            this.numSL.TabIndex = 14;
            this.numSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSL.Validating += new System.ComponentModel.CancelEventHandler(this.NumSL_Validating);
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTDDH, "MAVT", true));
            this.txtMaVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVT.Location = new System.Drawing.Point(126, 84);
            this.txtMaVT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.ReadOnly = true;
            this.txtMaVT.Size = new System.Drawing.Size(210, 24);
            this.txtMaVT.TabIndex = 12;
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTDDH, "MasoDDH", true));
            this.txtMaDDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDDH.Location = new System.Drawing.Point(126, 39);
            this.txtMaDDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.ReadOnly = true;
            this.txtMaDDH.Size = new System.Drawing.Size(210, 24);
            this.txtMaDDH.TabIndex = 10;
            // 
            // btnGhi
            // 
            this.btnGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Location = new System.Drawing.Point(290, 246);
            this.btnGhi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(78, 28);
            this.btnGhi.TabIndex = 10;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.BtnGhi_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // SubFormCTDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 302);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.vattuGridControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SubFormCTDDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Đơn Đặt Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubFormCTDDH_FormClosing);
            this.Load += new System.EventHandler(this.SubFormCTDDH_Load);
            this.Shown += new System.EventHandler(this.SubFormCTDDH_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLVT_DATHANGDataSet dS;
        private System.Windows.Forms.BindingSource bdsVT;
        private QLVT_DATHANGDataSetTableAdapters.VattuTableAdapter vattuTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vattuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVT;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private System.Windows.Forms.BindingSource bdsDH;
        private QLVT_DATHANGDataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private QLVT_DATHANGDataSetTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numDG;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.TextBox txtMaDDH;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label dONGIALabel;
        private System.Windows.Forms.Label sOLUONGLabel;
        private System.Windows.Forms.Label mAVTLabel;
        private System.Windows.Forms.Label masoDDHLabel;
    }
}