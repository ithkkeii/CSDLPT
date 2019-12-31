namespace CSDLPT.ReportForm {
    partial class InPhieu_diem_ca_nhan {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tENLOPLabel = new System.Windows.Forms.Label();
            this.hOTENLabel = new System.Windows.Forms.Label();
            this.hOLabel = new System.Windows.Forms.Label();
            this.tENLabel = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dS_SERVER1 = new CSDLPT.DS_SERVER1();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new CSDLPT.DS_SERVER1TableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new CSDLPT.DS_SERVER1TableAdapters.TableAdapterManager();
            this.tENLOPComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINHVIENTableAdapter = new CSDLPT.DS_SERVER1TableAdapters.SINHVIENTableAdapter();
            this.mASVComboBox = new System.Windows.Forms.ComboBox();
            this.hOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_SERVER1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            this.tENLOPLabel.AutoSize = true;
            this.tENLOPLabel.Location = new System.Drawing.Point(234, 163);
            this.tENLOPLabel.Name = "tENLOPLabel";
            this.tENLOPLabel.Size = new System.Drawing.Size(34, 13);
            this.tENLOPLabel.TabIndex = 4;
            this.tENLOPLabel.Text = "LỚP :";
            // 
            // hOTENLabel
            // 
            this.hOTENLabel.AutoSize = true;
            this.hOTENLabel.Location = new System.Drawing.Point(182, 205);
            this.hOTENLabel.Name = "hOTENLabel";
            this.hOTENLabel.Size = new System.Drawing.Size(86, 13);
            this.hOTENLabel.TabIndex = 9;
            this.hOTENLabel.Text = "MÃ SINH VIÊN :";
            // 
            // hOLabel
            // 
            this.hOLabel.AutoSize = true;
            this.hOLabel.Location = new System.Drawing.Point(239, 248);
            this.hOLabel.Name = "hOLabel";
            this.hOLabel.Size = new System.Drawing.Size(29, 13);
            this.hOLabel.TabIndex = 10;
            this.hOLabel.Text = "HỌ :";
            // 
            // tENLabel
            // 
            this.tENLabel.AutoSize = true;
            this.tENLabel.Location = new System.Drawing.Point(421, 248);
            this.tENLabel.Name = "tENLabel";
            this.tENLabel.Size = new System.Drawing.Size(35, 13);
            this.tENLabel.TabIndex = 11;
            this.tENLabel.Text = "TÊN :";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(274, 113);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(307, 21);
            this.cmbKhoa.TabIndex = 0;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.CmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "IN PHIẾU ĐIỂM CÁ NHÂN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "KHOA :";
            // 
            // dS_SERVER1
            // 
            this.dS_SERVER1.DataSetName = "DS_SERVER1";
            this.dS_SERVER1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dS_SERVER1;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CSDLPT.DS_SERVER1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tENLOPComboBox
            // 
            this.tENLOPComboBox.DataSource = this.lOPBindingSource;
            this.tENLOPComboBox.DisplayMember = "TENLOP";
            this.tENLOPComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tENLOPComboBox.FormattingEnabled = true;
            this.tENLOPComboBox.Location = new System.Drawing.Point(274, 160);
            this.tENLOPComboBox.Name = "tENLOPComboBox";
            this.tENLOPComboBox.Size = new System.Drawing.Size(307, 21);
            this.tENLOPComboBox.TabIndex = 5;
            this.tENLOPComboBox.ValueMember = "MALOP";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "IN ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "THOÁT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "FK_SINHVIEN_LOP";
            this.sINHVIENBindingSource.DataSource = this.lOPBindingSource;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // mASVComboBox
            // 
            this.mASVComboBox.DataSource = this.sINHVIENBindingSource;
            this.mASVComboBox.DisplayMember = "MASV";
            this.mASVComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mASVComboBox.FormattingEnabled = true;
            this.mASVComboBox.Location = new System.Drawing.Point(274, 202);
            this.mASVComboBox.Name = "mASVComboBox";
            this.mASVComboBox.Size = new System.Drawing.Size(307, 21);
            this.mASVComboBox.TabIndex = 10;
            this.mASVComboBox.ValueMember = "MASV";
            // 
            // hOTextEdit
            // 
            this.hOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sINHVIENBindingSource, "HO", true));
            this.hOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "HO", true));
            this.hOTextEdit.Location = new System.Drawing.Point(274, 245);
            this.hOTextEdit.Name = "hOTextEdit";
            this.hOTextEdit.Properties.ReadOnly = true;
            this.hOTextEdit.Size = new System.Drawing.Size(116, 20);
            this.hOTextEdit.TabIndex = 11;
            // 
            // tENTextEdit
            // 
            this.tENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sINHVIENBindingSource, "TEN", true));
            this.tENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sINHVIENBindingSource, "TEN", true));
            this.tENTextEdit.Location = new System.Drawing.Point(462, 245);
            this.tENTextEdit.Name = "tENTextEdit";
            this.tENTextEdit.Properties.ReadOnly = true;
            this.tENTextEdit.Size = new System.Drawing.Size(119, 20);
            this.tENTextEdit.TabIndex = 12;
            // 
            // InPhieu_diem_ca_nhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.tENLabel);
            this.Controls.Add(this.tENTextEdit);
            this.Controls.Add(this.hOLabel);
            this.Controls.Add(this.hOTextEdit);
            this.Controls.Add(this.mASVComboBox);
            this.Controls.Add(this.hOTENLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tENLOPLabel);
            this.Controls.Add(this.tENLOPComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKhoa);
            this.Name = "InPhieu_diem_ca_nhan";
            this.Text = "InPhieu_diem_ca_nhan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InPhieu_diem_ca_nhan_FormClosing);
            this.Load += new System.EventHandler(this.InPhieu_diem_ca_nhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_SERVER1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DS_SERVER1 dS_SERVER1;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private DS_SERVER1TableAdapters.LOPTableAdapter lOPTableAdapter;
        private DS_SERVER1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox tENLOPComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private DS_SERVER1TableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.ComboBox mASVComboBox;
        private DevExpress.XtraEditors.TextEdit hOTextEdit;
        private DevExpress.XtraEditors.TextEdit tENTextEdit;
        private System.Windows.Forms.Label tENLOPLabel;
        private System.Windows.Forms.Label hOTENLabel;
        private System.Windows.Forms.Label hOLabel;
        private System.Windows.Forms.Label tENLabel;
    }
}