
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CSDLPT.Report {
    public partial class Bang_diem_tong_ket : DevExpress.XtraReports.UI.XtraReport {
        public Bang_diem_tong_ket(String malop) {
            InitializeComponent();
            dS_SERVER11.EnforceConstraints = false;
            this.rpT_BANG_DIEM_TONG_KET_CA_LOPTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.rpT_BANG_DIEM_TONG_KET_CA_LOPTableAdapter1.Fill(dS_SERVER11.RPT_BANG_DIEM_TONG_KET_CA_LOP, malop);
        }

    }
}