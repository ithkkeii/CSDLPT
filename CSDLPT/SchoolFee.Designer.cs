namespace CSDLPT {
    partial class SchoolFee {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchoolFee));
            this.lbNhapMaSinhVien = new DevExpress.XtraEditors.LabelControl();
            this.txtbFindMaSV = new System.Windows.Forms.TextBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.flyoutPanelMain = new DevExpress.Utils.FlyoutPanel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.gcHocPhi = new DevExpress.XtraGrid.GridControl();
            this.bdsHocPhi = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DONGHOCPHI = new CSDLPT.DS_DONGHOCPHI();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCPHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIENDADONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnWrite = new DevExpress.XtraEditors.SimpleButton();
            this.btnRecovery = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtbTen = new System.Windows.Forms.TextBox();
            this.txtbHo = new System.Windows.Forms.TextBox();
            this.txtbMaLop = new System.Windows.Forms.TextBox();
            this.txtbMaSinhVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flyoutPanelSub = new DevExpress.Utils.FlyoutPanel();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.taHocPhi = new CSDLPT.DS_DONGHOCPHITableAdapters.HOCPHITableAdapter();
            this.tableAdapterManager = new CSDLPT.DS_DONGHOCPHITableAdapters.TableAdapterManager();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.taSV = new CSDLPT.DS_DONGHOCPHITableAdapters.SINHVIENTableAdapter();
            this.sINHVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelMain)).BeginInit();
            this.flyoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DONGHOCPHI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelSub)).BeginInit();
            this.flyoutPanelSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNhapMaSinhVien
            // 
            this.lbNhapMaSinhVien.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhapMaSinhVien.Appearance.Options.UseFont = true;
            this.lbNhapMaSinhVien.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lbNhapMaSinhVien.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNhapMaSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lbNhapMaSinhVien.ImageOptions.Image")));
            this.lbNhapMaSinhVien.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lbNhapMaSinhVien.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.lbNhapMaSinhVien.LineVisible = true;
            this.lbNhapMaSinhVien.Location = new System.Drawing.Point(18, 19);
            this.lbNhapMaSinhVien.Name = "lbNhapMaSinhVien";
            this.lbNhapMaSinhVien.Size = new System.Drawing.Size(210, 39);
            this.lbNhapMaSinhVien.TabIndex = 0;
            this.lbNhapMaSinhVien.Text = "Nhập Mã Sinh Viên: ";
            // 
            // txtbFindMaSV
            // 
            this.txtbFindMaSV.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFindMaSV.Location = new System.Drawing.Point(244, 24);
            this.txtbFindMaSV.Name = "txtbFindMaSV";
            this.txtbFindMaSV.Size = new System.Drawing.Size(226, 32);
            this.txtbFindMaSV.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Location = new System.Drawing.Point(491, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // flyoutPanelMain
            // 
            this.flyoutPanelMain.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.flyoutPanelMain.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.flyoutPanelMain.Appearance.BorderColor = System.Drawing.Color.White;
            this.flyoutPanelMain.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.flyoutPanelMain.Appearance.Options.UseBackColor = true;
            this.flyoutPanelMain.Appearance.Options.UseBorderColor = true;
            this.flyoutPanelMain.Appearance.Options.UseForeColor = true;
            this.flyoutPanelMain.Controls.Add(this.groupControl3);
            this.flyoutPanelMain.Location = new System.Drawing.Point(733, 81);
            this.flyoutPanelMain.Name = "flyoutPanelMain";
            this.flyoutPanelMain.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.TopRight;
            this.flyoutPanelMain.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.flyoutPanelMain.Options.HorzIndent = 350;
            this.flyoutPanelMain.Options.VertIndent = 150;
            this.flyoutPanelMain.OptionsBeakPanel.BackColor = System.Drawing.Color.Transparent;
            this.flyoutPanelMain.OptionsBeakPanel.BorderColor = System.Drawing.Color.Transparent;
            this.flyoutPanelMain.OwnerControl = this;
            this.flyoutPanelMain.Size = new System.Drawing.Size(929, 594);
            this.flyoutPanelMain.TabIndex = 3;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnEdit);
            this.groupControl3.Controls.Add(this.gcHocPhi);
            this.groupControl3.Controls.Add(this.btnWrite);
            this.groupControl3.Controls.Add(this.btnRecovery);
            this.groupControl3.Controls.Add(this.btnDelete);
            this.groupControl3.Controls.Add(this.btnAdd);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.ShowCaption = false;
            this.groupControl3.Size = new System.Drawing.Size(929, 594);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "groupControl3";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Location = new System.Drawing.Point(289, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(149, 31);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "CHỈNH SỬA";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gcHocPhi
            // 
            this.gcHocPhi.DataSource = this.bdsHocPhi;
            this.gcHocPhi.Location = new System.Drawing.Point(30, 86);
            this.gcHocPhi.MainView = this.gridView1;
            this.gcHocPhi.Name = "gcHocPhi";
            this.gcHocPhi.Size = new System.Drawing.Size(880, 477);
            this.gcHocPhi.TabIndex = 4;
            this.gcHocPhi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcHocPhi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcHocPhi_KeyDown);
            // 
            // bdsHocPhi
            // 
            this.bdsHocPhi.DataMember = "HOCPHI";
            this.bdsHocPhi.DataSource = this.dS_DONGHOCPHI;
            // 
            // dS_DONGHOCPHI
            // 
            this.dS_DONGHOCPHI.DataSetName = "DS_DONGHOCPHI";
            this.dS_DONGHOCPHI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.ColumnPanelRowHeight = 35;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNIENKHOA,
            this.colHOCKY,
            this.colHOCPHI,
            this.colSOTIENDADONG,
            this.colMASV});
            this.gridView1.GridControl = this.gcHocPhi;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 35;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            this.gridView1.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridView1.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView1_InvalidRowException);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNIENKHOA.AppearanceCell.Options.UseBorderColor = true;
            this.colNIENKHOA.AppearanceCell.Options.UseFont = true;
            this.colNIENKHOA.AppearanceHeader.BorderColor = System.Drawing.Color.Black;
            this.colNIENKHOA.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNIENKHOA.AppearanceHeader.Options.UseFont = true;
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 0;
            // 
            // colHOCKY
            // 
            this.colHOCKY.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCKY.AppearanceCell.Options.UseBorderColor = true;
            this.colHOCKY.AppearanceCell.Options.UseFont = true;
            this.colHOCKY.AppearanceHeader.BorderColor = System.Drawing.Color.Black;
            this.colHOCKY.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCKY.AppearanceHeader.Options.UseFont = true;
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 1;
            // 
            // colHOCPHI
            // 
            this.colHOCPHI.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCPHI.AppearanceCell.Options.UseBorderColor = true;
            this.colHOCPHI.AppearanceCell.Options.UseFont = true;
            this.colHOCPHI.AppearanceHeader.BorderColor = System.Drawing.Color.Black;
            this.colHOCPHI.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colHOCPHI.AppearanceHeader.Options.UseFont = true;
            this.colHOCPHI.FieldName = "HOCPHI";
            this.colHOCPHI.Name = "colHOCPHI";
            this.colHOCPHI.Visible = true;
            this.colHOCPHI.VisibleIndex = 2;
            // 
            // colSOTIENDADONG
            // 
            this.colSOTIENDADONG.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTIENDADONG.AppearanceCell.Options.UseBorderColor = true;
            this.colSOTIENDADONG.AppearanceCell.Options.UseFont = true;
            this.colSOTIENDADONG.AppearanceHeader.BorderColor = System.Drawing.Color.Black;
            this.colSOTIENDADONG.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTIENDADONG.AppearanceHeader.Options.UseFont = true;
            this.colSOTIENDADONG.FieldName = "SOTIENDADONG";
            this.colSOTIENDADONG.Name = "colSOTIENDADONG";
            this.colSOTIENDADONG.Visible = true;
            this.colSOTIENDADONG.VisibleIndex = 3;
            // 
            // colMASV
            // 
            this.colMASV.AppearanceCell.Options.UseBorderColor = true;
            this.colMASV.AppearanceHeader.BorderColor = System.Drawing.Color.Black;
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            // 
            // btnWrite
            // 
            this.btnWrite.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Appearance.Options.UseFont = true;
            this.btnWrite.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnWrite.ImageOptions.SvgImage")));
            this.btnWrite.Location = new System.Drawing.Point(472, 18);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(90, 31);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "GHI";
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRecovery
            // 
            this.btnRecovery.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecovery.Appearance.Options.UseFont = true;
            this.btnRecovery.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnRecovery.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRecovery.ImageOptions.SvgImage")));
            this.btnRecovery.Location = new System.Drawing.Point(605, 18);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(127, 31);
            this.btnRecovery.TabIndex = 2;
            this.btnRecovery.Text = "PHỤC HỒI";
            this.btnRecovery.Visible = false;
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnDelete.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseBorderColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.AppearanceDisabled.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.AppearanceDisabled.Options.UseForeColor = true;
            this.btnDelete.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.AppearanceHovered.BackColor2 = System.Drawing.Color.Transparent;
            this.btnDelete.AppearanceHovered.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.AppearanceHovered.Options.UseBackColor = true;
            this.btnDelete.AppearanceHovered.Options.UseBorderColor = true;
            this.btnDelete.AppearanceHovered.Options.UseForeColor = true;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(166, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(30, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtbTen);
            this.groupControl2.Controls.Add(this.txtbHo);
            this.groupControl2.Controls.Add(this.txtbMaLop);
            this.groupControl2.Controls.Add(this.txtbMaSinhVien);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl2.Location = new System.Drawing.Point(27, 24);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(370, 201);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "groupControl2";
            // 
            // txtbTen
            // 
            this.txtbTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTen.Location = new System.Drawing.Point(140, 151);
            this.txtbTen.Name = "txtbTen";
            this.txtbTen.ReadOnly = true;
            this.txtbTen.Size = new System.Drawing.Size(198, 29);
            this.txtbTen.TabIndex = 7;
            // 
            // txtbHo
            // 
            this.txtbHo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbHo.Location = new System.Drawing.Point(140, 112);
            this.txtbHo.Name = "txtbHo";
            this.txtbHo.ReadOnly = true;
            this.txtbHo.Size = new System.Drawing.Size(198, 29);
            this.txtbHo.TabIndex = 6;
            // 
            // txtbMaLop
            // 
            this.txtbMaLop.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaLop.Location = new System.Drawing.Point(140, 70);
            this.txtbMaLop.Name = "txtbMaLop";
            this.txtbMaLop.ReadOnly = true;
            this.txtbMaLop.Size = new System.Drawing.Size(198, 29);
            this.txtbMaLop.TabIndex = 5;
            // 
            // txtbMaSinhVien
            // 
            this.txtbMaSinhVien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbMaSinhVien.Location = new System.Drawing.Point(140, 27);
            this.txtbMaSinhVien.Name = "txtbMaSinhVien";
            this.txtbMaSinhVien.ReadOnly = true;
            this.txtbMaSinhVien.Size = new System.Drawing.Size(198, 29);
            this.txtbMaSinhVien.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbNhapMaSinhVien);
            this.groupControl1.Controls.Add(this.txtbFindMaSV);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(645, 81);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // flyoutPanelSub
            // 
            this.flyoutPanelSub.AnimationRate = 70;
            this.flyoutPanelSub.Controls.Add(this.btnBack);
            this.flyoutPanelSub.Controls.Add(this.groupControl2);
            this.flyoutPanelSub.Location = new System.Drawing.Point(231, 115);
            this.flyoutPanelSub.Name = "flyoutPanelSub";
            this.flyoutPanelSub.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.TopLeft;
            this.flyoutPanelSub.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.flyoutPanelSub.Options.HorzIndent = 100;
            this.flyoutPanelSub.Options.VertIndent = 200;
            this.flyoutPanelSub.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.flyoutPanelSub.OwnerControl = this;
            this.flyoutPanelSub.Size = new System.Drawing.Size(426, 315);
            this.flyoutPanelSub.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Appearance.Options.UseForeColor = true;
            this.btnBack.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.ImageOptions.Image")));
            this.btnBack.Location = new System.Drawing.Point(97, 243);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(268, 42);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "CHỌN LẠI MÃ SINH VIÊN";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // taHocPhi
            // 
            this.taHocPhi.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = this.taHocPhi;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.SP_THONGTINDONGHOCPHITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DS_DONGHOCPHITableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "SINHVIEN";
            this.bdsSV.DataSource = this.dS_DONGHOCPHI;
            // 
            // taSV
            // 
            this.taSV.ClearBeforeFill = true;
            // 
            // sINHVIENGridControl
            // 
            this.sINHVIENGridControl.DataSource = this.bdsSV;
            this.sINHVIENGridControl.Location = new System.Drawing.Point(30, 455);
            this.sINHVIENGridControl.MainView = this.gridView2;
            this.sINHVIENGridControl.Name = "sINHVIENGridControl";
            this.sINHVIENGridControl.Size = new System.Drawing.Size(300, 220);
            this.sINHVIENGridControl.TabIndex = 6;
            this.sINHVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.sINHVIENGridControl.Visible = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.sINHVIENGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // SchoolFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1930, 937);
            this.Controls.Add(this.sINHVIENGridControl);
            this.Controls.Add(this.flyoutPanelSub);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.flyoutPanelMain);
            this.Name = "SchoolFee";
            this.Text = "SchoolFee";
            this.Load += new System.EventHandler(this.SchoolFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelMain)).EndInit();
            this.flyoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHocPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DONGHOCPHI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelSub)).EndInit();
            this.flyoutPanelSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbNhapMaSinhVien;
        private System.Windows.Forms.TextBox txtbFindMaSV;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.Utils.FlyoutPanel flyoutPanelMain;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox txtbTen;
        private System.Windows.Forms.TextBox txtbHo;
        private System.Windows.Forms.TextBox txtbMaLop;
        private System.Windows.Forms.TextBox txtbMaSinhVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.FlyoutPanel flyoutPanelSub;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnWrite;
        private DevExpress.XtraEditors.SimpleButton btnRecovery;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DS_DONGHOCPHI dS_DONGHOCPHI;
        private System.Windows.Forms.BindingSource bdsHocPhi;
        private DS_DONGHOCPHITableAdapters.HOCPHITableAdapter taHocPhi;
        private DS_DONGHOCPHITableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcHocPhi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCPHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIENDADONG;
        private System.Windows.Forms.BindingSource bdsSV;
        private DS_DONGHOCPHITableAdapters.SINHVIENTableAdapter taSV;
        private DevExpress.XtraGrid.GridControl sINHVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnBack;
    }
}