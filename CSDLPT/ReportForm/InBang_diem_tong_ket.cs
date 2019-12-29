using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT.ReportForm
{
    public partial class InBang_diem_tong_ket : Form
    {
        private string tenServer = string.Empty;
        public InBang_diem_tong_ket()
        {
            InitializeComponent();
        }

        private void InBang_diem_tong_ket_Load(object sender, EventArgs e)
        {
            tenServer = ((DataRowView)Program.bds_dspm.Current)["TENSERVER"].ToString();
            BindingSource bds_dsKhoa = new BindingSource();
            bds_dsKhoa.DataSource = Program.bds_dspm.DataSource;
            bds_dsKhoa.Filter = "TENPM <> 'PHÒNG KẾ TOÁN'";
            cmbKhoa.DataSource = bds_dsKhoa.DataSource;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChinhanh;
            cmbKhoa.Enabled = Program.mGroup.Equals("PGV");
            // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS_SERVER1.LOP);

        }

        private void CmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbKhoa.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Program.servername = cmbKhoa.SelectedValue.ToString();
            }

            if (cmbKhoa.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.Connect() == 0)
            {
                MessageBox.Show("Lỗi kết nối khoa mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
                this.dS_SERVER1.EnforceConstraints = false;
                this.lOPTableAdapter.Fill(this.dS_SERVER1.LOP);
                comboBox2.SelectedIndex = 0;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox2.SelectedValue.ToString());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Program.servername = tenServer;
            this.Close();
        }
    }
}
