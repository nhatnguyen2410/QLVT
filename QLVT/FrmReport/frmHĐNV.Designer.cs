
namespace QLVT.Report
{
    partial class frmHĐNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHĐNV));
            this.TimeKTNV = new DevExpress.XtraEditors.DateEdit();
            this.TimeBDNV = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbChucNang2 = new System.Windows.Forms.Label();
            this.qLVT_DATHANGDataSet = new QLVT.QLVT_DATHANGDataSet();
            this.v_DSNV_TKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSNV_TKTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.V_DSNV_TKTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.cbbMANV = new System.Windows.Forms.ComboBox();
            this.CBBHoten = new System.Windows.Forms.ComboBox();
            this.radioPN = new System.Windows.Forms.RadioButton();
            this.radioPX = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TimeKTNV.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeKTNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBDNV.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBDNV.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSNV_TKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeKTNV
            // 
            this.TimeKTNV.EditValue = null;
            this.TimeKTNV.Location = new System.Drawing.Point(412, 213);
            this.TimeKTNV.Name = "TimeKTNV";
            this.TimeKTNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeKTNV.Properties.Appearance.Options.UseFont = true;
            this.TimeKTNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeKTNV.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeKTNV.Size = new System.Drawing.Size(112, 26);
            this.TimeKTNV.TabIndex = 10;
            // 
            // TimeBDNV
            // 
            this.TimeBDNV.EditValue = null;
            this.TimeBDNV.Location = new System.Drawing.Point(131, 213);
            this.TimeBDNV.Name = "TimeBDNV";
            this.TimeBDNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBDNV.Properties.Appearance.Options.UseFont = true;
            this.TimeBDNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeBDNV.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeBDNV.Size = new System.Drawing.Size(110, 26);
            this.TimeBDNV.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Từ ngày :";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(358, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(150, 333);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(147, 32);
            this.btnPreview.TabIndex = 11;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Đến ngày :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã NV :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Họ tên :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.lbChucNang2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 100);
            this.panel1.TabIndex = 18;
            // 
            // lbChucNang2
            // 
            this.lbChucNang2.AutoSize = true;
            this.lbChucNang2.BackColor = System.Drawing.Color.Transparent;
            this.lbChucNang2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucNang2.ForeColor = System.Drawing.Color.Blue;
            this.lbChucNang2.Location = new System.Drawing.Point(164, 31);
            this.lbChucNang2.Name = "lbChucNang2";
            this.lbChucNang2.Size = new System.Drawing.Size(302, 36);
            this.lbChucNang2.TabIndex = 0;
            this.lbChucNang2.Text = "Hoạt động nhân viên";
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DSNV_TKBindingSource
            // 
            this.v_DSNV_TKBindingSource.DataMember = "V_DSNV_TK";
            this.v_DSNV_TKBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // v_DSNV_TKTableAdapter
            // 
            this.v_DSNV_TKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cbbMANV
            // 
            this.cbbMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DSNV_TKBindingSource, "MANV", true));
            this.cbbMANV.DataSource = this.v_DSNV_TKBindingSource;
            this.cbbMANV.DisplayMember = "MANV";
            this.cbbMANV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMANV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMANV.FormattingEnabled = true;
            this.cbbMANV.Location = new System.Drawing.Point(131, 135);
            this.cbbMANV.Name = "cbbMANV";
            this.cbbMANV.Size = new System.Drawing.Size(110, 24);
            this.cbbMANV.TabIndex = 20;
            this.cbbMANV.ValueMember = "MANV";
            // 
            // CBBHoten
            // 
            this.CBBHoten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DSNV_TKBindingSource, "HOTEN", true));
            this.CBBHoten.DataSource = this.v_DSNV_TKBindingSource;
            this.CBBHoten.DisplayMember = "HOTEN";
            this.CBBHoten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBHoten.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBBHoten.FormattingEnabled = true;
            this.CBBHoten.Location = new System.Drawing.Point(412, 138);
            this.CBBHoten.Name = "CBBHoten";
            this.CBBHoten.Size = new System.Drawing.Size(112, 24);
            this.CBBHoten.TabIndex = 21;
            this.CBBHoten.ValueMember = "HOTEN";
            // 
            // radioPN
            // 
            this.radioPN.AutoSize = true;
            this.radioPN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPN.Location = new System.Drawing.Point(213, 276);
            this.radioPN.Name = "radioPN";
            this.radioPN.Size = new System.Drawing.Size(97, 20);
            this.radioPN.TabIndex = 22;
            this.radioPN.TabStop = true;
            this.radioPN.Text = "Phiếu Nhập";
            this.radioPN.UseVisualStyleBackColor = true;
            // 
            // radioPX
            // 
            this.radioPX.AutoSize = true;
            this.radioPX.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPX.Location = new System.Drawing.Point(342, 276);
            this.radioPX.Name = "radioPX";
            this.radioPX.Size = new System.Drawing.Size(96, 20);
            this.radioPX.TabIndex = 23;
            this.radioPX.TabStop = true;
            this.radioPX.Text = "Phiếu Xuất";
            this.radioPX.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Loại:";
            // 
            // frmHĐNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 395);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioPX);
            this.Controls.Add(this.radioPN);
            this.Controls.Add(this.CBBHoten);
            this.Controls.Add(this.cbbMANV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.TimeKTNV);
            this.Controls.Add(this.TimeBDNV);
            this.Controls.Add(this.label2);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmHĐNV.IconOptions.SvgImage")));
            this.Name = "frmHĐNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoạt động nhân viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHĐNV_FormClosed);
            this.Load += new System.EventHandler(this.frmHĐNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimeKTNV.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeKTNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBDNV.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBDNV.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSNV_TKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit TimeKTNV;
        private DevExpress.XtraEditors.DateEdit TimeBDNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbChucNang2;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource v_DSNV_TKBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.V_DSNV_TKTableAdapter v_DSNV_TKTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbbMANV;
        private System.Windows.Forms.ComboBox CBBHoten;
        private System.Windows.Forms.RadioButton radioPN;
        private System.Windows.Forms.RadioButton radioPX;
        private System.Windows.Forms.Label label5;
    }
}