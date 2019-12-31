using DevExpress.SpreadsheetSource.Implementation;
using DevExpress.Utils;
using DevExpress.XtraDashboardLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CSDLPT {
    public partial class ClassForm : DevExpress.XtraEditors.XtraForm {

        private String tenPhanManh = string.Empty;
        private string tenServer = string.Empty;
        private String maKhoa = "";
        private int vitri;
        private int vitriSV;
        private DataGridViewCell currentCell;
        private int dataGridViewMode = 0;
        private bool isEdit = false;
        private bool isAdd = false;
        private bool isEditSV = false;

        public ClassForm() {
            InitializeComponent();
            //this.ContextMenuStrip = contextMenuStrip1;
            gridView1.OptionsDetail.EnableMasterViewMode = false;
        }

        private void ClassForm_Load(object sender, EventArgs e) {
            tenPhanManh = ((DataRowView)Program.bds_dspm.Current)["TENPM"].ToString();
            tenServer = ((DataRowView)Program.bds_dspm.Current)["TENSERVER"].ToString();
            dS_SERVER1.EnforceConstraints = false;
            try {
                this.taSV.Connection.ConnectionString = Program.connstr;
                this.taLop.Connection.ConnectionString = Program.connstr;
                this.taKhoa.Connection.ConnectionString = Program.connstr;
                this.taDiem.Connection.ConnectionString = Program.connstr;
                //this.taHocPhi.Connection.ConnectionString = Program.connstr;
                this.taAllClass.Connection.ConnectionString = Program.connstr;

                // TODO: This line of code loads data into the 'dS_SERVER1.KHOA' table. You can move, or remove it, as needed.
                this.taKhoa.Fill(this.dS_SERVER1.KHOA);
                // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
                this.taLop.Fill(this.dS_SERVER1.LOP);
                // TODO: This line of code loads data into the 'dS_SERVER1.SINHVIEN' table. You can move, or remove it, as needed.
                this.taSV.Fill(this.dS_SERVER1.SINHVIEN);
                // TODO: This line of code loads data into the 'dS_SERVER1.DIEM' table. You can move, or remove it, as needed.
                this.taDiem.Fill(this.dS_SERVER1.DIEM);
                // TODO: This line of code loads data into the 'dS_SERVER1.HOCPHI' table. You can move, or remove it, as needed.
                //this.taHocPhi.Fill(this.dS_SERVER1.HOCPHI);
                // TODO: This line of code loads data into the 'dS_SERVER1.AllClass' table. You can move, or remove it, as needed.
                this.taAllClass.AllClass(this.dS_SERVER1.AllClass);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            //Xóa mảnh 3
            BindingSource bds_dspm_currentForm = new BindingSource();
            bds_dspm_currentForm.DataSource = Program.bds_dspm.DataSource;
            //if (bds_dspm_currentForm.Count.Equals(3))
            //    bds_dspm_currentForm.RemoveAt(bds_dspm_currentForm.Count - 1);

            //bds_dspm_currentForm.Filter = "TENSERVER <> 'DESKTOP-0VD6HF8\\SERVER3'";
            bds_dspm_currentForm.Filter = $"TENPM LIKE '{Program.prefix}*'";

            this.cmbKhoaInUse.DataSource = bds_dspm_currentForm.DataSource;
            this.cmbKhoaInUse.DisplayMember = "TENPM";
            this.cmbKhoaInUse.ValueMember = "TENSERVER";
            this.cmbKhoaInUse.Enabled = true;

            //auto click combobox
            this.cmbKhoaInUse.SelectedIndex = Program.mChinhanh;
            this.cmbKhoaInUse.SelectedIndex = -1;
            this.cmbKhoaInUse.SelectedIndex = Program.mChinhanh;

            //Button control
            bbtnAdd.Enabled = true;
            bbtnEdit.Enabled = true;
            bbtnRemove.Enabled = true;
            bbtnWrite.Enabled = false;
            bbtnRecovery.Enabled = false;
            bbtnRefresh.Enabled = true;

            //ts
            tsAdd.Enabled = true;
            tsEdit.Enabled = true;
            tsRemove.Enabled = true;
            tsWrite.Enabled = false;
            tsRecovery.Enabled = false;

            //View control
            gcLop.Enabled = true;
            groupBox1.Enabled = false;
            dgvSV.Enabled = true;
            dgvSV.ReadOnly = true;
        }

        private void barButtonAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            //Vị trí của item chọn
            vitri = bdsLop.Position;
            groupBox1.Enabled = true;
            gcLop.Enabled = false;
            bdsLop.AddNew();
            txbMaKhoa.Text = maKhoa;
            txbMaLop.ReadOnly = false;

            //Bar button control
            bbtnAdd.Enabled = false;
            bbtnEdit.Enabled = false;
            bbtnRemove.Enabled = false;
            bbtnRecovery.Enabled = true;
            bbtnWrite.Enabled = true;
            bbtnRefresh.Enabled = false;


            isAdd = true;
            isEdit = false;

            cmbKhoaInUse.Enabled = false;
        }

        private void bbtnWrite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            //Validate
            txbMaLop.Text = Regex.Replace(txbMaLop.Text.Trim(), @"\s+", string.Empty);
            txbTenLop.Text = Regex.Replace(txbTenLop.Text.Trim(), @"\s+", " ");
            if (txbMaLop.Text == string.Empty) {
                MessageBox.Show("Mã lớp không được để trống!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbMaLop.Focus();
                return;
            }
            if (txbMaLop.Text.Length > 8) {
                MessageBox.Show("Mã lớp phải nhỏ hơn hoặc bằng 8 ký tự!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbMaLop.Focus();
                return;
            }
            if (txbTenLop.Text == string.Empty) {
                MessageBox.Show("Tên lớp không được để trống!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTenLop.Focus();
                return;
            }
            if (txbTenLop.Text.Length > 40) {
                MessageBox.Show("Tên lớp phải nhỏ hơn hoặc bằng 40 ký tự!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbTenLop.Focus();
                return;
            }

            //Update database
            //Check xem khóa có hợp lệ ở site chủ hay k
            //Boolean isExistMaLopManh = true;
            //Boolean isExistMaLopGlobal = true;
            //Boolean isExistTenLopManh = true;
            //Boolean isExistTenLopGlobal = true;
            //string queryMaLopGlobal = $"SELECT MALOP FROM LINK0.QLDSV.dbo.LOP WHERE MALOP='{txbMaLop}'";
            //string queryTenLopGlobal = $"SELECT MALOP FROM LINK0.QLDSV.dbo.LOP WHERE TENLOP='{txbTenLop}'";
            //string queryMaLopManh = $"SELECT MALOP FROM dbo.LOP WHERE MALOP='{txbMaLop}'";
            //string queryTenLopManh = $"SELECT MALOP FROM dbo.LOP WHERE TENLOP='{txbTenLop}'";

            //SqlDataReader myReader = Program.ExecSqlDataReader(queryMaLopManh);
            //myReader.Close();
            //if (myReader == null) {
            //    isExistMaLopManh = false;
            //} else {
            //    bdsLop.EndEdit();
            //    bdsLop.ResetCurrentItem();
            //    MessageBox.Show("Mã lớp bị trùng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txbMaLop.Focus();
            //    return;
            //}

            //if (!isExistMaLopManh) {
            //    myReader = Program.ExecSqlDataReader(queryMaLopGlobal);
            //    myReader.Close();
            //    if (myReader == null) {
            //        isExistMaLopGlobal = false;
            //    } else {
            //        bdsLop.EndEdit();
            //        bdsLop.ResetCurrentItem();
            //        MessageBox.Show("Mã lớp bị trùng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txbMaLop.Focus();
            //        return;
            //    }
            //}

            //myReader = Program.ExecSqlDataReader(queryTenLopManh);
            //myReader.Close();
            //if (myReader == null) {
            //    isExistTenLopManh = false;
            //} else {
            //    bdsLop.EndEdit();
            //    bdsLop.ResetCurrentItem();
            //    MessageBox.Show("Tên lớp bị trùng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txbMaLop.Focus();
            //    return;
            //}

            //if (!isExistTenLopManh) {
            //    myReader = Program.ExecSqlDataReader(queryTenLopGlobal);
            //    myReader.Close();
            //    if (myReader == null) {
            //        isExistTenLopGlobal = false;
            //    } else {
            //        bdsLop.EndEdit();
            //        bdsLop.ResetCurrentItem();
            //        MessageBox.Show("Tên lớp bị trùng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txbMaLop.Focus();
            //        return;
            //    }
            //}
            int mode = 0;
            if (isEdit == true && isAdd == false)
                mode = 1;
            //string strLenh = $"EXEC SP_ISLOPEXIST {mode}, '{txbMaLop.Text}', '{txbTenLop.Text}'";
            string strLenh = $"SP_ISLOPEXIST";
            //SqlDataReader myReader = Program.ExecSqlDataReader(strLenh);

            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("MODE", mode);
            sqlcmd.Parameters.AddWithValue("MALOP", txbMaLop.Text);
            sqlcmd.Parameters.AddWithValue("TENLOP", txbTenLop.Text);
            var returnParameter = sqlcmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try {
                sqlcmd.ExecuteNonQuery();
            } catch (Exception ex) {
                Program.conn.Close();
                MessageBox.Show(ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Console.WriteLine(returnParameter.Value);

            if (returnParameter.Value.Equals(1) || returnParameter.Value.Equals(2)) {
                if (returnParameter.Value.Equals(1)) {
                    MessageBox.Show("Mã lớp bị trùng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMaLop.Focus();
                    return;
                } else {
                    MessageBox.Show("Tên lớp bị trùng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbTenLop.Focus();
                    return;
                }
            } else {
                try {
                    bdsLop.EndEdit();
                    bdsLop.ResetCurrentItem();
                    if (dS_SERVER1.HasChanges())
                        taLop.Update(dS_SERVER1.LOP);

                } catch (SqlException err) {
                    if (err.Message.Contains("PRIMARY")) {
                        MessageBox.Show("Mã lớp bị trùng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbMaLop.Focus();
                        return;
                    } else if (err.Message.Contains("UNIQUE")) {
                        MessageBox.Show("Tên lớp bị trùng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbTenLop.Focus();
                        return;
                    } else {
                        MessageBox.Show("Lỗi tạo lớp, vui lòng xem lại!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            //Button control
            bbtnAdd.Enabled = true;
            bbtnEdit.Enabled = true;
            bbtnRecovery.Enabled = true;
            bbtnRemove.Enabled = true;
            bbtnWrite.Enabled = false;
            bbtnRefresh.Enabled = true;

            gcLop.Enabled = true;
            groupBox1.Enabled = false;

            isEdit = false;
            isAdd = false;

            cmbKhoaInUse.Enabled = true;
        }

        private void bbtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            bbtnAdd.Enabled = false;
            bbtnEdit.Enabled = false;
            bbtnRemove.Enabled = false;
            bbtnWrite.Enabled = true;
            bbtnRecovery.Enabled = true;
            bbtnRefresh.Enabled = false;

            groupBox1.Enabled = true;
            txbMaLop.ReadOnly = true;
            gcLop.Enabled = false;
            vitri = bdsLop.Position;

            isAdd = false;
            isEdit = true;

            cmbKhoaInUse.Enabled = false;
            return;
        }

        private void bbtnRemove_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (bdsSV.Count > 0) {
                MessageBox.Show("Lớp có sinh viên không được xóa!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa lớp này?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes) {
                try {
                    bdsLop.RemoveCurrent();
                    taLop.Update(dS_SERVER1.LOP);
                    return;
                } catch (Exception err) {
                    Console.WriteLine(err.Message);
                    MessageBox.Show("Lỗi xóa lớp!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            return;
        }

        private void bbtnRecovery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            bdsLop.CancelEdit();
            this.taLop.Fill(this.dS_SERVER1.LOP);
            bdsLop.Position = vitri;
            gcLop.Enabled = true;
            groupBox1.Enabled = false;

            //Button control
            bbtnAdd.Enabled = true;
            bbtnEdit.Enabled = true;
            bbtnRemove.Enabled = true;
            bbtnWrite.Enabled = false;
            bbtnRecovery.Enabled = false;
            bbtnRefresh.Enabled = true;


            isEdit = false;
            isAdd = false;

            cmbKhoaInUse.Enabled = true;
        }

        private void tsAdd_Click(object sender, EventArgs e) {
            vitriSV = bdsSV.Position;
            bdsSV.AddNew();
            currentCell = dgvSV.CurrentCell;

            //Button control
            bbtnAdd.Enabled = false;
            bbtnEdit.Enabled = false;
            bbtnRemove.Enabled = false;
            bbtnWrite.Enabled = false;
            bbtnRecovery.Enabled = false;
            bbtnRefresh.Enabled = false;

            tsAdd.Enabled = false;
            tsEdit.Enabled = false;
            tsRemove.Enabled = false;
            tsWrite.Enabled = true;
            tsRecovery.Enabled = true;
            tsChangeClass.Enabled = false;

            //View control
            gcLop.Enabled = false;
            groupBox1.Enabled = false;
            dgvSV.Enabled = true;
            dgvSV.ReadOnly = false;
            dgvtxbMaLop.ReadOnly = true;

            cmbKhoaInUse.Enabled = false;
            //foreach (DataGridViewRow row in dgvSV.Rows) {
            //    row.ReadOnly = true;
            //}

            for (int i = 0; i < dgvSV.Rows.Count - 1; i++) {
                dgvSV.Rows[i].ReadOnly = true;
            }
            dgvSV.Rows[dgvSV.Rows.Count - 1].Cells["dgvchbPhai"].Value = false;
            dgvSV.Rows[dgvSV.Rows.Count - 1].Cells["dgvchbNghiHoc"].Value = false;
            return;
        }

        private void tsEdit_Click(object sender, EventArgs e) {

            dataGridViewMode = 2;
            vitriSV = bdsSV.Position;

            //Button control
            bbtnAdd.Enabled = false;
            bbtnEdit.Enabled = false;
            bbtnRemove.Enabled = false;
            bbtnWrite.Enabled = false;
            bbtnRecovery.Enabled = false;
            bbtnRefresh.Enabled = false;


            tsAdd.Enabled = false;
            tsEdit.Enabled = false;
            tsRemove.Enabled = false;
            tsWrite.Enabled = true;
            tsRecovery.Enabled = true;
            tsChangeClass.Enabled = false;
            isEditSV = true;

            //View control
            gcLop.Enabled = false;
            groupBox1.Enabled = false;
            dgvSV.Enabled = true;
            dgvSV.ReadOnly = false;
            dgvtxbMaLop.ReadOnly = true;

            cmbKhoaInUse.Enabled = false;

            //foreach (DataGridViewRow row in dgvSV.Rows) {
            //    row.Cells["dgvtxbMaSV"].ReadOnly = true;
            //}
            //dgvSV.Columns["dgvtxbMaSV"].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            //dgvSV.Columns["dgvtxbMaSV"].DefaultCellStyle.BackColor = System.Drawing.Color.Orange;
            dgvSV.Columns["dgvtxbMaSV"].ReadOnly = true;

            return;
        }

        private void tsWrite_Click(object sender, EventArgs e) {
            dataGridViewMode = 0;

            //Validate
            Console.WriteLine(dgvSV.Rows[dgvSV.Rows.Count - 1].Cells["dgvtxbMaSV"].Value);
            //Update database
            //Check xem khóa có hợp lệ ở site chủ hay k
            if (isEditSV == false) {
                string masv = dgvSV.Rows[dgvSV.Rows.Count - 1].Cells["dgvtxbMaSV"].Value.ToString(); //mã sinh viên của dòng add new
                string strLenh = "SP_ISSINHVIENEXIST";
                SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("MASV", masv);
                var returnParameter = sqlcmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                try {
                    sqlcmd.ExecuteNonQuery();
                } catch (Exception ex) {
                    Program.conn.Close();
                    MessageBox.Show(ex.Message);
                }

                Console.WriteLine(returnParameter.Value);

                if (returnParameter.Value.Equals(1)) {
                    //bdsLop.EndEdit();
                    //bdsLop.ResetCurrentItem();
                    MessageBox.Show("Mã sinh viên bị trùng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try {
                bdsSV.EndEdit();
                //bdsSV.ResetCurrentItem();
                if (dS_SERVER1.HasChanges())
                    taSV.Update(dS_SERVER1.SINHVIEN);
            } catch (Exception err) {
                Console.WriteLine(err.Message);
                if (err.Message.Contains("PRIMARY")) {
                    MessageBox.Show("Mã sinh viên bị trùng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else {
                    MessageBox.Show("Lỗi tạo sinh viên, vui lòng xem lại!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            //----> Write to db success
            //Button control
            bbtnAdd.Enabled = true;
            bbtnEdit.Enabled = true;
            bbtnRemove.Enabled = true;
            bbtnWrite.Enabled = false;
            bbtnRecovery.Enabled = false;
            bbtnRefresh.Enabled = true;


            tsAdd.Enabled = true;
            tsEdit.Enabled = true;
            tsRemove.Enabled = true;
            tsWrite.Enabled = false;
            tsRecovery.Enabled = false;
            tsChangeClass.Enabled = true;
            isEditSV = false;

            //View control
            gcLop.Enabled = true;
            groupBox1.Enabled = false;
            dgvSV.Enabled = true;
            dgvSV.ReadOnly = true;
            dgvtxbMaLop.ReadOnly = true;

            cmbKhoaInUse.Enabled = true;
            bdsSV.Position = vitriSV;
        }

        private void tsRemove_Click(object sender, EventArgs e) {
            if (bdsDiem.Count > 0) {
                MessageBox.Show("Sinh viên có điểm thi không được xóa!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Check lại trên site chủ
            //cách này tránh đc close myReader + catch đc RaiseError
            int selectedrowindex = dgvSV.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSV.Rows[selectedrowindex];
            string a = Convert.ToString(selectedRow.Cells["dgvtxbMaSV"].Value);
            string strLenh = "SP_ISSVDADONGHOCPHI";
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("MASV", a);

            try {
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Sinh viên đã đóng học phí không được xóa!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } catch (Exception ex) {
                DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa sinh viên này?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes) {
                    try {
                        bdsSV.RemoveCurrent();
                        taSV.Update(dS_SERVER1.SINHVIEN);
                        return;
                    } catch (Exception err) {
                        Console.WriteLine(err.Message);
                        MessageBox.Show("Lỗi xóa sinh viên!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            return;
        }

        private void tsRecovery_Click(object sender, EventArgs e) {

            bdsSV.CancelEdit();
            if (dataGridViewMode != 2 && currentCell.RowIndex != -1) { //Không phải edit
                dgvSV.Rows.Remove(dgvSV.Rows[currentCell.RowIndex]);
            } else
                this.taSV.Fill(this.dS_SERVER1.SINHVIEN);

            //dgvSV.Rows[4].Cells[0].Value
            //dgvSV.Refresh();
            //foreach (DataGridViewRow row in dgvSV.Rows) {
            //    if (row.Selected == true)
            //        dgvSV.Rows.Remove(row);
            //}

            foreach (DataGridViewRow row in dgvSV.Rows) {
                foreach (DataGridViewCell cell in row.Cells) {
                    //do operations with cell
                    dgvSV.CurrentCell = dgvSV.Rows[cell.RowIndex].Cells[cell.ColumnIndex];
                    dgvSV.CancelEdit();
                }
            }

            //Button control
            bbtnAdd.Enabled = true;
            bbtnEdit.Enabled = true;
            bbtnRemove.Enabled = true;
            bbtnWrite.Enabled = false;
            bbtnRecovery.Enabled = false;
            bbtnRefresh.Enabled = true;

            tsAdd.Enabled = true;
            tsEdit.Enabled = true;
            tsRemove.Enabled = true;
            tsWrite.Enabled = false;
            tsRecovery.Enabled = false;
            tsChangeClass.Enabled = true;
            isEditSV = false;

            //View control
            gcLop.Enabled = true;
            groupBox1.Enabled = false;
            dgvSV.Enabled = true;
            dgvSV.ReadOnly = true;
            dgvtxbMaLop.ReadOnly = true;

            cmbKhoaInUse.Enabled = true;
            bdsSV.Position = vitriSV;
        }
        Dictionary<string, string> list = null;
        private void tsChangeClass_Click(object sender, EventArgs e) {
            flyoutPanel1.ShowPopup();

            //Không bind dữ liệu, các lớp của khoa
            list = new Dictionary<string, string>();
            for (int i = 0; i < gridView1.DataRowCount; i++) {
                if (!gridView1
                    .GetRowCellValue(i, "MALOP")
                    .ToString()
                    .Equals(txteMaLop.Text.ToString()))
                    list.Add(gridView1.GetRowCellValue(i, "TENLOP").ToString(),
                        gridView1.GetRowCellValue(i, "MALOP").ToString());
            }
            //cmbChangeClass.DataSource = list.ToList();
            //cmbChangeClass.DisplayMember = "Key";
            //cmbChangeClass.ValueMember = "Value";

            //
            string strLenh = "SELECT MALOP,TENLOP FROM LINK0.QLDSV.dbo.LOP";
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable(strLenh);
            BindingSource bds = new BindingSource();
            bds.DataSource = dt;
            bds.Filter = $"MALOP <> '{txteMaLop.Text}'";
            cmbChangeClass.DataSource = bds.DataSource;
            cmbChangeClass.DisplayMember = "TENLOP";
            cmbChangeClass.ValueMember = "MALOP";


            //Auto choose first item
            //Không cần trick chọn 1 xong 0 vẫn ok ? 
            cmbChangeClass.SelectedIndex = 0;

            //Button control
            bbtnAdd.Enabled = false;
            bbtnEdit.Enabled = false;
            bbtnRemove.Enabled = false;
            bbtnWrite.Enabled = false;
            bbtnRecovery.Enabled = false;
            bbtnRefresh.Enabled = false;


            tsAdd.Enabled = false;
            tsEdit.Enabled = false;
            tsRemove.Enabled = false;
            tsWrite.Enabled = false;
            tsRecovery.Enabled = false;
            tsChangeClass.Enabled = false;

            //View control
            gcLop.Enabled = false;
            groupBox1.Enabled = false;
            dgvSV.Enabled = false;
            dgvSV.ReadOnly = true;
            dgvtxbMaLop.ReadOnly = true;
            cmbKhoaInUse.Enabled = false;
        }

        private void flyoutPanel1_Load(object sender, EventArgs e) {
            btnOk.Enabled = false;
        }

        private void btnOk_Click(object sender, EventArgs e) {

            string maSinhVienChuyenLop = txteMaSV.Text.ToString();
            string maLopMoi = cmbChangeClass.SelectedValue.ToString();
            string maLopCu = txteMaLop.Text;
            string tenLopMoi = cmbChangeClass.Text.ToString();
            string maSinhVenMoi = txteMaSVMoi.Text;


            string strLenh = "SP_ISSINHVIENEXIST";
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("MASV", maSinhVenMoi);
            var returnParameter = sqlcmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try {
                sqlcmd.ExecuteNonQuery();
            } catch (Exception ex) {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return;
            }

            if (returnParameter.Value.Equals(1)) {
                MessageBox.Show("Mã sinh viên mới bị trùng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            strLenh = "SP_CHUYENLOP";
            sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("MASV_NEW", maSinhVenMoi);
            sqlcmd.Parameters.AddWithValue("MASV_OLD", maSinhVienChuyenLop);
            sqlcmd.Parameters.AddWithValue("MALOP_NEW", maLopMoi);
            sqlcmd.Parameters.AddWithValue("MALOP_OLD", maLopCu);

            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try {
                sqlcmd.ExecuteNonQuery();
            } catch (Exception ex) {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return;
            }

            //string result = "";
            //if (list.TryGetValue(tenLopMoi, out result)) {
            //    for (int i = 0; i < dgvSV.Rows.Count; i++) {
            //        DataGridViewCell cell = dgvSV.Rows[i].Cells["dgvtxbMASV"];
            //        if (cell.Value.ToString().Equals(maSinhVienChuyenLop)) {
            //            dgvSV.Rows[i].Cells["dgvtxbMALOP"].Value = maLopMoi;
            //            try {
            //                bdsSV.EndEdit();
            //                if (dS_SERVER1.HasChanges())
            //                    taSV.Update(dS_SERVER1.SINHVIEN);
            //                this.taSV.Fill(this.dS_SERVER1.SINHVIEN);
            //            } catch (Exception ex) {
            //                Console.WriteLine(ex.Message);
            //            }
            //            break;
            //        }
            //    }
            //} else {
            //    return;
            //}


            //List<string> listLop = new List<string>();
            //for (int i = 0; i < gridView1.DataRowCount; i++) {
            //    listLop.Add(gridView1.GetRowCellValue(i, "MALOP").ToString());
            //}
            //for (int i = 0; i < dgvSV.Rows.Count; i++) {
            //    DataGridViewCell cell = dgvSV.Rows[i].Cells["dgvtxbMASV"];
            //    if (cell.Value.ToString().Equals(maSinhVienChuyenLop)) {
            //        if (listLop.Contains(maLopMoi)) {
            //            dgvSV.Rows[i].Cells["dgvtxbMALOP"].Value = maLopMoi;
            //        } else {
            //            string sql = $"UPDATE LINK0.QLDSV.dbo.SINHVIEN " +
            //                $"SET MALOP='{maLopMoi}' " +
            //                $"WHERE MASV='{maSinhVienChuyenLop}'";
            //            SqlCommand cmd = new SqlCommand(sql, Program.conn);
            //            cmd.ExecuteNonQuery();
            //        }
            //        try {
            //            bdsSV.EndEdit();
            //            if (dS_SERVER1.HasChanges())
            //                taSV.Update(dS_SERVER1.SINHVIEN);
            //            this.taSV.Fill(this.dS_SERVER1.SINHVIEN);
            //        } catch (Exception ex) {
            //            Console.WriteLine(ex.Message);
            //        }
            //        break;
            //    }
            //}



            //Button control
            bbtnAdd.Enabled = true;
            bbtnEdit.Enabled = true;
            bbtnRemove.Enabled = true;
            bbtnWrite.Enabled = false;
            bbtnRecovery.Enabled = false;
            bbtnRefresh.Enabled = true;


            tsAdd.Enabled = true;
            tsEdit.Enabled = true;
            tsRemove.Enabled = true;
            tsWrite.Enabled = false;
            tsRecovery.Enabled = false;
            tsChangeClass.Enabled = true;

            //View control
            gcLop.Enabled = true;
            groupBox1.Enabled = false;
            dgvSV.Enabled = true;
            dgvSV.ReadOnly = true;
            dgvtxbMaLop.ReadOnly = true;

            cmbKhoaInUse.Enabled = true;
            bdsSV.Position = vitriSV;
            flyoutPanel1.HidePopup();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            // Button control
            bbtnAdd.Enabled = true;
            bbtnEdit.Enabled = true;
            bbtnRemove.Enabled = true;
            bbtnWrite.Enabled = false;
            bbtnRecovery.Enabled = false;
            bbtnRefresh.Enabled = true;


            tsAdd.Enabled = true;
            tsEdit.Enabled = true;
            tsRemove.Enabled = true;
            tsWrite.Enabled = false;
            tsRecovery.Enabled = false;
            tsChangeClass.Enabled = true;

            //View control
            gcLop.Enabled = true;
            groupBox1.Enabled = false;
            dgvSV.Enabled = true;
            dgvSV.ReadOnly = true;
            dgvtxbMaLop.ReadOnly = true;

            cmbKhoaInUse.Enabled = true;
            //thoát chuyển lớp k cần gán lại vị trí
            //bdsSV.Position = vitriSV;
            flyoutPanel1.HidePopup();
        }

        private void dgvSV_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) {
            string headerText = dgvSV.Columns[e.ColumnIndex].HeaderText;


            //Validation if cell is in the MASV column
            if (headerText.Equals("MASV")) {
                validateStringField("MASV", 10, e, false);
            }

            if (headerText.Equals("HO")) {
                validateStringField("HO", 40, e);
            }

            if (headerText.Equals("TEN")) {
                validateStringField("TEN", 10, e);
            }

            if (headerText.Equals("NGAYSINH")) {
                DateTime dateTime;
                try {
                    dateTime = Convert.ToDateTime(e.FormattedValue.ToString());
                } catch (Exception ex) {
                    MessageBox.Show("Ngày sinh không hợp lệ!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine(ex.Message);
                    e.Cancel = true;
                    return;
                }

                //Cell is not empty
                if (string.IsNullOrEmpty(e.FormattedValue.ToString())) {
                    dgvSV.Rows[e.RowIndex].ErrorText = "NGAYSINH không được rỗng!";
                    e.Cancel = true;
                }

                //Năm sinh <= 1900
                if (dateTime.Year < 1900) {
                    dgvSV.Rows[e.RowIndex].ErrorText = "Năm sinh phải lớn hơn 1900!";
                    e.Cancel = true;
                }
            }

            if (headerText.Equals("NOISINH")) {
                validateStringField("NOISINH", 40, e);
            }

            if (headerText.Equals("DIACHI")) {
                validateStringField("DIACHI", 80, e);
            }
        }

        private void validateStringField(String field, int condition, DataGridViewCellValidatingEventArgs e, bool isNullable = true) {
            //Cell is not empty
            if (!isNullable && string.IsNullOrEmpty(e.FormattedValue.ToString())) {
                dgvSV.Rows[e.RowIndex].ErrorText = $"{field} không được rỗng!";
                MessageBox.Show($"{field} không được rỗng!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }

            if (e.FormattedValue.ToString().Length > condition) {
                dgvSV.Rows[e.RowIndex].ErrorText = $"{field} không được nhiều hơn {condition} ký tự!";
                MessageBox.Show($"{field} không được nhiều hơn {condition} ký tự!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void dgvSV_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            string value = string.Empty;

            dgvSV.Rows[e.RowIndex].ErrorText = string.Empty;
            //value = dgvSV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim();
            //dgvSV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value;

            if (dgvSV.Columns[e.ColumnIndex].HeaderText.Equals("MASV")) {
                value = dgvSV.Rows[e.RowIndex]
                    .Cells[e.ColumnIndex]
                    .Value
                    .ToString()
                    .Trim();
                value = Regex.Replace(value, @"\s+", string.Empty);
                value = Regex.Replace(value, "[^0-9a-zA-Z-]+", string.Empty);
                dgvSV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value;
            }

            if (dgvSV.Columns[e.ColumnIndex].HeaderText.Equals("HO") ||
                dgvSV.Columns[e.ColumnIndex].HeaderText.Equals("TEN")) {
                value = dgvSV.Rows[e.RowIndex]
                    .Cells[e.ColumnIndex]
                    .Value
                    .ToString()
                    .Trim();
                value = Regex.Replace(value, @"\s+", " ");
                value = Regex.Replace(value, "[/\\,;:.`?{}[\\]=+<>@#$%^&*]+", string.Empty);
                dgvSV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value;
            }

            if (dgvSV.Columns[e.ColumnIndex].HeaderText.Equals("NOISINH") ||
                dgvSV.Columns[e.ColumnIndex].HeaderText.Equals("DIACHI")) {
                value = dgvSV.Rows[e.RowIndex]
                    .Cells[e.ColumnIndex]
                    .Value
                    .ToString()
                    .Trim();
                value = Regex.Replace(value, @"\s+", " ");
                value = Regex.Replace(value, "[\\;:`?{}[\\]=+<>@#$%^&*]+", string.Empty);
                dgvSV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = value;
            }
        }

        private void dgvSV_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            MessageBox.Show("Error happened " + e.Context.ToString());
        }

        private void cmbKhoaInUse_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.cmbKhoaInUse.SelectedIndex == -1)
                return;

            if (cmbKhoaInUse.SelectedValue.ToString() == "System.Data.DataRowView") {
                return;
            }
            Program.servername = cmbKhoaInUse.SelectedValue.ToString();

            if (cmbKhoaInUse.SelectedIndex != Program.mChinhanh) {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            } else {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.Connect() == 0) {
                MessageBox.Show("Lỗi kết nối khoa mới", "", MessageBoxButtons.OK);
            } else {
                try {
                    this.taSV.Connection.ConnectionString = Program.connstr;
                    this.taLop.Connection.ConnectionString = Program.connstr;
                    this.taKhoa.Connection.ConnectionString = Program.connstr;
                    this.taDiem.Connection.ConnectionString = Program.connstr;
                    //this.taHocPhi.Connection.ConnectionString = Program.connstr;

                    // TODO: This line of code loads data into the 'dS_SERVER1.KHOA' table. You can move, or remove it, as needed.
                    this.taKhoa.Fill(this.dS_SERVER1.KHOA);
                    // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
                    this.taLop.Fill(this.dS_SERVER1.LOP);
                    // TODO: This line of code loads data into the 'dS_SERVER1.SINHVIEN' table. You can move, or remove it, as needed.
                    this.taSV.Fill(this.dS_SERVER1.SINHVIEN);
                    // TODO: This line of code loads data into the 'dS_SERVER1.DIEM' table. You can move, or remove it, as needed.
                    this.taDiem.Fill(this.dS_SERVER1.DIEM);
                    // TODO: This line of code loads data into the 'dS_SERVER1.HOCPHI' table. You can move, or remove it, as needed.
                    //this.taHocPhi.Fill(this.dS_SERVER1.HOCPHI);
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }

            //Gán Mã Khoa
            if (bdsLop.Count > 0)
                maKhoa = ((DataRowView)bdsLop[0])["MAKH"].ToString();
            else {
                if (cmbKhoaInUse.SelectedIndex == 0)
                    maKhoa = "CNTT";
                if (cmbKhoaInUse.SelectedIndex == 1)
                    maKhoa = "VT";
            }
        }

        private void ClassForm_FormClosing(object sender, FormClosingEventArgs e) {
            //Program.servername = tenServer;
        }

        private void ClassForm_FormClosed(object sender, FormClosedEventArgs e) {
            flyoutPanel1.HidePopup();
        }

        private void cmbChangeClass_SelectedIndexChanged(object sender, EventArgs e) {
            int? seleted = cmbChangeClass.SelectedIndex;
            Console.WriteLine(seleted);
            if (seleted != null && seleted != -1)
                btnOk.Enabled = true;
            else
                btnOk.Enabled = false;
        }

        private void cmbChangeClass_KeyUp(object sender, KeyEventArgs e) {
            int? seleted = cmbChangeClass.SelectedIndex;
            Console.WriteLine(seleted);
            if (seleted != null && seleted != -1)
                btnOk.Enabled = true;
            else
                btnOk.Enabled = false;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
            if (bdsSV.Count > 0) {
                //ts
                //tsAdd.Enabled = true;
                //tsEdit.Enabled = true;
                //tsRemove.Enabled = true;
                //tsWrite.Enabled = false;
                //tsRecovery.Enabled = false;
            } else {
                e.Cancel = true;
            }
        }

        private void bbtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                this.taSV.Connection.ConnectionString = Program.connstr;
                this.taLop.Connection.ConnectionString = Program.connstr;
                this.taKhoa.Connection.ConnectionString = Program.connstr;
                this.taDiem.Connection.ConnectionString = Program.connstr;
                //this.taHocPhi.Connection.ConnectionString = Program.connstr;
                this.taAllClass.Connection.ConnectionString = Program.connstr;

                // TODO: This line of code loads data into the 'dS_SERVER1.KHOA' table. You can move, or remove it, as needed.
                this.taKhoa.Fill(this.dS_SERVER1.KHOA);
                // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
                this.taLop.Fill(this.dS_SERVER1.LOP);
                // TODO: This line of code loads data into the 'dS_SERVER1.SINHVIEN' table. You can move, or remove it, as needed.
                this.taSV.Fill(this.dS_SERVER1.SINHVIEN);
                // TODO: This line of code loads data into the 'dS_SERVER1.DIEM' table. You can move, or remove it, as needed.
                this.taDiem.Fill(this.dS_SERVER1.DIEM);
                // TODO: This line of code loads data into the 'dS_SERVER1.HOCPHI' table. You can move, or remove it, as needed.
                //this.taHocPhi.Fill(this.dS_SERVER1.HOCPHI);
                // TODO: This line of code loads data into the 'dS_SERVER1.AllClass' table. You can move, or remove it, as needed.
                this.taAllClass.AllClass(this.dS_SERVER1.AllClass);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}