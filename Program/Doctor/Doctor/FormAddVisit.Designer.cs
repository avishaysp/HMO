namespace Doctor
{
    partial class FormAddVisit
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
            this.label2 = new System.Windows.Forms.Label();
            this.visitDate = new System.Windows.Forms.DateTimePicker();
            this.visitHour = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.visitNotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.visitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitpatiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblVisitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVisits = new Doctor.DataSetVisits();
            this.tblVisitsTableAdapter = new Doctor.DataSetVisitsTableAdapters.tblVisitsTableAdapter();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.visitpatiID = new System.Windows.Forms.ComboBox();
            this.dataSetPatients = new Doctor.DataSetPatients();
            this.tblPatientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPatientsTableAdapter = new Doctor.DataSetPatientsTableAdapters.tblPatientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "תז מטופל";
            // 
            // visitDate
            // 
            this.visitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.visitDate.Location = new System.Drawing.Point(302, 76);
            this.visitDate.Name = "visitDate";
            this.visitDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.visitDate.Size = new System.Drawing.Size(102, 20);
            this.visitDate.TabIndex = 4;
            // 
            // visitHour
            // 
            this.visitHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.visitHour.Location = new System.Drawing.Point(379, 103);
            this.visitHour.Name = "visitHour";
            this.visitHour.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.visitHour.Size = new System.Drawing.Size(102, 20);
            this.visitHour.TabIndex = 5;
            this.visitHour.Value = new System.DateTime(2016, 6, 23, 18, 9, 51, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "תאריך";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "שעה";
            // 
            // visitNotes
            // 
            this.visitNotes.Location = new System.Drawing.Point(12, 12);
            this.visitNotes.Multiline = true;
            this.visitNotes.Name = "visitNotes";
            this.visitNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.visitNotes.Size = new System.Drawing.Size(284, 114);
            this.visitNotes.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "הערות";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(373, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "הוספת ביקור";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitIDDataGridViewTextBoxColumn,
            this.visitpatiIDDataGridViewTextBoxColumn,
            this.visitDateDataGridViewTextBoxColumn,
            this.visitHourDataGridViewTextBoxColumn,
            this.visitNotesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblVisitsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(631, 223);
            this.dataGridView1.TabIndex = 11;
            // 
            // visitIDDataGridViewTextBoxColumn
            // 
            this.visitIDDataGridViewTextBoxColumn.DataPropertyName = "visitID";
            this.visitIDDataGridViewTextBoxColumn.HeaderText = "מספר ביקור";
            this.visitIDDataGridViewTextBoxColumn.Name = "visitIDDataGridViewTextBoxColumn";
            this.visitIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitpatiIDDataGridViewTextBoxColumn
            // 
            this.visitpatiIDDataGridViewTextBoxColumn.DataPropertyName = "visitpatiID";
            this.visitpatiIDDataGridViewTextBoxColumn.HeaderText = "תז מטופל";
            this.visitpatiIDDataGridViewTextBoxColumn.Name = "visitpatiIDDataGridViewTextBoxColumn";
            this.visitpatiIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitDateDataGridViewTextBoxColumn
            // 
            this.visitDateDataGridViewTextBoxColumn.DataPropertyName = "visitDate";
            this.visitDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.visitDateDataGridViewTextBoxColumn.Name = "visitDateDataGridViewTextBoxColumn";
            this.visitDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitHourDataGridViewTextBoxColumn
            // 
            this.visitHourDataGridViewTextBoxColumn.DataPropertyName = "visitHour";
            this.visitHourDataGridViewTextBoxColumn.HeaderText = "שעה";
            this.visitHourDataGridViewTextBoxColumn.Name = "visitHourDataGridViewTextBoxColumn";
            this.visitHourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitNotesDataGridViewTextBoxColumn
            // 
            this.visitNotesDataGridViewTextBoxColumn.DataPropertyName = "visitNotes";
            this.visitNotesDataGridViewTextBoxColumn.HeaderText = "הערות";
            this.visitNotesDataGridViewTextBoxColumn.Name = "visitNotesDataGridViewTextBoxColumn";
            this.visitNotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblVisitsBindingSource
            // 
            this.tblVisitsBindingSource.DataMember = "tblVisits";
            this.tblVisitsBindingSource.DataSource = this.dataSetVisits;
            // 
            // dataSetVisits
            // 
            this.dataSetVisits.DataSetName = "DataSetVisits";
            this.dataSetVisits.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblVisitsTableAdapter
            // 
            this.tblVisitsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(291, 361);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "הוסף";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // visitpatiID
            // 
            this.visitpatiID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblPatientsBindingSource, "patientID", true));
            this.visitpatiID.FormattingEnabled = true;
            this.visitpatiID.Location = new System.Drawing.Point(471, 76);
            this.visitpatiID.Name = "visitpatiID";
            this.visitpatiID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.visitpatiID.Size = new System.Drawing.Size(102, 21);
            this.visitpatiID.TabIndex = 13;
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
            // FormAddVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 396);
            this.Controls.Add(this.visitpatiID);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.visitNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.visitHour);
            this.Controls.Add(this.visitDate);
            this.Controls.Add(this.label2);
            this.Name = "FormAddVisit";
            this.Text = "FormAddVisit";
            this.Load += new System.EventHandler(this.FormAddVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker visitDate;
        private System.Windows.Forms.DateTimePicker visitHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox visitNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetVisits dataSetVisits;
        private System.Windows.Forms.BindingSource tblVisitsBindingSource;
        private DataSetVisitsTableAdapters.tblVisitsTableAdapter tblVisitsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitpatiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox visitpatiID;
        private DataSetPatients dataSetPatients;
        private System.Windows.Forms.BindingSource tblPatientsBindingSource;
        private DataSetPatientsTableAdapters.tblPatientsTableAdapter tblPatientsTableAdapter;
    }
}