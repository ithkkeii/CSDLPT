using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace CSDLPT.Report
{
    public partial class Danh_sach_thi_het_mon : DevExpress.XtraReports.UI.XtraReport
    {
        public Danh_sach_thi_het_mon(String malop)
        {
            InitializeComponent();
            dS_SERVER11.EnforceConstraints = false;
            this.rPT_DANH_SACH_THI_HET_MONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.rPT_DANH_SACH_THI_HET_MONTableAdapter.Fill(dS_SERVER11.RPT_DANH_SACH_THI_HET_MON, malop);
        }

    }
}
