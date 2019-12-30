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
using CSDLPT.Report;
using DevExpress.XtraReports.UI;

namespace CSDLPT.ReportForm {
    public partial class InDanh_sach_thi_het_mon : Form {
        private String tenPhanManh = string.Empty;
        private string tenServer = string.Empty;
        public InDanh_sach_thi_het_mon() {
            InitializeComponent();
        }

        private void InDanh_sach_thi_het_mon_Load(object sender, EventArgs e) {

            tenPhanManh = ((DataRowView)Program.bds_dspm.Current)["TENPM"].ToString();
            tenServer = ((DataRowView)Program.bds_dspm.Current)["TENSERVER"].ToString();
            // TODO: This line of code loads data into the 'dS_SERVER1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS_SERVER1.MONHOC);
            // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
            // chọn khoa
            BindingSource bds_dsKhoa = new BindingSource();
            bds_dsKhoa.DataSource = Program.bds_dspm.DataSource;
            bds_dsKhoa.Filter = "TENPM <> 'PHÒNG KẾ TOÁN'";
            cmbKhoa.DataSource = bds_dsKhoa.DataSource;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedIndex = Program.mChinhanh;
            cmbKhoa.Enabled = Program.mGroup.Equals("PGV");
        }

        private void BtnInbaocao_Click(object sender, EventArgs e) {
            Danh_sach_thi_het_mon dsthm = new Danh_sach_thi_het_mon(tENLOPComboBox.SelectedValue.ToString());
            dsthm.lblLop.Text = tENLOPComboBox.Text;
            dsthm.lblMonhoc.Text = tENMHComboBox.Text;
            dsthm.lblNgaythi.Text = dateTimePicker1.Value.Date.ToString("dd-MM-yyyy");
            ReportPrintTool print = new ReportPrintTool(dsthm);
            print.ShowPreviewDialog();

        }

        private void CmbKhoa_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.cmbKhoa.SelectedValue.ToString() != "System.Data.DataRowView") {
                Program.servername = cmbKhoa.SelectedValue.ToString();
            }

            if (cmbKhoa.SelectedIndex != Program.mChinhanh) {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            } else {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.Connect() == 0) {
                MessageBox.Show("Lỗi kết nối khoa mới", "", MessageBoxButtons.OK);
            } else {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
                this.dS_SERVER1.EnforceConstraints = false;
                this.lOPTableAdapter.Fill(this.dS_SERVER1.LOP);
                tENLOPComboBox.SelectedIndex = 0;
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e) {
            Program.servername = tenServer;
            this.Close();
        }
    }
}