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

namespace CSDLPT {
    public partial class ClassForm : DevExpress.XtraEditors.XtraForm {
        public ClassForm() {
            InitializeComponent();
            txbMaKhoa.Text = ((DataRowView)Program.bds_dspm.Current)["TENPM"].ToString();
        }

        private void barButtonAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //Vị trí của item chọn
            var vitri = bdsLop.Position;
            Console.WriteLine(vitri);
            gcLop.Enabled = false;
            groupBox1.Enabled = true;
            txbMaKhoa.Text = ((DataRowView)Program.bds_dspm.Current)["TENPM"].ToString();
            txbMaLop.ReadOnly = false;
            bdsLop.AddNew();
        }

        private void ClassForm_Load(object sender, EventArgs e) {
            dS_SERVER1.EnforceConstraints = false;
            try {
                this.taSV.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taKhoa.Connection.ConnectionString = Program.connstr;

                // TODO: This line of code loads data into the 'dS_SERVER1.KHOA' table. You can move, or remove it, as needed.
                this.taKhoa.Fill(this.dS_SERVER1.KHOA);
                // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
                this.lOPTableAdapter.Fill(this.dS_SERVER1.LOP);
                // TODO: This line of code loads data into the 'dS_SERVER1.SINHVIEN' table. You can move, or remove it, as needed.
                this.taSV.Fill(this.dS_SERVER1.SINHVIEN);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            this.cmbKhoaInUse.DataSource = Program.bds_dspm.DataSource;
            this.cmbKhoaInUse.DisplayMember = "TENPM";
            this.cmbKhoaInUse.ValueMember = "TENSERVER";
            this.cmbKhoaInUse.SelectedIndex = 1;
            this.cmbKhoaInUse.Enabled = false;
        }
    }
}