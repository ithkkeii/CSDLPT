using CSDLPT.Report;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT.ReportForm
{
    public partial class InPhieu_diem_ca_nhan : Form
    {
        private String tenPhanManh = string.Empty;
        private string tenServer = string.Empty;
        public InPhieu_diem_ca_nhan()
        {
            InitializeComponent();
        }

      

        private void InPhieu_diem_ca_nhan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_SERVER1.SINHVIEN' table. You can move, or remove it, as needed.
            
            tenPhanManh = ((DataRowView)Program.bds_dspm.Current)["TENPM"].ToString();
            tenServer = ((DataRowView)Program.bds_dspm.Current)["TENSERVER"].ToString();
            
            BindingSource bds_dsKhoa = new BindingSource();
            bds_dsKhoa.DataSource = Program.bds_dspm.DataSource;
            bds_dsKhoa.Filter = "TENPM <> 'PHÒNG KẾ TOÁN'";          
            cmbKhoa.DataSource = bds_dsKhoa.DataSource;
            cmbKhoa.DisplayMember = "TENPM";
            cmbKhoa.ValueMember = "TENSERVER";
            Console.WriteLine(cmbKhoa.SelectedIndex);
            cmbKhoa.SelectedIndex = Program.mChinhanh;
            cmbKhoa.Enabled = Program.mGroup.Equals("PGV");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Phieu_diem_ca_nhan pdcn = new Phieu_diem_ca_nhan(mASVComboBox.SelectedValue.ToString());
            pdcn.lblMasv.Text = mASVComboBox.SelectedValue.ToString();
          
            pdcn.lblTenlop.Text = this.tENLOPComboBox.Text;
            pdcn.lblTensinhvien.Text = hOTextEdit.Text + " " + tENTextEdit.Text;
            ReportPrintTool print = new ReportPrintTool(pdcn);
            print.ShowPreviewDialog();
        }

        private void CmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbKhoa.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Program.servername = cmbKhoa.SelectedValue.ToString();
            }

            if (cmbKhoa.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.Connect() == 0)
            {
                MessageBox.Show("Lỗi kết nối khoa mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
                this.dS_SERVER1.EnforceConstraints = false;
                this.lOPTableAdapter.Fill(this.dS_SERVER1.LOP);
                tENLOPComboBox.SelectedIndex = 0;
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dS_SERVER1.SINHVIEN);
                  tENLOPComboBox.SelectedIndex = 0;
            }
        }

     

        private void Button2_Click(object sender, EventArgs e)
        {
            Program.servername = tenServer;
            this.Close();
        }

        //private void FillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
