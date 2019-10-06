using DevExpress.UserSkins;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CSDLPT {
    static class Program {

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;
        public static String servername = string.Empty;
        public static String username = string.Empty;
        public static String mlogin = string.Empty;
        public static String password = string.Empty;

        public static String database = "QLDSV";
        public static String remotelogin = "SUPPORT_CONECT";
        public static String remotepassword = "123456";
        public static String mloginDN = string.Empty;
        public static String passwordDN = string.Empty;
        public static String mGroup = string.Empty;
        public static String mHoten = string.Empty;
        public static int mChinhanh = 0;

        public static BindingSource bds_dspm = new BindingSource(); // giữ bdsPM khi đăng nhập

        //Connect to the database
        public static int Connect() {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try {
                Program.connstr = $"Data Source={Program.servername}" +
                    $";Initial Catalog={Program.database}" +
                    $";User ID={Program.mlogin}" +
                    $";Password={Program.password}";
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e) {
                MessageBox.Show($"Lỗi kết nối CSDL. \nXem lại username và password.\n" +
                    $"{e.Message}", string.Empty, MessageBoxButtons.OK);
                return 0;
            }

        }

        //
        public static SqlDataReader ExecSqlDataReader(String command) {

            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(command, Program.conn);
            sqlcmd.CommandType = CommandType.Text;

            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (Exception e) {
                Program.conn.Close();
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public static DataTable ExecSqlDataTable(String command) {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(command, Program.conn);
            da.Fill(dt);
            Program.conn.Close();
            return dt;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Application.Run(new LoginForm());
        }
    }
}
