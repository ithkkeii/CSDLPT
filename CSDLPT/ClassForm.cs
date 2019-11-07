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
using System.Text.RegularExpressions;

namespace CSDLPT {
    public partial class ClassForm : DevExpress.XtraEditors.XtraForm {

        private String chiNhanh = "";
        private String maKhoa = "CNTT";

        public ClassForm() {
            InitializeComponent();
        }

        private void ClassForm_Load(object sender, EventArgs e) {
            chiNhanh = ((DataRowView)Program.bds_dspm.Current)["TENPM"].ToString();
            dS_SERVER1.EnforceConstraints = false;
            try {
                this.taSV.Connection.ConnectionString = Program.connstr;
                this.taLop.Connection.ConnectionString = Program.connstr;
                this.taKhoa.Connection.ConnectionString = Program.connstr;

                // TODO: This line of code loads data into the 'dS_SERVER1.KHOA' table. You can move, or remove it, as needed.
                this.taKhoa.Fill(this.dS_SERVER1.KHOA);
                // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
                this.taLop.Fill(this.dS_SERVER1.LOP);
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

        private void barButtonAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //Vị trí của item chọn
            var vitri = bdsLop.Position;
            groupBox1.Enabled = true;
            gcLop.Enabled = false;
            bdsLop.AddNew();
            txbMaKhoa.Text = maKhoa;
            txbMaLop.ReadOnly = false;

            //Bar button control
            bbtnAdd.Enabled = false;
            bbtnEdit.Enabled = false;
            bbtnRemove.Enabled = false;
            bbtnRecovery.Enabled = false;
            bbtnWrite.Enabled = true;
        }

        private void bbtnWrite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            //Validate
            txbMaLop.Text = Regex.Replace(txbMaLop.Text.Trim(), @"\s+", "");
            txbTenLop.Text = Regex.Replace(txbTenLop.Text.Trim(), @"\s+", " ");
            if (txbMaLop.Text == "") {
                MessageBox.Show("Mã lớp không được để trống!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMaLop.Focus();
                return;
            }
            if (txbTenLop.Text == "") {
                MessageBox.Show("Tên lớp không được để trống!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTenLop.Focus();
                return;
            }

            //Update database
            try {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                if (dS_SERVER1.HasChanges())
                    taLop.Update(dS_SERVER1.LOP);

            } catch (Exception) {

                throw;
            }
        }
    }
}