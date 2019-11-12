using System;
using System.Linq;
using System.Windows.Forms;

namespace CSDLPT {
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm {
        public MainView() {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
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
            Form frm = this.checkExist(typeof(StudentForm));
            if (frm == null) {
                StudentForm stuForm = new StudentForm();
                stuForm.MdiParent = this;
                stuForm.Show();
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
    }
}
