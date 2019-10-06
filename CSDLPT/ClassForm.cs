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
        }

        private void barButtonAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

        }

        private void ClassForm_Load(object sender, EventArgs e) {
            try {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'dS_SERVER1.KHOA' table. You can move, or remove it, as needed.
                this.kHOATableAdapter.Fill(this.dS_SERVER1.KHOA);
                // TODO: This line of code loads data into the 'dS_SERVER1.LOP' table. You can move, or remove it, as needed.
                this.lOPTableAdapter.Fill(this.dS_SERVER1.LOP);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}