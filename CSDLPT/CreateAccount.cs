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
using DevExpress.XtraReports.Native.Data;
using DevExpress.XtraBars.Controls;
using System.Data.SqlClient;

namespace CSDLPT {
    public partial class CreateAccount : DevExpress.XtraEditors.XtraForm {
        public CreateAccount() {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e) {
            Dictionary<string, string> listRole = new Dictionary<string, string>();

            if (Program.mGroup.Equals("PGV")) {
                listRole.Add("PGV", "Phòng Giáo Vụ");
                listRole.Add("KHOA", "Khoa");
                //listRole.Add("PKETOAN", "Phòng Kế Toán");
            }
            if (Program.mGroup.Equals("KHOA")) {
                listRole.Add("KHOA", "Khoa");
            }
            if (Program.mGroup.Equals("PKETOAN")) {
                listRole.Add("PKETOAN", "Phòng Kế Toán");
            }

            cmbRole.DataSource = listRole.ToList();
            cmbRole.DisplayMember = "Value";
            cmbRole.ValueMember = "Key";
            cmbRole.SelectedIndex = 0;

            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("EXEC SP_GIANGVIENCHUACOTAIKHOAN");
            cmbAccountOwner.DataSource = dt;
            cmbAccountOwner.DisplayMember = "TEN";
            cmbAccountOwner.ValueMember = "MAGV";
            if (cmbAccountOwner.Items.Count == 0) {
                cmbAccountOwner.SelectedText = "Không còn người để tạo tài khoản";
                cmbAccountOwner.Enabled = false;
            }
            btnOk.Enabled = false;
        }

        private void cmbAccountOwner_SelectedIndexChanged(object sender, EventArgs e) {
            int? seleted = cmbAccountOwner.SelectedIndex;
            if (seleted != null && seleted != -1 && !txtbLoginName.Text.Equals("") && !txtbPassword.Text.Equals(""))
                btnOk.Enabled = true;
            else
                btnOk.Enabled = false;
        }

        private void cmbAccountOwner_KeyUp(object sender, KeyEventArgs e) {
            int? seleted = cmbAccountOwner.SelectedIndex;
            if (seleted != null && seleted != -1 && !txtbLoginName.Text.Equals("") && !txtbPassword.Text.Equals(""))
                btnOk.Enabled = true;
            else
                btnOk.Enabled = false;
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e) {
        }

        private void btnOk_Click(object sender, EventArgs e) {
            string query = $"EXEC SP_TAOTAIKHOAN " +
                $"'{txtbLoginName.Text}', " +
                $"'{txtbPassword.Text}', " +
                $"'{cmbAccountOwner.SelectedValue.ToString().Trim()}', " +
                $"'{cmbRole.SelectedValue.ToString()}'";
            SqlDataReader myReader = Program.ExecSqlDataReader(query);
            if (myReader != null) {
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbLoginName.Text = "";
                txtbPassword.Text = "";
            }
            return;
        }

        private void txtbLoginName_KeyUp(object sender, KeyEventArgs e) {
            int? seleted = cmbAccountOwner.SelectedIndex;
            if (seleted != null && seleted != -1 && !txtbLoginName.Text.Equals("") && !txtbPassword.Text.Equals("")) {
                btnOk.Enabled = true;
            } else
                btnOk.Enabled = false;
        }

        private void txtbPassword_KeyUp(object sender, KeyEventArgs e) {
            int? seleted = cmbAccountOwner.SelectedIndex;
            if (seleted != null && seleted != -1 && !txtbLoginName.Text.Equals("") && !txtbPassword.Text.Equals("")) {
                btnOk.Enabled = true;
            } else
                btnOk.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}