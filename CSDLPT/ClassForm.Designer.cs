namespace CSDLPT {
    partial class ClassForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label mALOPLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassForm));
            this.bdsLop = new System.Windows.Forms.BindingSource(this.components);
            this.dS_SERVER1 = new CSDLPT.DS_SERVER1();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbtnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRemove = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnWrite = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRecovery = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.taLop = new CSDLPT.DS_SERVER1TableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new CSDLPT.DS_SERVER1TableAdapters.TableAdapterManager();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.taKhoa = new CSDLPT.DS_SERVER1TableAdapters.KHOATableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbKhoaInUse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbMaKhoa = new System.Windows.Forms.TextBox();
            this.txbTenLop = new System.Windows.Forms.TextBox();
            this.txbMaLop = new System.Windows.Forms.TextBox();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.cmbChangeClass = new System.Windows.Forms.ComboBox();
            this.bdsAllClass = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txteMaLop = new DevExpress.XtraEditors.TextEdit();
            this.tENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.txteMaSV = new DevExpress.XtraEditors.TextEdit();
            this.taSV = new CSDLPT.DS_SERVER1TableAdapters.SINHVIENTableAdapter();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.dgvtxbMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxbHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxbTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxbMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvchbPhai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvtxbNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxbNoiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxbDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvchbNghiHoc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsWrite = new System.Windows.Forms.ToolStripMenuItem();
            this.tsRecovery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsChangeClass = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsDiem = new System.Windows.Forms.BindingSource(this.components);
            this.taDiem = new CSDLPT.DS_SERVER1TableAdapters.DIEMTableAdapter();
            this.taAllClass = new CSDLPT.DS_SERVER1TableAdapters.AllClassTableAdapter();
            mALOPLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            mALOPLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SERVER1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAllClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(56, 44);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(87, 23);
            mALOPLabel.TabIndex = 0;
            mALOPLabel.Text = "MALOP:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(65, 309);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(78, 23);
            mAKHLabel.TabIndex = 4;
            mAKHLabel.Text = "MAKH:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(48, 169);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(95, 23);
            tENLOPLabel.TabIndex = 5;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mASVLabel.Location = new System.Drawing.Point(25, 18);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(56, 19);
            mASVLabel.TabIndex = 1;
            mASVLabel.Text = "MASV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(246, 18);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(35, 19);
            hOLabel.TabIndex = 3;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(239, 76);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(42, 19);
            tENLabel.TabIndex = 5;
            tENLabel.Text = "TEN:";
            // 
            // mALOPLabel1
            // 
            mALOPLabel1.AutoSize = true;
            mALOPLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel1.Location = new System.Drawing.Point(14, 76);
            mALOPLabel1.Name = "mALOPLabel1";
            mALOPLabel1.Size = new System.Drawing.Size(67, 19);
            mALOPLabel1.TabIndex = 7;
            mALOPLabel1.Text = "MALOP:";
            // 
            // bdsLop
            // 
            this.bdsLop.DataMember = "LOP";
            this.bdsLop.DataSource = this.dS_SERVER1;
            // 
            // dS_SERVER1
            // 
            this.dS_SERVER1.DataSetName = "DS_SERVER1";
            this.dS_SERVER1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barCheckItem1,
            this.bbtnAdd,
            this.bbtnRemove,
            this.bbtnEdit,
            this.bbtnWrite,
            this.bbtnRecovery});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 9;
            this.barManager.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnRemove, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnWrite),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbtnRecovery)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbtnAdd
            // 
            this.bbtnAdd.Caption = "THÊM LỚP";
            this.bbtnAdd.Id = 2;
            this.bbtnAdd.Name = "bbtnAdd";
            this.bbtnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAdd_ItemClick);
            // 
            // bbtnRemove
            // 
            this.bbtnRemove.Caption = "XÓA LỚP";
            this.bbtnRemove.Id = 3;
            this.bbtnRemove.Name = "bbtnRemove";
            this.bbtnRemove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnRemove_ItemClick);
            // 
            // bbtnEdit
            // 
            this.bbtnEdit.Caption = "HIỆU CHỈNH";
            this.bbtnEdit.Id = 4;
            this.bbtnEdit.Name = "bbtnEdit";
            this.bbtnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnEdit_ItemClick);
            // 
            // bbtnWrite
            // 
            this.bbtnWrite.Caption = "GHI";
            this.bbtnWrite.Id = 7;
            this.bbtnWrite.Name = "bbtnWrite";
            this.bbtnWrite.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnWrite_ItemClick);
            // 
            // bbtnRecovery
            // 
            this.bbtnRecovery.Caption = "PHỤC HỒI";
            this.bbtnRecovery.Id = 8;
            this.bbtnRecovery.Name = "bbtnRecovery";
            this.bbtnRecovery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnRecovery_ItemClick);
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
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.barDockControlTop.Size = new System.Drawing.Size(1930, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 754);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.barDockControlBottom.Size = new System.Drawing.Size(1930, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 732);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1930, 22);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 732);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 1;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // taLop
            // 
            this.taLop.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.taLop;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DS_SERVER1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.dS_SERVER1;
            // 
            // taKhoa
            // 
            this.taKhoa.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbKhoaInUse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1930, 67);
            this.panel1.TabIndex = 27;
            // 
            // cmbKhoaInUse
            // 
            this.cmbKhoaInUse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoaInUse.FormattingEnabled = true;
            this.cmbKhoaInUse.Location = new System.Drawing.Point(559, 14);
            this.cmbKhoaInUse.Name = "cmbKhoaInUse";
            this.cmbKhoaInUse.Size = new System.Drawing.Size(539, 31);
            this.cmbKhoaInUse.TabIndex = 29;
            this.cmbKhoaInUse.SelectedIndexChanged += new System.EventHandler(this.cmbKhoaInUse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Khoa:";
            // 
            // gcLop
            // 
            this.gcLop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gcLop.DataSource = this.bdsLop;
            this.gcLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLop.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(0);
            this.gcLop.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcLop.Location = new System.Drawing.Point(0, 89);
            this.gcLop.MainView = this.gridView1;
            this.gcLop.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gcLop.MenuManager = this.barManager;
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(1930, 307);
            this.gcLop.TabIndex = 27;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 35;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colMAKH});
            this.gridView1.DetailHeight = 727;
            this.gridView1.FixedLineWidth = 4;
            this.gridView1.GridControl = this.gcLop;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 35;
            // 
            // colMALOP
            // 
            this.colMALOP.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMALOP.AppearanceCell.Options.UseFont = true;
            this.colMALOP.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMALOP.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMALOP.AppearanceHeader.Options.UseFont = true;
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.OptionsColumn.ReadOnly = true;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 444;
            // 
            // colTENLOP
            // 
            this.colTENLOP.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENLOP.AppearanceCell.Options.UseFont = true;
            this.colTENLOP.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTENLOP.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colTENLOP.AppearanceHeader.Options.UseFont = true;
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.OptionsColumn.ReadOnly = true;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 733;
            // 
            // colMAKH
            // 
            this.colMAKH.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKH.AppearanceCell.Options.UseFont = true;
            this.colMAKH.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMAKH.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMAKH.AppearanceHeader.Options.UseFont = true;
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.OptionsColumn.AllowEdit = false;
            this.colMAKH.OptionsColumn.ReadOnly = true;
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            this.colMAKH.Width = 735;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbMaKhoa);
            this.groupBox1.Controls.Add(tENLOPLabel);
            this.groupBox1.Controls.Add(this.txbTenLop);
            this.groupBox1.Controls.Add(mAKHLabel);
            this.groupBox1.Controls.Add(mALOPLabel);
            this.groupBox1.Controls.Add(this.txbMaLop);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 358);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // txbMaKhoa
            // 
            this.txbMaKhoa.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MAKH", true));
            this.txbMaKhoa.Location = new System.Drawing.Point(349, 306);
            this.txbMaKhoa.Name = "txbMaKhoa";
            this.txbMaKhoa.ReadOnly = true;
            this.txbMaKhoa.Size = new System.Drawing.Size(234, 32);
            this.txbMaKhoa.TabIndex = 8;
            this.txbMaKhoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbTenLop
            // 
            this.txbTenLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "TENLOP", true));
            this.txbTenLop.Location = new System.Drawing.Point(349, 166);
            this.txbTenLop.Name = "txbTenLop";
            this.txbTenLop.Size = new System.Drawing.Size(541, 32);
            this.txbTenLop.TabIndex = 6;
            this.txbTenLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbMaLop
            // 
            this.txbMaLop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txbMaLop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLop, "MALOP", true));
            this.txbMaLop.Location = new System.Drawing.Point(349, 41);
            this.txbMaLop.Name = "txbMaLop";
            this.txbMaLop.ReadOnly = true;
            this.txbMaLop.Size = new System.Drawing.Size(234, 32);
            this.txbMaLop.TabIndex = 1;
            this.txbMaLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flyoutPanel1.Appearance.Options.UseFont = true;
            this.flyoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flyoutPanel1.Controls.Add(this.btnCancel);
            this.flyoutPanel1.Controls.Add(this.btnOk);
            this.flyoutPanel1.Controls.Add(this.cmbChangeClass);
            this.flyoutPanel1.Controls.Add(this.labelControl1);
            this.flyoutPanel1.Controls.Add(mALOPLabel1);
            this.flyoutPanel1.Controls.Add(this.txteMaLop);
            this.flyoutPanel1.Controls.Add(tENLabel);
            this.flyoutPanel1.Controls.Add(this.tENTextEdit);
            this.flyoutPanel1.Controls.Add(hOLabel);
            this.flyoutPanel1.Controls.Add(this.hOTextEdit);
            this.flyoutPanel1.Controls.Add(mASVLabel);
            this.flyoutPanel1.Controls.Add(this.txteMaSV);
            this.flyoutPanel1.Location = new System.Drawing.Point(424, 396);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.TopRight;
            this.flyoutPanel1.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.flyoutPanel1.Options.HorzIndent = 20;
            this.flyoutPanel1.OwnerControl = this.groupBox1;
            this.flyoutPanel1.Size = new System.Drawing.Size(493, 260);
            this.flyoutPanel1.TabIndex = 37;
            this.flyoutPanel1.Load += new System.EventHandler(this.flyoutPanel1_Load);
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSV.DataSource = this.bdsLop;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(287, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 34);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Appearance.Options.UseFont = true;
            this.btnOk.Location = new System.Drawing.Point(113, 204);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(94, 34);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "Đồng Ý";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cmbChangeClass
            // 
            this.cmbChangeClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbChangeClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbChangeClass.DataSource = this.bdsAllClass;
            this.cmbChangeClass.DisplayMember = "TENLOP";
            this.cmbChangeClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChangeClass.FormattingEnabled = true;
            this.cmbChangeClass.Location = new System.Drawing.Point(187, 152);
            this.cmbChangeClass.Name = "cmbChangeClass";
            this.cmbChangeClass.Size = new System.Drawing.Size(278, 27);
            this.cmbChangeClass.TabIndex = 10;
            this.cmbChangeClass.ValueMember = "MALOP";
            this.cmbChangeClass.SelectedIndexChanged += new System.EventHandler(this.cmbChangeClass_SelectedIndexChanged);
            this.cmbChangeClass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbChangeClass_KeyUp);
            // 
            // bdsAllClass
            // 
            this.bdsAllClass.DataMember = "AllClass";
            this.bdsAllClass.DataSource = this.dS_SERVER1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl1.ImageOptions.SvgImage")));
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(34, 143);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(147, 42);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Chuyển đến";
            // 
            // txteMaLop
            // 
            this.txteMaLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MALOP", true));
            this.txteMaLop.Location = new System.Drawing.Point(93, 73);
            this.txteMaLop.MenuManager = this.barManager;
            this.txteMaLop.Name = "txteMaLop";
            this.txteMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteMaLop.Properties.Appearance.Options.UseFont = true;
            this.txteMaLop.Properties.ReadOnly = true;
            this.txteMaLop.Size = new System.Drawing.Size(124, 26);
            this.txteMaLop.TabIndex = 8;
            // 
            // tENTextEdit
            // 
            this.tENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "TEN", true));
            this.tENTextEdit.Location = new System.Drawing.Point(287, 73);
            this.tENTextEdit.MenuManager = this.barManager;
            this.tENTextEdit.Name = "tENTextEdit";
            this.tENTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENTextEdit.Properties.ReadOnly = true;
            this.tENTextEdit.Size = new System.Drawing.Size(178, 26);
            this.tENTextEdit.TabIndex = 6;
            // 
            // hOTextEdit
            // 
            this.hOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "HO", true));
            this.hOTextEdit.Location = new System.Drawing.Point(287, 15);
            this.hOTextEdit.MenuManager = this.barManager;
            this.hOTextEdit.Name = "hOTextEdit";
            this.hOTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOTextEdit.Properties.Appearance.Options.UseFont = true;
            this.hOTextEdit.Properties.ReadOnly = true;
            this.hOTextEdit.Size = new System.Drawing.Size(178, 26);
            this.hOTextEdit.TabIndex = 4;
            // 
            // txteMaSV
            // 
            this.txteMaSV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSV, "MASV", true));
            this.txteMaSV.Location = new System.Drawing.Point(93, 15);
            this.txteMaSV.MenuManager = this.barManager;
            this.txteMaSV.Name = "txteMaSV";
            this.txteMaSV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteMaSV.Properties.Appearance.Options.UseFont = true;
            this.txteMaSV.Properties.ReadOnly = true;
            this.txteMaSV.Size = new System.Drawing.Size(124, 26);
            this.txteMaSV.TabIndex = 2;
            // 
            // taSV
            // 
            this.taSV.ClearBeforeFill = true;
            // 
            // dgvSV
            // 
            this.dgvSV.AllowUserToAddRows = false;
            this.dgvSV.AllowUserToDeleteRows = false;
            this.dgvSV.AutoGenerateColumns = false;
            this.dgvSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSV.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxbMaSV,
            this.dgvtxbHo,
            this.dgvtxbTen,
            this.dgvtxbMaLop,
            this.dgvchbPhai,
            this.dgvtxbNgaySinh,
            this.dgvtxbNoiSinh,
            this.dgvtxbDiaChi,
            this.dgvchbNghiHoc});
            this.dgvSV.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSV.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvSV.DataSource = this.bdsSV;
            this.dgvSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSV.Location = new System.Drawing.Point(917, 396);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.ReadOnly = true;
            this.dgvSV.RowTemplate.Height = 30;
            this.dgvSV.Size = new System.Drawing.Size(1013, 358);
            this.dgvSV.TabIndex = 32;
            this.dgvSV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSV_CellEndEdit);
            this.dgvSV.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvSV_CellValidating);
            this.dgvSV.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSV_DataError);
            // 
            // dgvtxbMaSV
            // 
            this.dgvtxbMaSV.DataPropertyName = "MASV";
            this.dgvtxbMaSV.HeaderText = "MASV";
            this.dgvtxbMaSV.Name = "dgvtxbMaSV";
            this.dgvtxbMaSV.ReadOnly = true;
            this.dgvtxbMaSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtxbMaSV.Width = 93;
            // 
            // dgvtxbHo
            // 
            this.dgvtxbHo.DataPropertyName = "HO";
            this.dgvtxbHo.HeaderText = "HO";
            this.dgvtxbHo.Name = "dgvtxbHo";
            this.dgvtxbHo.ReadOnly = true;
            this.dgvtxbHo.Width = 65;
            // 
            // dgvtxbTen
            // 
            this.dgvtxbTen.DataPropertyName = "TEN";
            this.dgvtxbTen.HeaderText = "TEN";
            this.dgvtxbTen.Name = "dgvtxbTen";
            this.dgvtxbTen.ReadOnly = true;
            this.dgvtxbTen.Width = 75;
            // 
            // dgvtxbMaLop
            // 
            this.dgvtxbMaLop.DataPropertyName = "MALOP";
            this.dgvtxbMaLop.HeaderText = "MALOP";
            this.dgvtxbMaLop.Name = "dgvtxbMaLop";
            this.dgvtxbMaLop.ReadOnly = true;
            this.dgvtxbMaLop.Width = 106;
            // 
            // dgvchbPhai
            // 
            this.dgvchbPhai.DataPropertyName = "PHAI";
            this.dgvchbPhai.FalseValue = "0";
            this.dgvchbPhai.HeaderText = "NAM";
            this.dgvchbPhai.IndeterminateValue = "0";
            this.dgvchbPhai.Name = "dgvchbPhai";
            this.dgvchbPhai.ReadOnly = true;
            this.dgvchbPhai.TrueValue = "1";
            this.dgvchbPhai.Width = 63;
            // 
            // dgvtxbNgaySinh
            // 
            this.dgvtxbNgaySinh.DataPropertyName = "NGAYSINH";
            this.dgvtxbNgaySinh.HeaderText = "NGAYSINH";
            this.dgvtxbNgaySinh.Name = "dgvtxbNgaySinh";
            this.dgvtxbNgaySinh.ReadOnly = true;
            this.dgvtxbNgaySinh.Width = 139;
            // 
            // dgvtxbNoiSinh
            // 
            this.dgvtxbNoiSinh.DataPropertyName = "NOISINH";
            this.dgvtxbNoiSinh.HeaderText = "NOISINH";
            this.dgvtxbNoiSinh.Name = "dgvtxbNoiSinh";
            this.dgvtxbNoiSinh.ReadOnly = true;
            this.dgvtxbNoiSinh.Width = 118;
            // 
            // dgvtxbDiaChi
            // 
            this.dgvtxbDiaChi.DataPropertyName = "DIACHI";
            this.dgvtxbDiaChi.HeaderText = "DIACHI";
            this.dgvtxbDiaChi.Name = "dgvtxbDiaChi";
            this.dgvtxbDiaChi.ReadOnly = true;
            this.dgvtxbDiaChi.Width = 105;
            // 
            // dgvchbNghiHoc
            // 
            this.dgvchbNghiHoc.DataPropertyName = "NGHIHOC";
            this.dgvchbNghiHoc.FalseValue = "false";
            this.dgvchbNghiHoc.HeaderText = "NGHIHOC";
            this.dgvchbNghiHoc.IndeterminateValue = "false";
            this.dgvchbNghiHoc.Name = "dgvchbNghiHoc";
            this.dgvchbNghiHoc.ReadOnly = true;
            this.dgvchbNghiHoc.TrueValue = "true";
            this.dgvchbNghiHoc.Width = 111;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlToolStripMenuItem,
            this.tsChangeClass});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 48);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsRemove,
            this.tsEdit,
            this.tsWrite,
            this.tsRecovery});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // tsAdd
            // 
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(141, 22);
            this.tsAdd.Text = "THÊM";
            this.tsAdd.Click += new System.EventHandler(this.tsAdd_Click);
            // 
            // tsRemove
            // 
            this.tsRemove.Name = "tsRemove";
            this.tsRemove.Size = new System.Drawing.Size(141, 22);
            this.tsRemove.Text = "XÓA";
            this.tsRemove.Click += new System.EventHandler(this.tsRemove_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(141, 22);
            this.tsEdit.Text = "HIỆU CHỈNH";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // tsWrite
            // 
            this.tsWrite.Name = "tsWrite";
            this.tsWrite.Size = new System.Drawing.Size(141, 22);
            this.tsWrite.Text = "GHI";
            this.tsWrite.Click += new System.EventHandler(this.tsWrite_Click);
            // 
            // tsRecovery
            // 
            this.tsRecovery.Name = "tsRecovery";
            this.tsRecovery.Size = new System.Drawing.Size(141, 22);
            this.tsRecovery.Text = "PHỤC HỒI";
            this.tsRecovery.Click += new System.EventHandler(this.tsRecovery_Click);
            // 
            // tsChangeClass
            // 
            this.tsChangeClass.Name = "tsChangeClass";
            this.tsChangeClass.Size = new System.Drawing.Size(146, 22);
            this.tsChangeClass.Text = "CHUYỂN LỚP";
            this.tsChangeClass.Click += new System.EventHandler(this.tsChangeClass_Click);
            // 
            // bdsDiem
            // 
            this.bdsDiem.DataMember = "FK_DIEM_SINHVIEN";
            this.bdsDiem.DataSource = this.bdsSV;
            // 
            // taDiem
            // 
            this.taDiem.ClearBeforeFill = true;
            // 
            // taAllClass
            // 
            this.taAllClass.ClearBeforeFill = true;
            // 
            // ClassForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1930, 777);
            this.Controls.Add(this.flyoutPanel1);
            this.Controls.Add(this.dgvSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcLop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ClassForm";
            this.Text = "ClassForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClassForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClassForm_FormClosed);
            this.Load += new System.EventHandler(this.ClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SERVER1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            this.flyoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAllClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbtnAdd;
        private DevExpress.XtraBars.BarButtonItem bbtnRemove;
        private DevExpress.XtraBars.BarButtonItem bbtnEdit;
        private DevExpress.XtraBars.BarButtonItem bbtnWrite;
        private DevExpress.XtraBars.BarButtonItem bbtnRecovery;
        private System.Windows.Forms.BindingSource bdsLop;
        private DS_SERVER1 dS_SERVER1;
        private DS_SERVER1TableAdapters.LOPTableAdapter taLop;
        private DS_SERVER1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DS_SERVER1TableAdapters.KHOATableAdapter taKhoa;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbKhoaInUse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource bdsSV;
        private DS_SERVER1TableAdapters.SINHVIENTableAdapter taSV;
        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.TextBox txbMaLop;
        private System.Windows.Forms.TextBox txbTenLop;
        private System.Windows.Forms.TextBox txbMaKhoa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsAdd;
        private System.Windows.Forms.ToolStripMenuItem tsRemove;
        private System.Windows.Forms.ToolStripMenuItem tsEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private System.Windows.Forms.ToolStripMenuItem tsWrite;
        private System.Windows.Forms.ToolStripMenuItem tsRecovery;
        private System.Windows.Forms.ToolStripMenuItem tsChangeClass;
        private System.Windows.Forms.BindingSource bdsDiem;
        private DS_SERVER1TableAdapters.DIEMTableAdapter taDiem;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.XtraEditors.TextEdit txteMaLop;
        private DevExpress.XtraEditors.TextEdit tENTextEdit;
        private DevExpress.XtraEditors.TextEdit hOTextEdit;
        private DevExpress.XtraEditors.TextEdit txteMaSV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bdsAllClass;
        private DS_SERVER1TableAdapters.AllClassTableAdapter taAllClass;
        private System.Windows.Forms.ComboBox cmbChangeClass;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxbMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxbHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxbTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxbMaLop;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvchbPhai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxbNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxbNoiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxbDiaChi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvchbNghiHoc;
    }
}