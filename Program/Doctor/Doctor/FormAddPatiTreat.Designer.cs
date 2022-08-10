namespace Doctor
{
    partial class FormAddPatiTreat
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
            this.pattrtIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattrtPatiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattrtDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattrtNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPatientTreatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientTreats = new Doctor.DataSetPatientTreats();
            this.pattrtDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPatiID = new System.Windows.Forms.ComboBox();
            this.comboBoxTreat = new System.Windows.Forms.ComboBox();
            this.tblPatientTreatsTableAdapter = new Doctor.DataSetPatientTreatsTableAdapters.tblPatientTreatsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientTreatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientTreats)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(166, 522);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 24);
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
            this.pattrtIDDataGridViewTextBoxColumn,
            this.pattrtPatiIdDataGridViewTextBoxColumn,
            this.pattrtDateDataGridViewTextBoxColumn,
            this.pattrtNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientTreatsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(426, 365);
            this.dataGridView1.TabIndex = 26;
            // 
            // pattrtIDDataGridViewTextBoxColumn
            // 
            this.pattrtIDDataGridViewTextBoxColumn.DataPropertyName = "pattrtID";
            this.pattrtIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.pattrtIDDataGridViewTextBoxColumn.Name = "pattrtIDDataGridViewTextBoxColumn";
            this.pattrtIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pattrtPatiIdDataGridViewTextBoxColumn
            // 
            this.pattrtPatiIdDataGridViewTextBoxColumn.DataPropertyName = "pattrtPatiId";
            this.pattrtPatiIdDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.pattrtPatiIdDataGridViewTextBoxColumn.Name = "pattrtPatiIdDataGridViewTextBoxColumn";
            this.pattrtPatiIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pattrtDateDataGridViewTextBoxColumn
            // 
            this.pattrtDateDataGridViewTextBoxColumn.DataPropertyName = "pattrtDate";
            this.pattrtDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.pattrtDateDataGridViewTextBoxColumn.Name = "pattrtDateDataGridViewTextBoxColumn";
            this.pattrtDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pattrtNameDataGridViewTextBoxColumn
            // 
            this.pattrtNameDataGridViewTextBoxColumn.DataPropertyName = "pattrtName";
            this.pattrtNameDataGridViewTextBoxColumn.HeaderText = "שם טיפול";
            this.pattrtNameDataGridViewTextBoxColumn.Name = "pattrtNameDataGridViewTextBoxColumn";
            this.pattrtNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblPatientTreatsBindingSource
            // 
            this.tblPatientTreatsBindingSource.DataMember = "tblPatientTreats";
            this.tblPatientTreatsBindingSource.DataSource = this.dataSetPatientTreats;
            // 
            // dataSetPatientTreats
            // 
            this.dataSetPatientTreats.DataSetName = "DataSetPatientTreats";
            this.dataSetPatientTreats.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pattrtDate
            // 
            this.pattrtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pattrtDate.Location = new System.Drawing.Point(71, 53);
            this.pattrtDate.Name = "pattrtDate";
            this.pattrtDate.Size = new System.Drawing.Size(101, 20);
            this.pattrtDate.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "טיפול";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "תאריך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "תז מטופל";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(83, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "הוספת טיפול למטופל";
            // 
            // comboBoxPatiID
            // 
            this.comboBoxPatiID.FormattingEnabled = true;
            this.comboBoxPatiID.Location = new System.Drawing.Point(260, 53);
            this.comboBoxPatiID.Name = "comboBoxPatiID";
            this.comboBoxPatiID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxPatiID.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPatiID.TabIndex = 28;
            // 
            // comboBoxTreat
            // 
            this.comboBoxTreat.FormattingEnabled = true;
            this.comboBoxTreat.Location = new System.Drawing.Point(142, 84);
            this.comboBoxTreat.Name = "comboBoxTreat";
            this.comboBoxTreat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxTreat.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTreat.TabIndex = 29;
            // 
            // tblPatientTreatsTableAdapter
            // 
            this.tblPatientTreatsTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddPatiTreat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 566);
            this.Controls.Add(this.comboBoxTreat);
            this.Controls.Add(this.comboBoxPatiID);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pattrtDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormAddPatiTreat";
            this.Text = "FormAddPatiTreat";
            this.Load += new System.EventHandler(this.FormAddPatiTreat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientTreatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientTreats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker pattrtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattrtVisitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxPatiID;
        private System.Windows.Forms.ComboBox comboBoxTreat;
        private DataSetPatientTreats dataSetPatientTreats;
        private System.Windows.Forms.BindingSource tblPatientTreatsBindingSource;
        private DataSetPatientTreatsTableAdapters.tblPatientTreatsTableAdapter tblPatientTreatsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattrtIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattrtPatiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattrtDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattrtNameDataGridViewTextBoxColumn;
    }
}