namespace Doctor
{
    partial class FormAddPatiDrug
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
            this.patdrgIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdrgPatiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdrgDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdrgNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPatientDrugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientDrugs = new Doctor.DataSetPatientDrugs();
            this.patdrgDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPatiID = new System.Windows.Forms.ComboBox();
            this.comboBoxDrug = new System.Windows.Forms.ComboBox();
            this.tblPatientDrugsTableAdapter = new Doctor.DataSetPatientDrugsTableAdapters.tblPatientDrugsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientDrugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(190, 499);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "הוסף";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patdrgIDDataGridViewTextBoxColumn,
            this.patdrgPatiIDDataGridViewTextBoxColumn,
            this.patdrgDateDataGridViewTextBoxColumn,
            this.patdrgNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientDrugsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(447, 368);
            this.dataGridView1.TabIndex = 26;
            // 
            // patdrgIDDataGridViewTextBoxColumn
            // 
            this.patdrgIDDataGridViewTextBoxColumn.DataPropertyName = "patdrgID";
            this.patdrgIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.patdrgIDDataGridViewTextBoxColumn.Name = "patdrgIDDataGridViewTextBoxColumn";
            // 
            // patdrgPatiIDDataGridViewTextBoxColumn
            // 
            this.patdrgPatiIDDataGridViewTextBoxColumn.DataPropertyName = "patdrgPatiID";
            this.patdrgPatiIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.patdrgPatiIDDataGridViewTextBoxColumn.Name = "patdrgPatiIDDataGridViewTextBoxColumn";
            // 
            // patdrgDateDataGridViewTextBoxColumn
            // 
            this.patdrgDateDataGridViewTextBoxColumn.DataPropertyName = "patdrgDate";
            this.patdrgDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.patdrgDateDataGridViewTextBoxColumn.Name = "patdrgDateDataGridViewTextBoxColumn";
            // 
            // patdrgNameDataGridViewTextBoxColumn
            // 
            this.patdrgNameDataGridViewTextBoxColumn.DataPropertyName = "patdrgName";
            this.patdrgNameDataGridViewTextBoxColumn.HeaderText = "שם תרופה";
            this.patdrgNameDataGridViewTextBoxColumn.Name = "patdrgNameDataGridViewTextBoxColumn";
            // 
            // tblPatientDrugsBindingSource
            // 
            this.tblPatientDrugsBindingSource.DataMember = "tblPatientDrugs";
            this.tblPatientDrugsBindingSource.DataSource = this.dataSetPatientDrugs;
            // 
            // dataSetPatientDrugs
            // 
            this.dataSetPatientDrugs.DataSetName = "DataSetPatientDrugs";
            this.dataSetPatientDrugs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patdrgDate
            // 
            this.patdrgDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.patdrgDate.Location = new System.Drawing.Point(54, 49);
            this.patdrgDate.Name = "patdrgDate";
            this.patdrgDate.Size = new System.Drawing.Size(101, 20);
            this.patdrgDate.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "תרופה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "תאריך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "תז מטופל";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "הוספת תרופה למטופל";
            // 
            // comboBoxPatiID
            // 
            this.comboBoxPatiID.FormattingEnabled = true;
            this.comboBoxPatiID.Location = new System.Drawing.Point(244, 53);
            this.comboBoxPatiID.Name = "comboBoxPatiID";
            this.comboBoxPatiID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxPatiID.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPatiID.TabIndex = 28;
            // 
            // comboBoxDrug
            // 
            this.comboBoxDrug.FormattingEnabled = true;
            this.comboBoxDrug.Location = new System.Drawing.Point(143, 84);
            this.comboBoxDrug.Name = "comboBoxDrug";
            this.comboBoxDrug.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxDrug.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDrug.TabIndex = 28;
            // 
            // tblPatientDrugsTableAdapter
            // 
            this.tblPatientDrugsTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddPatiDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 534);
            this.Controls.Add(this.comboBoxDrug);
            this.Controls.Add(this.comboBoxPatiID);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.patdrgDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormAddPatiDrug";
            this.Text = "FormAddPatiDrug";
            this.Load += new System.EventHandler(this.FormAddPatiDrug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientDrugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientDrugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker patdrgDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdrgVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxPatiID;
        private System.Windows.Forms.ComboBox comboBoxDrug;
        private DataSetPatientDrugs dataSetPatientDrugs;
        private System.Windows.Forms.BindingSource tblPatientDrugsBindingSource;
        private DataSetPatientDrugsTableAdapters.tblPatientDrugsTableAdapter tblPatientDrugsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdrgIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdrgPatiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdrgDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdrgNameDataGridViewTextBoxColumn;
    }
}