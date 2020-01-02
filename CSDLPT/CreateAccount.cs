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
            if (Program.mGroup.Equals("PGV")) {
                cmbPM.DataSource = Program.bds_dspm.DataSource;
                cmbPM.DisplayMember = "TENPM";
                cmbPM.ValueMember = "TENSERVER";
                cmbPM.DropDownStyle = ComboBoxStyle.DropDownList;
            }

            ///////////////////
            Dictionary<string, string> listRole = new Dictionary<string, string>();

            if (Program.mGroup.Equals("PGV")) {
                listRole.Add("PGV", "Phòng Giáo Vụ");
                listRole.Add("KHOA", "Khoa");

                //Auto click combobox
                cmbPM.SelectedIndex = Program.mChinhanh;
                cmbPM.SelectedIndex = -1;
                cmbPM.SelectedIndex = Program.mChinhanh;
            }
            if (Program.mGroup.Equals("KHOA")) {
                listRole.Add("KHOA", "Khoa");

                //disable box chuyển khoa
                cmbPM.DataSource = Program.bds_dspm.DataSource;
                cmbPM.DisplayMember = "TENPM";
                cmbPM.ValueMember = "TENSERVER";
                cmbPM.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbPM.Enabled = false;

                //Auto click combobox
                cmbPM.SelectedIndex = Program.mChinhanh;
                cmbPM.SelectedIndex = -1;
                cmbPM.SelectedIndex = Program.mChinhanh;
            }
            if (Program.mGroup.Equals("PKETOAN")) {
                listRole.Add("PKETOAN", "Phòng Kế Toán");

                //disable box chuyển khoa
                cmbPM.DataSource = Program.bds_dspm.DataSource;
                cmbPM.DisplayMember = "TENPM";
                cmbPM.ValueMember = "TENSERVER";
                cmbPM.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbPM.Enabled = false;

                //Auto click combobox
                cmbPM.SelectedIndex = Program.mChinhanh;
                cmbPM.SelectedIndex = -1;
                cmbPM.SelectedIndex = Program.mChinhanh;
            }

            cmbRole.DataSource = listRole.ToList();
            cmbRole.DisplayMember = "Value";
            cmbRole.ValueMember = "Key";
            cmbRole.SelectedIndex = 0;

            Program.servername = cmbPM.SelectedValue.ToString();

            if (cmbPM.SelectedIndex != Program.mChinhanh) {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            } else {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.Connect() == 0) {
                MessageBox.Show("Lỗi kết nối khoa mới", "", MessageBoxButtons.OK);
            }

            DataTable dt = new DataTable();
            Console.WriteLine(Program.connstr);
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
            try {
                myReader.Close();
            } catch (Exception) {
            }
            if (myReader != null) {
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbLoginName.Text = "";
                txtbPassword.Text = "";
                //this.Close();
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

        private void cmbPM_SelectedIndexChanged(object sender, EventArgs e) {
            if (Program.mGroup.Equals("PGV")) {

                if (this.cmbPM.SelectedIndex == 2) {
                    Dictionary<string, string> listRole = new Dictionary<string, string>();

                    if (Program.mGroup.Equals("PGV")) {
                        listRole.Add("PGV", "Phòng Giáo Vụ");
                        listRole.Add("KHOA", "Khoa");
                        listRole.Add("PKETOAN", "Phòng Kế Toán");
                    }
                    cmbRole.DataSource = listRole.ToList();
                    cmbRole.DisplayMember = "Value";
                    cmbRole.ValueMember = "Key";
                    cmbRole.SelectedIndex = 2;
                    cmbRole.Enabled = false;
                } else {
                    Dictionary<string, string> listRole = new Dictionary<string, string>();

                    if (Program.mGroup.Equals("PGV")) {
                        listRole.Add("PGV", "Phòng Giáo Vụ");
                        listRole.Add("KHOA", "Khoa");
                    }
                    cmbRole.DataSource = listRole.ToList();
                    cmbRole.DisplayMember = "Value";
                    cmbRole.ValueMember = "Key";
                    cmbRole.SelectedIndex = 0;
                    cmbRole.Enabled = true;
                }

                if (this.cmbPM.SelectedIndex == -1)
                    return;

                if (cmbPM.SelectedValue.ToString() == "System.Data.DataRowView") {
                    return;
                }
                Program.servername = cmbPM.SelectedValue.ToString();

                if (cmbPM.SelectedIndex != Program.mChinhanh) {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                } else {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.Connect() == 0) {
                    MessageBox.Show("Lỗi kết nối khoa mới", "", MessageBoxButtons.OK);
                }

                DataTable dt = new DataTable();
                dt = Program.ExecSqlDataTable("EXEC SP_GIANGVIENCHUACOTAIKHOAN");
                cmbAccountOwner.Enabled = true;
                cmbAccountOwner.DataSource = dt;
                cmbAccountOwner.DisplayMember = "TEN";
                cmbAccountOwner.ValueMember = "MAGV";
                if (cmbAccountOwner.Items.Count == 0) {
                    cmbAccountOwner.ResetText();
                    cmbAccountOwner.SelectedText = "Không còn người để tạo tài khoản";
                    cmbAccountOwner.Enabled = false;
                }
                btnOk.Enabled = false;
                Console.WriteLine(Program.connstr);
            }

            if (Program.mGroup.Equals("PKETOAN")) {
                if (this.cmbRole.SelectedIndex == -1)
                    return;

                if (cmbRole.SelectedValue.ToString() == "System.Data.DataRowView") {
                    return;
                }
                Program.servername = cmbRole.SelectedValue.ToString();

                if (cmbRole.SelectedIndex != Program.mChinhanh) {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                } else {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }

                if (Program.Connect() == 0) {
                    MessageBox.Show("Lỗi kết nối khoa mới", "", MessageBoxButtons.OK);
                }
                DataTable dt = new DataTable();
                dt = Program.ExecSqlDataTable("EXEC SP_GIANGVIENCHUACOTAIKHOAN");
                cmbAccountOwner.Enabled = true;
                cmbAccountOwner.DataSource = dt;
                cmbAccountOwner.DisplayMember = "TEN";
                cmbAccountOwner.ValueMember = "MAGV";
                if (cmbAccountOwner.Items.Count == 0) {
                    cmbAccountOwner.ResetText();
                    cmbAccountOwner.SelectedText = "Không còn người để tạo tài khoản";
                    cmbAccountOwner.Enabled = false;
                }
                btnOk.Enabled = false;
                Console.WriteLine(Program.servername);
            }
        }
    }
}