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
    public partial class InDSSV : DevExpress.XtraEditors.XtraForm {
        private string khoa = "";
        private string tenServer = string.Empty;

        public InDSSV() {
            InitializeComponent();
        }

        private void InDSSV_Load(object sender, EventArgs e) {
            tenServer = ((DataRowView)Program.bds_dspm.Current)["TENSERVER"].ToString();
            dS_SERVER1.EnforceConstraints = false;
            this.taLop.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
            this.taLop.Fill(this.dS_SERVER1.LOP);
            BindingSource bds_dspm_currentForm = new BindingSource();
            bds_dspm_currentForm.DataSource = Program.bds_dspm.DataSource;
            if (bds_dspm_currentForm.Count.Equals(3))
                bds_dspm_currentForm.RemoveAt(bds_dspm_currentForm.Count - 1);

            this.cmbChiNhanh.DataSource = bds_dspm_currentForm.DataSource;
            this.cmbChiNhanh.DisplayMember = "TENPM";
            this.cmbChiNhanh.ValueMember = "TENSERVER";
            this.cmbChiNhanh.Enabled = true;

            //auto click combobox
            this.cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            this.cmbChiNhanh.SelectedIndex = -1;
            this.cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            cmbChiNhanh.Enabled = Program.mGroup.Equals("PGV");
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e) {
            int? seleted = cmbLop.SelectedIndex;
            if (seleted != null && seleted != -1)
                btnOk.Enabled = true;
            else
                btnOk.Enabled = false;
        }

        private void cmbLop_KeyUp(object sender, KeyEventArgs e) {
            int? seleted = cmbLop.SelectedIndex;
            if (seleted != null && seleted != -1)
                btnOk.Enabled = true;
            else
                btnOk.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e) {

            if (bdsLop.Count != 0) {
                khoa = ((DataRowView)bdsLop[0])["MAKH"].ToString();
            }
            InDanhSachSinhVienLop rpt = new InDanhSachSinhVienLop(khoa, cmbLop.SelectedValue.ToString());
            rpt.lbLop.Text = cmbLop.SelectedValue.ToString();
            rpt.lbTenLop.Text = cmbLop.Text;
            rpt.lbKhoa.Text = khoa;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.cmbChiNhanh.SelectedIndex == -1)
                return;

            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") {
                return;
            }
            Program.servername = cmbChiNhanh.SelectedValue.ToString();

            if (cmbChiNhanh.SelectedIndex != Program.mChinhanh) {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            } else {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.Connect() == 0) {
                MessageBox.Show("Lỗi kết nối khoa mới", "", MessageBoxButtons.OK);
            } else {
                try {
                    this.taLop.Connection.ConnectionString = Program.connstr;
                    // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
                    this.taLop.Fill(this.dS_SERVER1.LOP);
                    if (cmbLop.Items.Count > 0) {
                        cmbLop.SelectedIndex = -1;
                        cmbLop.SelectedIndex = 0;
                    }
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }

            //Gán Mã Khoa
            if (bdsLop.Count > 0)
                khoa = ((DataRowView)bdsLop[0])["MAKH"].ToString();
            else {
                if (cmbChiNhanh.SelectedIndex == 0)
                    khoa = "CNTT";
                if (cmbChiNhanh.SelectedIndex == 1)
                    khoa = "VT";
            }
        }

        private void InDSSV_FormClosing(object sender, FormClosingEventArgs e) {
            //Program.servername = tenServer;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}