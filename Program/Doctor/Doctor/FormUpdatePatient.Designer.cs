namespace Doctor
{
    partial class FormUpdatePatient
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
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.patientPicture = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.patientMail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.patientMobile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.patientCity = new System.Windows.Forms.ComboBox();
            this.patientLastName = new System.Windows.Forms.TextBox();
            this.patientFirstName = new System.Windows.Forms.TextBox();
            this.patientID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patientAddress = new System.Windows.Forms.TextBox();
            this.patientBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.patientPhone = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tblPatientsTableAdapter = new Doctor.DataSetPatientsTableAdapters.tblPatientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(-206, 34);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(71, 105);
            this.buttonBrowse.TabIndex = 48;
            this.buttonBrowse.Text = "עיון";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(346, 162);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 80;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(427, 162);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 79;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(508, 162);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 78;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(589, 162);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 77;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(408, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 33);
            this.label12.TabIndex = 76;
            this.label12.Text = "עדכון מטופל";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 105);
            this.button1.TabIndex = 75;
            this.button1.Text = "עיון";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(463, 421);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 74;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(996, 224);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(89, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // patientPicture
            // 
            this.patientPicture.Location = new System.Drawing.Point(254, 81);
            this.patientPicture.Multiline = true;
            this.patientPicture.Name = "patientPicture";
            this.patientPicture.Size = new System.Drawing.Size(121, 70);
            this.patientPicture.TabIndex = 71;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(381, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "תמונה";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(569, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "מייל";
            // 
            // patientMail
            // 
            this.patientMail.Location = new System.Drawing.Point(442, 130);
            this.patientMail.Name = "patientMail";
            this.patientMail.Size = new System.Drawing.Size(121, 20);
            this.patientMail.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(569, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "נייד";
            // 
            // patientMobile
            // 
            this.patientMobile.Location = new System.Drawing.Point(442, 103);
            this.patientMobile.Name = "patientMobile";
            this.patientMobile.Size = new System.Drawing.Size(121, 20);
            this.patientMobile.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(718, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "עיר";
            // 
            // patientCity
            // 
            this.patientCity.FormattingEnabled = true;
            this.patientCity.Location = new System.Drawing.Point(612, 130);
            this.patientCity.Name = "patientCity";
            this.patientCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.patientCity.Size = new System.Drawing.Size(100, 21);
            this.patientCity.TabIndex = 59;
            // 
            // patientLastName
            // 
            this.patientLastName.Location = new System.Drawing.Point(796, 130);
            this.patientLastName.Name = "patientLastName";
            this.patientLastName.Size = new System.Drawing.Size(100, 20);
            this.patientLastName.TabIndex = 55;
            // 
            // patientFirstName
            // 
            this.patientFirstName.Location = new System.Drawing.Point(796, 104);
            this.patientFirstName.Name = "patientFirstName";
            this.patientFirstName.Size = new System.Drawing.Size(100, 20);
            this.patientFirstName.TabIndex = 54;
            // 
            // patientID
            // 
            this.patientID.Enabled = false;
            this.patientID.Location = new System.Drawing.Point(796, 77);
            this.patientID.Name = "patientID";
            this.patientID.Size = new System.Drawing.Size(100, 20);
            this.patientID.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(902, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "שם משפחה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(718, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "כתובת";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(902, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "שם פרטי";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(902, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "תז";
            // 
            // patientAddress
            // 
            this.patientAddress.Location = new System.Drawing.Point(612, 104);
            this.patientAddress.Name = "patientAddress";
            this.patientAddress.Size = new System.Drawing.Size(100, 20);
            this.patientAddress.TabIndex = 56;
            // 
            // patientBirthDate
            // 
            this.patientBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.patientBirthDate.Location = new System.Drawing.Point(612, 78);
            this.patientBirthDate.Name = "patientBirthDate";
            this.patientBirthDate.Size = new System.Drawing.Size(100, 20);
            this.patientBirthDate.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(718, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "תאריך לידה";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(569, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "טלפון";
            // 
            // patientPhone
            // 
            this.patientPhone.Location = new System.Drawing.Point(442, 77);
            this.patientPhone.Name = "patientPhone";
            this.patientPhone.Size = new System.Drawing.Size(121, 20);
            this.patientPhone.TabIndex = 84;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tblPatientsTableAdapter
            // 
            this.tblPatientsTableAdapter.ClearBeforeFill = true;
            // 
            // FormUpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 455);
            this.Controls.Add(this.patientPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.patientBirthDate);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.patientPicture);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.patientMail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.patientMobile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.patientCity);
            this.Controls.Add(this.patientAddress);
            this.Controls.Add(this.patientLastName);
            this.Controls.Add(this.patientFirstName);
            this.Controls.Add(this.patientID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowse);
            this.Name = "FormUpdatePatient";
            this.Text = "FormUpdatePatient";
            this.Load += new System.EventHandler(this.FormUpdatePatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox patientPicture;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox patientMail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox patientMobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox patientCity;
        private System.Windows.Forms.TextBox patientLastName;
        private System.Windows.Forms.TextBox patientFirstName;
        private System.Windows.Forms.TextBox patientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patientAddress;
        private System.Windows.Forms.DateTimePicker patientBirthDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox patientPhone;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
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