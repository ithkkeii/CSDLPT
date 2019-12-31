using CSDLPT.ReportForm;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CSDLPT {
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm {

        public Form RefToLoginForm { get; set; }

        public MainView() {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();

            //Authorize
            if (Program.mGroup.Equals("PKETOAN")) {
                bbtnSubject.Enabled = false;
                bbtnModifyClass.Enabled = false;
                bbtnModifyMark.Enabled = false;
                bbtnCreateAccount.Enabled = true;
                bbtnSchoolFee.Enabled = true;
                bbtnInDSSV.Enabled = false;
                bbtnInBangDiem.Enabled = false;
                bbtnInDSDongTien.Enabled = true;
            }
            if (Program.mGroup.Equals("PGV")) {
                bbtnSubject.Enabled = true;
                bbtnModifyClass.Enabled = true;
                bbtnModifyMark.Enabled = true;
                bbtnCreateAccount.Enabled = true;
                bbtnSchoolFee.Enabled = false;
                bbtnInDSSV.Enabled = true;
                bbtnInBangDiem.Enabled = true;
                bbtnInDSDongTien.Enabled = false;
            }
            if (Program.mGroup.Equals("KHOA")) {
                bbtnSubject.Enabled = false;
                bbtnModifyClass.Enabled = false;
                bbtnModifyMark.Enabled = true;
                bbtnCreateAccount.Enabled = true;
                bbtnSchoolFee.Enabled = false;
                bbtnInDSSV.Enabled = true;
                bbtnInBangDiem.Enabled = true;
                bbtnInDSDongTien.Enabled = false;
            }
        }

        void InitializeBindings() {
            _ = mvvmContext1.OfType<MainViewModel>();
        }

        //Check if view exist
        private Form checkExist(Type formType) {
            foreach (var item in this.MdiChildren) {
                if (item.GetType() == formType) {
                    //Console.WriteLine(item.GetType());
                    //Console.WriteLine($"{item.GetType()} == {formType}");
                    return item;
                }
            }
            return null;
        }

        private void barButtonSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Form frm = this.checkExist(typeof(SubjectForm));
            if (frm == null) {
                SubjectForm subForm = new SubjectForm();
                subForm.MdiParent = this;
                subForm.Show();
            } else
                frm.Activate();
        }

        private void barButtonModifyClass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Form frm = this.checkExist(typeof(ClassForm));
            if (frm == null) {
                ClassForm stuForm = new ClassForm();
                stuForm.MdiParent = this;
                stuForm.Show();
            } else
                frm.Activate();
        }

        private void bbtnSchoolFee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Form frm = this.checkExist(typeof(SchoolFee));
            if (frm == null) {
                SchoolFee schoolFeeForm = new SchoolFee();
                schoolFeeForm.MdiParent = this;
                schoolFeeForm.Show();
            } else
                frm.Activate();
        }

        private void bbtnCreateAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Form frm = this.checkExist(typeof(CreateAccount));
            if (frm == null) {
                CreateAccount createAccountForm = new CreateAccount();
                createAccountForm.MdiParent = this;
                createAccountForm.Show();
            } else
                frm.Activate();
        }

        private void bbtnInDSSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Form frm = this.checkExist(typeof(InDSSV));
            if (frm == null) {
                InDSSV inDSSV = new InDSSV();
                inDSSV.MdiParent = this;
                inDSSV.Show();
            } else
                frm.Activate();
        }

        private void bbtnInBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Form frm = this.checkExist(typeof(InBD));
            if (frm == null) {
                InBD inBangDiem = new InBD();
                inBangDiem.MdiParent = this;
                inBangDiem.Show();
            } else
                frm.Activate();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Form frm = this.checkExist(typeof(InDSDongHocPhi));
            if (frm == null) {
                InDSDongHocPhi inDanhSachDongTien = new InDSDongHocPhi();
                inDanhSachDongTien.MdiParent = this;
                inDanhSachDongTien.Show();
            } else
                frm.Activate();
        }

        private void bbtnModifyMark_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Form frm = this.checkExist(typeof(MarkForm));
            if (frm == null) {
                MarkForm markForm = new MarkForm();
                markForm.MdiParent = this;
                markForm.Show();
            } else
                frm.Activate();
        }

        private void bbtnThiHetMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Form frm = this.checkExist(typeof(InDanh_sach_thi_het_mon));
            if (frm == null) {
                InDanh_sach_thi_het_mon form = new InDanh_sach_thi_het_mon();
                form.MdiParent = this;
                form.Show();
            } else
                frm.Activate();
        }

        private void bbtnPhieuDiemCaNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Form frm = this.checkExist(typeof(InPhieu_diem_ca_nhan));
            if (frm == null) {
                InPhieu_diem_ca_nhan form = new InPhieu_diem_ca_nhan();
                form.MdiParent = this;
                form.Show();
            } else
                frm.Activate();
        }

        private void bbtnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn đăng xuất?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes) {
                Program.conn = new SqlConnection();
                Program.servername = string.Empty;
                Program.username = string.Empty;
                Program.mlogin = string.Empty;
                Program.password = string.Empty;

                Program.mloginDN = string.Empty;
                Program.passwordDN = string.Empty;
                Program.mGroup = string.Empty;
                Program.mHoten = string.Empty;
                Program.mChinhanh = 0;

                this.Close();
                RefToLoginForm.Show();
            } else {
                return;
            }
        }
    }
}
