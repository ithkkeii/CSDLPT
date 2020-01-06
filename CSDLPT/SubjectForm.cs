using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CSDLPT {
    public partial class SubjectForm : Form {
        private int vitri;
        public SubjectForm() {
            InitializeComponent();
        }

        private void MONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.bdsMONHOC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SERVER1);

        }

        private void SubjectForm_Load(object sender, EventArgs e) {

            dS_SERVER1.EnforceConstraints = false;
            gridView1.OptionsDetail.EnableMasterViewMode = false;


            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.dS_SERVER1.DIEM);


            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS_SERVER1.MONHOC);

            //button control
            this.barButtonSaveSubject.Enabled = false;
            this.groupControlSubject.Enabled = false;
            this.barButtonUndoSubject.Enabled = false;
        }

        private void BarButtonAddSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            vitri = bdsMONHOC.Position;
            this.groupControlSubject.Enabled = true;
            this.mONHOCGridControl.Enabled = false;
            bdsMONHOC.AddNew();
            this.barButtonSaveSubject.Enabled = true;
            this.barButtonUndoSubject.Enabled = true;
            this.barButtonAddSubject.Enabled = false;
            this.barButtonDelSubject.Enabled = false;
            this.barButtonEditSubject.Enabled = false;
            this.mAMHTextEdit.ReadOnly = false;

        }

        private void BarButtonSaveSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (mAMHTextEdit.Text == "") {
                MessageBox.Show("Mã môn học không được để trống!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                mAMHTextEdit.Focus();
                return;
            }
            if (mAMHTextEdit.Text.Length > 6) {
                MessageBox.Show("Mã môn học phải nhỏ hơn hoặc bằng 6 ký tự!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                mAMHTextEdit.Focus();
                return;
            }
            if (tENMHTextEdit.Text == "") {
                MessageBox.Show("Tên môn học không được để trống!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tENMHTextEdit.Focus();
                return;
            }
            if (tENMHTextEdit.Text.Length > 40) {
                MessageBox.Show("Tên môn học phải nhỏ hơn hoặc bằng 40 ký tự!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tENMHTextEdit.Focus();
                return;
            }
            if (!Regex.IsMatch(mAMHTextEdit.Text, "[a-zA-Z0-9]*")) {
                MessageBox.Show("Mã môn học chỉ đc chứa các ký tự a-z A-z và các chữ số!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                mAMHTextEdit.Focus();
                return;

            }


            try {
                bdsMONHOC.EndEdit();
                bdsMONHOC.ResetCurrentItem();
                if (dS_SERVER1.HasChanges())
                    mONHOCTableAdapter.Update(dS_SERVER1.MONHOC);

            } catch (Exception err) {
                Console.WriteLine(err.Message);
                if (err.Message.Contains("Column 'MAMH' is constrained to be unique")) {
                    MessageBox.Show("Mã môn học bị trùng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mAMHTextEdit.Focus();
                    return;
                } else if (err.Message.Contains("UNIQUE")) {
                    MessageBox.Show("Tên môn học bị trùng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tENMHTextEdit.Focus();
                    return;
                } else {
                    MessageBox.Show("Lỗi tạo mới Môn học, vui lòng xem lại!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            barButtonAddSubject.Enabled = barButtonEditSubject.Enabled = barButtonDelSubject.Enabled = mONHOCGridControl.Enabled = true;
            barButtonSaveSubject.Enabled = groupControlSubject.Enabled = false;
            this.mAMHTextEdit.ReadOnly = true;
        }

        private void BarButtonDelSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            if (dIEMBindingSource.Count > 0) {
                MessageBox.Show("Không được xóa môn học này!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes) {
                try {
                    bdsMONHOC.RemoveCurrent();
                    mONHOCTableAdapter.Update(dS_SERVER1.MONHOC);
                    return;
                } catch (Exception err) {

                    MessageBox.Show("Lỗi xóa môn học!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void BarButtonEditSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            this.mAMHTextEdit.ReadOnly = true;

            barButtonAddSubject.Enabled = barButtonDelSubject.Enabled = barButtonEditSubject.Enabled = false;
            groupControlSubject.Enabled = true;
            this.barButtonSaveSubject.Enabled = true;
            this.barButtonUndoSubject.Enabled = true;
            tENMHTextEdit.Focus();
            vitri = bdsMONHOC.Position;

        }

        private void BarButtonUndoSubject_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            bdsMONHOC.CancelEdit();
            bdsMONHOC.Position = vitri;
            groupControlSubject.Enabled = false;
            mONHOCGridControl.Enabled = true;
            //Button control
            barButtonAddSubject.Enabled = true;
            barButtonEditSubject.Enabled = true;
            barButtonDelSubject.Enabled = true;
            barButtonUndoSubject.Enabled = false;
            barButtonSaveSubject.Enabled = false;
        }

        private void BarButtonExitSubjectForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            this.Close();
        }
    }
}