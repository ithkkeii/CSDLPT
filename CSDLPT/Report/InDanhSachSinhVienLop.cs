using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CSDLPT.Report {
    public partial class InDanhSachSinhVienLop : DevExpress.XtraReports.UI.XtraReport {
        public InDanhSachSinhVienLop(string khoa, string lop) {
            InitializeComponent();
            this.dS_SERVER11.EnforceConstraints = false;
            this.sP_INDANHSACHSINHVIENLOPTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sP_INDANHSACHSINHVIENLOPTableAdapter1.Fill(dS_SERVER11.SP_INDANHSACHSINHVIENLOP, khoa, lop);
        }

    }
}
