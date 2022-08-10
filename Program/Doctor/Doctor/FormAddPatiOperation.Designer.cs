namespace Doctor
{
    partial class FormAddPatiOperation
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.patoprDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patoprIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patoprPatiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patoprDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patoprNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPatientOperationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientOperations = new Doctor.DataSetPatientOperations();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxPatiID = new System.Windows.Forms.ComboBox();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.tblPatientOperationsTableAdapter = new Doctor.DataSetPatientOperationsTableAdapters.tblPatientOperationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientOperationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת ניתוח למטופל";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "תז מטופל";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "תאריך";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ניתוח";
            // 
            // patoprDate
            // 
            this.patoprDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.patoprDate.Location = new System.Drawing.Point(89, 56);
            this.patoprDate.Name = "patoprDate";
            this.patoprDate.Size = new System.Drawing.Size(101, 20);
            this.patoprDate.TabIndex = 11;
            this.patoprDate.ValueChanged += new System.EventHandler(this.patoprDate_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patoprIDDataGridViewTextBoxColumn,
            this.patoprPatiIDDataGridViewTextBoxColumn,
            this.patoprDateDataGridViewTextBoxColumn,
            this.patoprNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientOperationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(443, 336);
            this.dataGridView1.TabIndex = 13;
            // 
            // patoprIDDataGridViewTextBoxColumn
            // 
            this.patoprIDDataGridViewTextBoxColumn.DataPropertyName = "patoprID";
            this.patoprIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.patoprIDDataGridViewTextBoxColumn.Name = "patoprIDDataGridViewTextBoxColumn";
            this.patoprIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patoprPatiIDDataGridViewTextBoxColumn
            // 
            this.patoprPatiIDDataGridViewTextBoxColumn.DataPropertyName = "patoprPatiID";
            this.patoprPatiIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.patoprPatiIDDataGridViewTextBoxColumn.Name = "patoprPatiIDDataGridViewTextBoxColumn";
            this.patoprPatiIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patoprDateDataGridViewTextBoxColumn
            // 
            this.patoprDateDataGridViewTextBoxColumn.DataPropertyName = "patoprDate";
            this.patoprDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.patoprDateDataGridViewTextBoxColumn.Name = "patoprDateDataGridViewTextBoxColumn";
            this.patoprDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patoprNameDataGridViewTextBoxColumn
            // 
            this.patoprNameDataGridViewTextBoxColumn.DataPropertyName = "patoprName";
            this.patoprNameDataGridViewTextBoxColumn.HeaderText = "שם ניתוח";
            this.patoprNameDataGridViewTextBoxColumn.Name = "patoprNameDataGridViewTextBoxColumn";
            this.patoprNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblPatientOperationsBindingSource
            // 
            this.tblPatientOperationsBindingSource.DataMember = "tblPatientOperations";
            this.tblPatientOperationsBindingSource.DataSource = this.dataSetPatientOperations;
            // 
            // dataSetPatientOperations
            // 
            this.dataSetPatientOperations.DataSetName = "DataSetPatientOperations";
            this.dataSetPatientOperations.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(185, 486);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "הוסף";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxPatiID
            // 
            this.comboBoxPatiID.FormattingEnabled = true;
            this.comboBoxPatiID.Location = new System.Drawing.Point(238, 58);
            this.comboBoxPatiID.Name = "comboBoxPatiID";
            this.comboBoxPatiID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxPatiID.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPatiID.TabIndex = 15;
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Location = new System.Drawing.Point(160, 95);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxOperation.Size = new System.Drawing.Size(100, 21);
            this.comboBoxOperation.TabIndex = 16;
            // 
            // tblPatientOperationsTableAdapter
            // 
            this.tblPatientOperationsTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddPatiOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 521);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.comboBoxPatiID);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.patoprDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormAddPatiOperation";
            this.Text = "FormAddPatiOperation";
            this.Load += new System.EventHandler(this.FormAddPatiOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientOperationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientOperations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker patoprDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn patoprVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxPatiID;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private DataSetPatientOperations dataSetPatientOperations;
        private System.Windows.Forms.BindingSource tblPatientOperationsBindingSource;
        private DataSetPatientOperationsTableAdapters.tblPatientOperationsTableAdapter tblPatientOperationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patoprIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patoprPatiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patoprDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patoprNameDataGridViewTextBoxColumn;
    }
}