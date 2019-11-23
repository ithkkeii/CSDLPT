using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CSDLPT.Report {
    public partial class InBangDiem : DevExpress.XtraReports.UI.XtraReport {
        public InBangDiem(string maLop, string maMH, short lan) {
            InitializeComponent();
            this.dS_SERVER11.EnforceConstraints = false;
            this.sP_INBANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_INBANGDIEMTableAdapter.Fill(dS_SERVER11.SP_INBANGDIEM, maLop, maMH, lan);
        }

    }
}
