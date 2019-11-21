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

namespace CSDLPT.ReportForm {
    public partial class InDSSV : DevExpress.XtraEditors.XtraForm {
        public InDSSV() {
            InitializeComponent();
        }

        private void InDSSV_Load(object sender, EventArgs e) {
            dS_SERVER1.EnforceConstraints = false;
            this.taLop.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
            this.taLop.Fill(this.dS_SERVER1.LOP);
            BindingSource bds_dspm_currentForm = new BindingSource();
            bds_dspm_currentForm.DataSource = Program.bds_dspm.DataSource;
            if (bds_dspm_currentForm.Count.Equals(3))
                bds_dspm_currentForm.RemoveAt(bds_dspm_currentForm.Count - 1);

            this.cmbKhoa.DataSource = bds_dspm_currentForm.DataSource;
            this.cmbKhoa.SelectedIndex = Program.mChinhanh;
            this.cmbKhoa.DisplayMember = "TENPM";
            this.cmbKhoa.ValueMember = "TENSERVER";
            this.cmbKhoa.Enabled = true;
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_SERVER1);

        }
    }
}