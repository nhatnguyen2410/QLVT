
namespace QLVT
{
    partial class FormDK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDK));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pnDky = new System.Windows.Forms.Panel();
            this.v_DSNV_CHUATKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVT_DATHANGDataSet = new QLVT.QLVT_DATHANGDataSet();
            this.cmbHoTen = new System.Windows.Forms.ComboBox();
            this.radioButton_CONGTY = new System.Windows.Forms.RadioButton();
            this.radioButton_USER = new System.Windows.Forms.RadioButton();
            this.radioButton_CN = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbCN = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnDky = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtMKDK = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtTKDK = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnHinhAnh = new System.Windows.Forms.Panel();
            this.v_DSNV_CHUATKTableAdapter = new QLVT.QLVT_DATHANGDataSetTableAdapters.V_DSNV_CHUATKTableAdapter();
            this.tableAdapterManager = new QLVT.QLVT_DATHANGDataSetTableAdapters.TableAdapterManager();
            this.cmbMANV = new System.Windows.Forms.ComboBox();
            this.pnDky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSNV_CHUATKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDky
            // 
            this.pnDky.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnDky.Controls.Add(this.cmbMANV);
            this.pnDky.Controls.Add(this.cmbHoTen);
            this.pnDky.Controls.Add(this.radioButton_CONGTY);
            this.pnDky.Controls.Add(this.radioButton_USER);
            this.pnDky.Controls.Add(this.radioButton_CN);
            this.pnDky.Controls.Add(this.pictureBox2);
            this.pnDky.Controls.Add(this.cmbCN);
            this.pnDky.Controls.Add(this.btnDky);
            this.pnDky.Controls.Add(this.txtMKDK);
            this.pnDky.Controls.Add(this.txtTKDK);
            this.pnDky.Controls.Add(this.bunifuLabel1);
            this.pnDky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDky.Location = new System.Drawing.Point(401, 0);
            this.pnDky.Name = "pnDky";
            this.pnDky.Size = new System.Drawing.Size(451, 465);
            this.pnDky.TabIndex = 1;
            this.pnDky.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDky_Paint);
            // 
            // v_DSNV_CHUATKBindingSource
            // 
            this.v_DSNV_CHUATKBindingSource.DataMember = "V_DSNV_CHUATK";
            this.v_DSNV_CHUATKBindingSource.DataSource = this.qLVT_DATHANGDataSet;
            // 
            // qLVT_DATHANGDataSet
            // 
            this.qLVT_DATHANGDataSet.DataSetName = "QLVT_DATHANGDataSet";
            this.qLVT_DATHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbHoTen
            // 
            this.cmbHoTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DSNV_CHUATKBindingSource, "HOTEN", true));
            this.cmbHoTen.DataSource = this.v_DSNV_CHUATKBindingSource;
            this.cmbHoTen.DisplayMember = "HOTEN";
            this.cmbHoTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoTen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHoTen.FormattingEnabled = true;
            this.cmbHoTen.Location = new System.Drawing.Point(262, 157);
            this.cmbHoTen.Name = "cmbHoTen";
            this.cmbHoTen.Size = new System.Drawing.Size(106, 24);
            this.cmbHoTen.TabIndex = 21;
            this.cmbHoTen.ValueMember = "HOTEN";
            // 
            // radioButton_CONGTY
            // 
            this.radioButton_CONGTY.AutoSize = true;
            this.radioButton_CONGTY.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_CONGTY.Location = new System.Drawing.Point(208, 310);
            this.radioButton_CONGTY.Name = "radioButton_CONGTY";
            this.radioButton_CONGTY.Size = new System.Drawing.Size(80, 22);
            this.radioButton_CONGTY.TabIndex = 20;
            this.radioButton_CONGTY.TabStop = true;
            this.radioButton_CONGTY.Text = "công ty";
            this.radioButton_CONGTY.UseVisualStyleBackColor = true;
            this.radioButton_CONGTY.Visible = false;
            // 
            // radioButton_USER
            // 
            this.radioButton_USER.AutoSize = true;
            this.radioButton_USER.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_USER.Location = new System.Drawing.Point(266, 321);
            this.radioButton_USER.Name = "radioButton_USER";
            this.radioButton_USER.Size = new System.Drawing.Size(55, 20);
            this.radioButton_USER.TabIndex = 19;
            this.radioButton_USER.TabStop = true;
            this.radioButton_USER.Text = "user";
            this.radioButton_USER.UseVisualStyleBackColor = true;
            // 
            // radioButton_CN
            // 
            this.radioButton_CN.AutoSize = true;
            this.radioButton_CN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_CN.Location = new System.Drawing.Point(152, 321);
            this.radioButton_CN.Name = "radioButton_CN";
            this.radioButton_CN.Size = new System.Drawing.Size(88, 20);
            this.radioButton_CN.TabIndex = 18;
            this.radioButton_CN.TabStop = true;
            this.radioButton_CN.Text = "chi nhánh";
            this.radioButton_CN.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(393, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cmbCN
            // 
            this.cmbCN.BackColor = System.Drawing.Color.Transparent;
            this.cmbCN.BackgroundColor = System.Drawing.Color.LightGray;
            this.cmbCN.BorderColor = System.Drawing.Color.Silver;
            this.cmbCN.BorderRadius = 1;
            this.cmbCN.Color = System.Drawing.Color.Silver;
            this.cmbCN.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmbCN.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbCN.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbCN.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbCN.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmbCN.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbCN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCN.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmbCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCN.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbCN.FillDropDown = true;
            this.cmbCN.FillIndicator = false;
            this.cmbCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCN.ForeColor = System.Drawing.Color.Black;
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Icon = null;
            this.cmbCN.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbCN.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cmbCN.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmbCN.IndicatorThickness = 2;
            this.cmbCN.IsDropdownOpened = false;
            this.cmbCN.ItemBackColor = System.Drawing.Color.White;
            this.cmbCN.ItemBorderColor = System.Drawing.Color.White;
            this.cmbCN.ItemForeColor = System.Drawing.Color.Black;
            this.cmbCN.ItemHeight = 26;
            this.cmbCN.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmbCN.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmbCN.ItemTopMargin = 3;
            this.cmbCN.Location = new System.Drawing.Point(111, 110);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(257, 32);
            this.cmbCN.TabIndex = 16;
            this.cmbCN.Text = null;
            this.cmbCN.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmbCN.TextLeftMargin = 5;
            this.cmbCN.SelectedIndexChanged += new System.EventHandler(this.cmbCN_SelectedIndexChanged);
            // 
            // btnDky
            // 
            this.btnDky.AllowAnimations = true;
            this.btnDky.AllowMouseEffects = true;
            this.btnDky.AllowToggling = false;
            this.btnDky.AnimationSpeed = 200;
            this.btnDky.AutoGenerateColors = false;
            this.btnDky.AutoRoundBorders = false;
            this.btnDky.AutoSizeLeftIcon = true;
            this.btnDky.AutoSizeRightIcon = true;
            this.btnDky.BackColor = System.Drawing.Color.Transparent;
            this.btnDky.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnDky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDky.BackgroundImage")));
            this.btnDky.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDky.ButtonText = "Submit";
            this.btnDky.ButtonTextMarginLeft = 0;
            this.btnDky.ColorContrastOnClick = 45;
            this.btnDky.ColorContrastOnHover = 45;
            this.btnDky.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDky.CustomizableEdges = borderEdges1;
            this.btnDky.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDky.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDky.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnDky.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnDky.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDky.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDky.ForeColor = System.Drawing.Color.White;
            this.btnDky.IconLeft = null;
            this.btnDky.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDky.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDky.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDky.IconMarginLeft = 11;
            this.btnDky.IconPadding = 10;
            this.btnDky.IconRight = null;
            this.btnDky.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDky.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDky.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDky.IconSize = 25;
            this.btnDky.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnDky.IdleBorderRadius = 0;
            this.btnDky.IdleBorderThickness = 0;
            this.btnDky.IdleFillColor = System.Drawing.Color.Empty;
            this.btnDky.IdleIconLeftImage = null;
            this.btnDky.IdleIconRightImage = null;
            this.btnDky.IndicateFocus = false;
            this.btnDky.Location = new System.Drawing.Point(192, 378);
            this.btnDky.Name = "btnDky";
            this.btnDky.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDky.OnDisabledState.BorderRadius = 40;
            this.btnDky.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDky.OnDisabledState.BorderThickness = 1;
            this.btnDky.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDky.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDky.OnDisabledState.IconLeftImage = null;
            this.btnDky.OnDisabledState.IconRightImage = null;
            this.btnDky.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnDky.onHoverState.BorderRadius = 40;
            this.btnDky.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDky.onHoverState.BorderThickness = 1;
            this.btnDky.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnDky.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnDky.onHoverState.IconLeftImage = null;
            this.btnDky.onHoverState.IconRightImage = null;
            this.btnDky.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(193)))), ((int)(((byte)(60)))));
            this.btnDky.OnIdleState.BorderRadius = 40;
            this.btnDky.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDky.OnIdleState.BorderThickness = 1;
            this.btnDky.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(193)))), ((int)(((byte)(60)))));
            this.btnDky.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnDky.OnIdleState.IconLeftImage = null;
            this.btnDky.OnIdleState.IconRightImage = null;
            this.btnDky.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDky.OnPressedState.BorderRadius = 40;
            this.btnDky.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDky.OnPressedState.BorderThickness = 1;
            this.btnDky.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnDky.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDky.OnPressedState.IconLeftImage = null;
            this.btnDky.OnPressedState.IconRightImage = null;
            this.btnDky.Size = new System.Drawing.Size(125, 42);
            this.btnDky.TabIndex = 15;
            this.btnDky.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDky.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDky.TextMarginLeft = 0;
            this.btnDky.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDky.UseDefaultRadiusAndThickness = true;
            this.btnDky.Click += new System.EventHandler(this.btnDky_Click);
            // 
            // txtMKDK
            // 
            this.txtMKDK.AcceptsReturn = false;
            this.txtMKDK.AcceptsTab = false;
            this.txtMKDK.AnimationSpeed = 200;
            this.txtMKDK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMKDK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMKDK.AutoSizeHeight = true;
            this.txtMKDK.BackColor = System.Drawing.Color.Transparent;
            this.txtMKDK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtMKDK.BackgroundImage")));
            this.txtMKDK.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtMKDK.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMKDK.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtMKDK.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtMKDK.BorderRadius = 15;
            this.txtMKDK.BorderThickness = 1;
            this.txtMKDK.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMKDK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKDK.DefaultFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKDK.DefaultText = "";
            this.txtMKDK.FillColor = System.Drawing.Color.White;
            this.txtMKDK.HideSelection = true;
            this.txtMKDK.IconLeft = null;
            this.txtMKDK.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKDK.IconPadding = 10;
            this.txtMKDK.IconRight = null;
            this.txtMKDK.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMKDK.Lines = new string[0];
            this.txtMKDK.Location = new System.Drawing.Point(108, 249);
            this.txtMKDK.MaxLength = 32767;
            this.txtMKDK.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtMKDK.Modified = false;
            this.txtMKDK.Multiline = false;
            this.txtMKDK.Name = "txtMKDK";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMKDK.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMKDK.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMKDK.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtMKDK.OnIdleState = stateProperties4;
            this.txtMKDK.Padding = new System.Windows.Forms.Padding(3);
            this.txtMKDK.PasswordChar = '.';
            this.txtMKDK.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMKDK.PlaceholderText = "Nhập mật khẩu";
            this.txtMKDK.ReadOnly = false;
            this.txtMKDK.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMKDK.SelectedText = "";
            this.txtMKDK.SelectionLength = 0;
            this.txtMKDK.SelectionStart = 0;
            this.txtMKDK.ShortcutsEnabled = true;
            this.txtMKDK.Size = new System.Drawing.Size(260, 38);
            this.txtMKDK.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtMKDK.TabIndex = 14;
            this.txtMKDK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMKDK.TextMarginBottom = 0;
            this.txtMKDK.TextMarginLeft = 3;
            this.txtMKDK.TextMarginTop = 1;
            this.txtMKDK.TextPlaceholder = "Nhập mật khẩu";
            this.txtMKDK.UseSystemPasswordChar = false;
            this.txtMKDK.WordWrap = true;
            // 
            // txtTKDK
            // 
            this.txtTKDK.AcceptsReturn = false;
            this.txtTKDK.AcceptsTab = false;
            this.txtTKDK.AnimationSpeed = 200;
            this.txtTKDK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTKDK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTKDK.AutoSizeHeight = true;
            this.txtTKDK.BackColor = System.Drawing.Color.Transparent;
            this.txtTKDK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTKDK.BackgroundImage")));
            this.txtTKDK.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTKDK.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTKDK.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTKDK.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTKDK.BorderRadius = 15;
            this.txtTKDK.BorderThickness = 1;
            this.txtTKDK.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTKDK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTKDK.DefaultFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKDK.DefaultText = "";
            this.txtTKDK.FillColor = System.Drawing.Color.White;
            this.txtTKDK.HideSelection = true;
            this.txtTKDK.IconLeft = null;
            this.txtTKDK.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTKDK.IconPadding = 10;
            this.txtTKDK.IconRight = null;
            this.txtTKDK.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTKDK.Lines = new string[0];
            this.txtTKDK.Location = new System.Drawing.Point(108, 194);
            this.txtTKDK.MaxLength = 32767;
            this.txtTKDK.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTKDK.Modified = false;
            this.txtTKDK.Multiline = false;
            this.txtTKDK.Name = "txtTKDK";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTKDK.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTKDK.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTKDK.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTKDK.OnIdleState = stateProperties8;
            this.txtTKDK.Padding = new System.Windows.Forms.Padding(3);
            this.txtTKDK.PasswordChar = '\0';
            this.txtTKDK.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTKDK.PlaceholderText = "Nhập tài khoản";
            this.txtTKDK.ReadOnly = false;
            this.txtTKDK.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTKDK.SelectedText = "";
            this.txtTKDK.SelectionLength = 0;
            this.txtTKDK.SelectionStart = 0;
            this.txtTKDK.ShortcutsEnabled = true;
            this.txtTKDK.Size = new System.Drawing.Size(260, 38);
            this.txtTKDK.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTKDK.TabIndex = 13;
            this.txtTKDK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTKDK.TextMarginBottom = 0;
            this.txtTKDK.TextMarginLeft = 3;
            this.txtTKDK.TextMarginTop = 1;
            this.txtTKDK.TextPlaceholder = "Nhập tài khoản";
            this.txtTKDK.UseSystemPasswordChar = false;
            this.txtTKDK.WordWrap = true;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(132, 55);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(218, 37);
            this.bunifuLabel1.TabIndex = 11;
            this.bunifuLabel1.Text = "Registration Info";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnHinhAnh
            // 
            this.pnHinhAnh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnHinhAnh.BackgroundImage")));
            this.pnHinhAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnHinhAnh.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnHinhAnh.Location = new System.Drawing.Point(0, 0);
            this.pnHinhAnh.Name = "pnHinhAnh";
            this.pnHinhAnh.Size = new System.Drawing.Size(401, 465);
            this.pnHinhAnh.TabIndex = 0;
            // 
            // v_DSNV_CHUATKTableAdapter
            // 
            this.v_DSNV_CHUATKTableAdapter.ClearBeforeFill = true;
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
            // cmbMANV
            // 
            this.cmbMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DSNV_CHUATKBindingSource, "MANV", true));
            this.cmbMANV.DataSource = this.v_DSNV_CHUATKBindingSource;
            this.cmbMANV.DisplayMember = "MANV";
            this.cmbMANV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMANV.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMANV.FormattingEnabled = true;
            this.cmbMANV.Location = new System.Drawing.Point(111, 157);
            this.cmbMANV.Name = "cmbMANV";
            this.cmbMANV.Size = new System.Drawing.Size(72, 24);
            this.cmbMANV.TabIndex = 22;
            this.cmbMANV.ValueMember = "MANV";
            // 
            // FormDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 465);
            this.Controls.Add(this.pnDky);
            this.Controls.Add(this.pnHinhAnh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDK";
            this.Load += new System.EventHandler(this.FormDK_Load);
            this.pnDky.ResumeLayout(false);
            this.pnDky.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSNV_CHUATKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHinhAnh;
        private System.Windows.Forms.Panel pnDky;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDky;
        private Bunifu.UI.WinForms.BunifuTextBox txtMKDK;
        private Bunifu.UI.WinForms.BunifuTextBox txtTKDK;
        public Bunifu.UI.WinForms.BunifuDropdown cmbCN;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton radioButton_CONGTY;
        private System.Windows.Forms.RadioButton radioButton_USER;
        private System.Windows.Forms.RadioButton radioButton_CN;
        private QLVT_DATHANGDataSet qLVT_DATHANGDataSet;
        private System.Windows.Forms.BindingSource v_DSNV_CHUATKBindingSource;
        private QLVT_DATHANGDataSetTableAdapters.V_DSNV_CHUATKTableAdapter v_DSNV_CHUATKTableAdapter;
        private QLVT_DATHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbHoTen;
        private System.Windows.Forms.ComboBox cmbMANV;
    }
}