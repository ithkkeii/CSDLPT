using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CSDLPT {
    public partial class MarkForm : Form {
        private BindingSource bdsNhapdiem = new BindingSource();
        private string cmd, maLop, maMonhoc, diemStr;
        private int lanThi;
        private float diemFl;
        private Boolean addFlag = false;
        private Boolean editFlag = false;
        private List<float> oldMark = new List<float>();
        public MarkForm() {
            InitializeComponent();
        }

        private void MarkForm_Load(object sender, EventArgs e) {
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS_SERVER1.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS_SERVER1.MONHOC);

            // tENMHComboBox.SelectedIndex = 1;
            //  tENLOPComboBox.SelectedIndex = 1;
            tENMHComboBox.SelectedIndex = 0;

            cmbLanthi.SelectedIndex = 0;
            gcMark.Enabled = false;
            btnSave.Enabled = false;
            // chọn khoa
            BindingSource bds_dsKhoa = new BindingSource();
            bds_dsKhoa.DataSource = Program.bds_dspm.DataSource;
            bds_dsKhoa.Filter = "TENPM <> 'KẾ TOÁN'";
            cmbKhoa.DataSource = bds_dsKhoa.DataSource;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            if (!Program.mGroup.Equals("PGV")) {
                //auto click
                cmbKhoa.SelectedIndex = Program.mChinhanh;
                cmbKhoa.SelectedIndex = -1;
                cmbKhoa.SelectedIndex = Program.mChinhanh;
                cmbKhoa.Enabled = false;
            }
        }
        //nút lưu
        private void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            List<DataRow> list = new List<DataRow>();


            for (int i = 0; i < gridView1.DataRowCount; i++) {
                list.Add(gridView1.GetDataRow(i));
            }
            if (addFlag)// thêm điểm
            {
                addMark(list);
                MessageBox.Show("Đã thêm điểm thành công!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (editFlag)// câp nhật điểm
            {
                updateMark(list);
                MessageBox.Show("Đã cập nhật điểm thành công!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            gcMark.Enabled = false;
            groupControl1.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = true;
            addFlag = editFlag = false;

            return;
        }

        private void addMark(List<DataRow> list) {
            DataRow row;
            for (int i = 0; i < list.Count; i++) {
                row = list[i];
            kiemtra:
                diemStr = row["DIEM"].ToString();

                if (diemStr == "")// nếu điểm rỗng thì bỏ qua kh thêm
                {
                    continue;
                }

                try {
                    diemFl = float.Parse(diemStr);
                } catch (FormatException fe)  // nếu điểm kh đúng định dạng
                  {
                    if (MessageBox.Show("Điểm sinh viên " + row["HOTEN"].ToString() + " - " + row["MASV"].ToString() + " không đúng định dạng. Bạn có muốn nhập lại?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                        row["DIEM"] = Interaction.InputBox(row["HOTEN"].ToString() + " - " + row["MASV"].ToString(), "Nhập lại điểm", "0");
                        goto kiemtra;
                    } else {
                        continue;
                    }
                }

                if (diemFl < 0 || diemFl > 10)// nếu điểm kh hợp lệ
                {
                    if (MessageBox.Show(row["HOTEN"].ToString() + " - " + row["MASV"].ToString() + ": Điểm không hợp lệ. Bạn có muốn nhập lại điểm?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                        try {

                            row["DIEM"] = Interaction.InputBox(row["HOTEN"].ToString() + " - " + row["MASV"].ToString(), "Nhập lại điểm", "0");
                            goto kiemtra;
                        } catch (Exception ex) {
                            Console.WriteLine(ex.Message);
                            goto kiemtra;
                        }

                    } else {
                        continue;
                    }

                }
                cmd = string.Format("EXEC sp_nhapdiem N'{0}',{1},{2},{3}", row["MASV"].ToString(), this.maMonhoc, this.lanThi, float.Parse(diemStr));
                SqlDataReader reader = Program.ExecSqlDataReader(cmd);
                Program.conn.Close();
            }
        }

        private void updateMark(List<DataRow> list) {
            DataRow row;
            for (int i = 0; i < list.Count; i++) {

                row = list[i];
            kiemtra:
                diemStr = row["DIEM"].ToString();

                if (diemStr == "")// nếu điểm rỗng thì bỏ qua kh thêm
                {
                    continue;
                }

                try {
                    diemFl = float.Parse(diemStr);
                    if (diemFl == oldMark[i])// neu diem khong co su thay doi thi bo qua
                    {
                        continue;
                    }
                }
            // nếu điểm kh đúng định dạng
            catch (FormatException fe) {
                    if (MessageBox.Show("Điểm sinh viên " + row["HOTEN"].ToString() + " - " + row["MASV"].ToString() + " không đúng định dạng. Bạn có muốn nhập lại?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                        row["DIEM"] = Interaction.InputBox(row["HOTEN"].ToString() + " - " + row["MASV"].ToString(), "Nhập lại điểm", "0");
                        goto kiemtra;
                    } else {
                        continue;
                    }
                }
                // nếu điểm kh hợp lệ
                if (diemFl < 0 || diemFl > 10) {
                    //neu nguoi dung nhap lai diem
                    if (MessageBox.Show(row["HOTEN"].ToString() + " - " + row["MASV"].ToString() + ": Điểm không hợp lệ. Bạn có muốn nhập lại điểm?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                        try {

                            row["DIEM"] = Interaction.InputBox(row["HOTEN"].ToString() + " - " + row["MASV"].ToString(), "Nhập lại điểm", "0");
                            goto kiemtra;
                        } catch (Exception ex) {
                            Console.WriteLine(ex.Message);
                            goto kiemtra;
                        }
                        //khong nhap lai diem thi bo qua khong cap nhat
                    } else {
                        continue;
                    }

                }

                // thuc hien cap nhat
                cmd = string.Format("EXEC sp_cap_nhat_diem N'{0}',{1},{2},{3}", row["MASV"].ToString(), this.maMonhoc, this.lanThi, float.Parse(diemStr));
                SqlDataReader reader = Program.ExecSqlDataReader(cmd);
                Console.WriteLine("Da sua diem ban thu " + i);
                Program.conn.Close();


            }
        }
        //nút thêm
        private void BtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            prepareProcess();

            cmd = string.Format("EXEC sp_lay_sinh_vien_theo_lop N'{0}',{1},{2}", maLop, maMonhoc, lanThi);
            DataTable dt = Program.ExecSqlDataTable(cmd);
            dt.Columns[0].ReadOnly = dt.Columns[1].ReadOnly = true;
            for (int i = 0; i < dt.Rows.Count; i++) {
                if (dt.Rows[i][2].ToString() != "") {
                    dt.Rows[i].Delete();
                }
            }
            gcMark.DataSource = dt;
            if (gridView1.RowCount == 0) {
                MessageBox.Show("Lớp này đã nhập điểm. Nếu chỉnh sửa vui lòng chọn chức năng SỬA.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else {
                addFlag = true;
                gcMark.Enabled = true;
                btnSave.Enabled = true;
                groupControl1.Enabled = false;
                btnEdit.Enabled = false;
            }



        }

        private void CmbKhoa_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbKhoa.SelectedIndex == -1)
                return;

            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") {
                return;
            }
            Program.servername = cmbKhoa.SelectedValue.ToString();

            if (cmbKhoa.SelectedIndex != Program.mChinhanh) {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            } else {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.Connect() == 0) {
                MessageBox.Show("Lỗi kết nối khoa mới", "", MessageBoxButtons.OK);
            } else {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
                this.dS_SERVER1.EnforceConstraints = false;
                this.lOPTableAdapter.Fill(this.dS_SERVER1.LOP);
                tENLOPComboBox.SelectedIndex = 0;
            }


        }

        // nút thoát
        private void BarButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            this.Close();
        }

        // nút sửa
        private void BtnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            prepareProcess();
            cmd = string.Format("EXEC sp_lay_sinh_vien_theo_lop N'{0}',{1},{2}", maLop, maMonhoc, lanThi);
            DataTable dt = Program.ExecSqlDataTable(cmd);
            dt.Columns[0].ReadOnly = dt.Columns[1].ReadOnly = true;
            for (int i = 0; i < dt.Rows.Count; i++) {
                if (dt.Rows[i][2].ToString() == "") {
                    dt.Rows[i].Delete();
                } else {
                    oldMark.Add(Convert.ToSingle(dt.Rows[i][2]));
                    // Console.WriteLine(dt.Rows[i][2].GetType());
                }
            }
            gcMark.DataSource = dt;

            if (gridView1.RowCount == 0) {
                MessageBox.Show("Lớp này chưa nhập điểm. Vui lòng chọn chức năng nhập điểm để thêm điểm.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else {
                editFlag = true;
                gcMark.Enabled = true;
                btnSave.Enabled = true;
                groupControl1.Enabled = false;
                btnAdd.Enabled = false;
            }



        }



        // gán các giá trị ban đầu
        private void prepareProcess() {

            this.lanThi = cmbLanthi.SelectedIndex + 1;
            Console.WriteLine(lanThi);
            maMonhoc = tENMHComboBox.SelectedValue.ToString();
            Console.WriteLine(maMonhoc);
            maLop = tENLOPComboBox.SelectedValue.ToString();
            Console.WriteLine(maLop);


        }
    }
}
