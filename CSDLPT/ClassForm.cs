using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using DevExpress.XtraSpellChecker.Parser;
using DevExpress.Utils.StructuredStorage.Internal.Reader;
using DevExpress.XtraExport.Xls;

namespace CSDLPT {
    public partial class ClassForm : DevExpress.XtraEditors.XtraForm {

        private String chiNhanh = "";
        private String maKhoa = "CNTT";
        private int vitri;

        public ClassForm() {
            InitializeComponent();
            //this.ContextMenuStrip = contextMenuStrip1;
            gridView1.OptionsDetail.EnableMasterViewMode = false;
        }

        private void ClassForm_Load(object sender, EventArgs e) {
            chiNhanh = ((DataRowView)Program.bds_dspm.Current)["TENPM"].ToString();
            dS_SERVER1.EnforceConstraints = false;
            try {
                this.taSV.Connection.ConnectionString = Program.connstr;
                this.taLop.Connection.ConnectionString = Program.connstr;
                this.taKhoa.Connection.ConnectionString = Program.connstr;

                // TODO: This line of code loads data into the 'dS_SERVER1.KHOA' table. You can move, or remove it, as needed.
                this.taKhoa.Fill(this.dS_SERVER1.KHOA);
                // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
                this.taLop.Fill(this.dS_SERVER1.LOP);
                // TODO: This line of code loads data into the 'dS_SERVER1.SINHVIEN' table. You can move, or remove it, as needed.
                this.taSV.Fill(this.dS_SERVER1.SINHVIEN);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            this.cmbKhoaInUse.DataSource = Program.bds_dspm.DataSource;
            this.cmbKhoaInUse.DisplayMember = "TENPM";
            this.cmbKhoaInUse.ValueMember = "TENSERVER";
            this.cmbKhoaInUse.SelectedIndex = 1;
            this.cmbKhoaInUse.Enabled = false;

            //Button control
            bbtnAdd.Enabled = true;
            bbtnEdit.Enabled = true;
            bbtnRemove.Enabled = true;
            bbtnWrite.Enabled = false;
            bbtnRecovery.Enabled = false;

            //View control
            gcLop.Enabled = true;
            groupBox1.Enabled = false;
            dgvSV.Enabled = true;
            dgvSV.ReadOnly = true;
        }

        private void barButtonAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //Vị trí của item chọn
            vitri = bdsLop.Position;
            groupBox1.Enabled = true;
            gcLop.Enabled = false;
            bdsLop.AddNew();
            txbMaKhoa.Text = maKhoa;
            txbMaLop.ReadOnly = false;

            //Bar button control
            bbtnAdd.Enabled = false;
            bbtnEdit.Enabled = false;
            bbtnRemove.Enabled = false;
            bbtnRecovery.Enabled = true;
            bbtnWrite.Enabled = true;
        }

