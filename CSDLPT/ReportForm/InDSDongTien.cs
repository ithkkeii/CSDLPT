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
    public partial class InDSDongTien : DevExpress.XtraEditors.XtraForm {
        public InDSDongTien() {
            InitializeComponent();
        }

        private void InDSDongTien_Load(object sender, EventArgs e) {
            string connectionStr = "Data Source=DESKTOP-0VD6HF8;" +
               "Initial Catalog=QLDSV;" +
               "Integrated Security=True";
            Program.conn.ConnectionString = connectionStr;
            Program.conn.Open();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT MALOP,TENLOP FROM LOP");
            Program.bds_dspm.DataSource = dt;
            cmbMaLop.DataSource = dt;
            cmbMaLop.DisplayMember = "TENLOP";
            cmbMaLop.ValueMember = "MALOP";

            //Combobox NienKhoa
            string currentYear = DateTime.Now.Year.ToString();
            for (int i = -6; i <= 0; i++) {
                cmbNienKhoa.Items.Add((int.Parse(currentYear) + i).ToString());
            }
            cmbNienKhoa.SelectedIndex = 0;
            cmbHocKy.SelectedIndex = 0;
        }

        private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e) {
            int? seleted = cmbMaLop.SelectedIndex;
            if (seleted != null && seleted != -1)
                btnOk.Enabled = true;
            else
                btnOk.Enabled = false;
        }

        private void cmbMaLop_KeyUp(object sender, KeyEventArgs e) {
            int? seleted = cmbMaLop.SelectedIndex;
            if (seleted != null && seleted != -1)
                btnOk.Enabled = true;
            else
                btnOk.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e) {
            InDanhSachDongHocPhi rpt = new InDanhSachDongHocPhi(cmbMaLop.SelectedValue.ToString(),
                int.Parse(cmbHocKy.SelectedItem.ToString()),
                cmbNienKhoa.SelectedItem.ToString());
            //double soTien = Double.Parse(rpt.lbSoTienDaDong.Text);
            //string soTienStr = ChuyenSoSangChuoi(soTien);
            //rpt.lbTienChu.Text = soTienStr;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}