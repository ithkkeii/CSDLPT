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
using DevExpress.XtraReports.UI;
using CSDLPT.Report;

namespace CSDLPT.ReportForm {
    public partial class InBD : DevExpress.XtraEditors.XtraForm {
        private string khoa = "";
        private string tenServer = string.Empty;

        public InBD() {
            InitializeComponent();
        }

        private void InBangDiem_Load(object sender, EventArgs e) {
            tenServer = ((DataRowView)Program.bds_dspm.Current)["TENSERVER"].ToString();
            dS_SERVER1.EnforceConstraints = false;
            this.taLop.Connection.ConnectionString = Program.connstr;
            this.taMonHoc.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
            this.taLop.Fill(this.dS_SERVER1.LOP);
            // TODO: This line of code loads data into the 'dS_SERVER1.MONHOC' table. You can move, or remove it, as needed.
            this.taMonHoc.Fill(this.dS_SERVER1.MONHOC);

            BindingSource bds_dspm_currentForm = new BindingSource();
            bds_dspm_currentForm.DataSource = Program.bds_dspm.DataSource;
            bds_dspm_currentForm.Filter = $"TENPM LIKE '{Program.prefix}*'";

            this.cmbChiNhanh.DataSource = bds_dspm_currentForm.DataSource;
            this.cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            this.cmbChiNhanh.DisplayMember = "TENPM";
            this.cmbChiNhanh.ValueMember = "TENSERVER";
            this.cmbChiNhanh.Enabled = true;
            this.cmbChiNhanh.SelectedIndex = 0;

            //Lần thi gán sẵn 
            this.cmbLanThi.SelectedIndex = -1;
            this.cmbLanThi.SelectedIndex = 0;
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbChiNhanh.SelectedValue.ToString() != "System.Data.DataRowView") {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
            }

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

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e) {
            int? seletedLop = cmbLop.SelectedIndex;
            int? seletedMonHoc = cmbMonHoc.SelectedIndex;
            if (seletedLop != null && seletedLop != -1 && seletedMonHoc != null && seletedMonHoc != -1)
                btnOk.Enabled = true;
            else
                btnOk.Enabled = false;
        }

        private void cmbLop_KeyUp(object sender, KeyEventArgs e) {
            int? seletedLop = cmbLop.SelectedIndex;
            int? seletedMonHoc = cmbMonHoc.SelectedIndex;
            if (seletedLop != null && seletedLop != -1 && seletedMonHoc != null && seletedMonHoc != -1)
                btnOk.Enabled = true;
            else
                btnOk.Enabled = false;
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e) {
            int? seletedLop = cmbLop.SelectedIndex;
            int? seletedMonHoc = cmbMonHoc.SelectedIndex;
            if (seletedLop != null && seletedLop != -1 && seletedMonHoc != null && seletedMonHoc != -1)
                btnOk.Enabled = true;
            else
                btnOk.Enabled = false;
        }

        private void cmbMonHoc_KeyUp(object sender, KeyEventArgs e) {
            int? seletedLop = cmbLop.SelectedIndex;
            int? seletedMonHoc = cmbMonHoc.SelectedIndex;
            if (seletedLop != null && seletedLop != -1 && seletedMonHoc != null && seletedMonHoc != -1)
                btnOk.Enabled = true;
            else
                btnOk.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e) {
            if (bdsLop.Count != 0) {
                khoa = ((DataRowView)bdsLop[0])["MAKH"].ToString();
            }
            InBangDiem rpt = new InBangDiem(cmbLop.SelectedValue.ToString(), cmbMonHoc.SelectedValue.ToString(), short.Parse(cmbLanThi.Text));
            rpt.lbLop.Text = cmbLop.Text.Trim();
            rpt.lbMaLop.Text = cmbLop.SelectedValue.ToString();
            rpt.lbMonHoc.Text = cmbMonHoc.Text.Trim();
            rpt.lbLanThi.Text = cmbLanThi.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void InBD_FormClosing(object sender, FormClosingEventArgs e) {
            Program.servername = tenServer;
        }
    }
}