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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Serializing;

namespace CSDLPT {
    public partial class SchoolFee : DevExpress.XtraEditors.XtraForm {

        private string masv = "";
        private string masvCheck = "";
        private BindingSource bds_feeInfomation = new BindingSource();

        public SchoolFee() {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            masv = txtbFindMaSV.Text;
            //DataTable dt = new DataTable();
            //dt = Program.ExecSqlDataTable($"EXEC SP_THONGTINDONGHOCPHI '{masv}'");
            //bds_feeInfomation.DataSource = dt;
            //bdsThongTinDongHocPhi.DataSource = dt;
            try {
                this.taHocPhi.FillBy(dS_DONGHOCPHI.HOCPHI, masv);
            } catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            for (int i = 0; i < bdsSV.Count - 1; i++) {
                masvCheck = ((DataRowView)bdsSV[i])["MASV"].ToString().Trim();
                if (masvCheck.Equals(masv)) {
                    txtbMaSinhVien.Text = ((DataRowView)bdsSV[i])["MASV"].ToString();
                    txtbMaLop.Text = ((DataRowView)bdsSV[i])["MALOP"].ToString();
                    txtbHo.Text = ((DataRowView)bdsSV[i])["HO"].ToString();
                    txtbTen.Text = ((DataRowView)bdsSV[i])["TEN"].ToString();
                    break;
                }
                //----> if not find student
                masvCheck = "";
            }

            if (masvCheck.Equals("")) {
                MessageBox.Show("Mã sinh viên không tìm thấy!", "", MessageBoxButtons.OK);
                //return;
            }

            groupControl1.Visible = false;
            flyoutPanelSub.ShowPopup();
            flyoutPanelMain.ShowPopup();
        }

        private void SchoolFee_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'dS_DONGHOCPHI.SINHVIEN' table. You can move, or remove it, as needed.
            this.taSV.Fill(this.dS_DONGHOCPHI.SINHVIEN);
            // TODO: This line of code loads data into the 'dS_DONGHOCPHI.HOCPHI' table. You can move, or remove it, as needed.
            //this.hOCPHITableAdapter.Fill(this.dS_DONGHOCPHI.HOCPHI);
        }

        private void btnAdd_Click(object sender, EventArgs e) {

            gridView1.OptionsBehavior.ReadOnly = false;
            bdsHocPhi.AddNew();
            //gridView1.AddNewRow();
            //bdsThongTinDongHocPhi.AddNew();
        }


        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e) {
            GridView view = sender as GridView;
            GridColumn maSV = view.Columns["MASV"];
            view.SetRowCellValue(e.RowHandle, maSV, masv);
        }

        private void btnDelete_Click(object sender, EventArgs e) {

        }

        private void btnRecovery_Click(object sender, EventArgs e) {

        }

        private void btnWrite_Click(object sender, EventArgs e) {
            taHocPhi.Update(dS_DONGHOCPHI.HOCPHI);
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e) {
            if (!gridView1.IsNewItemRow(gridView1.FocusedRowHandle))
                e.Cancel = true;
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {
            GridView view = sender as GridView;
            GridColumn nienKhoa = view.Columns["NIENKHOA"];
            GridColumn hocKy = view.Columns["HOCKY"];
            GridColumn hocPhi = view.Columns["HOCPHI"];
            GridColumn soTienDaDong = view.Columns["SOTIENDADONG"];

            //Get value of first column
            string checkNienKhoa = (string)view.GetRowCellValue(e.RowHandle, nienKhoa);
            if (checkNienKhoa.Length < 4 || checkNienKhoa.Length > 4 || Int32.Parse(checkNienKhoa) < 1500) {
                e.Valid = false;
                //Set error
                view.SetColumnError(nienKhoa, "Năm phải có 4 ký tự và lớn hơn năm 1900");
            } else {
                view.SetColumnError(nienKhoa, "");
            }

            int checkHocKy = (int)view.GetRowCellValue(e.RowHandle, hocKy);
            if (checkHocKy > 20 || checkHocKy <= 0) {
                e.Valid = false;
                //Set error
                view.SetColumnError(hocKy, "Học kỳ phải lớn hơn 0 và nhỏ hơn 20");
            } else {
                view.SetColumnError(hocKy, "");
            }

            int checkHocPhi = (int)view.GetRowCellValue(e.RowHandle, hocPhi);
            if (checkHocPhi < 0) {
                e.Valid = false;
                //Set error
                view.SetColumnError(hocPhi, "Học phí phải lớn hơn 0đ");
            } else {
                view.SetColumnError(hocPhi, "");
            }

            int checkSoTienDaDong = (int)view.GetRowCellValue(e.RowHandle, soTienDaDong);
            if (checkSoTienDaDong < 0 || checkSoTienDaDong < checkHocPhi) {
                e.Valid = false;
                //Set error
                view.SetColumnError(soTienDaDong, "Số tiền đóng phải lớn hơn học phí và lớn hơn 0đ");
            } else {
                view.SetColumnError(soTienDaDong, "");
            }
        }

    }
}