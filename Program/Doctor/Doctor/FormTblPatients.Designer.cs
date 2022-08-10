namespace Doctor
{
    partial class FormTblPatients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPatientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatients = new Doctor.DataSetPatients();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tblPatientsTableAdapter = new Doctor.DataSetPatientsTableAdapters.tblPatientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.patientFirstNameDataGridViewTextBoxColumn,
            this.patientLastNameDataGridViewTextBoxColumn,
            this.patientBirthDateDataGridViewTextBoxColumn,
            this.patientAddressDataGridViewTextBoxColumn,
            this.patientCityDataGridViewTextBoxColumn,
            this.patientPhoneDataGridViewTextBoxColumn,
            this.patientMobileDataGridViewTextBoxColumn,
            this.patientMailDataGridViewTextBoxColumn,
            this.patientPictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(822, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "patientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "תז";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // patientFirstNameDataGridViewTextBoxColumn
            // 
            this.patientFirstNameDataGridViewTextBoxColumn.DataPropertyName = "patientFirstName";
            this.patientFirstNameDataGridViewTextBoxColumn.HeaderText = "שם פרטי";
            this.patientFirstNameDataGridViewTextBoxColumn.Name = "patientFirstNameDataGridViewTextBoxColumn";
            // 
            // patientLastNameDataGridViewTextBoxColumn
            // 
            this.patientLastNameDataGridViewTextBoxColumn.DataPropertyName = "patientLastName";
            this.patientLastNameDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.patientLastNameDataGridViewTextBoxColumn.Name = "patientLastNameDataGridViewTextBoxColumn";
            // 
            // patientBirthDateDataGridViewTextBoxColumn
            // 
            this.patientBirthDateDataGridViewTextBoxColumn.DataPropertyName = "patientBirthDate";
            this.patientBirthDateDataGridViewTextBoxColumn.HeaderText = "תאריך לידה";
            this.patientBirthDateDataGridViewTextBoxColumn.Name = "patientBirthDateDataGridViewTextBoxColumn";
            // 
            // patientAddressDataGridViewTextBoxColumn
            // 
            this.patientAddressDataGridViewTextBoxColumn.DataPropertyName = "patientAddress";
            this.patientAddressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.patientAddressDataGridViewTextBoxColumn.Name = "patientAddressDataGridViewTextBoxColumn";
            // 
            // patientCityDataGridViewTextBoxColumn
            // 
            this.patientCityDataGridViewTextBoxColumn.DataPropertyName = "patientCity";
            this.patientCityDataGridViewTextBoxColumn.HeaderText = "עיר";
            this.patientCityDataGridViewTextBoxColumn.Name = "patientCityDataGridViewTextBoxColumn";
            // 
            // patientPhoneDataGridViewTextBoxColumn
            // 
            this.patientPhoneDataGridViewTextBoxColumn.DataPropertyName = "patientPhone";
            this.patientPhoneDataGridViewTextBoxColumn.HeaderText = "טלפון";
            this.patientPhoneDataGridViewTextBoxColumn.Name = "patientPhoneDataGridViewTextBoxColumn";
            // 
            // patientMobileDataGridViewTextBoxColumn
            // 
            this.patientMobileDataGridViewTextBoxColumn.DataPropertyName = "patientMobile";
            this.patientMobileDataGridViewTextBoxColumn.HeaderText = "נייד";
            this.patientMobileDataGridViewTextBoxColumn.Name = "patientMobileDataGridViewTextBoxColumn";
            // 
            // patientMailDataGridViewTextBoxColumn
            // 
            this.patientMailDataGridViewTextBoxColumn.DataPropertyName = "patientMail";
            this.patientMailDataGridViewTextBoxColumn.HeaderText = "מייל";
            this.patientMailDataGridViewTextBoxColumn.Name = "patientMailDataGridViewTextBoxColumn";
            // 
            // patientPictureDataGridViewTextBoxColumn
            // 
            this.patientPictureDataGridViewTextBoxColumn.DataPropertyName = "patientPicture";
            this.patientPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.patientPictureDataGridViewTextBoxColumn.Name = "patientPictureDataGridViewTextBoxColumn";
            // 
            // tblPatientsBindingSource
            // 
            this.tblPatientsBindingSource.DataMember = "tblPatients";
            this.tblPatientsBindingSource.DataSource = this.dataSetPatients;
            // 
            // dataSetPatients
            // 
            this.dataSetPatients.DataSetName = "DataSetPatients";
            this.dataSetPatients.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(343, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "טבלת מטופלים";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblPatientsTableAdapter
            // 
            this.tblPatientsTableAdapter.ClearBeforeFill = true;
            // 
            // FormTblPatients
            // 
            this.ClientSize = new System.Drawing.Size(846, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblPatients";
            this.Text = "FormTblPatients";
            this.Load += new System.EventHandler(this.FormTblPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private DataSetPatients dataSetPatients;
        private System.Windows.Forms.BindingSource tblPatientsBindingSource;
        private DataSetPatientsTableAdapters.tblPatientsTableAdapter tblPatientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPictureDataGridViewTextBoxColumn;
    }
}