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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassForm));
            this.dbsLop = new System.Windows.Forms.BindingSource(this.components);
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
            this.lOPTableAdapter = new CSDLPT.DS_SERVER1TableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new CSDLPT.DS_SERVER1TableAdapters.TableAdapterManager();
            this.bdsKhoa = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new CSDLPT.DS_SERVER1TableAdapters.KHOATableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbKhoaInUse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gcLop = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.giangvienTableAdapter1 = new CSDLPT.DS_SERVER1TableAdapters.GIANGVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SERVER1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dbsLop
            // 
            this.dbsLop.DataMember = "LOP";
            this.dbsLop.DataSource = this.dS_SERVER1;
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
            this.bbtnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtnAdd.ImageOptions.SvgImage")));
            this.bbtnAdd.Name = "bbtnAdd";
            this.bbtnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAdd_ItemClick);
            // 
            // bbtnRemove
            // 
            this.bbtnRemove.Caption = "XÓA LỚP";
            this.bbtnRemove.Id = 3;
            this.bbtnRemove.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtnRemove.ImageOptions.SvgImage")));
            this.bbtnRemove.Name = "bbtnRemove";
            // 
            // bbtnEdit
            // 
            this.bbtnEdit.Caption = "HIỆU CHỈNH";
            this.bbtnEdit.Id = 4;
            this.bbtnEdit.Name = "bbtnEdit";
            // 
            // bbtnWrite
            // 
            this.bbtnWrite.Caption = "GHI";
            this.bbtnWrite.Id = 7;
            this.bbtnWrite.Name = "bbtnWrite";
            // 
            // bbtnRecovery
            // 
            this.bbtnRecovery.Caption = "PHỤC HỒI";
            this.bbtnRecovery.Id = 8;
            this.bbtnRecovery.Name = "bbtnRecovery";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1193, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 634);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.barDockControlBottom.Size = new System.Drawing.Size(1193, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 608);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1193, 26);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 608);
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
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DS_SERVER1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsKhoa
            // 
            this.bdsKhoa.DataMember = "KHOA";
            this.bdsKhoa.DataSource = this.dS_SERVER1;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbKhoaInUse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 67);
            this.panel1.TabIndex = 27;
            // 
            // cmbKhoaInUse
            // 
            this.cmbKhoaInUse.FormattingEnabled = true;
            this.cmbKhoaInUse.Location = new System.Drawing.Point(309, 14);
            this.cmbKhoaInUse.Name = "cmbKhoaInUse";
            this.cmbKhoaInUse.Size = new System.Drawing.Size(321, 35);
            this.cmbKhoaInUse.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 28;
            this.label1.Text = "Khoa:";
            // 
            // gcLop
            // 
            this.gcLop.DataSource = this.dbsLop;
            this.gcLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcLop.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(0);
            this.gcLop.Location = new System.Drawing.Point(0, 93);
            this.gcLop.MainView = this.gridView1;
            this.gcLop.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gcLop.MenuManager = this.barManager;
            this.gcLop.Name = "gcLop";
            this.gcLop.Size = new System.Drawing.Size(1193, 274);
            this.gcLop.TabIndex = 27;
            this.gcLop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 727;
            this.gridView1.FixedLineWidth = 4;
            this.gridView1.GridControl = this.gcLop;
            this.gridView1.Name = "gridView1";
            // 
            // giangvienTableAdapter1
            // 
            this.giangvienTableAdapter1.ClearBeforeFill = true;
            // 
            // ClassForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 657);
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
            this.Load += new System.EventHandler(this.ClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SERVER1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private System.Windows.Forms.BindingSource dbsLop;
        private DS_SERVER1 dS_SERVER1;
        private DS_SERVER1TableAdapters.LOPTableAdapter lOPTableAdapter;
        private DS_SERVER1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsKhoa;
        private DS_SERVER1TableAdapters.KHOATableAdapter kHOATableAdapter;
        private DevExpress.XtraGrid.GridControl gcLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DS_SERVER1TableAdapters.GIANGVIENTableAdapter giangvienTableAdapter1;
        private System.Windows.Forms.ComboBox cmbKhoaInUse;
        private System.Windows.Forms.Label label1;
    }
}