namespace Doctor
{
    partial class FormAddPatiVaccine
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patvacIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patvacPatientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patvacDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patvacNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPatientVaccinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientVaccines = new Doctor.DataSetPatientVaccines();
            this.patvacDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patvacPatientID = new System.Windows.Forms.ComboBox();
            this.comboBoxVaccine = new System.Windows.Forms.ComboBox();
            this.tblPatientVaccinesTableAdapter = new Doctor.DataSetPatientVaccinesTableAdapters.tblPatientVaccinesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientVaccinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientVaccines)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(197, 480);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "הוסף";
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
            this.patvacIDDataGridViewTextBoxColumn,
            this.patvacPatientIDDataGridViewTextBoxColumn,
            this.patvacDateDataGridViewTextBoxColumn,
            this.patvacNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientVaccinesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(452, 361);
            this.dataGridView1.TabIndex = 26;
            // 
            // patvacIDDataGridViewTextBoxColumn
            // 
            this.patvacIDDataGridViewTextBoxColumn.DataPropertyName = "patvacID";
            this.patvacIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.patvacIDDataGridViewTextBoxColumn.Name = "patvacIDDataGridViewTextBoxColumn";
            this.patvacIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patvacPatientIDDataGridViewTextBoxColumn
            // 
            this.patvacPatientIDDataGridViewTextBoxColumn.DataPropertyName = "patvacPatientID";
            this.patvacPatientIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.patvacPatientIDDataGridViewTextBoxColumn.Name = "patvacPatientIDDataGridViewTextBoxColumn";
            this.patvacPatientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patvacDateDataGridViewTextBoxColumn
            // 
            this.patvacDateDataGridViewTextBoxColumn.DataPropertyName = "patvacDate";
            this.patvacDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.patvacDateDataGridViewTextBoxColumn.Name = "patvacDateDataGridViewTextBoxColumn";
            this.patvacDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patvacNameDataGridViewTextBoxColumn
            // 
            this.patvacNameDataGridViewTextBoxColumn.DataPropertyName = "patvacName";
            this.patvacNameDataGridViewTextBoxColumn.HeaderText = "שם חיסון";
            this.patvacNameDataGridViewTextBoxColumn.Name = "patvacNameDataGridViewTextBoxColumn";
            this.patvacNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblPatientVaccinesBindingSource
            // 
            this.tblPatientVaccinesBindingSource.DataMember = "tblPatientVaccines";
            this.tblPatientVaccinesBindingSource.DataSource = this.dataSetPatientVaccines;
            // 
            // dataSetPatientVaccines
            // 
            this.dataSetPatientVaccines.DataSetName = "DataSetPatientVaccines";
            this.dataSetPatientVaccines.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patvacDate
            // 
            this.patvacDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.patvacDate.Location = new System.Drawing.Point(71, 44);
            this.patvacDate.Name = "patvacDate";
            this.patvacDate.Size = new System.Drawing.Size(101, 20);
            this.patvacDate.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "חיסון";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "תאריך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "ת\"ז מטופל";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "הוספת חיסון למטופל";
            // 
            // patvacPatientID
            // 
            this.patvacPatientID.FormattingEnabled = true;
            this.patvacPatientID.Location = new System.Drawing.Point(234, 47);
            this.patvacPatientID.Name = "patvacPatientID";
            this.patvacPatientID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.patvacPatientID.Size = new System.Drawing.Size(100, 21);
            this.patvacPatientID.TabIndex = 28;
            // 
            // comboBoxVaccine
            // 
            this.comboBoxVaccine.FormattingEnabled = true;
            this.comboBoxVaccine.Location = new System.Drawing.Point(172, 86);
            this.comboBoxVaccine.Name = "comboBoxVaccine";
            this.comboBoxVaccine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxVaccine.Size = new System.Drawing.Size(100, 21);
            this.comboBoxVaccine.TabIndex = 29;
            // 
            // tblPatientVaccinesTableAdapter
            // 
            this.tblPatientVaccinesTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddPatiVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 515);
            this.Controls.Add(this.comboBoxVaccine);
            this.Controls.Add(this.patvacPatientID);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.patvacDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormAddPatiVaccine";
            this.Text = "FormAddPatiVaccine";
            this.Load += new System.EventHandler(this.FormAddPatiVaccnie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientVaccinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientVaccines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker patvacDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patvacVisitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox patvacPatientID;
        private System.Windows.Forms.ComboBox comboBoxVaccine;
        private DataSetPatientVaccines dataSetPatientVaccines;
        private System.Windows.Forms.BindingSource tblPatientVaccinesBindingSource;
        private DataSetPatientVaccinesTableAdapters.tblPatientVaccinesTableAdapter tblPatientVaccinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patvacIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patvacPatientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patvacDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patvacNameDataGridViewTextBoxColumn;
    }
}