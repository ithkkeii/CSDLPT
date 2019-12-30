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
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;

namespace CSDLPT {
    public partial class SchoolFee : DevExpress.XtraEditors.XtraForm {

        private string masv = "";
        private string masvCheck = "";
        private bool isEdit = false;
        private int vitri = 0;
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
                this.taHocPhi.Connection.ConnectionString = Program.connstr;
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
                return;
            }

            groupControl1.Visible = false;
            btnRecovery.Enabled = false;
            btnWrite.Enabled = false;
            flyoutPanelSub.ShowPopup();
            flyoutPanelMain.ShowPopup();
        }

        private void SchoolFee_Load(object sender, EventArgs e) {
            this.taSV.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS_DONGHOCPHI.SINHVIEN' table. You can move, or remove it, as needed.
            this.taSV.Fill(this.dS_DONGHOCPHI.SINHVIEN);
            // TODO: This line of code loads data into the 'dS_DONGHOCPHI.HOCPHI' table. You can move, or remove it, as needed.
            //this.hOCPHITableAdapter.Fill(this.dS_DONGHOCPHI.HOCPHI);
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            vitri = bdsHocPhi.Position;
            gridView1.OptionsBehavior.ReadOnly = false;
            bdsHocPhi.AddNew();
            //gridView1.AddNewRow();
            //bdsThongTinDongHocPhi.AddNew();

            //Button control
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnBack.Enabled = false;
            btnRecovery.Enabled = true;
            btnWrite.Enabled = true;

        }


        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e) {
            GridView view = sender as GridView;
            GridColumn maSV = view.Columns["MASV"];
            GridColumn hocPhi = view.Columns["HOCPHI"];
            GridColumn soTienDaDong = view.Columns["SOTIENDADONG"];
            view.SetRowCellValue(e.RowHandle, maSV, masv);
            view.SetRowCellValue(e.RowHandle, hocPhi, 0);
            view.SetRowCellValue(e.RowHandle, soTienDaDong, 0);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            vitri = bdsHocPhi.Position;
            isEdit = true;

            //Button control
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnBack.Enabled = false;
            btnWrite.Enabled = true;
        }


        private void btnDelete_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa mục này?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes) {
                try {
                    bdsHocPhi.RemoveCurrent();
                    taHocPhi.Update(dS_DONGHOCPHI.HOCPHI);
                    return;
                } catch (Exception err) {
                    Console.WriteLine(err.Message);
                    MessageBox.Show("Lỗi xóa!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnRecovery_Click(object sender, EventArgs e) {
            bdsHocPhi.CancelEdit();
            isEdit = false;
            //Không cần refresh vì đổi vị trí nó tự vẽ lại
            //gridView1.RefreshData();
            bdsHocPhi.Position = vitri;

            //Button control
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnBack.Enabled = true;
            btnRecovery.Enabled = false;
            btnWrite.Enabled = false;
        }

        private void btnWrite_Click(object sender, EventArgs e) {
            //Trả lại vị trí con trỏ UI/UX
            bdsHocPhi.Position = vitri;
            isEdit = false;
            bdsHocPhi.EndEdit();
            if (dS_DONGHOCPHI.HasChanges())
                taHocPhi.Update(dS_DONGHOCPHI.HOCPHI);

            //Button control
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnBack.Enabled = true;
            btnRecovery.Enabled = false;
            btnWrite.Enabled = false;
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e) {
            GridView view = sender as GridView;
            int newPosition = view.GetSelectedRows()[0];
            if (!isEdit && !gridView1.IsNewItemRow(gridView1.FocusedRowHandle)) {
                e.Cancel = true;
                return;
            }
            if (newPosition != vitri && isEdit) {
                e.Cancel = true;
                return;
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {
            int error = 0;
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
                error++;
            } else {
                view.SetColumnError(nienKhoa, "");
            }

            int checkHocKy = (int)view.GetRowCellValue(e.RowHandle, hocKy);
            if (checkHocKy > 20 || checkHocKy <= 0) {
                e.Valid = false;
                //Set error
                view.SetColumnError(hocKy, "Học kỳ phải lớn hơn 0 và nhỏ hơn 20");
                error++;
            } else {
                view.SetColumnError(hocKy, "");
            }

            int checkHocPhi = (int)view.GetRowCellValue(e.RowHandle, hocPhi);
            if (checkHocPhi < 0) {
                e.Valid = false;
                //Set error
                view.SetColumnError(hocPhi, "Học phí phải lớn hơn 0đ");
                error++;
            } else {
                view.SetColumnError(hocPhi, "");
            }

            int checkSoTienDaDong = (int)view.GetRowCellValue(e.RowHandle, soTienDaDong);
            if (checkSoTienDaDong < 0 || (checkSoTienDaDong < checkHocPhi && checkSoTienDaDong != 0)) {
                e.Valid = false;
                //Set error
                view.SetColumnError(soTienDaDong, "Số tiền đóng phải lớn hơn học phí và lớn hơn 0đ");
                error++;
            } else {
                view.SetColumnError(soTienDaDong, "");
            }

            //Button control
            if (error == 0) {
                btnWrite_Click(null, null);
                //btnAdd.Enabled = true;
                //btnEdit.Enabled = true;
                //btnDelete.Enabled = true;
                //btnBack.Enabled = true;
                //btnRecovery.Enabled = false;
                //btnWrite.Enabled = false;
            }
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e) {
            GridView view = sender as GridView;
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e) {
            GridView view = sender as GridView;
            if (e.RowHandle == vitri && isEdit) {
                e.Appearance.BackColor = Color.LightSalmon;
            } else {
                e.Appearance.BackColor = Color.White;
            }
        }

        private void btnBack_Click(object sender, EventArgs e) {
            groupControl1.Visible = true;
            flyoutPanelSub.HidePopup();
            flyoutPanelMain.HidePopup();
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e) {
            //Suppress displaying the error message box 
            e.ExceptionMode = ExceptionMode.NoAction;
            //Button control
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnBack.Enabled = false;
            btnRecovery.Enabled = true;
            btnWrite.Enabled = true;
            MessageBox.Show("Thông tin lỗi do khóa trùng hoặc sai format", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void gcHocPhi_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Escape) {
                bdsHocPhi.CancelEdit();
                isEdit = false;
                //Không cần refresh vì đổi vị trí nó tự vẽ lại
                //gridView1.RefreshData();
                bdsHocPhi.Position = vitri;

                //Button control
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnBack.Enabled = true;
                btnRecovery.Enabled = false;
                btnWrite.Enabled = false;
            }
        }
    }
}