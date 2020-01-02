using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CSDLPT {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) {
            string connectionStr = "Data Source=DESKTOP-0VD6HF8;" +
               "Initial Catalog=QLDSV;" +
               "Integrated Security=True";
            Program.conn.ConnectionString = connectionStr;
            Program.conn.Open();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DSPM");
            Program.bds_dspm.DataSource = dt;
            cmbPM.DataSource = dt;
            cmbPM.DisplayMember = "TENPM";
            cmbPM.ValueMember = "TENSERVER";
            cmbPM.DropDownStyle = ComboBoxStyle.DropDownList;

            //Auto click combobox
            cmbPM.SelectedIndex = 0;
            cmbPM.SelectedIndex = 1;
            cmbPM.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (tbUsername.Text.Trim() == string.Empty || tbPassword.Text.Trim() == string.Empty) {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!", string.Empty, MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = tbUsername.Text;
            Program.password = tbPassword.Text;
            if (Program.Connect() == 0)
                return;
            Program.mChinhanh = cmbPM.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = $"EXEC SP_DANGNHAP '{Program.mlogin}'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null)
                return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username)) {
                MessageBox.Show($"Bạn không có quyền truy cập dữ liệu \n Xem lại username,password.", string.Empty, MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            //MessageBox.Show($"Giang Vien - Nhom : {Program.mHoten} - {Program.mGroup}", "", MessageBoxButtons.OK);
            this.Hide();
            MainView mv = new MainView();
            mv.RefToLoginForm = this;
            mv.bsiMaGV.Caption = Program.username;
            mv.bsiTenGV.Caption = Program.mHoten;
            mv.bsiNhom.Caption = Program.mGroup;
            mv.Show();
        }

        private void cmbPM_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                Program.servername = cmbPM.SelectedValue.ToString();
            } catch (Exception) {
            }
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                btnLogin_Click(sender, e);
            }
        }

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                btnLogin_Click(sender, e);
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                btnLogin_Click(sender, e);
            }
        }

        private void cmbPM_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                btnLogin_Click(sender, e);
            }
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e) {
            LoginForm_Load(sender, e);
        }
    }
}
