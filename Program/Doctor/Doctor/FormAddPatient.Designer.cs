namespace Doctor
{
    partial class FormAddPatient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.patFirstName = new System.Windows.Forms.TextBox();
            this.patLastName = new System.Windows.Forms.TextBox();
            this.patAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.patPhone = new System.Windows.Forms.TextBox();
            this.patMobile = new System.Windows.Forms.TextBox();
            this.patMail = new System.Windows.Forms.TextBox();
            this.patBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureLocation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
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
            this.tblPatientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatients = new Doctor.DataSetPatients();
            this.tblPatientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPatientsTableAdapter = new Doctor.DataSetPatientsTableAdapters.tblPatientsTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.patID = new System.Windows.Forms.TextBox();
            this.comboCity = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת מטופל";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(785, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "שם פרטי";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(785, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "שם משפחה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(785, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "תאריך לידה";
            // 
            // patFirstName
            // 
            this.patFirstName.Location = new System.Drawing.Point(655, 75);
            this.patFirstName.Name = "patFirstName";
            this.patFirstName.Size = new System.Drawing.Size(124, 20);
            this.patFirstName.TabIndex = 4;
            // 
            // patLastName
            // 
            this.patLastName.Location = new System.Drawing.Point(655, 101);
            this.patLastName.Name = "patLastName";
            this.patLastName.Size = new System.Drawing.Size(124, 20);
            this.patLastName.TabIndex = 4;
            // 
            // patAddress
            // 
            this.patAddress.Location = new System.Drawing.Point(579, 153);
            this.patAddress.Name = "patAddress";
            this.patAddress.Size = new System.Drawing.Size(200, 20);
            this.patAddress.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(785, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "כתובת";
            // 
            // patPhone
            // 
            this.patPhone.Location = new System.Drawing.Point(356, 101);
            this.patPhone.Name = "patPhone";
            this.patPhone.Size = new System.Drawing.Size(158, 20);
            this.patPhone.TabIndex = 6;
            // 
            // patMobile
            // 
            this.patMobile.Location = new System.Drawing.Point(356, 127);
            this.patMobile.Name = "patMobile";
            this.patMobile.Size = new System.Drawing.Size(158, 20);
            this.patMobile.TabIndex = 6;
            // 
            // patMail
            // 
            this.patMail.Location = new System.Drawing.Point(356, 153);
            this.patMail.Name = "patMail";
            this.patMail.Size = new System.Drawing.Size(158, 20);
            this.patMail.TabIndex = 6;
            // 
            // patBirthDate
            // 
            this.patBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.patBirthDate.Location = new System.Drawing.Point(579, 127);
            this.patBirthDate.Name = "patBirthDate";
            this.patBirthDate.Size = new System.Drawing.Size(200, 20);
            this.patBirthDate.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "עיר";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "טלפון";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(520, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "נייד";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(520, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "מייל";
            // 
            // pictureLocation
            // 
            this.pictureLocation.Location = new System.Drawing.Point(66, 49);
            this.pictureLocation.Name = "pictureLocation";
            this.pictureLocation.Size = new System.Drawing.Size(220, 20);
            this.pictureLocation.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "תמונה";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(23, 92);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 67);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "הוסף מטופל";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            this.dataGridView1.DataSource = this.tblPatientsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(847, 267);
            this.dataGridView1.TabIndex = 17;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "patientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "תז מטופל";
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
            // tblPatientsBindingSource1
            // 
            this.tblPatientsBindingSource1.DataMember = "tblPatients";
            this.tblPatientsBindingSource1.DataSource = this.dataSetPatients;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(785, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "תז מטופל";
            // 
            // patID
            // 
            this.patID.Location = new System.Drawing.Point(655, 49);
            this.patID.Name = "patID";
            this.patID.Size = new System.Drawing.Size(124, 20);
            this.patID.TabIndex = 19;
            // 
            // comboCity
            // 
            this.comboCity.FormattingEnabled = true;
            this.comboCity.Location = new System.Drawing.Point(356, 75);
            this.comboCity.Name = "comboCity";
            this.comboCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboCity.Size = new System.Drawing.Size(158, 21);
            this.comboCity.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(155, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(12, 41);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(48, 34);
            this.buttonBrowse.TabIndex = 22;
            this.buttonBrowse.Text = "...עיון";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // FormAddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 458);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboCity);
            this.Controls.Add(this.patID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureLocation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.patBirthDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.patMail);
            this.Controls.Add(this.patMobile);
            this.Controls.Add(this.patPhone);
            this.Controls.Add(this.patAddress);
            this.Controls.Add(this.patLastName);
            this.Controls.Add(this.patFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddPatient";
            this.Text = "FormAddPatient";
            this.Load += new System.EventHandler(this.FormAddPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patFirstName;
        private System.Windows.Forms.TextBox patLastName;
        private System.Windows.Forms.TextBox patAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox patPhone;
        private System.Windows.Forms.TextBox patMobile;
        private System.Windows.Forms.TextBox patMail;
        private System.Windows.Forms.DateTimePicker patBirthDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pictureLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.BindingSource tblPatientsBindingSource1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox patID;
        private System.Windows.Forms.ComboBox comboCity;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBrowse;
    }
}