namespace CSDLPT {
    partial class SubjectForm {
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
            this.mAMHLabel = new System.Windows.Forms.Label();
            this.tENMHLabel = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonAddSubject = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDelSubject = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonEditSubject = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonUndoSubject = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSaveSubject = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonExitSubjectForm = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dS_SERVER1 = new CSDLPT.DS_SERVER1();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new CSDLPT.DS_SERVER1TableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new CSDLPT.DS_SERVER1TableAdapters.TableAdapterManager();
            this.mONHOCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControlSubject = new DevExpress.XtraEditors.GroupControl();
            this.tENMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIEMTableAdapter = new CSDLPT.DS_SERVER1TableAdapters.DIEMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SERVER1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSubject)).BeginInit();
            this.groupControlSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            this.mAMHLabel.AutoSize = true;
            this.mAMHLabel.Location = new System.Drawing.Point(57, 99);
            this.mAMHLabel.Name = "mAMHLabel";
            this.mAMHLabel.Size = new System.Drawing.Size(68, 13);
            this.mAMHLabel.TabIndex = 0;
            this.mAMHLabel.Text = "Mã Môn học:";
            // 
            // tENMHLabel
            // 
            this.tENMHLabel.AutoSize = true;
            this.tENMHLabel.Location = new System.Drawing.Point(393, 99);
            this.tENMHLabel.Name = "tENMHLabel";
            this.tENMHLabel.Size = new System.Drawing.Size(73, 13);
            this.tENMHLabel.TabIndex = 2;
            this.tENMHLabel.Text = "Tên Môn Học:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonAddSubject,
            this.barButtonDelSubject,
            this.barButtonEditSubject,
            this.barButtonUndoSubject,
            this.barButtonSaveSubject,
            this.barButtonExitSubjectForm});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonAddSubject, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonDelSubject, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonEditSubject, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonUndoSubject, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonSaveSubject, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonExitSubjectForm, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonAddSubject
            // 
            this.barButtonAddSubject.Caption = "THÊM";
            this.barButtonAddSubject.Id = 0;
            this.barButtonAddSubject.Name = "barButtonAddSubject";
            this.barButtonAddSubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonAddSubject_ItemClick);
            // 
            // barButtonDelSubject
            // 
            this.barButtonDelSubject.Caption = "XÓA";
            this.barButtonDelSubject.Id = 1;
            this.barButtonDelSubject.Name = "barButtonDelSubject";
            this.barButtonDelSubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonDelSubject_ItemClick);
            // 
            // barButtonEditSubject
            // 
            this.barButtonEditSubject.Caption = "HIỆU CHỈNH";
            this.barButtonEditSubject.Id = 2;
            this.barButtonEditSubject.Name = "barButtonEditSubject";
            this.barButtonEditSubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonEditSubject_ItemClick);
            // 
            // barButtonUndoSubject
            // 
            this.barButtonUndoSubject.Caption = "PHỤC HỒI";
            this.barButtonUndoSubject.Id = 3;
            this.barButtonUndoSubject.Name = "barButtonUndoSubject";
            this.barButtonUndoSubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonUndoSubject_ItemClick);
            // 
            // barButtonSaveSubject
            // 
            this.barButtonSaveSubject.Caption = "GHI";
            this.barButtonSaveSubject.Id = 4;
            this.barButtonSaveSubject.Name = "barButtonSaveSubject";
            this.barButtonSaveSubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonSaveSubject_ItemClick);
            // 
            // barButtonExitSubjectForm
            // 
            this.barButtonExitSubjectForm.Caption = "THOÁT";
            this.barButtonExitSubjectForm.Id = 5;
            this.barButtonExitSubjectForm.Name = "barButtonExitSubjectForm";
            this.barButtonExitSubjectForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonExitSubjectForm_ItemClick);
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
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(820, 41);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 464);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(820, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 41);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 423);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(820, 41);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 423);
            // 
            // dS_SERVER1
            // 
            this.dS_SERVER1.DataSetName = "DS_SERVER1";
            this.dS_SERVER1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.dS_SERVER1;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DS_SERVER1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCGridControl
            // 
            this.mONHOCGridControl.DataSource = this.bdsMONHOC;
            this.mONHOCGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.mONHOCGridControl.Location = new System.Drawing.Point(0, 41);
            this.mONHOCGridControl.MainView = this.gridView1;
            this.mONHOCGridControl.MenuManager = this.barManager1;
            this.mONHOCGridControl.Name = "mONHOCGridControl";
            this.mONHOCGridControl.Size = new System.Drawing.Size(820, 220);
            this.mONHOCGridControl.TabIndex = 10;
            this.mONHOCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gridView1.GridControl = this.mONHOCGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.ShowUnboundExpressionMenu = true;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
            // 
            // groupControlSubject
            // 
            this.groupControlSubject.Controls.Add(this.tENMHLabel);
            this.groupControlSubject.Controls.Add(this.tENMHTextEdit);
            this.groupControlSubject.Controls.Add(this.mAMHLabel);
            this.groupControlSubject.Controls.Add(this.mAMHTextEdit);
            this.groupControlSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlSubject.Location = new System.Drawing.Point(0, 261);
            this.groupControlSubject.Name = "groupControlSubject";
            this.groupControlSubject.Size = new System.Drawing.Size(820, 203);
            this.groupControlSubject.TabIndex = 15;
            // 
            // tENMHTextEdit
            // 
            this.tENMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMONHOC, "TENMH", true));
            this.tENMHTextEdit.Location = new System.Drawing.Point(472, 96);
            this.tENMHTextEdit.MenuManager = this.barManager1;
            this.tENMHTextEdit.Name = "tENMHTextEdit";
            this.tENMHTextEdit.Size = new System.Drawing.Size(274, 20);
            this.tENMHTextEdit.TabIndex = 3;
            // 
            // mAMHTextEdit
            // 
            this.mAMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMONHOC, "MAMH", true));
            this.mAMHTextEdit.Location = new System.Drawing.Point(143, 96);
            this.mAMHTextEdit.MenuManager = this.barManager1;
            this.mAMHTextEdit.Name = "mAMHTextEdit";
            this.mAMHTextEdit.Properties.ReadOnly = true;
            this.mAMHTextEdit.Size = new System.Drawing.Size(120, 20);
            this.mAMHTextEdit.TabIndex = 1;
            // 
            // dIEMBindingSource
            // 
            this.dIEMBindingSource.DataMember = "FK_DIEM_MONHOC1";
            this.dIEMBindingSource.DataSource = this.bdsMONHOC;
            // 
            // dIEMTableAdapter
            // 
            this.dIEMTableAdapter.ClearBeforeFill = true;
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 484);
            this.Controls.Add(this.groupControlSubject);
            this.Controls.Add(this.mONHOCGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SERVER1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSubject)).EndInit();
            this.groupControlSubject.ResumeLayout(false);
            this.groupControlSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tENMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonAddSubject;
        private DevExpress.XtraBars.BarButtonItem barButtonDelSubject;
        private DevExpress.XtraBars.BarButtonItem barButtonEditSubject;
        private DevExpress.XtraBars.BarButtonItem barButtonUndoSubject;
        private DevExpress.XtraBars.BarButtonItem barButtonSaveSubject;
        private DevExpress.XtraBars.BarButtonItem barButtonExitSubjectForm;
        private System.Windows.Forms.BindingSource bdsMONHOC;
        private DS_SERVER1 dS_SERVER1;
        private DS_SERVER1TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DS_SERVER1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl mONHOCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControlSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraEditors.TextEdit tENMHTextEdit;
        private DevExpress.XtraEditors.TextEdit mAMHTextEdit;
        private System.Windows.Forms.Label mAMHLabel;
        private System.Windows.Forms.Label tENMHLabel;
        private System.Windows.Forms.BindingSource dIEMBindingSource;
        private DS_SERVER1TableAdapters.DIEMTableAdapter dIEMTableAdapter;
    }
}