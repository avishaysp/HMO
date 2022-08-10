namespace Doctor
{
    partial class FormRptDrugsOfPatient
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
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textboxPatientID = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSetPatients = new Doctor.DataSetPatients();
            this.tblPatientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPatientsTableAdapter = new Doctor.DataSetPatientsTableAdapters.tblPatientsTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(889, 123);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 132;
            this.buttonColor.Text = "בחר צבע";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(808, 123);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 133;
            this.buttonClear.Text = "נקה";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            // 
            // textboxPatientID
            // 
            this.textboxPatientID.Enabled = false;
            this.textboxPatientID.Location = new System.Drawing.Point(485, 61);
            this.textboxPatientID.Name = "textboxPatientID";
            this.textboxPatientID.Size = new System.Drawing.Size(100, 20);
            this.textboxPatientID.TabIndex = 130;
            this.textboxPatientID.TextChanged += new System.EventHandler(this.textboxPatientID_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(808, 151);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(409, 396);
            this.listView1.TabIndex = 129;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ת\"ז מטפל ";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "מספר מזהה";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "תאריך טיפול";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "שם טיפול רגיל";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "שם טיפול מדעי";
            this.columnHeader5.Width = 100;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(203, 122);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 128;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(365, 122);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 127;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(284, 122);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 126;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(446, 122);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 125;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(790, 396);
            this.dataGridView1.TabIndex = 124;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 123;
            this.label2.Text = "תז מטופל";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(431, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 33);
            this.label1.TabIndex = 122;
            this.label1.Text = "דוח תרופות למטופל";
            // 
            // dataSetPatients
            // 
            this.dataSetPatients.DataSetName = "DataSetPatients";
            this.dataSetPatients.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPatientsBindingSource
            // 
            this.tblPatientsBindingSource.DataMember = "tblPatients";
            this.tblPatientsBindingSource.DataSource = this.dataSetPatients;
            // 
            // tblPatientsTableAdapter
            // 
            this.tblPatientsTableAdapter.ClearBeforeFill = true;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "patientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "תז";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientFirstNameDataGridViewTextBoxColumn
            // 
            this.patientFirstNameDataGridViewTextBoxColumn.DataPropertyName = "patientFirstName";
            this.patientFirstNameDataGridViewTextBoxColumn.HeaderText = "שם פרטי";
            this.patientFirstNameDataGridViewTextBoxColumn.Name = "patientFirstNameDataGridViewTextBoxColumn";
            this.patientFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientLastNameDataGridViewTextBoxColumn
            // 
            this.patientLastNameDataGridViewTextBoxColumn.DataPropertyName = "patientLastName";
            this.patientLastNameDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.patientLastNameDataGridViewTextBoxColumn.Name = "patientLastNameDataGridViewTextBoxColumn";
            this.patientLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientBirthDateDataGridViewTextBoxColumn
            // 
            this.patientBirthDateDataGridViewTextBoxColumn.DataPropertyName = "patientBirthDate";
            this.patientBirthDateDataGridViewTextBoxColumn.HeaderText = "תאריך לידה";
            this.patientBirthDateDataGridViewTextBoxColumn.Name = "patientBirthDateDataGridViewTextBoxColumn";
            this.patientBirthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientAddressDataGridViewTextBoxColumn
            // 
            this.patientAddressDataGridViewTextBoxColumn.DataPropertyName = "patientAddress";
            this.patientAddressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.patientAddressDataGridViewTextBoxColumn.Name = "patientAddressDataGridViewTextBoxColumn";
            this.patientAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientCityDataGridViewTextBoxColumn
            // 
            this.patientCityDataGridViewTextBoxColumn.DataPropertyName = "patientCity";
            this.patientCityDataGridViewTextBoxColumn.HeaderText = "עיר";
            this.patientCityDataGridViewTextBoxColumn.Name = "patientCityDataGridViewTextBoxColumn";
            this.patientCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientPhoneDataGridViewTextBoxColumn
            // 
            this.patientPhoneDataGridViewTextBoxColumn.DataPropertyName = "patientPhone";
            this.patientPhoneDataGridViewTextBoxColumn.HeaderText = "טלפון";
            this.patientPhoneDataGridViewTextBoxColumn.Name = "patientPhoneDataGridViewTextBoxColumn";
            this.patientPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientMobileDataGridViewTextBoxColumn
            // 
            this.patientMobileDataGridViewTextBoxColumn.DataPropertyName = "patientMobile";
            this.patientMobileDataGridViewTextBoxColumn.HeaderText = "נייד";
            this.patientMobileDataGridViewTextBoxColumn.Name = "patientMobileDataGridViewTextBoxColumn";
            this.patientMobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientMailDataGridViewTextBoxColumn
            // 
            this.patientMailDataGridViewTextBoxColumn.DataPropertyName = "patientMail";
            this.patientMailDataGridViewTextBoxColumn.HeaderText = "מייל";
            this.patientMailDataGridViewTextBoxColumn.Name = "patientMailDataGridViewTextBoxColumn";
            this.patientMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientPictureDataGridViewTextBoxColumn
            // 
            this.patientPictureDataGridViewTextBoxColumn.DataPropertyName = "patientPicture";
            this.patientPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.patientPictureDataGridViewTextBoxColumn.Name = "patientPictureDataGridViewTextBoxColumn";
            this.patientPictureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormRptDrugsOfPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 557);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textboxPatientID);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRptDrugsOfPatient";
            this.Text = "FormRptDrugsOfPatient";
            this.Load += new System.EventHandler(this.FormRptDrugsOfPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textboxPatientID;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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