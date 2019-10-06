using System;
using System.Linq;

namespace CSDLPT {
    public partial class StudentForm : DevExpress.XtraEditors.XtraForm {
        public StudentForm() {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e) {
            // Ngừng check các khóa ngoại
            dS_SERVER1.EnforceConstraints = false;
            try {
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS_SERVER1.SINHVIEN' table. You can move, or remove it, as needed.
                this.sINHVIENTableAdapter.Fill(this.dS_SERVER1.SINHVIEN);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void barButtonAddStudent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        private void sINHVIENGridControl_Click(object sender, EventArgs e) {

        }
    }
}