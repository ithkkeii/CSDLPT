namespace CSDLPT {
    partial class MainView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbtnSubject = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnModifyClass = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSchoolFee = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnCreateAccount = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnInDSSV = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnInBangDiem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnInDSDongTien = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbtnSubject,
            this.bbtnModifyClass,
            this.barButtonItem1,
            this.bbtnSchoolFee,
            this.bbtnCreateAccount,
            this.bbtnInDSSV,
            this.bbtnInBangDiem,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.bbtnInDSDongTien});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1174, 143);
            // 
            // bbtnSubject
            // 
            this.bbtnSubject.Caption = "SINH VIÊN";
            this.bbtnSubject.Id = 1;
            this.bbtnSubject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnSubject.ImageOptions.Image")));
            this.bbtnSubject.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnSubject.ImageOptions.LargeImage")));
            this.bbtnSubject.Name = "bbtnSubject";
            this.bbtnSubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSV_ItemClick);
            // 
            // bbtnModifyClass
            // 
            this.bbtnModifyClass.Caption = "NHẬP LỚP";
            this.bbtnModifyClass.Id = 3;
            this.bbtnModifyClass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtnModifyClass.ImageOptions.SvgImage")));
            this.bbtnModifyClass.Name = "bbtnModifyClass";
            this.bbtnModifyClass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonModifyClass_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đóng Học Phí";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bbtnSchoolFee
            // 
            this.bbtnSchoolFee.Caption = "ĐÓNG HỌC PHÍ";
            this.bbtnSchoolFee.Id = 6;
            this.bbtnSchoolFee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnSchoolFee.ImageOptions.Image")));
            this.bbtnSchoolFee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnSchoolFee.ImageOptions.LargeImage")));
            this.bbtnSchoolFee.Name = "bbtnSchoolFee";
            this.bbtnSchoolFee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnSchoolFee_ItemClick);
            // 
            // bbtnCreateAccount
            // 
            this.bbtnCreateAccount.Caption = "TẠO TÀI KHOẢN";
            this.bbtnCreateAccount.Id = 7;
            this.bbtnCreateAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtnCreateAccount.ImageOptions.SvgImage")));
            this.bbtnCreateAccount.LargeWidth = 100;
            this.bbtnCreateAccount.Name = "bbtnCreateAccount";
            this.bbtnCreateAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnCreateAccount_ItemClick);
            // 
            // bbtnInDSSV
            // 
            this.bbtnInDSSV.Caption = "IN DANH SÁCH SINH VIÊN";
            this.bbtnInDSSV.Id = 8;
            this.bbtnInDSSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtnInDSSV.ImageOptions.SvgImage")));
            this.bbtnInDSSV.Name = "bbtnInDSSV";
            this.bbtnInDSSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnInDSSV_ItemClick);
            // 
            // bbtnInBangDiem
            // 
            this.bbtnInBangDiem.Caption = "IN BẢNG ĐIỂM";
            this.bbtnInBangDiem.Id = 9;
            this.bbtnInBangDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbtnInBangDiem.ImageOptions.SvgImage")));
            this.bbtnInBangDiem.Name = "bbtnInBangDiem";
            this.bbtnInBangDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnInBangDiem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnSubject, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbtnModifyClass);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bbtnSchoolFee);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bbtnCreateAccount);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtnInDSSV);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtnInBangDiem);
            this.ribbonPageGroup4.ItemLinks.Add(this.bbtnInDSDongTien);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            this.mvvmContext1.ViewModelType = typeof(CSDLPT.MainViewModel);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 12;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 13;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // bbtnInDSDongTien
            // 
            this.bbtnInDSDongTien.Caption = "In Danh Sách Đóng Tiền";
            this.bbtnInDSDongTien.Id = 14;
            this.bbtnInDSDongTien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.bbtnInDSDongTien.Name = "bbtnInDSDongTien";
            this.bbtnInDSDongTien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // MainView
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 676);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.Ribbon = this.ribbonControl1;
            this.Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
        private DevExpress.XtraBars.BarButtonItem bbtnSubject;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem bbtnModifyClass;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem bbtnSchoolFee;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem bbtnCreateAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bbtnInDSSV;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem bbtnInBangDiem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem bbtnInDSDongTien;
    }
}

