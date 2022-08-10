namespace Doctor
{
    partial class FormTblPatientVaccines
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblPatientVaccinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientVaccines = new Doctor.DataSetPatientVaccines();
            this.tblPatientVaccinesTableAdapter = new Doctor.DataSetPatientVaccinesTableAdapters.tblPatientVaccinesTableAdapter();
            this.patvacIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patvacPatientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patvacDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patvacNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientVaccinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientVaccines)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(204, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "טבלת חיסונים למטופל";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patvacIDDataGridViewTextBoxColumn,
            this.patvacPatientIDDataGridViewTextBoxColumn,
            this.patvacDateDataGridViewTextBoxColumn,
            this.patvacNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientVaccinesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 92);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(788, 266);
            this.dataGridView1.TabIndex = 2;
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
            // tblPatientVaccinesTableAdapter
            // 
            this.tblPatientVaccinesTableAdapter.ClearBeforeFill = true;
            // 
            // patvacIDDataGridViewTextBoxColumn
            // 
            this.patvacIDDataGridViewTextBoxColumn.DataPropertyName = "patvacID";
            this.patvacIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.patvacIDDataGridViewTextBoxColumn.Name = "patvacIDDataGridViewTextBoxColumn";
            // 
            // patvacPatientIDDataGridViewTextBoxColumn
            // 
            this.patvacPatientIDDataGridViewTextBoxColumn.DataPropertyName = "patvacPatientID";
            this.patvacPatientIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.patvacPatientIDDataGridViewTextBoxColumn.Name = "patvacPatientIDDataGridViewTextBoxColumn";
            // 
            // patvacDateDataGridViewTextBoxColumn
            // 
            this.patvacDateDataGridViewTextBoxColumn.DataPropertyName = "patvacDate";
            this.patvacDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.patvacDateDataGridViewTextBoxColumn.Name = "patvacDateDataGridViewTextBoxColumn";
            // 
            // patvacNameDataGridViewTextBoxColumn
            // 
            this.patvacNameDataGridViewTextBoxColumn.DataPropertyName = "patvacName";
            this.patvacNameDataGridViewTextBoxColumn.HeaderText = "שם חיסון";
            this.patvacNameDataGridViewTextBoxColumn.Name = "patvacNameDataGridViewTextBoxColumn";
            // 
            // FormTblPatientVaccines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 409);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTblPatientVaccines";
            this.Text = "FormTblPatientVaccines";
            this.Load += new System.EventHandler(this.FormTblPatientVaccines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientVaccinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientVaccines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetPatientVaccines dataSetPatientVaccines;
        private System.Windows.Forms.BindingSource tblPatientVaccinesBindingSource;
        private DataSetPatientVaccinesTableAdapters.tblPatientVaccinesTableAdapter tblPatientVaccinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patvacIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patvacPatientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patvacDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patvacNameDataGridViewTextBoxColumn;
    }
}