        private void bbtnWrite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            //Validate
            txbMaLop.Text = Regex.Replace(txbMaLop.Text.Trim(), @"\s+", "");
            txbTenLop.Text = Regex.Replace(txbTenLop.Text.Trim(), @"\s+", " ");
            if (txbMaLop.Text == "") {
                MessageBox.Show("Mã lớp không được để trống!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbMaLop.Focus();
                return;
            }
            if (txbMaLop.Text.Length > 8) {
                MessageBox.Show("Mã lớp phải nhỏ hơn hoặc bằng 8 ký tự!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbMaLop.Focus();
                return;
            }
            if (txbTenLop.Text == "") {
                MessageBox.Show("Tên lớp không được để trống!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTenLop.Focus();
                return;
            }
            if (txbTenLop.Text.Length > 40) {
                MessageBox.Show("Tên lớp phải nhỏ hơn hoặc bằng 40 ký tự!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTenLop.Focus();
                return;
            }

            //Update database
            try {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                if (dS_SERVER1.HasChanges())
                    taLop.Update(dS_SERVER1.LOP);

            } catch (SqlException err) {
                Console.WriteLine(err.Message);
                if (err.Message.Contains("PRIMARY")) {
                    MessageBox.Show("Mã lớp bị trùng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMaLop.Focus();
                    return;
                } else if (err.Message.Contains("UNIQUE")) {
                    MessageBox.Show("Tên lớp bị trùng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbTenLop.Focus();
                    return;
                } else {
                    MessageBox.Show("Lỗi tạo lớp, vui lòng xem lại!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //Button control
            bbtnAdd.Enabled = true;
            bbtnEdit.Enabled = true;
            bbtnRecovery.Enabled = true;
            bbtnRemove.Enabled = true;
            bbtnWrite.Enabled = false;
            gcLop.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void bbtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            bbtnAdd.Enabled = false;
            bbtnEdit.Enabled = false;
            bbtnRemove.Enabled = false;
            bbtnWrite.Enabled = true;
            bbtnRecovery.Enabled = true;
            //bbtnRefresh.Enable = true;
            groupBox1.Enabled = true;
            gcLop.Enabled = false;
            vitri = bdsLop.Position;
            return;
        }

        private void bbtnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (bdsSV.Count > 0) {
                MessageBox.Show("Lớp có sinh viên không được xóa!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa lớp này?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes) {
                try {
                    bdsLop.RemoveCurrent();
                    taLop.Update(dS_SERVER1.LOP);
                    return;
                } catch (Exception err) {
                    Console.WriteLine(err.Message);
                    MessageBox.Show("Lỗi xóa lớp!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            return;
        }

        private void bbtnRecovery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            bdsLop.CancelEdit();
            bdsLop.Position = vitri;
            gcLop.Enabled = true;
            groupBox1.Enabled = false;

            //Button control
            bbtnAdd.Enabled = true;
            bbtnEdit.Enabled = true;
            bbtnRemove.Enabled = true;
            bbtnWrite.Enabled = false;
            bbtnRecovery.Enabled = false;
        }

        private void tsAdd_Click(object sender, EventArgs e) {

            bdsSV.AddNew();

            //Button control
            bbtnAdd.Enabled = false;
            bbtnEdit.Enabled = false;
            bbtnRemove.Enabled = false;
            bbtnWrite.Enabled = false;
            bbtnRecovery.Enabled = false;

            tsAdd.Enabled = false;
            tsEdit.Enabled = false;
            tsRemove.Enabled = false;
            tsWrite.Enabled = true;
            tsRecovery.Enabled = true;
            tsChangeClass.Enabled = false;


            //View control
            gcLop.Enabled = false;
            groupBox1.Enabled = false;
            dgvSV.Enabled = true;
            dgvSV.ReadOnly = false;
            dgvtxbMaLop.ReadOnly = true;

            //foreach (DataGridViewRow row in dgvSV.Rows) {
            //    row.ReadOnly = true;
            //}

            for (int i = 0; i < dgvSV.Rows.Count - 1; i++) {
                dgvSV.Rows[i].ReadOnly = true;
            }

            return;
        }

        private void tsEdit_Click(object sender, EventArgs e) {
            //Button control
            bbtnAdd.Enabled = false;
            bbtnEdit.Enabled = false;
            bbtnRemove.Enabled = false;
            bbtnWrite.Enabled = false;
            bbtnRecovery.Enabled = false;

            tsAdd.Enabled = false;
            tsEdit.Enabled = false;
            tsRemove.Enabled = false;
            tsWrite.Enabled = true;
            tsRecovery.Enabled = true;
            tsChangeClass.Enabled = false;

            //View control
            gcLop.Enabled = false;
            groupBox1.Enabled = false;
            dgvSV.Enabled = true;
            dgvSV.ReadOnly = false;
            dgvtxbMaLop.ReadOnly = true;
            return;
        }

        private void tsWrite_Click(object sender, EventArgs e) {

            //Validate
            Console.WriteLine(dgvtxbMaSV.ToString());

            try {
                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                if (dS_SERVER1.HasChanges())
                    taSV.Update(dS_SERVER1.SINHVIEN);
            } catch (Exception err) {
                Console.WriteLine(err.Message);
                if (err.Message.Contains("PRIMARY")) {
                    MessageBox.Show("Mã sinh viên bị trùng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else {
                    MessageBox.Show("Lỗi tạo sinh viên, vui lòng xem lại!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            //----> Write to db success
            //Button control
            bbtnAdd.Enabled = true;
            bbtnEdit.Enabled = true;
            bbtnRemove.Enabled = true;
            bbtnWrite.Enabled = false;
            bbtnRecovery.Enabled = false;

            tsAdd.Enabled = true;
            tsEdit.Enabled = true;
            tsRemove.Enabled = true;
            tsWrite.Enabled = false;
            tsRecovery.Enabled = false;
            tsChangeClass.Enabled = true;

            //View control
            gcLop.Enabled = true;
            groupBox1.Enabled = false;
            dgvSV.Enabled = true;
            dgvSV.ReadOnly = true;
            dgvtxbMaLop.ReadOnly = true;
        }

        private void dgvSV_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) {
            string headerText = dgvSV.Columns[e.ColumnIndex].HeaderText;


            //Validation if cell is in the MASV column
            if (headerText.Equals("MASV")) {
                validateStringField("MASV", 10, e, false);
            }

            if (headerText.Equals("HO")) {
                validateStringField("HO", 40, e);
            }

            if (headerText.Equals("TEN")) {
                validateStringField("TEN", 10, e);
            }

            if (headerText.Equals("NGAYSINH")) {
                DateTime dateTime;
                try {
                    dateTime = Convert.ToDateTime(e.FormattedValue.ToString());
                } catch (Exception ex) {
                    MessageBox.Show("Ngày sinh không hợp lệ!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine(ex.Message);
                    e.Cancel = true;
                    return;
                }

                //Cell is not empty
                if (string.IsNullOrEmpty(e.FormattedValue.ToString())) {
                    dgvSV.Rows[e.RowIndex].ErrorText = "NGAYSINH không được rỗng!";
                    e.Cancel = true;
                }

                //Năm sinh <= 1900
                if (dateTime.Year < 1900) {
                    dgvSV.Rows[e.RowIndex].ErrorText = "Năm sinh phải lớn hơn 1900!";
                    e.Cancel = true;
                }
            }

            if (headerText.Equals("NOISINH")) {
                validateStringField("NOISINH", 40, e);
            }

            if (headerText.Equals("DIACHI")) {
                validateStringField("DIACHI", 80, e);
            }
        }

        private void validateStringField(String field, int condition, DataGridViewCellValidatingEventArgs e, bool isNullable = true) {
            //Cell is not empty
            if (!isNullable && string.IsNullOrEmpty(e.FormattedValue.ToString())) {
                dgvSV.Rows[e.RowIndex].ErrorText = $"{field} không được rỗng!";
                MessageBox.Show($"{field} không được rỗng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }

            if (e.FormattedValue.ToString().Length > condition) {
                dgvSV.Rows[e.RowIndex].ErrorText = $"{field} không được nhiều hơn {condition} ký tự!";
                MessageBox.Show($"{field} không được nhiều hơn {condition} ký tự!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void dgvSV_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            string value = "";

            dgvSV.Rows[e.RowIndex].ErrorText = string.Empty;
            //value = dgvSV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim();
            //dgvSV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value;

            if (dgvSV.Columns[e.ColumnIndex].HeaderText.Equals("MASV")) {
                value = dgvSV.Rows[e.RowIndex]
                    .Cells[e.ColumnIndex]
                    .Value
                    .ToString()
                    .Trim();
                value = Regex.Replace(value, @"\s+", "");
                value = Regex.Replace(value, "[^0-9a-zA-Z]+", "");
                dgvSV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value;
            }

            if (dgvSV.Columns[e.ColumnIndex].HeaderText.Equals("HO") ||
                dgvSV.Columns[e.ColumnIndex].HeaderText.Equals("TEN")) {
                value = dgvSV.Rows[e.RowIndex]
                    .Cells[e.ColumnIndex]
                    .Value
                    .ToString()
                    .Trim();
                value = Regex.Replace(value, @"\s+", " ");
                value = Regex.Replace(value, "[/\\,;:.`?{}[\\]=+<>@#$%^&*]+", "");
                dgvSV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value;
            }

            if (dgvSV.Columns[e.ColumnIndex].HeaderText.Equals("NOISINH") ||
                dgvSV.Columns[e.ColumnIndex].HeaderText.Equals("DIACHI")) {
                value = dgvSV.Rows[e.RowIndex]
                    .Cells[e.ColumnIndex]
                    .Value
                    .ToString()
                    .Trim();
                value = Regex.Replace(value, @"\s+", " ");
                value = Regex.Replace(value, "[\\;:`?{}[\\]=+<>@#$%^&*]+", "");
                dgvSV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value;
            }
        }

        //private void dgvSV_DataError(object sender, DataGridViewDataErrorEventArgs e) {
        //    MessageBox.Show("Error happened " + e.Context.ToString());
        //}
    }
}