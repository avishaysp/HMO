namespace Doctor
{
    partial class FormAddPatiDisease
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
            this.patdssIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdssPatiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdssDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdssNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPatientDiseasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientDiseases = new Doctor.DataSetPatientDiseases();
            this.patdssDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPatiID = new System.Windows.Forms.ComboBox();
            this.comboBoxDisease = new System.Windows.Forms.ComboBox();
            this.tblPatientDiseasesTableAdapter = new Doctor.DataSetPatientDiseasesTableAdapters.tblPatientDiseasesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientDiseasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientDiseases)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(195, 495);
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
            this.patdssIDDataGridViewTextBoxColumn,
            this.patdssPatiIDDataGridViewTextBoxColumn,
            this.patdssDateDataGridViewTextBoxColumn,
            this.patdssNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientDiseasesBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(454, 353);
            this.dataGridView1.TabIndex = 26;
            // 
            // patdssIDDataGridViewTextBoxColumn
            // 
            this.patdssIDDataGridViewTextBoxColumn.DataPropertyName = "patdssID";
            this.patdssIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.patdssIDDataGridViewTextBoxColumn.Name = "patdssIDDataGridViewTextBoxColumn";
            // 
            // patdssPatiIDDataGridViewTextBoxColumn
            // 
            this.patdssPatiIDDataGridViewTextBoxColumn.DataPropertyName = "patdssPatiID";
            this.patdssPatiIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.patdssPatiIDDataGridViewTextBoxColumn.Name = "patdssPatiIDDataGridViewTextBoxColumn";
            // 
            // patdssDateDataGridViewTextBoxColumn
            // 
            this.patdssDateDataGridViewTextBoxColumn.DataPropertyName = "patdssDate";
            this.patdssDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.patdssDateDataGridViewTextBoxColumn.Name = "patdssDateDataGridViewTextBoxColumn";
            // 
            // patdssNameDataGridViewTextBoxColumn
            // 
            this.patdssNameDataGridViewTextBoxColumn.DataPropertyName = "patdssName";
            this.patdssNameDataGridViewTextBoxColumn.HeaderText = "שם מחלה";
            this.patdssNameDataGridViewTextBoxColumn.Name = "patdssNameDataGridViewTextBoxColumn";
            // 
            // tblPatientDiseasesBindingSource
            // 
            this.tblPatientDiseasesBindingSource.DataMember = "tblPatientDiseases";
            this.tblPatientDiseasesBindingSource.DataSource = this.dataSetPatientDiseases;
            // 
            // dataSetPatientDiseases
            // 
            this.dataSetPatientDiseases.DataSetName = "DataSetPatientDiseases";
            this.dataSetPatientDiseases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patdssDate
            // 
            this.patdssDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.patdssDate.Location = new System.Drawing.Point(75, 66);
            this.patdssDate.Name = "patdssDate";
            this.patdssDate.Size = new System.Drawing.Size(101, 20);
            this.patdssDate.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "מחלה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "תאריך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "ת\"ז מטופל";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(110, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "הוספת מחלה למטופל";
            // 
            // comboBoxPatiID
            // 
            this.comboBoxPatiID.FormattingEnabled = true;
            this.comboBoxPatiID.Location = new System.Drawing.Point(247, 66);
            this.comboBoxPatiID.Name = "comboBoxPatiID";
            this.comboBoxPatiID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxPatiID.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPatiID.TabIndex = 28;
            // 
            // comboBoxDisease
            // 
            this.comboBoxDisease.FormattingEnabled = true;
            this.comboBoxDisease.Location = new System.Drawing.Point(152, 102);
            this.comboBoxDisease.Name = "comboBoxDisease";
            this.comboBoxDisease.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxDisease.Size = new System.Drawing.Size(101, 21);
            this.comboBoxDisease.TabIndex = 29;
            // 
            // tblPatientDiseasesTableAdapter
            // 
            this.tblPatientDiseasesTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddPatiDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 530);
            this.Controls.Add(this.comboBoxDisease);
            this.Controls.Add(this.comboBoxPatiID);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.patdssDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormAddPatiDisease";
            this.Text = "FormAddPatiDisease";
            this.Load += new System.EventHandler(this.FormAddPatiDisease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientDiseasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientDiseases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker patdssDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdssVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxPatiID;
        private System.Windows.Forms.ComboBox comboBoxDisease;
        private DataSetPatientDiseases dataSetPatientDiseases;
        private System.Windows.Forms.BindingSource tblPatientDiseasesBindingSource;
        private DataSetPatientDiseasesTableAdapters.tblPatientDiseasesTableAdapter tblPatientDiseasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdssIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdssPatiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdssDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdssNameDataGridViewTextBoxColumn;
    }
}