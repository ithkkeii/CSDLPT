using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CSDLPT.Report {
    public partial class Phieu_diem_ca_nhan : DevExpress.XtraReports.UI.XtraReport {
        public Phieu_diem_ca_nhan(string masinhvien) {
            InitializeComponent();
            dS_SERVER11.EnforceConstraints = false;
            this.rPT_PHIEU_DIEM_CA_NHANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.rPT_PHIEU_DIEM_CA_NHANTableAdapter.Fill(dS_SERVER11.RPT_PHIEU_DIEM_CA_NHAN, masinhvien);
        }
    }
}
